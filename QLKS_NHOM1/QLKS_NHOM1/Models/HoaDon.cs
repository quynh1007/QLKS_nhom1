using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace QLKS_NHOM1.Models
{
    class HoaDon
    {
        public int MaHD { set; get; }
        public int MaNV { set; get; }
        public int MaKH { set; get; }

        public DateTime Ngay { set; get; }
        public int GiaHD { set; get; }
        
        

        public HoaDon() { }
        public HoaDon(DataRow dataRow)
        {
            this.MaHD = Int32.Parse(dataRow["MaHD"].ToString());
            this.MaKH = Int32.Parse(dataRow["MaKH"].ToString());
            this.MaNV = Int32.Parse(dataRow["MaNV"].ToString());
            this.Ngay = DateTime.Parse(dataRow["Ngay"].ToString());
            this.GiaHD = Int32.Parse(dataRow["GiaHD"].ToString());
           
            
           
        }
    }
}
