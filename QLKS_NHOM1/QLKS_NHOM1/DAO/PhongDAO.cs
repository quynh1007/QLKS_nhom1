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
    class PhongDAO
    {
        private static PhongDAO instance;

        internal static PhongDAO Instance
        {
            get { if (instance == null) instance = new PhongDAO(); return instance; }
            private set { instance = value; }
        }
        public List<Phong> GetAll()
        {
            List<Phong> list = new List<Phong>();
            DataTable data = DataProvider.Instance.ExecuteQuery("SP_PHONG_GetAll");
            foreach (DataRow item in data.Rows)
            {
                Phong entry = new Phong(item);
                list.Add(entry);
            }
            return list;
        }
        public bool Insert(string TenPhong,string LoaiPhong,int GiaPhong,string ChuThich ,string TinhTrang ,int MaNV ,int MaDichVu)
        {
            int result = DataProvider.Instance.ExecuteNonQuery("SP_PHONG_Insert @TenPhong , @LoaiPhong, @GiaPhong, @ChuThich ,@TinhTrang , @MaNV , @MaDichVu ", new object[] { TenPhong, LoaiPhong, GiaPhong, ChuThich, TinhTrang, MaNV, MaDichVu });
            return result > 0;
        }

        public bool Update(int MaPhong, string TenPhong, string LoaiPhong, int GiaPhong, string ChuThich, string TinhTrang, int MaNV, int MaDichVu)
        {
            int result = DataProvider.Instance.ExecuteNonQuery("SP_PHONG_Update @MaPhong, @TenPhong, @LoaiPhong, @GiaPhong, @ChuThich , @TinhTrang ,@MaNV , @MaDichVu", new object[] { MaPhong,TenPhong, LoaiPhong, GiaPhong, ChuThich, TinhTrang, MaNV, MaDichVu });
            return result > 0;
        }

        public bool Delete(int MaPhong)
        {
            int result = DataProvider.Instance.ExecuteNonQuery("SP_PHONG_Delete @MaPhong", new object[] { MaPhong });

            return result > 0;
        }

        public List<Phong> Search(string searchValue)
        {
            List<Phong> list = new List<Phong>();
            DataTable data = DataProvider.Instance.ExecuteQuery("SP_PHONG_Search @searchValue", new object[] { searchValue });
            foreach (DataRow item in data.Rows)
            {
                Phong entry = new Phong(item);
                list.Add(entry);
            }
            return list;
        }
    }
}
