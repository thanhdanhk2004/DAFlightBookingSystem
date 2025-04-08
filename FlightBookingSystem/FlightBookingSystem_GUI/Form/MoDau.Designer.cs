namespace FlightBookingSystem_GUI
{
    partial class MoDau
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(MoDau));
            label1 = new Label();
            thanhTrangThai = new ProgressBar();
            SuspendLayout();
            // 
            // label1
            // 
            label1.BackColor = Color.Transparent;
            label1.Dock = DockStyle.Top;
            label1.Font = new Font("Segoe UI", 20F, FontStyle.Bold);
            label1.ForeColor = Color.Red;
            label1.Location = new Point(0, 0);
            label1.Name = "label1";
            label1.Size = new Size(815, 70);
            label1.TabIndex = 0;
            label1.Text = "CODER";
            label1.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // thanhTrangThai
            // 
            thanhTrangThai.Dock = DockStyle.Bottom;
            thanhTrangThai.ForeColor = Color.Lime;
            thanhTrangThai.Location = new Point(0, 461);
            thanhTrangThai.Name = "thanhTrangThai";
            thanhTrangThai.Size = new Size(815, 24);
            thanhTrangThai.TabIndex = 1;
            // 
            // MoDau
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackgroundImage = (Image)resources.GetObject("$this.BackgroundImage");
            BackgroundImageLayout = ImageLayout.Stretch;
            ClientSize = new Size(815, 485);
            Controls.Add(thanhTrangThai);
            Controls.Add(label1);
            Name = "MoDau";
            ShowIcon = false;
            StartPosition = FormStartPosition.CenterScreen;
            Load += MoDau_Load;
            ResumeLayout(false);
        }

        #endregion

        private Label label1;
        private ProgressBar thanhTrangThai;
    }
}