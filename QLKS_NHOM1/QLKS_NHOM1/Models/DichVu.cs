using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace QLKS_NHOM1.Models
{
    class DichVu
    {
        public int MaDichVu { set; get; }
        public string TenDichVu { set; get; }
        public int Gia { set; get; }
       

        public DichVu() { }
        public DichVu(DataRow dataRow)
        {
            this.MaDichVu = Int32.Parse(dataRow["MaDichVu"].ToString());
            this.TenDichVu = dataRow["TenDichVu"].ToString();
            this.Gia = Int32.Parse(dataRow["Gia"].ToString());
           
        }
    }
}
