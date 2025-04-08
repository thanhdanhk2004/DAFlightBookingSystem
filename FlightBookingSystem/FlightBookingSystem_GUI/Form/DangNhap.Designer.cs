namespace PresentationLayer
{
    partial class DangNhap
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(DangNhap));
            lbDangNhap = new Label();
            txtTenDangNhap = new TextBox();
            txtMatKhau = new TextBox();
            btDangKy = new Button();
            label4 = new Label();
            lbDangKy = new Label();
            groupBox1 = new GroupBox();
            panel1 = new Panel();
            pictureBox3 = new PictureBox();
            label1 = new Label();
            pictureBox2 = new PictureBox();
            pictureBox1 = new PictureBox();
            groupBox1.SuspendLayout();
            panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox3).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox2).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            SuspendLayout();
            // 
            // lbDangNhap
            // 
            lbDangNhap.BackColor = Color.Transparent;
            lbDangNhap.Font = new Font("Microsoft Sans Serif", 20F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lbDangNhap.ForeColor = Color.Black;
            lbDangNhap.Location = new Point(289, 21);
            lbDangNhap.Name = "lbDangNhap";
            lbDangNhap.Size = new Size(376, 65);
            lbDangNhap.TabIndex = 1;
            lbDangNhap.Text = "Đăng nhập";
            lbDangNhap.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // txtTenDangNhap
            // 
            txtTenDangNhap.Font = new Font("Microsoft Sans Serif", 17F, FontStyle.Regular, GraphicsUnit.Point, 0);
            txtTenDangNhap.Location = new Point(278, 63);
            txtTenDangNhap.Margin = new Padding(3, 4, 3, 4);
            txtTenDangNhap.Multiline = true;
            txtTenDangNhap.Name = "txtTenDangNhap";
            txtTenDangNhap.Size = new Size(297, 45);
            txtTenDangNhap.TabIndex = 5;
            // 
            // txtMatKhau
            // 
            txtMatKhau.Font = new Font("Microsoft Sans Serif", 17F, FontStyle.Regular, GraphicsUnit.Point, 0);
            txtMatKhau.Location = new Point(278, 156);
            txtMatKhau.Margin = new Padding(3, 4, 3, 4);
            txtMatKhau.Multiline = true;
            txtMatKhau.Name = "txtMatKhau";
            txtMatKhau.PasswordChar = '*';
            txtMatKhau.Size = new Size(297, 42);
            txtMatKhau.TabIndex = 9;
            // 
            // btDangKy
            // 
            btDangKy.BackColor = Color.LimeGreen;
            btDangKy.Font = new Font("Microsoft Sans Serif", 7.8F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btDangKy.ForeColor = SystemColors.ActiveCaptionText;
            btDangKy.Location = new Point(337, 229);
            btDangKy.Margin = new Padding(3, 4, 3, 4);
            btDangKy.Name = "btDangKy";
            btDangKy.Size = new Size(155, 60);
            btDangKy.TabIndex = 15;
            btDangKy.Text = "Đăng nhập";
            btDangKy.UseVisualStyleBackColor = false;
            btDangKy.Click += btDangKy_Click;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Font = new Font("Microsoft Sans Serif", 8.5F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label4.ForeColor = Color.Black;
            label4.Location = new Point(262, 325);
            label4.Name = "label4";
            label4.Size = new Size(185, 18);
            label4.TabIndex = 17;
            label4.Text = "Bạn chưa có tài khoản?";
            // 
            // lbDangKy
            // 
            lbDangKy.AutoSize = true;
            lbDangKy.Font = new Font("Microsoft Sans Serif", 10F, FontStyle.Bold | FontStyle.Italic | FontStyle.Underline, GraphicsUnit.Point, 0);
            lbDangKy.ForeColor = Color.Blue;
            lbDangKy.Location = new Point(442, 322);
            lbDangKy.Name = "lbDangKy";
            lbDangKy.Size = new Size(76, 20);
            lbDangKy.TabIndex = 18;
            lbDangKy.Text = "Đăng ký";
            lbDangKy.TextAlign = ContentAlignment.MiddleCenter;
            lbDangKy.Click += lbDangKy_Click;
            // 
            // groupBox1
            // 
            groupBox1.BackColor = Color.Cornsilk;
            groupBox1.Controls.Add(panel1);
            groupBox1.Controls.Add(pictureBox2);
            groupBox1.Controls.Add(pictureBox1);
            groupBox1.Controls.Add(lbDangKy);
            groupBox1.Controls.Add(label4);
            groupBox1.Controls.Add(btDangKy);
            groupBox1.Controls.Add(txtMatKhau);
            groupBox1.Controls.Add(txtTenDangNhap);
            groupBox1.Location = new Point(124, 121);
            groupBox1.Margin = new Padding(3, 4, 3, 4);
            groupBox1.Name = "groupBox1";
            groupBox1.Padding = new Padding(3, 4, 3, 4);
            groupBox1.Size = new Size(638, 411);
            groupBox1.TabIndex = 2;
            groupBox1.TabStop = false;
            // 
            // panel1
            // 
            panel1.BackColor = Color.FromArgb(255, 255, 128);
            panel1.Controls.Add(pictureBox3);
            panel1.Controls.Add(label1);
            panel1.Location = new Point(0, 0);
            panel1.Margin = new Padding(3, 4, 3, 4);
            panel1.Name = "panel1";
            panel1.Size = new Size(205, 411);
            panel1.TabIndex = 21;
            // 
            // pictureBox3
            // 
            pictureBox3.BackColor = Color.Transparent;
            pictureBox3.Image = (Image)resources.GetObject("pictureBox3.Image");
            pictureBox3.Location = new Point(56, 39);
            pictureBox3.Margin = new Padding(3, 4, 3, 4);
            pictureBox3.Name = "pictureBox3";
            pictureBox3.Size = new Size(100, 62);
            pictureBox3.SizeMode = PictureBoxSizeMode.StretchImage;
            pictureBox3.TabIndex = 1;
            pictureBox3.TabStop = false;
            // 
            // label1
            // 
            label1.Font = new Font("Microsoft Sans Serif", 15F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label1.ForeColor = Color.Blue;
            label1.Location = new Point(25, 39);
            label1.Name = "label1";
            label1.Size = new Size(165, 309);
            label1.TabIndex = 0;
            label1.Text = "Welcom Flight Booking System";
            label1.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // pictureBox2
            // 
            pictureBox2.Image = (Image)resources.GetObject("pictureBox2.Image");
            pictureBox2.Location = new Point(228, 156);
            pictureBox2.Margin = new Padding(3, 4, 3, 4);
            pictureBox2.Name = "pictureBox2";
            pictureBox2.Size = new Size(34, 42);
            pictureBox2.SizeMode = PictureBoxSizeMode.StretchImage;
            pictureBox2.TabIndex = 20;
            pictureBox2.TabStop = false;
            // 
            // pictureBox1
            // 
            pictureBox1.Image = (Image)resources.GetObject("pictureBox1.Image");
            pictureBox1.Location = new Point(228, 63);
            pictureBox1.Margin = new Padding(3, 4, 3, 4);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(34, 45);
            pictureBox1.SizeMode = PictureBoxSizeMode.StretchImage;
            pictureBox1.TabIndex = 19;
            pictureBox1.TabStop = false;
            // 
            // DangNhap
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackgroundImage = (Image)resources.GetObject("$this.BackgroundImage");
            BackgroundImageLayout = ImageLayout.Stretch;
            ClientSize = new Size(905, 594);
            Controls.Add(groupBox1);
            Controls.Add(lbDangNhap);
            Margin = new Padding(3, 4, 3, 4);
            Name = "DangNhap";
            ShowIcon = false;
            StartPosition = FormStartPosition.CenterScreen;
            groupBox1.ResumeLayout(false);
            groupBox1.PerformLayout();
            panel1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)pictureBox3).EndInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox2).EndInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Label lbDangNhap;
        private System.Windows.Forms.TextBox txtTenDangNhap;
        private System.Windows.Forms.TextBox txtMatKhau;
        private System.Windows.Forms.Button btDangKy;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label lbDangKy;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.PictureBox pictureBox2;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.PictureBox pictureBox3;
        private System.Windows.Forms.Label label1;
    }
}