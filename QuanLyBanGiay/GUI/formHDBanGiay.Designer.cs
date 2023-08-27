
namespace GUI
{
    partial class formHDBanGiay
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
            this.guna2CustomGradientPanel2 = new Guna.UI2.WinForms.Guna2CustomGradientPanel();
            this.dtList = new Guna.UI2.WinForms.Guna2DataGridView();
            this.mãHóaĐơnDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.mãKháchHàngDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.mãGiàyDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.sốLượngDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.hóaĐơnBánHàngBindingSource1 = new System.Windows.Forms.BindingSource(this.components);
            this.dataSet1 = new GUI.DataSet1();
            this.btThem = new Guna.UI2.WinForms.Guna2Button();
            this.guna2Panel1 = new Guna.UI2.WinForms.Guna2Panel();
            this.cbOP = new Guna.UI2.WinForms.Guna2ComboBox();
            this.btFind = new Guna.UI2.WinForms.Guna2Button();
            this.txtFind = new Guna.UI2.WinForms.Guna2TextBox();
            this.guna2DragControl1 = new Guna.UI2.WinForms.Guna2DragControl(this.components);
            this.hóaĐơnBánHàngBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.hóa_đơn_bán_hàngTableAdapter = new GUI.DataSet1TableAdapters.Hóa_đơn_bán_hàngTableAdapter();
            this.guna2CustomGradientPanel1.SuspendLayout();
            this.guna2CustomGradientPanel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dtList)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.hóaĐơnBánHàngBindingSource1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataSet1)).BeginInit();
            this.guna2Panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.hóaĐơnBánHàngBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // guna2CustomGradientPanel1
            // 
            this.guna2CustomGradientPanel1.Controls.Add(this.guna2CustomGradientPanel2);
            this.guna2CustomGradientPanel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.guna2CustomGradientPanel1.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(149)))), ((int)(((byte)(67)))), ((int)(((byte)(167)))));
            this.guna2CustomGradientPanel1.FillColor2 = System.Drawing.Color.FromArgb(((int)(((byte)(227)))), ((int)(((byte)(80)))), ((int)(((byte)(168)))));
            this.guna2CustomGradientPanel1.FillColor3 = System.Drawing.Color.FromArgb(((int)(((byte)(227)))), ((int)(((byte)(80)))), ((int)(((byte)(168)))));
            this.guna2CustomGradientPanel1.FillColor4 = System.Drawing.Color.FromArgb(((int)(((byte)(184)))), ((int)(((byte)(213)))), ((int)(((byte)(234)))));
            this.guna2CustomGradientPanel1.Location = new System.Drawing.Point(0, 0);
            this.guna2CustomGradientPanel1.Name = "guna2CustomGradientPanel1";
            this.guna2CustomGradientPanel1.Size = new System.Drawing.Size(750, 670);
            this.guna2CustomGradientPanel1.TabIndex = 0;
            // 
            // guna2CustomGradientPanel2
            // 
            this.guna2CustomGradientPanel2.Controls.Add(this.dtList);
            this.guna2CustomGradientPanel2.Controls.Add(this.btThem);
            this.guna2CustomGradientPanel2.Controls.Add(this.guna2Panel1);
            this.guna2CustomGradientPanel2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.guna2CustomGradientPanel2.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(149)))), ((int)(((byte)(67)))), ((int)(((byte)(167)))));
            this.guna2CustomGradientPanel2.FillColor2 = System.Drawing.Color.FromArgb(((int)(((byte)(227)))), ((int)(((byte)(80)))), ((int)(((byte)(168)))));
            this.guna2CustomGradientPanel2.FillColor3 = System.Drawing.Color.FromArgb(((int)(((byte)(227)))), ((int)(((byte)(80)))), ((int)(((byte)(168)))));
            this.guna2CustomGradientPanel2.FillColor4 = System.Drawing.Color.FromArgb(((int)(((byte)(184)))), ((int)(((byte)(213)))), ((int)(((byte)(234)))));
            this.guna2CustomGradientPanel2.Location = new System.Drawing.Point(0, 0);
            this.guna2CustomGradientPanel2.Name = "guna2CustomGradientPanel2";
            this.guna2CustomGradientPanel2.Size = new System.Drawing.Size(750, 670);
            this.guna2CustomGradientPanel2.TabIndex = 2;
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
            this.mãHóaĐơnDataGridViewTextBoxColumn,
            this.mãKháchHàngDataGridViewTextBoxColumn,
            this.mãGiàyDataGridViewTextBoxColumn,
            this.sốLượngDataGridViewTextBoxColumn});
            this.dtList.DataSource = this.hóaĐơnBánHàngBindingSource1;
            dataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle3.BackColor = System.Drawing.Color.White;
            dataGridViewCellStyle3.Font = new System.Drawing.Font("Segoe UI Semibold", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle3.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(71)))), ((int)(((byte)(69)))), ((int)(((byte)(94)))));
            dataGridViewCellStyle3.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(231)))), ((int)(((byte)(229)))), ((int)(((byte)(255)))));
            dataGridViewCellStyle3.SelectionForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(71)))), ((int)(((byte)(69)))), ((int)(((byte)(94)))));
            dataGridViewCellStyle3.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.dtList.DefaultCellStyle = dataGridViewCellStyle3;
            this.dtList.GridColor = System.Drawing.Color.FromArgb(((int)(((byte)(231)))), ((int)(((byte)(229)))), ((int)(((byte)(255)))));
            this.dtList.Location = new System.Drawing.Point(57, 111);
            this.dtList.Name = "dtList";
            this.dtList.ReadOnly = true;
            this.dtList.RowHeadersVisible = false;
            this.dtList.RowHeadersWidth = 51;
            this.dtList.Size = new System.Drawing.Size(637, 399);
            this.dtList.TabIndex = 3;
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
            // 
            // mãHóaĐơnDataGridViewTextBoxColumn
            // 
            this.mãHóaĐơnDataGridViewTextBoxColumn.DataPropertyName = "Mã hóa đơn";
            this.mãHóaĐơnDataGridViewTextBoxColumn.HeaderText = "Mã hóa đơn";
            this.mãHóaĐơnDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.mãHóaĐơnDataGridViewTextBoxColumn.Name = "mãHóaĐơnDataGridViewTextBoxColumn";
            this.mãHóaĐơnDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // mãKháchHàngDataGridViewTextBoxColumn
            // 
            this.mãKháchHàngDataGridViewTextBoxColumn.DataPropertyName = "Mã khách hàng";
            this.mãKháchHàngDataGridViewTextBoxColumn.HeaderText = "Mã khách hàng";
            this.mãKháchHàngDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.mãKháchHàngDataGridViewTextBoxColumn.Name = "mãKháchHàngDataGridViewTextBoxColumn";
            this.mãKháchHàngDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // mãGiàyDataGridViewTextBoxColumn
            // 
            this.mãGiàyDataGridViewTextBoxColumn.DataPropertyName = "Mã giày";
            this.mãGiàyDataGridViewTextBoxColumn.HeaderText = "Mã giày";
            this.mãGiàyDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.mãGiàyDataGridViewTextBoxColumn.Name = "mãGiàyDataGridViewTextBoxColumn";
            this.mãGiàyDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // sốLượngDataGridViewTextBoxColumn
            // 
            this.sốLượngDataGridViewTextBoxColumn.DataPropertyName = "Số lượng";
            this.sốLượngDataGridViewTextBoxColumn.HeaderText = "Số lượng";
            this.sốLượngDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.sốLượngDataGridViewTextBoxColumn.Name = "sốLượngDataGridViewTextBoxColumn";
            this.sốLượngDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // hóaĐơnBánHàngBindingSource1
            // 
            this.hóaĐơnBánHàngBindingSource1.DataMember = "Hóa đơn bán hàng";
            this.hóaĐơnBánHàngBindingSource1.DataSource = this.dataSet1;
            // 
            // dataSet1
            // 
            this.dataSet1.DataSetName = "DataSet1";
            this.dataSet1.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // btThem
            // 
            this.btThem.Animated = true;
            this.btThem.BackColor = System.Drawing.Color.Transparent;
            this.btThem.BorderRadius = 8;
            this.btThem.CheckedState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(184)))), ((int)(((byte)(213)))), ((int)(((byte)(234)))));
            this.btThem.CheckedState.Font = new System.Drawing.Font("Segoe UI Semibold", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btThem.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.btThem.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.btThem.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.btThem.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.btThem.Font = new System.Drawing.Font("Segoe UI Semibold", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btThem.ForeColor = System.Drawing.Color.White;
            this.btThem.HoverState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(227)))), ((int)(((byte)(80)))), ((int)(((byte)(168)))));
            this.btThem.HoverState.Font = new System.Drawing.Font("Segoe UI Semibold", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btThem.Location = new System.Drawing.Point(574, 584);
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
            this.guna2Panel1.Controls.Add(this.btFind);
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
            this.cbOP.Location = new System.Drawing.Point(279, 8);
            this.cbOP.Name = "cbOP";
            this.cbOP.Size = new System.Drawing.Size(150, 36);
            this.cbOP.TabIndex = 2;
            // 
            // btFind
            // 
            this.btFind.Animated = true;
            this.btFind.AutoRoundedCorners = true;
            this.btFind.BorderRadius = 14;
            this.btFind.CheckedState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(184)))), ((int)(((byte)(213)))), ((int)(((byte)(234)))));
            this.btFind.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.btFind.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.btFind.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.btFind.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.btFind.Font = new System.Drawing.Font("Segoe UI Semibold", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btFind.ForeColor = System.Drawing.Color.White;
            this.btFind.HoverState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(227)))), ((int)(((byte)(80)))), ((int)(((byte)(168)))));
            this.btFind.HoverState.Font = new System.Drawing.Font("Segoe UI Semibold", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btFind.Location = new System.Drawing.Point(594, 13);
            this.btFind.Name = "btFind";
            this.btFind.Size = new System.Drawing.Size(100, 30);
            this.btFind.TabIndex = 1;
            this.btFind.Text = "Tìm kiếm";
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
            this.txtFind.Location = new System.Drawing.Point(435, 13);
            this.txtFind.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.txtFind.Name = "txtFind";
            this.txtFind.PasswordChar = '\0';
            this.txtFind.PlaceholderText = "";
            this.txtFind.SelectedText = "";
            this.txtFind.Size = new System.Drawing.Size(150, 30);
            this.txtFind.TabIndex = 0;
            // 
            // guna2DragControl1
            // 
            this.guna2DragControl1.DockIndicatorTransparencyValue = 0.6D;
            this.guna2DragControl1.UseTransparentDrag = true;
            // 
            // hóaĐơnBánHàngBindingSource
            // 
            this.hóaĐơnBánHàngBindingSource.DataMember = "Hóa đơn bán hàng";
            this.hóaĐơnBánHàngBindingSource.DataSource = this.dataSet1;
            // 
            // hóa_đơn_bán_hàngTableAdapter
            // 
            this.hóa_đơn_bán_hàngTableAdapter.ClearBeforeFill = true;
            // 
            // formHDBanGiay
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(10F, 23F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoSize = true;
            this.ClientSize = new System.Drawing.Size(750, 670);
            this.Controls.Add(this.guna2CustomGradientPanel1);
            this.Font = new System.Drawing.Font("Segoe UI Semibold", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Margin = new System.Windows.Forms.Padding(5);
            this.Name = "formHDBanGiay";
            this.Text = "formHDBanGiay";
            this.Load += new System.EventHandler(this.formHDBanGiay_Load);
            this.guna2CustomGradientPanel1.ResumeLayout(false);
            this.guna2CustomGradientPanel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dtList)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.hóaĐơnBánHàngBindingSource1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataSet1)).EndInit();
            this.guna2Panel1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.hóaĐơnBánHàngBindingSource)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private Guna.UI2.WinForms.Guna2CustomGradientPanel guna2CustomGradientPanel1;
        private Guna.UI2.WinForms.Guna2CustomGradientPanel guna2CustomGradientPanel2;
        private Guna.UI2.WinForms.Guna2Button btThem;
        private Guna.UI2.WinForms.Guna2Panel guna2Panel1;
        private Guna.UI2.WinForms.Guna2ComboBox cbOP;
        private Guna.UI2.WinForms.Guna2Button btFind;
        private Guna.UI2.WinForms.Guna2TextBox txtFind;
        private Guna.UI2.WinForms.Guna2DragControl guna2DragControl1;
        private DataSet1 dataSet1;
        private System.Windows.Forms.BindingSource hóaĐơnBánHàngBindingSource;
        private DataSet1TableAdapters.Hóa_đơn_bán_hàngTableAdapter hóa_đơn_bán_hàngTableAdapter;
        private Guna.UI2.WinForms.Guna2DataGridView dtList;
        private System.Windows.Forms.DataGridViewTextBoxColumn mãHóaĐơnDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn mãKháchHàngDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn mãGiàyDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn sốLượngDataGridViewTextBoxColumn;
        private System.Windows.Forms.BindingSource hóaĐơnBánHàngBindingSource1;
    }
}