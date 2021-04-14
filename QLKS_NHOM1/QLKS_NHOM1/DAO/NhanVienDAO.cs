using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using QLKS_NHOM1.Models;
using QLKS_NHOM1.DataAccessLayer;
using System.Data;

namespace QLKS_NHOM1.DAO
{
    class NhanVienDAO
    {
        private static NhanVienDAO instance;

        internal static NhanVienDAO Instance
        {
            get { if (instance == null) instance = new NhanVienDAO(); return instance; }
            private set { instance = value; }
        }
        public List<NhanVien> GetAll()
        {
            List<NhanVien> list = new List<NhanVien>();
            DataTable data = DataProvider.Instance.ExecuteQuery("SP_NHANVIEN_GetAll");
            foreach (DataRow item in data.Rows)
            {
                NhanVien entry = new NhanVien(item);
                list.Add(entry);
            }
            return list;
        }
    }
}
