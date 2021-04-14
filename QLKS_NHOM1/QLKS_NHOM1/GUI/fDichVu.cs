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
    public partial class fDichVu : Form
    {
        BindingSource DSDichVu = new BindingSource();
        public fDichVu()
        {
            InitializeComponent();
            LoadFirstTime();
            EditDataGridView();
            BindingDataToFrom();
        }
        private void EditDataGridView()
        {
            dgvDichVu.Columns["MaDichVu"].HeaderText = "Mã dịch vụ";
            dgvDichVu.Columns["TenDichVu"].HeaderText = "Tên dịch vụ";
            dgvDichVu.Columns["Gia"].HeaderText = "Giá";
            
        }
        private void BindingDataToFrom()
        {
            txtMaDichVu.DataBindings.Add(new Binding("Text", dgvDichVu.DataSource, "MaDichVu", true, DataSourceUpdateMode.Never));
            txtTenDichVu.DataBindings.Add(new Binding("Text", dgvDichVu.DataSource, "TenDichVu", true, DataSourceUpdateMode.Never));
            txtGia.DataBindings.Add(new Binding("Text", dgvDichVu.DataSource, "Gia", true, DataSourceUpdateMode.Never));
           
        }
      


        private void LoadFirstTime()
        {
            dgvDichVu.DataSource = DSDichVu;
            LoadListReaders();
        }


        private void LoadListReaders()
        {
            DSDichVu.DataSource = DichVuDAO.Instance.GetAll();
        }

        private void btnThem_Click(object sender, EventArgs e)
        {
  
            string TenDichVu = txtTenDichVu.Text;
            int Gia;
            Int32.TryParse(txtGia.Text, out Gia);

            try
            {
                if (TenDichVu == "")
                {
                    MessageBox.Show("Vui lòng điền đầy đủ thông tin");
                    return;
                }
                DichVuDAO.Instance.Insert( TenDichVu, Gia);
                MessageBox.Show("Thêm thành công");
                LoadListReaders();
            }
            catch (Exception err)
            {
                MessageBox.Show("Có lỗi xảy ra" + err.ToString());
                LoadListReaders();
            }
        }

        private void btnSua_Click(object sender, EventArgs e)
        {
            int MaDichVu =-1;
            Int32.TryParse(txtMaDichVu.Text, out MaDichVu);
            string TenDichVu = txtTenDichVu.Text;
            int Gia;
            Int32.TryParse(txtGia.Text, out Gia);

            try
            {
                if (MaDichVu == -1 || TenDichVu == "")
                {
                    MessageBox.Show("Vui lòng điền đầy đủ thông tin");
                    return;
                }
                DichVuDAO.Instance.Update(MaDichVu, TenDichVu, Gia);
                MessageBox.Show("Sửa thành công");
                LoadListReaders();
            }
            catch (Exception err)
            {
                MessageBox.Show("Có lỗi xảy ra" + err.ToString());
                LoadListReaders();
            }
        }
       

        private void btnXoa_Click(object sender, EventArgs e)
        {
            int MaDichVu = -1;
            Int32.TryParse(txtMaDichVu.Text, out MaDichVu);
            try
            {
                DichVuDAO.Instance.Delete(MaDichVu);
                MessageBox.Show("Xóa thành công");
                LoadListReaders();
            }
            catch (Exception err)
            {
                MessageBox.Show("Có lỗi xảy ra" + err.ToString());
                LoadListReaders();
            }
        }

     

        private void btnTimKiem_Click(object sender, EventArgs e)
        {
            string str = txttimkiem.Text.Trim();
            if (str == "")
            {
                MessageBox.Show("Chưa nhập thông tin tìm kiếm");
                return;
            }
            DSDichVu.DataSource = DichVuDAO.Instance.Search(str);
        }
    }
}
