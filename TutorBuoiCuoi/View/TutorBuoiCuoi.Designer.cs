namespace TutorBuoiCuoi.View
{
    partial class TutorBuoiCuoi
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
            groupBox1 = new GroupBox();
            label5 = new Label();
            rbt_hethang = new RadioButton();
            rbt_conhang = new RadioButton();
            label3 = new Label();
            label2 = new Label();
            label1 = new Label();
            tb_nhaxb = new TextBox();
            tb_gia = new TextBox();
            tb_ten = new TextBox();
            groupBox2 = new GroupBox();
            dtgv_data = new DataGridView();
            label4 = new Label();
            tb_timkiem = new TextBox();
            groupBox3 = new GroupBox();
            bt_clear = new Button();
            bt_xoa = new Button();
            bt_sua = new Button();
            bt_them = new Button();
            groupBox1.SuspendLayout();
            groupBox2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dtgv_data).BeginInit();
            groupBox3.SuspendLayout();
            SuspendLayout();
            // 
            // groupBox1
            // 
            groupBox1.Controls.Add(label5);
            groupBox1.Controls.Add(rbt_hethang);
            groupBox1.Controls.Add(rbt_conhang);
            groupBox1.Controls.Add(label3);
            groupBox1.Controls.Add(label2);
            groupBox1.Controls.Add(label1);
            groupBox1.Controls.Add(tb_nhaxb);
            groupBox1.Controls.Add(tb_gia);
            groupBox1.Controls.Add(tb_ten);
            groupBox1.Location = new Point(12, 12);
            groupBox1.Name = "groupBox1";
            groupBox1.Size = new Size(496, 241);
            groupBox1.TabIndex = 0;
            groupBox1.TabStop = false;
            groupBox1.Text = "Input";
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Location = new Point(36, 208);
            label5.Name = "label5";
            label5.Size = new Size(89, 25);
            label5.TabIndex = 8;
            label5.Text = "Trạng thái";
            // 
            // rbt_hethang
            // 
            rbt_hethang.AutoSize = true;
            rbt_hethang.Location = new Point(320, 206);
            rbt_hethang.Name = "rbt_hethang";
            rbt_hethang.Size = new Size(110, 29);
            rbt_hethang.TabIndex = 7;
            rbt_hethang.TabStop = true;
            rbt_hethang.Text = "Hết hàng";
            rbt_hethang.UseVisualStyleBackColor = true;
            // 
            // rbt_conhang
            // 
            rbt_conhang.AutoSize = true;
            rbt_conhang.Location = new Point(161, 206);
            rbt_conhang.Name = "rbt_conhang";
            rbt_conhang.Size = new Size(114, 29);
            rbt_conhang.TabIndex = 6;
            rbt_conhang.TabStop = true;
            rbt_conhang.Text = "Còn hàng";
            rbt_conhang.UseVisualStyleBackColor = true;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(36, 102);
            label3.Name = "label3";
            label3.Size = new Size(37, 25);
            label3.TabIndex = 5;
            label3.Text = "Giá";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(36, 162);
            label2.Name = "label2";
            label2.Size = new Size(117, 25);
            label2.TabIndex = 4;
            label2.Text = "Nhà xuất bản";
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(36, 48);
            label1.Name = "label1";
            label1.Size = new Size(38, 25);
            label1.TabIndex = 3;
            label1.Text = "Tên";
            // 
            // tb_nhaxb
            // 
            tb_nhaxb.Location = new Point(152, 156);
            tb_nhaxb.Name = "tb_nhaxb";
            tb_nhaxb.Size = new Size(292, 31);
            tb_nhaxb.TabIndex = 2;
            // 
            // tb_gia
            // 
            tb_gia.Location = new Point(152, 102);
            tb_gia.Name = "tb_gia";
            tb_gia.Size = new Size(292, 31);
            tb_gia.TabIndex = 1;
            // 
            // tb_ten
            // 
            tb_ten.Location = new Point(152, 42);
            tb_ten.Name = "tb_ten";
            tb_ten.Size = new Size(292, 31);
            tb_ten.TabIndex = 0;
            // 
            // groupBox2
            // 
            groupBox2.Controls.Add(dtgv_data);
            groupBox2.Controls.Add(label4);
            groupBox2.Controls.Add(tb_timkiem);
            groupBox2.Location = new Point(12, 251);
            groupBox2.Name = "groupBox2";
            groupBox2.Size = new Size(756, 252);
            groupBox2.TabIndex = 1;
            groupBox2.TabStop = false;
            groupBox2.Text = "Data";
            // 
            // dtgv_data
            // 
            dtgv_data.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dtgv_data.Location = new Point(27, 81);
            dtgv_data.Name = "dtgv_data";
            dtgv_data.RowHeadersWidth = 62;
            dtgv_data.RowTemplate.Height = 33;
            dtgv_data.Size = new Size(702, 165);
            dtgv_data.TabIndex = 7;
            dtgv_data.CellClick += dtgv_data_CellClick;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(18, 33);
            label4.Name = "label4";
            label4.Size = new Size(84, 25);
            label4.TabIndex = 6;
            label4.Text = "Tìm kiếm";
            // 
            // tb_timkiem
            // 
            tb_timkiem.Location = new Point(140, 30);
            tb_timkiem.Name = "tb_timkiem";
            tb_timkiem.Size = new Size(564, 31);
            tb_timkiem.TabIndex = 3;
            tb_timkiem.TextChanged += tb_timkiem_TextChanged;
            // 
            // groupBox3
            // 
            groupBox3.Controls.Add(bt_clear);
            groupBox3.Controls.Add(bt_xoa);
            groupBox3.Controls.Add(bt_sua);
            groupBox3.Controls.Add(bt_them);
            groupBox3.Location = new Point(514, 12);
            groupBox3.Name = "groupBox3";
            groupBox3.Size = new Size(274, 241);
            groupBox3.TabIndex = 1;
            groupBox3.TabStop = false;
            groupBox3.Text = "Control";
            // 
            // bt_clear
            // 
            bt_clear.Location = new Point(72, 182);
            bt_clear.Name = "bt_clear";
            bt_clear.Size = new Size(112, 51);
            bt_clear.TabIndex = 3;
            bt_clear.Text = "Clear";
            bt_clear.UseVisualStyleBackColor = true;
            bt_clear.Click += bt_clear_Click;
            // 
            // bt_xoa
            // 
            bt_xoa.Location = new Point(72, 125);
            bt_xoa.Name = "bt_xoa";
            bt_xoa.Size = new Size(112, 51);
            bt_xoa.TabIndex = 2;
            bt_xoa.Text = "Xóa";
            bt_xoa.UseVisualStyleBackColor = true;
            bt_xoa.Click += bt_xoa_Click;
            // 
            // bt_sua
            // 
            bt_sua.Location = new Point(72, 71);
            bt_sua.Name = "bt_sua";
            bt_sua.Size = new Size(112, 51);
            bt_sua.TabIndex = 1;
            bt_sua.Text = "Sửa";
            bt_sua.UseVisualStyleBackColor = true;
            bt_sua.Click += bt_sua_Click;
            // 
            // bt_them
            // 
            bt_them.Location = new Point(72, 22);
            bt_them.Name = "bt_them";
            bt_them.Size = new Size(112, 51);
            bt_them.TabIndex = 0;
            bt_them.Text = "Thêm";
            bt_them.UseVisualStyleBackColor = true;
            bt_them.Click += bt_them_Click;
            // 
            // TutorBuoiCuoi
            // 
            AutoScaleDimensions = new SizeF(10F, 25F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 515);
            Controls.Add(groupBox2);
            Controls.Add(groupBox3);
            Controls.Add(groupBox1);
            Name = "TutorBuoiCuoi";
            Text = "TutorBuoiCuoi";
            Load += TutorBuoiCuoi_Load;
            groupBox1.ResumeLayout(false);
            groupBox1.PerformLayout();
            groupBox2.ResumeLayout(false);
            groupBox2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)dtgv_data).EndInit();
            groupBox3.ResumeLayout(false);
            ResumeLayout(false);
        }

        #endregion

        private GroupBox groupBox1;
        private TextBox tb_nhaxb;
        private TextBox tb_gia;
        private TextBox tb_ten;
        private GroupBox groupBox2;
        private TextBox tb_timkiem;
        private GroupBox groupBox3;
        private Label label5;
        private RadioButton rbt_hethang;
        private RadioButton rbt_conhang;
        private Label label3;
        private Label label2;
        private Label label1;
        private DataGridView dtgv_data;
        private Label label4;
        private Button bt_clear;
        private Button bt_xoa;
        private Button bt_sua;
        private Button bt_them;
    }
}