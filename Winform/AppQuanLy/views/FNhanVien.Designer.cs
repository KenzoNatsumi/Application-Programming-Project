namespace quản_lí_cửa_hàng_máy_tính.views
{
    partial class FNhanVien
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
            groupBox1 = new GroupBox();
            txtGioiTinh = new TextBox();
            label7 = new Label();
            dtpNgaySinh = new DateTimePicker();
            txtDiaChi = new TextBox();
            txtSoDT = new TextBox();
            txtTenNV = new TextBox();
            txtMaNV = new TextBox();
            label4 = new Label();
            label5 = new Label();
            label6 = new Label();
            label3 = new Label();
            label2 = new Label();
            label1 = new Label();
            groupBox2 = new GroupBox();
            lsvDSNV = new ListView();
            btnTaoMoi = new Button();
            btnCapNhat = new Button();
            btnXoa = new Button();
            btnThem = new Button();
            groupBox4 = new GroupBox();
            txtTenNVTimKiem = new TextBox();
            btnTimKiem = new Button();
            label8 = new Label();
            groupBox1.SuspendLayout();
            groupBox2.SuspendLayout();
            groupBox4.SuspendLayout();
            SuspendLayout();
            // 
            // groupBox1
            // 
            groupBox1.BackColor = SystemColors.ActiveCaption;
            groupBox1.Controls.Add(txtGioiTinh);
            groupBox1.Controls.Add(label7);
            groupBox1.Controls.Add(dtpNgaySinh);
            groupBox1.Controls.Add(txtDiaChi);
            groupBox1.Controls.Add(txtSoDT);
            groupBox1.Controls.Add(txtTenNV);
            groupBox1.Controls.Add(txtMaNV);
            groupBox1.Controls.Add(label4);
            groupBox1.Controls.Add(label5);
            groupBox1.Controls.Add(label6);
            groupBox1.Controls.Add(label3);
            groupBox1.Controls.Add(label2);
            groupBox1.Controls.Add(label1);
            groupBox1.Font = new Font("Segoe UI Semibold", 9.75F, FontStyle.Bold, GraphicsUnit.Point);
            groupBox1.ForeColor = Color.Maroon;
            groupBox1.Location = new Point(51, 25);
            groupBox1.Name = "groupBox1";
            groupBox1.Size = new Size(627, 179);
            groupBox1.TabIndex = 0;
            groupBox1.TabStop = false;
            groupBox1.Text = "Thông tin nhân viên";
            // 
            // txtGioiTinh
            // 
            txtGioiTinh.Location = new Point(374, 86);
            txtGioiTinh.Name = "txtGioiTinh";
            txtGioiTinh.Size = new Size(192, 25);
            txtGioiTinh.TabIndex = 14;
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.Location = new Point(297, 90);
            label7.Name = "label7";
            label7.Size = new Size(59, 17);
            label7.TabIndex = 13;
            label7.Text = "Giới tính";
            // 
            // dtpNgaySinh
            // 
            dtpNgaySinh.Location = new Point(375, 140);
            dtpNgaySinh.Name = "dtpNgaySinh";
            dtpNgaySinh.Size = new Size(192, 25);
            dtpNgaySinh.TabIndex = 12;
            // 
            // txtDiaChi
            // 
            txtDiaChi.Location = new Point(374, 36);
            txtDiaChi.Name = "txtDiaChi";
            txtDiaChi.Size = new Size(192, 25);
            txtDiaChi.TabIndex = 10;
            // 
            // txtSoDT
            // 
            txtSoDT.Location = new Point(128, 138);
            txtSoDT.Name = "txtSoDT";
            txtSoDT.Size = new Size(147, 25);
            txtSoDT.TabIndex = 9;
            txtSoDT.KeyPress += txtSoDT_KeyPress;
            // 
            // txtTenNV
            // 
            txtTenNV.Location = new Point(128, 84);
            txtTenNV.Name = "txtTenNV";
            txtTenNV.Size = new Size(147, 25);
            txtTenNV.TabIndex = 8;
            // 
            // txtMaNV
            // 
            txtMaNV.Location = new Point(128, 36);
            txtMaNV.Name = "txtMaNV";
            txtMaNV.Size = new Size(147, 25);
            txtMaNV.TabIndex = 7;
            txtMaNV.KeyPress += txtMaNV_KeyPress;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(297, 142);
            label4.Name = "label4";
            label4.Size = new Size(69, 17);
            label4.TabIndex = 6;
            label4.Text = "Ngày sinh";
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Location = new Point(297, 90);
            label5.Name = "label5";
            label5.Size = new Size(0, 17);
            label5.TabIndex = 5;
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Location = new Point(297, 40);
            label6.Name = "label6";
            label6.Size = new Size(48, 17);
            label6.TabIndex = 4;
            label6.Text = "Địa chỉ";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(31, 142);
            label3.Name = "label3";
            label3.Size = new Size(88, 17);
            label3.TabIndex = 3;
            label3.Text = "Số điện thoại";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(31, 87);
            label2.Name = "label2";
            label2.Size = new Size(93, 17);
            label2.TabIndex = 2;
            label2.Text = "Tên nhân viên";
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(31, 40);
            label1.Name = "label1";
            label1.Size = new Size(91, 17);
            label1.TabIndex = 1;
            label1.Text = "Mã nhân viên";
            // 
            // groupBox2
            // 
            groupBox2.BackColor = SystemColors.ActiveCaption;
            groupBox2.Controls.Add(lsvDSNV);
            groupBox2.Font = new Font("Segoe UI Semibold", 9.75F, FontStyle.Bold, GraphicsUnit.Point);
            groupBox2.ForeColor = Color.Maroon;
            groupBox2.Location = new Point(51, 210);
            groupBox2.Name = "groupBox2";
            groupBox2.Size = new Size(732, 245);
            groupBox2.TabIndex = 1;
            groupBox2.TabStop = false;
            groupBox2.Text = "Danh Sách nhân Viên";
            // 
            // lsvDSNV
            // 
            lsvDSNV.Dock = DockStyle.Fill;
            lsvDSNV.Location = new Point(3, 21);
            lsvDSNV.Name = "lsvDSNV";
            lsvDSNV.Size = new Size(726, 221);
            lsvDSNV.TabIndex = 0;
            lsvDSNV.UseCompatibleStateImageBehavior = false;
            lsvDSNV.SelectedIndexChanged += lsvDSNV_SelectedIndexChanged;
            // 
            // btnTaoMoi
            // 
            btnTaoMoi.BackColor = SystemColors.GradientInactiveCaption;
            btnTaoMoi.Font = new Font("Segoe UI Semibold", 9.75F, FontStyle.Bold, GraphicsUnit.Point);
            btnTaoMoi.ForeColor = Color.Maroon;
            btnTaoMoi.Location = new Point(684, 168);
            btnTaoMoi.Name = "btnTaoMoi";
            btnTaoMoi.Size = new Size(99, 36);
            btnTaoMoi.TabIndex = 18;
            btnTaoMoi.Text = "Tạo mới";
            btnTaoMoi.UseVisualStyleBackColor = false;
            btnTaoMoi.Click += btnTaoMoi_Click_1;
            // 
            // btnCapNhat
            // 
            btnCapNhat.BackColor = SystemColors.GradientInactiveCaption;
            btnCapNhat.Font = new Font("Segoe UI Semibold", 9.75F, FontStyle.Bold, GraphicsUnit.Point);
            btnCapNhat.ForeColor = Color.Maroon;
            btnCapNhat.Location = new Point(684, 74);
            btnCapNhat.Name = "btnCapNhat";
            btnCapNhat.Size = new Size(99, 36);
            btnCapNhat.TabIndex = 17;
            btnCapNhat.Text = "Cập nhật";
            btnCapNhat.UseVisualStyleBackColor = false;
            btnCapNhat.Click += btnCapNhat_Click_1;
            // 
            // btnXoa
            // 
            btnXoa.BackColor = SystemColors.GradientInactiveCaption;
            btnXoa.Font = new Font("Segoe UI Semibold", 9.75F, FontStyle.Bold, GraphicsUnit.Point);
            btnXoa.ForeColor = Color.Maroon;
            btnXoa.Location = new Point(684, 121);
            btnXoa.Name = "btnXoa";
            btnXoa.Size = new Size(99, 36);
            btnXoa.TabIndex = 16;
            btnXoa.Text = "Xoá";
            btnXoa.UseVisualStyleBackColor = false;
            btnXoa.Click += btnXoa_Click_1;
            // 
            // btnThem
            // 
            btnThem.BackColor = SystemColors.GradientInactiveCaption;
            btnThem.Font = new Font("Segoe UI Semibold", 9.75F, FontStyle.Bold, GraphicsUnit.Point);
            btnThem.ForeColor = Color.Maroon;
            btnThem.Location = new Point(684, 25);
            btnThem.Name = "btnThem";
            btnThem.Size = new Size(99, 38);
            btnThem.TabIndex = 15;
            btnThem.Text = "Thêm";
            btnThem.UseVisualStyleBackColor = false;
            btnThem.Click += btnThem_Click_1;
            // 
            // groupBox4
            // 
            groupBox4.BackColor = SystemColors.ActiveCaption;
            groupBox4.Controls.Add(txtTenNVTimKiem);
            groupBox4.Controls.Add(btnTimKiem);
            groupBox4.Controls.Add(label8);
            groupBox4.Font = new Font("Segoe UI Semibold", 9.75F, FontStyle.Bold, GraphicsUnit.Point);
            groupBox4.ForeColor = Color.Maroon;
            groupBox4.Location = new Point(54, 461);
            groupBox4.Name = "groupBox4";
            groupBox4.Size = new Size(726, 72);
            groupBox4.TabIndex = 19;
            groupBox4.TabStop = false;
            groupBox4.Text = "Tìm kiếm nhân viên";
            // 
            // txtTenNVTimKiem
            // 
            txtTenNVTimKiem.Location = new Point(172, 27);
            txtTenNVTimKiem.Name = "txtTenNVTimKiem";
            txtTenNVTimKiem.Size = new Size(348, 25);
            txtTenNVTimKiem.TabIndex = 18;
            txtTenNVTimKiem.KeyPress += txtTenNVTimKiem_KeyPress;
            // 
            // btnTimKiem
            // 
            btnTimKiem.BackColor = SystemColors.GradientInactiveCaption;
            btnTimKiem.Font = new Font("Segoe UI Semibold", 9.75F, FontStyle.Bold, GraphicsUnit.Point);
            btnTimKiem.ForeColor = Color.Maroon;
            btnTimKiem.Location = new Point(542, 20);
            btnTimKiem.Name = "btnTimKiem";
            btnTimKiem.Size = new Size(99, 36);
            btnTimKiem.TabIndex = 17;
            btnTimKiem.Text = "Tìm kiếm";
            btnTimKiem.UseVisualStyleBackColor = false;
            btnTimKiem.Click += btnTimKiem_Click;
            // 
            // label8
            // 
            label8.AutoSize = true;
            label8.Font = new Font("Segoe UI Semibold", 9.75F, FontStyle.Bold, GraphicsUnit.Point);
            label8.ForeColor = Color.Maroon;
            label8.Location = new Point(45, 30);
            label8.Name = "label8";
            label8.Size = new Size(91, 17);
            label8.TabIndex = 16;
            label8.Text = "Mã nhân viên";
            // 
            // FNhanVien
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(828, 559);
            Controls.Add(groupBox4);
            Controls.Add(btnTaoMoi);
            Controls.Add(btnCapNhat);
            Controls.Add(btnXoa);
            Controls.Add(groupBox2);
            Controls.Add(btnThem);
            Controls.Add(groupBox1);
            Name = "FNhanVien";
            Text = "FNhanVien";
            Load += FNhanVien_Load;
            groupBox1.ResumeLayout(false);
            groupBox1.PerformLayout();
            groupBox2.ResumeLayout(false);
            groupBox4.ResumeLayout(false);
            groupBox4.PerformLayout();
            ResumeLayout(false);
        }

        #endregion

        private GroupBox groupBox1;
        private GroupBox groupBox2;
        private Label label4;
        private Label label5;
        private Label label6;
        private Label label3;
        private Label label2;
        private Label label1;
        private ListView lsvDSNV;
        private TextBox txtDiaChi;
        private TextBox txtSoDT;
        private TextBox txtTenNV;
        private TextBox txtMaNV;
        private DateTimePicker dtpNgaySinh;
        private TextBox txtGioiTinh;
        private Label label7;
        private Button btnTaoMoi;
        private Button btnCapNhat;
        private Button btnXoa;
        private Button btnThem;
        private GroupBox groupBox4;
        private TextBox txtTenNVTimKiem;
        private Button btnTimKiem;
        private Label label8;
    }
}