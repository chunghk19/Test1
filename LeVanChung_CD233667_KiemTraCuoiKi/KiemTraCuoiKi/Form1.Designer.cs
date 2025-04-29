namespace KiemTraCuoiKi
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
            menuStrip1 = new MenuStrip();
            danhSáchSáchToolStripMenuItem = new ToolStripMenuItem();
            báoCáoSáchToolStripMenuItem = new ToolStripMenuItem();
            statusStrip1 = new StatusStrip();
            tssTaiKhoan = new ToolStripStatusLabel();
            tssSoLuong = new ToolStripStatusLabel();
            menuStrip1.SuspendLayout();
            statusStrip1.SuspendLayout();
            SuspendLayout();
            // 
            // menuStrip1
            // 
            menuStrip1.ImageScalingSize = new Size(32, 32);
            menuStrip1.Items.AddRange(new ToolStripItem[] { danhSáchSáchToolStripMenuItem, báoCáoSáchToolStripMenuItem });
            menuStrip1.Location = new Point(0, 0);
            menuStrip1.Name = "menuStrip1";
            menuStrip1.Size = new Size(1488, 40);
            menuStrip1.TabIndex = 1;
            menuStrip1.Text = "menuStrip1";
            // 
            // danhSáchSáchToolStripMenuItem
            // 
            danhSáchSáchToolStripMenuItem.Name = "danhSáchSáchToolStripMenuItem";
            danhSáchSáchToolStripMenuItem.Size = new Size(205, 36);
            danhSáchSáchToolStripMenuItem.Text = "Danh Sách Sách";
            danhSáchSáchToolStripMenuItem.Click += danhSáchSáchToolStripMenuItem_Click;
            // 
            // báoCáoSáchToolStripMenuItem
            // 
            báoCáoSáchToolStripMenuItem.Name = "báoCáoSáchToolStripMenuItem";
            báoCáoSáchToolStripMenuItem.Size = new Size(179, 36);
            báoCáoSáchToolStripMenuItem.Text = "Báo Cáo Sách";
            báoCáoSáchToolStripMenuItem.Click += báoCáoSáchToolStripMenuItem_Click;
            // 
            // statusStrip1
            // 
            statusStrip1.ImageScalingSize = new Size(32, 32);
            statusStrip1.Items.AddRange(new ToolStripItem[] { tssTaiKhoan, tssSoLuong });
            statusStrip1.Location = new Point(0, 722);
            statusStrip1.Name = "statusStrip1";
            statusStrip1.Size = new Size(1488, 42);
            statusStrip1.TabIndex = 3;
            statusStrip1.Text = "statusStrip1";
            statusStrip1.ItemClicked += statusStrip1_ItemClicked;
            // 
            // tssTaiKhoan
            // 
            tssTaiKhoan.Name = "tssTaiKhoan";
            tssTaiKhoan.Size = new Size(146, 32);
            tssTaiKhoan.Text = "Người Dùng";
            // 
            // tssSoLuong
            // 
            tssSoLuong.Name = "tssSoLuong";
            tssSoLuong.Size = new Size(172, 32);
            tssSoLuong.Text = "Số Lượng Sách";
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(13F, 32F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1488, 764);
            Controls.Add(statusStrip1);
            Controls.Add(menuStrip1);
            IsMdiContainer = true;
            MainMenuStrip = menuStrip1;
            Name = "Form1";
            Text = "Form1";
            Load += Form1_Load;
            menuStrip1.ResumeLayout(false);
            menuStrip1.PerformLayout();
            statusStrip1.ResumeLayout(false);
            statusStrip1.PerformLayout();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private MenuStrip menuStrip1;
        private ToolStripMenuItem danhSáchSáchToolStripMenuItem;
        private ToolStripMenuItem báoCáoSáchToolStripMenuItem;
        private StatusStrip statusStrip1;
        private ToolStripStatusLabel tssTaiKhoan;
        private ToolStripStatusLabel tssSoLuong;
    }
}
