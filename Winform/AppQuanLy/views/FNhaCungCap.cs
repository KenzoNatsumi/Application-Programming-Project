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
    public partial class FNhaCungCap : Form
    {
        List<CNhaCungCap> dsNhaCungCaps = new List<CNhaCungCap>();
        CtrlNhaCungCap ctrNhaCungCap = new CtrlNhaCungCap();
        public FNhaCungCap()
        {
            InitializeComponent();
            int width = lsvDSNCC.Width;
            lsvDSNCC.Columns.Add("Mã nhà cung cấp", 50 * width / 100);
            lsvDSNCC.Columns.Add("Tên nhà cung cấp", 50 * width / 100);
            lsvDSNCC.View = View.Details;
            lsvDSNCC.FullRowSelect = true;
        }


        private void FNhaCungCap_Load(object sender, EventArgs e)
        {
            dsNhaCungCaps = ctrNhaCungCap.finAll();
            foreach (CNhaCungCap ncc in dsNhaCungCaps)
            {
                string[] obj =
                { ncc.MaNCC1,  ncc.TenNCC1 + " "};
                ListViewItem item = new ListViewItem(obj);
                lsvDSNCC.Items.Add(item);
            }
        }

        private void lsvDSNCC_SelectedIndexChanged(object sender, EventArgs e)
        {
            try
            {
                ListViewItem item = lsvDSNCC.SelectedItems[0];
                CNhaCungCap NCC = new CNhaCungCap();
                NCC.MaNCC1 = item.SubItems[0].Text;
                int index = dsNhaCungCaps.IndexOf(NCC);
                if (index < 0)
                {
                    return;
                }
                NCC = dsNhaCungCaps[index];
                txtMaNCC.Text = NCC.MaNCC1;
                txtTenNCC.Text = NCC.TenNCC1;
            }
            catch
            { }
        }

        private void btnThem_Click(object sender, EventArgs e)
        {
            string MaNCC = txtMaNCC.Text;
            string TenNCC = txtTenNCC.Text;
            CNhaCungCap ncc = new CNhaCungCap(MaNCC, TenNCC);
            if (ctrNhaCungCap.Insert(ncc))
            {
                MessageBox.Show("Đã thêm");
                dsNhaCungCaps.Add(ncc);
                string[] obj =
               { ncc.MaNCC1,  ncc.TenNCC1 + " "};
                ListViewItem item = new ListViewItem(obj);
                lsvDSNCC.Items.Add(item);
                txtMaNCC.Clear();
                txtTenNCC.Clear();
                txtMaNCC.Focus();
            }
            else
                MessageBox.Show("Thêm Thất Bại");
        }



        private void btnXoa_Click(object sender, EventArgs e)
        {
            try
            {
                // Kiểm tra xem có mục nào được chọn không
                if (lsvDSNCC.SelectedItems.Count == 0)
                    return;

                // Lấy mục được chọn
                ListViewItem item = lsvDSNCC.SelectedItems[0];
                string maNCC = item.SubItems[0].Text;

                // Tìm nhà cung cấp trong danh sách theo mã nhà cung cấp
                CNhaCungCap NCC = dsNhaCungCaps.FirstOrDefault(ncc => ncc.MaNCC1 == maNCC);
                if (NCC == null)
                {
                    return;
                }

                // Xóa nhà cung cấp
                if (ctrNhaCungCap.delete(NCC))
                {
                    MessageBox.Show("Đã Xoá");
                    dsNhaCungCaps.Remove(NCC);
                    lsvDSNCC.Items.Remove(item);

                    // Cập nhật mã nhà cung cấp cho các mục còn lại
                    ctrNhaCungCap.UpdateMaNCCAfterDeletion(maNCC);
                    LoadNhaCungCap(); // Tải lại dữ liệu để làm mới ListView
                    txtMaNCC.Clear();
                    txtTenNCC.Clear();
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
        private void LoadNhaCungCap()
        {
            dsNhaCungCaps = ctrNhaCungCap.finAll();
            RefreshListView();
        }

        private void RefreshListView()
        {
            lsvDSNCC.Items.Clear();
            foreach (var ncc in dsNhaCungCaps)
            {
                string[] obj = { ncc.MaNCC1, ncc.TenNCC1 };
                ListViewItem item = new ListViewItem(obj);
                lsvDSNCC.Items.Add(item);
            }
        }






        private void btnCapNhat_Click(object sender, EventArgs e)
        {
            ListViewItem item = lsvDSNCC.SelectedItems[0];
            CNhaCungCap NCC = new CNhaCungCap();
            NCC.MaNCC1 = item.SubItems[0].Text;
            int index = dsNhaCungCaps.IndexOf(NCC);
            if (index < 0)
            {
                return;
            }
            NCC = dsNhaCungCaps[index];
            NCC.TenNCC1 = txtTenNCC.Text;
            if (ctrNhaCungCap.update(NCC))
            {
                MessageBox.Show("Đã cập nhật");
                item.SubItems[1].Text = NCC.TenNCC1;
            }
            else
                MessageBox.Show("cập nhật Thất Bại");
        }

        private void btnTaoMoi_Click(object sender, EventArgs e)
        {
            txtMaNCC.Clear();
            txtTenNCCTimKiem.Clear();
            txtTenNCC.Clear();
            txtMaNCC.Focus();
            txtMaNCC.Select();
            txtTenNCCTimKiem.Text = "";
            btnTimKiem_Click(sender, e);
        }

        private void btnTimKiem_Click(object sender, EventArgs e)
        {
            string dkfind = txtTenNCCTimKiem.Text;
            dsNhaCungCaps = ctrNhaCungCap.findMaNCC(dkfind);
            lsvDSNCC.Items.Clear();
            foreach (CNhaCungCap ncc in dsNhaCungCaps)
            {
                string[] obj =
                { ncc.MaNCC1,  ncc.TenNCC1 + " "};
                ListViewItem item = new ListViewItem(obj);
                lsvDSNCC.Items.Add(item);
            }
            if (lsvDSNCC.Items.Count == 0)
            {
                MessageBox.Show("không tìm thấy khách hàng");
            }
            txtMaNCC.Clear();
            txtTenNCCTimKiem.Clear();
            txtTenNCC.Clear();
        }

        private void txtMaNCC_KeyPress(object sender, KeyPressEventArgs e)
        {
            TextBox textBox = (TextBox)sender;
            // Kiểm tra độ dài chuỗi
            if (textBox.Text.Length < 3)
            {
                // Kiểm tra nếu ký tự nhập vào là số
                if (char.IsDigit(e.KeyChar))
                {
                    // Hủy bỏ ký tự nhập vào
                    e.Handled = true;
                }
            }
            // Kiểm tra độ dài của chuỗi nhập vào
            if (textBox.Text.Length >= 5 && e.KeyChar != '\b')
            {
                // Hủy bỏ ký tự nhập vào nếu độ dài vượt quá 5 ký tự
                e.Handled = true;
                return;
            }

            // Kiểm tra ký tự nhập vào
            if (e.KeyChar != 'N' && e.KeyChar != 'C' && e.KeyChar != 'C' && !char.IsDigit(e.KeyChar) && e.KeyChar != '\b')
            {
                // Hủy bỏ ký tự nhập vào nếu không phải 'N', 'C', 'C' hoặc số
                e.Handled = true;
            }
        }

        private void txtTenNCCTimKiem_KeyPress(object sender, KeyPressEventArgs e)
        {
            TextBox textBox = (TextBox)sender;
            // Kiểm tra độ dài chuỗi
            if (textBox.Text.Length < 3)
            {
                // Kiểm tra nếu ký tự nhập vào là số
                if (char.IsDigit(e.KeyChar))
                {
                    // Hủy bỏ ký tự nhập vào
                    e.Handled = true;
                }
            }
            // Kiểm tra độ dài của chuỗi nhập vào
            if (textBox.Text.Length >= 5 && e.KeyChar != '\b')
            {
                // Hủy bỏ ký tự nhập vào nếu độ dài vượt quá 5 ký tự
                e.Handled = true;
                return;
            }

            // Kiểm tra ký tự nhập vào
            if (e.KeyChar != 'N' && e.KeyChar != 'C' && e.KeyChar != 'C' && !char.IsDigit(e.KeyChar) && e.KeyChar != '\b')
            {
                // Hủy bỏ ký tự nhập vào nếu không phải 'N', 'C', 'C' hoặc số
                e.Handled = true;
            }
        }
    }
}
