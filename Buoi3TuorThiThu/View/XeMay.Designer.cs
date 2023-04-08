namespace Buoi3TuorThiThu.View
{
    partial class XeMay
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            tb_ten = new TextBox();
            tb_mota = new TextBox();
            tb_gianhap = new TextBox();
            lb_tenxe = new Label();
            lb_mota = new Label();
            label3 = new Label();
            label4 = new Label();
            cbb_soluong = new ComboBox();
            bt_them = new Button();
            bt_xoa = new Button();
            bt_hienthi = new Button();
            bt_clear = new Button();
            gr_thongtin = new GroupBox();
            cbb_loaixe = new ComboBox();
            label1 = new Label();
            gr_chucNang = new GroupBox();
            gr_hienthi = new GroupBox();
            dtgv_data = new DataGridView();
            tb_search = new TextBox();
            label5 = new Label();
            gr_thongtin.SuspendLayout();
            gr_chucNang.SuspendLayout();
            gr_hienthi.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dtgv_data).BeginInit();
            SuspendLayout();
            // 
            // tb_ten
            // 
            tb_ten.Location = new Point(107, 40);
            tb_ten.Name = "tb_ten";
            tb_ten.Size = new Size(373, 27);
            tb_ten.TabIndex = 0;
            // 
            // tb_mota
            // 
            tb_mota.Location = new Point(107, 95);
            tb_mota.Name = "tb_mota";
            tb_mota.Size = new Size(373, 27);
            tb_mota.TabIndex = 1;
            // 
            // tb_gianhap
            // 
            tb_gianhap.Location = new Point(107, 143);
            tb_gianhap.Name = "tb_gianhap";
            tb_gianhap.Size = new Size(373, 27);
            tb_gianhap.TabIndex = 2;
            // 
            // lb_tenxe
            // 
            lb_tenxe.AutoSize = true;
            lb_tenxe.Location = new Point(22, 40);
            lb_tenxe.Name = "lb_tenxe";
            lb_tenxe.Size = new Size(51, 20);
            lb_tenxe.TabIndex = 3;
            lb_tenxe.Text = "Tên xe";
            // 
            // lb_mota
            // 
            lb_mota.AutoSize = true;
            lb_mota.Location = new Point(22, 95);
            lb_mota.Name = "lb_mota";
            lb_mota.Size = new Size(48, 20);
            lb_mota.TabIndex = 4;
            lb_mota.Text = "Mô tả";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(22, 146);
            label3.Name = "label3";
            label3.Size = new Size(68, 20);
            label3.TabIndex = 5;
            label3.Text = "Giá nhập";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(22, 257);
            label4.Name = "label4";
            label4.Size = new Size(69, 20);
            label4.TabIndex = 6;
            label4.Text = "Số lượng";
            // 
            // cbb_soluong
            // 
            cbb_soluong.FormattingEnabled = true;
            cbb_soluong.Location = new Point(107, 257);
            cbb_soluong.Name = "cbb_soluong";
            cbb_soluong.Size = new Size(373, 28);
            cbb_soluong.TabIndex = 7;
            // 
            // bt_them
            // 
            bt_them.Location = new Point(41, 37);
            bt_them.Name = "bt_them";
            bt_them.Size = new Size(173, 56);
            bt_them.TabIndex = 8;
            bt_them.Text = "Thêm";
            bt_them.UseVisualStyleBackColor = true;
            bt_them.Click += bt_them_Click;
            // 
            // bt_xoa
            // 
            bt_xoa.Location = new Point(41, 99);
            bt_xoa.Name = "bt_xoa";
            bt_xoa.Size = new Size(173, 57);
            bt_xoa.TabIndex = 9;
            bt_xoa.Text = "Xóa";
            bt_xoa.UseVisualStyleBackColor = true;
            bt_xoa.Click += bt_xoa_Click;
            // 
            // bt_hienthi
            // 
            bt_hienthi.Location = new Point(41, 162);
            bt_hienthi.Name = "bt_hienthi";
            bt_hienthi.Size = new Size(173, 56);
            bt_hienthi.TabIndex = 10;
            bt_hienthi.Text = "Hiển thị";
            bt_hienthi.UseVisualStyleBackColor = true;
            bt_hienthi.Click += bt_hienthi_Click;
            // 
            // bt_clear
            // 
            bt_clear.Location = new Point(41, 224);
            bt_clear.Name = "bt_clear";
            bt_clear.Size = new Size(173, 53);
            bt_clear.TabIndex = 11;
            bt_clear.Text = "Xóa Form";
            bt_clear.UseVisualStyleBackColor = true;
            bt_clear.Click += bt_clear_Click;
            // 
            // gr_thongtin
            // 
            gr_thongtin.Controls.Add(cbb_loaixe);
            gr_thongtin.Controls.Add(label1);
            gr_thongtin.Controls.Add(tb_ten);
            gr_thongtin.Controls.Add(tb_mota);
            gr_thongtin.Controls.Add(tb_gianhap);
            gr_thongtin.Controls.Add(lb_tenxe);
            gr_thongtin.Controls.Add(lb_mota);
            gr_thongtin.Controls.Add(cbb_soluong);
            gr_thongtin.Controls.Add(label3);
            gr_thongtin.Controls.Add(label4);
            gr_thongtin.Location = new Point(12, 12);
            gr_thongtin.Name = "gr_thongtin";
            gr_thongtin.Size = new Size(495, 292);
            gr_thongtin.TabIndex = 12;
            gr_thongtin.TabStop = false;
            gr_thongtin.Text = "Thông tin";
            // 
            // cbb_loaixe
            // 
            cbb_loaixe.FormattingEnabled = true;
            cbb_loaixe.Location = new Point(107, 200);
            cbb_loaixe.Name = "cbb_loaixe";
            cbb_loaixe.Size = new Size(373, 28);
            cbb_loaixe.TabIndex = 9;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(22, 200);
            label1.Name = "label1";
            label1.Size = new Size(56, 20);
            label1.TabIndex = 8;
            label1.Text = "Loại xe";
            // 
            // gr_chucNang
            // 
            gr_chucNang.Controls.Add(bt_them);
            gr_chucNang.Controls.Add(bt_clear);
            gr_chucNang.Controls.Add(bt_xoa);
            gr_chucNang.Controls.Add(bt_hienthi);
            gr_chucNang.Location = new Point(538, 12);
            gr_chucNang.Name = "gr_chucNang";
            gr_chucNang.Size = new Size(250, 292);
            gr_chucNang.TabIndex = 13;
            gr_chucNang.TabStop = false;
            gr_chucNang.Text = "Chức năng";
            // 
            // gr_hienthi
            // 
            gr_hienthi.Controls.Add(dtgv_data);
            gr_hienthi.Controls.Add(tb_search);
            gr_hienthi.Controls.Add(label5);
            gr_hienthi.Location = new Point(12, 307);
            gr_hienthi.Name = "gr_hienthi";
            gr_hienthi.Size = new Size(776, 227);
            gr_hienthi.TabIndex = 14;
            gr_hienthi.TabStop = false;
            gr_hienthi.Text = "HIển thị";
            // 
            // dtgv_data
            // 
            dtgv_data.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dtgv_data.Location = new Point(6, 72);
            dtgv_data.Name = "dtgv_data";
            dtgv_data.RowHeadersWidth = 51;
            dtgv_data.RowTemplate.Height = 29;
            dtgv_data.Size = new Size(764, 155);
            dtgv_data.TabIndex = 9;
            dtgv_data.CellClick += dtgv_data_CellClick;
            // 
            // tb_search
            // 
            tb_search.Location = new Point(154, 29);
            tb_search.Name = "tb_search";
            tb_search.Size = new Size(514, 27);
            tb_search.TabIndex = 8;
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Location = new Point(34, 32);
            label5.Name = "label5";
            label5.Size = new Size(70, 20);
            label5.TabIndex = 0;
            label5.Text = "Tìm kiếm";
            // 
            // XeMay
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 546);
            Controls.Add(gr_hienthi);
            Controls.Add(gr_chucNang);
            Controls.Add(gr_thongtin);
            Name = "XeMay";
            Text = "XeMay";
            Load += XeMay_Load;
            gr_thongtin.ResumeLayout(false);
            gr_thongtin.PerformLayout();
            gr_chucNang.ResumeLayout(false);
            gr_hienthi.ResumeLayout(false);
            gr_hienthi.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)dtgv_data).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private TextBox tb_ten;
        private TextBox tb_mota;
        private TextBox tb_gianhap;
        private Label lb_tenxe;
        private Label lb_mota;
        private Label label3;
        private Label label4;
        private ComboBox cbb_soluong;
        private Button bt_them;
        private Button bt_xoa;
        private Button bt_hienthi;
        private Button bt_clear;
        private GroupBox gr_thongtin;
        private GroupBox gr_chucNang;
        private GroupBox gr_hienthi;
        private DataGridView dtgv_data;
        private TextBox tb_search;
        private Label label5;
        private ComboBox cbb_loaixe;
        private Label label1;
    }
}