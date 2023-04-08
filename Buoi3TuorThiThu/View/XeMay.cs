using Buoi3TuorThiThu.Models;
using Buoi3TuorThiThu.Repo;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Buoi3TuorThiThu.View
{
    public partial class XeMay : Form
    {
        private XeMayRepo _xeMayRepo;
        private LoaiXeRepo _loaiXeRepo;
        private List<LoaiXe> _loaiXes;
        private int _idxemay;
        private validate _validate;
        public XeMay()
        {
            _validate = new();
            _xeMayRepo = new();
            _loaiXes = new();
            _loaiXeRepo = new();
            InitializeComponent();
        }

       

        private void bt_clear_Click(object sender, EventArgs e)
        {
            tb_search.Text = "";
            tb_gianhap.Text = "";
            tb_mota.Text = "";
            tb_ten.Text = "";
            cbb_loaixe.Text = "";
            cbb_soluong.SelectedIndex = 5;//Dùng để khi clear form sẽ chọn cbb vị trí số 5
        }

        private void XeMay_Load(object sender, EventArgs e)
        {
            for (int i = 1; i <= 100; i++)
            {
                cbb_soluong.Items.Add(i);
            }

            foreach (var item in _loaiXeRepo.GetLoaiXes())
            {
                _loaiXes.Add(item);
                cbb_loaixe.Items.Add(item.TenLoaiXe);
            }
        }

        private void bt_them_Click(object sender, EventArgs e)
        {
            if (_validate.CheckGia(tb_gianhap.Text))
            {
                int vitri = 0;
                if (_loaiXes[cbb_loaixe.SelectedIndex].Id != -1)
                {
                    vitri = _loaiXes[cbb_loaixe.SelectedIndex].Id;
                }
                

                Models.XeMay xeMay = new Models.XeMay()
                {
                    TenXe = tb_ten.Text,
                    MoTa = tb_mota.Text,
                    GiaNhap = int.Parse(tb_gianhap.Text),
                    SoLuong = int.Parse(cbb_soluong.Text),
                    IdLoaiXm = vitri//Lấy được Id của loại xe máy thông qua vị trí đã selected

                };//Do đặt trùng tên class với View nên mới cần chỉ rõ ra Fodel
                MessageBox.Show(_xeMayRepo.CreateXe(xeMay));
                bt_hienthi_Click(null, null);
            }
            else
            {
                MessageBox.Show("Giá nhập phải > 0 và là số nguyên");
            }
            
        }

        private void bt_xoa_Click(object sender, EventArgs e)
        {
            var thongbao = MessageBox.Show("Xác nhận xóa xe", "Thông báo", MessageBoxButtons.OKCancel);
            if (thongbao == DialogResult.OK)
            {
                MessageBox.Show(_xeMayRepo.DeleteXe(_idxemay));
            }
            bt_hienthi_Click(null, null);
        }

        private void dtgv_data_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            _idxemay = int.Parse(dtgv_data.CurrentRow.Cells[0].Value.ToString());//Dùng để lưu lại id dùng cho chứ năng xóa
            tb_ten.Text = dtgv_data.CurrentRow.Cells[2].Value.ToString();
            tb_mota.Text = dtgv_data.CurrentRow.Cells[3].Value == null ? "" : dtgv_data.CurrentRow.Cells[3].Value.ToString();//Do lúc đầu thêm để giá trị null
            tb_gianhap.Text = dtgv_data.CurrentRow.Cells[4].Value.ToString();
            cbb_soluong.Text = dtgv_data.CurrentRow.Cells[5].Value.ToString();
            cbb_loaixe.Text = dtgv_data.CurrentRow.Cells[6].Value.ToString();
        }
        private void bt_hienthi_Click(object sender, EventArgs e)
        {
            var loaixe = _loaiXeRepo.GetLoaiXes();
            var xemay = _xeMayRepo.GetAllXeMay();
            dtgv_data.Rows.Clear();
            dtgv_data.ColumnCount = 7;
            dtgv_data.Columns[0].Visible = false;//Dùng để lưu được id để dùng được chứ năng xóa
            dtgv_data.Columns[1].Name = "STT";
            dtgv_data.Columns[2].Name = "Tên xe";
            dtgv_data.Columns[3].Name = "Mô tả";
            dtgv_data.Columns[4].Name = "Giá nhập";
            dtgv_data.Columns[5].Name = "Số lượng";
            dtgv_data.Columns[6].Name = "Loại xe";

            int stt = 0;
            foreach (var item in _xeMayRepo.GetAllXeMay())
            {
                var tenloaixe = item.IdLoaiXm == null ? "Xe nhái": loaixe.FirstOrDefault(c => c.Id == item.IdLoaiXm).TenLoaiXe;
                stt++;
                dtgv_data.Rows.Add(item.Id, stt, item.TenXe, item.MoTa, item.GiaNhap, item.SoLuong, tenloaixe);
            }

        }
    }
}
