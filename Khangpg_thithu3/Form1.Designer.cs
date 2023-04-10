namespace Khangpg_thithu3
{
    partial class Form1
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            gr_input = new GroupBox();
            rbt_moban = new RadioButton();
            rbt_dungban = new RadioButton();
            label4 = new Label();
            label3 = new Label();
            label2 = new Label();
            label1 = new Label();
            tb_maxe = new TextBox();
            tb_giaban = new TextBox();
            tb_tenxe = new TextBox();
            gr_button = new GroupBox();
            bt_clear = new Button();
            bt_xoa = new Button();
            bt_sua = new Button();
            bt_them = new Button();
            gr_view = new GroupBox();
            dtgv_data = new DataGridView();
            tb_timkiem = new TextBox();
            gr_input.SuspendLayout();
            gr_button.SuspendLayout();
            gr_view.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dtgv_data).BeginInit();
            SuspendLayout();
            // 
            // gr_input
            // 
            gr_input.Controls.Add(rbt_moban);
            gr_input.Controls.Add(rbt_dungban);
            gr_input.Controls.Add(label4);
            gr_input.Controls.Add(label3);
            gr_input.Controls.Add(label2);
            gr_input.Controls.Add(label1);
            gr_input.Controls.Add(tb_maxe);
            gr_input.Controls.Add(tb_giaban);
            gr_input.Controls.Add(tb_tenxe);
            gr_input.Location = new Point(22, 12);
            gr_input.Name = "gr_input";
            gr_input.Size = new Size(484, 210);
            gr_input.TabIndex = 0;
            gr_input.TabStop = false;
            gr_input.Text = "input";
            // 
            // rbt_moban
            // 
            rbt_moban.AutoSize = true;
            rbt_moban.Location = new Point(299, 170);
            rbt_moban.Name = "rbt_moban";
            rbt_moban.Size = new Size(81, 24);
            rbt_moban.TabIndex = 8;
            rbt_moban.TabStop = true;
            rbt_moban.Text = "Mở bán";
            rbt_moban.UseVisualStyleBackColor = true;
            // 
            // rbt_dungban
            // 
            rbt_dungban.AutoSize = true;
            rbt_dungban.Location = new Point(139, 170);
            rbt_dungban.Name = "rbt_dungban";
            rbt_dungban.Size = new Size(96, 24);
            rbt_dungban.TabIndex = 7;
            rbt_dungban.TabStop = true;
            rbt_dungban.Text = "Dừng bán";
            rbt_dungban.UseVisualStyleBackColor = true;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(30, 172);
            label4.Name = "label4";
            label4.Size = new Size(75, 20);
            label4.TabIndex = 6;
            label4.Text = "Trạng thái";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(30, 129);
            label3.Name = "label3";
            label3.Size = new Size(60, 20);
            label3.TabIndex = 5;
            label3.Text = "Giá bán";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(30, 75);
            label2.Name = "label2";
            label2.Size = new Size(30, 20);
            label2.TabIndex = 4;
            label2.Text = "Mã";
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(30, 26);
            label1.Name = "label1";
            label1.Size = new Size(32, 20);
            label1.TabIndex = 3;
            label1.Text = "Tên";
            // 
            // tb_maxe
            // 
            tb_maxe.Location = new Point(106, 75);
            tb_maxe.Name = "tb_maxe";
            tb_maxe.Size = new Size(359, 27);
            tb_maxe.TabIndex = 2;
            // 
            // tb_giaban
            // 
            tb_giaban.Location = new Point(106, 129);
            tb_giaban.Name = "tb_giaban";
            tb_giaban.Size = new Size(359, 27);
            tb_giaban.TabIndex = 1;
            // 
            // tb_tenxe
            // 
            tb_tenxe.Location = new Point(106, 26);
            tb_tenxe.Name = "tb_tenxe";
            tb_tenxe.Size = new Size(359, 27);
            tb_tenxe.TabIndex = 0;
            // 
            // gr_button
            // 
            gr_button.Controls.Add(bt_clear);
            gr_button.Controls.Add(bt_xoa);
            gr_button.Controls.Add(bt_sua);
            gr_button.Controls.Add(bt_them);
            gr_button.Location = new Point(512, 12);
            gr_button.Name = "gr_button";
            gr_button.Size = new Size(276, 210);
            gr_button.TabIndex = 2;
            gr_button.TabStop = false;
            gr_button.Text = "button";
            // 
            // bt_clear
            // 
            bt_clear.Location = new Point(69, 155);
            bt_clear.Name = "bt_clear";
            bt_clear.Size = new Size(147, 42);
            bt_clear.TabIndex = 3;
            bt_clear.Text = "Clear";
            bt_clear.UseVisualStyleBackColor = true;
            bt_clear.Click += bt_clear_Click;
            // 
            // bt_xoa
            // 
            bt_xoa.Location = new Point(69, 107);
            bt_xoa.Name = "bt_xoa";
            bt_xoa.Size = new Size(147, 42);
            bt_xoa.TabIndex = 2;
            bt_xoa.Text = "Xóa";
            bt_xoa.UseVisualStyleBackColor = true;
            bt_xoa.Click += bt_xoa_Click;
            // 
            // bt_sua
            // 
            bt_sua.Location = new Point(69, 62);
            bt_sua.Name = "bt_sua";
            bt_sua.Size = new Size(147, 42);
            bt_sua.TabIndex = 1;
            bt_sua.Text = "Sửa";
            bt_sua.UseVisualStyleBackColor = true;
            bt_sua.Click += bt_sua_Click;
            // 
            // bt_them
            // 
            bt_them.Location = new Point(69, 14);
            bt_them.Name = "bt_them";
            bt_them.Size = new Size(147, 42);
            bt_them.TabIndex = 0;
            bt_them.Text = "Thêm";
            bt_them.UseVisualStyleBackColor = true;
            bt_them.Click += bt_them_Click;
            // 
            // gr_view
            // 
            gr_view.Controls.Add(dtgv_data);
            gr_view.Controls.Add(tb_timkiem);
            gr_view.Location = new Point(22, 241);
            gr_view.Name = "gr_view";
            gr_view.Size = new Size(766, 197);
            gr_view.TabIndex = 2;
            gr_view.TabStop = false;
            gr_view.Text = "GridView";
            // 
            // dtgv_data
            // 
            dtgv_data.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dtgv_data.Location = new Point(6, 57);
            dtgv_data.Name = "dtgv_data";
            dtgv_data.RowHeadersWidth = 51;
            dtgv_data.RowTemplate.Height = 29;
            dtgv_data.Size = new Size(754, 140);
            dtgv_data.TabIndex = 4;
            dtgv_data.CellClick += dtgv_data_CellClick;
            // 
            // tb_timkiem
            // 
            tb_timkiem.Location = new Point(106, 15);
            tb_timkiem.Name = "tb_timkiem";
            tb_timkiem.Size = new Size(370, 27);
            tb_timkiem.TabIndex = 3;
            tb_timkiem.TextChanged += tb_timkiem_TextChanged;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(gr_button);
            Controls.Add(gr_view);
            Controls.Add(gr_input);
            Name = "Form1";
            Text = "Form1";
            Load += Form1_Load;
            gr_input.ResumeLayout(false);
            gr_input.PerformLayout();
            gr_button.ResumeLayout(false);
            gr_view.ResumeLayout(false);
            gr_view.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)dtgv_data).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private GroupBox gr_input;
        private TextBox tb_maxe;
        private TextBox tb_giaban;
        private TextBox tb_tenxe;
        private GroupBox gr_button;
        private GroupBox gr_view;
        private TextBox tb_timkiem;
        private RadioButton rbt_moban;
        private RadioButton rbt_dungban;
        private Label label4;
        private Label label3;
        private Label label2;
        private Label label1;
        private Button bt_clear;
        private Button bt_xoa;
        private Button bt_sua;
        private Button bt_them;
        private DataGridView dtgv_data;
    }
}