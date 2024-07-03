using quản_lí_cửa_hàng_máy_tính.views;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace quản_lí_cửa_hàng_máy_tính
{
    public partial class Fchuongtrinh : Form
    {
        public Fchuongtrinh()
        {
            InitializeComponent();
        }
        public bool thoat = true;

        public event EventHandler DangXuat;
        private void btnDangXuat_Click(object sender, EventArgs e)
        {
            DangXuat(this, new EventArgs());
        }

        private void btnThoat_Click(object sender, EventArgs e)
        {
            if (thoat)
                Application.Exit();
        }

        private void Fchuongtrinh_FormClosed(object sender, FormClosedEventArgs e)
        {
            if (thoat)
                Application.Exit();
        }

        private void Fchuongtrinh_FormClosing(object sender, FormClosingEventArgs e)
        {
            if (thoat)
            {
                if (MessageBox.Show("bạn có muốn thoát chương trình không",
                     "cảnh báo", MessageBoxButtons.YesNo) != DialogResult.Yes)
                    e.Cancel = true;
            }
        }
        private Form currentFromChild;
        private void openChildForm(Form ChildForm)
        {
            if (currentFromChild != null)
            {
                currentFromChild.Close();
            }
            currentFromChild = ChildForm;
            ChildForm.TopLevel = false;
            ChildForm.FormBorderStyle = FormBorderStyle.None;
            ChildForm.Dock = DockStyle.Fill;
            panel_Body.Controls.Add(ChildForm);
            panel_Body.Tag = ChildForm;
            ChildForm.BringToFront();
            ChildForm.Show();
        }
        private void btnDMNV_Click(object sender, EventArgs e)
        {
            openChildForm(new FNhanVien());
            label_TieuDe.Text = btnDMNV.Text;
        }

        private void btnDMKH_Click(object sender, EventArgs e)
        {
            openChildForm(new FKhachHang());
            label_TieuDe.Text = btnDMKH.Text;
        }

        private void btnDMSP_Click(object sender, EventArgs e)
        {
            openChildForm(new FSanPham());
            label_TieuDe.Text = btnDMSP.Text;
        }

        private void btnDMNCC_Click(object sender, EventArgs e)
        {
            openChildForm(new FNhaCungCap());
            label_TieuDe.Text = btnDMNCC.Text;
        }

        private void btnHDBH_Click(object sender, EventArgs e)
        {
            openChildForm(new FHoaDon());
            label_TieuDe.Text = btnHDBH.Text;
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {
            if (currentFromChild != null)
            {
                currentFromChild.Close();
            }
            label_TieuDe.Text = "home";
        }
    }
}
