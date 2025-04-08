﻿namespace PresentationLayer
{
    partial class NguoiDungChonChuyen
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(NguoiDungChonChuyen));
            cbThoiGianBay = new ComboBox();
            cbSoDiemDung = new ComboBox();
            cbHangBay = new ComboBox();
            cacChuyenDi = new Panel();
            panel4 = new Panel();
            lbThongTinChuyenBay = new Label();
            lbNoiDen = new Label();
            pictureBox5 = new PictureBox();
            lbNoiDi = new Label();
            lbLuotDi = new Label();
            panel4.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox5).BeginInit();
            SuspendLayout();
            // 
            // cbThoiGianBay
            // 
            cbThoiGianBay.Font = new Font("Microsoft Sans Serif", 10F, FontStyle.Regular, GraphicsUnit.Point, 0);
            cbThoiGianBay.FormattingEnabled = true;
            cbThoiGianBay.Items.AddRange(new object[] { "Tất cả", "Buổi sáng", "Buổi chiều", "Buổi tối" });
            cbThoiGianBay.Location = new Point(11, 203);
            cbThoiGianBay.Margin = new Padding(3, 4, 3, 4);
            cbThoiGianBay.Name = "cbThoiGianBay";
            cbThoiGianBay.Size = new Size(153, 28);
            cbThoiGianBay.TabIndex = 4;
            cbThoiGianBay.Text = "Thời gian bay";
            cbThoiGianBay.SelectedIndexChanged += cbThoiGianBay_SelectedIndexChanged;
            // 
            // cbSoDiemDung
            // 
            cbSoDiemDung.Font = new Font("Microsoft Sans Serif", 10F, FontStyle.Regular, GraphicsUnit.Point, 0);
            cbSoDiemDung.FormattingEnabled = true;
            cbSoDiemDung.Items.AddRange(new object[] { "Tất cả", "Bay trực tiếp", "Một điểm dừng", "Hai điểm dừng" });
            cbSoDiemDung.Location = new Point(11, 281);
            cbSoDiemDung.Margin = new Padding(3, 4, 3, 4);
            cbSoDiemDung.Name = "cbSoDiemDung";
            cbSoDiemDung.Size = new Size(153, 28);
            cbSoDiemDung.TabIndex = 5;
            cbSoDiemDung.Text = "Số điểm dừng";
            cbSoDiemDung.SelectedIndexChanged += cbSoDiemDung_SelectedIndexChanged;
            // 
            // cbHangBay
            // 
            cbHangBay.Font = new Font("Microsoft Sans Serif", 10F, FontStyle.Regular, GraphicsUnit.Point, 0);
            cbHangBay.FormattingEnabled = true;
            cbHangBay.Items.AddRange(new object[] { "Tất cả", "Bamboo Airways", "VietJet Air", "Vietnam Airlines" });
            cbHangBay.Location = new Point(11, 125);
            cbHangBay.Margin = new Padding(3, 4, 3, 4);
            cbHangBay.Name = "cbHangBay";
            cbHangBay.Size = new Size(153, 28);
            cbHangBay.TabIndex = 7;
            cbHangBay.Text = "Hãng bay";
            cbHangBay.SelectedIndexChanged += cbHangBay_SelectedIndexChanged;
            // 
            // cacChuyenDi
            // 
            cacChuyenDi.AutoScroll = true;
            cacChuyenDi.BackColor = Color.Silver;
            cacChuyenDi.Location = new Point(190, 125);
            cacChuyenDi.Margin = new Padding(3, 4, 3, 4);
            cacChuyenDi.Name = "cacChuyenDi";
            cacChuyenDi.Size = new Size(693, 402);
            cacChuyenDi.TabIndex = 1;
            // 
            // panel4
            // 
            panel4.Controls.Add(lbThongTinChuyenBay);
            panel4.Controls.Add(lbNoiDen);
            panel4.Controls.Add(pictureBox5);
            panel4.Controls.Add(lbNoiDi);
            panel4.Dock = DockStyle.Top;
            panel4.Font = new Font("Microsoft Sans Serif", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            panel4.Location = new Point(0, 0);
            panel4.Margin = new Padding(3, 4, 3, 4);
            panel4.Name = "panel4";
            panel4.Size = new Size(952, 86);
            panel4.TabIndex = 11;
            // 
            // lbThongTinChuyenBay
            // 
            lbThongTinChuyenBay.AutoSize = true;
            lbThongTinChuyenBay.Location = new Point(377, 56);
            lbThongTinChuyenBay.Name = "lbThongTinChuyenBay";
            lbThongTinChuyenBay.Size = new Size(262, 18);
            lbThongTinChuyenBay.TabIndex = 3;
            lbThongTinChuyenBay.Text = "1 Người | 20/07/2025 | Phổ Thông";
            // 
            // lbNoiDen
            // 
            lbNoiDen.AutoSize = true;
            lbNoiDen.Font = new Font("Microsoft Sans Serif", 13F, FontStyle.Regular, GraphicsUnit.Point, 0);
            lbNoiDen.Location = new Point(602, 20);
            lbNoiDen.Name = "lbNoiDen";
            lbNoiDen.Size = new Size(79, 26);
            lbNoiDen.TabIndex = 2;
            lbNoiDen.Text = "Hà Nội";
            lbNoiDen.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // pictureBox5
            // 
            pictureBox5.Image = (Image)resources.GetObject("pictureBox5.Image");
            pictureBox5.Location = new Point(480, 20);
            pictureBox5.Margin = new Padding(3, 4, 3, 4);
            pictureBox5.Name = "pictureBox5";
            pictureBox5.Size = new Size(56, 32);
            pictureBox5.SizeMode = PictureBoxSizeMode.StretchImage;
            pictureBox5.TabIndex = 1;
            pictureBox5.TabStop = false;
            // 
            // lbNoiDi
            // 
            lbNoiDi.AutoSize = true;
            lbNoiDi.Font = new Font("Microsoft Sans Serif", 13F, FontStyle.Regular, GraphicsUnit.Point, 0);
            lbNoiDi.Location = new Point(297, 20);
            lbNoiDi.Name = "lbNoiDi";
            lbNoiDi.Size = new Size(132, 26);
            lbNoiDi.TabIndex = 0;
            lbNoiDi.Text = "Hồ Chí Minh";
            lbNoiDi.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // lbLuotDi
            // 
            lbLuotDi.Dock = DockStyle.Top;
            lbLuotDi.Font = new Font("Segoe UI", 13F, FontStyle.Bold);
            lbLuotDi.ForeColor = Color.Red;
            lbLuotDi.Location = new Point(0, 86);
            lbLuotDi.Name = "lbLuotDi";
            lbLuotDi.Size = new Size(952, 35);
            lbLuotDi.TabIndex = 12;
            lbLuotDi.Text = "Lượt đi";
            lbLuotDi.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // NguoiDungChonChuyen
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.Moccasin;
            ClientSize = new Size(952, 579);
            Controls.Add(lbLuotDi);
            Controls.Add(panel4);
            Controls.Add(cacChuyenDi);
            Controls.Add(cbHangBay);
            Controls.Add(cbSoDiemDung);
            Controls.Add(cbThoiGianBay);
            Margin = new Padding(3, 4, 3, 4);
            Name = "NguoiDungChonChuyen";
            ShowIcon = false;
            StartPosition = FormStartPosition.CenterScreen;
            Load += NguoiDungChonChuyen_Load;
            panel4.ResumeLayout(false);
            panel4.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox5).EndInit();
            ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.ComboBox cbThoiGianBay;
        private System.Windows.Forms.ComboBox cbSoDiemDung;
        private System.Windows.Forms.ComboBox cbHangBay;
        private System.Windows.Forms.Panel cacChuyenDi;
        private Panel panel4;
        private Label lbThongTinChuyenBay;
        private Label lbNoiDen;
        private PictureBox pictureBox5;
        private Label lbNoiDi;
        private Label lbLuotDi;
    }
}