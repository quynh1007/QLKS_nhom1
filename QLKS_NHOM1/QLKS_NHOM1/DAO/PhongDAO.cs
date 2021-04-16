using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using QLKS_NHOM1.DataAccessLayer;
using QLKS_NHOM1.Models;
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
    }
}
