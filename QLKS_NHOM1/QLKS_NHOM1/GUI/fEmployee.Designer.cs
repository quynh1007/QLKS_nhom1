
namespace QLKS_NHOM1.GUI
{
    partial class fEmployee
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
            this.lb1 = new System.Windows.Forms.Label();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.dateTime_DOB = new System.Windows.Forms.DateTimePicker();
            this.txtPosition = new System.Windows.Forms.TextBox();
            this.btn_Reset = new System.Windows.Forms.Button();
            this.cb_Gender = new System.Windows.Forms.ComboBox();
            this.txt_PhoneNumber = new System.Windows.Forms.TextBox();
            this.txtAddress = new System.Windows.Forms.TextBox();
            this.textFullName = new System.Windows.Forms.TextBox();
            this.lb_DOB = new System.Windows.Forms.Label();
            this.lb_PhoneNumber = new System.Windows.Forms.Label();
            this.lb_Position = new System.Windows.Forms.Label();
            this.lb_Gender = new System.Windows.Forms.Label();
            this.lb_Address = new System.Windows.Forms.Label();
            this.lb_Name = new System.Windows.Forms.Label();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.btn_Search = new System.Windows.Forms.Button();
            this.txt_Search = new System.Windows.Forms.TextBox();
            this.btn_Refresh = new System.Windows.Forms.Button();
            this.btn_Delete = new System.Windows.Forms.Button();
            this.btn_Edit = new System.Windows.Forms.Button();
            this.btn_Add = new System.Windows.Forms.Button();
            this.dgv_ListEmployee = new System.Windows.Forms.DataGridView();
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgv_ListEmployee)).BeginInit();
            this.SuspendLayout();
            // 
            // lb1
            // 
            this.lb1.AutoSize = true;
            this.lb1.Font = new System.Drawing.Font("Times New Roman", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lb1.Location = new System.Drawing.Point(483, 11);
            this.lb1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lb1.Name = "lb1";
            this.lb1.Size = new System.Drawing.Size(248, 31);
            this.lb1.TabIndex = 0;
            this.lb1.Text = "Quản Lý Nhân Viên";
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.dateTime_DOB);
            this.groupBox1.Controls.Add(this.txtPosition);
            this.groupBox1.Controls.Add(this.btn_Reset);
            this.groupBox1.Controls.Add(this.cb_Gender);
            this.groupBox1.Controls.Add(this.txt_PhoneNumber);
            this.groupBox1.Controls.Add(this.txtAddress);
            this.groupBox1.Controls.Add(this.textFullName);
            this.groupBox1.Controls.Add(this.lb_DOB);
            this.groupBox1.Controls.Add(this.lb_PhoneNumber);
            this.groupBox1.Controls.Add(this.lb_Position);
            this.groupBox1.Controls.Add(this.lb_Gender);
            this.groupBox1.Controls.Add(this.lb_Address);
            this.groupBox1.Controls.Add(this.lb_Name);
            this.groupBox1.Font = new System.Drawing.Font("Times New Roman", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox1.Location = new System.Drawing.Point(16, 101);
            this.groupBox1.Margin = new System.Windows.Forms.Padding(4);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Padding = new System.Windows.Forms.Padding(4);
            this.groupBox1.Size = new System.Drawing.Size(699, 241);
            this.groupBox1.TabIndex = 1;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Thông tin nhân viên";
            // 
            // dateTime_DOB
            // 
            this.dateTime_DOB.Location = new System.Drawing.Point(473, 42);
            this.dateTime_DOB.Name = "dateTime_DOB";
            this.dateTime_DOB.Size = new System.Drawing.Size(178, 26);
            this.dateTime_DOB.TabIndex = 12;
            // 
            // txtPosition
            // 
            this.txtPosition.Location = new System.Drawing.Point(472, 143);
            this.txtPosition.Margin = new System.Windows.Forms.Padding(4);
            this.txtPosition.Name = "txtPosition";
            this.txtPosition.Size = new System.Drawing.Size(179, 26);
            this.txtPosition.TabIndex = 11;
            // 
            // btn_Reset
            // 
            this.btn_Reset.Font = new System.Drawing.Font("Times New Roman", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_Reset.Location = new System.Drawing.Point(599, 213);
            this.btn_Reset.Margin = new System.Windows.Forms.Padding(4);
            this.btn_Reset.Name = "btn_Reset";
            this.btn_Reset.Size = new System.Drawing.Size(100, 28);
            this.btn_Reset.TabIndex = 4;
            this.btn_Reset.Text = "Làm Trống";
            this.btn_Reset.UseVisualStyleBackColor = true;
            // 
            // cb_Gender
            // 
            this.cb_Gender.AutoCompleteCustomSource.AddRange(new string[] {
            "Nam",
            "Nữ"});
            this.cb_Gender.FormattingEnabled = true;
            this.cb_Gender.Items.AddRange(new object[] {
            "Nam",
            "Nữ"});
            this.cb_Gender.Location = new System.Drawing.Point(121, 144);
            this.cb_Gender.Margin = new System.Windows.Forms.Padding(4);
            this.cb_Gender.Name = "cb_Gender";
            this.cb_Gender.Size = new System.Drawing.Size(179, 27);
            this.cb_Gender.TabIndex = 10;
            // 
            // txt_PhoneNumber
            // 
            this.txt_PhoneNumber.Location = new System.Drawing.Point(472, 94);
            this.txt_PhoneNumber.Margin = new System.Windows.Forms.Padding(4);
            this.txt_PhoneNumber.Name = "txt_PhoneNumber";
            this.txt_PhoneNumber.Size = new System.Drawing.Size(179, 26);
            this.txt_PhoneNumber.TabIndex = 9;
            // 
            // txtAddress
            // 
            this.txtAddress.Location = new System.Drawing.Point(121, 94);
            this.txtAddress.Margin = new System.Windows.Forms.Padding(4);
            this.txtAddress.Name = "txtAddress";
            this.txtAddress.Size = new System.Drawing.Size(179, 26);
            this.txtAddress.TabIndex = 7;
            // 
            // textFullName
            // 
            this.textFullName.Location = new System.Drawing.Point(121, 42);
            this.textFullName.Margin = new System.Windows.Forms.Padding(4);
            this.textFullName.Name = "textFullName";
            this.textFullName.Size = new System.Drawing.Size(179, 26);
            this.textFullName.TabIndex = 6;
            // 
            // lb_DOB
            // 
            this.lb_DOB.AutoSize = true;
            this.lb_DOB.Font = new System.Drawing.Font("Times New Roman", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lb_DOB.Location = new System.Drawing.Point(384, 44);
            this.lb_DOB.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lb_DOB.Name = "lb_DOB";
            this.lb_DOB.Size = new System.Drawing.Size(81, 19);
            this.lb_DOB.TabIndex = 5;
            this.lb_DOB.Text = "Ngày sinh";
            // 
            // lb_PhoneNumber
            // 
            this.lb_PhoneNumber.AutoSize = true;
            this.lb_PhoneNumber.Font = new System.Drawing.Font("Times New Roman", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lb_PhoneNumber.Location = new System.Drawing.Point(384, 96);
            this.lb_PhoneNumber.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lb_PhoneNumber.Name = "lb_PhoneNumber";
            this.lb_PhoneNumber.Size = new System.Drawing.Size(40, 19);
            this.lb_PhoneNumber.TabIndex = 4;
            this.lb_PhoneNumber.Text = "SĐT";
            // 
            // lb_Position
            // 
            this.lb_Position.AutoSize = true;
            this.lb_Position.Font = new System.Drawing.Font("Times New Roman", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lb_Position.Location = new System.Drawing.Point(384, 146);
            this.lb_Position.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lb_Position.Name = "lb_Position";
            this.lb_Position.Size = new System.Drawing.Size(69, 19);
            this.lb_Position.TabIndex = 3;
            this.lb_Position.Text = "Chức vụ";
            // 
            // lb_Gender
            // 
            this.lb_Gender.AutoSize = true;
            this.lb_Gender.Font = new System.Drawing.Font("Times New Roman", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lb_Gender.Location = new System.Drawing.Point(33, 146);
            this.lb_Gender.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lb_Gender.Name = "lb_Gender";
            this.lb_Gender.Size = new System.Drawing.Size(82, 19);
            this.lb_Gender.TabIndex = 2;
            this.lb_Gender.Text = "Giới Tính";
            // 
            // lb_Address
            // 
            this.lb_Address.AutoSize = true;
            this.lb_Address.Font = new System.Drawing.Font("Times New Roman", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lb_Address.Location = new System.Drawing.Point(33, 96);
            this.lb_Address.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lb_Address.Name = "lb_Address";
            this.lb_Address.Size = new System.Drawing.Size(62, 19);
            this.lb_Address.TabIndex = 1;
            this.lb_Address.Text = "Địa chỉ";
            // 
            // lb_Name
            // 
            this.lb_Name.AutoSize = true;
            this.lb_Name.Font = new System.Drawing.Font("Times New Roman", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lb_Name.Location = new System.Drawing.Point(33, 44);
            this.lb_Name.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lb_Name.Name = "lb_Name";
            this.lb_Name.Size = new System.Drawing.Size(58, 19);
            this.lb_Name.TabIndex = 0;
            this.lb_Name.Text = "Họ tên";
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.btn_Search);
            this.groupBox2.Controls.Add(this.txt_Search);
            this.groupBox2.Controls.Add(this.btn_Refresh);
            this.groupBox2.Controls.Add(this.btn_Delete);
            this.groupBox2.Controls.Add(this.btn_Edit);
            this.groupBox2.Controls.Add(this.btn_Add);
            this.groupBox2.Font = new System.Drawing.Font("Times New Roman", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox2.Location = new System.Drawing.Point(820, 101);
            this.groupBox2.Margin = new System.Windows.Forms.Padding(4);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Padding = new System.Windows.Forms.Padding(4);
            this.groupBox2.Size = new System.Drawing.Size(343, 241);
            this.groupBox2.TabIndex = 2;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Lựa chọn";
            // 
            // btn_Search
            // 
            this.btn_Search.Font = new System.Drawing.Font("Times New Roman", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_Search.Location = new System.Drawing.Point(235, 169);
            this.btn_Search.Margin = new System.Windows.Forms.Padding(4);
            this.btn_Search.Name = "btn_Search";
            this.btn_Search.Size = new System.Drawing.Size(100, 28);
            this.btn_Search.TabIndex = 8;
            this.btn_Search.Text = "Tìm Kiếm";
            this.btn_Search.UseVisualStyleBackColor = true;
            // 
            // txt_Search
            // 
            this.txt_Search.Location = new System.Drawing.Point(8, 171);
            this.txt_Search.Margin = new System.Windows.Forms.Padding(4);
            this.txt_Search.Name = "txt_Search";
            this.txt_Search.Size = new System.Drawing.Size(212, 26);
            this.txt_Search.TabIndex = 7;
            // 
            // btn_Refresh
            // 
            this.btn_Refresh.Font = new System.Drawing.Font("Times New Roman", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_Refresh.Location = new System.Drawing.Point(121, 86);
            this.btn_Refresh.Margin = new System.Windows.Forms.Padding(4);
            this.btn_Refresh.Name = "btn_Refresh";
            this.btn_Refresh.Size = new System.Drawing.Size(100, 28);
            this.btn_Refresh.TabIndex = 3;
            this.btn_Refresh.Text = "Refresh";
            this.btn_Refresh.UseVisualStyleBackColor = true;
            // 
            // btn_Delete
            // 
            this.btn_Delete.Font = new System.Drawing.Font("Times New Roman", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_Delete.Location = new System.Drawing.Point(235, 34);
            this.btn_Delete.Margin = new System.Windows.Forms.Padding(4);
            this.btn_Delete.Name = "btn_Delete";
            this.btn_Delete.Size = new System.Drawing.Size(100, 28);
            this.btn_Delete.TabIndex = 2;
            this.btn_Delete.Text = "Xóa";
            this.btn_Delete.UseVisualStyleBackColor = true;
            // 
            // btn_Edit
            // 
            this.btn_Edit.Font = new System.Drawing.Font("Times New Roman", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_Edit.Location = new System.Drawing.Point(121, 34);
            this.btn_Edit.Margin = new System.Windows.Forms.Padding(4);
            this.btn_Edit.Name = "btn_Edit";
            this.btn_Edit.Size = new System.Drawing.Size(100, 28);
            this.btn_Edit.TabIndex = 1;
            this.btn_Edit.Text = "Sửa";
            this.btn_Edit.UseVisualStyleBackColor = true;
            // 
            // btn_Add
            // 
            this.btn_Add.Font = new System.Drawing.Font("Times New Roman", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_Add.Location = new System.Drawing.Point(8, 34);
            this.btn_Add.Margin = new System.Windows.Forms.Padding(4);
            this.btn_Add.Name = "btn_Add";
            this.btn_Add.Size = new System.Drawing.Size(100, 28);
            this.btn_Add.TabIndex = 0;
            this.btn_Add.Text = "Thêm";
            this.btn_Add.UseVisualStyleBackColor = true;
            // 
            // dgv_ListEmployee
            // 
            this.dgv_ListEmployee.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgv_ListEmployee.Location = new System.Drawing.Point(16, 379);
            this.dgv_ListEmployee.Margin = new System.Windows.Forms.Padding(4);
            this.dgv_ListEmployee.Name = "dgv_ListEmployee";
            this.dgv_ListEmployee.RowHeadersWidth = 51;
            this.dgv_ListEmployee.Size = new System.Drawing.Size(1147, 356);
            this.dgv_ListEmployee.TabIndex = 3;
            // 
            // fEmployee
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1181, 750);
            this.Controls.Add(this.dgv_ListEmployee);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.lb1);
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "fEmployee";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Quản Lý Nhân Viên";
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgv_ListEmployee)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Label lb1;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.Label lb_Gender;
        private System.Windows.Forms.Label lb_Address;
        private System.Windows.Forms.Label lb_Name;
        private System.Windows.Forms.Label lb_DOB;
        private System.Windows.Forms.Label lb_PhoneNumber;
        private System.Windows.Forms.Label lb_Position;
        private System.Windows.Forms.ComboBox cb_Gender;
        private System.Windows.Forms.TextBox txt_PhoneNumber;
        private System.Windows.Forms.TextBox txtAddress;
        private System.Windows.Forms.TextBox textFullName;
        private System.Windows.Forms.Button btn_Add;
        private System.Windows.Forms.Button btn_Delete;
        private System.Windows.Forms.Button btn_Edit;
        private System.Windows.Forms.Button btn_Refresh;
        private System.Windows.Forms.Button btn_Reset;
        private System.Windows.Forms.Button btn_Search;
        private System.Windows.Forms.TextBox txt_Search;
        private System.Windows.Forms.DataGridView dgv_ListEmployee;
        private System.Windows.Forms.TextBox txtPosition;
        private System.Windows.Forms.DateTimePicker dateTime_DOB;
    }
}