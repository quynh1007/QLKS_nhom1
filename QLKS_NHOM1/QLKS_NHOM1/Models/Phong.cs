using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace QLKS_NHOM1.Models
{
    class Phong
    {
        public int MaPhong { set; get; }
        public string TenPhong { set; get; }
        public string LoaiPhong { set; get; }
        public int GiaPhong { set; get; }
        public string ChuThich { set; get; }
        public string TinhTrang { set; get; }
        public int MaNV { set; get; }
        public int MaDichVu { set; get; }

        public Phong() { }
        public Phong(DataRow dataRow)
        {
            this.MaPhong = Int32.Parse(dataRow["MaPhong"].ToString());
            this.TenPhong = dataRow["TenPhong"].ToString();
            this.LoaiPhong = dataRow["LoaiPhong"].ToString();
            this.GiaPhong = Int32.Parse(dataRow["GiaPhong"].ToString());
            this.ChuThich = dataRow["ChuThich"].ToString();
            this.TinhTrang = dataRow["TinhTrang"].ToString();
            this.MaNV = Int32.Parse(dataRow["MaNV"].ToString());
            this.MaDichVu = Int32.Parse(dataRow["MaDichVu"].ToString());
        }
    }
}
