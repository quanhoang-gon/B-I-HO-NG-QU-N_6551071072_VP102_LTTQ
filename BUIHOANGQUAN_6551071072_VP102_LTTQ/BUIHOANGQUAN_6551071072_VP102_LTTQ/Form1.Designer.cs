namespace BUIHOANGQUAN_6551071072_VP102_LTTQ
{
    partial class Form1
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            btnThem = new Button();
            btnSua = new Button();
            btnXoa = new Button();
            btnThoat = new Button();
            grpThongTin = new GroupBox();
            dvgSinhVien = new DataGridView();
            grpThaoTac = new GroupBox();
            txtDTB = new TextBox();
            txtTenSV = new TextBox();
            txtMaSV = new TextBox();
            label3 = new Label();
            label2 = new Label();
            label1 = new Label();
            sqlCommand1 = new Microsoft.Data.SqlClient.SqlCommand();
            grpThongTin.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dvgSinhVien).BeginInit();
            grpThaoTac.SuspendLayout();
            SuspendLayout();
            // 
            // btnThem
            // 
            btnThem.Location = new Point(29, 44);
            btnThem.Name = "btnThem";
            btnThem.Size = new Size(100, 37);
            btnThem.TabIndex = 0;
            btnThem.Text = "Thêm";
            btnThem.UseVisualStyleBackColor = true;
            btnThem.Click += btnThem_Click;
            // 
            // btnSua
            // 
            btnSua.Location = new Point(160, 44);
            btnSua.Name = "btnSua";
            btnSua.Size = new Size(100, 37);
            btnSua.TabIndex = 1;
            btnSua.Text = "Sửa";
            btnSua.UseVisualStyleBackColor = true;
            btnSua.Click += btnSua_Click;
            // 
            // btnXoa
            // 
            btnXoa.Location = new Point(293, 44);
            btnXoa.Name = "btnXoa";
            btnXoa.Size = new Size(100, 37);
            btnXoa.TabIndex = 2;
            btnXoa.Text = "Xóa";
            btnXoa.UseVisualStyleBackColor = true;
            btnXoa.Click += btnXoa_Click;
            // 
            // btnThoat
            // 
            btnThoat.Location = new Point(436, 44);
            btnThoat.Name = "btnThoat";
            btnThoat.Size = new Size(100, 37);
            btnThoat.TabIndex = 3;
            btnThoat.Text = "Thoát";
            btnThoat.UseVisualStyleBackColor = true;
            btnThoat.Click += btnThoat_Click;
            // 
            // grpThongTin
            // 
            grpThongTin.Controls.Add(dvgSinhVien);
            grpThongTin.Location = new Point(10, 109);
            grpThongTin.Name = "grpThongTin";
            grpThongTin.Size = new Size(492, 329);
            grpThongTin.TabIndex = 4;
            grpThongTin.TabStop = false;
            grpThongTin.Text = "Danh sách sinh viên";
            // 
            // dvgSinhVien
            // 
            dvgSinhVien.AllowUserToAddRows = false;
            dvgSinhVien.AllowUserToDeleteRows = false;
            dvgSinhVien.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            dvgSinhVien.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dvgSinhVien.Location = new Point(6, 38);
            dvgSinhVien.MultiSelect = false;
            dvgSinhVien.Name = "dvgSinhVien";
            dvgSinhVien.ReadOnly = true;
            dvgSinhVien.RowHeadersWidth = 51;
            dvgSinhVien.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            dvgSinhVien.Size = new Size(456, 285);
            dvgSinhVien.TabIndex = 0;
            dvgSinhVien.CellClick += dvgSinhVien_CellClick;
            // 
            // grpThaoTac
            // 
            grpThaoTac.Controls.Add(txtDTB);
            grpThaoTac.Controls.Add(txtTenSV);
            grpThaoTac.Controls.Add(txtMaSV);
            grpThaoTac.Controls.Add(label3);
            grpThaoTac.Controls.Add(label2);
            grpThaoTac.Controls.Add(label1);
            grpThaoTac.Location = new Point(498, 109);
            grpThaoTac.Name = "grpThaoTac";
            grpThaoTac.Size = new Size(299, 329);
            grpThaoTac.TabIndex = 5;
            grpThaoTac.TabStop = false;
            grpThaoTac.Text = "Thông tin sinh viên ";
            // 
            // txtDTB
            // 
            txtDTB.Location = new Point(19, 260);
            txtDTB.MaxLength = 12;
            txtDTB.Name = "txtDTB";
            txtDTB.Size = new Size(266, 30);
            txtDTB.TabIndex = 5;
            // 
            // txtTenSV
            // 
            txtTenSV.Location = new Point(19, 163);
            txtTenSV.Name = "txtTenSV";
            txtTenSV.Size = new Size(266, 30);
            txtTenSV.TabIndex = 4;
            // 
            // txtMaSV
            // 
            txtMaSV.Location = new Point(19, 76);
            txtMaSV.MaxLength = 10;
            txtMaSV.Name = "txtMaSV";
            txtMaSV.Size = new Size(266, 30);
            txtMaSV.TabIndex = 3;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(19, 215);
            label3.Name = "label3";
            label3.Size = new Size(140, 23);
            label3.TabIndex = 2;
            label3.Text = "Điểm trung bình:";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(19, 126);
            label2.Name = "label2";
            label2.Size = new Size(117, 23);
            label2.TabIndex = 1;
            label2.Text = "Tên Sinh Viên:";
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(19, 38);
            label1.Name = "label1";
            label1.Size = new Size(115, 23);
            label1.TabIndex = 0;
            label1.Text = "Mã Sinh Viên:";
            // 
            // sqlCommand1
            // 
            sqlCommand1.CommandTimeout = 30;
            sqlCommand1.EnableOptimizedParameterBinding = false;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(9F, 23F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(grpThaoTac);
            Controls.Add(grpThongTin);
            Controls.Add(btnThoat);
            Controls.Add(btnXoa);
            Controls.Add(btnSua);
            Controls.Add(btnThem);
            Name = "Form1";
            Text = "Quản lý Hồ sơ sinh viên/ Học phần - VP102";
            Load += Form1_Load;
            grpThongTin.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)dvgSinhVien).EndInit();
            grpThaoTac.ResumeLayout(false);
            grpThaoTac.PerformLayout();
            ResumeLayout(false);
        }


        #endregion

        private Button btnThem;
        private Button btnSua;
        private Button btnXoa;
        private Button btnThoat;
        private GroupBox grpThongTin;
        private DataGridView dvgSinhVien;
        private GroupBox grpThaoTac;
        private Microsoft.Data.SqlClient.SqlCommand sqlCommand1;
        private TextBox txtDTB;
        private TextBox txtTenSV;
        private TextBox txtMaSV;
        private Label label3;
        private Label label2;
        private Label label1;
    }
}
