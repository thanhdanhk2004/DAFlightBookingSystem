namespace PresentationLayer
{
    partial class ThongTinVe
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(ThongTinVe));
            panel4 = new Panel();
            lbThongTinChuyenBay = new Label();
            lbNoiDen = new Label();
            picMuiTen = new PictureBox();
            lbNoiDi = new Label();
            thongTinHanhKhach = new Panel();
            btXacNhanThongTin = new Button();
            label1 = new Label();
            label2 = new Label();
            lbTongTienThanhToan = new Label();
            lbTongTienSauKhuyenMai = new Label();
            panel2 = new Panel();
            label3 = new Label();
            panel4.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)picMuiTen).BeginInit();
            panel2.SuspendLayout();
            SuspendLayout();
            // 
            // panel4
            // 
            panel4.Controls.Add(lbThongTinChuyenBay);
            panel4.Controls.Add(lbNoiDen);
            panel4.Controls.Add(picMuiTen);
            panel4.Controls.Add(lbNoiDi);
            panel4.Dock = DockStyle.Top;
            panel4.Font = new Font("Microsoft Sans Serif", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            panel4.Location = new Point(0, 0);
            panel4.Margin = new Padding(3, 4, 3, 4);
            panel4.Name = "panel4";
            panel4.Size = new Size(955, 93);
            panel4.TabIndex = 4;
            // 
            // lbThongTinChuyenBay
            // 
            lbThongTinChuyenBay.AutoSize = true;
            lbThongTinChuyenBay.Location = new Point(348, 63);
            lbThongTinChuyenBay.Name = "lbThongTinChuyenBay";
            lbThongTinChuyenBay.Size = new Size(262, 18);
            lbThongTinChuyenBay.TabIndex = 3;
            lbThongTinChuyenBay.Text = "1 Người | 20/07/2025 | Phổ Thông";
            // 
            // lbNoiDen
            // 
            lbNoiDen.AutoSize = true;
            lbNoiDen.Font = new Font("Microsoft Sans Serif", 13F, FontStyle.Regular, GraphicsUnit.Point, 0);
            lbNoiDen.Location = new Point(545, 16);
            lbNoiDen.Name = "lbNoiDen";
            lbNoiDen.Size = new Size(79, 26);
            lbNoiDen.TabIndex = 2;
            lbNoiDen.Text = "Hà Nội";
            lbNoiDen.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // picMuiTen
            // 
            picMuiTen.Image = (Image)resources.GetObject("picMuiTen.Image");
            picMuiTen.Location = new Point(451, 16);
            picMuiTen.Margin = new Padding(3, 4, 3, 4);
            picMuiTen.Name = "picMuiTen";
            picMuiTen.Size = new Size(56, 32);
            picMuiTen.SizeMode = PictureBoxSizeMode.StretchImage;
            picMuiTen.TabIndex = 1;
            picMuiTen.TabStop = false;
            // 
            // lbNoiDi
            // 
            lbNoiDi.AutoSize = true;
            lbNoiDi.Font = new Font("Microsoft Sans Serif", 13F, FontStyle.Regular, GraphicsUnit.Point, 0);
            lbNoiDi.Location = new Point(288, 16);
            lbNoiDi.Name = "lbNoiDi";
            lbNoiDi.Size = new Size(132, 26);
            lbNoiDi.TabIndex = 0;
            lbNoiDi.Text = "Hồ Chí Minh";
            lbNoiDi.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // thongTinHanhKhach
            // 
            thongTinHanhKhach.AutoScroll = true;
            thongTinHanhKhach.BackColor = Color.Silver;
            thongTinHanhKhach.Location = new Point(28, 142);
            thongTinHanhKhach.Margin = new Padding(3, 4, 3, 4);
            thongTinHanhKhach.Name = "thongTinHanhKhach";
            thongTinHanhKhach.Size = new Size(905, 366);
            thongTinHanhKhach.TabIndex = 5;
            // 
            // btXacNhanThongTin
            // 
            btXacNhanThongTin.BackColor = Color.Lime;
            btXacNhanThongTin.Font = new Font("Microsoft Sans Serif", 11F, FontStyle.Regular, GraphicsUnit.Point, 0);
            btXacNhanThongTin.Location = new Point(418, 639);
            btXacNhanThongTin.Margin = new Padding(3, 4, 3, 4);
            btXacNhanThongTin.Name = "btXacNhanThongTin";
            btXacNhanThongTin.Size = new Size(109, 41);
            btXacNhanThongTin.TabIndex = 6;
            btXacNhanThongTin.Text = "Xác nhận";
            btXacNhanThongTin.UseVisualStyleBackColor = false;
            btXacNhanThongTin.Click += btXacNhanThongTin_Click;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Microsoft Sans Serif", 9F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label1.ForeColor = Color.Blue;
            label1.Location = new Point(22, 15);
            label1.Name = "label1";
            label1.Size = new Size(155, 18);
            label1.TabIndex = 0;
            label1.Text = "Số tiền cần thanh toán";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Microsoft Sans Serif", 9F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label2.ForeColor = Color.Blue;
            label2.Location = new Point(277, 15);
            label2.Name = "label2";
            label2.Size = new Size(176, 18);
            label2.TabIndex = 1;
            label2.Text = "Tổng tiền sau khuyến mãi";
            // 
            // lbTongTienThanhToan
            // 
            lbTongTienThanhToan.AutoSize = true;
            lbTongTienThanhToan.Font = new Font("Microsoft Sans Serif", 10F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lbTongTienThanhToan.ForeColor = Color.Red;
            lbTongTienThanhToan.Location = new Point(32, 61);
            lbTongTienThanhToan.Name = "lbTongTienThanhToan";
            lbTongTienThanhToan.Size = new Size(134, 20);
            lbTongTienThanhToan.TabIndex = 2;
            lbTongTienThanhToan.Text = "1.700.000 VND";
            // 
            // lbTongTienSauKhuyenMai
            // 
            lbTongTienSauKhuyenMai.AutoSize = true;
            lbTongTienSauKhuyenMai.Font = new Font("Microsoft Sans Serif", 10F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lbTongTienSauKhuyenMai.ForeColor = Color.Red;
            lbTongTienSauKhuyenMai.Location = new Point(295, 61);
            lbTongTienSauKhuyenMai.Name = "lbTongTienSauKhuyenMai";
            lbTongTienSauKhuyenMai.Size = new Size(134, 20);
            lbTongTienSauKhuyenMai.TabIndex = 3;
            lbTongTienSauKhuyenMai.Text = "1.400.000 VND";
            // 
            // panel2
            // 
            panel2.BackColor = Color.FromArgb(224, 224, 224);
            panel2.Controls.Add(lbTongTienSauKhuyenMai);
            panel2.Controls.Add(lbTongTienThanhToan);
            panel2.Controls.Add(label2);
            panel2.Controls.Add(label1);
            panel2.Location = new Point(241, 530);
            panel2.Margin = new Padding(3, 4, 3, 4);
            panel2.Name = "panel2";
            panel2.Size = new Size(516, 90);
            panel2.TabIndex = 8;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Segoe UI", 13F, FontStyle.Bold);
            label3.Location = new Point(348, 97);
            label3.Name = "label3";
            label3.Size = new Size(237, 30);
            label3.TabIndex = 9;
            label3.Text = "Thông tin hành khách";
            // 
            // ThongTinVe
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.Moccasin;
            ClientSize = new Size(955, 711);
            Controls.Add(label3);
            Controls.Add(panel2);
            Controls.Add(btXacNhanThongTin);
            Controls.Add(thongTinHanhKhach);
            Controls.Add(panel4);
            Margin = new Padding(3, 4, 3, 4);
            Name = "ThongTinVe";
            ShowIcon = false;
            StartPosition = FormStartPosition.CenterScreen;
            Load += ThongTinVe_Load;
            panel4.ResumeLayout(false);
            panel4.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)picMuiTen).EndInit();
            panel2.ResumeLayout(false);
            panel2.PerformLayout();
            ResumeLayout(false);
            PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Panel panel4;
        private System.Windows.Forms.Label lbThongTinChuyenBay;
        private System.Windows.Forms.Label lbNoiDen;
        private System.Windows.Forms.PictureBox picMuiTen;
        private System.Windows.Forms.Label lbNoiDi;
        private System.Windows.Forms.Panel thongTinHanhKhach;
        private System.Windows.Forms.Button btXacNhanThongTin;
        private Label label1;
        private Label label2;
        private Label lbTongTienThanhToan;
        private Label lbTongTienSauKhuyenMai;
        private Panel panel2;
        private Label label3;
    }
}