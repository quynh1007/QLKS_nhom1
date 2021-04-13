using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
using QLKS_NHOM1.DataAccessLayer;
using QLKS_NHOM1.Models;

namespace QLKS_NHOM1.DAO
{
    class KhachHangDAO
    {
        private static KhachHangDAO instance;

        internal static KhachHangDAO Instance
        {
            get { if (instance == null) instance = new KhachHangDAO(); return instance; }
            private set { instance = value; }
        }
        public List<KhachHang> GetAll()
        {
            List<KhachHang> list = new List<KhachHang>();
            DataTable data = DataProvider.Instance.ExecuteQuery("SP_KHACHHANG_GetAll");

            foreach (DataRow item in data.Rows)
            {
                KhachHang entry = new KhachHang(item);
                list.Add(entry);
            }
            return list;
        }

        public bool CheckInsert(string HoTen, int CMND, string GioiTinh, int Tuoi, int SDT, int MaPhong)
        {
            List<KhachHang> list = new List<KhachHang>();
            DataTable data = DataProvider.Instance.ExecuteQuery("SP_KHACHHANG_Insert @HoTen, @CMND, @GioiTinh, @Tuoi, @SDT, @MaPhong", new object[] { HoTen, CMND, GioiTinh, Tuoi, SDT, MaPhong });
            foreach (DataRow item in data.Rows)
            {
                KhachHang entry = new KhachHang(item);
                list.Add(entry);
            }
            return list.Count == 0;
        }

        public bool Insert(string HoTen, int CMND, string GioiTinh, int Tuoi, int SDT, int MaPhong)
        {
            int result = DataProvider.Instance.ExecuteNonQuery("SP_KHACHHANG_Insert @HoTen, @CMND, @GioiTinh, @Tuoi, @SDT, @MaPhong", new object[] { HoTen, CMND, GioiTinh, Tuoi, SDT, MaPhong });
            return result > 0;
        }

        public bool Update(int MaKH, string HoTen, int CMND, string GioiTinh, int Tuoi, int SDT, int MaPhong)
        {
            int result = DataProvider.Instance.ExecuteNonQuery("SP_KHACHHANG_Update @MaKH, @HoTen, @CMND, @GioiTinh, @Tuoi, @SDT, @MaPhong", new object[] { MaKH, HoTen, CMND, GioiTinh, Tuoi, SDT, MaPhong });

            return result > 0;
        }
        public bool Delete(int MaKH)
        {
            int result = DataProvider.Instance.ExecuteNonQuery("SP_KHACHHANG_Delete @MaKH", new object[] { MaKH });

            return result > 0;
        }
        public List<KhachHang> Search(string searchValue)
        {
            List<KhachHang> list = new List<KhachHang>();
            DataTable data = DataProvider.Instance.ExecuteQuery("SP_KHACHHANG_Search @searchValue", new object[] { searchValue });
            foreach (DataRow item in data.Rows)
            {
                KhachHang entry = new KhachHang(item);
                list.Add(entry);
            }
            return list;
        }
    }
}
