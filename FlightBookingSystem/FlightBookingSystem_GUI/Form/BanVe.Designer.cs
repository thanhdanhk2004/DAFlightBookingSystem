namespace PresentationLayer
{
    partial class BanVe
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(BanVe));
            panelMain = new Panel();
            btChonChuyen = new Button();
            checkBoxKhuHoi = new CheckBox();
            btTImKiem = new Button();
            label7 = new Label();
            ngayVe = new DateTimePicker();
            label8 = new Label();
            ngayDi = new DateTimePicker();
            label6 = new Label();
            cbHangVe = new ComboBox();
            label5 = new Label();
            cbLoaiVe = new ComboBox();
            label4 = new Label();
            cbSoLuongve = new ComboBox();
            picSwap = new PictureBox();
            label3 = new Label();
            cbNoiDen = new ComboBox();
            label2 = new Label();
            cbNoiDi = new ComboBox();
            dgvChuyenBay = new DataGridView();
            MaCB = new DataGridViewTextBoxColumn();
            HangHangKhong = new DataGridViewTextBoxColumn();
            NoiDi = new DataGridViewTextBoxColumn();
            NoiDen = new DataGridViewTextBoxColumn();
            ThoiGianDi = new DataGridViewTextBoxColumn();
            ThoiGianDen = new DataGridViewTextBoxColumn();
            SoDiemDung = new DataGridViewTextBoxColumn();
            SoTien = new DataGridViewTextBoxColumn();
            pictureBox1 = new PictureBox();
            label1 = new Label();
            panelMain.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)picSwap).BeginInit();
            ((System.ComponentModel.ISupportInitialize)dgvChuyenBay).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            SuspendLayout();
            // 
            // panelMain
            // 
            panelMain.Controls.Add(btChonChuyen);
            panelMain.Controls.Add(checkBoxKhuHoi);
            panelMain.Controls.Add(btTImKiem);
            panelMain.Controls.Add(label7);
            panelMain.Controls.Add(ngayVe);
            panelMain.Controls.Add(label8);
            panelMain.Controls.Add(ngayDi);
            panelMain.Controls.Add(label6);
            panelMain.Controls.Add(cbHangVe);
            panelMain.Controls.Add(label5);
            panelMain.Controls.Add(cbLoaiVe);
            panelMain.Controls.Add(label4);
            panelMain.Controls.Add(cbSoLuongve);
            panelMain.Controls.Add(picSwap);
            panelMain.Controls.Add(label3);
            panelMain.Controls.Add(cbNoiDen);
            panelMain.Controls.Add(label2);
            panelMain.Controls.Add(cbNoiDi);
            panelMain.Controls.Add(dgvChuyenBay);
            panelMain.Controls.Add(pictureBox1);
            panelMain.Controls.Add(label1);
            panelMain.Dock = DockStyle.Fill;
            panelMain.Location = new Point(0, 0);
            panelMain.Name = "panelMain";
            panelMain.Size = new Size(1220, 837);
            panelMain.TabIndex = 5;
            // 
            // btChonChuyen
            // 
            btChonChuyen.BackColor = Color.LightGray;
            btChonChuyen.Font = new Font("Microsoft Sans Serif", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btChonChuyen.ForeColor = Color.Red;
            btChonChuyen.Location = new Point(497, 774);
            btChonChuyen.Margin = new Padding(3, 4, 3, 4);
            btChonChuyen.Name = "btChonChuyen";
            btChonChuyen.Size = new Size(125, 48);
            btChonChuyen.TabIndex = 49;
            btChonChuyen.Text = "Chọn chuyến";
            btChonChuyen.UseVisualStyleBackColor = false;
            btChonChuyen.Click += btChonChuyen_Click;
            // 
            // checkBoxKhuHoi
            // 
            checkBoxKhuHoi.Font = new Font("Segoe UI", 15F);
            checkBoxKhuHoi.Location = new Point(430, 728);
            checkBoxKhuHoi.Name = "checkBoxKhuHoi";
            checkBoxKhuHoi.Size = new Size(27, 30);
            checkBoxKhuHoi.TabIndex = 48;
            checkBoxKhuHoi.UseVisualStyleBackColor = true;
            checkBoxKhuHoi.CheckedChanged += checkBoxKhuHoi_CheckedChanged;
            // 
            // btTImKiem
            // 
            btTImKiem.BackColor = Color.LightGray;
            btTImKiem.Font = new Font("Microsoft Sans Serif", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btTImKiem.ForeColor = Color.Red;
            btTImKiem.Location = new Point(773, 681);
            btTImKiem.Margin = new Padding(3, 4, 3, 4);
            btTImKiem.Name = "btTImKiem";
            btTImKiem.Size = new Size(125, 48);
            btTImKiem.TabIndex = 47;
            btTImKiem.Text = "Tìm chuyến";
            btTImKiem.UseVisualStyleBackColor = false;
            btTImKiem.Click += btTImKiem_Click;
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.Font = new Font("Microsoft Sans Serif", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label7.Location = new Point(340, 728);
            label7.Name = "label7";
            label7.Size = new Size(90, 25);
            label7.TabIndex = 46;
            label7.Text = "Ngày về:";
            // 
            // ngayVe
            // 
            ngayVe.Location = new Point(458, 726);
            ngayVe.Margin = new Padding(3, 4, 3, 4);
            ngayVe.Name = "ngayVe";
            ngayVe.Size = new Size(233, 27);
            ngayVe.TabIndex = 45;
            // 
            // label8
            // 
            label8.AutoSize = true;
            label8.Font = new Font("Microsoft Sans Serif", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label8.Location = new Point(340, 666);
            label8.Name = "label8";
            label8.Size = new Size(84, 25);
            label8.TabIndex = 44;
            label8.Text = "Ngày đi:";
            // 
            // ngayDi
            // 
            ngayDi.Location = new Point(458, 664);
            ngayDi.Margin = new Padding(3, 4, 3, 4);
            ngayDi.Name = "ngayDi";
            ngayDi.Size = new Size(233, 27);
            ngayDi.TabIndex = 43;
            ngayDi.ValueChanged += ngayDi_ValueChanged;
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Font = new Font("Microsoft Sans Serif", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label6.Location = new Point(17, 771);
            label6.Name = "label6";
            label6.Size = new Size(85, 25);
            label6.TabIndex = 42;
            label6.Text = "Hạng vé";
            // 
            // cbHangVe
            // 
            cbHangVe.Font = new Font("Microsoft Sans Serif", 10F, FontStyle.Regular, GraphicsUnit.Point, 0);
            cbHangVe.FormattingEnabled = true;
            cbHangVe.Items.AddRange(new object[] { "Phổ thông", "Thương gia" });
            cbHangVe.Location = new Point(144, 768);
            cbHangVe.Margin = new Padding(3, 4, 3, 4);
            cbHangVe.Name = "cbHangVe";
            cbHangVe.Size = new Size(112, 28);
            cbHangVe.TabIndex = 41;
            cbHangVe.Text = "Phổ thông";
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Font = new Font("Microsoft Sans Serif", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label5.Location = new Point(17, 718);
            label5.Name = "label5";
            label5.Size = new Size(81, 25);
            label5.TabIndex = 40;
            label5.Text = "Loại vé:";
            // 
            // cbLoaiVe
            // 
            cbLoaiVe.Font = new Font("Microsoft Sans Serif", 10F, FontStyle.Regular, GraphicsUnit.Point, 0);
            cbLoaiVe.FormattingEnabled = true;
            cbLoaiVe.Items.AddRange(new object[] { "Một chiều", "Khứ hồi" });
            cbLoaiVe.Location = new Point(144, 715);
            cbLoaiVe.Margin = new Padding(3, 4, 3, 4);
            cbLoaiVe.Name = "cbLoaiVe";
            cbLoaiVe.Size = new Size(112, 28);
            cbLoaiVe.TabIndex = 39;
            cbLoaiVe.Text = "Một chiều";
            cbLoaiVe.SelectedIndexChanged += cbLoaiVe_SelectedIndexChanged;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Font = new Font("Microsoft Sans Serif", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label4.Location = new Point(17, 670);
            label4.Name = "label4";
            label4.Size = new Size(122, 25);
            label4.TabIndex = 38;
            label4.Text = "Số lượng vé:";
            // 
            // cbSoLuongve
            // 
            cbSoLuongve.Font = new Font("Microsoft Sans Serif", 10F, FontStyle.Regular, GraphicsUnit.Point, 0);
            cbSoLuongve.FormattingEnabled = true;
            cbSoLuongve.Items.AddRange(new object[] { "1", "2", "3", "4", "5" });
            cbSoLuongve.Location = new Point(145, 667);
            cbSoLuongve.Margin = new Padding(3, 4, 3, 4);
            cbSoLuongve.Name = "cbSoLuongve";
            cbSoLuongve.Size = new Size(111, 28);
            cbSoLuongve.TabIndex = 37;
            cbSoLuongve.Text = "1";
            // 
            // picSwap
            // 
            picSwap.Image = (Image)resources.GetObject("picSwap.Image");
            picSwap.Location = new Point(458, 584);
            picSwap.Margin = new Padding(3, 4, 3, 4);
            picSwap.Name = "picSwap";
            picSwap.Size = new Size(42, 44);
            picSwap.SizeMode = PictureBoxSizeMode.StretchImage;
            picSwap.TabIndex = 36;
            picSwap.TabStop = false;
            picSwap.Click += picSwap_Click;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Microsoft Sans Serif", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label3.Location = new Point(623, 545);
            label3.Name = "label3";
            label3.Size = new Size(79, 25);
            label3.TabIndex = 35;
            label3.Text = "Nơi đến";
            // 
            // cbNoiDen
            // 
            cbNoiDen.Font = new Font("Microsoft Sans Serif", 10F, FontStyle.Regular, GraphicsUnit.Point, 0);
            cbNoiDen.FormattingEnabled = true;
            cbNoiDen.Location = new Point(547, 593);
            cbNoiDen.Margin = new Padding(3, 4, 3, 4);
            cbNoiDen.Name = "cbNoiDen";
            cbNoiDen.Size = new Size(233, 28);
            cbNoiDen.TabIndex = 34;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Microsoft Sans Serif", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label2.Location = new Point(261, 545);
            label2.Name = "label2";
            label2.Size = new Size(61, 25);
            label2.TabIndex = 33;
            label2.Text = "Nơi đi";
            // 
            // cbNoiDi
            // 
            cbNoiDi.Font = new Font("Microsoft Sans Serif", 10F, FontStyle.Regular, GraphicsUnit.Point, 0);
            cbNoiDi.FormattingEnabled = true;
            cbNoiDi.Location = new Point(185, 593);
            cbNoiDi.Margin = new Padding(3, 4, 3, 4);
            cbNoiDi.Name = "cbNoiDi";
            cbNoiDi.Size = new Size(233, 28);
            cbNoiDi.TabIndex = 32;
            // 
            // dgvChuyenBay
            // 
            dgvChuyenBay.AllowUserToAddRows = false;
            dgvChuyenBay.AllowUserToDeleteRows = false;
            dgvChuyenBay.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgvChuyenBay.Columns.AddRange(new DataGridViewColumn[] { MaCB, HangHangKhong, NoiDi, NoiDen, ThoiGianDi, ThoiGianDen, SoDiemDung, SoTien });
            dgvChuyenBay.Location = new Point(31, 98);
            dgvChuyenBay.Name = "dgvChuyenBay";
            dgvChuyenBay.ReadOnly = true;
            dgvChuyenBay.RowHeadersWidth = 51;
            dgvChuyenBay.Size = new Size(1163, 420);
            dgvChuyenBay.TabIndex = 31;
            // 
            // MaCB
            // 
            MaCB.HeaderText = "Mã";
            MaCB.MinimumWidth = 6;
            MaCB.Name = "MaCB";
            MaCB.ReadOnly = true;
            MaCB.Width = 70;
            // 
            // HangHangKhong
            // 
            HangHangKhong.HeaderText = "Hãng hàng không";
            HangHangKhong.MinimumWidth = 6;
            HangHangKhong.Name = "HangHangKhong";
            HangHangKhong.ReadOnly = true;
            HangHangKhong.Width = 170;
            // 
            // NoiDi
            // 
            NoiDi.HeaderText = "Nơi đi";
            NoiDi.MinimumWidth = 6;
            NoiDi.Name = "NoiDi";
            NoiDi.ReadOnly = true;
            NoiDi.Width = 125;
            // 
            // NoiDen
            // 
            NoiDen.HeaderText = "Nơi đến";
            NoiDen.MinimumWidth = 6;
            NoiDen.Name = "NoiDen";
            NoiDen.ReadOnly = true;
            NoiDen.Width = 125;
            // 
            // ThoiGianDi
            // 
            ThoiGianDi.HeaderText = "Thời gian đi";
            ThoiGianDi.MinimumWidth = 6;
            ThoiGianDi.Name = "ThoiGianDi";
            ThoiGianDi.ReadOnly = true;
            ThoiGianDi.Width = 160;
            // 
            // ThoiGianDen
            // 
            ThoiGianDen.HeaderText = "Thời gian đến";
            ThoiGianDen.MinimumWidth = 6;
            ThoiGianDen.Name = "ThoiGianDen";
            ThoiGianDen.ReadOnly = true;
            ThoiGianDen.Width = 160;
            // 
            // SoDiemDung
            // 
            SoDiemDung.HeaderText = "Số điểm dừng";
            SoDiemDung.MinimumWidth = 6;
            SoDiemDung.Name = "SoDiemDung";
            SoDiemDung.ReadOnly = true;
            SoDiemDung.Width = 150;
            // 
            // SoTien
            // 
            SoTien.HeaderText = "Số tiền (VND)";
            SoTien.MinimumWidth = 6;
            SoTien.Name = "SoTien";
            SoTien.ReadOnly = true;
            SoTien.Width = 150;
            // 
            // pictureBox1
            // 
            pictureBox1.Image = (Image)resources.GetObject("pictureBox1.Image");
            pictureBox1.Location = new Point(573, 26);
            pictureBox1.Margin = new Padding(3, 4, 3, 4);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(49, 44);
            pictureBox1.SizeMode = PictureBoxSizeMode.StretchImage;
            pictureBox1.TabIndex = 30;
            pictureBox1.TabStop = false;
            // 
            // label1
            // 
            label1.Font = new Font("Microsoft Sans Serif", 14F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label1.ForeColor = Color.Red;
            label1.Location = new Point(362, 14);
            label1.Name = "label1";
            label1.Size = new Size(295, 56);
            label1.TabIndex = 29;
            label1.Text = "Bán vé";
            label1.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // BanVe
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1220, 837);
            Controls.Add(panelMain);
            Margin = new Padding(3, 4, 3, 4);
            Name = "BanVe";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "BanVe";
            Load += BanVe_Load;
            panelMain.ResumeLayout(false);
            panelMain.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)picSwap).EndInit();
            ((System.ComponentModel.ISupportInitialize)dgvChuyenBay).EndInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            ResumeLayout(false);

        }

        #endregion
        private Panel panelMain;
        private Button btChonChuyen;
        private CheckBox checkBoxKhuHoi;
        private Button btTImKiem;
        private Label label7;
        private DateTimePicker ngayVe;
        private Label label8;
        private DateTimePicker ngayDi;
        private Label label6;
        private ComboBox cbHangVe;
        private Label label5;
        private ComboBox cbLoaiVe;
        private Label label4;
        private ComboBox cbSoLuongve;
        private PictureBox picSwap;
        private Label label3;
        private ComboBox cbNoiDen;
        private Label label2;
        private ComboBox cbNoiDi;
        private DataGridView dgvChuyenBay;
        private DataGridViewTextBoxColumn MaCB;
        private DataGridViewTextBoxColumn HangHangKhong;
        private DataGridViewTextBoxColumn NoiDi;
        private DataGridViewTextBoxColumn NoiDen;
        private DataGridViewTextBoxColumn ThoiGianDi;
        private DataGridViewTextBoxColumn ThoiGianDen;
        private DataGridViewTextBoxColumn SoDiemDung;
        private DataGridViewTextBoxColumn SoTien;
        private PictureBox pictureBox1;
        private Label label1;
    }
}