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

        private void BindingDataToForm()
        {
            txtHoTen.DataBindings.Add(new Binding("Text", dgvCustomer.DataSource, "HoTen", true, DataSourceUpdateMode.Never));
            txtCMND.DataBindings.Add(new Binding("Text", dgvCustomer.DataSource, "CMND", true, DataSourceUpdateMode.Never));
            cbGioiTinh.DataBindings.Add(new Binding("Text", dgvCustomer.DataSource, "GioiTinh", true, DataSourceUpdateMode.Never));
            txtTuoi.DataBindings.Add(new Binding("Text", dgvCustomer.DataSource, "Tuoi", true, DataSourceUpdateMode.Never));
            txtSDT.DataBindings.Add(new Binding("Text", dgvCustomer.DataSource, "SDT", true, DataSourceUpdateMode.Never));
            cbMaPhong.DataBindings.Add(new Binding("Text", dgvCustomer.DataSource, "MaPhong", true, DataSourceUpdateMode.Never));
        }

        private void LoadData()
        {
            dgvCustomer.DataSource = CustomerList;
            LoadListCustomer();
            EditDataGridViewHeader();
            LoadComboboxMaPhong();
        }

        private void LoadComboboxMaPhong()
        {
            cbMaPhong.DataSource = PhongDAO.Instance.GetAll();
            cbMaPhong.DisplayMember = "MaPhong";
        }

        private void EditDataGridViewHeader()
        {
            dgvCustomer.Columns["MaKH"].HeaderText = "Mã Khách Hàng";
            dgvCustomer.Columns["HoTen"].HeaderText = "Họ Tên";
            dgvCustomer.Columns["CMND"].HeaderText = "CMND";
            dgvCustomer.Columns["GioiTinh"].HeaderText = "Giới Tính";
            dgvCustomer.Columns["Tuoi"].HeaderText = "Tuổi";
            dgvCustomer.Columns["SDT"].HeaderText = "Số điện thoại";
            dgvCustomer.Columns["MaPhong"].HeaderText = "Mã Phòng";
        }

        private void LoadListCustomer()
        {
            CustomerList.DataSource = KhachHangDAO.Instance.GetAll();
        }

        private void btnLamTrong_Click(object sender, EventArgs e)
        {
            txtHoTen.Text = "";
            txtCMND.Text = "";
            txtTuoi.Text = "";
            txtSDT.Text = "";
            LoadComboboxMaPhong();
        }

        private void btnRefresh_Click(object sender, EventArgs e)
        {
            LoadListCustomer();
        }

        private void btnThem_Click(object sender, EventArgs e)
        {
            string HoTen = txtHoTen.Text;
            int CMND = -1;
            Int32.TryParse(txtCMND.Text, out CMND);
            int Tuoi = -1;
            string GioiTinh = cbGioiTinh.Text;
            Int32.TryParse(txtTuoi.Text, out Tuoi);
            int SDT = -1;
            Int32.TryParse(txtSDT.Text, out SDT);
            int MaPhong = -1;
            Int32.TryParse(cbMaPhong.Text, out MaPhong);

            try
            {
                if (HoTen == "" || CMND == -1 || Tuoi == -1 || SDT == -1 || MaPhong == -1)
                {
                    MessageBox.Show("Vui lòng điền đầy đủ thông tin");
                    return;
                }
                else if(MessageBox.Show("Bạn có thật sự muốn thêm khách hàng này!", "Thông báo", MessageBoxButtons.OKCancel) == System.Windows.Forms.DialogResult.OK)
                {
                    KhachHangDAO.Instance.Insert(HoTen, CMND, GioiTinh, Tuoi, SDT, MaPhong);
                    MessageBox.Show("Thêm thành công");
                    LoadData();
                }
            }
            catch (Exception err)
            {
                MessageBox.Show("Có lỗi xảy ra" + err.ToString());
            }
        }

        private void btnSua_Click(object sender, EventArgs e)
        {
            int row = dgvCustomer.CurrentCell.RowIndex;
            int MaKH;
            Int32.TryParse(dgvCustomer.Rows[row].Cells[0].Value.ToString().Trim(), out MaKH);

            string HoTen = txtHoTen.Text;
            int CMND = -1;
            Int32.TryParse(txtCMND.Text, out CMND);
            int Tuoi = -1;
            string GioiTinh = cbGioiTinh.Text;
            Int32.TryParse(txtTuoi.Text, out Tuoi);
            int SDT = -1;
            Int32.TryParse(txtSDT.Text, out SDT);
            int MaPhong = -1;
            Int32.TryParse(cbMaPhong.Text, out MaPhong);

            try
            {
                if (HoTen == "" || CMND == -1 || Tuoi == -1 || SDT == -1 || MaPhong == -1)
                {
                    MessageBox.Show("Vui lòng điền đầy đủ thông tin");
                    return;
                }
                else if (MessageBox.Show("Bạn có thật sự muốn sửa khách hàng này!", "Thông báo", MessageBoxButtons.OKCancel) == System.Windows.Forms.DialogResult.OK)
                {
                    KhachHangDAO.Instance.Update(MaKH, HoTen, CMND, GioiTinh, Tuoi, SDT, MaPhong);
                    MessageBox.Show("Cập nhật thành công");
                    LoadData();
                }

            }
            catch (Exception err)
            {
                MessageBox.Show("Có lỗi xảy ra" + err.ToString());
                LoadData();
            }
        }

        private void btnXoa_Click(object sender, EventArgs e)
        {

            int row = dgvCustomer.CurrentCell.RowIndex;
            int MaKH;
            Int32.TryParse(dgvCustomer.Rows[row].Cells[0].Value.ToString().Trim(), out MaKH);
            try
            {
                if (MessageBox.Show("Bạn có thật sự muốn xoá khách hàng này!", "Thông báo", MessageBoxButtons.OKCancel) == System.Windows.Forms.DialogResult.OK)
                {
                    KhachHangDAO.Instance.Delete(MaKH);
                    MessageBox.Show("Xóa thành công!");
                    LoadData();
                }

            }
            catch (Exception err)
            {
                MessageBox.Show("Có lỗi xảy ra" + err.ToString());
                LoadData();
            }
        }

        private void btnTimKiem_Click(object sender, EventArgs e)
        {
            string search = txtTimKiem.Text.Trim();
            if (search.Equals(""))
            {
                MessageBox.Show("Mời bạn nhập thông tin tìm kiếm!");
                return;
            }
            else
            {
                CustomerList.DataSource = KhachHangDAO.Instance.Search(search);
            }
        }
    }

}
