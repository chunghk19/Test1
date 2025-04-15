namespace BaiTapTongHop1
{
    partial class FormDangNhap
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
            txtTenDN = new TextBox();
            txtMatKhau = new TextBox();
            btnDangNhap = new Button();
            btnThoat = new Button();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(275, 127);
            label1.Name = "label1";
            label1.Size = new Size(181, 32);
            label1.TabIndex = 0;
            label1.Text = "Tên Đăng Nhập";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(275, 246);
            label2.Name = "label2";
            label2.Size = new Size(117, 32);
            label2.TabIndex = 1;
            label2.Text = "Mật Khẩu";
            // 
            // txtTenDN
            // 
            txtTenDN.Location = new Point(579, 120);
            txtTenDN.Name = "txtTenDN";
            txtTenDN.Size = new Size(413, 39);
            txtTenDN.TabIndex = 2;
            // 
            // txtMatKhau
            // 
            txtMatKhau.Location = new Point(579, 239);
            txtMatKhau.Name = "txtMatKhau";
            txtMatKhau.Size = new Size(417, 39);
            txtMatKhau.TabIndex = 3;
            txtMatKhau.TextChanged += textBox2_TextChanged;
            // 
            // btnDangNhap
            // 
            btnDangNhap.Location = new Point(275, 439);
            btnDangNhap.Name = "btnDangNhap";
            btnDangNhap.Size = new Size(150, 46);
            btnDangNhap.TabIndex = 4;
            btnDangNhap.Text = "Đăng Nhập";
            btnDangNhap.UseVisualStyleBackColor = true;
            btnDangNhap.Click += btnDangNhap_Click;
            // 
            // btnThoat
            // 
            btnThoat.Location = new Point(846, 439);
            btnThoat.Name = "btnThoat";
            btnThoat.Size = new Size(150, 46);
            btnThoat.TabIndex = 5;
            btnThoat.Text = "Thoát";
            btnThoat.UseVisualStyleBackColor = true;
            btnThoat.Click += btnThoat_Click;
            // 
            // FormDangNhap
            // 
            AutoScaleDimensions = new SizeF(13F, 32F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1675, 1059);
            ControlBox = false;
            Controls.Add(btnThoat);
            Controls.Add(btnDangNhap);
            Controls.Add(txtMatKhau);
            Controls.Add(txtTenDN);
            Controls.Add(label2);
            Controls.Add(label1);
            Name = "FormDangNhap";
            Text = "FormDangNhap";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private Label label2;
        private TextBox txtTenDN;
        private TextBox txtMatKhau;
        private Button btnDangNhap;
        private Button btnThoat;
    }
}