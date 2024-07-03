namespace quản_lí_cửa_hàng_máy_tính.views
{
    partial class FHoaDon
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
            groupBox5 = new GroupBox();
            txtTongTien = new TextBox();
            groupBox4 = new GroupBox();
            lstDSSP = new ListBox();
            label16 = new Label();
            txtGG = new TextBox();
            label14 = new Label();
            txtSL = new TextBox();
            label11 = new Label();
            txtTenSP = new TextBox();
            label13 = new Label();
            groupBox3 = new GroupBox();
            lsvCTHD = new ListView();
            btnThemSP = new Button();
            btnXoaSP = new Button();
            groupBox1 = new GroupBox();
            cbMaKH = new ComboBox();
            cbMaNV = new ComboBox();
            label8 = new Label();
            txtMaHD = new TextBox();
            label7 = new Label();
            dtpNgayBan = new DateTimePicker();
            txtDCKH = new TextBox();
            txtSoDTKH = new TextBox();
            label4 = new Label();
            label5 = new Label();
            label6 = new Label();
            label3 = new Label();
            label1 = new Label();
            label2 = new Label();
            btnTimKiem = new Button();
            txtMaHoaDonTimKiem = new TextBox();
            btnLuuHD = new Button();
            btnTaoMoiHD = new Button();
            btnHuyHD = new Button();
            groupBox6 = new GroupBox();
            lsvDSHD = new ListView();
            groupBox2.SuspendLayout();
            groupBox5.SuspendLayout();
            groupBox4.SuspendLayout();
            groupBox3.SuspendLayout();
            groupBox1.SuspendLayout();
            groupBox6.SuspendLayout();
            SuspendLayout();
            // 
            // groupBox2
            // 
            groupBox2.BackColor = SystemColors.ActiveCaption;
            groupBox2.Controls.Add(groupBox5);
            groupBox2.Controls.Add(groupBox4);
            groupBox2.Controls.Add(label16);
            groupBox2.Controls.Add(txtGG);
            groupBox2.Controls.Add(label14);
            groupBox2.Controls.Add(txtSL);
            groupBox2.Controls.Add(label11);
            groupBox2.Controls.Add(txtTenSP);
            groupBox2.Controls.Add(label13);
            groupBox2.Controls.Add(groupBox3);
            groupBox2.Controls.Add(btnThemSP);
            groupBox2.Controls.Add(btnXoaSP);
            groupBox2.Font = new Font("Segoe UI Semibold", 9.75F, FontStyle.Bold, GraphicsUnit.Point);
            groupBox2.ForeColor = Color.Maroon;
            groupBox2.Location = new Point(27, 127);
            groupBox2.Name = "groupBox2";
            groupBox2.Size = new Size(775, 258);
            groupBox2.TabIndex = 9;
            groupBox2.TabStop = false;
            groupBox2.Text = "thông tin sản phẩm";
            groupBox2.Enter += groupBox2_Enter;
            // 
            // groupBox5
            // 
            groupBox5.Controls.Add(txtTongTien);
            groupBox5.ForeColor = Color.Maroon;
            groupBox5.Location = new Point(615, 133);
            groupBox5.Name = "groupBox5";
            groupBox5.Size = new Size(138, 108);
            groupBox5.TabIndex = 30;
            groupBox5.TabStop = false;
            groupBox5.Text = "Tổng Tiền";
            // 
            // txtTongTien
            // 
            txtTongTien.Location = new Point(28, 54);
            txtTongTien.Name = "txtTongTien";
            txtTongTien.Size = new Size(85, 25);
            txtTongTien.TabIndex = 31;
            txtTongTien.Text = "0";
            // 
            // groupBox4
            // 
            groupBox4.Controls.Add(lstDSSP);
            groupBox4.ForeColor = Color.Maroon;
            groupBox4.Location = new Point(16, 52);
            groupBox4.Name = "groupBox4";
            groupBox4.Size = new Size(539, 77);
            groupBox4.TabIndex = 29;
            groupBox4.TabStop = false;
            groupBox4.Text = "Danh sách sản phẩm";
            // 
            // lstDSSP
            // 
            lstDSSP.Dock = DockStyle.Fill;
            lstDSSP.FormattingEnabled = true;
            lstDSSP.ItemHeight = 17;
            lstDSSP.Location = new Point(3, 21);
            lstDSSP.Name = "lstDSSP";
            lstDSSP.Size = new Size(533, 53);
            lstDSSP.TabIndex = 0;
            // 
            // label16
            // 
            label16.AutoSize = true;
            label16.Location = new Point(555, 148);
            label16.Name = "label16";
            label16.Size = new Size(0, 17);
            label16.TabIndex = 26;
            // 
            // txtGG
            // 
            txtGG.Location = new Point(662, 17);
            txtGG.Name = "txtGG";
            txtGG.Size = new Size(85, 25);
            txtGG.TabIndex = 23;
            txtGG.Text = "1";
            txtGG.KeyPress += txtGG_KeyPress;
            // 
            // label14
            // 
            label14.AutoSize = true;
            label14.Location = new Point(597, 21);
            label14.Name = "label14";
            label14.Size = new Size(61, 17);
            label14.TabIndex = 22;
            label14.Text = "Giảm giá";
            // 
            // txtSL
            // 
            txtSL.Location = new Point(478, 18);
            txtSL.Name = "txtSL";
            txtSL.Size = new Size(96, 25);
            txtSL.TabIndex = 21;
            txtSL.Text = "1";
            txtSL.KeyPress += txtSL_KeyPress;
            // 
            // label11
            // 
            label11.AutoSize = true;
            label11.Location = new Point(403, 22);
            label11.Name = "label11";
            label11.Size = new Size(62, 17);
            label11.TabIndex = 20;
            label11.Text = "Số lượng";
            // 
            // txtTenSP
            // 
            txtTenSP.Location = new Point(146, 19);
            txtTenSP.Name = "txtTenSP";
            txtTenSP.Size = new Size(241, 25);
            txtTenSP.TabIndex = 17;
            txtTenSP.TextChanged += txtTenSP_TextChanged;
            // 
            // label13
            // 
            label13.AutoSize = true;
            label13.Location = new Point(14, 21);
            label13.Name = "label13";
            label13.Size = new Size(117, 17);
            label13.TabIndex = 16;
            label13.Text = "Mã/Tên sản phẩm";
            // 
            // groupBox3
            // 
            groupBox3.Controls.Add(lsvCTHD);
            groupBox3.ForeColor = Color.Maroon;
            groupBox3.Location = new Point(16, 133);
            groupBox3.Name = "groupBox3";
            groupBox3.Size = new Size(593, 111);
            groupBox3.TabIndex = 0;
            groupBox3.TabStop = false;
            groupBox3.Text = "Chi tiết hoá đơn";
            // 
            // lsvCTHD
            // 
            lsvCTHD.Dock = DockStyle.Fill;
            lsvCTHD.Location = new Point(3, 21);
            lsvCTHD.Name = "lsvCTHD";
            lsvCTHD.Size = new Size(587, 87);
            lsvCTHD.TabIndex = 1;
            lsvCTHD.UseCompatibleStateImageBehavior = false;
            // 
            // btnThemSP
            // 
            btnThemSP.BackColor = SystemColors.GradientInactiveCaption;
            btnThemSP.Font = new Font("Segoe UI Semibold", 9.75F, FontStyle.Bold, GraphicsUnit.Point);
            btnThemSP.ForeColor = Color.Maroon;
            btnThemSP.Location = new Point(565, 79);
            btnThemSP.Name = "btnThemSP";
            btnThemSP.Size = new Size(80, 33);
            btnThemSP.TabIndex = 10;
            btnThemSP.Text = "Thêm";
            btnThemSP.UseVisualStyleBackColor = false;
            btnThemSP.Click += btnThemSP_Click;
            // 
            // btnXoaSP
            // 
            btnXoaSP.BackColor = SystemColors.GradientInactiveCaption;
            btnXoaSP.Font = new Font("Segoe UI Semibold", 9.75F, FontStyle.Bold, GraphicsUnit.Point);
            btnXoaSP.ForeColor = Color.Maroon;
            btnXoaSP.Location = new Point(671, 79);
            btnXoaSP.Name = "btnXoaSP";
            btnXoaSP.Size = new Size(80, 33);
            btnXoaSP.TabIndex = 11;
            btnXoaSP.Text = "Xoá";
            btnXoaSP.UseVisualStyleBackColor = false;
            btnXoaSP.Click += btnXoaSP_Click;
            // 
            // groupBox1
            // 
            groupBox1.BackColor = SystemColors.ActiveCaption;
            groupBox1.Controls.Add(cbMaKH);
            groupBox1.Controls.Add(cbMaNV);
            groupBox1.Controls.Add(label8);
            groupBox1.Controls.Add(txtMaHD);
            groupBox1.Controls.Add(label7);
            groupBox1.Controls.Add(dtpNgayBan);
            groupBox1.Controls.Add(txtDCKH);
            groupBox1.Controls.Add(txtSoDTKH);
            groupBox1.Controls.Add(label4);
            groupBox1.Controls.Add(label5);
            groupBox1.Controls.Add(label6);
            groupBox1.Controls.Add(label3);
            groupBox1.Controls.Add(label1);
            groupBox1.Font = new Font("Segoe UI Semibold", 9.75F, FontStyle.Bold, GraphicsUnit.Point);
            groupBox1.ForeColor = Color.Maroon;
            groupBox1.Location = new Point(27, 8);
            groupBox1.Name = "groupBox1";
            groupBox1.Size = new Size(667, 113);
            groupBox1.TabIndex = 8;
            groupBox1.TabStop = false;
            groupBox1.Text = "Thông tin chung";
            groupBox1.Enter += groupBox1_Enter;
            // 
            // cbMaKH
            // 
            cbMaKH.FormattingEnabled = true;
            cbMaKH.Location = new Point(422, 22);
            cbMaKH.Name = "cbMaKH";
            cbMaKH.Size = new Size(225, 25);
            cbMaKH.TabIndex = 20;
            cbMaKH.SelectedIndexChanged += cbMaKH_SelectedIndexChanged;
            // 
            // cbMaNV
            // 
            cbMaNV.FormattingEnabled = true;
            cbMaNV.Location = new Point(136, 77);
            cbMaNV.Name = "cbMaNV";
            cbMaNV.Size = new Size(154, 25);
            cbMaNV.TabIndex = 19;
            // 
            // label8
            // 
            label8.AutoSize = true;
            label8.Location = new Point(314, 22);
            label8.Name = "label8";
            label8.Size = new Size(102, 17);
            label8.TabIndex = 15;
            label8.Text = "Mã khách hàng";
            // 
            // txtMaHD
            // 
            txtMaHD.Location = new Point(135, 21);
            txtMaHD.Name = "txtMaHD";
            txtMaHD.Size = new Size(155, 25);
            txtMaHD.TabIndex = 14;
            txtMaHD.KeyPress += txtMaHD_KeyPress;
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.Location = new Point(40, 25);
            label7.Name = "label7";
            label7.Size = new Size(82, 17);
            label7.TabIndex = 13;
            label7.Text = "Mã hóa đơn";
            // 
            // dtpNgayBan
            // 
            dtpNgayBan.Location = new Point(136, 49);
            dtpNgayBan.Name = "dtpNgayBan";
            dtpNgayBan.Size = new Size(154, 25);
            dtpNgayBan.TabIndex = 12;
            // 
            // txtDCKH
            // 
            txtDCKH.Location = new Point(422, 49);
            txtDCKH.Name = "txtDCKH";
            txtDCKH.Size = new Size(225, 25);
            txtDCKH.TabIndex = 10;
            // 
            // txtSoDTKH
            // 
            txtSoDTKH.Location = new Point(422, 77);
            txtSoDTKH.Name = "txtSoDTKH";
            txtSoDTKH.Size = new Size(225, 25);
            txtSoDTKH.TabIndex = 9;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(40, 52);
            label4.Name = "label4";
            label4.Size = new Size(67, 17);
            label4.TabIndex = 6;
            label4.Text = "Ngày bán";
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Location = new Point(386, 35);
            label5.Name = "label5";
            label5.Size = new Size(0, 17);
            label5.TabIndex = 5;
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Location = new Point(314, 52);
            label6.Name = "label6";
            label6.Size = new Size(48, 17);
            label6.TabIndex = 4;
            label6.Text = "Địa chỉ";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(314, 80);
            label3.Name = "label3";
            label3.Size = new Size(88, 17);
            label3.TabIndex = 3;
            label3.Text = "Số điện thoại";
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(40, 80);
            label1.Name = "label1";
            label1.Size = new Size(91, 17);
            label1.TabIndex = 1;
            label1.Text = "Mã nhân viên";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Segoe UI Semibold", 9.75F, FontStyle.Bold, GraphicsUnit.Point);
            label2.ForeColor = Color.Maroon;
            label2.Location = new Point(106, 532);
            label2.Name = "label2";
            label2.Size = new Size(82, 17);
            label2.TabIndex = 21;
            label2.Text = "Mã hóa đơn";
            // 
            // btnTimKiem
            // 
            btnTimKiem.BackColor = SystemColors.GradientInactiveCaption;
            btnTimKiem.Font = new Font("Segoe UI Semibold", 9.75F, FontStyle.Bold, GraphicsUnit.Point);
            btnTimKiem.ForeColor = Color.Maroon;
            btnTimKiem.Location = new Point(600, 527);
            btnTimKiem.Name = "btnTimKiem";
            btnTimKiem.Size = new Size(97, 26);
            btnTimKiem.TabIndex = 14;
            btnTimKiem.Text = "Tìm kiếm";
            btnTimKiem.UseVisualStyleBackColor = false;
            btnTimKiem.Click += btnTimKiem_Click;
            // 
            // txtMaHoaDonTimKiem
            // 
            txtMaHoaDonTimKiem.Location = new Point(199, 528);
            txtMaHoaDonTimKiem.Name = "txtMaHoaDonTimKiem";
            txtMaHoaDonTimKiem.Size = new Size(385, 23);
            txtMaHoaDonTimKiem.TabIndex = 22;
            txtMaHoaDonTimKiem.TextChanged += txtMaHoaDonTimKiem_TextChanged;
            txtMaHoaDonTimKiem.KeyPress += txtMaHoaDonTimKiem_KeyPress;
            // 
            // btnLuuHD
            // 
            btnLuuHD.BackColor = SystemColors.GradientInactiveCaption;
            btnLuuHD.Font = new Font("Segoe UI Semibold", 9.75F, FontStyle.Bold, GraphicsUnit.Point);
            btnLuuHD.ForeColor = Color.Maroon;
            btnLuuHD.Location = new Point(705, 76);
            btnLuuHD.Name = "btnLuuHD";
            btnLuuHD.Size = new Size(97, 33);
            btnLuuHD.TabIndex = 32;
            btnLuuHD.Text = "lưu";
            btnLuuHD.UseVisualStyleBackColor = false;
            btnLuuHD.Click += btnLuuHD_Click;
            // 
            // btnTaoMoiHD
            // 
            btnTaoMoiHD.BackColor = SystemColors.GradientInactiveCaption;
            btnTaoMoiHD.Font = new Font("Segoe UI Semibold", 9.75F, FontStyle.Bold, GraphicsUnit.Point);
            btnTaoMoiHD.ForeColor = Color.Maroon;
            btnTaoMoiHD.Location = new Point(705, 8);
            btnTaoMoiHD.Name = "btnTaoMoiHD";
            btnTaoMoiHD.Size = new Size(97, 33);
            btnTaoMoiHD.TabIndex = 29;
            btnTaoMoiHD.Text = "Tạo mới";
            btnTaoMoiHD.UseVisualStyleBackColor = false;
            btnTaoMoiHD.Click += btnTaoMoiHD_Click;
            // 
            // btnHuyHD
            // 
            btnHuyHD.BackColor = SystemColors.GradientInactiveCaption;
            btnHuyHD.Font = new Font("Segoe UI Semibold", 9.75F, FontStyle.Bold, GraphicsUnit.Point);
            btnHuyHD.ForeColor = Color.Maroon;
            btnHuyHD.Location = new Point(705, 42);
            btnHuyHD.Name = "btnHuyHD";
            btnHuyHD.Size = new Size(97, 33);
            btnHuyHD.TabIndex = 30;
            btnHuyHD.Text = "Huỷ ";
            btnHuyHD.UseVisualStyleBackColor = false;
            btnHuyHD.Click += btnHuyHD_Click;
            // 
            // groupBox6
            // 
            groupBox6.BackColor = SystemColors.ActiveCaption;
            groupBox6.Controls.Add(lsvDSHD);
            groupBox6.Font = new Font("Segoe UI Semibold", 9.75F, FontStyle.Bold, GraphicsUnit.Point);
            groupBox6.ForeColor = Color.Maroon;
            groupBox6.Location = new Point(27, 391);
            groupBox6.Name = "groupBox6";
            groupBox6.Size = new Size(775, 125);
            groupBox6.TabIndex = 33;
            groupBox6.TabStop = false;
            groupBox6.Text = "Danh sách hoá Đơn";
            // 
            // lsvDSHD
            // 
            lsvDSHD.Dock = DockStyle.Fill;
            lsvDSHD.Location = new Point(3, 21);
            lsvDSHD.Name = "lsvDSHD";
            lsvDSHD.Size = new Size(769, 101);
            lsvDSHD.TabIndex = 0;
            lsvDSHD.UseCompatibleStateImageBehavior = false;
            lsvDSHD.SelectedIndexChanged += lsvDSHD_SelectedIndexChanged;
            // 
            // FHoaDon
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(828, 559);
            Controls.Add(groupBox6);
            Controls.Add(btnLuuHD);
            Controls.Add(txtMaHoaDonTimKiem);
            Controls.Add(btnHuyHD);
            Controls.Add(btnTimKiem);
            Controls.Add(btnTaoMoiHD);
            Controls.Add(label2);
            Controls.Add(groupBox2);
            Controls.Add(groupBox1);
            Name = "FHoaDon";
            Text = "FHoaDon";
            Load += FHoaDon_Load;
            groupBox2.ResumeLayout(false);
            groupBox2.PerformLayout();
            groupBox5.ResumeLayout(false);
            groupBox5.PerformLayout();
            groupBox4.ResumeLayout(false);
            groupBox3.ResumeLayout(false);
            groupBox1.ResumeLayout(false);
            groupBox1.PerformLayout();
            groupBox6.ResumeLayout(false);
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion
        private GroupBox groupBox2;
        private Button btnXoaSP;
        private GroupBox groupBox1;
        private DateTimePicker dtpNgayBan;
        private TextBox txtDCKH;
        private TextBox txtSoDTKH;
        private Label label4;
        private Label label5;
        private Label label6;
        private Label label3;
        private Label label1;
        private Button btnThemSP;
        private TextBox txtMaHD;
        private Label label8;
        private ComboBox cbMaKH;
        private ComboBox cbMaNV;
        private GroupBox groupBox3;
        private ListView lsvCTHD;
        private Button btnLuu;
        private Label label2;
        private Button btnTimKiem;
        private TextBox txtGG;
        private Label label14;
        private TextBox txtSL;
        private Label label11;
        private TextBox txtTenSP;
        private Label label13;
        private Label label16;
        private TextBox txtMaHoaDonTimKiem;
        private Button btnLuuHD;
        private Button btnTaoMoiHD;
        private Button btnHuyHD;
        private GroupBox groupBox4;
        private GroupBox groupBox5;
        private TextBox txtTongTien;
        private ListBox lstDSSP;
        private GroupBox groupBox6;
        private ListView lsvDSHD;
        private Label label7;
    }
}