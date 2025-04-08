using FlightBookingSytem_BLL.Session;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FlightBookingSystem_GUI.GUI
{
    public class Avatar
    {
        
        public Avatar() 
        { 
           
        }
        public void loadAvatar(PictureBox pictureBox, Label label)
        {
            label.Text = "Hello, " + UserSession.ten;
            if (UserSession.gioiTinh == "Nam")
                pictureBox.Image = Image.FromFile(@"C:\Users\add\Pictures\DoAnLTCSDL\FlightBookingSystem\bin\Picture\profile.png");
            else
                pictureBox.Image = Image.FromFile(@"C:\Users\add\Pictures\DoAnLTCSDL\FlightBookingSystem\bin\Picture\woman.png");
        }
    }
}
