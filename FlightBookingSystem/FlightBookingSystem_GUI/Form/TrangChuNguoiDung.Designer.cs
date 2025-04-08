namespace FlightBookingSystem_GUI
{
    partial class TrangChuNguoiDung
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(TrangChuNguoiDung));
            picChatBox = new PictureBox();
            panel1 = new Panel();
            txtHello = new Label();
            picAvata = new PictureBox();
            button3 = new Button();
            btDangXuat = new Button();
            btLienHe = new Button();
            btDatVe = new Button();
            pictureBox1 = new PictureBox();
            panelMain = new Panel();
            ((System.ComponentModel.ISupportInitialize)picChatBox).BeginInit();
            panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)picAvata).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            SuspendLayout();
            // 
            // picChatBox
            // 
            picChatBox.Image = (Image)resources.GetObject("picChatBox.Image");
            picChatBox.Location = new Point(844, 644);
            picChatBox.Margin = new Padding(3, 4, 3, 4);
            picChatBox.Name = "picChatBox";
            picChatBox.Size = new Size(53, 56);
            picChatBox.SizeMode = PictureBoxSizeMode.StretchImage;
            picChatBox.TabIndex = 5;
            picChatBox.TabStop = false;
            // 
            // panel1
            // 
            panel1.BackColor = Color.MistyRose;
            panel1.Controls.Add(txtHello);
            panel1.Controls.Add(picAvata);
            panel1.Controls.Add(button3);
            panel1.Controls.Add(btDangXuat);
            panel1.Controls.Add(btLienHe);
            panel1.Controls.Add(btDatVe);
            panel1.Controls.Add(pictureBox1);
            panel1.Dock = DockStyle.Top;
            panel1.Location = new Point(0, 0);
            panel1.Margin = new Padding(3, 4, 3, 4);
            panel1.Name = "panel1";
            panel1.Size = new Size(956, 114);
            panel1.TabIndex = 4;
            // 
            // txtHello
            // 
            txtHello.AutoSize = true;
            txtHello.Font = new Font("Segoe UI", 10F, FontStyle.Bold);
            txtHello.Location = new Point(832, 72);
            txtHello.Name = "txtHello";
            txtHello.Size = new Size(52, 23);
            txtHello.TabIndex = 6;
            txtHello.Text = "Hello";
            // 
            // picAvata
            // 
            picAvata.Image = (Image)resources.GetObject("picAvata.Image");
            picAvata.Location = new Point(865, 15);
            picAvata.Margin = new Padding(3, 4, 3, 4);
            picAvata.Name = "picAvata";
            picAvata.Size = new Size(52, 45);
            picAvata.SizeMode = PictureBoxSizeMode.StretchImage;
            picAvata.TabIndex = 5;
            picAvata.TabStop = false;
            // 
            // button3
            // 
            button3.BackColor = Color.Transparent;
            button3.Font = new Font("Microsoft Sans Serif", 10F, FontStyle.Regular, GraphicsUnit.Point, 0);
            button3.Location = new Point(317, 15);
            button3.Margin = new Padding(3, 4, 3, 4);
            button3.Name = "button3";
            button3.Size = new Size(137, 42);
            button3.TabIndex = 4;
            button3.Text = "Ưu đãi";
            button3.UseVisualStyleBackColor = false;
            // 
            // btDangXuat
            // 
            btDangXuat.Font = new Font("Microsoft Sans Serif", 10F, FontStyle.Regular, GraphicsUnit.Point, 0);
            btDangXuat.Location = new Point(626, 15);
            btDangXuat.Margin = new Padding(3, 4, 3, 4);
            btDangXuat.Name = "btDangXuat";
            btDangXuat.Size = new Size(137, 42);
            btDangXuat.TabIndex = 3;
            btDangXuat.Text = "Đăng xuất";
            btDangXuat.UseVisualStyleBackColor = true;
            btDangXuat.Click += btDangXuat_Click;
            // 
            // btLienHe
            // 
            btLienHe.Font = new Font("Microsoft Sans Serif", 10F, FontStyle.Regular, GraphicsUnit.Point, 0);
            btLienHe.Location = new Point(471, 15);
            btLienHe.Margin = new Padding(3, 4, 3, 4);
            btLienHe.Name = "btLienHe";
            btLienHe.Size = new Size(137, 42);
            btLienHe.TabIndex = 2;
            btLienHe.Text = "Liên hệ";
            btLienHe.UseVisualStyleBackColor = true;
            // 
            // btDatVe
            // 
            btDatVe.BackColor = Color.LightGray;
            btDatVe.Font = new Font("Microsoft Sans Serif", 10F, FontStyle.Regular, GraphicsUnit.Point, 0);
            btDatVe.Location = new Point(159, 15);
            btDatVe.Margin = new Padding(3, 4, 3, 4);
            btDatVe.Name = "btDatVe";
            btDatVe.Size = new Size(137, 42);
            btDatVe.TabIndex = 1;
            btDatVe.Text = "Đặt Vé";
            btDatVe.UseVisualStyleBackColor = false;
            // 
            // pictureBox1
            // 
            pictureBox1.Image = (Image)resources.GetObject("pictureBox1.Image");
            pictureBox1.Location = new Point(22, 4);
            pictureBox1.Margin = new Padding(3, 4, 3, 4);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(55, 62);
            pictureBox1.SizeMode = PictureBoxSizeMode.StretchImage;
            pictureBox1.TabIndex = 0;
            pictureBox1.TabStop = false;
            // 
            // panelMain
            // 
            panelMain.Dock = DockStyle.Fill;
            panelMain.Location = new Point(0, 114);
            panelMain.Name = "panelMain";
            panelMain.Size = new Size(956, 703);
            panelMain.TabIndex = 6;
            // 
            // TrangChuNguoiDung
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.Moccasin;
            ClientSize = new Size(956, 817);
            Controls.Add(panelMain);
            Controls.Add(picChatBox);
            Controls.Add(panel1);
            Name = "TrangChuNguoiDung";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "TrangChuNguoiDung";
            Load += TrangChuNguoiDung_Load;
            ((System.ComponentModel.ISupportInitialize)picChatBox).EndInit();
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)picAvata).EndInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            ResumeLayout(false);
        }

        #endregion
        private PictureBox picChatBox;
        private Panel panel1;
        private Label txtHello;
        private PictureBox picAvata;
        private Button button3;
        private Button button2;
        private Button btLienHe;
        private Button btDatVe;
        private PictureBox pictureBox1;
        private Button btDangXuat;
        private Panel panelMain;
    }
}