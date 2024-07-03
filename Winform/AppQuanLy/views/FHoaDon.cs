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
    public partial class FHoaDon : Form
    {
        List<CKhachHang> dskh = new List<CKhachHang>();
        CtrlKhachHang ctrkh = new CtrlKhachHang();
        List<CNhanVien> dsnv = new List<CNhanVien>();
        CtrlNhanVien ctrnv = new CtrlNhanVien();
        List<CSanPham> dssp = new List<CSanPham>();
        CtrlSanPham ctrsp = new CtrlSanPham();
        List<CHoaDon> dshoadons = new List<CHoaDon>();
        CtrlHoaDon ctrhoadons = new CtrlHoaDon();
        CtrlCTHD ctrcthds = new CtrlCTHD();
        List<CCTHD> dscthds = new List<CCTHD>();
        public FHoaDon()
        {
            InitializeComponent();
            int width_cthd = lsvCTHD.Width;
            lsvCTHD.Columns.Add("Mã sản phẩm", 10 * width_cthd / 100);
            lsvCTHD.Columns.Add("Tên sản phẩm", 30 * width_cthd / 100);
            lsvCTHD.Columns.Add("nhà cung cấp", 30 * width_cthd / 100);
            lsvCTHD.Columns.Add("số lượng", 10 * width_cthd / 100);
            lsvCTHD.Columns.Add("Đơn Giá", 20 * width_cthd / 100);
            lsvCTHD.Columns.Add("Giảm Giá", 20 * width_cthd / 100);
            lsvCTHD.Columns.Add("Thành tiền", 30 * width_cthd / 100);
            lsvCTHD.View = View.Details;
            lsvCTHD.FullRowSelect = true;

            int witdh_hd = lsvDSHD.Width;
            lsvDSHD.Columns.Add("Mã hoá đơn", 10 * witdh_hd / 100);
            lsvDSHD.Columns.Add("Mã Nhân Viên", 30 * witdh_hd / 100);
            lsvDSHD.Columns.Add("Mã Khách hàng", 10 * witdh_hd / 100);
            lsvDSHD.Columns.Add("Ngày bán", 20 * witdh_hd / 100);
            lsvDSHD.Columns.Add("Tổng tiền", 30 * witdh_hd / 100);
            lsvDSHD.View = View.Details;
            lsvDSHD.FullRowSelect = true;
        }

        private void FHoaDon_Load(object sender, EventArgs e)
        {
            dshoadons = ctrhoadons.finAll();
            //hiển thị danh sách khách hàng
            dskh = ctrkh.finAll();
            cbMaKH.DataSource = dskh;
            //hiển thị danh sách nhân viên
            dsnv = ctrnv.finAll();
            cbMaNV.DataSource = dsnv;
            foreach (CHoaDon hd in dshoadons)
            {
                string[] obj =
                { hd.MaHD1,hd.MaNV1.MaNV1,hd.MaKH1.MaKH1,hd.NgayBan1+"", hd.TongTien1+"" };
                ListViewItem item = new ListViewItem(obj);
                lsvDSHD.Items.Add(item);
            }
            dssp = ctrsp.finaAll();
            if (dssp.Count > 0)
            {
                lstDSSP.Items.Clear();
                foreach (CSanPham x in dssp)
                    lstDSSP.Items.Add(x);
            }
        }

        private void lsvDSHD_SelectedIndexChanged(object sender, EventArgs e)
        {
            try
            {
                if (lsvDSHD.SelectedItems.Count > 0)
                {
                    ListViewItem item = lsvDSHD.SelectedItems[0];
                    string maHD = item.SubItems[0].Text;
                    string maNV = item.SubItems[1].Text;
                    string maKH = item.SubItems[2].Text;


                    // Lấy thông tin hoá đơn từ danh sách hoá đơn
                    CHoaDon hd = dshoadons.FirstOrDefault(h => h.MaHD1 == maHD);
                    if (hd != null)
                    {
                        txtMaHD.Text = hd.MaHD1;
                        dtpNgayBan.Value = hd.NgayBan1;
                        cbMaNV.Text = hd.MaNV1.MaNV1;
                        cbMaKH.Text = hd.MaKH1.MaKH1;
                        txtTongTien.Text = hd.TongTien1 + "";



                        // Lấy thông tin chi tiết khách hàng
                        CKhachHang kh = new CtrlKhachHang().findKhachHangById(maKH);
                        if (kh != null)
                        {
                            txtDCKH.Text = kh.DiaChi1;
                            txtSoDTKH.Text = kh.SoDT1;
                        }
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Đã xảy ra lỗi: " + ex.Message);
            }
        }

        private void btnTaoMoiHD_Click(object sender, EventArgs e)
        {
            txtMaHD.Select();
            txtMaHD.Focus();
            txtMaHoaDonTimKiem.Text = "";
            btnTimKiem_Click(sender, e);
            txtMaHD.Text = string.Empty;
            cbMaKH.Text = string.Empty;
            txtDCKH.Text = string.Empty;
            txtSoDTKH.Text = string.Empty;
            cbMaNV.Text = string.Empty;

        }

        private void groupBox1_Enter(object sender, EventArgs e)
        {

        }

        private void cbMaKH_SelectedIndexChanged(object sender, EventArgs e)
        {
            CKhachHang kh = (CKhachHang)cbMaKH.SelectedItem;
            txtDCKH.Text = kh.DiaChi1;
            txtSoDTKH.Text = kh.SoDT1;
        }

        private void btnHuyHD_Click(object sender, EventArgs e)
        {
            ListViewItem item = lsvDSHD.SelectedItems[0];
            CHoaDon hoadon = new CHoaDon();
            hoadon.MaHD1 = item.SubItems[0].Text;
            int index = dshoadons.IndexOf(hoadon);
            // tìm kiếm phần tử được chọn ở vị trí nào trong ds
            if (index < 0) { return; }

            //
            hoadon = dshoadons[index];
            if (ctrhoadons.delete(hoadon))
            {

                dshoadons.Remove(hoadon);
                lsvDSHD.Items.Remove(item);
                MessageBox.Show("Xóa thành công");
            }
            else MessageBox.Show("Xóa thất bại!");
        }

        private void btnThemSP_Click(object sender, EventArgs e)
        {
            CSanPham sp = (CSanPham)lstDSSP.SelectedItem;
            CHoaDon hd = new CHoaDon();
            CCTHD cthd = new CCTHD();
            hd.MaHD1 = txtMaHD.Text;
            hd.NgayBan1 = dtpNgayBan.Value;
            CKhachHang kh = (CKhachHang)cbMaKH.SelectedItem;
            CNhanVien nv = (CNhanVien)cbMaNV.SelectedItem;
            hd.MaKH1 = kh;
            hd.MaNV1 = nv;
            cthd.MaSP1 = sp;
            cthd.MaHD1 = hd;
            cthd.SoLuong1 = int.Parse(txtSL.Text);
            cthd.GiamGia1 = int.Parse(txtGG.Text);
            if (!dscthds.Contains(cthd))
            {
                dscthds.Add(cthd);
                double thanhTien = cthd.SoLuong1 * sp.GiaBan1;
                string[] obj = { sp.MaSP1, sp.TenSP1, sp.MaNCC1, cthd.SoLuong1 + "", sp.GiaBan1 + "", cthd.GiamGia1 + "", (thanhTien - cthd.GiamGia1) + "" };
                ListViewItem item = new ListViewItem(obj);
                lsvCTHD.Items.Add(item);

                txtTongTien.Text = (double.Parse(txtTongTien.Text) + (thanhTien - cthd.GiamGia1)) + "";
                hd.TongTien1 = double.Parse(txtTongTien.Text);
            }
            else
            {
                //cập nhật lại số lượng và thành tiền
                int index = dscthds.IndexOf(cthd);
                ListViewItem item = lsvCTHD.Items.Cast<ListViewItem>().FirstOrDefault(x => x.Text == sp.MaSP1);
                cthd = dscthds[index];
                cthd.SoLuong1 += int.Parse(txtSL.Text);
                //cập nhật lại ô trị giá hóa đơn
                txtTongTien.Text = (int.Parse(txtTongTien.Text) + (int.Parse(txtSL.Text) * sp.GiaBan1)) + "";
                hd.TongTien1 = double.Parse(txtTongTien.Text);
                //cập nhật lại lsv

                item.SubItems[3].Text = cthd.SoLuong1 + "";
                item.SubItems[5].Text = int.Parse(item.SubItems[5].Text) + cthd.GiamGia1 + "";
                item.SubItems[6].Text = cthd.SoLuong1 * sp.GiaBan1 + "";
            }
        }

        private void groupBox2_Enter(object sender, EventArgs e)
        {

        }

        private void btnLuuHD_Click(object sender, EventArgs e)
        {
            if (dscthds.Count > 0) // có mua sản phẩm
            {
                CHoaDon hd = dscthds[0].MaHD1;
                //lưu hóa đơn
                if (ctrhoadons.insert(hd))
                {
                    //lưu chi tiết hóa đơn
                    foreach (CCTHD c in dscthds)

                        ctrcthds.insert(c);
                    string[] obj = { hd.MaHD1, hd.MaNV1.MaNV1, hd.MaKH1.MaKH1, hd.NgayBan1 + "", hd.TongTien1 + "" };
                    ListViewItem item = new ListViewItem(obj);
                    lsvDSHD.Items.Add(item);
                    MessageBox.Show("Lưu thành công");


                }
                else
                {
                    MessageBox.Show("Lưu thất bại");
                }
            }
        }
        private void btnXoaSP_Click(object sender, EventArgs e)
        {
            CSanPham sp = (CSanPham)lstDSSP.SelectedItem;
            CCTHD cthd = new CCTHD();
            try
            {
                ListViewItem item = lsvCTHD.SelectedItems[0];

                double soTien = (int.Parse(item.SubItems[3].Text)) * (double.Parse(item.SubItems[4].Text));
                txtTongTien.Text = (int.Parse(txtTongTien.Text) - soTien) + "";

                //xóa khỏi listvieww
                lsvCTHD.Items.Remove(item);
                string maSP = item.SubItems[1].Text;

                // Xóa sản phẩm khỏi danh sách chi tiết hóa đơn
                for (int i = dscthds.Count - 1; i >= 0; i--)
                {
                    if (dscthds[i].MaSP1.MaSP1 == maSP)
                    {
                        dscthds.RemoveAt(i);
                        break;
                    }
                }
            }
            catch { }
        }

        private void txtTenSP_TextChanged(object sender, EventArgs e)
        {
            List<CSanPham> dssp = new List<CSanPham>();
            dssp = ctrsp.FindByTenSP(txtTenSP.Text);
            if (dssp.Count > 0)
            {
                lstDSSP.Items.Clear();
                foreach (CSanPham x in dssp)
                    lstDSSP.Items.Add(x);
            }
        }

        private void txtMaHoaDonTimKiem_TextChanged(object sender, EventArgs e)
        {

        }

        private void btnTimKiem_Click(object sender, EventArgs e)
        {
            string dkfind = txtMaHoaDonTimKiem.Text;
            dshoadons = ctrhoadons.findMaHD(dkfind);
            lsvDSHD.Items.Clear();
            foreach (CHoaDon s in dshoadons)
            {
                string[] obj = { s.MaHD1, s.MaNV1 + "", s.MaKH1 + "", s.NgayBan1 + "", s.TongTien1 + "" };
                ListViewItem item = new ListViewItem(obj);
                lsvDSHD.Items.Add(item);
            }
            if (lsvDSHD.Items.Count == 0)
            {
                MessageBox.Show("không tìm thấy hoá đơn");

            }
            txtMaHD.Text = string.Empty;
            cbMaKH.Text = string.Empty;
            txtDCKH.Text = string.Empty;
            txtSoDTKH.Text = string.Empty;
            cbMaNV.Text = string.Empty;
            txtTongTien.Text = string.Empty;
        }

        private void txtMaHD_KeyPress(object sender, KeyPressEventArgs e)
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
            if (e.KeyChar != 'H' && e.KeyChar != 'D' && !char.IsDigit(e.KeyChar) && e.KeyChar != '\b')
            {
                // Hủy bỏ ký tự nhập vào nếu không phải 'H', 'D' hoặc số
                e.Handled = true;
            }
        }

        private void txtSL_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar))
            {
                e.Handled = true; // Ignore the key press event
            }
        }

        private void txtGG_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar))
            {
                e.Handled = true; // Ignore the key press event
            }
        }

        private void txtMaHoaDonTimKiem_KeyPress(object sender, KeyPressEventArgs e)
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
            if (e.KeyChar != 'H' && e.KeyChar != 'D' && !char.IsDigit(e.KeyChar) && e.KeyChar != '\b')
            {
                // Hủy bỏ ký tự nhập vào nếu không phải 'H', 'D' hoặc số
                e.Handled = true;
            }
        }
    }

}
