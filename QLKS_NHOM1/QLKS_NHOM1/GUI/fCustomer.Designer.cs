namespace QLKS_NHOM1.GUI
{
    partial class fCustomer
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.label5 = new System.Windows.Forms.Label();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.btnRefresh = new System.Windows.Forms.Button();
            this.btnSearch = new System.Windows.Forms.Button();
            this.txtSearch = new System.Windows.Forms.TextBox();
            this.btnDelete = new System.Windows.Forms.Button();
            this.btnEdit = new System.Windows.Forms.Button();
            this.btnAdd = new System.Windows.Forms.Button();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.btnEmpty = new System.Windows.Forms.Button();
            this.dgvCustomer = new System.Windows.Forms.DataGridView();
            this.lbHoTen = new System.Windows.Forms.Label();
            this.lbCMND = new System.Windows.Forms.Label();
            this.lbGioiTinh = new System.Windows.Forms.Label();
            this.txtHoTen = new System.Windows.Forms.TextBox();
            this.txtCMND = new System.Windows.Forms.TextBox();
            this.cbGioiTinh = new System.Windows.Forms.ComboBox();
            this.lbTuoi = new System.Windows.Forms.Label();
            this.lbSDT = new System.Windows.Forms.Label();
            this.lbMaPhong = new System.Windows.Forms.Label();
            this.txtTuoi = new System.Windows.Forms.TextBox();
            this.txtSDT = new System.Windows.Forms.TextBox();
            this.cbMaPhong = new System.Windows.Forms.ComboBox();
            this.groupBox2.SuspendLayout();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvCustomer)).BeginInit();
            this.SuspendLayout();
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Times New Roman", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.ForeColor = System.Drawing.Color.MidnightBlue;
            this.label5.Location = new System.Drawing.Point(316, 9);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(239, 26);
            this.label5.TabIndex = 9;
            this.label5.Text = "Quản Lý Khách Hàng";
            this.label5.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.btnRefresh);
            this.groupBox2.Controls.Add(this.btnSearch);
            this.groupBox2.Controls.Add(this.txtSearch);
            this.groupBox2.Controls.Add(this.btnDelete);
            this.groupBox2.Controls.Add(this.btnEdit);
            this.groupBox2.Controls.Add(this.btnAdd);
            this.groupBox2.Font = new System.Drawing.Font("Microsoft Sans Serif", 8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox2.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.groupBox2.Location = new System.Drawing.Point(609, 76);
            this.groupBox2.Margin = new System.Windows.Forms.Padding(2);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Padding = new System.Windows.Forms.Padding(2);
            this.groupBox2.Size = new System.Drawing.Size(266, 217);
            this.groupBox2.TabIndex = 10;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Lựa chọn";
            // 
            // btnRefresh
            // 
            this.btnRefresh.Location = new System.Drawing.Point(101, 85);
            this.btnRefresh.Margin = new System.Windows.Forms.Padding(2);
            this.btnRefresh.Name = "btnRefresh";
            this.btnRefresh.Size = new System.Drawing.Size(63, 38);
            this.btnRefresh.TabIndex = 6;
            this.btnRefresh.Text = "Refresh";
            this.btnRefresh.UseVisualStyleBackColor = true;
            // 
            // btnSearch
            // 
            this.btnSearch.Location = new System.Drawing.Point(177, 151);
            this.btnSearch.Margin = new System.Windows.Forms.Padding(2);
            this.btnSearch.Name = "btnSearch";
            this.btnSearch.Size = new System.Drawing.Size(75, 38);
            this.btnSearch.TabIndex = 4;
            this.btnSearch.Text = "Tìm Kiếm";
            this.btnSearch.UseVisualStyleBackColor = true;
            // 
            // txtSearch
            // 
            this.txtSearch.Font = new System.Drawing.Font("Microsoft Sans Serif", 8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtSearch.Location = new System.Drawing.Point(11, 161);
            this.txtSearch.Margin = new System.Windows.Forms.Padding(2);
            this.txtSearch.Name = "txtSearch";
            this.txtSearch.Size = new System.Drawing.Size(153, 20);
            this.txtSearch.TabIndex = 3;
            // 
            // btnDelete
            // 
            this.btnDelete.Location = new System.Drawing.Point(189, 36);
            this.btnDelete.Margin = new System.Windows.Forms.Padding(2);
            this.btnDelete.Name = "btnDelete";
            this.btnDelete.Size = new System.Drawing.Size(63, 38);
            this.btnDelete.TabIndex = 2;
            this.btnDelete.Text = "Xoá";
            this.btnDelete.UseVisualStyleBackColor = true;
            // 
            // btnEdit
            // 
            this.btnEdit.Location = new System.Drawing.Point(101, 36);
            this.btnEdit.Margin = new System.Windows.Forms.Padding(2);
            this.btnEdit.Name = "btnEdit";
            this.btnEdit.Size = new System.Drawing.Size(63, 38);
            this.btnEdit.TabIndex = 1;
            this.btnEdit.Text = "Sửa";
            this.btnEdit.UseVisualStyleBackColor = true;
            // 
            // btnAdd
            // 
            this.btnAdd.Location = new System.Drawing.Point(13, 36);
            this.btnAdd.Margin = new System.Windows.Forms.Padding(2);
            this.btnAdd.Name = "btnAdd";
            this.btnAdd.Size = new System.Drawing.Size(63, 38);
            this.btnAdd.TabIndex = 0;
            this.btnAdd.Text = "Thêm";
            this.btnAdd.UseVisualStyleBackColor = true;
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.cbMaPhong);
            this.groupBox1.Controls.Add(this.txtSDT);
            this.groupBox1.Controls.Add(this.txtTuoi);
            this.groupBox1.Controls.Add(this.lbMaPhong);
            this.groupBox1.Controls.Add(this.lbSDT);
            this.groupBox1.Controls.Add(this.lbTuoi);
            this.groupBox1.Controls.Add(this.cbGioiTinh);
            this.groupBox1.Controls.Add(this.txtCMND);
            this.groupBox1.Controls.Add(this.txtHoTen);
            this.groupBox1.Controls.Add(this.lbGioiTinh);
            this.groupBox1.Controls.Add(this.lbCMND);
            this.groupBox1.Controls.Add(this.lbHoTen);
            this.groupBox1.Controls.Add(this.btnEmpty);
            this.groupBox1.Font = new System.Drawing.Font("Microsoft Sans Serif", 8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox1.Location = new System.Drawing.Point(11, 76);
            this.groupBox1.Margin = new System.Windows.Forms.Padding(2);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Padding = new System.Windows.Forms.Padding(2);
            this.groupBox1.Size = new System.Drawing.Size(519, 217);
            this.groupBox1.TabIndex = 7;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Thông tin khách hàng";
            // 
            // btnEmpty
            // 
            this.btnEmpty.Location = new System.Drawing.Point(232, 175);
            this.btnEmpty.Margin = new System.Windows.Forms.Padding(2);
            this.btnEmpty.Name = "btnEmpty";
            this.btnEmpty.Size = new System.Drawing.Size(84, 38);
            this.btnEmpty.TabIndex = 5;
            this.btnEmpty.Text = "Làm Trống";
            this.btnEmpty.UseVisualStyleBackColor = true;
            // 
            // dgvCustomer
            // 
            this.dgvCustomer.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgvCustomer.BackgroundColor = System.Drawing.SystemColors.ButtonFace;
            this.dgvCustomer.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvCustomer.Location = new System.Drawing.Point(11, 312);
            this.dgvCustomer.Margin = new System.Windows.Forms.Padding(2);
            this.dgvCustomer.Name = "dgvCustomer";
            this.dgvCustomer.RowHeadersWidth = 62;
            this.dgvCustomer.RowTemplate.Height = 28;
            this.dgvCustomer.Size = new System.Drawing.Size(864, 286);
            this.dgvCustomer.TabIndex = 11;
            // 
            // lbHoTen
            // 
            this.lbHoTen.AutoSize = true;
            this.lbHoTen.Location = new System.Drawing.Point(5, 36);
            this.lbHoTen.Name = "lbHoTen";
            this.lbHoTen.Size = new System.Drawing.Size(49, 13);
            this.lbHoTen.TabIndex = 6;
            this.lbHoTen.Text = "Họ Tên";
            // 
            // lbCMND
            // 
            this.lbCMND.AutoSize = true;
            this.lbCMND.Location = new System.Drawing.Point(5, 74);
            this.lbCMND.Name = "lbCMND";
            this.lbCMND.Size = new System.Drawing.Size(43, 13);
            this.lbCMND.TabIndex = 7;
            this.lbCMND.Text = "CMND";
            // 
            // lbGioiTinh
            // 
            this.lbGioiTinh.AutoSize = true;
            this.lbGioiTinh.Location = new System.Drawing.Point(5, 118);
            this.lbGioiTinh.Name = "lbGioiTinh";
            this.lbGioiTinh.Size = new System.Drawing.Size(60, 13);
            this.lbGioiTinh.TabIndex = 8;
            this.lbGioiTinh.Text = "Giới Tính";
            // 
            // txtHoTen
            // 
            this.txtHoTen.Location = new System.Drawing.Point(70, 33);
            this.txtHoTen.Name = "txtHoTen";
            this.txtHoTen.Size = new System.Drawing.Size(164, 20);
            this.txtHoTen.TabIndex = 9;
            // 
            // txtCMND
            // 
            this.txtCMND.Location = new System.Drawing.Point(70, 71);
            this.txtCMND.Name = "txtCMND";
            this.txtCMND.Size = new System.Drawing.Size(164, 20);
            this.txtCMND.TabIndex = 10;
            // 
            // cbGioiTinh
            // 
            this.cbGioiTinh.FormattingEnabled = true;
            this.cbGioiTinh.Items.AddRange(new object[] {
            "Nam",
            "Nữ"});
            this.cbGioiTinh.Location = new System.Drawing.Point(70, 115);
            this.cbGioiTinh.Name = "cbGioiTinh";
            this.cbGioiTinh.Size = new System.Drawing.Size(164, 21);
            this.cbGioiTinh.TabIndex = 11;
            // 
            // lbTuoi
            // 
            this.lbTuoi.AutoSize = true;
            this.lbTuoi.Location = new System.Drawing.Point(252, 36);
            this.lbTuoi.Name = "lbTuoi";
            this.lbTuoi.Size = new System.Drawing.Size(32, 13);
            this.lbTuoi.TabIndex = 12;
            this.lbTuoi.Text = "Tuổi";
            // 
            // lbSDT
            // 
            this.lbSDT.AutoSize = true;
            this.lbSDT.Location = new System.Drawing.Point(252, 74);
            this.lbSDT.Name = "lbSDT";
            this.lbSDT.Size = new System.Drawing.Size(88, 13);
            this.lbSDT.TabIndex = 13;
            this.lbSDT.Text = "Số Điện Thoại";
            // 
            // lbMaPhong
            // 
            this.lbMaPhong.AutoSize = true;
            this.lbMaPhong.Location = new System.Drawing.Point(252, 118);
            this.lbMaPhong.Name = "lbMaPhong";
            this.lbMaPhong.Size = new System.Drawing.Size(64, 13);
            this.lbMaPhong.TabIndex = 14;
            this.lbMaPhong.Text = "Mã Phòng";
            // 
            // txtTuoi
            // 
            this.txtTuoi.Location = new System.Drawing.Point(345, 33);
            this.txtTuoi.Name = "txtTuoi";
            this.txtTuoi.Size = new System.Drawing.Size(164, 20);
            this.txtTuoi.TabIndex = 15;
            // 
            // txtSDT
            // 
            this.txtSDT.Location = new System.Drawing.Point(345, 71);
            this.txtSDT.Name = "txtSDT";
            this.txtSDT.Size = new System.Drawing.Size(164, 20);
            this.txtSDT.TabIndex = 16;
            // 
            // cbMaPhong
            // 
            this.cbMaPhong.FormattingEnabled = true;
            this.cbMaPhong.Location = new System.Drawing.Point(345, 115);
            this.cbMaPhong.Name = "cbMaPhong";
            this.cbMaPhong.Size = new System.Drawing.Size(164, 21);
            this.cbMaPhong.TabIndex = 17;
            // 
            // fCustomer
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(886, 609);
            this.Controls.Add(this.dgvCustomer);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.label5);
            this.Name = "fCustomer";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Quản lý khách hàng";
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvCustomer)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.Button btnRefresh;
        private System.Windows.Forms.Button btnSearch;
        private System.Windows.Forms.TextBox txtSearch;
        private System.Windows.Forms.Button btnDelete;
        private System.Windows.Forms.Button btnEdit;
        private System.Windows.Forms.Button btnAdd;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Button btnEmpty;
        private System.Windows.Forms.DataGridView dgvCustomer;
        private System.Windows.Forms.TextBox txtCMND;
        private System.Windows.Forms.TextBox txtHoTen;
        private System.Windows.Forms.Label lbGioiTinh;
        private System.Windows.Forms.Label lbCMND;
        private System.Windows.Forms.Label lbHoTen;
        private System.Windows.Forms.ComboBox cbGioiTinh;
        private System.Windows.Forms.Label lbMaPhong;
        private System.Windows.Forms.Label lbSDT;
        private System.Windows.Forms.Label lbTuoi;
        private System.Windows.Forms.TextBox txtSDT;
        private System.Windows.Forms.TextBox txtTuoi;
        private System.Windows.Forms.ComboBox cbMaPhong;
    }
}