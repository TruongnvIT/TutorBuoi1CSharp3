namespace TutorBuoi2
{
    partial class Buoi2
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
            bt_ten = new Button();
            bt_sua = new Button();
            bt_xoa = new Button();
            tb_name = new TextBox();
            tb_tuoi = new TextBox();
            tb_diaChi = new TextBox();
            cbb_gioiTinh = new ComboBox();
            lb_name = new Label();
            lb_diaChi = new Label();
            lb_tuoi = new Label();
            lb_gioiTInh = new Label();
            dtv_data = new DataGridView();
            lb_chucvu = new Label();
            cbb_chucvu = new ComboBox();
            ((System.ComponentModel.ISupportInitialize)dtv_data).BeginInit();
            SuspendLayout();
            // 
            // bt_ten
            // 
            bt_ten.Location = new Point(650, 41);
            bt_ten.Name = "bt_ten";
            bt_ten.Size = new Size(94, 29);
            bt_ten.TabIndex = 0;
            bt_ten.Text = "Thêm";
            bt_ten.UseVisualStyleBackColor = true;
            bt_ten.Click += bt_ten_Click;
            // 
            // bt_sua
            // 
            bt_sua.Location = new Point(650, 105);
            bt_sua.Name = "bt_sua";
            bt_sua.Size = new Size(94, 29);
            bt_sua.TabIndex = 1;
            bt_sua.Text = "Sửa";
            bt_sua.UseVisualStyleBackColor = true;
            bt_sua.Click += bt_sua_Click;
            // 
            // bt_xoa
            // 
            bt_xoa.Location = new Point(650, 172);
            bt_xoa.Name = "bt_xoa";
            bt_xoa.Size = new Size(94, 29);
            bt_xoa.TabIndex = 2;
            bt_xoa.Text = "Xóa";
            bt_xoa.UseVisualStyleBackColor = true;
            bt_xoa.Click += bt_xoa_Click;
            // 
            // tb_name
            // 
            tb_name.Location = new Point(134, 55);
            tb_name.Name = "tb_name";
            tb_name.Size = new Size(125, 27);
            tb_name.TabIndex = 3;
            // 
            // tb_tuoi
            // 
            tb_tuoi.Location = new Point(410, 55);
            tb_tuoi.Name = "tb_tuoi";
            tb_tuoi.Size = new Size(125, 27);
            tb_tuoi.TabIndex = 4;
            // 
            // tb_diaChi
            // 
            tb_diaChi.Location = new Point(134, 113);
            tb_diaChi.Name = "tb_diaChi";
            tb_diaChi.Size = new Size(125, 27);
            tb_diaChi.TabIndex = 6;
            // 
            // cbb_gioiTinh
            // 
            cbb_gioiTinh.FormattingEnabled = true;
            cbb_gioiTinh.Location = new Point(410, 113);
            cbb_gioiTinh.Name = "cbb_gioiTinh";
            cbb_gioiTinh.Size = new Size(151, 28);
            cbb_gioiTinh.TabIndex = 7;
            // 
            // lb_name
            // 
            lb_name.AutoSize = true;
            lb_name.Location = new Point(59, 58);
            lb_name.Name = "lb_name";
            lb_name.Size = new Size(32, 20);
            lb_name.TabIndex = 8;
            lb_name.Text = "Tên";
            // 
            // lb_diaChi
            // 
            lb_diaChi.AutoSize = true;
            lb_diaChi.Location = new Point(59, 116);
            lb_diaChi.Name = "lb_diaChi";
            lb_diaChi.Size = new Size(55, 20);
            lb_diaChi.TabIndex = 9;
            lb_diaChi.Text = "Địa chỉ";
            // 
            // lb_tuoi
            // 
            lb_tuoi.AutoSize = true;
            lb_tuoi.Location = new Point(345, 58);
            lb_tuoi.Name = "lb_tuoi";
            lb_tuoi.Size = new Size(38, 20);
            lb_tuoi.TabIndex = 10;
            lb_tuoi.Text = "Tuổi";
            // 
            // lb_gioiTInh
            // 
            lb_gioiTInh.AutoSize = true;
            lb_gioiTInh.Location = new Point(339, 116);
            lb_gioiTInh.Name = "lb_gioiTInh";
            lb_gioiTInh.Size = new Size(65, 20);
            lb_gioiTInh.TabIndex = 11;
            lb_gioiTInh.Text = "Giới tính";
            // 
            // dtv_data
            // 
            dtv_data.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dtv_data.Location = new Point(12, 224);
            dtv_data.Name = "dtv_data";
            dtv_data.RowHeadersWidth = 51;
            dtv_data.RowTemplate.Height = 29;
            dtv_data.Size = new Size(761, 214);
            dtv_data.TabIndex = 12;
            dtv_data.CellClick += dtv_data_CellClick;
            // 
            // lb_chucvu
            // 
            lb_chucvu.AutoSize = true;
            lb_chucvu.Location = new Point(174, 180);
            lb_chucvu.Name = "lb_chucvu";
            lb_chucvu.Size = new Size(61, 20);
            lb_chucvu.TabIndex = 14;
            lb_chucvu.Text = "Chức vụ";
            // 
            // cbb_chucvu
            // 
            cbb_chucvu.FormattingEnabled = true;
            cbb_chucvu.Location = new Point(253, 177);
            cbb_chucvu.Name = "cbb_chucvu";
            cbb_chucvu.Size = new Size(151, 28);
            cbb_chucvu.TabIndex = 15;
            // 
            // Buoi2
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(cbb_chucvu);
            Controls.Add(lb_chucvu);
            Controls.Add(dtv_data);
            Controls.Add(lb_gioiTInh);
            Controls.Add(lb_tuoi);
            Controls.Add(lb_diaChi);
            Controls.Add(lb_name);
            Controls.Add(cbb_gioiTinh);
            Controls.Add(tb_diaChi);
            Controls.Add(tb_tuoi);
            Controls.Add(tb_name);
            Controls.Add(bt_xoa);
            Controls.Add(bt_sua);
            Controls.Add(bt_ten);
            Name = "Buoi2";
            Text = "Buoi2";
            Load += Buoi2_Load;
            ((System.ComponentModel.ISupportInitialize)dtv_data).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Button bt_ten;
        private Button bt_sua;
        private Button bt_xoa;
        private TextBox tb_name;
        private TextBox tb_tuoi;
        private TextBox tb_diaChi;
        private ComboBox cbb_gioiTinh;
        private Label lb_name;
        private Label lb_diaChi;
        private Label lb_tuoi;
        private Label lb_gioiTInh;
        private DataGridView dtv_data;
        private Label lb_chucvu;
        private ComboBox cbb_chucvu;
    }
}