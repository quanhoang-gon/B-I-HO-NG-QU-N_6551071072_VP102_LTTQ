using BUIHOANGQUAN_6551071072_VP102_LTTQ.Models;
using Microsoft.EntityFrameworkCore;
using System;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace BUIHOANGQUAN_6551071072_VP102_LTTQ
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private async void Form1_Load(object sender, EventArgs e)
        {
            btnThem.Enabled = true;
            btnThoat.Enabled = true;
            btnSua.Enabled = false;
            btnXoa.Enabled = false;

            await LoadData();
        }

        private async Task LoadData()
        {
            using var db = new DuLieuContext();
            dvgSinhVien.DataSource = await db.SinhViens.AsNoTracking()
                .Select(p => new
                {
                    p.MaSinhVien,
                    p.TenSinhVien,
                    p.DiemTrungBinh
                })
                .ToListAsync();

            if (dvgSinhVien.Columns["MaSinhVien"] != null)
                dvgSinhVien.Columns["MaSinhVien"].HeaderText = "Mã Sinh Viên";
            if (dvgSinhVien.Columns["TenSinhVien"] != null)
                dvgSinhVien.Columns["TenSinhVien"].HeaderText = "Tên Sinh Viên";
            if (dvgSinhVien.Columns["DiemTrungBinh"] != null)
                dvgSinhVien.Columns["DiemTrungBinh"].HeaderText = "Điểm Trung Bình";

            dvgSinhVien.ClearSelection();
        }

        private void txtGiaBan_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (char.IsControl(e.KeyChar) || char.IsDigit(e.KeyChar))
            {
                return;
            }

            if (e.KeyChar == '.' && !txtDTB.Text.Contains("."))
            {
                return;
            }

            e.Handled = true;
        }

        private void btnThoat_Click(object sender, EventArgs e)
        {
            DialogResult dr = MessageBox.Show("Bạn có muốn thoát không", "Xác nhận", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if (dr == DialogResult.Yes)
            {
                this.Close();
            }
        }

        private async void btnThem_Click(object sender, EventArgs e)
        {
            string ma = txtMaSV.Text.Trim();
            string ten = txtTenSV.Text.Trim();
            string gia = txtDTB.Text.Trim();

            if (string.IsNullOrEmpty(ma) || string.IsNullOrEmpty(ten) || string.IsNullOrEmpty(gia))
            {
                MessageBox.Show("Vui lòng nhập đầy đủ thông tin vào tất cả các ô TextBox!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            using var db = new DuLieuContext();
            bool isTrung = await db.SinhViens.AnyAsync(p => p.MaSinhVien == ma);
            if (isTrung)
            {
                MessageBox.Show("Mã sinh viên đã tồn tại! Vui lòng nhập lại mã khác.", "Báo trùng", MessageBoxButtons.OK, MessageBoxIcon.Error);
                txtMaSV.SelectAll();
                txtMaSV.Focus();
                return;
            }
            var sp = new SinhVien
            {
                MaSinhVien = ma,
                TenSinhVien = ten,
                DiemTrungBinh = gia
            };

            db.SinhViens.Add(sp);
            await db.SaveChangesAsync();
            await LoadData();
            XoaRongTextBox();

            btnThem.Enabled = false;

            MessageBox.Show("Thêm sinh vien  thành công!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }

        private void dvgSinhVien_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex < 0) return;

            DataGridViewRow r = dvgSinhVien.Rows[e.RowIndex];
            txtMaSV.Text = r.Cells["MaSinhVien"].Value?.ToString() ?? "";
            txtTenSV.Text = r.Cells["TenSinhVien"].Value?.ToString() ?? "";
            txtDTB.Text = r.Cells["DiemTrungBinh"].Value?.ToString() ?? "";

            btnSua.Enabled = true;
            btnXoa.Enabled = true;
            btnThem.Enabled = true;
        }
        private async void btnXoa_Click(object sender, EventArgs e)
        {
            DialogResult dr = MessageBox.Show("Bạn có muốn xóa sinh viên này không?", "Xác nhận xóa", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if (dr == DialogResult.Yes)
            {
                string ma = txtMaSV.Text.Trim();
                using var db = new DuLieuContext();
                var sp = await db.SinhViens.FindAsync(ma);
                if (sp != null)
                {
                    db.SinhViens.Remove(sp);
                    await db.SaveChangesAsync();
                }

                await LoadData();
                XoaRongTextBox();

                btnSua.Enabled = false;
                btnXoa.Enabled = false;
                btnThem.Enabled = true;

                MessageBox.Show("Đã xóa thành công!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }

        private async void btnSua_Click(object sender, EventArgs e)
        {
            string ma = txtMaSV.Text.Trim();
            string ten = txtTenSV.Text.Trim();
            string gia = txtDTB.Text.Trim();

            if (string.IsNullOrEmpty(ma) || string.IsNullOrEmpty(ten) || string.IsNullOrEmpty(gia))
            {
                MessageBox.Show("Vui lòng nhập đầy đủ thông tin để sửa!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            using var db = new DuLieuContext();
            var sp = await db.SinhViens.FindAsync(ma);
            if (sp != null)
            {
                sp.TenSinhVien = ten;
                sp.DiemTrungBinh = gia;

                await db.SaveChangesAsync();

                await LoadData();

                XoaRongTextBox();

                btnSua.Enabled = false;
                btnXoa.Enabled = false;
                btnThem.Enabled = true;

                MessageBox.Show("Cập nhật sản phẩm thành công!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            else
            {
                MessageBox.Show("Không tìm thấy sản phẩm có mã này trong hệ thống!", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }


        private void XoaRongTextBox()
        {
            txtMaSV.Clear();
            txtTenSV.Clear();
            txtDTB.Clear();
            txtMaSV.Focus();
        }
    }
}