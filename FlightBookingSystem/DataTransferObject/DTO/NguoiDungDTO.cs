using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataTransferObject.DTO
{
    public class NguoiDungDTO
    {
        public string ho {  get; set; }
        public string ten { get; set; }
        public string soCCCD { get; set; }
        public DateTime ngaySinh { get; set; }
        public bool hanhLy {  get; set; }
        public float giaTienChuyenBayLuotDi {  get; set; }
        public float giaTienChuyenBayLuotVe {  get; set; }
        public float giaTienHanhLy { get; set; }
    }
}
