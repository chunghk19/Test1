namespace KiemTraCuoiKi
{
    partial class FormDanhSachSachcs
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
            label1 = new Label();
            label2 = new Label();
            label3 = new Label();
            label4 = new Label();
            label5 = new Label();
            label6 = new Label();
            txtID = new TextBox();
            txtTenSach = new TextBox();
            txtGia = new TextBox();
            txtSoLuong = new TextBox();
            txtMoTa = new TextBox();
            cbbTheLoai = new ComboBox();
            dgvSach = new DataGridView();
            button1 = new Button();
            btnCapNhat = new Button();
            btnXoa = new Button();
            btnTimKiem = new Button();
            label7 = new Label();
            txtTimKiem = new TextBox();
            ((System.ComponentModel.ISupportInitialize)dgvSach).BeginInit();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(360, 77);
            label1.Name = "label1";
            label1.Size = new Size(37, 32);
            label1.TabIndex = 0;
            label1.Text = "ID";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(360, 168);
            label2.Name = "label2";
            label2.Size = new Size(109, 32);
            label2.TabIndex = 1;
            label2.Text = "Tên Sách";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(360, 254);
            label3.Name = "label3";
            label3.Size = new Size(48, 32);
            label3.TabIndex = 2;
            label3.Text = "Giá";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(360, 352);
            label4.Name = "label4";
            label4.Size = new Size(115, 32);
            label4.TabIndex = 3;
            label4.Text = "Số Lượng";
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Location = new Point(360, 453);
            label5.Name = "label5";
            label5.Size = new Size(82, 32);
            label5.TabIndex = 4;
            label5.Text = "Mô Tả";
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Location = new Point(360, 550);
            label6.Name = "label6";
            label6.Size = new Size(104, 32);
            label6.TabIndex = 5;
            label6.Text = "Thể Loại";
            // 
            // txtID
            // 
            txtID.Location = new Point(638, 77);
            txtID.Name = "txtID";
            txtID.ReadOnly = true;
            txtID.Size = new Size(378, 39);
            txtID.TabIndex = 6;
            // 
            // txtTenSach
            // 
            txtTenSach.Location = new Point(638, 168);
            txtTenSach.Name = "txtTenSach";
            txtTenSach.Size = new Size(378, 39);
            txtTenSach.TabIndex = 7;
            // 
            // txtGia
            // 
            txtGia.Location = new Point(638, 254);
            txtGia.Name = "txtGia";
            txtGia.Size = new Size(378, 39);
            txtGia.TabIndex = 8;
            // 
            // txtSoLuong
            // 
            txtSoLuong.Location = new Point(638, 352);
            txtSoLuong.Name = "txtSoLuong";
            txtSoLuong.Size = new Size(378, 39);
            txtSoLuong.TabIndex = 9;
            // 
            // txtMoTa
            // 
            txtMoTa.Location = new Point(638, 450);
            txtMoTa.Multiline = true;
            txtMoTa.Name = "txtMoTa";
            txtMoTa.Size = new Size(378, 39);
            txtMoTa.TabIndex = 10;
            // 
            // cbbTheLoai
            // 
            cbbTheLoai.FormattingEnabled = true;
            cbbTheLoai.Location = new Point(638, 550);
            cbbTheLoai.Name = "cbbTheLoai";
            cbbTheLoai.Size = new Size(378, 40);
            cbbTheLoai.TabIndex = 11;
            // 
            // dgvSach
            // 
            dgvSach.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgvSach.Location = new Point(248, 808);
            dgvSach.Name = "dgvSach";
            dgvSach.RowHeadersWidth = 82;
            dgvSach.Size = new Size(1356, 396);
            dgvSach.TabIndex = 12;
            dgvSach.CellClick += dgvSach_CellClick;
            dgvSach.CellContentClick += dgvSach_CellClick;
            // 
            // button1
            // 
            button1.Location = new Point(349, 720);
            button1.Name = "button1";
            button1.Size = new Size(150, 46);
            button1.TabIndex = 13;
            button1.Text = "Thêm Mới";
            button1.UseVisualStyleBackColor = true;
            button1.Click += button1_Click;
            // 
            // btnCapNhat
            // 
            btnCapNhat.Location = new Point(687, 720);
            btnCapNhat.Name = "btnCapNhat";
            btnCapNhat.Size = new Size(150, 46);
            btnCapNhat.TabIndex = 14;
            btnCapNhat.Text = "Cập Nhật";
            btnCapNhat.UseVisualStyleBackColor = true;
            btnCapNhat.Click += btnCapNhat_Click;
            // 
            // btnXoa
            // 
            btnXoa.Location = new Point(1034, 720);
            btnXoa.Name = "btnXoa";
            btnXoa.Size = new Size(150, 46);
            btnXoa.TabIndex = 15;
            btnXoa.Text = "Xoá";
            btnXoa.UseVisualStyleBackColor = true;
            btnXoa.Click += btnXoa_Click;
            // 
            // btnTimKiem
            // 
            btnTimKiem.Location = new Point(1377, 720);
            btnTimKiem.Name = "btnTimKiem";
            btnTimKiem.Size = new Size(150, 46);
            btnTimKiem.TabIndex = 16;
            btnTimKiem.Text = "Tìm Kiếm";
            btnTimKiem.UseVisualStyleBackColor = true;
            btnTimKiem.Click += btnTimKiem_Click;
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.Location = new Point(360, 636);
            label7.Name = "label7";
            label7.Size = new Size(115, 32);
            label7.TabIndex = 17;
            label7.Text = "Tìm Kiếm";
            // 
            // txtTimKiem
            // 
            txtTimKiem.Location = new Point(638, 641);
            txtTimKiem.Name = "txtTimKiem";
            txtTimKiem.Size = new Size(378, 39);
            txtTimKiem.TabIndex = 18;
            // 
            // FormDanhSachSachcs
            // 
            AutoScaleDimensions = new SizeF(13F, 32F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1917, 1242);
            Controls.Add(txtTimKiem);
            Controls.Add(label7);
            Controls.Add(btnTimKiem);
            Controls.Add(btnXoa);
            Controls.Add(btnCapNhat);
            Controls.Add(button1);
            Controls.Add(dgvSach);
            Controls.Add(cbbTheLoai);
            Controls.Add(txtMoTa);
            Controls.Add(txtSoLuong);
            Controls.Add(txtGia);
            Controls.Add(txtTenSach);
            Controls.Add(txtID);
            Controls.Add(label6);
            Controls.Add(label5);
            Controls.Add(label4);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(label1);
            Name = "FormDanhSachSachcs";
            Text = "FormDanhSachSachcs";
            Load += FormDanhSachSachcs_Load;
            ((System.ComponentModel.ISupportInitialize)dgvSach).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private Label label2;
        private Label label3;
        private Label label4;
        private Label label5;
        private Label label6;
        private TextBox txtID;
        private TextBox txtTenSach;
        private TextBox txtGia;
        private TextBox txtSoLuong;
        private TextBox txtMoTa;
        private ComboBox cbbTheLoai;
        private DataGridView dgvSach;
        private Button button1;
        private Button btnCapNhat;
        private Button btnXoa;
        private Button btnTimKiem;
        private Label label7;
        private TextBox txtTimKiem;
    }
}