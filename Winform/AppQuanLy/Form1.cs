namespace quản_lí_cửa_hàng_máy_tính
{
    public partial class Form1 : Form
    {
        string tk = "admin";
        string mk = "admin123";
        public Form1()
        {
            InitializeComponent();
        }

        private void btnThoat_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void btnDN_Click(object sender, EventArgs e)
        {
            if (ktr(txtTK.Text, txtMK.Text))
            {
                Fchuongtrinh f = new Fchuongtrinh();
                f.Show();
                this.Hide();
                f.DangXuat += F_DangXuat;
            }
            else
            {
                MessageBox.Show(" tên đăng nhập hoặc tài khoản không hợp lệ", "lỗi");
                txtTK.Focus();
                txtTK.Clear();
                txtMK.Clear();
            }
        }

        private void F_DangXuat(object? sender, EventArgs e)
        {
            (sender as Fchuongtrinh).thoat = false;
            this.Show();
            (sender as Fchuongtrinh).Close();
            txtTK.Clear();
            txtMK.Clear();
        }
        bool ktr(string tk, string mk)
        {
            if (tk == this.tk && mk == this.mk)
            {
                return true;
            }
            return false;
        }
    }
}