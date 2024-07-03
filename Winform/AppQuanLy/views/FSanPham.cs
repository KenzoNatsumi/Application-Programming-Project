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
    public partial class FSanPham : Form
    {
        List<CSanPham> dsSanPhams = new List<CSanPham>();
        CtrlSanPham ctrsanphams = new CtrlSanPham();
        public FSanPham()
        {
            InitializeComponent();
            int width = lsvDSSP.Width;
            lsvDSSP.Columns.Add("Mã sản phẩm", 20 * width / 100);
            lsvDSSP.Columns.Add("Tên San Phẩm", 30 * width / 100);
            lsvDSSP.Columns.Add("Mã nhà cung cấp", 20 * width / 100);
            lsvDSSP.Columns.Add("Số lượng", 10 * width / 100);
            lsvDSSP.Columns.Add("Giá Nhập", 30 * width / 100);
            lsvDSSP.Columns.Add("Giá Bán", 30 * width / 100);
            lsvDSSP.Columns.Add("Ghi chú", 50 * width / 100);
            lsvDSSP.View = View.Details;
            lsvDSSP.FullRowSelect = true;
        }
        private void LoadNhaCungCap()
        {
            List<string> maNCCs = ctrsanphams.GetAllMaNCC();
            cbMaNCC.Items.Clear();
            foreach (string maNCC in maNCCs)
            {
                cbMaNCC.Items.Add(maNCC);
            }
        }
        private void FSanPham_Load(object sender, EventArgs e)
        {
            dsSanPhams = ctrsanphams.finaAll();
            foreach (CSanPham sp in dsSanPhams)
            {
                string[] obj =
                { sp.MaSP1, sp.TenSP1, sp.MaNCC1, sp.SoLuong1+"", sp.GiaNhap1 + "", sp.GiaBan1 + "", sp.GhiChu1 };
                ListViewItem item = new ListViewItem(obj);
                lsvDSSP.Items.Add(item);
            }
            LoadNhaCungCap();
        }

        private void lsvDSSP_SelectedIndexChanged(object sender, EventArgs e)
        {
            try
            {
                ListViewItem item = lsvDSSP.SelectedItems[0];
                CNhaCungCap ncc = new CNhaCungCap();
                CSanPham sp = new CSanPham();
                sp.MaSP1 = item.SubItems[0].Text;
                int index = dsSanPhams.IndexOf(sp);
                if (index < 0)
                {
                    return;
                }
                sp = dsSanPhams[index];
                txtMaSP.Text = sp.MaSP1;
                txtTenSP.Text = sp.TenSP1;
                cbMaNCC.Text = sp.MaNCC1;
                txtSL.Text = sp.SoLuong1 + "";
                txtGN.Text = sp.GiaNhap1 + "";
                txtGB.Text = sp.GiaBan1 + "";
                txtGhiChu.Text = sp.GhiChu1;
                txtTenSPTimKiem.Text = sp.MaSP1;
            }
            catch
            { }
        }

        private void btnThem_Click(object sender, EventArgs e)
        {
            string MaSP = txtMaSP.Text;
            string TenSP = txtTenSP.Text;
            string MaNCC = cbMaNCC.Text;
            int SoLuong = int.Parse(txtSL.Text);
            double GiaNhap = double.Parse(txtGN.Text);
            double GiaBan = double.Parse(txtGB.Text);
            string GhiChu = txtGhiChu.Text;
            CSanPham sp = new CSanPham(MaSP, TenSP, MaNCC, SoLuong, GiaNhap, GiaBan, GhiChu);


            CSanPham existingProduct = ctrsanphams.GetProductByTenSPAndMaNCC(TenSP, MaNCC);

            if (existingProduct != null)
            {
                if (ctrsanphams.UpdateSoLuong(existingProduct.MaSP1, SoLuong))
                {
                    MessageBox.Show("Đã cập nhật số lượng sản phẩm.");
                    existingProduct.SoLuong1 = (int.Parse(existingProduct.SoLuong1 + "") + SoLuong);
                    foreach (ListViewItem item in lsvDSSP.Items)
                    {
                        if (item.SubItems[0].Text == existingProduct.MaSP1)
                        {
                            item.SubItems[3].Text = existingProduct.SoLuong1 + "";
                            break;
                        }
                    }
                }
                else
                {
                    MessageBox.Show("Cập nhật số lượng thất bại.");
                }
            }
            else
            {
                if (ctrsanphams.Insert(sp))
                {
                    MessageBox.Show("Đã thêm");
                    dsSanPhams.Add(sp);
                    string[] obj =
                   {sp.MaSP1, sp.TenSP1, sp.MaNCC1, sp.SoLuong1+ "", sp.GiaNhap1 + "", sp.GiaBan1 + "", sp.GhiChu1  };
                    ListViewItem item = new ListViewItem(obj);
                    lsvDSSP.Items.Add(item);
                    txtMaSP.Clear();
                    txtTenSP.Clear();
                    cbMaNCC.Text = "";
                    txtSL.Clear();
                    txtGN.Clear();
                    txtGB.Clear();
                    txtTenSPTimKiem.Clear();
                    txtGhiChu.Clear();
                    txtMaSP.Focus();
                }
                else
                    MessageBox.Show("Thêm Thất Bại");
            }
            try
            {
                string response = await client.GetStringAsync("http://localhost/path_to_your_php/orders.php");
                DataTable table = (DataTable)JsonConvert.DeserializeObject(response, (typeof(DataTable)));
                lsvDSSP.DataSource = table;
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }


        private void btnCapNhat_Click(object sender, EventArgs e)
        {
            ListViewItem item = lsvDSSP.SelectedItems[0];
            CSanPham sp = new CSanPham();
            sp.MaSP1 = item.SubItems[0].Text;
            int index = dsSanPhams.IndexOf(sp);
            if (index < 0)
            {
                return;
            }
            sp = dsSanPhams[index];
            sp.TenSP1 = txtTenSP.Text;
            sp.MaNCC1 = cbMaNCC.Text;
            sp.SoLuong1 = int.Parse(txtSL.Text);
            sp.GiaNhap1 = double.Parse(txtGN.Text);
            sp.GiaBan1 = double.Parse(txtGB.Text);
            sp.GhiChu1 = txtGhiChu.Text;
            if (ctrsanphams.update(sp))
            {
                MessageBox.Show("Đã cập nhật");
                item.SubItems[1].Text = sp.TenSP1;
                item.SubItems[2].Text = sp.MaNCC1;
                item.SubItems[3].Text = sp.SoLuong1 + "";
                item.SubItems[4].Text = sp.GiaNhap1 + "";
                item.SubItems[5].Text = sp.GiaBan1 + "";
                item.SubItems[5].Text = sp.GhiChu1;
            }
            else
                MessageBox.Show("cập nhật Thất Bại");
        }

        private void btnTaoMoi_Click(object sender, EventArgs e)
        {
            txtMaSP.Clear();
            txtTenSP.Clear();
            cbMaNCC.Text = "";
            txtSL.Clear();
            txtGN.Clear();
            txtGB.Clear();
            txtTenSPTimKiem.Clear();
            txtGhiChu.Clear();
            txtMaSP.Focus();
            txtMaSP.Select();
            btnTimKiem_Click(sender, e);
        }



        private void LoadSanPham()
        {
            dsSanPhams = ctrsanphams.finaAll();
            RefreshListView();
        }

        private void RefreshListView()
        {
            lsvDSSP.Items.Clear();
            foreach (var sp in dsSanPhams)
            {
                string[] obj = { sp.MaSP1, sp.TenSP1, sp.MaNCC1, sp.SoLuong1 + "", sp.GiaNhap1 + "" + "", sp.GiaBan1 + "", sp.GhiChu1 };
                ListViewItem item = new ListViewItem(obj);
                lsvDSSP.Items.Add(item);
            }
        }



        private void btnXoa_Click(object sender, EventArgs e)
        {
            try
            {
                // Kiểm tra xem có mục nào được chọn không
                if (lsvDSSP.SelectedItems.Count == 0)
                    return;

                // Lấy mục được chọn
                ListViewItem item = lsvDSSP.SelectedItems[0];
                string MaSP = item.SubItems[0].Text;

                // Tìm nhân viên trong danh sách theo mã nhân viên
                CSanPham sp = dsSanPhams.FirstOrDefault(sp => sp.MaSP1 == MaSP);
                if (sp == null)
                {
                    return;
                }

                // Xóa Nhân viên
                if (ctrsanphams.delete(sp))
                {
                    MessageBox.Show("Đã Xoá");
                    dsSanPhams.Remove(sp);
                    lsvDSSP.Items.Remove(item);

                    // Cập nhật mã nhà cung cấp cho các mục còn lại
                    ctrsanphams.UpdateMaNCCAfterDeletion(MaSP);
                    LoadSanPham();
                    txtMaSP.Clear();
                    txtTenSP.Clear();
                    cbMaNCC.Text = "";
                    txtSL.Clear();
                    txtGN.Clear();
                    txtGB.Clear();
                    txtTenSPTimKiem.Clear();
                    txtGhiChu.Clear();
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

        private void btnTimKiem_Click(object sender, EventArgs e)
        {
            string dkfind = txtTenSPTimKiem.Text;
            dsSanPhams = ctrsanphams.findMaSP(dkfind);
            lsvDSSP.Items.Clear();
            foreach (CSanPham sp in dsSanPhams)
            {
                string[] obj = { sp.MaSP1, sp.TenSP1, sp.MaNCC1, sp.SoLuong1 + "", sp.GiaNhap1 + "", sp.GiaBan1 + "", sp.GhiChu1 };
                ListViewItem item = new ListViewItem(obj);
                lsvDSSP.Items.Add(item);
            }

            if (lsvDSSP.Items.Count == 0)
            {
                MessageBox.Show("không tìm thấy sản phẩm");
            }
            {
                txtMaSP.Clear();
                txtTenSP.Clear();
                cbMaNCC.Text = "";
                txtSL.Clear();
                txtGN.Clear();
                txtGB.Clear();
                txtGhiChu.Clear();

            }
        }
        private void txtMaSP_KeyPress(object sender, KeyPressEventArgs e)
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
            if (e.KeyChar != 'S' && e.KeyChar != 'P' && !char.IsDigit(e.KeyChar) && e.KeyChar != '\b')
            {
                // Hủy bỏ ký tự nhập vào nếu không phải 'S', 'P' hoặc số
                e.Handled = true;
            }
        }

        private void txtGN_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar))
            {
                e.Handled = true; // Ignore the key press event
            }
        }

        private void txtGB_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar))
            {
                e.Handled = true; // Ignore the key press event
            }
        }

        private void txtSL_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar))
            {
                e.Handled = true; // Ignore the key press event
            }
        }

        private void txtTenSPTimKiem_KeyPress(object sender, KeyPressEventArgs e)
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
            if (e.KeyChar != 'S' && e.KeyChar != 'P' && !char.IsDigit(e.KeyChar) && e.KeyChar != '\b')
            {
                // Hủy bỏ ký tự nhập vào nếu không phải 'S', 'P' hoặc số
                e.Handled = true;
            }
        }
    }
}
