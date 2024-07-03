namespace quản_lí_cửa_hàng_máy_tính.views
{
    partial class FKhachHang
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
            txtDiaChi = new TextBox();
            txtSoDT = new TextBox();
            txtTenKH = new TextBox();
            txtMaKH = new TextBox();
            label4 = new Label();
            label3 = new Label();
            label2 = new Label();
            label1 = new Label();
            groupBox2 = new GroupBox();
            lsvDSKH = new ListView();
            btnTaoMoi = new Button();
            btnCapNhat = new Button();
            btnXoa = new Button();
            btnThem = new Button();
            groupBox4 = new GroupBox();
            txtTenKHTimKiem = new TextBox();
            btnTimKiem = new Button();
            label7 = new Label();
            groupBox1.SuspendLayout();
            groupBox2.SuspendLayout();
            groupBox4.SuspendLayout();
            SuspendLayout();
            // 
            // groupBox1
            // 
            groupBox1.BackColor = SystemColors.ActiveCaption;
            groupBox1.Controls.Add(txtDiaChi);
            groupBox1.Controls.Add(txtSoDT);
            groupBox1.Controls.Add(txtTenKH);
            groupBox1.Controls.Add(txtMaKH);
            groupBox1.Controls.Add(label4);
            groupBox1.Controls.Add(label3);
            groupBox1.Controls.Add(label2);
            groupBox1.Controls.Add(label1);
            groupBox1.Font = new Font("Segoe UI Semibold", 9.75F, FontStyle.Bold, GraphicsUnit.Point);
            groupBox1.ForeColor = Color.Maroon;
            groupBox1.Location = new Point(36, 21);
            groupBox1.Name = "groupBox1";
            groupBox1.Size = new Size(651, 179);
            groupBox1.TabIndex = 1;
            groupBox1.TabStop = false;
            groupBox1.Text = "Thông tin khách hàng";
            // 
            // txtDiaChi
            // 
            txtDiaChi.Location = new Point(383, 104);
            txtDiaChi.Name = "txtDiaChi";
            txtDiaChi.Size = new Size(225, 25);
            txtDiaChi.TabIndex = 7;
            // 
            // txtSoDT
            // 
            txtSoDT.Location = new Point(498, 56);
            txtSoDT.Name = "txtSoDT";
            txtSoDT.Size = new Size(110, 25);
            txtSoDT.TabIndex = 6;
            txtSoDT.KeyPress += txtSoDT_KeyPress;
            // 
            // txtTenKH
            // 
            txtTenKH.Location = new Point(152, 104);
            txtTenKH.Name = "txtTenKH";
            txtTenKH.Size = new Size(166, 25);
            txtTenKH.TabIndex = 5;
            // 
            // txtMaKH
            // 
            txtMaKH.Location = new Point(154, 56);
            txtMaKH.Name = "txtMaKH";
            txtMaKH.Size = new Size(164, 25);
            txtMaKH.TabIndex = 4;
            txtMaKH.KeyPress += txtMaKH_KeyPress;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(329, 107);
            label4.Name = "label4";
            label4.Size = new Size(48, 17);
            label4.TabIndex = 3;
            label4.Text = "Địa chỉ";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(329, 59);
            label3.Name = "label3";
            label3.Size = new Size(163, 17);
            label3.TabIndex = 2;
            label3.Text = "Số điện thoại khách hàng";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(50, 107);
            label2.Name = "label2";
            label2.Size = new Size(104, 17);
            label2.TabIndex = 1;
            label2.Text = "Tên khách hàng";
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(50, 59);
            label1.Name = "label1";
            label1.Size = new Size(102, 17);
            label1.TabIndex = 0;
            label1.Text = "Mã khách hàng";
            // 
            // groupBox2
            // 
            groupBox2.BackColor = SystemColors.ActiveCaption;
            groupBox2.Controls.Add(lsvDSKH);
            groupBox2.Font = new Font("Segoe UI Semibold", 9.75F, FontStyle.Bold, GraphicsUnit.Point);
            groupBox2.ForeColor = Color.Maroon;
            groupBox2.Location = new Point(36, 206);
            groupBox2.Name = "groupBox2";
            groupBox2.Size = new Size(756, 255);
            groupBox2.TabIndex = 1;
            groupBox2.TabStop = false;
            groupBox2.Text = "Danh sách khách hàng";
            // 
            // lsvDSKH
            // 
            lsvDSKH.Dock = DockStyle.Fill;
            lsvDSKH.Location = new Point(3, 21);
            lsvDSKH.Name = "lsvDSKH";
            lsvDSKH.Size = new Size(750, 231);
            lsvDSKH.TabIndex = 0;
            lsvDSKH.UseCompatibleStateImageBehavior = false;
            lsvDSKH.SelectedIndexChanged += lsvDSKH_SelectedIndexChanged;
            // 
            // btnTaoMoi
            // 
            btnTaoMoi.BackColor = SystemColors.GradientInactiveCaption;
            btnTaoMoi.Font = new Font("Segoe UI Semibold", 9.75F, FontStyle.Bold, GraphicsUnit.Point);
            btnTaoMoi.ForeColor = Color.Maroon;
            btnTaoMoi.Location = new Point(693, 164);
            btnTaoMoi.Name = "btnTaoMoi";
            btnTaoMoi.Size = new Size(99, 36);
            btnTaoMoi.TabIndex = 14;
            btnTaoMoi.Text = "Tạo mới";
            btnTaoMoi.UseVisualStyleBackColor = false;
            btnTaoMoi.Click += btnTaoMoi_Click;
            // 
            // btnCapNhat
            // 
            btnCapNhat.BackColor = SystemColors.GradientInactiveCaption;
            btnCapNhat.Font = new Font("Segoe UI Semibold", 9.75F, FontStyle.Bold, GraphicsUnit.Point);
            btnCapNhat.ForeColor = Color.Maroon;
            btnCapNhat.Location = new Point(693, 70);
            btnCapNhat.Name = "btnCapNhat";
            btnCapNhat.Size = new Size(99, 36);
            btnCapNhat.TabIndex = 13;
            btnCapNhat.Text = "Cập nhật";
            btnCapNhat.UseVisualStyleBackColor = false;
            btnCapNhat.Click += btnCapNhat_Click_1;
            // 
            // btnXoa
            // 
            btnXoa.BackColor = SystemColors.GradientInactiveCaption;
            btnXoa.Font = new Font("Segoe UI Semibold", 9.75F, FontStyle.Bold, GraphicsUnit.Point);
            btnXoa.ForeColor = Color.Maroon;
            btnXoa.Location = new Point(693, 117);
            btnXoa.Name = "btnXoa";
            btnXoa.Size = new Size(99, 36);
            btnXoa.TabIndex = 12;
            btnXoa.Text = "Xoá";
            btnXoa.UseVisualStyleBackColor = false;
            btnXoa.Click += btnXoa_Click_1;
            // 
            // btnThem
            // 
            btnThem.BackColor = SystemColors.GradientInactiveCaption;
            btnThem.Font = new Font("Segoe UI Semibold", 9.75F, FontStyle.Bold, GraphicsUnit.Point);
            btnThem.ForeColor = Color.Maroon;
            btnThem.Location = new Point(693, 21);
            btnThem.Name = "btnThem";
            btnThem.Size = new Size(99, 38);
            btnThem.TabIndex = 11;
            btnThem.Text = "Thêm";
            btnThem.UseVisualStyleBackColor = false;
            btnThem.Click += btnThem_Click_1;
            // 
            // groupBox4
            // 
            groupBox4.BackColor = SystemColors.ActiveCaption;
            groupBox4.Controls.Add(txtTenKHTimKiem);
            groupBox4.Controls.Add(btnTimKiem);
            groupBox4.Controls.Add(label7);
            groupBox4.Font = new Font("Segoe UI Semibold", 9.75F, FontStyle.Bold, GraphicsUnit.Point);
            groupBox4.ForeColor = Color.Maroon;
            groupBox4.Location = new Point(39, 467);
            groupBox4.Name = "groupBox4";
            groupBox4.Size = new Size(750, 72);
            groupBox4.TabIndex = 15;
            groupBox4.TabStop = false;
            groupBox4.Text = "Tìm kiếm khách hàng";
            // 
            // txtTenKHTimKiem
            // 
            txtTenKHTimKiem.Location = new Point(192, 27);
            txtTenKHTimKiem.Name = "txtTenKHTimKiem";
            txtTenKHTimKiem.Size = new Size(348, 25);
            txtTenKHTimKiem.TabIndex = 18;
            txtTenKHTimKiem.KeyPress += txtTenKHTimKiem_KeyPress;
            // 
            // btnTimKiem
            // 
            btnTimKiem.BackColor = SystemColors.GradientInactiveCaption;
            btnTimKiem.Font = new Font("Segoe UI Semibold", 9.75F, FontStyle.Bold, GraphicsUnit.Point);
            btnTimKiem.ForeColor = Color.Maroon;
            btnTimKiem.Location = new Point(562, 20);
            btnTimKiem.Name = "btnTimKiem";
            btnTimKiem.Size = new Size(99, 36);
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
            label7.Location = new Point(65, 30);
            label7.Name = "label7";
            label7.Size = new Size(103, 17);
            label7.TabIndex = 16;
            label7.Text = "Mã Khách hàng";
            // 
            // FKhachHang
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(828, 559);
            Controls.Add(groupBox4);
            Controls.Add(btnTaoMoi);
            Controls.Add(btnCapNhat);
            Controls.Add(btnXoa);
            Controls.Add(btnThem);
            Controls.Add(groupBox2);
            Controls.Add(groupBox1);
            Name = "FKhachHang";
            Text = "FKhachHang";
            Load += FKhachHang_Load;
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
        private Label label3;
        private Label label2;
        private Label label1;
        private TextBox txtTenKH;
        private TextBox txtMaKH;
        private TextBox txtSoDT;
        private TextBox txtDiaChi;
        private ListView lsvDSKH;
        private Button btnTaoMoi;
        private Button btnCapNhat;
        private Button btnXoa;
        private Button btnThem;
        private GroupBox groupBox4;
        private TextBox txtTenKHTimKiem;
        private Button btnTimKiem;
        private Label label7;
    }
}