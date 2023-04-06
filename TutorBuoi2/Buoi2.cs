using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using TutorBuoi2.Models;
using TutorBuoi2.Repo;
using TutorBuoi2.Validate;
using static System.Windows.Forms.VisualStyles.VisualStyleElement.Button;

namespace TutorBuoi2
{
    public partial class Buoi2 : Form
    {
        private List<ChucVu> _chucVus;
        private ConNguoiRepo _cnrepo;
        private ChucVuRepo _cvrepo;
        private ValidateCheck _validate;
        private int _idconnguoi = 0;
        public Buoi2()
        {
            _chucVus = new List<ChucVu>();
            _validate = new ValidateCheck();
            _cnrepo = new ConNguoiRepo();
            _cvrepo = new ChucVuRepo();
            InitializeComponent();
        }

        private void bt_ten_Click(object sender, EventArgs e)
        {
            if (_validate.CheckSo(tb_tuoi.Text))
            {
                ConNguoi conNguoi = new ConNguoi()
                {
                    Ten = tb_name.Text,
                    Tuoi = int.Parse(tb_tuoi.Text),
                    DiaChi = tb_diaChi.Text,
                    GioiTinh = cbb_gioiTinh.Text,
                    IdChucVu = _chucVus[cbb_chucvu.SelectedIndex].Id
                    //IdChucVu = _cvrepo.GetChucVus().FirstOrDefault(c => c.ChucVu1 == cbb_chucvu.Text).Id //Không nên làm dễ lấy sai hoặc không lấy ra được id
                };
                MessageBox.Show(_cnrepo.Create(conNguoi));
                Buoi2_Load(null, null);
            }
            else
            {
                MessageBox.Show("Tuổi phải là số", "Cảnh báo");
            }
        }

        private void Buoi2_Load(object sender, EventArgs e)
        {
            dtv_data.Rows.Clear();
            dtv_data.ColumnCount = 7;

            dtv_data.Columns[0].Visible = false; // Dùng để có thể đẩy cả id lên dtgv để khi Sửa Xóa có thể lấy id từ trên dtgv xuống
            dtv_data.Columns[1].Name = "STT";
            dtv_data.Columns[2].Name = "Tên";
            dtv_data.Columns[3].Name = "Tuổi";
            dtv_data.Columns[4].Name = "Địa chỉ";
            dtv_data.Columns[5].Name = "Giới tính";
            dtv_data.Columns[6].Name = "Chức vụ";
            int stt = 0;
            foreach (var cn in _cnrepo.GetConNguois())
            {
                stt++;
                dtv_data.Rows.Add(cn.Id, stt, cn.Ten, cn.Tuoi, cn.DiaChi, cn.GioiTinh, cn.ChucVu);
            }
            cbb_gioiTinh.Items.Add("Nam");
            cbb_gioiTinh.Items.Add("Nữ");
            _chucVus = new List<ChucVu>();
            foreach (var cv in _cvrepo.GetChucVus())
            {
                _chucVus.Add(cv);

                cbb_chucvu.Items.Add(cv.ChucVu1);
            }
        }

        private void dtv_data_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            _idconnguoi = int.Parse(dtv_data.CurrentRow.Cells[0].Value.ToString());
            tb_name.Text = dtv_data.CurrentRow.Cells[2].Value.ToString();
            tb_tuoi.Text = dtv_data.CurrentRow.Cells[3].Value.ToString();
            tb_diaChi.Text = dtv_data.CurrentRow.Cells[4].Value.ToString();
            cbb_gioiTinh.Text = dtv_data.CurrentRow.Cells[5].Value.ToString();
            cbb_chucvu.Text = dtv_data.CurrentRow.Cells[6].Value.ToString();
        }

        private void bt_sua_Click(object sender, EventArgs e)
        {
            if (_validate.CheckSo(tb_tuoi.Text))
            {
                ConNguoi conNguoi = new ConNguoi()
                {
                    Id = _idconnguoi,
                    Ten = tb_name.Text,
                    Tuoi = int.Parse(tb_tuoi.Text),
                    DiaChi = tb_diaChi.Text,
                    GioiTinh = cbb_gioiTinh.Text,
                    IdChucVu = _chucVus[cbb_chucvu.SelectedIndex].Id
                    //IdChucVu = _cvrepo.GetChucVus().FirstOrDefault(c => c.ChucVu1 == cbb_chucvu.Text).Id //Không nên làm dễ lấy sai hoặc không lấy ra được id
                };
                MessageBox.Show(_cnrepo.Update(conNguoi));
                Buoi2_Load(null, null);
                _idconnguoi = 0;
            }
            else
            {
                MessageBox.Show("Tuổi phải là số", "Cảnh báo");
            }
        }

        private void bt_xoa_Click(object sender, EventArgs e)
        {
            if (_idconnguoi != 0)
            {
                MessageBox.Show(_cnrepo.Delete(_idconnguoi));
                Buoi2_Load(null, null);
            }
        }
    }
}
