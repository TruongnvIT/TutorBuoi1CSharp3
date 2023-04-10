using Khangpg_thithu3.Models;
using Khangpg_thithu3.Reopo;
using Khangpg_thithu3.Utinities;

namespace Khangpg_thithu3
{
    public partial class Form1 : Form
    {
        private Validate _validate;
        private XeMayRepo _xeMayRepo;
        private int _idxm;
        public Form1()
        {
            _xeMayRepo = new();
            _validate = new();
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            dtgv_data.Rows.Clear();
            dtgv_data.ColumnCount = 6;

            dtgv_data.Columns[0].Visible = false;
            dtgv_data.Columns[1].Name = "STT";
            dtgv_data.Columns[2].Name = "Mã xe";
            dtgv_data.Columns[3].Name = "Tên xe";
            dtgv_data.Columns[4].Name = "Giá bán";
            dtgv_data.Columns[5].Name = "Trạng thái";

            int stt = 0;
            foreach (var xemay in _xeMayRepo.GetXeMays())
            {
                stt++;
                dtgv_data.Rows.Add(xemay.Id, stt, xemay.MaXe, xemay.TenXe, xemay.GiaBan, xemay.TrangThai == true ? "Mở bán" : "Dừng bán");
            }
        }

        private void bt_clear_Click(object sender, EventArgs e)
        {
            tb_timkiem.Text = "";
            tb_tenxe.Text = "";
            tb_maxe.Text = "";
            tb_giaban.Text = "";
            rbt_moban.Checked = true;
            rbt_dungban.Checked = false;
        }

        private void bt_them_Click(object sender, EventArgs e)
        {
            if (_validate.CheckGia(tb_giaban.Text))
            {
                var resutl = MessageBox.Show("Xác nhận thêm xe", "Xác nhận", MessageBoxButtons.YesNo);
                if (resutl == DialogResult.Yes)
                {
                    XeMay xeMay = new XeMay()
                    {
                        MaXe = tb_maxe.Text,
                        TenXe = tb_tenxe.Text,
                        GiaBan = int.Parse(tb_giaban.Text),
                        TrangThai = rbt_moban.Checked ? true : false
                    };
                    MessageBox.Show(_xeMayRepo.Create(xeMay));
                    Form1_Load(null, null);
                }
            }
            else
            {
                MessageBox.Show("Giá bán không được để trống và phải > 0");
            }
        }

        private void bt_sua_Click(object sender, EventArgs e)
        {
            if (_validate.CheckGia(tb_giaban.Text))
            {
                var resutl = MessageBox.Show("Xác nhận sửa xe", "Xác nhận", MessageBoxButtons.YesNo);
                if (resutl == DialogResult.Yes)
                {
                    XeMay xeMay = new XeMay()
                    {
                        Id = _idxm,
                        MaXe = tb_maxe.Text,
                        TenXe = tb_tenxe.Text,
                        GiaBan = int.Parse(tb_giaban.Text),
                        TrangThai = rbt_moban.Checked ? true : false
                    };
                    MessageBox.Show(_xeMayRepo.Update(xeMay));
                    Form1_Load(null, null);
                }
            }
            else
            {
                MessageBox.Show("Giá bán không được để trống và phải > 0");
            }
        }

        private void dtgv_data_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            _idxm = Convert.ToInt32(dtgv_data.CurrentRow.Cells[0].Value.ToString());
            tb_maxe.Text = dtgv_data.CurrentRow.Cells[2].Value.ToString();
            tb_tenxe.Text = dtgv_data.CurrentRow.Cells[3].Value.ToString();
            tb_giaban.Text = dtgv_data.CurrentRow.Cells[4].Value.ToString();
            if (Convert.ToString(dtgv_data.CurrentRow.Cells[5].Value) == "Mở bán")
            {
                rbt_dungban.Checked = false;
                rbt_moban.Checked = true;
            }
            else
            {
                rbt_dungban.Checked = true;
                rbt_moban.Checked = false;
            }
        }

        private void bt_xoa_Click(object sender, EventArgs e)
        {
            var resutl = MessageBox.Show("Xác nhận xóa xe", "Xác nhận", MessageBoxButtons.YesNo);
            if (resutl == DialogResult.Yes)
            {
                MessageBox.Show(_xeMayRepo.Delete(_idxm));
                Form1_Load(null, null);
            }
        }

        private void tb_timkiem_TextChanged(object sender, EventArgs e)
        {
            if (tb_timkiem.Text == "")
            {
                Form1_Load(null, null);
            }
            else
            {


                dtgv_data.Rows.Clear();
                dtgv_data.ColumnCount = 6;

                dtgv_data.Columns[0].Visible = false;
                dtgv_data.Columns[1].Name = "STT";
                dtgv_data.Columns[2].Name = "Mã xe";
                dtgv_data.Columns[3].Name = "Tên xe";
                dtgv_data.Columns[4].Name = "Giá bán";
                dtgv_data.Columns[5].Name = "Trạng thái";

                int stt = 0;
                foreach (var xemay in _xeMayRepo.GetXeMays().Where(c => !c.TenXe.Contains(tb_timkiem.Text)))
                {
                    stt++;
                    dtgv_data.Rows.Add(xemay.Id, stt, xemay.MaXe, xemay.TenXe, xemay.GiaBan, xemay.TrangThai == true ? "Mở bán" : "Dừng bán");
                }
            }

        }
    }
}