using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using QLKS_NHOM1.DAO;

namespace QLKS_NHOM1.GUI
{
    public partial class fPhong : Form
    {
        BindingSource PhongList = new BindingSource();
        public fPhong()
        {
            InitializeComponent();
            LoadFirstTime();
            EditDataGridView();
            LoadCombobox();
            BindingDataToFrom();
        }
        private void EditDataGridView()
        {
            dgvPhong.Columns["MaPhong"].HeaderText = "Mã phòng";
            dgvPhong.Columns["TenPhong"].HeaderText = "Tên phòng";
            dgvPhong.Columns["LoaiPhong"].HeaderText = "Loại phòng";
            dgvPhong.Columns["GiaPhong"].HeaderText = "Giá phòng";
            dgvPhong.Columns["ChuThich"].HeaderText = "Chú thích";
            dgvPhong.Columns["TinhTrang"].HeaderText = "Tình Trạng";
            dgvPhong.Columns["MaNV"].HeaderText = "Mã nhân viên";
            dgvPhong.Columns["MaDichVu"].HeaderText = "Mã dịch vụ";
        }
        private void BindingDataToFrom()
        {
            txtMaPhong.DataBindings.Add(new Binding("Text", dgvPhong.DataSource, "MaPhong", true, DataSourceUpdateMode.Never));
            txtTenPhong.DataBindings.Add(new Binding("Text", dgvPhong.DataSource, "TenPhong", true, DataSourceUpdateMode.Never));
            txtLoaiPhong.DataBindings.Add(new Binding("Text", dgvPhong.DataSource, "LoaiPhong", true, DataSourceUpdateMode.Never));
            txtGia.DataBindings.Add(new Binding("Text", dgvPhong.DataSource, "GiaPhong", true, DataSourceUpdateMode.Never));
            txtChuThich.DataBindings.Add(new Binding("Text", dgvPhong.DataSource, "ChuThich", true, DataSourceUpdateMode.Never));
            txtTinhTrang.DataBindings.Add(new Binding("Text", dgvPhong.DataSource, "TinhTrang", true, DataSourceUpdateMode.Never));
            cbxMaNV.DataBindings.Add(new Binding("Text", dgvPhong.DataSource, "MaNV", true, DataSourceUpdateMode.Never));
            cbxMaDV.DataBindings.Add(new Binding("Text", dgvPhong.DataSource, "MaDichVu", true, DataSourceUpdateMode.Never));
        }
        private void LoadCombobox()
        {
            cbxMaNV.DataSource = NhanVienDAO.Instance.GetAll();
            cbxMaNV.DisplayMember = "MaNV";
        }


        private void LoadFirstTime()
        {
            dgvPhong.DataSource = PhongList;
            LoadListPhong();
        }


        private void LoadListPhong()
        {
            PhongList.DataSource = PhongDAO.Instance.GetAll();
        }

  

    }
}
