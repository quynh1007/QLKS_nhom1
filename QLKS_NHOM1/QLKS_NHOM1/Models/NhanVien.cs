using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace QLKS_NHOM1.Models
{
    class NhanVien
    {
        public int MaNV { set; get; }
        public string HoTen { set; get; }
        public int SDT { set; get; }
        public DateTime NgaySinh { set; get; }
        public string DiaChi { set; get; }
        public string GioiTinh { set; get; }    
        public string ChucVu { set; get; }


        public NhanVien(DataRow dataRow)
        {
            this.MaNV = Int32.Parse(dataRow["MaNV"].ToString());
            this.HoTen = dataRow["HoTen"].ToString();
            this.SDT = Int32.Parse(dataRow["SDT"].ToString());
            this.NgaySinh = DateTime.Parse(dataRow["Ngáyinh"].ToString());
            this.DiaChi = dataRow["DiaChi"].ToString();
            this.GioiTinh = dataRow["GioiTinh"].ToString();
            this.ChucVu = dataRow["ChucVu"].ToString();


        }
    }
}
