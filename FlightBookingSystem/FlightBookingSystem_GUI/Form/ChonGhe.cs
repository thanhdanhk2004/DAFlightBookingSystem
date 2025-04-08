using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace PresentationLayer
{
    public partial class ChonGhe : Form
    {
        public ChonGhe()
        {
            InitializeComponent();
        }

        private PictureBox chiecGhe(int c, int r, int x, int y)
        {
            PictureBox ghe = new PictureBox();
            ghe.Image = Image.FromFile("C:\\Users\\add\\Pictures\\BTLLTCSDL\\FlightBookingSystem\\bin\\Picture\\passenger.png");
            ghe.Width = 35;
            ghe.Height = 50;
            ghe.Name = "ghe" + r.ToString() + c.ToString();
            ghe.Location = new Point(x, y);
            ghe.SizeMode = PictureBoxSizeMode.StretchImage;
            ghe.BackColor = Color.White;
            return ghe;
        }
        private void ChonGhe_Load(object sender, EventArgs e)
        {
            int height = 10;
            int distance = 10;
            for(int i = 0; i < 8;i++)
            {
                for(int j = 0; j < 16; j++)
                {
                    distance = j >= 8 ? 62 : 10;
                    PictureBox ghe = chiecGhe(i, j, distance + (j * 50), height);
                    gBCacGhe.Controls.Add(ghe);
                }
                height += 64;
            }
        }
    }
}
