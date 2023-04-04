using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using TutorBuoi1CSharp3.Models;
using TutorBuoi1CSharp3.Repo;

namespace TutorBuoi1CSharp3
{
    public partial class Buoi1 : Form
    {
        private NguoiDungRepo _nguoiDungRepo;
        private Validate _validate;
        private int _idNguoiDung;

        public Buoi1()
        {
            _nguoiDungRepo = new NguoiDungRepo();
            _validate = new Validate();
            InitializeComponent();
        }

        private void Buoi1_Load(object sender, EventArgs e)
        {
            var nguoiDungs = _nguoiDungRepo.GetAll();
            dtv_data.Rows.Clear();
            dtv_data.ColumnCount = 4;
            dtv_data.Columns[0].Name = "STT";
            dtv_data.Columns[1].Name = "Tên";
            dtv_data.Columns[2].Name = "Giới tính";
            dtv_data.Columns[3].Visible = false;

            int stt = 0;
            foreach (var nguoidung in nguoiDungs)
            {
                stt++;
                dtv_data.Rows.Add(stt, nguoidung.Ten, nguoidung.GiớiTính, nguoidung.Id);
            }
            cbb_gioitinh.Items.Add("Nam");
            cbb_gioitinh.Items.Add("Nữ");
        }

        private void bt_addName_Click(object sender, EventArgs e)
        {
            if (_validate.CheckNull(tb_name.Text))
            {
                var idmax = _nguoiDungRepo.GetAll().Max(c => c.Id);
                NguoiDung nguoiDung = new NguoiDung()
                {
                    Id = idmax + 1,
                    Ten = tb_name.Text,
                    GiớiTính = cbb_gioitinh.Text
                };
                MessageBox.Show(_nguoiDungRepo.AddNguoiDung(nguoiDung));

                Buoi1_Load(null, null);
            }
            else
            {
                MessageBox.Show("Vui lòng điền đầy đủ thông tin", "Thông báo");
            }
        }

        private void dtv_data_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            tb_name.Text = dtv_data.CurrentRow.Cells[1].Value.ToString();
            cbb_gioitinh.Text = dtv_data.CurrentRow.Cells[2].Value.ToString();
            _idNguoiDung = Convert.ToInt32(dtv_data.CurrentRow.Cells[3].Value);
        }

        private void bt_update_Click(object sender, EventArgs e)
        {
            if (_validate.CheckNull(tb_name.Text))
            {
                NguoiDung nguoiDung = new NguoiDung()
                {
                    Id = _idNguoiDung,
                    Ten = tb_name.Text,
                    GiớiTính = cbb_gioitinh.Text
                };
                MessageBox.Show(_nguoiDungRepo.UpdateNguoiDung(nguoiDung), "Thông báo");
                _idNguoiDung = 0;
                Buoi1_Load(null, null);
            }
            else
            {
                MessageBox.Show("Vui lòng điền đầy đủ thông tin", "Thông báo");
            }
        }

        private void bt_delete_Click(object sender, EventArgs e)
        {
            if (_idNguoiDung != 0)
            {
                var check = MessageBox.Show("Bạn xác nhận xóa người dùng", "Xác nhận", MessageBoxButtons.OKCancel);
                if (check == DialogResult.OK)
                {
                    _nguoiDungRepo.DeleteNguoiDung(_idNguoiDung);
                    Buoi1_Load(null, null);
                }

            }
        }
    }
}
