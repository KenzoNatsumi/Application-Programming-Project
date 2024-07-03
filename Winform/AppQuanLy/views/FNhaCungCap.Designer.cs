namespace quản_lí_cửa_hàng_máy_tính.views
{
    partial class FNhaCungCap
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
            btnCapNhat = new Button();
            btnXoa = new Button();
            btnThem = new Button();
            groupBox2 = new GroupBox();
            lsvDSNCC = new ListView();
            groupBox1 = new GroupBox();
            txtTenNCC = new TextBox();
            label2 = new Label();
            txtMaNCC = new TextBox();
            label3 = new Label();
            label1 = new Label();
            btnTaoMoi = new Button();
            groupBox4 = new GroupBox();
            txtTenNCCTimKiem = new TextBox();
            btnTimKiem = new Button();
            label7 = new Label();
            groupBox2.SuspendLayout();
            groupBox1.SuspendLayout();
            groupBox4.SuspendLayout();
            SuspendLayout();
            // 
            // btnCapNhat
            // 
            btnCapNhat.BackColor = SystemColors.GradientInactiveCaption;
            btnCapNhat.Font = new Font("Segoe UI Semibold", 9.75F, FontStyle.Bold, GraphicsUnit.Point);
            btnCapNhat.ForeColor = Color.Maroon;
            btnCapNhat.Location = new Point(689, 71);
            btnCapNhat.Name = "btnCapNhat";
            btnCapNhat.Size = new Size(99, 36);
            btnCapNhat.TabIndex = 9;
            btnCapNhat.Text = "Cập nhật";
            btnCapNhat.UseVisualStyleBackColor = false;
            btnCapNhat.Click += btnCapNhat_Click;
            // 
            // btnXoa
            // 
            btnXoa.BackColor = SystemColors.GradientInactiveCaption;
            btnXoa.Font = new Font("Segoe UI Semibold", 9.75F, FontStyle.Bold, GraphicsUnit.Point);
            btnXoa.ForeColor = Color.Maroon;
            btnXoa.Location = new Point(689, 118);
            btnXoa.Name = "btnXoa";
            btnXoa.Size = new Size(99, 36);
            btnXoa.TabIndex = 8;
            btnXoa.Text = "Xoá";
            btnXoa.UseVisualStyleBackColor = false;
            btnXoa.Click += btnXoa_Click;
            // 
            // btnThem
            // 
            btnThem.BackColor = SystemColors.GradientInactiveCaption;
            btnThem.Font = new Font("Segoe UI Semibold", 9.75F, FontStyle.Bold, GraphicsUnit.Point);
            btnThem.ForeColor = Color.Maroon;
            btnThem.Location = new Point(689, 22);
            btnThem.Name = "btnThem";
            btnThem.Size = new Size(99, 38);
            btnThem.TabIndex = 7;
            btnThem.Text = "Thêm";
            btnThem.UseVisualStyleBackColor = false;
            btnThem.Click += btnThem_Click;
            // 
            // groupBox2
            // 
            groupBox2.BackColor = SystemColors.ActiveCaption;
            groupBox2.Controls.Add(lsvDSNCC);
            groupBox2.Font = new Font("Segoe UI Semibold", 9.75F, FontStyle.Bold, GraphicsUnit.Point);
            groupBox2.ForeColor = Color.Maroon;
            groupBox2.Location = new Point(39, 209);
            groupBox2.Name = "groupBox2";
            groupBox2.Size = new Size(749, 247);
            groupBox2.TabIndex = 5;
            groupBox2.TabStop = false;
            groupBox2.Text = "Danh sách nhà cung cấp";
            // 
            // lsvDSNCC
            // 
            lsvDSNCC.Dock = DockStyle.Fill;
            lsvDSNCC.Location = new Point(3, 21);
            lsvDSNCC.Name = "lsvDSNCC";
            lsvDSNCC.Size = new Size(743, 223);
            lsvDSNCC.TabIndex = 0;
            lsvDSNCC.UseCompatibleStateImageBehavior = false;
            lsvDSNCC.SelectedIndexChanged += lsvDSNCC_SelectedIndexChanged;
            // 
            // groupBox1
            // 
            groupBox1.BackColor = SystemColors.ActiveCaption;
            groupBox1.Controls.Add(txtTenNCC);
            groupBox1.Controls.Add(label2);
            groupBox1.Controls.Add(txtMaNCC);
            groupBox1.Controls.Add(label3);
            groupBox1.Controls.Add(label1);
            groupBox1.Font = new Font("Segoe UI Semibold", 9.75F, FontStyle.Bold, GraphicsUnit.Point);
            groupBox1.ForeColor = Color.Maroon;
            groupBox1.Location = new Point(39, 22);
            groupBox1.Name = "groupBox1";
            groupBox1.Size = new Size(644, 181);
            groupBox1.TabIndex = 6;
            groupBox1.TabStop = false;
            groupBox1.Text = "Thông tin nhà cung cấp";
            // 
            // txtTenNCC
            // 
            txtTenNCC.Location = new Point(260, 104);
            txtTenNCC.Name = "txtTenNCC";
            txtTenNCC.Size = new Size(198, 25);
            txtTenNCC.TabIndex = 7;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(141, 107);
            label2.Name = "label2";
            label2.Size = new Size(119, 17);
            label2.TabIndex = 6;
            label2.Text = "Tên Nhà Cung cấp";
            // 
            // txtMaNCC
            // 
            txtMaNCC.Location = new Point(260, 48);
            txtMaNCC.Name = "txtMaNCC";
            txtMaNCC.Size = new Size(198, 25);
            txtMaNCC.TabIndex = 4;
            txtMaNCC.KeyPress += txtMaNCC_KeyPress;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(347, 41);
            label3.Name = "label3";
            label3.Size = new Size(0, 17);
            label3.TabIndex = 2;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(141, 51);
            label1.Name = "label1";
            label1.Size = new Size(113, 17);
            label1.TabIndex = 0;
            label1.Text = "Mã nhà cung cấp";
            // 
            // btnTaoMoi
            // 
            btnTaoMoi.BackColor = SystemColors.GradientInactiveCaption;
            btnTaoMoi.Font = new Font("Segoe UI Semibold", 9.75F, FontStyle.Bold, GraphicsUnit.Point);
            btnTaoMoi.ForeColor = Color.Maroon;
            btnTaoMoi.Location = new Point(689, 165);
            btnTaoMoi.Name = "btnTaoMoi";
            btnTaoMoi.Size = new Size(99, 36);
            btnTaoMoi.TabIndex = 10;
            btnTaoMoi.Text = "Tạo mới";
            btnTaoMoi.UseVisualStyleBackColor = false;
            btnTaoMoi.Click += btnTaoMoi_Click;
            // 
            // groupBox4
            // 
            groupBox4.BackColor = SystemColors.ActiveCaption;
            groupBox4.Controls.Add(txtTenNCCTimKiem);
            groupBox4.Controls.Add(btnTimKiem);
            groupBox4.Controls.Add(label7);
            groupBox4.Font = new Font("Segoe UI Semibold", 9.75F, FontStyle.Bold, GraphicsUnit.Point);
            groupBox4.ForeColor = Color.Maroon;
            groupBox4.Location = new Point(42, 462);
            groupBox4.Name = "groupBox4";
            groupBox4.Size = new Size(746, 72);
            groupBox4.TabIndex = 11;
            groupBox4.TabStop = false;
            groupBox4.Text = "Tìm kiếm nhà cung cấp";
            // 
            // txtTenNCCTimKiem
            // 
            txtTenNCCTimKiem.Location = new Point(172, 27);
            txtTenNCCTimKiem.Name = "txtTenNCCTimKiem";
            txtTenNCCTimKiem.Size = new Size(348, 25);
            txtTenNCCTimKiem.TabIndex = 18;
            txtTenNCCTimKiem.KeyPress += txtTenNCCTimKiem_KeyPress;
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
            // label7
            // 
            label7.AutoSize = true;
            label7.Font = new Font("Segoe UI Semibold", 9.75F, FontStyle.Bold, GraphicsUnit.Point);
            label7.ForeColor = Color.Maroon;
            label7.Location = new Point(45, 30);
            label7.Name = "label7";
            label7.Size = new Size(119, 17);
            label7.TabIndex = 16;
            label7.Text = "Mã Nhà Cung Cấp";
            // 
            // FNhaCungCap
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
            Name = "FNhaCungCap";
            Text = "FNhaCungCap";
            Load += FNhaCungCap_Load;
            groupBox2.ResumeLayout(false);
            groupBox1.ResumeLayout(false);
            groupBox1.PerformLayout();
            groupBox4.ResumeLayout(false);
            groupBox4.PerformLayout();
            ResumeLayout(false);
        }

        #endregion

        private Button btnCapNhat;
        private Button btnXoa;
        private Button btnThem;
        private GroupBox groupBox2;
        private ListView lsvDSNCC;
        private GroupBox groupBox1;
        private TextBox txtMaNCC;
        private Label label3;
        private Label label1;
        private TextBox txtTenNCC;
        private Label label2;
        private Button btnTaoMoi;
        private GroupBox groupBox4;
        private TextBox txtTenNCCTimKiem;
        private Button btnTimKiem;
        private Label label7;
    }
}