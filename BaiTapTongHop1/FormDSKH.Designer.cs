namespace BaiTapTongHop1
{
    partial class FormDSKH
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
            txtID = new TextBox();
            txtHoTen = new TextBox();
            txtSDT = new TextBox();
            txtDiaChi = new TextBox();
            dtpNgaySinh = new DateTimePicker();
            button1 = new Button();
            dgvKhachHang = new DataGridView();
            label6 = new Label();
            cbnLoaiKH = new ComboBox();
            btnCapNhat = new Button();
            btnXoa = new Button();
            label7 = new Label();
            txtTimKiem = new TextBox();
            btnTimKiem = new Button();
            ((System.ComponentModel.ISupportInitialize)dgvKhachHang).BeginInit();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(218, 84);
            label1.Name = "label1";
            label1.Size = new Size(37, 32);
            label1.TabIndex = 0;
            label1.Text = "ID";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(218, 171);
            label2.Name = "label2";
            label2.Size = new Size(121, 32);
            label2.TabIndex = 1;
            label2.Text = "Họ và Tên";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(218, 246);
            label3.Name = "label3";
            label3.Size = new Size(57, 32);
            label3.TabIndex = 2;
            label3.Text = "SĐT";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(218, 320);
            label4.Name = "label4";
            label4.Size = new Size(87, 32);
            label4.TabIndex = 3;
            label4.Text = "Địa chỉ";
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Location = new Point(218, 396);
            label5.Name = "label5";
            label5.Size = new Size(124, 32);
            label5.TabIndex = 4;
            label5.Text = "Ngày Sinh";
            // 
            // txtID
            // 
            txtID.Location = new Point(507, 77);
            txtID.Name = "txtID";
            txtID.ReadOnly = true;
            txtID.Size = new Size(400, 39);
            txtID.TabIndex = 5;
            // 
            // txtHoTen
            // 
            txtHoTen.Location = new Point(507, 164);
            txtHoTen.Name = "txtHoTen";
            txtHoTen.Size = new Size(400, 39);
            txtHoTen.TabIndex = 6;
            // 
            // txtSDT
            // 
            txtSDT.Location = new Point(507, 246);
            txtSDT.Name = "txtSDT";
            txtSDT.Size = new Size(400, 39);
            txtSDT.TabIndex = 7;
            // 
            // txtDiaChi
            // 
            txtDiaChi.Location = new Point(507, 320);
            txtDiaChi.Name = "txtDiaChi";
            txtDiaChi.Size = new Size(400, 39);
            txtDiaChi.TabIndex = 8;
            // 
            // dtpNgaySinh
            // 
            dtpNgaySinh.Location = new Point(507, 389);
            dtpNgaySinh.Name = "dtpNgaySinh";
            dtpNgaySinh.Size = new Size(400, 39);
            dtpNgaySinh.TabIndex = 9;
            // 
            // button1
            // 
            button1.Location = new Point(140, 632);
            button1.Name = "button1";
            button1.Size = new Size(213, 87);
            button1.TabIndex = 10;
            button1.Text = "Thêm Mới";
            button1.UseVisualStyleBackColor = true;
            button1.Click += button1_Click;
            // 
            // dgvKhachHang
            // 
            dgvKhachHang.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgvKhachHang.Location = new Point(55, 738);
            dgvKhachHang.Name = "dgvKhachHang";
            dgvKhachHang.RowHeadersWidth = 82;
            dgvKhachHang.Size = new Size(1411, 300);
            dgvKhachHang.TabIndex = 11;
            dgvKhachHang.CellClick += dgvKhachHang_CellClick;
            dgvKhachHang.CellContentClick += dgvKhachHang_CellContentClick;
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Location = new Point(218, 468);
            label6.Name = "label6";
            label6.Size = new Size(193, 32);
            label6.TabIndex = 12;
            label6.Text = "Loại Khách Hàng";
            // 
            // cbnLoaiKH
            // 
            cbnLoaiKH.FormattingEnabled = true;
            cbnLoaiKH.Location = new Point(507, 465);
            cbnLoaiKH.Name = "cbnLoaiKH";
            cbnLoaiKH.Size = new Size(400, 40);
            cbnLoaiKH.TabIndex = 13;
            // 
            // btnCapNhat
            // 
            btnCapNhat.Location = new Point(507, 632);
            btnCapNhat.Name = "btnCapNhat";
            btnCapNhat.Size = new Size(196, 87);
            btnCapNhat.TabIndex = 14;
            btnCapNhat.Text = "Cập Nhật";
            btnCapNhat.UseVisualStyleBackColor = true;
            btnCapNhat.Click += btnCapNhat_Click;
            // 
            // btnXoa
            // 
            btnXoa.Location = new Point(1179, 632);
            btnXoa.Name = "btnXoa";
            btnXoa.Size = new Size(195, 87);
            btnXoa.TabIndex = 15;
            btnXoa.Text = "Xoá";
            btnXoa.UseVisualStyleBackColor = true;
            btnXoa.Click += btnXoa_Click;
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.Location = new Point(224, 535);
            label7.Name = "label7";
            label7.Size = new Size(115, 32);
            label7.TabIndex = 16;
            label7.Text = "Tìm Kiếm";
            // 
            // txtTimKiem
            // 
            txtTimKiem.Location = new Point(509, 532);
            txtTimKiem.Name = "txtTimKiem";
            txtTimKiem.Size = new Size(398, 39);
            txtTimKiem.TabIndex = 17;
            // 
            // btnTimKiem
            // 
            btnTimKiem.Location = new Point(828, 632);
            btnTimKiem.Name = "btnTimKiem";
            btnTimKiem.Size = new Size(205, 87);
            btnTimKiem.TabIndex = 18;
            btnTimKiem.Text = "Tìm Kiếm";
            btnTimKiem.UseVisualStyleBackColor = true;
            btnTimKiem.Click += btnTimKiem_Click;
            // 
            // FormDSKH
            // 
            AutoScaleDimensions = new SizeF(13F, 32F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1505, 1215);
            Controls.Add(btnTimKiem);
            Controls.Add(txtTimKiem);
            Controls.Add(label7);
            Controls.Add(btnXoa);
            Controls.Add(btnCapNhat);
            Controls.Add(cbnLoaiKH);
            Controls.Add(label6);
            Controls.Add(dgvKhachHang);
            Controls.Add(button1);
            Controls.Add(dtpNgaySinh);
            Controls.Add(txtDiaChi);
            Controls.Add(txtSDT);
            Controls.Add(txtHoTen);
            Controls.Add(txtID);
            Controls.Add(label5);
            Controls.Add(label4);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(label1);
            Name = "FormDSKH";
            Text = "FormDSKH";
            Load += FormDSKH_Load;
            ((System.ComponentModel.ISupportInitialize)dgvKhachHang).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private Label label2;
        private Label label3;
        private Label label4;
        private Label label5;
        private TextBox txtID;
        private TextBox txtHoTen;
        private TextBox txtSDT;
        private TextBox txtDiaChi;
        private DateTimePicker dtpNgaySinh;
        private Button button1;
        private DataGridView dgvKhachHang;
        private Label label6;
        private ComboBox cbnLoaiKH;
        private Button btnCapNhat;
        private Button btnXoa;
        private Label label7;
        private TextBox txtTimKiem;
        private Button btnTimKiem;
    }
}