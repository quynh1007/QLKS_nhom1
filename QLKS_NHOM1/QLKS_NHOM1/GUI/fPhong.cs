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
using QLKS_NHOM1.Models;

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

            cbxMaDV.DataSource = DichVuDAO.Instance.GetAll();
            cbxMaDV.DisplayMember = "MaDichVu";
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
        private void btnThem_Click(object sender, EventArgs e)
        {
            string TenPhong = txtTenPhong.Text;
            string LoaiPhong = txtLoaiPhong.Text;
            string ChuThich = txtChuThich.Text;
            string TinhTrang = txtTinhTrang.Text;
            int GiaPhong ;
            Int32.TryParse(txtGia.Text, out GiaPhong);
            int MaNV;
            Int32.TryParse(cbxMaNV.Text, out MaNV);
            int MaDichVu;
            Int32.TryParse(cbxMaDV.Text, out MaDichVu);


            try
            {
                if (TenPhong == "" || LoaiPhong == ""|| ChuThich == "" || TinhTrang == "")
                {
                    MessageBox.Show("Vui lòng điền đầy đủ thông tin");
                    return;
                }
                PhongDAO.Instance.Insert(TenPhong, LoaiPhong, GiaPhong, ChuThich, TinhTrang, MaNV, MaDichVu);
                MessageBox.Show("Thêm thành công");
                LoadListPhong();
            }
            catch (Exception err)
            {
                MessageBox.Show("Có lỗi xảy ra" + err.ToString());
                LoadListPhong();
            }
        }
        private void btnEdit_Click(object sender, EventArgs e)
        {
            string TenPhong = txtTenPhong.Text;
            string LoaiPhong = txtLoaiPhong.Text;
            string ChuThich = txtChuThich.Text;
            string TinhTrang = txtTinhTrang.Text;
            int GiaPhong;
            Int32.TryParse(txtGia.Text, out GiaPhong);
            int MaPhong;
            Int32.TryParse(txtMaPhong.Text, out MaPhong);
            int MaNV;
            Int32.TryParse(cbxMaNV.Text, out MaNV);
            int MaDichVu;
            Int32.TryParse(cbxMaDV.Text, out MaDichVu);
            try
            {
                if (TenPhong == "" || LoaiPhong == "" || ChuThich == "" || TinhTrang == "")
                {
                    MessageBox.Show("Vui lòng điền đầy đủ thông tin");
                    return;
                }
                
                PhongDAO.Instance.Update(MaPhong, TenPhong, LoaiPhong, GiaPhong, ChuThich, TinhTrang, MaNV, MaDichVu);
                MessageBox.Show("Sửa thành công");
                LoadListPhong();
            }
            catch (Exception err)
            {
                MessageBox.Show("Có lỗi xảy ra" + err.ToString());
                LoadListPhong();
            }
        }
        

        private void btnDelete_Click(object sender, EventArgs e)
        {
            int MaPhong=0;
            Int32.TryParse(txtMaPhong.Text.Trim(), out MaPhong);
            try
            {
                PhongDAO.Instance.Delete(MaPhong);
                MessageBox.Show("Xóa thành công");
                LoadListPhong();
            }
            catch (Exception err)
            {
                MessageBox.Show("Có lỗi xảy ra" + err.ToString());
                LoadListPhong();
            }
        }

     

        private void btnSearch_Click(object sender, EventArgs e)
        {
            string str = txtSearch.Text.Trim();
            if (str == "")
            {
                MessageBox.Show("Chưa nhập thông tin tìm kiếm");
                return;
            }
            PhongList.DataSource = PhongDAO.Instance.Search(str);
        }

    }
}
