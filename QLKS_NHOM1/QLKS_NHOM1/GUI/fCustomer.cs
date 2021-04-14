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
    public partial class fCustomer : Form
    {
        BindingSource CustomerList = new BindingSource();
        public fCustomer()
        {
            InitializeComponent();
            LoadData();
            BindingDataToForm();
        }

        private void LoadData()
        {
            dgvCustomer.DataSource = CustomerList;
            LoadListCustomer();
            EditDataGridViewHeader();
            LoadComboboxMaPhong();
        }

        private void BindingDataToForm()
        {
            txtHoTen.DataBindings.Add(new Binding("Text", dgvCustomer.DataSource, "HoTen", true, DataSourceUpdateMode.Never));
            txtCMND.DataBindings.Add(new Binding("Text", dgvCustomer.DataSource, "CMND", true, DataSourceUpdateMode.Never));
            cbGioiTinh.DataBindings.Add(new Binding("Text", dgvCustomer.DataSource, "GioiTinh", true, DataSourceUpdateMode.Never));
            txtTuoi.DataBindings.Add(new Binding("Text", dgvCustomer.DataSource, "Tuoi", true, DataSourceUpdateMode.Never));
            txtSDT.DataBindings.Add(new Binding("Text", dgvCustomer.DataSource, "SDT", true, DataSourceUpdateMode.Never));
            cbMaPhong.DataBindings.Add(new Binding("Text", dgvCustomer.DataSource, "MaPhong", true, DataSourceUpdateMode.Never));
        }

        private void EditDataGridViewHeader()
        {
            dgvCustomer.Columns["MaKH"].HeaderText = "Mã Khách Hàng";
            dgvCustomer.Columns["HoTen"].HeaderText = "Họ Tên";
            dgvCustomer.Columns["CMND"].HeaderText = "CMND";
            dgvCustomer.Columns["GioiTinh"].HeaderText = "Giới Tính";
            dgvCustomer.Columns["Tuoi"].HeaderText = "Tuổi";
            dgvCustomer.Columns["SDT"].HeaderText = "Số Điện Thoại";
            dgvCustomer.Columns["Tuoi"].HeaderText = "Mã Phòng";
        }

        private void LoadComboboxMaPhong()
        {
            cbMaPhong.DataSource = PhongDAO.Instance.GetAll();
            cbMaPhong.DisplayMember = "MaPhong";
        }
        
        private void LoadListCustomer()
        {
            CustomerList.DataSource = KhachHangDAO.Instance.GetAll();
        }

        private void btnEmpty_Click(object sender, EventArgs e)
        {
            txtHoTen.Text = "";
            txtCMND.Text = "";
            cbGioiTinh.Text = "";
            txtTuoi.Text = "";
            txtSDT.Text = "";
            LoadComboboxMaPhong();
        }

        private void btnRefresh_Click(object sender, EventArgs e)
        {
            CustomerList.DataSource = KhachHangDAO.Instance.GetAll();
        }
    }
}
