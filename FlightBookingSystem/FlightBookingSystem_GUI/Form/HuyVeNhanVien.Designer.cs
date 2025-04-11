namespace FlightBookingSystem_GUI
{
    partial class HuyVeNhanVien
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
            txtMa = new TextBox();
            label1 = new Label();
            label2 = new Label();
            btTimKiem = new Button();
            label3 = new Label();
            dvgThongTinVe = new DataGridView();
            MaCTV = new DataGridViewTextBoxColumn();
            HoTen = new DataGridViewTextBoxColumn();
            SoCCCD = new DataGridViewTextBoxColumn();
            NoiDi = new DataGridViewTextBoxColumn();
            NoiDen = new DataGridViewTextBoxColumn();
            NgayDi = new DataGridViewTextBoxColumn();
            GiaVe = new DataGridViewTextBoxColumn();
            TrangThaiVe = new DataGridViewTextBoxColumn();
            btHuy = new Button();
            ((System.ComponentModel.ISupportInitialize)dvgThongTinVe).BeginInit();
            SuspendLayout();
            // 
            // txtMa
            // 
            txtMa.Location = new Point(44, 109);
            txtMa.Name = "txtMa";
            txtMa.Size = new Size(331, 27);
            txtMa.TabIndex = 0;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(44, 70);
            label1.Name = "label1";
            label1.Size = new Size(334, 20);
            label1.TabIndex = 1;
            label1.Text = "Vui lòng nhập mã vé hoặc số Căn cước công dân:";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Segoe UI", 13F, FontStyle.Bold);
            label2.ForeColor = Color.Red;
            label2.Location = new Point(587, 9);
            label2.Name = "label2";
            label2.Size = new Size(92, 30);
            label2.TabIndex = 2;
            label2.Text = "HỦY VÉ";
            // 
            // btTimKiem
            // 
            btTimKiem.BackColor = Color.Lime;
            btTimKiem.Location = new Point(401, 102);
            btTimKiem.Name = "btTimKiem";
            btTimKiem.Size = new Size(94, 40);
            btTimKiem.TabIndex = 3;
            btTimKiem.Text = "Tìm kiếm";
            btTimKiem.UseVisualStyleBackColor = false;
            btTimKiem.Click += timKiem_Click;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Segoe UI", 13F, FontStyle.Bold);
            label3.ForeColor = Color.Red;
            label3.Location = new Point(522, 181);
            label3.Name = "label3";
            label3.Size = new Size(143, 30);
            label3.TabIndex = 5;
            label3.Text = "Thông tin vé";
            // 
            // dvgThongTinVe
            // 
            dvgThongTinVe.AllowUserToAddRows = false;
            dvgThongTinVe.AllowUserToDeleteRows = false;
            dvgThongTinVe.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dvgThongTinVe.Columns.AddRange(new DataGridViewColumn[] { MaCTV, HoTen, SoCCCD, NoiDi, NoiDen, NgayDi, GiaVe, TrangThaiVe });
            dvgThongTinVe.Location = new Point(12, 246);
            dvgThongTinVe.Name = "dvgThongTinVe";
            dvgThongTinVe.ReadOnly = true;
            dvgThongTinVe.RowHeadersWidth = 51;
            dvgThongTinVe.Size = new Size(1184, 262);
            dvgThongTinVe.TabIndex = 6;
            // 
            // MaCTV
            // 
            MaCTV.HeaderText = "Mã Vé";
            MaCTV.MinimumWidth = 6;
            MaCTV.Name = "MaCTV";
            MaCTV.ReadOnly = true;
            MaCTV.Width = 125;
            // 
            // HoTen
            // 
            HoTen.HeaderText = "Họ Tên";
            HoTen.MinimumWidth = 6;
            HoTen.Name = "HoTen";
            HoTen.ReadOnly = true;
            HoTen.Width = 125;
            // 
            // SoCCCD
            // 
            SoCCCD.HeaderText = "Số CCCD";
            SoCCCD.MinimumWidth = 6;
            SoCCCD.Name = "SoCCCD";
            SoCCCD.ReadOnly = true;
            SoCCCD.Width = 150;
            // 
            // NoiDi
            // 
            NoiDi.HeaderText = "Địa điểm đi";
            NoiDi.MinimumWidth = 6;
            NoiDi.Name = "NoiDi";
            NoiDi.ReadOnly = true;
            NoiDi.Width = 150;
            // 
            // NoiDen
            // 
            NoiDen.HeaderText = "Địa điểm đến";
            NoiDen.MinimumWidth = 6;
            NoiDen.Name = "NoiDen";
            NoiDen.ReadOnly = true;
            NoiDen.Width = 150;
            // 
            // NgayDi
            // 
            NgayDi.HeaderText = "Ngày đi";
            NgayDi.MinimumWidth = 6;
            NgayDi.Name = "NgayDi";
            NgayDi.ReadOnly = true;
            NgayDi.Width = 150;
            // 
            // GiaVe
            // 
            GiaVe.HeaderText = "Giá vé";
            GiaVe.MinimumWidth = 6;
            GiaVe.Name = "GiaVe";
            GiaVe.ReadOnly = true;
            GiaVe.Width = 130;
            // 
            // TrangThaiVe
            // 
            TrangThaiVe.HeaderText = "Trạng thái vé";
            TrangThaiVe.MinimumWidth = 6;
            TrangThaiVe.Name = "TrangThaiVe";
            TrangThaiVe.ReadOnly = true;
            TrangThaiVe.Width = 150;
            // 
            // btHuy
            // 
            btHuy.BackColor = Color.FromArgb(128, 255, 128);
            btHuy.Enabled = false;
            btHuy.Font = new Font("Segoe UI", 13F);
            btHuy.Location = new Point(538, 579);
            btHuy.Name = "btHuy";
            btHuy.Size = new Size(141, 52);
            btHuy.TabIndex = 7;
            btHuy.Text = "Hủy vé";
            btHuy.UseVisualStyleBackColor = false;
            btHuy.Click += btHuy_Click;
            // 
            // HuyVeNhanVien
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.FromArgb(255, 192, 192);
            ClientSize = new Size(1208, 679);
            Controls.Add(btHuy);
            Controls.Add(dvgThongTinVe);
            Controls.Add(label3);
            Controls.Add(btTimKiem);
            Controls.Add(label2);
            Controls.Add(label1);
            Controls.Add(txtMa);
            Name = "HuyVeNhanVien";
            Text = "HuyVeNhanVien";
            Load += HuyVeNhanVien_Load;
            ((System.ComponentModel.ISupportInitialize)dvgThongTinVe).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private TextBox txtMa;
        private Label label1;
        private Label label2;
        private Button btTimKiem;
        private Label label3;
        private DataGridView dvgThongTinVe;
        private DataGridViewTextBoxColumn MaCTV;
        private DataGridViewTextBoxColumn HoTen;
        private DataGridViewTextBoxColumn SoCCCD;
        private DataGridViewTextBoxColumn NoiDi;
        private DataGridViewTextBoxColumn NoiDen;
        private DataGridViewTextBoxColumn NgayDi;
        private DataGridViewTextBoxColumn GiaVe;
        private DataGridViewTextBoxColumn TrangThaiVe;
        private Button btHuy;
    }
}