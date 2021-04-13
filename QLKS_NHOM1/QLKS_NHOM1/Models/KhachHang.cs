using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace QLKS_NHOM1.Models
{
    class KhachHang
    {
        public int MaKH { set; get; }
        public string HoTen { set; get; }
        public int CMND { set; get; }
        public string GioiTinh { set; get; }
        public int Tuoi { set; get; }
        public int SDT { set; get; }
        public int MaPhong { set; get; }


        public KhachHang() { }
        public KhachHang(DataRow dataRow)
        {
            this.MaKH = Int32.Parse(dataRow["MaKH"].ToString());
            this.HoTen = dataRow["HoTen"].ToString();
            this.CMND =Int32.Parse(dataRow["CMND"].ToString());
            this.GioiTinh =dataRow["GioiTinh"].ToString();
            this.Tuoi =Int32.Parse(dataRow["Tuoi"].ToString());
            this.SDT = Int32.Parse(dataRow["SDT"].ToString());
            this.MaPhong = Int32.Parse(dataRow["MaPhong"].ToString());

        }
    }
}
