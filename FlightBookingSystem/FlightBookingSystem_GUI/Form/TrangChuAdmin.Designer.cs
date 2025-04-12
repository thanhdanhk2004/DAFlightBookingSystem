namespace FlightBookingSystem_GUI
{
    partial class TrangChuAdmin
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(TrangChuAdmin));
            panel1 = new Panel();
            btHuyChuyenBay = new Button();
            btThongTinVe = new Button();
            panel2 = new Panel();
            picAvatar = new PictureBox();
            lbHello = new Label();
            btQuanLyNhanVien = new Button();
            btThongKe = new Button();
            panelMain = new Panel();
            panel1.SuspendLayout();
            panel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)picAvatar).BeginInit();
            SuspendLayout();
            // 
            // panel1
            // 
            panel1.BackColor = Color.Lime;
            panel1.Controls.Add(btHuyChuyenBay);
            panel1.Controls.Add(btThongTinVe);
            panel1.Controls.Add(panel2);
            panel1.Controls.Add(btQuanLyNhanVien);
            panel1.Controls.Add(btThongKe);
            panel1.Dock = DockStyle.Left;
            panel1.Location = new Point(0, 0);
            panel1.Margin = new Padding(3, 4, 3, 4);
            panel1.Name = "panel1";
            panel1.Size = new Size(205, 601);
            panel1.TabIndex = 6;
            // 
            // btHuyChuyenBay
            // 
            btHuyChuyenBay.BackColor = Color.Transparent;
            btHuyChuyenBay.Font = new Font("Microsoft Sans Serif", 10F, FontStyle.Regular, GraphicsUnit.Point, 0);
            btHuyChuyenBay.Location = new Point(22, 459);
            btHuyChuyenBay.Margin = new Padding(3, 4, 3, 4);
            btHuyChuyenBay.Name = "btHuyChuyenBay";
            btHuyChuyenBay.Size = new Size(137, 42);
            btHuyChuyenBay.TabIndex = 9;
            btHuyChuyenBay.Text = "Hủy chuyến bay";
            btHuyChuyenBay.UseVisualStyleBackColor = false;
            // 
            // btThongTinVe
            // 
            btThongTinVe.BackColor = Color.Transparent;
            btThongTinVe.Font = new Font("Microsoft Sans Serif", 10F, FontStyle.Regular, GraphicsUnit.Point, 0);
            btThongTinVe.Location = new Point(22, 603);
            btThongTinVe.Margin = new Padding(3, 4, 3, 4);
            btThongTinVe.Name = "btThongTinVe";
            btThongTinVe.Size = new Size(137, 42);
            btThongTinVe.TabIndex = 8;
            btThongTinVe.Text = "Thông tin vé";
            btThongTinVe.UseVisualStyleBackColor = false;
            // 
            // panel2
            // 
            panel2.BackColor = Color.MediumSpringGreen;
            panel2.Controls.Add(picAvatar);
            panel2.Controls.Add(lbHello);
            panel2.Dock = DockStyle.Top;
            panel2.Location = new Point(0, 0);
            panel2.Margin = new Padding(3, 4, 3, 4);
            panel2.Name = "panel2";
            panel2.Size = new Size(205, 165);
            panel2.TabIndex = 7;
            // 
            // picAvatar
            // 
            picAvatar.Image = (Image)resources.GetObject("picAvatar.Image");
            picAvatar.Location = new Point(68, 15);
            picAvatar.Margin = new Padding(3, 4, 3, 4);
            picAvatar.Name = "picAvatar";
            picAvatar.Size = new Size(65, 70);
            picAvatar.SizeMode = PictureBoxSizeMode.StretchImage;
            picAvatar.TabIndex = 5;
            picAvatar.TabStop = false;
            // 
            // lbHello
            // 
            lbHello.Font = new Font("Microsoft Sans Serif", 10F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lbHello.Location = new Point(29, 100);
            lbHello.Name = "lbHello";
            lbHello.Size = new Size(130, 29);
            lbHello.TabIndex = 6;
            lbHello.Text = "Hello Dân";
            lbHello.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // btQuanLyNhanVien
            // 
            btQuanLyNhanVien.BackColor = Color.Transparent;
            btQuanLyNhanVien.Font = new Font("Microsoft Sans Serif", 10F, FontStyle.Regular, GraphicsUnit.Point, 0);
            btQuanLyNhanVien.Location = new Point(22, 334);
            btQuanLyNhanVien.Margin = new Padding(3, 4, 3, 4);
            btQuanLyNhanVien.Name = "btQuanLyNhanVien";
            btQuanLyNhanVien.Size = new Size(137, 42);
            btQuanLyNhanVien.TabIndex = 4;
            btQuanLyNhanVien.Text = "Thêm tài khoản";
            btQuanLyNhanVien.UseVisualStyleBackColor = false;
            // 
            // btThongKe
            // 
            btThongKe.BackColor = Color.LightGray;
            btThongKe.Font = new Font("Microsoft Sans Serif", 10F, FontStyle.Regular, GraphicsUnit.Point, 0);
            btThongKe.Location = new Point(22, 219);
            btThongKe.Margin = new Padding(3, 4, 3, 4);
            btThongKe.Name = "btThongKe";
            btThongKe.Size = new Size(137, 42);
            btThongKe.TabIndex = 1;
            btThongKe.Text = "Thống kê";
            btThongKe.UseVisualStyleBackColor = false;
            btThongKe.Click += btThongKe_Click;
            // 
            // panelMain
            // 
            panelMain.Dock = DockStyle.Fill;
            panelMain.Location = new Point(205, 0);
            panelMain.Name = "panelMain";
            panelMain.Size = new Size(978, 601);
            panelMain.TabIndex = 7;
            // 
            // TrangChuAdmin
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1183, 601);
            Controls.Add(panelMain);
            Controls.Add(panel1);
            Name = "TrangChuAdmin";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "TrangChuAdmin";
            Load += TrangChuAdmin_Load;
            panel1.ResumeLayout(false);
            panel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)picAvatar).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private Panel panel1;
        private Button btHuyVe;
        private Button btThongTinVe;
        private Panel panel2;
        private PictureBox picAvatar;
        private Label lbHello;
        private Button btQuanLyNhanVien;
        private Button btThongKe;
        private Button btHuyChuyenBay;
        private Panel panelMain;
    }
}