using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using TutorBuoiCuoi.Models;
using TutorBuoiCuoi.Repo;
using TutorBuoiCuoi.Utilities;

namespace TutorBuoiCuoi.View
{
    public partial class TutorBuoiCuoi : Form
    {
        SachRepo _sachRepo;
        Validated _validated;
        int _idsach;
        public TutorBuoiCuoi()
        {
            _validated = new();
            _sachRepo = new();
            InitializeComponent();
        }


        private void bt_clear_Click(object sender, EventArgs e)
        {
            tb_gia.Text = "";
            tb_ten.Text = "";
            tb_timkiem.Text = "";
            tb_nhaxb.Text = "";
            rbt_conhang.Checked = true;
            rbt_hethang.Checked = false;

        }

        private void bt_them_Click(object sender, EventArgs e)
        {
            if (_validated.Check(tb_gia.Text))
            {
                Sach sach = new Sach()
                {
                    TenSach = tb_ten.Text,
                    GiaSach = int.Parse(tb_gia.Text),
                    NhaXb = tb_nhaxb.Text,
                    TrangThai = rbt_conhang.Checked ? true : false
                };
                var add = MessageBox.Show("Bạn muốn thêm ?", "Xác nhận", MessageBoxButtons.OKCancel);
                if (add == DialogResult.OK)
                {
                    MessageBox.Show(_sachRepo.Create(sach));
                    TutorBuoiCuoi_Load(null, null);
                }
            }
            else
            {
                MessageBox.Show("Giá không hợp lệ");
            }
        }

        private void bt_xoa_Click(object sender, EventArgs e)
        {
            var delete = MessageBox.Show("Bạn muốn xóa ?", "Xác nhận", MessageBoxButtons.OKCancel);
            if (delete == DialogResult.OK)
            {
                MessageBox.Show(_sachRepo.Delete(_idsach));
                TutorBuoiCuoi_Load(null, null);
            }
        }

        private void dtgv_data_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            _idsach = int.Parse(dtgv_data.CurrentRow.Cells[0].Value.ToString());
            tb_ten.Text = dtgv_data.CurrentRow.Cells[3].Value.ToString();
            tb_gia.Text = dtgv_data.CurrentRow.Cells[4].Value.ToString();
            tb_nhaxb.Text = dtgv_data.CurrentRow.Cells[5].Value.ToString();
            if (dtgv_data.CurrentRow.Cells[6].Value.ToString() == "Còn hàng")
            {
                rbt_conhang.Checked = true;
                rbt_hethang.Checked = false;
            }
            else
            {
                rbt_conhang.Checked = false;
                rbt_hethang.Checked = true;
            }
        }
        private void TutorBuoiCuoi_Load(object sender, EventArgs e)
        {
            dtgv_data.Rows.Clear();
            dtgv_data.ColumnCount = 7;
            dtgv_data.Columns[0].Visible = false;
            dtgv_data.Columns[1].Name = "STT";
            dtgv_data.Columns[2].Name = "Mã";
            dtgv_data.Columns[3].Name = "Tên sách";
            dtgv_data.Columns[4].Name = "Giá sách";
            dtgv_data.Columns[5].Name = "Nhà xuất bản";
            dtgv_data.Columns[6].Name = "Trạng thái";
            int stt = 0;
            foreach (var item in _sachRepo.GetAll())
            {
                stt++;
                dtgv_data.Rows.Add(item.Id, stt, item.Ma, item.TenSach, item.GiaSach, item.NhaXb == null || item.NhaXb == "" ? "Sách nhái" : item.NhaXb, item.TrangThai ? "Còn hàng" : "Hết hàng");
            }
        }

        private void bt_sua_Click(object sender, EventArgs e)
        {
            if (_validated.Check(tb_gia.Text))
            {
                Sach sach = new Sach()
                {
                    Id = _idsach,
                    TenSach = tb_ten.Text,
                    GiaSach = int.Parse(tb_gia.Text),
                    NhaXb = tb_nhaxb.Text,
                    TrangThai = rbt_conhang.Checked ? true : false
                };
                var add = MessageBox.Show("Bạn muốn sửa ?", "Xác nhận", MessageBoxButtons.OKCancel);
                if (add == DialogResult.OK)
                {
                    MessageBox.Show(_sachRepo.Update(sach));
                    TutorBuoiCuoi_Load(null, null);
                }
            }
            else
            {
                MessageBox.Show("Giá không hợp lệ");
            }
        }

        private void tb_timkiem_TextChanged(object sender, EventArgs e)
        {
            if (tb_timkiem.Text == "")
            {
                TutorBuoiCuoi_Load(null, null);
            }
            else
            {
                dtgv_data.Rows.Clear();
                dtgv_data.ColumnCount = 7;
                dtgv_data.Columns[0].Visible = false;
                dtgv_data.Columns[1].Name = "STT";
                dtgv_data.Columns[2].Name = "Mã";
                dtgv_data.Columns[3].Name = "Tên sách";
                dtgv_data.Columns[4].Name = "Giá sách";
                dtgv_data.Columns[5].Name = "Nhà xuất bản";
                dtgv_data.Columns[6].Name = "Trạng thái";
                int stt = 0;
                foreach (var item in _sachRepo.GetAll().Where(c=>c.TenSach.Contains(tb_timkiem.Text)))
                {
                    stt++;
                    dtgv_data.Rows.Add(item.Id, stt, item.Ma, item.TenSach, item.GiaSach, item.NhaXb == null || item.NhaXb == "" ? "Sách nhái" : item.NhaXb, item.TrangThai ? "Còn hàng" : "Hết hàng");
                }
            }
        }
    }
}
