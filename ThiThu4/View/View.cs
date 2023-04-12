using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using ThiThu4.Models;
using ThiThu4.Repo;
using ThiThu4.Utilities;

namespace ThiThu4.View
{
    public partial class View : Form
    {
        private Validated _validated;
        private XeMayRepo _xeMayRepo;
        private HangXRepo _hangXRepo;
        private List<HangXe> _hangXes;
        private int _idXemay;
        public View()
        {
            _validated = new();
            _hangXes = new();
            _hangXRepo = new();
            _xeMayRepo = new();
            InitializeComponent();
        }

        private void View_Load(object sender, EventArgs e)
        {
            dtgv_data.Rows.Clear();
            dtgv_data.ColumnCount = 6;

            dtgv_data.Columns[0].Visible = false;
            dtgv_data.Columns[1].Name = "STT";
            dtgv_data.Columns[2].Name = "Mã";
            dtgv_data.Columns[3].Name = "Tên";
            dtgv_data.Columns[4].Name = "Giá";
            dtgv_data.Columns[5].Name = "Hãng";
            int stt = 0;
            foreach (var item in _xeMayRepo.GetAll())
            {
                var hangxe = _hangXRepo.GetAll().FirstOrDefault(c => c.Id == item.IdHangXe);
                stt++;
                dtgv_data.Rows.Add(item.Id, stt,item.MaXe, item.TenXe,  item.GiaBan, hangxe.TenHangXe);//dùng dynamic thì đổi hangxe.TenHangXe thành item.Hang
            }

            cbb_hang.Items.Clear();//Clear cho đỡ bị trồng

            foreach (var item in _hangXRepo.GetAll())
            {
                _hangXes.Add(item);
                cbb_hang.Items.Add(item.TenHangXe);
            }            
        }

        private void bt_clear_Click(object sender, EventArgs e)
        {
            tb_ten.Text = "";
            tb_gia.Text = "";
            cbb_hang.Text = "";
            tb_timkiem.Text = "";
        }

        private void bt_them_Click(object sender, EventArgs e)
        {
            if (_validated.Check(tb_gia.Text))
            {
                string ma = "";
                for (int i = 0; i < tb_ten.Text.Length; i++)
                {
                    tb_ten.Text = tb_ten.Text.Trim();
                    if (i == 0)
                    {
                        ma = ma + tb_ten.Text.Substring(i, 1);//Cắt 1 kí tự từ kí tự có vị trí thứ i
                    }
                    if (tb_ten.Text[i].ToString() == " ")
                    {
                        ma = ma + tb_ten.Text.Substring(i + 1, 1);
                    }
                }
                XeMay xeMay = new XeMay()
                {
                    TenXe = tb_ten.Text,
                    MaXe = ma,
                    GiaBan = int.Parse(tb_gia.Text),
                    IdHangXe = _hangXes[cbb_hang.SelectedIndex].Id
                };
                var resutl = MessageBox.Show("Xác nhận thêm", "Xác nhận", MessageBoxButtons.YesNo);
                if (resutl == DialogResult.Yes)
                {
                    MessageBox.Show(_xeMayRepo.Create(xeMay));
                    View_Load(null, null);
                }
            }
            else
            {
                MessageBox.Show("Giá không hợp lệ");
            }
        }

        private void dtgv_data_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            _idXemay = int.Parse(dtgv_data.CurrentRow.Cells[0].Value.ToString());
            tb_ten.Text = dtgv_data.CurrentRow.Cells[3].Value.ToString();
            tb_gia.Text = dtgv_data.CurrentRow.Cells[4].Value.ToString();
            cbb_hang.Text = dtgv_data.CurrentRow.Cells[5].Value.ToString();

        }

        private void bt_sua_Click(object sender, EventArgs e)
        {
            if (_validated.Check(tb_gia.Text))
            {
                XeMay xeMay = new XeMay()
                {
                    Id = _idXemay,
                    TenXe = tb_ten.Text,
                    GiaBan = int.Parse(tb_gia.Text),
                    IdHangXe = _hangXes[cbb_hang.SelectedIndex].Id,
                };
                var resutl = MessageBox.Show("Xác nhận sửa", "Xác nhận ", MessageBoxButtons.YesNo);
                if (resutl == DialogResult.Yes)
                {
                    MessageBox.Show(_xeMayRepo.Update(xeMay));
                    View_Load(null, null);
                }
            }
            else
            {
                MessageBox.Show("Giá không hợp lệ");
            }
        }

        private void bt_xoa_Click(object sender, EventArgs e)
        {
            var resutl = MessageBox.Show("Xác nhận xóa", "Xác nhận ", MessageBoxButtons.YesNo);
            if (resutl == DialogResult.Yes)
            {
                MessageBox.Show(_xeMayRepo.Delete(_idXemay));
                View_Load(null, null);
            }
        }

        private void tb_timkiem_TextChanged(object sender, EventArgs e)
        {
            //if (tb_timkiem.Text == "")
            //{
            //    View_Load(null, null);
            //}
            //else
            //{
            //    dtgv_data.Rows.Clear();
            //    dtgv_data.ColumnCount = 6;

            //    dtgv_data.Columns[0].Visible = false;
            //    dtgv_data.Columns[1].Name = "STT";
            //    dtgv_data.Columns[2].Name = "Mã";
            //    dtgv_data.Columns[3].Name = "Tên";
            //    dtgv_data.Columns[4].Name = "Giá";
            //    dtgv_data.Columns[5].Name = "Hãng";
            //    int stt = 0;
            //    foreach (var item in _xeMayRepo.GetAll(tb_timkiem.Text))
            //    {
            //        stt++;
            //        dtgv_data.Rows.Add(item.Id, stt,  item.Ma,item.Ten, item.Gia, item.Hang);
            //    }
            //}
            
        }
    }
}
