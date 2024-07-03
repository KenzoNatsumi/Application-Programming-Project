using quản_lí_cửa_hàng_máy_tính.Control;
using quản_lí_cửa_hàng_máy_tính.model;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace quản_lí_cửa_hàng_máy_tính.views
{
    public partial class FNhanVien : Form
    {
        List<CNhanVien> dsnhanviens = new List<CNhanVien>();
        CtrlNhanVien ctrnhanviens = new CtrlNhanVien();
        public FNhanVien()
        {
            InitializeComponent();
            int width = lsvDSNV.Width;
            lsvDSNV.Columns.Add("Mã nhân viên", 20 * width / 100);
            lsvDSNV.Columns.Add("Tên nhân viên", 40 * width / 100);
            lsvDSNV.Columns.Add("Giới tính", 18 * width / 100);
            lsvDSNV.Columns.Add("Địa Chỉ", 20 * width / 100);
            lsvDSNV.Columns.Add("Số điện thoại", 20 * width / 100);
            lsvDSNV.Columns.Add("Giới tính", 20 * width / 100);
            lsvDSNV.View = View.Details;
            lsvDSNV.FullRowSelect = true;
        }

        private void FNhanVien_Load(object sender, EventArgs e)
        {
            dsnhanviens = ctrnhanviens.finAll();
            //hien thi lne list view
            foreach (CNhanVien nv in dsnhanviens)
            {
                string[] obj = { nv.MaNV1, nv.TenNV1, nv.GioiTinh1, nv.DiaChi1, nv.SoDT1, nv.NgaySinh1 + " " };
                ListViewItem item = new ListViewItem(obj);
                lsvDSNV.Items.Add(item);
            }
        }

        private void lsvDSNV_SelectedIndexChanged(object sender, EventArgs e)
        {
            try
            {
                ListViewItem item = lsvDSNV.SelectedItems[0];
                CNhanVien nv = new CNhanVien();
                nv.MaNV1 = item.SubItems[0].Text;
                int index = dsnhanviens.IndexOf(nv);
                if (index < 0)
                    return;
                nv = dsnhanviens[index];
                //hien thi thong tin
                txtMaNV.Text = nv.MaNV1;
                txtTenNV.Text = nv.TenNV1;
                txtGioiTinh.Text = nv.GioiTinh1;
                txtDiaChi.Text = nv.DiaChi1;
                txtSoDT.Text = nv.SoDT1;
                dtpNgaySinh.Value = nv.NgaySinh1;
                txtTenNVTimKiem.Text = nv.MaNV1;
            }
            catch
            { }
        }
        private void LoadNhanVien()
        {
            dsnhanviens = ctrnhanviens.finAll();
            RefreshListView();
        }

        private void RefreshListView()
        {
            lsvDSNV.Items.Clear();
            foreach (var nv in dsnhanviens)
            {
                string[] obj = { nv.MaNV1, nv.TenNV1, nv.GioiTinh1, nv.DiaChi1, nv.SoDT1, nv.NgaySinh1 + " " };
                ListViewItem item = new ListViewItem(obj);
                lsvDSNV.Items.Add(item);
            }
        }



        private void btnTaoMoi_Click(object sender, EventArgs e)
        {
            txtMaNV.Clear();
            txtTenNV.Clear();
            txtGioiTinh.Clear();
            txtDiaChi.Clear();
            txtSoDT.Clear();
            dtpNgaySinh.Value = DateTime.Now;
            txtMaNV.Focus();
        }

        private void btnThem_Click_1(object sender, EventArgs e)
        {
            string MaNV = txtMaNV.Text;
            string TenNV = txtTenNV.Text;
            string GioiTinh = txtGioiTinh.Text;
            string DiaChi = txtDiaChi.Text;
            string SoDT = txtSoDT.Text;
            DateTime NgaySinh = dtpNgaySinh.Value;
            CNhanVien nv = new CNhanVien(MaNV, TenNV, GioiTinh, DiaChi, SoDT, NgaySinh);
            if (ctrnhanviens.Insert(nv))
            {
                MessageBox.Show("Đã thêm");
                dsnhanviens.Add(nv);
                string[] obj =
               { nv.MaNV1, nv.TenNV1, nv.GioiTinh1, nv.DiaChi1, nv.SoDT1, nv.NgaySinh1 + " "   };
                ListViewItem item = new ListViewItem(obj);
                lsvDSNV.Items.Add(item);
                txtMaNV.Clear();
                txtTenNV.Clear();
                txtGioiTinh.Clear();
                txtDiaChi.Clear();
                txtSoDT.Clear();
                dtpNgaySinh.Value = DateTime.Now;
                txtMaNV.Focus();
            }
            else
                MessageBox.Show("Thêm Thất Bại");
        }

        private void btnCapNhat_Click_1(object sender, EventArgs e)
        {
            ListViewItem item = lsvDSNV.SelectedItems[0];
            CNhanVien nv = new CNhanVien();
            nv.MaNV1 = item.SubItems[0].Text;
            int index = dsnhanviens.IndexOf(nv);
            if (index < 0)
            {
                return;
            }
            nv = dsnhanviens[index];
            nv.TenNV1 = txtTenNV.Text;
            nv.GioiTinh1 = txtGioiTinh.Text;
            nv.DiaChi1 = txtDiaChi.Text;
            nv.SoDT1 = txtSoDT.Text;
            nv.NgaySinh1 = dtpNgaySinh.Value;
            if (ctrnhanviens.update(nv))
            {
                MessageBox.Show("Đã cập nhật");
                item.SubItems[1].Text = nv.TenNV1;
                item.SubItems[2].Text = nv.GioiTinh1;
                item.SubItems[3].Text = nv.DiaChi1;
                item.SubItems[4].Text = nv.SoDT1;
                item.SubItems[5].Text = nv.NgaySinh1 + "";
            }
            else
                MessageBox.Show("cập nhật Thất Bại");
        }

        private void btnXoa_Click_1(object sender, EventArgs e)
        {
            try
            {
                // Kiểm tra xem có mục nào được chọn không
                if (lsvDSNV.SelectedItems.Count == 0)
                    return;

                // Lấy mục được chọn
                ListViewItem item = lsvDSNV.SelectedItems[0];
                string MaNV = item.SubItems[0].Text;

                // Tìm nhân viên trong danh sách theo mã nhân viên
                CNhanVien nv = dsnhanviens.FirstOrDefault(nv => nv.MaNV1 == MaNV);
                if (nv == null)
                {
                    return;
                }

                // Xóa Nhân viên
                if (ctrnhanviens.delete(nv))
                {
                    MessageBox.Show("Đã Xoá");
                    dsnhanviens.Remove(nv);
                    lsvDSNV.Items.Remove(item);

                    // Cập nhật mã nhà cung cấp cho các mục còn lại
                    ctrnhanviens.UpdateMaNCCAfterDeletion(MaNV);
                    LoadNhanVien();
                    txtMaNV.Clear();
                    txtTenNV.Clear();
                    txtGioiTinh.Clear();
                    txtDiaChi.Clear();
                    txtSoDT.Clear();
                    dtpNgaySinh.Value = DateTime.Now;
                    txtSoDT.Clear();
                }
                else
                {
                    MessageBox.Show("Xoá thất bại");
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error: " + ex.Message);
            }
        }

        private void btnTaoMoi_Click_1(object sender, EventArgs e)
        {
            txtMaNV.Clear();
            txtTenNV.Clear();
            txtGioiTinh.Clear();
            txtDiaChi.Clear();
            txtSoDT.Clear();
            dtpNgaySinh.Value = DateTime.Now;
            txtMaNV.Focus();
            txtTenNVTimKiem.Clear();
            txtMaNV.Select();
            btnTimKiem_Click(sender, e);
        }

        private void btnTimKiem_Click(object sender, EventArgs e)
        {
            string dkfind = txtTenNVTimKiem.Text;
            dsnhanviens = ctrnhanviens.findMaNV(dkfind);
            lsvDSNV.Items.Clear();
            foreach (CNhanVien nv in dsnhanviens)
            {
                string[] obj = { nv.MaNV1, nv.TenNV1, nv.GioiTinh1, nv.DiaChi1, nv.SoDT1, nv.NgaySinh1 + " " };
                ListViewItem item = new ListViewItem(obj);
                lsvDSNV.Items.Add(item);
            }
            if (lsvDSNV.Items.Count == 0)
            {
                MessageBox.Show("không tìm thấy sản phẩm");
            }
            txtMaNV.Clear();
            txtTenNV.Clear();
            txtGioiTinh.Clear();
            txtDiaChi.Clear();
            txtSoDT.Clear();
            dtpNgaySinh.Value = DateTime.Now;
            txtTenNVTimKiem.Clear();
        }
        private void txtMaNV_KeyPress(object sender, KeyPressEventArgs e)
        {
            TextBox textBox = (TextBox)sender;
            // Kiểm tra độ dài chuỗi
            if (textBox.Text.Length < 2)
            {
                // Kiểm tra nếu ký tự nhập vào là số
                if (char.IsDigit(e.KeyChar))
                {
                    // Hủy bỏ ký tự nhập vào
                    e.Handled = true;
                }
            }
            // Kiểm tra độ dài của chuỗi nhập vào
            if (textBox.Text.Length >= 4 && e.KeyChar != '\b')
            {
                // Hủy bỏ ký tự nhập vào nếu độ dài vượt quá 4 ký tự
                e.Handled = true;
                return;
            }

            // Kiểm tra ký tự nhập vào
            if (e.KeyChar != 'N' && e.KeyChar != 'V' && !char.IsDigit(e.KeyChar) && e.KeyChar != '\b')
            {
                // Hủy bỏ ký tự nhập vào nếu không phải 'N', 'V' hoặc số
                e.Handled = true;
            }

        }

        private void txtSoDT_KeyPress(object sender, KeyPressEventArgs e)
        {
            // Kiểm tra nếu ký tự không phải là số và không phải là phím Backspace
            if (!char.IsDigit(e.KeyChar) && e.KeyChar != '\b')
            {
                e.Handled = true; // Chặn sự kiện nhập ký tự
            }
            // Kiểm tra độ dài số điện thoại
            if (txtSoDT.Text.Length >= 10 && e.KeyChar != (char)Keys.Back)
            {
                e.Handled = true; // Hủy bỏ ký tự nếu số điện thoại đã đạt đến giới hạn 10 chữ số
            }
        }

        private void txtTenNVTimKiem_KeyPress(object sender, KeyPressEventArgs e)
        {
            TextBox textBox = (TextBox)sender;
            // Kiểm tra độ dài chuỗi
            if (textBox.Text.Length < 2)
            {
                // Kiểm tra nếu ký tự nhập vào là số
                if (char.IsDigit(e.KeyChar))
                {
                    // Hủy bỏ ký tự nhập vào
                    e.Handled = true;
                }
            }
            // Kiểm tra độ dài của chuỗi nhập vào
            if (textBox.Text.Length >= 4 && e.KeyChar != '\b')
            {
                // Hủy bỏ ký tự nhập vào nếu độ dài vượt quá 4 ký tự
                e.Handled = true;
                return;
            }

            // Kiểm tra ký tự nhập vào
            if (e.KeyChar != 'N' && e.KeyChar != 'V' && !char.IsDigit(e.KeyChar) && e.KeyChar != '\b')
            {
                // Hủy bỏ ký tự nhập vào nếu không phải 'N', 'V' hoặc số
                e.Handled = true;
            }

        }
    }
}
