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
    public partial class FKhachHang : Form
    {
        List<CKhachHang> dskhachhangs = new List<CKhachHang>();
        CtrlKhachHang ctrkhachhangs = new CtrlKhachHang();
        public FKhachHang()
        {
            InitializeComponent();
            int width = lsvDSKH.Width;
            lsvDSKH.Columns.Add("Mã nhà khách hàng", 10 * width / 100);
            lsvDSKH.Columns.Add("Tên nhà cung cấp", 30 * width / 100);
            lsvDSKH.Columns.Add("Địa chỉ", 40 * width / 100);
            lsvDSKH.Columns.Add("Số điện thoại", 20 * width / 100);
            lsvDSKH.View = View.Details;
            lsvDSKH.FullRowSelect = true;
        }

        private void FKhachHang_Load(object sender, EventArgs e)
        {
            dskhachhangs = ctrkhachhangs.finAll();
            foreach (CKhachHang kh in dskhachhangs)
            {
                string[] obj =
                { kh.MaKH1, kh.TenKH1 , kh.DiaChi1, kh.SoDT1 };
                ListViewItem item = new ListViewItem(obj);
                lsvDSKH.Items.Add(item);
            }
        }

        private void lsvDSKH_SelectedIndexChanged(object sender, EventArgs e)
        {
            try
            {
                ListViewItem item = lsvDSKH.SelectedItems[0];
                CKhachHang kh = new CKhachHang();
                kh.MaKH1 = item.SubItems[0].Text;
                int index = dskhachhangs.IndexOf(kh);
                if (index < 0)
                {
                    return;
                }
                kh = dskhachhangs[index];
                txtMaKH.Text = kh.MaKH1;
                txtTenKH.Text = kh.TenKH1;
                txtDiaChi.Text = kh.DiaChi1;
                txtSoDT.Text = kh.SoDT1;
            }
            catch
            { }
        }
        private void LoadKhachHang()
        {
            dskhachhangs = ctrkhachhangs.finAll();
            RefreshListView();
        }

        private void RefreshListView()
        {
            lsvDSKH.Items.Clear();
            foreach (var kh in dskhachhangs)
            {
                string[] obj = { kh.MaKH1, kh.TenKH1, kh.DiaChi1, kh.SoDT1 };
                ListViewItem item = new ListViewItem(obj);
                lsvDSKH.Items.Add(item);
            }
        }

        private void btnThem_Click_1(object sender, EventArgs e)
        {
            string MaKH = txtMaKH.Text;
            string TenKH = txtTenKH.Text;
            string DiaChi = txtDiaChi.Text;
            string SoDT = txtSoDT.Text;
            CKhachHang kh = new CKhachHang(MaKH, TenKH, DiaChi, SoDT);
            if (ctrkhachhangs.Insert(kh))
            {
                MessageBox.Show("Đã thêm");
                dskhachhangs.Add(kh);
                string[] obj =
               { kh.MaKH1, kh.TenKH1 , kh.DiaChi1, kh.SoDT1  };
                ListViewItem item = new ListViewItem(obj);
                lsvDSKH.Items.Add(item);
                txtMaKH.Clear();
                txtTenKH.Clear();
                txtDiaChi.Clear();
                txtTenKHTimKiem.Clear();
                txtSoDT.Clear();
                txtMaKH.Focus();
            }
            else
                MessageBox.Show("Thêm Thất Bại");
        }

        private void btnCapNhat_Click_1(object sender, EventArgs e)
        {
            ListViewItem item = lsvDSKH.SelectedItems[0];
            CKhachHang kh = new CKhachHang();
            kh.MaKH1 = item.SubItems[0].Text;
            int index = dskhachhangs.IndexOf(kh);
            if (index < 0)
            {
                return;
            }
            kh = dskhachhangs[index];
            kh.TenKH1 = txtTenKH.Text;
            kh.DiaChi1 = txtDiaChi.Text;
            kh.SoDT1 = txtSoDT.Text;
            if (ctrkhachhangs.update(kh))
            {
                MessageBox.Show("Đã cập nhật");
                item.SubItems[1].Text = kh.TenKH1;
                item.SubItems[2].Text = kh.DiaChi1;
                item.SubItems[3].Text = kh.SoDT1;
            }
            else
                MessageBox.Show("cập nhật Thất Bại");
        }

        private void btnXoa_Click_1(object sender, EventArgs e)
        {
            try
            {
                // Kiểm tra xem có mục nào được chọn không
                if (lsvDSKH.SelectedItems.Count == 0)
                    return;

                // Lấy mục được chọn
                ListViewItem item = lsvDSKH.SelectedItems[0];
                string MaKH = item.SubItems[0].Text;

                // Tìm khách hàng trong danh sách theo mã khách hàng
                CKhachHang kh = dskhachhangs.FirstOrDefault(kh => kh.MaKH1 == MaKH);
                if (kh == null)
                {
                    return;
                }

                // Xóa khách hàng
                if (ctrkhachhangs.delete(kh))
                {
                    MessageBox.Show("Đã Xoá");
                    dskhachhangs.Remove(kh);
                    lsvDSKH.Items.Remove(item);

                    // Cập nhật mã khách hàng cho các mục còn lại
                    ctrkhachhangs.UpdateMaNCCAfterDeletion(MaKH);
                    LoadKhachHang(); // Tải lại dữ liệu để làm mới ListView
                    txtMaKH.Clear();
                    txtTenKH.Clear();
                    txtDiaChi.Clear();
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

        private void btnTaoMoi_Click(object sender, EventArgs e)
        {
            txtMaKH.Clear();
            txtTenKH.Clear();
            txtDiaChi.Clear();
            txtSoDT.Clear();
            txtMaKH.Focus();
            txtMaKH.Select();
            txtTenKHTimKiem.Text = "";
            btnTimKiem_Click(sender, e);
        }
        private void btnTimKiem_Click(object sender, EventArgs e)
        {

            string dkfind = txtTenKHTimKiem.Text;
            dskhachhangs = ctrkhachhangs.findMaKH(dkfind);
            lsvDSKH.Items.Clear();
            foreach (CKhachHang kh in dskhachhangs)
            {
                string[] obj =
                { kh.MaKH1, kh.TenKH1 , kh.DiaChi1, kh.SoDT1 };
                ListViewItem item = new ListViewItem(obj);
                lsvDSKH.Items.Add(item);
            }
            if (lsvDSKH.Items.Count == 0)
            {
                MessageBox.Show("không tìm thấy khách hàng");
            }
            txtMaKH.Clear();
            txtTenKH.Clear();
            txtDiaChi.Clear();
            txtSoDT.Clear();
        }

        private void txtMaKH_KeyPress(object sender, KeyPressEventArgs e)
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
            if (e.KeyChar != 'K' && e.KeyChar != 'H' && !char.IsDigit(e.KeyChar) && e.KeyChar != '\b')
            {
                // Hủy bỏ ký tự nhập vào nếu không phải 'K', 'H' hoặc số
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

        private void txtTenKHTimKiem_KeyPress(object sender, KeyPressEventArgs e)
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
            if (e.KeyChar != 'K' && e.KeyChar != 'H' && !char.IsDigit(e.KeyChar) && e.KeyChar != '\b')
            {
                // Hủy bỏ ký tự nhập vào nếu không phải 'K', 'H' hoặc số
                e.Handled = true;
            }
        }
    }
}
