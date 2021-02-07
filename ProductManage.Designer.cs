
namespace quanlykho
{
    partial class ProductManage
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle3 = new System.Windows.Forms.DataGridViewCellStyle();
            this.panel1 = new System.Windows.Forms.Panel();
            this.label6 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.splitContainer1 = new System.Windows.Forms.SplitContainer();
            this.ProductGV = new Guna.UI2.WinForms.Guna2DataGridView();
            this.label3 = new System.Windows.Forms.Label();
            this.btnClear = new Guna.UI2.WinForms.Guna2Button();
            this.QtyProdcutTb = new Guna.UI2.WinForms.Guna2TextBox();
            this.ProductPriceTb = new Guna.UI2.WinForms.Guna2TextBox();
            this.btnHome = new Guna.UI2.WinForms.Guna2Button();
            this.btnDelete = new Guna.UI2.WinForms.Guna2Button();
            this.btnEdit = new Guna.UI2.WinForms.Guna2Button();
            this.btnAdd = new Guna.UI2.WinForms.Guna2Button();
            this.ProductNameTb = new Guna.UI2.WinForms.Guna2TextBox();
            this.ProductTbId = new Guna.UI2.WinForms.Guna2TextBox();
            this.cbCat = new Guna.UI2.WinForms.Guna2ComboBox();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer1)).BeginInit();
            this.splitContainer1.Panel1.SuspendLayout();
            this.splitContainer1.Panel2.SuspendLayout();
            this.splitContainer1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.ProductGV)).BeginInit();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.Crimson;
            this.panel1.Controls.Add(this.label6);
            this.panel1.Controls.Add(this.label5);
            this.panel1.Controls.Add(this.label4);
            this.panel1.Controls.Add(this.label2);
            this.panel1.Controls.Add(this.label1);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel1.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.panel1.ForeColor = System.Drawing.Color.LavenderBlush;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(902, 67);
            this.panel1.TabIndex = 2;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.Location = new System.Drawing.Point(871, 3);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(31, 29);
            this.label6.TabIndex = 4;
            this.label6.Text = "X";
            this.label6.Click += new System.EventHandler(this.label6_Click);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(899, 3);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(31, 29);
            this.label5.TabIndex = 3;
            this.label5.Text = "X";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(953, 3);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(35, 32);
            this.label4.TabIndex = 2;
            this.label4.Text = "X";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(370, 32);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(203, 29);
            this.label2.TabIndex = 1;
            this.label2.Text = "Manage Product";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(269, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(432, 32);
            this.label1.TabIndex = 0;
            this.label1.Text = "Inventory Management System";
            // 
            // splitContainer1
            // 
            this.splitContainer1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.splitContainer1.Location = new System.Drawing.Point(0, 67);
            this.splitContainer1.Name = "splitContainer1";
            // 
            // splitContainer1.Panel1
            // 
            this.splitContainer1.Panel1.Controls.Add(this.cbCat);
            this.splitContainer1.Panel1.Controls.Add(this.btnClear);
            this.splitContainer1.Panel1.Controls.Add(this.QtyProdcutTb);
            this.splitContainer1.Panel1.Controls.Add(this.ProductPriceTb);
            this.splitContainer1.Panel1.Controls.Add(this.btnHome);
            this.splitContainer1.Panel1.Controls.Add(this.btnDelete);
            this.splitContainer1.Panel1.Controls.Add(this.btnEdit);
            this.splitContainer1.Panel1.Controls.Add(this.btnAdd);
            this.splitContainer1.Panel1.Controls.Add(this.ProductNameTb);
            this.splitContainer1.Panel1.Controls.Add(this.ProductTbId);
            // 
            // splitContainer1.Panel2
            // 
            this.splitContainer1.Panel2.Controls.Add(this.ProductGV);
            this.splitContainer1.Panel2.Controls.Add(this.label3);
            this.splitContainer1.Size = new System.Drawing.Size(902, 435);
            this.splitContainer1.SplitterDistance = 349;
            this.splitContainer1.TabIndex = 3;
            // 
            // ProductGV
            // 
            dataGridViewCellStyle1.BackColor = System.Drawing.Color.White;
            this.ProductGV.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle1;
            this.ProductGV.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.ProductGV.BackgroundColor = System.Drawing.Color.White;
            this.ProductGV.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.ProductGV.CellBorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.SingleHorizontal;
            this.ProductGV.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(100)))), ((int)(((byte)(88)))), ((int)(((byte)(255)))));
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle2.ForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.ProductGV.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle2;
            this.ProductGV.ColumnHeadersHeight = 20;
            dataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle3.BackColor = System.Drawing.Color.White;
            dataGridViewCellStyle3.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle3.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(71)))), ((int)(((byte)(69)))), ((int)(((byte)(94)))));
            dataGridViewCellStyle3.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(231)))), ((int)(((byte)(229)))), ((int)(((byte)(255)))));
            dataGridViewCellStyle3.SelectionForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(71)))), ((int)(((byte)(69)))), ((int)(((byte)(94)))));
            dataGridViewCellStyle3.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.ProductGV.DefaultCellStyle = dataGridViewCellStyle3;
            this.ProductGV.EnableHeadersVisualStyles = false;
            this.ProductGV.GridColor = System.Drawing.Color.FromArgb(((int)(((byte)(231)))), ((int)(((byte)(229)))), ((int)(((byte)(255)))));
            this.ProductGV.Location = new System.Drawing.Point(21, 82);
            this.ProductGV.Name = "ProductGV";
            this.ProductGV.RowHeadersVisible = false;
            this.ProductGV.RowHeadersWidth = 62;
            this.ProductGV.RowTemplate.Height = 28;
            this.ProductGV.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.ProductGV.Size = new System.Drawing.Size(516, 319);
            this.ProductGV.TabIndex = 5;
            this.ProductGV.Theme = Guna.UI2.WinForms.Enums.DataGridViewPresetThemes.Default;
            this.ProductGV.ThemeStyle.AlternatingRowsStyle.BackColor = System.Drawing.Color.White;
            this.ProductGV.ThemeStyle.AlternatingRowsStyle.Font = null;
            this.ProductGV.ThemeStyle.AlternatingRowsStyle.ForeColor = System.Drawing.Color.Empty;
            this.ProductGV.ThemeStyle.AlternatingRowsStyle.SelectionBackColor = System.Drawing.Color.Empty;
            this.ProductGV.ThemeStyle.AlternatingRowsStyle.SelectionForeColor = System.Drawing.Color.Empty;
            this.ProductGV.ThemeStyle.BackColor = System.Drawing.Color.White;
            this.ProductGV.ThemeStyle.GridColor = System.Drawing.Color.FromArgb(((int)(((byte)(231)))), ((int)(((byte)(229)))), ((int)(((byte)(255)))));
            this.ProductGV.ThemeStyle.HeaderStyle.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(100)))), ((int)(((byte)(88)))), ((int)(((byte)(255)))));
            this.ProductGV.ThemeStyle.HeaderStyle.BorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            this.ProductGV.ThemeStyle.HeaderStyle.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ProductGV.ThemeStyle.HeaderStyle.ForeColor = System.Drawing.Color.White;
            this.ProductGV.ThemeStyle.HeaderStyle.HeaightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.EnableResizing;
            this.ProductGV.ThemeStyle.HeaderStyle.Height = 20;
            this.ProductGV.ThemeStyle.ReadOnly = false;
            this.ProductGV.ThemeStyle.RowsStyle.BackColor = System.Drawing.Color.White;
            this.ProductGV.ThemeStyle.RowsStyle.BorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.SingleHorizontal;
            this.ProductGV.ThemeStyle.RowsStyle.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ProductGV.ThemeStyle.RowsStyle.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(71)))), ((int)(((byte)(69)))), ((int)(((byte)(94)))));
            this.ProductGV.ThemeStyle.RowsStyle.Height = 28;
            this.ProductGV.ThemeStyle.RowsStyle.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(231)))), ((int)(((byte)(229)))), ((int)(((byte)(255)))));
            this.ProductGV.ThemeStyle.RowsStyle.SelectionForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(71)))), ((int)(((byte)(69)))), ((int)(((byte)(94)))));
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.BackColor = System.Drawing.Color.Transparent;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.ForeColor = System.Drawing.Color.Crimson;
            this.label3.Location = new System.Drawing.Point(202, 19);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(151, 29);
            this.label3.TabIndex = 4;
            this.label3.Text = "Product List";
            // 
            // btnClear
            // 
            this.btnClear.CheckedState.Parent = this.btnClear;
            this.btnClear.CustomImages.Parent = this.btnClear;
            this.btnClear.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.btnClear.ForeColor = System.Drawing.Color.White;
            this.btnClear.HoverState.Parent = this.btnClear;
            this.btnClear.Location = new System.Drawing.Point(60, 384);
            this.btnClear.Name = "btnClear";
            this.btnClear.ShadowDecoration.Parent = this.btnClear;
            this.btnClear.Size = new System.Drawing.Size(96, 35);
            this.btnClear.TabIndex = 26;
            this.btnClear.Text = "Clear";
            // 
            // QtyProdcutTb
            // 
            this.QtyProdcutTb.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.QtyProdcutTb.DefaultText = "";
            this.QtyProdcutTb.DisabledState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(208)))), ((int)(((byte)(208)))));
            this.QtyProdcutTb.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(226)))), ((int)(((byte)(226)))), ((int)(((byte)(226)))));
            this.QtyProdcutTb.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.QtyProdcutTb.DisabledState.Parent = this.QtyProdcutTb;
            this.QtyProdcutTb.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.QtyProdcutTb.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.QtyProdcutTb.FocusedState.Parent = this.QtyProdcutTb;
            this.QtyProdcutTb.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold);
            this.QtyProdcutTb.HoverState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.QtyProdcutTb.HoverState.Parent = this.QtyProdcutTb;
            this.QtyProdcutTb.Location = new System.Drawing.Point(12, 209);
            this.QtyProdcutTb.Name = "QtyProdcutTb";
            this.QtyProdcutTb.PasswordChar = '\0';
            this.QtyProdcutTb.PlaceholderForeColor = System.Drawing.Color.OrangeRed;
            this.QtyProdcutTb.PlaceholderText = "Quantity";
            this.QtyProdcutTb.SelectedText = "";
            this.QtyProdcutTb.ShadowDecoration.Parent = this.QtyProdcutTb;
            this.QtyProdcutTb.Size = new System.Drawing.Size(220, 36);
            this.QtyProdcutTb.TabIndex = 25;
            // 
            // ProductPriceTb
            // 
            this.ProductPriceTb.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.ProductPriceTb.DefaultText = "";
            this.ProductPriceTb.DisabledState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(208)))), ((int)(((byte)(208)))));
            this.ProductPriceTb.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(226)))), ((int)(((byte)(226)))), ((int)(((byte)(226)))));
            this.ProductPriceTb.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.ProductPriceTb.DisabledState.Parent = this.ProductPriceTb;
            this.ProductPriceTb.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.ProductPriceTb.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.ProductPriceTb.FocusedState.Parent = this.ProductPriceTb;
            this.ProductPriceTb.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold);
            this.ProductPriceTb.HoverState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.ProductPriceTb.HoverState.Parent = this.ProductPriceTb;
            this.ProductPriceTb.Location = new System.Drawing.Point(12, 153);
            this.ProductPriceTb.Name = "ProductPriceTb";
            this.ProductPriceTb.PasswordChar = '\0';
            this.ProductPriceTb.PlaceholderForeColor = System.Drawing.Color.OrangeRed;
            this.ProductPriceTb.PlaceholderText = "Product Price";
            this.ProductPriceTb.SelectedText = "";
            this.ProductPriceTb.ShadowDecoration.Parent = this.ProductPriceTb;
            this.ProductPriceTb.Size = new System.Drawing.Size(220, 36);
            this.ProductPriceTb.TabIndex = 24;
            // 
            // btnHome
            // 
            this.btnHome.CheckedState.Parent = this.btnHome;
            this.btnHome.CustomImages.Parent = this.btnHome;
            this.btnHome.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.btnHome.ForeColor = System.Drawing.Color.White;
            this.btnHome.HoverState.Parent = this.btnHome;
            this.btnHome.Location = new System.Drawing.Point(180, 384);
            this.btnHome.Name = "btnHome";
            this.btnHome.ShadowDecoration.Parent = this.btnHome;
            this.btnHome.Size = new System.Drawing.Size(96, 35);
            this.btnHome.TabIndex = 23;
            this.btnHome.Text = "Home";
            // 
            // btnDelete
            // 
            this.btnDelete.CheckedState.Parent = this.btnDelete;
            this.btnDelete.CustomImages.Parent = this.btnDelete;
            this.btnDelete.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.btnDelete.ForeColor = System.Drawing.Color.White;
            this.btnDelete.HoverState.Parent = this.btnDelete;
            this.btnDelete.Location = new System.Drawing.Point(234, 330);
            this.btnDelete.Name = "btnDelete";
            this.btnDelete.ShadowDecoration.Parent = this.btnDelete;
            this.btnDelete.Size = new System.Drawing.Size(96, 35);
            this.btnDelete.TabIndex = 22;
            this.btnDelete.Text = "Delete";
            this.btnDelete.Click += new System.EventHandler(this.btnDelete_Click);
            // 
            // btnEdit
            // 
            this.btnEdit.CheckedState.Parent = this.btnEdit;
            this.btnEdit.CustomImages.Parent = this.btnEdit;
            this.btnEdit.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.btnEdit.ForeColor = System.Drawing.Color.White;
            this.btnEdit.HoverState.Parent = this.btnEdit;
            this.btnEdit.Location = new System.Drawing.Point(132, 330);
            this.btnEdit.Name = "btnEdit";
            this.btnEdit.ShadowDecoration.Parent = this.btnEdit;
            this.btnEdit.Size = new System.Drawing.Size(96, 35);
            this.btnEdit.TabIndex = 21;
            this.btnEdit.Text = "Edit";
            this.btnEdit.Click += new System.EventHandler(this.btnEdit_Click);
            // 
            // btnAdd
            // 
            this.btnAdd.CheckedState.Parent = this.btnAdd;
            this.btnAdd.CustomImages.Parent = this.btnAdd;
            this.btnAdd.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.btnAdd.ForeColor = System.Drawing.Color.White;
            this.btnAdd.HoverState.Parent = this.btnAdd;
            this.btnAdd.Location = new System.Drawing.Point(9, 328);
            this.btnAdd.Name = "btnAdd";
            this.btnAdd.ShadowDecoration.Parent = this.btnAdd;
            this.btnAdd.Size = new System.Drawing.Size(96, 35);
            this.btnAdd.TabIndex = 18;
            this.btnAdd.Text = "Add";
            this.btnAdd.Click += new System.EventHandler(this.btnAdd_Click);
            // 
            // ProductNameTb
            // 
            this.ProductNameTb.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.ProductNameTb.DefaultText = "";
            this.ProductNameTb.DisabledState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(208)))), ((int)(((byte)(208)))));
            this.ProductNameTb.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(226)))), ((int)(((byte)(226)))), ((int)(((byte)(226)))));
            this.ProductNameTb.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.ProductNameTb.DisabledState.Parent = this.ProductNameTb;
            this.ProductNameTb.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.ProductNameTb.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.ProductNameTb.FocusedState.Parent = this.ProductNameTb;
            this.ProductNameTb.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold);
            this.ProductNameTb.HoverState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.ProductNameTb.HoverState.Parent = this.ProductNameTb;
            this.ProductNameTb.Location = new System.Drawing.Point(12, 95);
            this.ProductNameTb.Name = "ProductNameTb";
            this.ProductNameTb.PasswordChar = '\0';
            this.ProductNameTb.PlaceholderForeColor = System.Drawing.Color.OrangeRed;
            this.ProductNameTb.PlaceholderText = "Product Name";
            this.ProductNameTb.SelectedText = "";
            this.ProductNameTb.ShadowDecoration.Parent = this.ProductNameTb;
            this.ProductNameTb.Size = new System.Drawing.Size(220, 36);
            this.ProductNameTb.TabIndex = 20;
            // 
            // ProductTbId
            // 
            this.ProductTbId.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.ProductTbId.DefaultText = "";
            this.ProductTbId.DisabledState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(208)))), ((int)(((byte)(208)))));
            this.ProductTbId.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(226)))), ((int)(((byte)(226)))), ((int)(((byte)(226)))));
            this.ProductTbId.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.ProductTbId.DisabledState.Parent = this.ProductTbId;
            this.ProductTbId.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.ProductTbId.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.ProductTbId.FocusedState.Parent = this.ProductTbId;
            this.ProductTbId.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold);
            this.ProductTbId.HoverState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.ProductTbId.HoverState.Parent = this.ProductTbId;
            this.ProductTbId.Location = new System.Drawing.Point(12, 31);
            this.ProductTbId.Name = "ProductTbId";
            this.ProductTbId.PasswordChar = '\0';
            this.ProductTbId.PlaceholderForeColor = System.Drawing.Color.OrangeRed;
            this.ProductTbId.PlaceholderText = "ID Product";
            this.ProductTbId.ReadOnly = true;
            this.ProductTbId.SelectedText = "";
            this.ProductTbId.ShadowDecoration.Parent = this.ProductTbId;
            this.ProductTbId.Size = new System.Drawing.Size(220, 36);
            this.ProductTbId.TabIndex = 19;
            this.ProductTbId.TextChanged += new System.EventHandler(this.ProductTbId_TextChanged);
            // 
            // cbCat
            // 
            this.cbCat.BackColor = System.Drawing.Color.Transparent;
            this.cbCat.DrawMode = System.Windows.Forms.DrawMode.OwnerDrawFixed;
            this.cbCat.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbCat.FocusedColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.cbCat.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.cbCat.FocusedState.Parent = this.cbCat;
            this.cbCat.Font = new System.Drawing.Font("Segoe UI", 10F);
            this.cbCat.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(68)))), ((int)(((byte)(88)))), ((int)(((byte)(112)))));
            this.cbCat.HoverState.Parent = this.cbCat;
            this.cbCat.ItemHeight = 30;
            this.cbCat.ItemsAppearance.Parent = this.cbCat;
            this.cbCat.Location = new System.Drawing.Point(12, 271);
            this.cbCat.Name = "cbCat";
            this.cbCat.ShadowDecoration.Parent = this.cbCat;
            this.cbCat.Size = new System.Drawing.Size(220, 36);
            this.cbCat.TabIndex = 27;
            // 
            // ProductManage
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(10F, 22F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(902, 502);
            this.Controls.Add(this.splitContainer1);
            this.Controls.Add(this.panel1);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "ProductManage";
            this.Text = "Quản lý sản phẩm";
            this.Load += new System.EventHandler(this.ProductManage_Load);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.splitContainer1.Panel1.ResumeLayout(false);
            this.splitContainer1.Panel2.ResumeLayout(false);
            this.splitContainer1.Panel2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer1)).EndInit();
            this.splitContainer1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.ProductGV)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.SplitContainer splitContainer1;
        private System.Windows.Forms.Label label3;
        private Guna.UI2.WinForms.Guna2DataGridView ProductGV;
        private System.Windows.Forms.Label label6;
        private Guna.UI2.WinForms.Guna2Button btnClear;
        private Guna.UI2.WinForms.Guna2TextBox QtyProdcutTb;
        private Guna.UI2.WinForms.Guna2TextBox ProductPriceTb;
        private Guna.UI2.WinForms.Guna2Button btnHome;
        private Guna.UI2.WinForms.Guna2Button btnDelete;
        private Guna.UI2.WinForms.Guna2Button btnEdit;
        private Guna.UI2.WinForms.Guna2Button btnAdd;
        private Guna.UI2.WinForms.Guna2TextBox ProductNameTb;
        private Guna.UI2.WinForms.Guna2TextBox ProductTbId;
        private Guna.UI2.WinForms.Guna2ComboBox cbCat;
    }
}