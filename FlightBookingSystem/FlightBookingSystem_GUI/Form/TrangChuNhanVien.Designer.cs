namespace FlightBookingSystem_GUI
{
    partial class TrangChuNhanVien
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(TrangChuNhanVien));
            panel1 = new Panel();
            btHuyVe = new Button();
            btThongTinVe = new Button();
            panel2 = new Panel();
            picAvatar = new PictureBox();
            lbHello = new Label();
            btLapLich = new Button();
            btBanVe = new Button();
            panelMain = new Panel();
            panel1.SuspendLayout();
            panel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)picAvatar).BeginInit();
            SuspendLayout();
            // 
            // panel1
            // 
            panel1.BackColor = Color.Lime;
            panel1.Controls.Add(btHuyVe);
            panel1.Controls.Add(btThongTinVe);
            panel1.Controls.Add(panel2);
            panel1.Controls.Add(btLapLich);
            panel1.Controls.Add(btBanVe);
            panel1.Dock = DockStyle.Left;
            panel1.Location = new Point(0, 0);
            panel1.Margin = new Padding(3, 4, 3, 4);
            panel1.Name = "panel1";
            panel1.Size = new Size(205, 837);
            panel1.TabIndex = 5;
            // 
            // btHuyVe
            // 
            btHuyVe.BackColor = Color.Transparent;
            btHuyVe.Font = new Font("Microsoft Sans Serif", 10F, FontStyle.Regular, GraphicsUnit.Point, 0);
            btHuyVe.Location = new Point(22, 470);
            btHuyVe.Margin = new Padding(3, 4, 3, 4);
            btHuyVe.Name = "btHuyVe";
            btHuyVe.Size = new Size(137, 42);
            btHuyVe.TabIndex = 9;
            btHuyVe.Text = "Hủy vé";
            btHuyVe.UseVisualStyleBackColor = false;
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
            // btLapLich
            // 
            btLapLich.BackColor = Color.Transparent;
            btLapLich.Font = new Font("Microsoft Sans Serif", 10F, FontStyle.Regular, GraphicsUnit.Point, 0);
            btLapLich.Location = new Point(22, 334);
            btLapLich.Margin = new Padding(3, 4, 3, 4);
            btLapLich.Name = "btLapLich";
            btLapLich.Size = new Size(137, 42);
            btLapLich.TabIndex = 4;
            btLapLich.Text = "Lập lịch ";
            btLapLich.UseVisualStyleBackColor = false;
            btLapLich.Click += btLapLich_Click;
            // 
            // btBanVe
            // 
            btBanVe.BackColor = Color.LightGray;
            btBanVe.Font = new Font("Microsoft Sans Serif", 10F, FontStyle.Regular, GraphicsUnit.Point, 0);
            btBanVe.Location = new Point(22, 219);
            btBanVe.Margin = new Padding(3, 4, 3, 4);
            btBanVe.Name = "btBanVe";
            btBanVe.Size = new Size(137, 42);
            btBanVe.TabIndex = 1;
            btBanVe.Text = "Bán vé";
            btBanVe.UseVisualStyleBackColor = false;
            // 
            // panelMain
            // 
            panelMain.Dock = DockStyle.Fill;
            panelMain.Location = new Point(205, 0);
            panelMain.Name = "panelMain";
            panelMain.Size = new Size(1211, 837);
            panelMain.TabIndex = 6;
            // 
            // TrangChuNhanVien
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1416, 837);
            Controls.Add(panelMain);
            Controls.Add(panel1);
            Name = "TrangChuNhanVien";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "TrangChuNhanVien";
            Load += TrangChuNhanVien_Load;
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
        private Button btLapLich;
        private Button btBanVe;
        private Panel panelMain;
    }
}