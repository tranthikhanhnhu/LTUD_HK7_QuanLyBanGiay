
namespace GUI
{
    partial class formThemNV
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
            this.guna2CustomGradientPanel1 = new Guna.UI2.WinForms.Guna2CustomGradientPanel();
            this.guna2ControlBox1 = new Guna.UI2.WinForms.Guna2ControlBox();
            this.guna2CustomGradientPanel2 = new Guna.UI2.WinForms.Guna2CustomGradientPanel();
            this.label1 = new System.Windows.Forms.Label();
            this.chkAdmin = new Guna.UI2.WinForms.Guna2ToggleSwitch();
            this.dtNSinh = new Guna.UI2.WinForms.Guna2DateTimePicker();
            this.btThem = new Guna.UI2.WinForms.Guna2GradientButton();
            this.txtID = new Guna.UI2.WinForms.Guna2TextBox();
            this.txtSDT = new Guna.UI2.WinForms.Guna2TextBox();
            this.txtMK = new Guna.UI2.WinForms.Guna2TextBox();
            this.txtTen = new Guna.UI2.WinForms.Guna2TextBox();
            this.guna2CustomGradientPanel1.SuspendLayout();
            this.guna2CustomGradientPanel2.SuspendLayout();
            this.SuspendLayout();
            // 
            // guna2CustomGradientPanel1
            // 
            this.guna2CustomGradientPanel1.BackColor = System.Drawing.Color.Transparent;
            this.guna2CustomGradientPanel1.Controls.Add(this.guna2ControlBox1);
            this.guna2CustomGradientPanel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.guna2CustomGradientPanel1.Location = new System.Drawing.Point(0, 0);
            this.guna2CustomGradientPanel1.Name = "guna2CustomGradientPanel1";
            this.guna2CustomGradientPanel1.Size = new System.Drawing.Size(500, 30);
            this.guna2CustomGradientPanel1.TabIndex = 2;
            // 
            // guna2ControlBox1
            // 
            this.guna2ControlBox1.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.guna2ControlBox1.BackColor = System.Drawing.Color.Transparent;
            this.guna2ControlBox1.FillColor = System.Drawing.Color.Transparent;
            this.guna2ControlBox1.IconColor = System.Drawing.Color.Black;
            this.guna2ControlBox1.Location = new System.Drawing.Point(0, 0);
            this.guna2ControlBox1.Name = "guna2ControlBox1";
            this.guna2ControlBox1.Size = new System.Drawing.Size(45, 29);
            this.guna2ControlBox1.TabIndex = 0;
            // 
            // guna2CustomGradientPanel2
            // 
            this.guna2CustomGradientPanel2.BackColor = System.Drawing.Color.Transparent;
            this.guna2CustomGradientPanel2.Controls.Add(this.label1);
            this.guna2CustomGradientPanel2.Controls.Add(this.chkAdmin);
            this.guna2CustomGradientPanel2.Controls.Add(this.dtNSinh);
            this.guna2CustomGradientPanel2.Controls.Add(this.btThem);
            this.guna2CustomGradientPanel2.Controls.Add(this.txtID);
            this.guna2CustomGradientPanel2.Controls.Add(this.txtSDT);
            this.guna2CustomGradientPanel2.Controls.Add(this.txtMK);
            this.guna2CustomGradientPanel2.Controls.Add(this.txtTen);
            this.guna2CustomGradientPanel2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.guna2CustomGradientPanel2.Location = new System.Drawing.Point(0, 0);
            this.guna2CustomGradientPanel2.Name = "guna2CustomGradientPanel2";
            this.guna2CustomGradientPanel2.Size = new System.Drawing.Size(500, 800);
            this.guna2CustomGradientPanel2.TabIndex = 3;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Segoe UI Semibold", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(104, 468);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(60, 23);
            this.label1.TabIndex = 19;
            this.label1.Text = "Admin";
            // 
            // chkAdmin
            // 
            this.chkAdmin.CheckedState.BorderColor = System.Drawing.Color.Lime;
            this.chkAdmin.CheckedState.FillColor = System.Drawing.Color.Lime;
            this.chkAdmin.CheckedState.InnerBorderColor = System.Drawing.Color.White;
            this.chkAdmin.CheckedState.InnerColor = System.Drawing.Color.White;
            this.chkAdmin.Location = new System.Drawing.Point(46, 468);
            this.chkAdmin.Name = "chkAdmin";
            this.chkAdmin.Size = new System.Drawing.Size(40, 20);
            this.chkAdmin.TabIndex = 18;
            this.chkAdmin.UncheckedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(125)))), ((int)(((byte)(137)))), ((int)(((byte)(149)))));
            this.chkAdmin.UncheckedState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(125)))), ((int)(((byte)(137)))), ((int)(((byte)(149)))));
            this.chkAdmin.UncheckedState.InnerBorderColor = System.Drawing.Color.White;
            this.chkAdmin.UncheckedState.InnerColor = System.Drawing.Color.White;
            // 
            // dtNSinh
            // 
            this.dtNSinh.Animated = true;
            this.dtNSinh.BorderRadius = 8;
            this.dtNSinh.Checked = true;
            this.dtNSinh.FillColor = System.Drawing.Color.White;
            this.dtNSinh.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.dtNSinh.Format = System.Windows.Forms.DateTimePickerFormat.Long;
            this.dtNSinh.Location = new System.Drawing.Point(46, 396);
            this.dtNSinh.MaxDate = new System.DateTime(9998, 12, 31, 0, 0, 0, 0);
            this.dtNSinh.MinDate = new System.DateTime(1753, 1, 1, 0, 0, 0, 0);
            this.dtNSinh.Name = "dtNSinh";
            this.dtNSinh.Size = new System.Drawing.Size(400, 36);
            this.dtNSinh.TabIndex = 17;
            this.dtNSinh.Value = new System.DateTime(2023, 8, 23, 20, 4, 42, 193);
            // 
            // btThem
            // 
            this.btThem.Animated = true;
            this.btThem.AutoRoundedCorners = true;
            this.btThem.BackColor = System.Drawing.Color.Transparent;
            this.btThem.BorderRadius = 21;
            this.btThem.CheckedState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(149)))), ((int)(((byte)(67)))), ((int)(((byte)(167)))));
            this.btThem.CheckedState.FillColor2 = System.Drawing.Color.FromArgb(((int)(((byte)(74)))), ((int)(((byte)(38)))), ((int)(((byte)(171)))));
            this.btThem.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.btThem.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.btThem.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.btThem.DisabledState.FillColor2 = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.btThem.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.btThem.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(33)))), ((int)(((byte)(36)))), ((int)(((byte)(77)))));
            this.btThem.FillColor2 = System.Drawing.Color.FromArgb(((int)(((byte)(227)))), ((int)(((byte)(80)))), ((int)(((byte)(168)))));
            this.btThem.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.btThem.ForeColor = System.Drawing.Color.White;
            this.btThem.HoverState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(33)))), ((int)(((byte)(36)))), ((int)(((byte)(77)))));
            this.btThem.HoverState.FillColor2 = System.Drawing.Color.FromArgb(((int)(((byte)(184)))), ((int)(((byte)(213)))), ((int)(((byte)(234)))));
            this.btThem.HoverState.Font = new System.Drawing.Font("Segoe UI Semibold", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btThem.Location = new System.Drawing.Point(294, 704);
            this.btThem.Name = "btThem";
            this.btThem.Size = new System.Drawing.Size(180, 45);
            this.btThem.TabIndex = 16;
            this.btThem.Text = "Thêm";
            this.btThem.Click += new System.EventHandler(this.btThem_Click);
            // 
            // txtID
            // 
            this.txtID.Animated = true;
            this.txtID.AutoRoundedCorners = true;
            this.txtID.BackColor = System.Drawing.Color.Transparent;
            this.txtID.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(149)))), ((int)(((byte)(67)))), ((int)(((byte)(167)))));
            this.txtID.BorderRadius = 17;
            this.txtID.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.txtID.DefaultText = "";
            this.txtID.DisabledState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(208)))), ((int)(((byte)(208)))));
            this.txtID.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(226)))), ((int)(((byte)(226)))), ((int)(((byte)(226)))));
            this.txtID.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.txtID.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.txtID.FillColor = System.Drawing.Color.Gainsboro;
            this.txtID.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(227)))), ((int)(((byte)(80)))), ((int)(((byte)(168)))));
            this.txtID.Font = new System.Drawing.Font("Segoe UI", 10.2F);
            this.txtID.ForeColor = System.Drawing.Color.Black;
            this.txtID.HoverState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.txtID.Location = new System.Drawing.Point(46, 179);
            this.txtID.Margin = new System.Windows.Forms.Padding(3, 5, 3, 5);
            this.txtID.Name = "txtID";
            this.txtID.PasswordChar = '\0';
            this.txtID.PlaceholderForeColor = System.Drawing.Color.Black;
            this.txtID.PlaceholderText = "Mã nhân viên";
            this.txtID.SelectedText = "";
            this.txtID.Size = new System.Drawing.Size(400, 36);
            this.txtID.TabIndex = 11;
            // 
            // txtSDT
            // 
            this.txtSDT.Animated = true;
            this.txtSDT.AutoRoundedCorners = true;
            this.txtSDT.BackColor = System.Drawing.Color.Transparent;
            this.txtSDT.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(149)))), ((int)(((byte)(67)))), ((int)(((byte)(167)))));
            this.txtSDT.BorderRadius = 17;
            this.txtSDT.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.txtSDT.DefaultText = "";
            this.txtSDT.DisabledState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(208)))), ((int)(((byte)(208)))));
            this.txtSDT.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(226)))), ((int)(((byte)(226)))), ((int)(((byte)(226)))));
            this.txtSDT.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.txtSDT.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.txtSDT.FillColor = System.Drawing.Color.Gainsboro;
            this.txtSDT.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(227)))), ((int)(((byte)(80)))), ((int)(((byte)(168)))));
            this.txtSDT.Font = new System.Drawing.Font("Segoe UI", 10.2F);
            this.txtSDT.ForeColor = System.Drawing.Color.Black;
            this.txtSDT.HoverState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.txtSDT.Location = new System.Drawing.Point(46, 247);
            this.txtSDT.Margin = new System.Windows.Forms.Padding(3, 5, 3, 5);
            this.txtSDT.Name = "txtSDT";
            this.txtSDT.PasswordChar = '\0';
            this.txtSDT.PlaceholderForeColor = System.Drawing.Color.Black;
            this.txtSDT.PlaceholderText = "Số điện thoại";
            this.txtSDT.SelectedText = "";
            this.txtSDT.Size = new System.Drawing.Size(400, 36);
            this.txtSDT.TabIndex = 10;
            // 
            // txtMK
            // 
            this.txtMK.Animated = true;
            this.txtMK.AutoRoundedCorners = true;
            this.txtMK.BackColor = System.Drawing.Color.Transparent;
            this.txtMK.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(149)))), ((int)(((byte)(67)))), ((int)(((byte)(167)))));
            this.txtMK.BorderRadius = 17;
            this.txtMK.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.txtMK.DefaultText = "";
            this.txtMK.DisabledState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(208)))), ((int)(((byte)(208)))));
            this.txtMK.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(226)))), ((int)(((byte)(226)))), ((int)(((byte)(226)))));
            this.txtMK.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.txtMK.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.txtMK.FillColor = System.Drawing.Color.Gainsboro;
            this.txtMK.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(227)))), ((int)(((byte)(80)))), ((int)(((byte)(168)))));
            this.txtMK.Font = new System.Drawing.Font("Segoe UI", 10.2F);
            this.txtMK.ForeColor = System.Drawing.Color.Black;
            this.txtMK.HoverState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.txtMK.Location = new System.Drawing.Point(46, 326);
            this.txtMK.Margin = new System.Windows.Forms.Padding(3, 5, 3, 5);
            this.txtMK.Name = "txtMK";
            this.txtMK.PasswordChar = '\0';
            this.txtMK.PlaceholderForeColor = System.Drawing.Color.Black;
            this.txtMK.PlaceholderText = "Mật khẩu";
            this.txtMK.SelectedText = "";
            this.txtMK.Size = new System.Drawing.Size(400, 36);
            this.txtMK.TabIndex = 9;
            // 
            // txtTen
            // 
            this.txtTen.Animated = true;
            this.txtTen.AutoRoundedCorners = true;
            this.txtTen.BackColor = System.Drawing.Color.Transparent;
            this.txtTen.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(149)))), ((int)(((byte)(67)))), ((int)(((byte)(167)))));
            this.txtTen.BorderRadius = 17;
            this.txtTen.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.txtTen.DefaultText = "";
            this.txtTen.DisabledState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(208)))), ((int)(((byte)(208)))));
            this.txtTen.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(226)))), ((int)(((byte)(226)))), ((int)(((byte)(226)))));
            this.txtTen.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.txtTen.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.txtTen.FillColor = System.Drawing.Color.Gainsboro;
            this.txtTen.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(227)))), ((int)(((byte)(80)))), ((int)(((byte)(168)))));
            this.txtTen.Font = new System.Drawing.Font("Segoe UI", 10.2F);
            this.txtTen.ForeColor = System.Drawing.Color.Black;
            this.txtTen.HoverState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.txtTen.Location = new System.Drawing.Point(46, 105);
            this.txtTen.Margin = new System.Windows.Forms.Padding(3, 5, 3, 5);
            this.txtTen.Name = "txtTen";
            this.txtTen.PasswordChar = '\0';
            this.txtTen.PlaceholderForeColor = System.Drawing.Color.Black;
            this.txtTen.PlaceholderText = "Tên nhân viên";
            this.txtTen.SelectedText = "";
            this.txtTen.Size = new System.Drawing.Size(400, 36);
            this.txtTen.TabIndex = 5;
            // 
            // formThemNV
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(500, 800);
            this.Controls.Add(this.guna2CustomGradientPanel1);
            this.Controls.Add(this.guna2CustomGradientPanel2);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "formThemNV";
            this.Text = "formThemNV";
            this.guna2CustomGradientPanel1.ResumeLayout(false);
            this.guna2CustomGradientPanel2.ResumeLayout(false);
            this.guna2CustomGradientPanel2.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion
        private Guna.UI2.WinForms.Guna2CustomGradientPanel guna2CustomGradientPanel1;
        private Guna.UI2.WinForms.Guna2ControlBox guna2ControlBox1;
        private Guna.UI2.WinForms.Guna2CustomGradientPanel guna2CustomGradientPanel2;
        private Guna.UI2.WinForms.Guna2GradientButton btThem;
        private Guna.UI2.WinForms.Guna2TextBox txtID;
        private Guna.UI2.WinForms.Guna2TextBox txtSDT;
        private Guna.UI2.WinForms.Guna2TextBox txtMK;
        private Guna.UI2.WinForms.Guna2TextBox txtTen;
        private Guna.UI2.WinForms.Guna2DateTimePicker dtNSinh;
        private Guna.UI2.WinForms.Guna2ToggleSwitch chkAdmin;
        private System.Windows.Forms.Label label1;
    }
}