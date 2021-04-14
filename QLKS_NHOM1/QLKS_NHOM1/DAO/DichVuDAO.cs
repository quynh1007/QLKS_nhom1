using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using QLKS_NHOM1.Models;
using System.Data;
using QLKS_NHOM1.DataAccessLayer;

namespace QLKS_NHOM1.DAO
{
    class DichVuDAO
    {
        private static DichVuDAO instance;

        internal static DichVuDAO Instance
        {
            get { if (instance == null) instance = new DichVuDAO(); return instance; }
            private set { instance = value; }
        }
        public List<DichVu> GetAll()
        {
            List<DichVu> list = new List<DichVu>();
            DataTable data = DataProvider.Instance.ExecuteQuery("SP_DICHVU_GetAll");
            foreach (DataRow item in data.Rows)
            {
                DichVu entry = new DichVu(item);
                list.Add(entry);
            }
            return list;
        }
        public bool Insert(string TenDichVu, int Gia)
        {
            int result = DataProvider.Instance.ExecuteNonQuery("exec SP_DICHVU_Insert @TenDichVu , @Gia", new object[] { TenDichVu, Gia });
            return result > 0;
        }

        public bool Update(int MaDichVu, string TenDichVu, int Gia)
        {
            int result = DataProvider.Instance.ExecuteNonQuery("exec SP_DICHVU_Update @MaDichVu , @TenDichVu , @Gia", new object[] { MaDichVu, TenDichVu, Gia});
            return result > 0;
        }

        public bool Delete(int MaDichVu)
        {
            int result = DataProvider.Instance.ExecuteNonQuery("exec SP_DICHVU_Delete @MaDichVu", new object[] { MaDichVu });

            return result > 0;
        }

        public List<DichVu> Search(string searchValue)
        {
            List<DichVu> list = new List<DichVu>();
            DataTable data = DataProvider.Instance.ExecuteQuery("exec SP_DICHVU_Search @searchValue", new object[] { searchValue });
            foreach (DataRow item in data.Rows)
            {
                DichVu entry = new DichVu(item);
                list.Add(entry);
            }
            return list;
        }
    }
}
