namespace ThiThu4.View
{
    partial class View
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
            groupBox2 = new GroupBox();
            bt_clear = new Button();
            bt_xoa = new Button();
            bt_sua = new Button();
            bt_them = new Button();
            groupBox3 = new GroupBox();
            dtgv_data = new DataGridView();
            label4 = new Label();
            tb_timkiem = new TextBox();
            groupBox1 = new GroupBox();
            dataGridView1 = new DataGridView();
            label3 = new Label();
            label2 = new Label();
            label1 = new Label();
            cbb_hang = new ComboBox();
            tb_gia = new TextBox();
            tb_ten = new TextBox();
            groupBox2.SuspendLayout();
            groupBox3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dtgv_data).BeginInit();
            groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dataGridView1).BeginInit();
            SuspendLayout();
            // 
            // groupBox2
            // 
            groupBox2.Controls.Add(bt_clear);
            groupBox2.Controls.Add(bt_xoa);
            groupBox2.Controls.Add(bt_sua);
            groupBox2.Controls.Add(bt_them);
            groupBox2.Location = new Point(544, 12);
            groupBox2.Name = "groupBox2";
            groupBox2.Size = new Size(250, 242);
            groupBox2.TabIndex = 4;
            groupBox2.TabStop = false;
            groupBox2.Text = "groupBox2";
            // 
            // bt_clear
            // 
            bt_clear.Location = new Point(56, 186);
            bt_clear.Name = "bt_clear";
            bt_clear.Size = new Size(144, 50);
            bt_clear.TabIndex = 3;
            bt_clear.Text = "Clear";
            bt_clear.UseVisualStyleBackColor = true;
            bt_clear.Click += bt_clear_Click;
            // 
            // bt_xoa
            // 
            bt_xoa.Location = new Point(56, 131);
            bt_xoa.Name = "bt_xoa";
            bt_xoa.Size = new Size(144, 50);
            bt_xoa.TabIndex = 2;
            bt_xoa.Text = "Xóa";
            bt_xoa.UseVisualStyleBackColor = true;
            bt_xoa.Click += bt_xoa_Click;
            // 
            // bt_sua
            // 
            bt_sua.Location = new Point(56, 77);
            bt_sua.Name = "bt_sua";
            bt_sua.Size = new Size(144, 50);
            bt_sua.TabIndex = 1;
            bt_sua.Text = "Sửa";
            bt_sua.UseVisualStyleBackColor = true;
            bt_sua.Click += bt_sua_Click;
            // 
            // bt_them
            // 
            bt_them.Location = new Point(56, 28);
            bt_them.Name = "bt_them";
            bt_them.Size = new Size(144, 50);
            bt_them.TabIndex = 0;
            bt_them.Text = "Thêm";
            bt_them.UseVisualStyleBackColor = true;
            bt_them.Click += bt_them_Click;
            // 
            // groupBox3
            // 
            groupBox3.Controls.Add(dtgv_data);
            groupBox3.Controls.Add(label4);
            groupBox3.Controls.Add(tb_timkiem);
            groupBox3.Location = new Point(6, 260);
            groupBox3.Name = "groupBox3";
            groupBox3.Size = new Size(776, 232);
            groupBox3.TabIndex = 3;
            groupBox3.TabStop = false;
            groupBox3.Text = "groupBox3";
            // 
            // dtgv_data
            // 
            dtgv_data.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dtgv_data.Location = new Point(6, 83);
            dtgv_data.Name = "dtgv_data";
            dtgv_data.RowHeadersWidth = 51;
            dtgv_data.RowTemplate.Height = 29;
            dtgv_data.Size = new Size(752, 140);
            dtgv_data.TabIndex = 7;
            dtgv_data.CellClick += dtgv_data_CellClick;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(6, 29);
            label4.Name = "label4";
            label4.Size = new Size(50, 20);
            label4.TabIndex = 6;
            label4.Text = "label4";
            // 
            // tb_timkiem
            // 
            tb_timkiem.Location = new Point(62, 26);
            tb_timkiem.Name = "tb_timkiem";
            tb_timkiem.Size = new Size(568, 27);
            tb_timkiem.TabIndex = 2;
            tb_timkiem.TextChanged += tb_timkiem_TextChanged;
            // 
            // groupBox1
            // 
            groupBox1.Controls.Add(dataGridView1);
            groupBox1.Controls.Add(label3);
            groupBox1.Controls.Add(label2);
            groupBox1.Controls.Add(label1);
            groupBox1.Controls.Add(cbb_hang);
            groupBox1.Controls.Add(tb_gia);
            groupBox1.Controls.Add(tb_ten);
            groupBox1.Location = new Point(6, 12);
            groupBox1.Name = "groupBox1";
            groupBox1.Size = new Size(520, 242);
            groupBox1.TabIndex = 2;
            groupBox1.TabStop = false;
            groupBox1.Text = "groupBox1";
            // 
            // dataGridView1
            // 
            dataGridView1.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridView1.Location = new Point(298, 299);
            dataGridView1.Name = "dataGridView1";
            dataGridView1.RowHeadersWidth = 51;
            dataGridView1.RowTemplate.Height = 29;
            dataGridView1.Size = new Size(300, 84);
            dataGridView1.TabIndex = 7;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(32, 161);
            label3.Name = "label3";
            label3.Size = new Size(45, 20);
            label3.TabIndex = 5;
            label3.Text = "Hãng";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(32, 106);
            label2.Name = "label2";
            label2.Size = new Size(31, 20);
            label2.TabIndex = 4;
            label2.Text = "Giá";
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(32, 58);
            label1.Name = "label1";
            label1.Size = new Size(32, 20);
            label1.TabIndex = 3;
            label1.Text = "Tên";
            // 
            // cbb_hang
            // 
            cbb_hang.FormattingEnabled = true;
            cbb_hang.Location = new Point(129, 161);
            cbb_hang.Name = "cbb_hang";
            cbb_hang.Size = new Size(360, 28);
            cbb_hang.TabIndex = 2;
            // 
            // tb_gia
            // 
            tb_gia.Location = new Point(129, 99);
            tb_gia.Name = "tb_gia";
            tb_gia.Size = new Size(360, 27);
            tb_gia.TabIndex = 1;
            // 
            // tb_ten
            // 
            tb_ten.Location = new Point(129, 55);
            tb_ten.Name = "tb_ten";
            tb_ten.Size = new Size(360, 27);
            tb_ten.TabIndex = 0;
            // 
            // View
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 495);
            Controls.Add(groupBox2);
            Controls.Add(groupBox3);
            Controls.Add(groupBox1);
            Name = "View";
            Text = "View";
            Load += View_Load;
            groupBox2.ResumeLayout(false);
            groupBox3.ResumeLayout(false);
            groupBox3.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)dtgv_data).EndInit();
            groupBox1.ResumeLayout(false);
            groupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)dataGridView1).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private GroupBox groupBox2;
        private Button bt_clear;
        private Button bt_xoa;
        private Button bt_sua;
        private Button bt_them;
        private GroupBox groupBox3;
        private DataGridView dtgv_data;
        private Label label4;
        private TextBox tb_timkiem;
        private GroupBox groupBox1;
        private DataGridView dataGridView1;
        private Label label3;
        private Label label2;
        private Label label1;
        private ComboBox cbb_hang;
        private TextBox tb_gia;
        private TextBox tb_ten;
    }
}