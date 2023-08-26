
namespace GUI
{
    partial class formDanhSachNhanVien
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
            this.components = new System.ComponentModel.Container();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle3 = new System.Windows.Forms.DataGridViewCellStyle();
            this.guna2CustomGradientPanel1 = new Guna.UI2.WinForms.Guna2CustomGradientPanel();
            this.dtList = new Guna.UI2.WinForms.Guna2DataGridView();
            this.mãNhânViênDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.họTênNhânViênDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ngàySinhDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.sđtDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.nhânViênBindingSource3 = new System.Windows.Forms.BindingSource(this.components);
            this.dataSet1 = new GUI.DataSet1();
            this.btXoa = new Guna.UI2.WinForms.Guna2Button();
            this.btThem = new Guna.UI2.WinForms.Guna2Button();
            this.guna2Panel1 = new Guna.UI2.WinForms.Guna2Panel();
            this.cbOP = new Guna.UI2.WinForms.Guna2ComboBox();
            this.btTimKiem = new Guna.UI2.WinForms.Guna2Button();
            this.txtFind = new Guna.UI2.WinForms.Guna2TextBox();
            this.nhânViênBindingSource2 = new System.Windows.Forms.BindingSource(this.components);
            this.guna2DragControl1 = new Guna.UI2.WinForms.Guna2DragControl(this.components);
            this.nhânViênBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.nhân_viênTableAdapter = new GUI.DataSet1TableAdapters.Nhân_viênTableAdapter();
            this.nhânViênBindingSource1 = new System.Windows.Forms.BindingSource(this.components);
            this.guna2CustomGradientPanel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dtList)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.nhânViênBindingSource3)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataSet1)).BeginInit();
            this.guna2Panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.nhânViênBindingSource2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.nhânViênBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.nhânViênBindingSource1)).BeginInit();
            this.SuspendLayout();
            // 
            // guna2CustomGradientPanel1
            // 
            this.guna2CustomGradientPanel1.Controls.Add(this.dtList);
            this.guna2CustomGradientPanel1.Controls.Add(this.btXoa);
            this.guna2CustomGradientPanel1.Controls.Add(this.btThem);
            this.guna2CustomGradientPanel1.Controls.Add(this.guna2Panel1);
            this.guna2CustomGradientPanel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.guna2CustomGradientPanel1.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(74)))), ((int)(((byte)(38)))), ((int)(((byte)(171)))));
            this.guna2CustomGradientPanel1.FillColor2 = System.Drawing.Color.FromArgb(((int)(((byte)(149)))), ((int)(((byte)(67)))), ((int)(((byte)(167)))));
            this.guna2CustomGradientPanel1.FillColor3 = System.Drawing.Color.FromArgb(((int)(((byte)(149)))), ((int)(((byte)(67)))), ((int)(((byte)(167)))));
            this.guna2CustomGradientPanel1.FillColor4 = System.Drawing.Color.FromArgb(((int)(((byte)(227)))), ((int)(((byte)(80)))), ((int)(((byte)(168)))));
            this.guna2CustomGradientPanel1.Location = new System.Drawing.Point(0, 0);
            this.guna2CustomGradientPanel1.Name = "guna2CustomGradientPanel1";
            this.guna2CustomGradientPanel1.Size = new System.Drawing.Size(750, 670);
            this.guna2CustomGradientPanel1.TabIndex = 0;
            // 
            // dtList
            // 
            this.dtList.AllowUserToAddRows = false;
            this.dtList.AllowUserToDeleteRows = false;
            dataGridViewCellStyle1.BackColor = System.Drawing.Color.White;
            this.dtList.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle1;
            this.dtList.AutoGenerateColumns = false;
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(100)))), ((int)(((byte)(88)))), ((int)(((byte)(255)))));
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Segoe UI Semibold", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle2.ForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dtList.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle2;
            this.dtList.ColumnHeadersHeight = 25;
            this.dtList.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.EnableResizing;
            this.dtList.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.mãNhânViênDataGridViewTextBoxColumn,
            this.họTênNhânViênDataGridViewTextBoxColumn,
            this.ngàySinhDataGridViewTextBoxColumn,
            this.sđtDataGridViewTextBoxColumn});
            this.dtList.DataSource = this.nhânViênBindingSource3;
            dataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle3.BackColor = System.Drawing.Color.White;
            dataGridViewCellStyle3.Font = new System.Drawing.Font("Segoe UI Semibold", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle3.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(71)))), ((int)(((byte)(69)))), ((int)(((byte)(94)))));
            dataGridViewCellStyle3.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(231)))), ((int)(((byte)(229)))), ((int)(((byte)(255)))));
            dataGridViewCellStyle3.SelectionForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(71)))), ((int)(((byte)(69)))), ((int)(((byte)(94)))));
            dataGridViewCellStyle3.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.dtList.DefaultCellStyle = dataGridViewCellStyle3;
            this.dtList.GridColor = System.Drawing.Color.FromArgb(((int)(((byte)(231)))), ((int)(((byte)(229)))), ((int)(((byte)(255)))));
            this.dtList.Location = new System.Drawing.Point(29, 106);
            this.dtList.Name = "dtList";
            this.dtList.ReadOnly = true;
            this.dtList.RowHeadersVisible = false;
            this.dtList.RowHeadersWidth = 51;
            this.dtList.Size = new System.Drawing.Size(693, 408);
            this.dtList.TabIndex = 5;
            this.dtList.ThemeStyle.AlternatingRowsStyle.BackColor = System.Drawing.Color.White;
            this.dtList.ThemeStyle.AlternatingRowsStyle.Font = null;
            this.dtList.ThemeStyle.AlternatingRowsStyle.ForeColor = System.Drawing.Color.Empty;
            this.dtList.ThemeStyle.AlternatingRowsStyle.SelectionBackColor = System.Drawing.Color.Empty;
            this.dtList.ThemeStyle.AlternatingRowsStyle.SelectionForeColor = System.Drawing.Color.Empty;
            this.dtList.ThemeStyle.BackColor = System.Drawing.Color.White;
            this.dtList.ThemeStyle.GridColor = System.Drawing.Color.FromArgb(((int)(((byte)(231)))), ((int)(((byte)(229)))), ((int)(((byte)(255)))));
            this.dtList.ThemeStyle.HeaderStyle.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(100)))), ((int)(((byte)(88)))), ((int)(((byte)(255)))));
            this.dtList.ThemeStyle.HeaderStyle.BorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            this.dtList.ThemeStyle.HeaderStyle.Font = new System.Drawing.Font("Segoe UI Semibold", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dtList.ThemeStyle.HeaderStyle.ForeColor = System.Drawing.Color.White;
            this.dtList.ThemeStyle.HeaderStyle.HeaightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.EnableResizing;
            this.dtList.ThemeStyle.HeaderStyle.Height = 25;
            this.dtList.ThemeStyle.ReadOnly = true;
            this.dtList.ThemeStyle.RowsStyle.BackColor = System.Drawing.Color.White;
            this.dtList.ThemeStyle.RowsStyle.BorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.SingleHorizontal;
            this.dtList.ThemeStyle.RowsStyle.Font = new System.Drawing.Font("Segoe UI Semibold", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dtList.ThemeStyle.RowsStyle.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(71)))), ((int)(((byte)(69)))), ((int)(((byte)(94)))));
            this.dtList.ThemeStyle.RowsStyle.Height = 22;
            this.dtList.ThemeStyle.RowsStyle.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(231)))), ((int)(((byte)(229)))), ((int)(((byte)(255)))));
            this.dtList.ThemeStyle.RowsStyle.SelectionForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(71)))), ((int)(((byte)(69)))), ((int)(((byte)(94)))));
            this.dtList.Click += new System.EventHandler(this.dtList_Click);
            // 
            // mãNhânViênDataGridViewTextBoxColumn
            // 
            this.mãNhânViênDataGridViewTextBoxColumn.DataPropertyName = "Mã nhân viên";
            this.mãNhânViênDataGridViewTextBoxColumn.HeaderText = "Mã nhân viên";
            this.mãNhânViênDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.mãNhânViênDataGridViewTextBoxColumn.Name = "mãNhânViênDataGridViewTextBoxColumn";
            this.mãNhânViênDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // họTênNhânViênDataGridViewTextBoxColumn
            // 
            this.họTênNhânViênDataGridViewTextBoxColumn.DataPropertyName = "Họ tên nhân viên";
            this.họTênNhânViênDataGridViewTextBoxColumn.HeaderText = "Họ tên nhân viên";
            this.họTênNhânViênDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.họTênNhânViênDataGridViewTextBoxColumn.Name = "họTênNhânViênDataGridViewTextBoxColumn";
            this.họTênNhânViênDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // ngàySinhDataGridViewTextBoxColumn
            // 
            this.ngàySinhDataGridViewTextBoxColumn.DataPropertyName = "Ngày sinh";
            this.ngàySinhDataGridViewTextBoxColumn.HeaderText = "Ngày sinh";
            this.ngàySinhDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.ngàySinhDataGridViewTextBoxColumn.Name = "ngàySinhDataGridViewTextBoxColumn";
            this.ngàySinhDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // sđtDataGridViewTextBoxColumn
            // 
            this.sđtDataGridViewTextBoxColumn.DataPropertyName = "Sđt";
            this.sđtDataGridViewTextBoxColumn.HeaderText = "Sđt";
            this.sđtDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.sđtDataGridViewTextBoxColumn.Name = "sđtDataGridViewTextBoxColumn";
            this.sđtDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // nhânViênBindingSource3
            // 
            this.nhânViênBindingSource3.DataMember = "Nhân viên";
            this.nhânViênBindingSource3.DataSource = this.dataSet1;
            // 
            // dataSet1
            // 
            this.dataSet1.DataSetName = "DataSet1";
            this.dataSet1.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // btXoa
            // 
            this.btXoa.Animated = true;
            this.btXoa.BackColor = System.Drawing.Color.Transparent;
            this.btXoa.BorderRadius = 8;
            this.btXoa.CheckedState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(227)))), ((int)(((byte)(80)))), ((int)(((byte)(168)))));
            this.btXoa.CheckedState.Font = new System.Drawing.Font("Segoe UI Semibold", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btXoa.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.btXoa.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.btXoa.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.btXoa.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.btXoa.Font = new System.Drawing.Font("Segoe UI Semibold", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btXoa.ForeColor = System.Drawing.Color.White;
            this.btXoa.HoverState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(227)))), ((int)(((byte)(80)))), ((int)(((byte)(168)))));
            this.btXoa.HoverState.Font = new System.Drawing.Font("Segoe UI Semibold", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btXoa.Location = new System.Drawing.Point(617, 600);
            this.btXoa.Name = "btXoa";
            this.btXoa.Size = new System.Drawing.Size(120, 40);
            this.btXoa.TabIndex = 4;
            this.btXoa.Text = "Xóa";
            this.btXoa.Click += new System.EventHandler(this.btXoa_Click);
            // 
            // btThem
            // 
            this.btThem.Animated = true;
            this.btThem.BackColor = System.Drawing.Color.Transparent;
            this.btThem.BorderRadius = 8;
            this.btThem.CheckedState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(227)))), ((int)(((byte)(80)))), ((int)(((byte)(168)))));
            this.btThem.CheckedState.Font = new System.Drawing.Font("Segoe UI Semibold", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btThem.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.btThem.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.btThem.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.btThem.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.btThem.Font = new System.Drawing.Font("Segoe UI Semibold", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btThem.ForeColor = System.Drawing.Color.White;
            this.btThem.HoverState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(227)))), ((int)(((byte)(80)))), ((int)(((byte)(168)))));
            this.btThem.HoverState.Font = new System.Drawing.Font("Segoe UI Semibold", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btThem.Location = new System.Drawing.Point(478, 600);
            this.btThem.Name = "btThem";
            this.btThem.Size = new System.Drawing.Size(120, 40);
            this.btThem.TabIndex = 2;
            this.btThem.Text = "Thêm";
            this.btThem.Click += new System.EventHandler(this.btThem_Click);
            // 
            // guna2Panel1
            // 
            this.guna2Panel1.BackColor = System.Drawing.Color.Transparent;
            this.guna2Panel1.Controls.Add(this.cbOP);
            this.guna2Panel1.Controls.Add(this.btTimKiem);
            this.guna2Panel1.Controls.Add(this.txtFind);
            this.guna2Panel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.guna2Panel1.Location = new System.Drawing.Point(0, 0);
            this.guna2Panel1.Name = "guna2Panel1";
            this.guna2Panel1.Size = new System.Drawing.Size(750, 63);
            this.guna2Panel1.TabIndex = 0;
            // 
            // cbOP
            // 
            this.cbOP.AutoRoundedCorners = true;
            this.cbOP.BackColor = System.Drawing.Color.Transparent;
            this.cbOP.BorderRadius = 17;
            this.cbOP.DrawMode = System.Windows.Forms.DrawMode.OwnerDrawFixed;
            this.cbOP.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbOP.FocusedColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.cbOP.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.cbOP.Font = new System.Drawing.Font("Segoe UI", 10F);
            this.cbOP.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(68)))), ((int)(((byte)(88)))), ((int)(((byte)(112)))));
            this.cbOP.ItemHeight = 30;
            this.cbOP.Items.AddRange(new object[] {
            "Mã nhân viên",
            "Họ tên nhân viên"});
            this.cbOP.Location = new System.Drawing.Point(322, 12);
            this.cbOP.Name = "cbOP";
            this.cbOP.Size = new System.Drawing.Size(150, 36);
            this.cbOP.StartIndex = 0;
            this.cbOP.TabIndex = 2;
            // 
            // btTimKiem
            // 
            this.btTimKiem.Animated = true;
            this.btTimKiem.AutoRoundedCorners = true;
            this.btTimKiem.BorderRadius = 14;
            this.btTimKiem.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.btTimKiem.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.btTimKiem.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.btTimKiem.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.btTimKiem.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.btTimKiem.ForeColor = System.Drawing.Color.White;
            this.btTimKiem.Location = new System.Drawing.Point(637, 12);
            this.btTimKiem.Name = "btTimKiem";
            this.btTimKiem.Size = new System.Drawing.Size(100, 30);
            this.btTimKiem.TabIndex = 1;
            this.btTimKiem.Text = "Tìm kiếm";
            // 
            // txtFind
            // 
            this.txtFind.Animated = true;
            this.txtFind.AutoRoundedCorners = true;
            this.txtFind.BorderRadius = 14;
            this.txtFind.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.txtFind.DefaultText = "";
            this.txtFind.DisabledState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(208)))), ((int)(((byte)(208)))));
            this.txtFind.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(226)))), ((int)(((byte)(226)))), ((int)(((byte)(226)))));
            this.txtFind.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.txtFind.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.txtFind.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.txtFind.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.txtFind.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.txtFind.HoverState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.txtFind.Location = new System.Drawing.Point(478, 12);
            this.txtFind.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.txtFind.Name = "txtFind";
            this.txtFind.PasswordChar = '\0';
            this.txtFind.PlaceholderText = "";
            this.txtFind.SelectedText = "";
            this.txtFind.Size = new System.Drawing.Size(150, 30);
            this.txtFind.TabIndex = 0;
            // 
            // nhânViênBindingSource2
            // 
            this.nhânViênBindingSource2.DataMember = "Nhân viên";
            this.nhânViênBindingSource2.DataSource = this.dataSet1;
            // 
            // guna2DragControl1
            // 
            this.guna2DragControl1.DockIndicatorTransparencyValue = 0.6D;
            this.guna2DragControl1.TargetControl = this;
            this.guna2DragControl1.UseTransparentDrag = true;
            // 
            // nhânViênBindingSource
            // 
            this.nhânViênBindingSource.DataMember = "Nhân viên";
            this.nhânViênBindingSource.DataSource = this.dataSet1;
            // 
            // nhân_viênTableAdapter
            // 
            this.nhân_viênTableAdapter.ClearBeforeFill = true;
            // 
            // nhânViênBindingSource1
            // 
            this.nhânViênBindingSource1.DataMember = "Nhân viên";
            this.nhânViênBindingSource1.DataSource = this.dataSet1;
            // 
            // formDanhSachNhanVien
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(10F, 23F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoSize = true;
            this.ClientSize = new System.Drawing.Size(750, 670);
            this.Controls.Add(this.guna2CustomGradientPanel1);
            this.Font = new System.Drawing.Font("Segoe UI Semibold", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Margin = new System.Windows.Forms.Padding(5);
            this.Name = "formDanhSachNhanVien";
            this.Text = "formDanhSachNhanVien";
            this.Load += new System.EventHandler(this.formDanhSachNhanVien_Load);
            this.guna2CustomGradientPanel1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dtList)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.nhânViênBindingSource3)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataSet1)).EndInit();
            this.guna2Panel1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.nhânViênBindingSource2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.nhânViênBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.nhânViênBindingSource1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private Guna.UI2.WinForms.Guna2CustomGradientPanel guna2CustomGradientPanel1;
        private Guna.UI2.WinForms.Guna2DragControl guna2DragControl1;
        private Guna.UI2.WinForms.Guna2Panel guna2Panel1;
        private Guna.UI2.WinForms.Guna2TextBox txtFind;
        private Guna.UI2.WinForms.Guna2Button btTimKiem;
        private Guna.UI2.WinForms.Guna2Button btThem;
        private Guna.UI2.WinForms.Guna2Button btXoa;
        private Guna.UI2.WinForms.Guna2ComboBox cbOP;
        private DataSet1 dataSet1;
        private System.Windows.Forms.BindingSource nhânViênBindingSource;
        private DataSet1TableAdapters.Nhân_viênTableAdapter nhân_viênTableAdapter;
        private System.Windows.Forms.BindingSource nhânViênBindingSource1;
        private Guna.UI2.WinForms.Guna2DataGridView dtList;
        private System.Windows.Forms.DataGridViewTextBoxColumn mãNhânViênDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn họTênNhânViênDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn ngàySinhDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn sđtDataGridViewTextBoxColumn;
        private System.Windows.Forms.BindingSource nhânViênBindingSource2;
        private System.Windows.Forms.BindingSource nhânViênBindingSource3;
    }
}