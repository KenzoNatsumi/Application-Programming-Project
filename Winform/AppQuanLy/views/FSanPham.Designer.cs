namespace quản_lí_cửa_hàng_máy_tính.views
{
    partial class FSanPham
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
            groupBox2 = new GroupBox();
            lsvDSSP = new ListView();
            groupBox1 = new GroupBox();
            groupBox3 = new GroupBox();
            txtGhiChu = new TextBox();
            txtSL = new TextBox();
            label6 = new Label();
            txtGB = new TextBox();
            label5 = new Label();
            cbMaNCC = new ComboBox();
            txtGN = new TextBox();
            txtTenSP = new TextBox();
            txtMaSP = new TextBox();
            label4 = new Label();
            label3 = new Label();
            label2 = new Label();
            label1 = new Label();
            groupBox4 = new GroupBox();
            txtTenSPTimKiem = new TextBox();
            btnTimKiem = new Button();
            label7 = new Label();
            btnTaoMoi = new Button();
            btnCapNhat = new Button();
            btnThem = new Button();
            btnXoa = new Button();
            groupBox2.SuspendLayout();
            groupBox1.SuspendLayout();
            groupBox3.SuspendLayout();
            groupBox4.SuspendLayout();
            SuspendLayout();
            // 
            // groupBox2
            // 
            groupBox2.BackColor = SystemColors.ActiveCaption;
            groupBox2.Controls.Add(lsvDSSP);
            groupBox2.Font = new Font("Segoe UI Semibold", 9.75F, FontStyle.Bold, GraphicsUnit.Point);
            groupBox2.ForeColor = Color.Maroon;
            groupBox2.Location = new Point(41, 232);
            groupBox2.Name = "groupBox2";
            groupBox2.Size = new Size(748, 219);
            groupBox2.TabIndex = 5;
            groupBox2.TabStop = false;
            groupBox2.Text = "Danh sách sản phẩm";
            // 
            // lsvDSSP
            // 
            lsvDSSP.Dock = DockStyle.Fill;
            lsvDSSP.Location = new Point(3, 21);
            lsvDSSP.Name = "lsvDSSP";
            lsvDSSP.Size = new Size(742, 195);
            lsvDSSP.TabIndex = 0;
            lsvDSSP.UseCompatibleStateImageBehavior = false;
            lsvDSSP.SelectedIndexChanged += lsvDSSP_SelectedIndexChanged;
            // 
            // groupBox1
            // 
            groupBox1.BackColor = SystemColors.ActiveCaption;
            groupBox1.Controls.Add(groupBox3);
            groupBox1.Controls.Add(txtSL);
            groupBox1.Controls.Add(label6);
            groupBox1.Controls.Add(txtGB);
            groupBox1.Controls.Add(label5);
            groupBox1.Controls.Add(cbMaNCC);
            groupBox1.Controls.Add(txtGN);
            groupBox1.Controls.Add(txtTenSP);
            groupBox1.Controls.Add(txtMaSP);
            groupBox1.Controls.Add(label4);
            groupBox1.Controls.Add(label3);
            groupBox1.Controls.Add(label2);
            groupBox1.Controls.Add(label1);
            groupBox1.Font = new Font("Segoe UI Semibold", 9.75F, FontStyle.Bold, GraphicsUnit.Point);
            groupBox1.ForeColor = Color.Maroon;
            groupBox1.Location = new Point(44, 32);
            groupBox1.Name = "groupBox1";
            groupBox1.Size = new Size(640, 194);
            groupBox1.TabIndex = 6;
            groupBox1.TabStop = false;
            groupBox1.Text = "Thông tin sản phẩm";
            // 
            // groupBox3
            // 
            groupBox3.Controls.Add(txtGhiChu);
            groupBox3.ForeColor = Color.Maroon;
            groupBox3.Location = new Point(149, 134);
            groupBox3.Name = "groupBox3";
            groupBox3.Size = new Size(344, 48);
            groupBox3.TabIndex = 12;
            groupBox3.TabStop = false;
            groupBox3.Text = "Ghi chú";
            // 
            // txtGhiChu
            // 
            txtGhiChu.Location = new Point(6, 17);
            txtGhiChu.Name = "txtGhiChu";
            txtGhiChu.Size = new Size(332, 25);
            txtGhiChu.TabIndex = 13;
            // 
            // txtSL
            // 
            txtSL.Location = new Point(449, 103);
            txtSL.Name = "txtSL";
            txtSL.Size = new Size(162, 25);
            txtSL.TabIndex = 11;
            txtSL.KeyPress += txtSL_KeyPress;
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Location = new Point(376, 108);
            label6.Name = "label6";
            label6.Size = new Size(62, 17);
            label6.TabIndex = 10;
            label6.Text = "Số lượng";
            // 
            // txtGB
            // 
            txtGB.Location = new Point(449, 67);
            txtGB.Name = "txtGB";
            txtGB.Size = new Size(162, 25);
            txtGB.TabIndex = 9;
            txtGB.KeyPress += txtGB_KeyPress;
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Location = new Point(376, 70);
            label5.Name = "label5";
            label5.Size = new Size(54, 17);
            label5.TabIndex = 8;
            label5.Text = "Giá bán";
            // 
            // cbMaNCC
            // 
            cbMaNCC.FormattingEnabled = true;
            cbMaNCC.Location = new Point(136, 100);
            cbMaNCC.Name = "cbMaNCC";
            cbMaNCC.Size = new Size(176, 25);
            cbMaNCC.TabIndex = 7;
            // 
            // txtGN
            // 
            txtGN.Location = new Point(449, 24);
            txtGN.Name = "txtGN";
            txtGN.Size = new Size(162, 25);
            txtGN.TabIndex = 6;
            txtGN.KeyPress += txtGN_KeyPress;
            // 
            // txtTenSP
            // 
            txtTenSP.Location = new Point(136, 62);
            txtTenSP.Name = "txtTenSP";
            txtTenSP.Size = new Size(176, 25);
            txtTenSP.TabIndex = 5;
            // 
            // txtMaSP
            // 
            txtMaSP.Location = new Point(138, 24);
            txtMaSP.Name = "txtMaSP";
            txtMaSP.Size = new Size(174, 25);
            txtMaSP.TabIndex = 4;
            txtMaSP.KeyPress += txtMaSP_KeyPress;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(17, 103);
            label4.Name = "label4";
            label4.Size = new Size(113, 17);
            label4.TabIndex = 3;
            label4.Text = "Mã nhà cung cấp";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(376, 27);
            label3.Name = "label3";
            label3.Size = new Size(62, 17);
            label3.TabIndex = 2;
            label3.Text = "Giá nhập";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(17, 65);
            label2.Name = "label2";
            label2.Size = new Size(93, 17);
            label2.TabIndex = 1;
            label2.Text = "Tên sản phẩm";
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(17, 27);
            label1.Name = "label1";
            label1.Size = new Size(91, 17);
            label1.TabIndex = 0;
            label1.Text = "Mã sản phẩm";
            // 
            // groupBox4
            // 
            groupBox4.BackColor = SystemColors.ActiveCaption;
            groupBox4.Controls.Add(txtTenSPTimKiem);
            groupBox4.Controls.Add(btnTimKiem);
            groupBox4.Controls.Add(label7);
            groupBox4.Font = new Font("Segoe UI Semibold", 9.75F, FontStyle.Bold, GraphicsUnit.Point);
            groupBox4.ForeColor = Color.Maroon;
            groupBox4.Location = new Point(44, 457);
            groupBox4.Name = "groupBox4";
            groupBox4.Size = new Size(742, 69);
            groupBox4.TabIndex = 10;
            groupBox4.TabStop = false;
            groupBox4.Text = "Tìm kiếm sản phẩm";
            // 
            // txtTenSPTimKiem
            // 
            txtTenSPTimKiem.Location = new Point(165, 26);
            txtTenSPTimKiem.Name = "txtTenSPTimKiem";
            txtTenSPTimKiem.Size = new Size(374, 25);
            txtTenSPTimKiem.TabIndex = 18;
            txtTenSPTimKiem.KeyPress += txtTenSPTimKiem_KeyPress;
            // 
            // btnTimKiem
            // 
            btnTimKiem.BackColor = SystemColors.GradientInactiveCaption;
            btnTimKiem.Font = new Font("Segoe UI Semibold", 9.75F, FontStyle.Bold, GraphicsUnit.Point);
            btnTimKiem.ForeColor = Color.Maroon;
            btnTimKiem.Location = new Point(545, 22);
            btnTimKiem.Name = "btnTimKiem";
            btnTimKiem.Size = new Size(75, 32);
            btnTimKiem.TabIndex = 17;
            btnTimKiem.Text = "Tìm kiếm";
            btnTimKiem.UseVisualStyleBackColor = false;
            btnTimKiem.Click += btnTimKiem_Click;
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.Font = new Font("Segoe UI Semibold", 9.75F, FontStyle.Bold, GraphicsUnit.Point);
            label7.ForeColor = Color.Maroon;
            label7.Location = new Point(67, 30);
            label7.Name = "label7";
            label7.Size = new Size(92, 17);
            label7.TabIndex = 16;
            label7.Text = "Mã Sản Phẩm";
            // 
            // btnTaoMoi
            // 
            btnTaoMoi.BackColor = SystemColors.GradientInactiveCaption;
            btnTaoMoi.Font = new Font("Segoe UI Semibold", 9.75F, FontStyle.Bold, GraphicsUnit.Point);
            btnTaoMoi.ForeColor = Color.Maroon;
            btnTaoMoi.Location = new Point(690, 190);
            btnTaoMoi.Name = "btnTaoMoi";
            btnTaoMoi.Size = new Size(99, 36);
            btnTaoMoi.TabIndex = 21;
            btnTaoMoi.Text = "Tạo mới";
            btnTaoMoi.UseVisualStyleBackColor = false;
            btnTaoMoi.Click += btnTaoMoi_Click;
            // 
            // btnCapNhat
            // 
            btnCapNhat.BackColor = SystemColors.GradientInactiveCaption;
            btnCapNhat.Font = new Font("Segoe UI Semibold", 9.75F, FontStyle.Bold, GraphicsUnit.Point);
            btnCapNhat.ForeColor = Color.Maroon;
            btnCapNhat.Location = new Point(690, 86);
            btnCapNhat.Name = "btnCapNhat";
            btnCapNhat.Size = new Size(99, 36);
            btnCapNhat.TabIndex = 20;
            btnCapNhat.Text = "Cập nhật";
            btnCapNhat.UseVisualStyleBackColor = false;
            btnCapNhat.Click += btnCapNhat_Click;
            // 
            // btnThem
            // 
            btnThem.BackColor = SystemColors.GradientInactiveCaption;
            btnThem.Font = new Font("Segoe UI Semibold", 9.75F, FontStyle.Bold, GraphicsUnit.Point);
            btnThem.ForeColor = Color.Maroon;
            btnThem.Location = new Point(690, 32);
            btnThem.Name = "btnThem";
            btnThem.Size = new Size(99, 38);
            btnThem.TabIndex = 19;
            btnThem.Text = "Thêm";
            btnThem.UseVisualStyleBackColor = false;
            btnThem.Click += btnThem_Click;
            // 
            // btnXoa
            // 
            btnXoa.BackColor = SystemColors.GradientInactiveCaption;
            btnXoa.Font = new Font("Segoe UI Semibold", 9.75F, FontStyle.Bold, GraphicsUnit.Point);
            btnXoa.ForeColor = Color.Maroon;
            btnXoa.Location = new Point(690, 137);
            btnXoa.Name = "btnXoa";
            btnXoa.Size = new Size(99, 36);
            btnXoa.TabIndex = 22;
            btnXoa.Text = "Xoá";
            btnXoa.UseVisualStyleBackColor = false;
            btnXoa.Click += btnXoa_Click;
            // 
            // FSanPham
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(828, 559);
            Controls.Add(btnXoa);
            Controls.Add(btnTaoMoi);
            Controls.Add(btnCapNhat);
            Controls.Add(btnThem);
            Controls.Add(groupBox4);
            Controls.Add(groupBox2);
            Controls.Add(groupBox1);
            Name = "FSanPham";
            Text = "FSanPham";
            Load += FSanPham_Load;
            groupBox2.ResumeLayout(false);
            groupBox1.ResumeLayout(false);
            groupBox1.PerformLayout();
            groupBox3.ResumeLayout(false);
            groupBox3.PerformLayout();
            groupBox4.ResumeLayout(false);
            groupBox4.PerformLayout();
            ResumeLayout(false);
        }

        #endregion
        private GroupBox groupBox2;
        private ListView lsvDSSP;
        private GroupBox groupBox1;
        private TextBox txtGN;
        private TextBox txtTenSP;
        private TextBox txtMaSP;
        private Label label4;
        private Label label3;
        private Label label2;
        private Label label1;
        private Label label6;
        private TextBox txtGB;
        private Label label5;
        private ComboBox cbMaNCC;
        private GroupBox groupBox3;
        private TextBox txtGhiChu;
        private TextBox txtSL;
        private GroupBox groupBox4;
        private Button btnTimKiem;
        private Label label7;
        private TextBox txtTenSPTimKiem;
        private Button btnTaoMoi;
        private Button btnCapNhat;
        private Button btnThem;
        private Button btnXoa;
    }
}