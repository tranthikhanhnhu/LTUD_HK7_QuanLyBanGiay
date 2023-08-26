
namespace GUI
{
    partial class formDanhSachGiay
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle4 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle5 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle6 = new System.Windows.Forms.DataGridViewCellStyle();
            this.guna2CustomGradientPanel1 = new Guna.UI2.WinForms.Guna2CustomGradientPanel();
            this.dtList = new Guna.UI2.WinForms.Guna2DataGridView();
            this.mãGiàyDataGridViewTextBoxColumn1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.tênGiàyDataGridViewTextBoxColumn1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.nhàSảnXuấtDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.sizeDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.màuDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.sốLượngDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.giáDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.giàyBindingSource3 = new System.Windows.Forms.BindingSource(this.components);
            this.dataSet1 = new GUI.DataSet1();
            this.btXoa = new Guna.UI2.WinForms.Guna2Button();
            this.btSua = new Guna.UI2.WinForms.Guna2Button();
            this.btThem = new Guna.UI2.WinForms.Guna2Button();
            this.guna2Panel1 = new Guna.UI2.WinForms.Guna2Panel();
            this.guna2ComboBox1 = new Guna.UI2.WinForms.Guna2ComboBox();
            this.btTimKiem = new Guna.UI2.WinForms.Guna2Button();
            this.txtFind = new Guna.UI2.WinForms.Guna2TextBox();
            this.giàyBindingSource2 = new System.Windows.Forms.BindingSource(this.components);
            this.guna2DragControl1 = new Guna.UI2.WinForms.Guna2DragControl(this.components);
            this.mãGiàyDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.tênGiàyDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.giàyBindingSource1 = new System.Windows.Forms.BindingSource(this.components);
            this.giàyBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.giàyTableAdapter = new GUI.DataSet1TableAdapters.GiàyTableAdapter();
            this.guna2CustomGradientPanel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dtList)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.giàyBindingSource3)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataSet1)).BeginInit();
            this.guna2Panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.giàyBindingSource2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.giàyBindingSource1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.giàyBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // guna2CustomGradientPanel1
            // 
            this.guna2CustomGradientPanel1.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.guna2CustomGradientPanel1.Controls.Add(this.dtList);
            this.guna2CustomGradientPanel1.Controls.Add(this.btXoa);
            this.guna2CustomGradientPanel1.Controls.Add(this.btSua);
            this.guna2CustomGradientPanel1.Controls.Add(this.btThem);
            this.guna2CustomGradientPanel1.Controls.Add(this.guna2Panel1);
            this.guna2CustomGradientPanel1.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(74)))), ((int)(((byte)(38)))), ((int)(((byte)(171)))));
            this.guna2CustomGradientPanel1.FillColor2 = System.Drawing.Color.FromArgb(((int)(((byte)(149)))), ((int)(((byte)(67)))), ((int)(((byte)(167)))));
            this.guna2CustomGradientPanel1.FillColor3 = System.Drawing.Color.FromArgb(((int)(((byte)(149)))), ((int)(((byte)(67)))), ((int)(((byte)(167)))));
            this.guna2CustomGradientPanel1.FillColor4 = System.Drawing.Color.FromArgb(((int)(((byte)(227)))), ((int)(((byte)(80)))), ((int)(((byte)(168)))));
            this.guna2CustomGradientPanel1.Location = new System.Drawing.Point(0, 0);
            this.guna2CustomGradientPanel1.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.guna2CustomGradientPanel1.Name = "guna2CustomGradientPanel1";
            this.guna2CustomGradientPanel1.Size = new System.Drawing.Size(1000, 825);
            this.guna2CustomGradientPanel1.TabIndex = 1;
            // 
            // dtList
            // 
            dataGridViewCellStyle4.BackColor = System.Drawing.Color.White;
            this.dtList.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle4;
            this.dtList.AutoGenerateColumns = false;
            dataGridViewCellStyle5.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle5.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(100)))), ((int)(((byte)(88)))), ((int)(((byte)(255)))));
            dataGridViewCellStyle5.Font = new System.Drawing.Font("Microsoft Sans Serif", 6.6F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle5.ForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle5.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle5.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle5.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dtList.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle5;
            this.dtList.ColumnHeadersHeight = 32;
            this.dtList.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.EnableResizing;
            this.dtList.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.mãGiàyDataGridViewTextBoxColumn1,
            this.tênGiàyDataGridViewTextBoxColumn1,
            this.nhàSảnXuấtDataGridViewTextBoxColumn,
            this.sizeDataGridViewTextBoxColumn,
            this.màuDataGridViewTextBoxColumn,
            this.sốLượngDataGridViewTextBoxColumn,
            this.giáDataGridViewTextBoxColumn});
            this.dtList.DataSource = this.giàyBindingSource3;
            dataGridViewCellStyle6.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle6.BackColor = System.Drawing.Color.White;
            dataGridViewCellStyle6.Font = new System.Drawing.Font("Microsoft Sans Serif", 6.6F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle6.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(71)))), ((int)(((byte)(69)))), ((int)(((byte)(94)))));
            dataGridViewCellStyle6.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(231)))), ((int)(((byte)(229)))), ((int)(((byte)(255)))));
            dataGridViewCellStyle6.SelectionForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(71)))), ((int)(((byte)(69)))), ((int)(((byte)(94)))));
            dataGridViewCellStyle6.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.dtList.DefaultCellStyle = dataGridViewCellStyle6;
            this.dtList.GridColor = System.Drawing.Color.FromArgb(((int)(((byte)(231)))), ((int)(((byte)(229)))), ((int)(((byte)(255)))));
            this.dtList.Location = new System.Drawing.Point(31, 129);
            this.dtList.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.dtList.Name = "dtList";
            this.dtList.ReadOnly = true;
            this.dtList.RowHeadersVisible = false;
            this.dtList.RowHeadersWidth = 51;
            this.dtList.Size = new System.Drawing.Size(940, 498);
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
            this.dtList.ThemeStyle.HeaderStyle.Font = new System.Drawing.Font("Microsoft Sans Serif", 6.6F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dtList.ThemeStyle.HeaderStyle.ForeColor = System.Drawing.Color.White;
            this.dtList.ThemeStyle.HeaderStyle.HeaightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.EnableResizing;
            this.dtList.ThemeStyle.HeaderStyle.Height = 32;
            this.dtList.ThemeStyle.ReadOnly = true;
            this.dtList.ThemeStyle.RowsStyle.BackColor = System.Drawing.Color.White;
            this.dtList.ThemeStyle.RowsStyle.BorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.SingleHorizontal;
            this.dtList.ThemeStyle.RowsStyle.Font = new System.Drawing.Font("Microsoft Sans Serif", 6.6F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dtList.ThemeStyle.RowsStyle.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(71)))), ((int)(((byte)(69)))), ((int)(((byte)(94)))));
            this.dtList.ThemeStyle.RowsStyle.Height = 22;
            this.dtList.ThemeStyle.RowsStyle.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(231)))), ((int)(((byte)(229)))), ((int)(((byte)(255)))));
            this.dtList.ThemeStyle.RowsStyle.SelectionForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(71)))), ((int)(((byte)(69)))), ((int)(((byte)(94)))));
            this.dtList.Click += new System.EventHandler(this.dtList_Click);
            // 
            // mãGiàyDataGridViewTextBoxColumn1
            // 
            this.mãGiàyDataGridViewTextBoxColumn1.DataPropertyName = "Mã giày";
            this.mãGiàyDataGridViewTextBoxColumn1.HeaderText = "Mã giày";
            this.mãGiàyDataGridViewTextBoxColumn1.MinimumWidth = 6;
            this.mãGiàyDataGridViewTextBoxColumn1.Name = "mãGiàyDataGridViewTextBoxColumn1";
            this.mãGiàyDataGridViewTextBoxColumn1.ReadOnly = true;
            // 
            // tênGiàyDataGridViewTextBoxColumn1
            // 
            this.tênGiàyDataGridViewTextBoxColumn1.DataPropertyName = "Tên giày";
            this.tênGiàyDataGridViewTextBoxColumn1.HeaderText = "Tên giày";
            this.tênGiàyDataGridViewTextBoxColumn1.MinimumWidth = 6;
            this.tênGiàyDataGridViewTextBoxColumn1.Name = "tênGiàyDataGridViewTextBoxColumn1";
            this.tênGiàyDataGridViewTextBoxColumn1.ReadOnly = true;
            // 
            // nhàSảnXuấtDataGridViewTextBoxColumn
            // 
            this.nhàSảnXuấtDataGridViewTextBoxColumn.DataPropertyName = "Nhà sản xuất";
            this.nhàSảnXuấtDataGridViewTextBoxColumn.HeaderText = "Nhà sản xuất";
            this.nhàSảnXuấtDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.nhàSảnXuấtDataGridViewTextBoxColumn.Name = "nhàSảnXuấtDataGridViewTextBoxColumn";
            this.nhàSảnXuấtDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // sizeDataGridViewTextBoxColumn
            // 
            this.sizeDataGridViewTextBoxColumn.DataPropertyName = "Size";
            this.sizeDataGridViewTextBoxColumn.HeaderText = "Size";
            this.sizeDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.sizeDataGridViewTextBoxColumn.Name = "sizeDataGridViewTextBoxColumn";
            this.sizeDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // màuDataGridViewTextBoxColumn
            // 
            this.màuDataGridViewTextBoxColumn.DataPropertyName = "Màu";
            this.màuDataGridViewTextBoxColumn.HeaderText = "Màu";
            this.màuDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.màuDataGridViewTextBoxColumn.Name = "màuDataGridViewTextBoxColumn";
            this.màuDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // sốLượngDataGridViewTextBoxColumn
            // 
            this.sốLượngDataGridViewTextBoxColumn.DataPropertyName = "Số lượng";
            this.sốLượngDataGridViewTextBoxColumn.HeaderText = "Số lượng";
            this.sốLượngDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.sốLượngDataGridViewTextBoxColumn.Name = "sốLượngDataGridViewTextBoxColumn";
            this.sốLượngDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // giáDataGridViewTextBoxColumn
            // 
            this.giáDataGridViewTextBoxColumn.DataPropertyName = "Giá";
            this.giáDataGridViewTextBoxColumn.HeaderText = "Giá";
            this.giáDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.giáDataGridViewTextBoxColumn.Name = "giáDataGridViewTextBoxColumn";
            this.giáDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // giàyBindingSource3
            // 
            this.giàyBindingSource3.DataMember = "Giày";
            this.giàyBindingSource3.DataSource = this.dataSet1;
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
            this.btXoa.Location = new System.Drawing.Point(811, 726);
            this.btXoa.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.btXoa.Name = "btXoa";
            this.btXoa.Size = new System.Drawing.Size(160, 49);
            this.btXoa.TabIndex = 4;
            this.btXoa.Text = "Xóa";
            this.btXoa.Click += new System.EventHandler(this.btXoa_Click);
            // 
            // btSua
            // 
            this.btSua.Animated = true;
            this.btSua.BackColor = System.Drawing.Color.Transparent;
            this.btSua.BorderRadius = 8;
            this.btSua.CheckedState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(227)))), ((int)(((byte)(80)))), ((int)(((byte)(168)))));
            this.btSua.CheckedState.Font = new System.Drawing.Font("Segoe UI Semibold", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btSua.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.btSua.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.btSua.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.btSua.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.btSua.Font = new System.Drawing.Font("Segoe UI Semibold", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btSua.ForeColor = System.Drawing.Color.White;
            this.btSua.HoverState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(227)))), ((int)(((byte)(80)))), ((int)(((byte)(168)))));
            this.btSua.HoverState.Font = new System.Drawing.Font("Segoe UI Semibold", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btSua.Location = new System.Drawing.Point(640, 726);
            this.btSua.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.btSua.Name = "btSua";
            this.btSua.Size = new System.Drawing.Size(160, 49);
            this.btSua.TabIndex = 3;
            this.btSua.Text = "Sửa";
            this.btSua.Click += new System.EventHandler(this.btSua_Click);
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
            this.btThem.Location = new System.Drawing.Point(469, 726);
            this.btThem.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.btThem.Name = "btThem";
            this.btThem.Size = new System.Drawing.Size(160, 49);
            this.btThem.TabIndex = 2;
            this.btThem.Text = "Thêm";
            this.btThem.Click += new System.EventHandler(this.btThem_Click);
            // 
            // guna2Panel1
            // 
            this.guna2Panel1.BackColor = System.Drawing.Color.Transparent;
            this.guna2Panel1.Controls.Add(this.guna2ComboBox1);
            this.guna2Panel1.Controls.Add(this.btTimKiem);
            this.guna2Panel1.Controls.Add(this.txtFind);
            this.guna2Panel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.guna2Panel1.Location = new System.Drawing.Point(0, 0);
            this.guna2Panel1.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.guna2Panel1.Name = "guna2Panel1";
            this.guna2Panel1.Size = new System.Drawing.Size(1000, 78);
            this.guna2Panel1.TabIndex = 0;
            // 
            // guna2ComboBox1
            // 
            this.guna2ComboBox1.AutoRoundedCorners = true;
            this.guna2ComboBox1.BackColor = System.Drawing.Color.Transparent;
            this.guna2ComboBox1.BorderRadius = 17;
            this.guna2ComboBox1.DrawMode = System.Windows.Forms.DrawMode.OwnerDrawFixed;
            this.guna2ComboBox1.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.guna2ComboBox1.FocusedColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.guna2ComboBox1.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.guna2ComboBox1.Font = new System.Drawing.Font("Segoe UI", 10F);
            this.guna2ComboBox1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(68)))), ((int)(((byte)(88)))), ((int)(((byte)(112)))));
            this.guna2ComboBox1.ItemHeight = 30;
            this.guna2ComboBox1.Location = new System.Drawing.Point(377, 15);
            this.guna2ComboBox1.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.guna2ComboBox1.Name = "guna2ComboBox1";
            this.guna2ComboBox1.Size = new System.Drawing.Size(199, 36);
            this.guna2ComboBox1.TabIndex = 2;
            // 
            // btTimKiem
            // 
            this.btTimKiem.Animated = true;
            this.btTimKiem.AutoRoundedCorners = true;
            this.btTimKiem.BorderRadius = 17;
            this.btTimKiem.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.btTimKiem.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.btTimKiem.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.btTimKiem.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.btTimKiem.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.btTimKiem.ForeColor = System.Drawing.Color.White;
            this.btTimKiem.Location = new System.Drawing.Point(797, 15);
            this.btTimKiem.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.btTimKiem.Name = "btTimKiem";
            this.btTimKiem.Size = new System.Drawing.Size(133, 37);
            this.btTimKiem.TabIndex = 1;
            this.btTimKiem.Text = "Tìm kiếm";
            this.btTimKiem.Click += new System.EventHandler(this.btTimKiem_Click);
            // 
            // txtFind
            // 
            this.txtFind.Animated = true;
            this.txtFind.AutoRoundedCorners = true;
            this.txtFind.BorderRadius = 17;
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
            this.txtFind.Location = new System.Drawing.Point(585, 15);
            this.txtFind.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.txtFind.Name = "txtFind";
            this.txtFind.PasswordChar = '\0';
            this.txtFind.PlaceholderText = "";
            this.txtFind.SelectedText = "";
            this.txtFind.Size = new System.Drawing.Size(200, 37);
            this.txtFind.TabIndex = 0;
            // 
            // giàyBindingSource2
            // 
            this.giàyBindingSource2.DataMember = "Giày";
            this.giàyBindingSource2.DataSource = this.dataSet1;
            // 
            // guna2DragControl1
            // 
            this.guna2DragControl1.DockIndicatorTransparencyValue = 0.6D;
            this.guna2DragControl1.TargetControl = this;
            this.guna2DragControl1.UseTransparentDrag = true;
            // 
            // mãGiàyDataGridViewTextBoxColumn
            // 
            this.mãGiàyDataGridViewTextBoxColumn.DataPropertyName = "Mã giày";
            this.mãGiàyDataGridViewTextBoxColumn.HeaderText = "Mã giày";
            this.mãGiàyDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.mãGiàyDataGridViewTextBoxColumn.Name = "mãGiàyDataGridViewTextBoxColumn";
            this.mãGiàyDataGridViewTextBoxColumn.Width = 129;
            // 
            // tênGiàyDataGridViewTextBoxColumn
            // 
            this.tênGiàyDataGridViewTextBoxColumn.DataPropertyName = "Tên giày";
            this.tênGiàyDataGridViewTextBoxColumn.HeaderText = "Tên giày";
            this.tênGiàyDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.tênGiàyDataGridViewTextBoxColumn.Name = "tênGiàyDataGridViewTextBoxColumn";
            this.tênGiàyDataGridViewTextBoxColumn.Width = 130;
            // 
            // giàyBindingSource1
            // 
            this.giàyBindingSource1.DataMember = "Giày";
            this.giàyBindingSource1.DataSource = this.dataSet1;
            // 
            // giàyBindingSource
            // 
            this.giàyBindingSource.DataMember = "Giày";
            this.giàyBindingSource.DataSource = this.dataSet1;
            // 
            // giàyTableAdapter
            // 
            this.giàyTableAdapter.ClearBeforeFill = true;
            // 
            // formDanhSachGiay
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1000, 825);
            this.Controls.Add(this.guna2CustomGradientPanel1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.Name = "formDanhSachGiay";
            this.Text = "formDanhSachGiay";
            this.Load += new System.EventHandler(this.formDanhSachGiay_Load);
            this.guna2CustomGradientPanel1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dtList)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.giàyBindingSource3)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataSet1)).EndInit();
            this.guna2Panel1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.giàyBindingSource2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.giàyBindingSource1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.giàyBindingSource)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private Guna.UI2.WinForms.Guna2CustomGradientPanel guna2CustomGradientPanel1;
        private Guna.UI2.WinForms.Guna2Button btXoa;
        private Guna.UI2.WinForms.Guna2Button btSua;
        private Guna.UI2.WinForms.Guna2Button btThem;
        private Guna.UI2.WinForms.Guna2Panel guna2Panel1;
        private Guna.UI2.WinForms.Guna2ComboBox guna2ComboBox1;
        private Guna.UI2.WinForms.Guna2Button btTimKiem;
        private Guna.UI2.WinForms.Guna2TextBox txtFind;
        private Guna.UI2.WinForms.Guna2DragControl guna2DragControl1;
        private DataSet1 dataSet1;
        private DataSet1TableAdapters.GiàyTableAdapter giàyTableAdapter;
        private System.Windows.Forms.DataGridViewTextBoxColumn mãGiàyDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn tênGiàyDataGridViewTextBoxColumn;
        private System.Windows.Forms.BindingSource giàyBindingSource;
        private System.Windows.Forms.BindingSource giàyBindingSource1;
        private Guna.UI2.WinForms.Guna2DataGridView dtList;
        private System.Windows.Forms.BindingSource giàyBindingSource2;
        private System.Windows.Forms.DataGridViewTextBoxColumn mãGiàyDataGridViewTextBoxColumn1;
        private System.Windows.Forms.DataGridViewTextBoxColumn tênGiàyDataGridViewTextBoxColumn1;
        private System.Windows.Forms.DataGridViewTextBoxColumn nhàSảnXuấtDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn sizeDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn màuDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn sốLượngDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn giáDataGridViewTextBoxColumn;
        private System.Windows.Forms.BindingSource giàyBindingSource3;
    }
}