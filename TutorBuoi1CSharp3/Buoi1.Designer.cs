namespace TutorBuoi1CSharp3
{
    partial class Buoi1
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
            bt_addName = new Button();
            tb_name = new TextBox();
            dtv_data = new DataGridView();
            lb_name = new Label();
            cbb_gioitinh = new ComboBox();
            bt_update = new Button();
            lb_gt = new Label();
            bt_delete = new Button();
            ((System.ComponentModel.ISupportInitialize)dtv_data).BeginInit();
            SuspendLayout();
            // 
            // bt_addName
            // 
            bt_addName.Location = new Point(657, 44);
            bt_addName.Name = "bt_addName";
            bt_addName.Size = new Size(94, 29);
            bt_addName.TabIndex = 0;
            bt_addName.Text = "Thêm mới";
            bt_addName.UseVisualStyleBackColor = true;
            bt_addName.Click += bt_addName_Click;
            // 
            // tb_name
            // 
            tb_name.Location = new Point(155, 86);
            tb_name.Name = "tb_name";
            tb_name.Size = new Size(125, 27);
            tb_name.TabIndex = 1;
            // 
            // dtv_data
            // 
            dtv_data.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dtv_data.Location = new Point(31, 238);
            dtv_data.Name = "dtv_data";
            dtv_data.RowHeadersWidth = 51;
            dtv_data.RowTemplate.Height = 29;
            dtv_data.Size = new Size(743, 188);
            dtv_data.TabIndex = 2;
            dtv_data.CellClick += dtv_data_CellClick;
            // 
            // lb_name
            // 
            lb_name.AutoSize = true;
            lb_name.Location = new Point(93, 86);
            lb_name.Name = "lb_name";
            lb_name.Size = new Size(32, 20);
            lb_name.TabIndex = 3;
            lb_name.Text = "Tên";
            // 
            // cbb_gioitinh
            // 
            cbb_gioitinh.FormattingEnabled = true;
            cbb_gioitinh.Location = new Point(402, 87);
            cbb_gioitinh.Name = "cbb_gioitinh";
            cbb_gioitinh.Size = new Size(151, 28);
            cbb_gioitinh.TabIndex = 4;
            // 
            // bt_update
            // 
            bt_update.Location = new Point(657, 99);
            bt_update.Name = "bt_update";
            bt_update.Size = new Size(94, 29);
            bt_update.TabIndex = 5;
            bt_update.Text = "Cập nhật";
            bt_update.UseVisualStyleBackColor = true;
            bt_update.Click += bt_update_Click;
            // 
            // lb_gt
            // 
            lb_gt.AutoSize = true;
            lb_gt.Location = new Point(321, 90);
            lb_gt.Name = "lb_gt";
            lb_gt.Size = new Size(65, 20);
            lb_gt.TabIndex = 6;
            lb_gt.Text = "Giới tính";
            // 
            // bt_delete
            // 
            bt_delete.Location = new Point(657, 153);
            bt_delete.Name = "bt_delete";
            bt_delete.Size = new Size(94, 29);
            bt_delete.TabIndex = 7;
            bt_delete.Text = "Xóa";
            bt_delete.UseVisualStyleBackColor = true;
            bt_delete.Click += bt_delete_Click;
            // 
            // Buoi1
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(bt_delete);
            Controls.Add(lb_gt);
            Controls.Add(bt_update);
            Controls.Add(cbb_gioitinh);
            Controls.Add(lb_name);
            Controls.Add(dtv_data);
            Controls.Add(tb_name);
            Controls.Add(bt_addName);
            Name = "Buoi1";
            Text = "Buoi1";
            Load += Buoi1_Load;
            ((System.ComponentModel.ISupportInitialize)dtv_data).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Button bt_addName;
        private TextBox tb_name;
        private DataGridView dtv_data;
        private Label lb_name;
        private ComboBox cbb_gioitinh;
        private Button bt_update;
        private Label lb_gt;
        private Button bt_delete;
    }
}