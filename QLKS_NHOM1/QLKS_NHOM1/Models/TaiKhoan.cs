using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace QLKS_NHOM1.Models
{
    class TaiKhoan
    {
        public int MaTK { set; get; }
        public string TenTK { set; get; }
        public int MK { set; get; }


        public TaiKhoan() { }
        public TaiKhoan(DataRow dataRow)
        {
            this.MaTK = Int32.Parse(dataRow["MaTK"].ToString());
            this.TenTK = dataRow["TenTK"].ToString();
            this.MK = Int32.Parse(dataRow["Mk"].ToString());

        }
    }
}
