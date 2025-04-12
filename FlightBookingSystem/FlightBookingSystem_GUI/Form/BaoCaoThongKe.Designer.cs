namespace FlightBookingSystem_GUI
{
    partial class BaoCaoThongKe
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
            groupBox1 = new GroupBox();
            rbDuong = new RadioButton();
            rdTron = new RadioButton();
            rdCot = new RadioButton();
            groupBox2 = new GroupBox();
            rdNam = new RadioButton();
            rdQuy = new RadioButton();
            rdThang = new RadioButton();
            panelChart = new Panel();
            groupBox1.SuspendLayout();
            groupBox2.SuspendLayout();
            SuspendLayout();
            // 
            // label1
            // 
            label1.Dock = DockStyle.Top;
            label1.Font = new Font("Segoe UI", 13F, FontStyle.Bold);
            label1.ForeColor = Color.Red;
            label1.Location = new Point(0, 0);
            label1.Name = "label1";
            label1.Size = new Size(1021, 30);
            label1.TabIndex = 9;
            label1.Text = "Thống kê doanh số";
            label1.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // groupBox1
            // 
            groupBox1.BackColor = Color.White;
            groupBox1.Controls.Add(rbDuong);
            groupBox1.Controls.Add(rdTron);
            groupBox1.Controls.Add(rdCot);
            groupBox1.Font = new Font("Segoe UI", 11F, FontStyle.Bold);
            groupBox1.Location = new Point(307, 440);
            groupBox1.Name = "groupBox1";
            groupBox1.Size = new Size(171, 129);
            groupBox1.TabIndex = 14;
            groupBox1.TabStop = false;
            groupBox1.Text = "Dạng biểu đồ";
            // 
            // rbDuong
            // 
            rbDuong.AutoSize = true;
            rbDuong.Font = new Font("Segoe UI", 10F);
            rbDuong.Location = new Point(16, 96);
            rbDuong.Name = "rbDuong";
            rbDuong.Size = new Size(144, 27);
            rbDuong.TabIndex = 2;
            rbDuong.Text = "Biểu đồ đường";
            rbDuong.UseVisualStyleBackColor = true;
            // 
            // rdTron
            // 
            rdTron.AutoSize = true;
            rdTron.Font = new Font("Segoe UI", 10F);
            rdTron.Location = new Point(16, 63);
            rdTron.Name = "rdTron";
            rdTron.Size = new Size(126, 27);
            rdTron.TabIndex = 1;
            rdTron.Text = "Biểu đồ tròn";
            rdTron.UseVisualStyleBackColor = true;
            // 
            // rdCot
            // 
            rdCot.AutoSize = true;
            rdCot.Checked = true;
            rdCot.Font = new Font("Segoe UI", 10F);
            rdCot.Location = new Point(16, 30);
            rdCot.Name = "rdCot";
            rdCot.Size = new Size(118, 27);
            rdCot.TabIndex = 0;
            rdCot.TabStop = true;
            rdCot.Text = "Biểu đồ cột";
            rdCot.UseVisualStyleBackColor = true;
            // 
            // groupBox2
            // 
            groupBox2.BackColor = Color.White;
            groupBox2.Controls.Add(rdNam);
            groupBox2.Controls.Add(rdQuy);
            groupBox2.Controls.Add(rdThang);
            groupBox2.Font = new Font("Segoe UI", 11F, FontStyle.Bold);
            groupBox2.Location = new Point(569, 440);
            groupBox2.Name = "groupBox2";
            groupBox2.Size = new Size(171, 129);
            groupBox2.TabIndex = 15;
            groupBox2.TabStop = false;
            groupBox2.Text = "Mốc thời gian";
            // 
            // rdNam
            // 
            rdNam.AutoSize = true;
            rdNam.Font = new Font("Segoe UI", 10F);
            rdNam.Location = new Point(16, 96);
            rdNam.Name = "rdNam";
            rdNam.Size = new Size(108, 27);
            rdNam.TabIndex = 2;
            rdNam.Text = "Theo năm";
            rdNam.UseVisualStyleBackColor = true;
            // 
            // rdQuy
            // 
            rdQuy.AutoSize = true;
            rdQuy.Font = new Font("Segoe UI", 10F);
            rdQuy.Location = new Point(16, 63);
            rdQuy.Name = "rdQuy";
            rdQuy.Size = new Size(102, 27);
            rdQuy.TabIndex = 1;
            rdQuy.Text = "Theo quý";
            rdQuy.UseVisualStyleBackColor = true;
            // 
            // rdThang
            // 
            rdThang.AutoSize = true;
            rdThang.Checked = true;
            rdThang.Font = new Font("Segoe UI", 10F);
            rdThang.Location = new Point(16, 30);
            rdThang.Name = "rdThang";
            rdThang.Size = new Size(119, 27);
            rdThang.TabIndex = 0;
            rdThang.TabStop = true;
            rdThang.Text = "Theo tháng";
            rdThang.UseVisualStyleBackColor = true;
            // 
            // panelChart
            // 
            panelChart.Location = new Point(44, 48);
            panelChart.Name = "panelChart";
            panelChart.Size = new Size(948, 376);
            panelChart.TabIndex = 16;
            // 
            // BaoCaoThongKe
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.FromArgb(255, 255, 192);
            ClientSize = new Size(1021, 581);
            Controls.Add(panelChart);
            Controls.Add(groupBox2);
            Controls.Add(groupBox1);
            Controls.Add(label1);
            Name = "BaoCaoThongKe";
            Text = "BaoCaoThongKe";
            Load += BaoCaoThongKe_Load;
            groupBox1.ResumeLayout(false);
            groupBox1.PerformLayout();
            groupBox2.ResumeLayout(false);
            groupBox2.PerformLayout();
            ResumeLayout(false);
        }

        #endregion

        private Label label1;
        private GroupBox groupBox1;
        private RadioButton rbDuong;
        private RadioButton rdTron;
        private RadioButton rdCot;
        private GroupBox groupBox2;
        private RadioButton rdNam;
        private RadioButton rdQuy;
        private RadioButton rdThang;
        private Panel panelChart;
    }
}