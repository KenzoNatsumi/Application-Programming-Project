namespace quản_lí_cửa_hàng_máy_tính
{
    partial class Form1
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            label1 = new Label();
            label2 = new Label();
            label3 = new Label();
            txtTK = new TextBox();
            txtMK = new TextBox();
            btnDN = new Button();
            btnThoat = new Button();
            pictureBox1 = new PictureBox();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 14.25F, FontStyle.Bold, GraphicsUnit.Point);
            label1.ForeColor = Color.Firebrick;
            label1.Location = new Point(402, 105);
            label1.Name = "label1";
            label1.Size = new Size(198, 25);
            label1.TabIndex = 1;
            label1.Text = "Đăng nhập tài khoản";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Segoe UI", 9.75F, FontStyle.Bold, GraphicsUnit.Point);
            label2.ForeColor = Color.Firebrick;
            label2.Location = new Point(378, 159);
            label2.Name = "label2";
            label2.Size = new Size(66, 17);
            label2.TabIndex = 2;
            label2.Text = "tài khoản";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Segoe UI", 9.75F, FontStyle.Bold, GraphicsUnit.Point);
            label3.ForeColor = Color.Firebrick;
            label3.Location = new Point(378, 200);
            label3.Name = "label3";
            label3.Size = new Size(70, 17);
            label3.TabIndex = 3;
            label3.Text = "mật khẩu ";
            // 
            // txtTK
            // 
            txtTK.Location = new Point(466, 156);
            txtTK.Name = "txtTK";
            txtTK.Size = new Size(168, 23);
            txtTK.TabIndex = 4;
            // 
            // txtMK
            // 
            txtMK.Location = new Point(466, 198);
            txtMK.Name = "txtMK";
            txtMK.Size = new Size(168, 23);
            txtMK.TabIndex = 5;
            txtMK.UseSystemPasswordChar = true;
            // 
            // btnDN
            // 
            btnDN.BackColor = Color.CornflowerBlue;
            btnDN.Font = new Font("Segoe UI", 9.75F, FontStyle.Bold, GraphicsUnit.Point);
            btnDN.ForeColor = Color.Firebrick;
            btnDN.Location = new Point(378, 244);
            btnDN.Name = "btnDN";
            btnDN.Size = new Size(103, 40);
            btnDN.TabIndex = 6;
            btnDN.Text = "Đăng nhập";
            btnDN.UseVisualStyleBackColor = false;
            btnDN.Click += btnDN_Click;
            // 
            // btnThoat
            // 
            btnThoat.BackColor = Color.CornflowerBlue;
            btnThoat.Font = new Font("Segoe UI", 9.75F, FontStyle.Bold, GraphicsUnit.Point);
            btnThoat.ForeColor = Color.Firebrick;
            btnThoat.Location = new Point(531, 244);
            btnThoat.Name = "btnThoat";
            btnThoat.Size = new Size(103, 40);
            btnThoat.TabIndex = 7;
            btnThoat.Text = "Thoát";
            btnThoat.UseVisualStyleBackColor = false;
            btnThoat.Click += btnThoat_Click;
            // 
            // pictureBox1
            // 
            pictureBox1.Image = (Image)resources.GetObject("pictureBox1.Image");
            pictureBox1.Location = new Point(0, 0);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(336, 388);
            pictureBox1.SizeMode = PictureBoxSizeMode.StretchImage;
            pictureBox1.TabIndex = 8;
            pictureBox1.TabStop = false;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.RoyalBlue;
            ClientSize = new Size(670, 388);
            Controls.Add(pictureBox1);
            Controls.Add(btnThoat);
            Controls.Add(btnDN);
            Controls.Add(txtMK);
            Controls.Add(txtTK);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(label1);
            Name = "Form1";
            Text = "Form1";
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private Label label2;
        private Label label3;
        private TextBox txtTK;
        private TextBox txtMK;
        private Button btnDN;
        private Button btnThoat;
        private PictureBox pictureBox1;
    }
}