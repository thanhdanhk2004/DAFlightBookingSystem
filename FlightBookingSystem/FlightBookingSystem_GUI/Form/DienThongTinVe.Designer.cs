namespace PresentationLayer
{
    partial class DienThongTinVe
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
            thongTinHanhKhach = new Panel();
            panelThongTinThanhToan = new Panel();
            btXacNhan = new Button();
            lbTongTienSauKhuyenMai = new Label();
            lbTongTienThanhToan = new Label();
            label4 = new Label();
            label3 = new Label();
            label2 = new Label();
            cbPhuongThucThanhToan = new ComboBox();
            thongTinHanhKhach.SuspendLayout();
            panelThongTinThanhToan.SuspendLayout();
            SuspendLayout();
            // 
            // label1
            // 
            label1.Font = new Font("Microsoft Sans Serif", 14F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label1.ForeColor = Color.Red;
            label1.Location = new Point(394, 9);
            label1.Name = "label1";
            label1.Size = new Size(295, 56);
            label1.TabIndex = 10;
            label1.Text = "Thông tin vé";
            label1.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // thongTinHanhKhach
            // 
            thongTinHanhKhach.AutoScroll = true;
            thongTinHanhKhach.BackColor = Color.Silver;
            thongTinHanhKhach.Controls.Add(panelThongTinThanhToan);
            thongTinHanhKhach.Location = new Point(71, 81);
            thongTinHanhKhach.Margin = new Padding(3, 4, 3, 4);
            thongTinHanhKhach.Name = "thongTinHanhKhach";
            thongTinHanhKhach.Size = new Size(1051, 580);
            thongTinHanhKhach.TabIndex = 11;
            // 
            // panelThongTinThanhToan
            // 
            panelThongTinThanhToan.BackColor = Color.FromArgb(192, 255, 255);
            panelThongTinThanhToan.Controls.Add(btXacNhan);
            panelThongTinThanhToan.Controls.Add(lbTongTienSauKhuyenMai);
            panelThongTinThanhToan.Controls.Add(lbTongTienThanhToan);
            panelThongTinThanhToan.Controls.Add(label4);
            panelThongTinThanhToan.Controls.Add(label3);
            panelThongTinThanhToan.Controls.Add(label2);
            panelThongTinThanhToan.Controls.Add(cbPhuongThucThanhToan);
            panelThongTinThanhToan.Location = new Point(734, 17);
            panelThongTinThanhToan.Name = "panelThongTinThanhToan";
            panelThongTinThanhToan.Size = new Size(305, 323);
            panelThongTinThanhToan.TabIndex = 0;
            // 
            // btXacNhan
            // 
            btXacNhan.BackColor = Color.Lime;
            btXacNhan.Font = new Font("Segoe UI", 9F, FontStyle.Bold);
            btXacNhan.Location = new Point(110, 248);
            btXacNhan.Name = "btXacNhan";
            btXacNhan.Size = new Size(94, 40);
            btXacNhan.TabIndex = 22;
            btXacNhan.Text = "Xác nhận";
            btXacNhan.UseVisualStyleBackColor = false;
            btXacNhan.Click += btXacNhan_Click;
            // 
            // lbTongTienSauKhuyenMai
            // 
            lbTongTienSauKhuyenMai.AutoSize = true;
            lbTongTienSauKhuyenMai.Font = new Font("Segoe UI", 12F);
            lbTongTienSauKhuyenMai.Location = new Point(149, 116);
            lbTongTienSauKhuyenMai.Name = "lbTongTienSauKhuyenMai";
            lbTongTienSauKhuyenMai.Size = new Size(97, 28);
            lbTongTienSauKhuyenMai.TabIndex = 20;
            lbTongTienSauKhuyenMai.Text = "1.500.000";
            // 
            // lbTongTienThanhToan
            // 
            lbTongTienThanhToan.AutoSize = true;
            lbTongTienThanhToan.Font = new Font("Segoe UI", 12F);
            lbTongTienThanhToan.Location = new Point(127, 52);
            lbTongTienThanhToan.Name = "lbTongTienThanhToan";
            lbTongTienThanhToan.Size = new Size(97, 28);
            lbTongTienThanhToan.TabIndex = 18;
            lbTongTienThanhToan.Text = "1.700.000";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Font = new Font("Segoe UI", 11F);
            label4.ForeColor = Color.Blue;
            label4.Location = new Point(13, 119);
            label4.Name = "label4";
            label4.Size = new Size(141, 25);
            label4.TabIndex = 17;
            label4.Text = "Số tiền sau KM:";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Segoe UI", 11F);
            label3.ForeColor = Color.Blue;
            label3.Location = new Point(13, 55);
            label3.Name = "label3";
            label3.Size = new Size(125, 25);
            label3.TabIndex = 16;
            label3.Text = "Tổng số tiền: ";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Segoe UI", 12F, FontStyle.Bold);
            label2.Location = new Point(46, 1);
            label2.Name = "label2";
            label2.Size = new Size(214, 28);
            label2.TabIndex = 15;
            label2.Text = "Thông tin thanh toán";
            // 
            // cbPhuongThucThanhToan
            // 
            cbPhuongThucThanhToan.Font = new Font("Microsoft Sans Serif", 10F, FontStyle.Regular, GraphicsUnit.Point, 0);
            cbPhuongThucThanhToan.FormattingEnabled = true;
            cbPhuongThucThanhToan.Items.AddRange(new object[] { "Thanh toán tiền mặt", "Thanh toán chuyển khoản" });
            cbPhuongThucThanhToan.Location = new Point(16, 176);
            cbPhuongThucThanhToan.Margin = new Padding(3, 4, 3, 4);
            cbPhuongThucThanhToan.Name = "cbPhuongThucThanhToan";
            cbPhuongThucThanhToan.Size = new Size(244, 28);
            cbPhuongThucThanhToan.TabIndex = 14;
            cbPhuongThucThanhToan.Text = "Thanh toán tiền mặt";
            // 
            // DienThongTinVe
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1188, 685);
            Controls.Add(thongTinHanhKhach);
            Controls.Add(label1);
            Margin = new Padding(3, 4, 3, 4);
            Name = "DienThongTinVe";
            StartPosition = FormStartPosition.CenterScreen;
            Load += DienThongTinVe_Load;
            thongTinHanhKhach.ResumeLayout(false);
            panelThongTinThanhToan.ResumeLayout(false);
            panelThongTinThanhToan.PerformLayout();
            ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Panel thongTinHanhKhach;
        private System.Windows.Forms.ComboBox cbPhuongThucThanhToan;
        private Panel panelThongTinThanhToan;
        private Label lbTongTienThanhToan;
        private Label label4;
        private Label label3;
        private Label label2;
        private Button btXacNhan;
        private Label lbTongTienSauKhuyenMai;
    }
}