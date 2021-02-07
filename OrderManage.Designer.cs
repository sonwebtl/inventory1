
namespace quanlykho
{
    partial class OrderManage
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle4 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle5 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle6 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle7 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle8 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle9 = new System.Windows.Forms.DataGridViewCellStyle();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(OrderManage));
            this.panel1 = new System.Windows.Forms.Panel();
            this.label4 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.ProductGV = new Guna.UI2.WinForms.Guna2DataGridView();
            this.CustomerGV = new Guna.UI2.WinForms.Guna2DataGridView();
            this.label5 = new System.Windows.Forms.Label();
            this.btnAddOrder = new Guna.UI2.WinForms.Guna2Button();
            this.OrderGv = new Guna.UI2.WinForms.Guna2DataGridView();
            this.label6 = new System.Windows.Forms.Label();
            this.lbTotal = new System.Windows.Forms.Label();
            this.CustomerIdTb = new Guna.UI2.WinForms.Guna2TextBox();
            this.label9 = new System.Windows.Forms.Label();
            this.OrderDatedtpk = new Guna.UI2.WinForms.Guna2DateTimePicker();
            this.nmQty = new Guna.UI2.WinForms.Guna2NumericUpDown();
            this.InsertOderBtn = new Guna.UI2.WinForms.Guna2Button();
            this.ViewOrderBtn = new Guna.UI2.WinForms.Guna2Button();
            this.ProductIdTb = new Guna.UI2.WinForms.Guna2TextBox();
            this.totalPriceTb = new Guna.UI2.WinForms.Guna2TextBox();
            this.printPreviewDialog1 = new System.Windows.Forms.PrintPreviewDialog();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.ProductGV)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.CustomerGV)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.OrderGv)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.nmQty)).BeginInit();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.Crimson;
            this.panel1.Controls.Add(this.label4);
            this.panel1.Controls.Add(this.label2);
            this.panel1.Controls.Add(this.label1);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel1.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.panel1.ForeColor = System.Drawing.Color.LavenderBlush;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(1087, 67);
            this.panel1.TabIndex = 3;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(1040, 9);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(35, 32);
            this.label4.TabIndex = 2;
            this.label4.Text = "X";
            this.label4.Click += new System.EventHandler(this.label4_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(370, 32);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(181, 29);
            this.label2.TabIndex = 1;
            this.label2.Text = "Manage Order";
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
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.BackColor = System.Drawing.Color.Transparent;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.ForeColor = System.Drawing.Color.Crimson;
            this.label3.Location = new System.Drawing.Point(43, 70);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(173, 29);
            this.label3.TabIndex = 4;
            this.label3.Text = "Customer List";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.BackColor = System.Drawing.Color.Transparent;
            this.label7.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.ForeColor = System.Drawing.Color.Crimson;
            this.label7.Location = new System.Drawing.Point(629, 70);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(151, 29);
            this.label7.TabIndex = 5;
            this.label7.Text = "Product List";
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
            this.ProductGV.Location = new System.Drawing.Point(505, 102);
            this.ProductGV.Name = "ProductGV";
            this.ProductGV.RowHeadersVisible = false;
            this.ProductGV.RowHeadersWidth = 62;
            this.ProductGV.RowTemplate.Height = 28;
            this.ProductGV.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.ProductGV.Size = new System.Drawing.Size(556, 254);
            this.ProductGV.TabIndex = 6;
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
            this.ProductGV.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.ProductGV_CellContentClick);
            // 
            // CustomerGV
            // 
            dataGridViewCellStyle4.BackColor = System.Drawing.Color.White;
            this.CustomerGV.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle4;
            this.CustomerGV.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.CustomerGV.BackgroundColor = System.Drawing.Color.White;
            this.CustomerGV.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.CustomerGV.CellBorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.SingleHorizontal;
            this.CustomerGV.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            dataGridViewCellStyle5.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle5.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(100)))), ((int)(((byte)(88)))), ((int)(((byte)(255)))));
            dataGridViewCellStyle5.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle5.ForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle5.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle5.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle5.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.CustomerGV.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle5;
            this.CustomerGV.ColumnHeadersHeight = 20;
            dataGridViewCellStyle6.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle6.BackColor = System.Drawing.Color.White;
            dataGridViewCellStyle6.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle6.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(71)))), ((int)(((byte)(69)))), ((int)(((byte)(94)))));
            dataGridViewCellStyle6.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(231)))), ((int)(((byte)(229)))), ((int)(((byte)(255)))));
            dataGridViewCellStyle6.SelectionForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(71)))), ((int)(((byte)(69)))), ((int)(((byte)(94)))));
            dataGridViewCellStyle6.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.CustomerGV.DefaultCellStyle = dataGridViewCellStyle6;
            this.CustomerGV.EnableHeadersVisualStyles = false;
            this.CustomerGV.GridColor = System.Drawing.Color.FromArgb(((int)(((byte)(231)))), ((int)(((byte)(229)))), ((int)(((byte)(255)))));
            this.CustomerGV.Location = new System.Drawing.Point(26, 102);
            this.CustomerGV.Name = "CustomerGV";
            this.CustomerGV.RowHeadersVisible = false;
            this.CustomerGV.RowHeadersWidth = 62;
            this.CustomerGV.RowTemplate.Height = 28;
            this.CustomerGV.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.CustomerGV.Size = new System.Drawing.Size(456, 254);
            this.CustomerGV.TabIndex = 7;
            this.CustomerGV.Theme = Guna.UI2.WinForms.Enums.DataGridViewPresetThemes.Default;
            this.CustomerGV.ThemeStyle.AlternatingRowsStyle.BackColor = System.Drawing.Color.White;
            this.CustomerGV.ThemeStyle.AlternatingRowsStyle.Font = null;
            this.CustomerGV.ThemeStyle.AlternatingRowsStyle.ForeColor = System.Drawing.Color.Empty;
            this.CustomerGV.ThemeStyle.AlternatingRowsStyle.SelectionBackColor = System.Drawing.Color.Empty;
            this.CustomerGV.ThemeStyle.AlternatingRowsStyle.SelectionForeColor = System.Drawing.Color.Empty;
            this.CustomerGV.ThemeStyle.BackColor = System.Drawing.Color.White;
            this.CustomerGV.ThemeStyle.GridColor = System.Drawing.Color.FromArgb(((int)(((byte)(231)))), ((int)(((byte)(229)))), ((int)(((byte)(255)))));
            this.CustomerGV.ThemeStyle.HeaderStyle.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(100)))), ((int)(((byte)(88)))), ((int)(((byte)(255)))));
            this.CustomerGV.ThemeStyle.HeaderStyle.BorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            this.CustomerGV.ThemeStyle.HeaderStyle.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.CustomerGV.ThemeStyle.HeaderStyle.ForeColor = System.Drawing.Color.White;
            this.CustomerGV.ThemeStyle.HeaderStyle.HeaightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.EnableResizing;
            this.CustomerGV.ThemeStyle.HeaderStyle.Height = 20;
            this.CustomerGV.ThemeStyle.ReadOnly = false;
            this.CustomerGV.ThemeStyle.RowsStyle.BackColor = System.Drawing.Color.White;
            this.CustomerGV.ThemeStyle.RowsStyle.BorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.SingleHorizontal;
            this.CustomerGV.ThemeStyle.RowsStyle.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.CustomerGV.ThemeStyle.RowsStyle.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(71)))), ((int)(((byte)(69)))), ((int)(((byte)(94)))));
            this.CustomerGV.ThemeStyle.RowsStyle.Height = 28;
            this.CustomerGV.ThemeStyle.RowsStyle.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(231)))), ((int)(((byte)(229)))), ((int)(((byte)(255)))));
            this.CustomerGV.ThemeStyle.RowsStyle.SelectionForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(71)))), ((int)(((byte)(69)))), ((int)(((byte)(94)))));
            this.CustomerGV.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.CustomerGV_CellContentClick);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.BackColor = System.Drawing.Color.Transparent;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.ForeColor = System.Drawing.Color.Crimson;
            this.label5.Location = new System.Drawing.Point(513, 373);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(108, 29);
            this.label5.TabIndex = 8;
            this.label5.Text = "Quantity";
            // 
            // btnAddOrder
            // 
            this.btnAddOrder.CheckedState.Parent = this.btnAddOrder;
            this.btnAddOrder.CustomImages.Parent = this.btnAddOrder;
            this.btnAddOrder.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.btnAddOrder.ForeColor = System.Drawing.Color.White;
            this.btnAddOrder.HoverState.Parent = this.btnAddOrder;
            this.btnAddOrder.Location = new System.Drawing.Point(790, 373);
            this.btnAddOrder.Name = "btnAddOrder";
            this.btnAddOrder.ShadowDecoration.Parent = this.btnAddOrder;
            this.btnAddOrder.Size = new System.Drawing.Size(175, 38);
            this.btnAddOrder.TabIndex = 10;
            this.btnAddOrder.Text = "Add to Order";
            this.btnAddOrder.Click += new System.EventHandler(this.btnAddOrder_Click);
            // 
            // OrderGv
            // 
            dataGridViewCellStyle7.BackColor = System.Drawing.Color.White;
            this.OrderGv.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle7;
            this.OrderGv.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.OrderGv.BackgroundColor = System.Drawing.Color.White;
            this.OrderGv.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.OrderGv.CellBorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.SingleHorizontal;
            this.OrderGv.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            dataGridViewCellStyle8.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle8.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(100)))), ((int)(((byte)(88)))), ((int)(((byte)(255)))));
            dataGridViewCellStyle8.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle8.ForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle8.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle8.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle8.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.OrderGv.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle8;
            this.OrderGv.ColumnHeadersHeight = 20;
            dataGridViewCellStyle9.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle9.BackColor = System.Drawing.Color.White;
            dataGridViewCellStyle9.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle9.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(71)))), ((int)(((byte)(69)))), ((int)(((byte)(94)))));
            dataGridViewCellStyle9.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(231)))), ((int)(((byte)(229)))), ((int)(((byte)(255)))));
            dataGridViewCellStyle9.SelectionForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(71)))), ((int)(((byte)(69)))), ((int)(((byte)(94)))));
            dataGridViewCellStyle9.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.OrderGv.DefaultCellStyle = dataGridViewCellStyle9;
            this.OrderGv.EnableHeadersVisualStyles = false;
            this.OrderGv.GridColor = System.Drawing.Color.FromArgb(((int)(((byte)(231)))), ((int)(((byte)(229)))), ((int)(((byte)(255)))));
            this.OrderGv.Location = new System.Drawing.Point(462, 418);
            this.OrderGv.Name = "OrderGv";
            this.OrderGv.RowHeadersVisible = false;
            this.OrderGv.RowHeadersWidth = 62;
            this.OrderGv.RowTemplate.Height = 28;
            this.OrderGv.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.OrderGv.Size = new System.Drawing.Size(599, 226);
            this.OrderGv.TabIndex = 11;
            this.OrderGv.Theme = Guna.UI2.WinForms.Enums.DataGridViewPresetThemes.Default;
            this.OrderGv.ThemeStyle.AlternatingRowsStyle.BackColor = System.Drawing.Color.White;
            this.OrderGv.ThemeStyle.AlternatingRowsStyle.Font = null;
            this.OrderGv.ThemeStyle.AlternatingRowsStyle.ForeColor = System.Drawing.Color.Empty;
            this.OrderGv.ThemeStyle.AlternatingRowsStyle.SelectionBackColor = System.Drawing.Color.Empty;
            this.OrderGv.ThemeStyle.AlternatingRowsStyle.SelectionForeColor = System.Drawing.Color.Empty;
            this.OrderGv.ThemeStyle.BackColor = System.Drawing.Color.White;
            this.OrderGv.ThemeStyle.GridColor = System.Drawing.Color.FromArgb(((int)(((byte)(231)))), ((int)(((byte)(229)))), ((int)(((byte)(255)))));
            this.OrderGv.ThemeStyle.HeaderStyle.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(100)))), ((int)(((byte)(88)))), ((int)(((byte)(255)))));
            this.OrderGv.ThemeStyle.HeaderStyle.BorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            this.OrderGv.ThemeStyle.HeaderStyle.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.OrderGv.ThemeStyle.HeaderStyle.ForeColor = System.Drawing.Color.White;
            this.OrderGv.ThemeStyle.HeaderStyle.HeaightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.EnableResizing;
            this.OrderGv.ThemeStyle.HeaderStyle.Height = 20;
            this.OrderGv.ThemeStyle.ReadOnly = false;
            this.OrderGv.ThemeStyle.RowsStyle.BackColor = System.Drawing.Color.White;
            this.OrderGv.ThemeStyle.RowsStyle.BorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.SingleHorizontal;
            this.OrderGv.ThemeStyle.RowsStyle.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.OrderGv.ThemeStyle.RowsStyle.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(71)))), ((int)(((byte)(69)))), ((int)(((byte)(94)))));
            this.OrderGv.ThemeStyle.RowsStyle.Height = 28;
            this.OrderGv.ThemeStyle.RowsStyle.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(231)))), ((int)(((byte)(229)))), ((int)(((byte)(255)))));
            this.OrderGv.ThemeStyle.RowsStyle.SelectionForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(71)))), ((int)(((byte)(69)))), ((int)(((byte)(94)))));
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.BackColor = System.Drawing.Color.Transparent;
            this.label6.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.ForeColor = System.Drawing.Color.Crimson;
            this.label6.Location = new System.Drawing.Point(473, 660);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(124, 29);
            this.label6.TabIndex = 12;
            this.label6.Text = "Tổng tiền";
            // 
            // lbTotal
            // 
            this.lbTotal.AutoSize = true;
            this.lbTotal.BackColor = System.Drawing.Color.Transparent;
            this.lbTotal.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbTotal.ForeColor = System.Drawing.Color.Crimson;
            this.lbTotal.Location = new System.Drawing.Point(703, 660);
            this.lbTotal.Name = "lbTotal";
            this.lbTotal.Size = new System.Drawing.Size(28, 29);
            this.lbTotal.TabIndex = 13;
            this.lbTotal.Text = "đ";
            // 
            // CustomerIdTb
            // 
            this.CustomerIdTb.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.CustomerIdTb.DefaultText = "";
            this.CustomerIdTb.DisabledState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(208)))), ((int)(((byte)(208)))));
            this.CustomerIdTb.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(226)))), ((int)(((byte)(226)))), ((int)(((byte)(226)))));
            this.CustomerIdTb.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.CustomerIdTb.DisabledState.Parent = this.CustomerIdTb;
            this.CustomerIdTb.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.CustomerIdTb.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.CustomerIdTb.FocusedState.Parent = this.CustomerIdTb;
            this.CustomerIdTb.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.CustomerIdTb.HoverState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.CustomerIdTb.HoverState.Parent = this.CustomerIdTb;
            this.CustomerIdTb.Location = new System.Drawing.Point(38, 407);
            this.CustomerIdTb.Name = "CustomerIdTb";
            this.CustomerIdTb.PasswordChar = '\0';
            this.CustomerIdTb.PlaceholderForeColor = System.Drawing.Color.Crimson;
            this.CustomerIdTb.PlaceholderText = "Customer Id";
            this.CustomerIdTb.ReadOnly = true;
            this.CustomerIdTb.SelectedText = "";
            this.CustomerIdTb.ShadowDecoration.Parent = this.CustomerIdTb;
            this.CustomerIdTb.Size = new System.Drawing.Size(200, 33);
            this.CustomerIdTb.Style = Guna.UI2.WinForms.Enums.TextBoxStyle.Material;
            this.CustomerIdTb.TabIndex = 14;
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.BackColor = System.Drawing.Color.Transparent;
            this.label9.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label9.ForeColor = System.Drawing.Color.Crimson;
            this.label9.Location = new System.Drawing.Point(14, 567);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(142, 29);
            this.label9.TabIndex = 15;
            this.label9.Text = "Order Date";
            // 
            // OrderDatedtpk
            // 
            this.OrderDatedtpk.CheckedState.Parent = this.OrderDatedtpk;
            this.OrderDatedtpk.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.OrderDatedtpk.Format = System.Windows.Forms.DateTimePickerFormat.Long;
            this.OrderDatedtpk.HoverState.Parent = this.OrderDatedtpk;
            this.OrderDatedtpk.Location = new System.Drawing.Point(176, 567);
            this.OrderDatedtpk.MaxDate = new System.DateTime(9998, 12, 31, 0, 0, 0, 0);
            this.OrderDatedtpk.MinDate = new System.DateTime(1753, 1, 1, 0, 0, 0, 0);
            this.OrderDatedtpk.Name = "OrderDatedtpk";
            this.OrderDatedtpk.ShadowDecoration.Parent = this.OrderDatedtpk;
            this.OrderDatedtpk.Size = new System.Drawing.Size(263, 36);
            this.OrderDatedtpk.TabIndex = 16;
            this.OrderDatedtpk.Value = new System.DateTime(2021, 2, 6, 15, 51, 23, 466);
            // 
            // nmQty
            // 
            this.nmQty.BackColor = System.Drawing.Color.Transparent;
            this.nmQty.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.nmQty.DisabledState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(208)))), ((int)(((byte)(208)))));
            this.nmQty.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(226)))), ((int)(((byte)(226)))), ((int)(((byte)(226)))));
            this.nmQty.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.nmQty.DisabledState.Parent = this.nmQty;
            this.nmQty.DisabledState.UpDownButtonFillColor = System.Drawing.Color.FromArgb(((int)(((byte)(177)))), ((int)(((byte)(177)))), ((int)(((byte)(177)))));
            this.nmQty.DisabledState.UpDownButtonForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(203)))), ((int)(((byte)(203)))), ((int)(((byte)(203)))));
            this.nmQty.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.nmQty.FocusedState.Parent = this.nmQty;
            this.nmQty.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.nmQty.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(126)))), ((int)(((byte)(137)))), ((int)(((byte)(149)))));
            this.nmQty.Location = new System.Drawing.Point(634, 373);
            this.nmQty.Minimum = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.nmQty.Name = "nmQty";
            this.nmQty.ShadowDecoration.Parent = this.nmQty;
            this.nmQty.Size = new System.Drawing.Size(119, 38);
            this.nmQty.TabIndex = 19;
            this.nmQty.Value = new decimal(new int[] {
            1,
            0,
            0,
            0});
            // 
            // InsertOderBtn
            // 
            this.InsertOderBtn.CheckedState.Parent = this.InsertOderBtn;
            this.InsertOderBtn.CustomImages.Parent = this.InsertOderBtn;
            this.InsertOderBtn.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.InsertOderBtn.ForeColor = System.Drawing.Color.White;
            this.InsertOderBtn.HoverState.Parent = this.InsertOderBtn;
            this.InsertOderBtn.Location = new System.Drawing.Point(19, 622);
            this.InsertOderBtn.Name = "InsertOderBtn";
            this.InsertOderBtn.ShadowDecoration.Parent = this.InsertOderBtn;
            this.InsertOderBtn.Size = new System.Drawing.Size(175, 38);
            this.InsertOderBtn.TabIndex = 20;
            this.InsertOderBtn.Text = "Insert Order";
            this.InsertOderBtn.Click += new System.EventHandler(this.InsertOderBtn_Click);
            // 
            // ViewOrderBtn
            // 
            this.ViewOrderBtn.CheckedState.Parent = this.ViewOrderBtn;
            this.ViewOrderBtn.CustomImages.Parent = this.ViewOrderBtn;
            this.ViewOrderBtn.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.ViewOrderBtn.ForeColor = System.Drawing.Color.White;
            this.ViewOrderBtn.HoverState.Parent = this.ViewOrderBtn;
            this.ViewOrderBtn.Location = new System.Drawing.Point(222, 622);
            this.ViewOrderBtn.Name = "ViewOrderBtn";
            this.ViewOrderBtn.ShadowDecoration.Parent = this.ViewOrderBtn;
            this.ViewOrderBtn.Size = new System.Drawing.Size(175, 38);
            this.ViewOrderBtn.TabIndex = 21;
            this.ViewOrderBtn.Text = "View Order";
            this.ViewOrderBtn.Click += new System.EventHandler(this.ViewOrderBtn_Click);
            // 
            // ProductIdTb
            // 
            this.ProductIdTb.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.ProductIdTb.DefaultText = "";
            this.ProductIdTb.DisabledState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(208)))), ((int)(((byte)(208)))));
            this.ProductIdTb.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(226)))), ((int)(((byte)(226)))), ((int)(((byte)(226)))));
            this.ProductIdTb.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.ProductIdTb.DisabledState.Parent = this.ProductIdTb;
            this.ProductIdTb.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.ProductIdTb.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.ProductIdTb.FocusedState.Parent = this.ProductIdTb;
            this.ProductIdTb.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.ProductIdTb.HoverState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.ProductIdTb.HoverState.Parent = this.ProductIdTb;
            this.ProductIdTb.Location = new System.Drawing.Point(38, 462);
            this.ProductIdTb.Name = "ProductIdTb";
            this.ProductIdTb.PasswordChar = '\0';
            this.ProductIdTb.PlaceholderForeColor = System.Drawing.Color.Crimson;
            this.ProductIdTb.PlaceholderText = "Product Id";
            this.ProductIdTb.ReadOnly = true;
            this.ProductIdTb.SelectedText = "";
            this.ProductIdTb.ShadowDecoration.Parent = this.ProductIdTb;
            this.ProductIdTb.Size = new System.Drawing.Size(200, 33);
            this.ProductIdTb.Style = Guna.UI2.WinForms.Enums.TextBoxStyle.Material;
            this.ProductIdTb.TabIndex = 22;
            // 
            // totalPriceTb
            // 
            this.totalPriceTb.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.totalPriceTb.DefaultText = "";
            this.totalPriceTb.DisabledState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(208)))), ((int)(((byte)(208)))));
            this.totalPriceTb.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(226)))), ((int)(((byte)(226)))), ((int)(((byte)(226)))));
            this.totalPriceTb.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.totalPriceTb.DisabledState.Parent = this.totalPriceTb;
            this.totalPriceTb.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.totalPriceTb.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.totalPriceTb.FocusedState.Parent = this.totalPriceTb;
            this.totalPriceTb.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.totalPriceTb.HoverState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.totalPriceTb.HoverState.Parent = this.totalPriceTb;
            this.totalPriceTb.Location = new System.Drawing.Point(38, 518);
            this.totalPriceTb.Name = "totalPriceTb";
            this.totalPriceTb.PasswordChar = '\0';
            this.totalPriceTb.PlaceholderForeColor = System.Drawing.Color.Crimson;
            this.totalPriceTb.PlaceholderText = "Total Price";
            this.totalPriceTb.ReadOnly = true;
            this.totalPriceTb.SelectedText = "";
            this.totalPriceTb.ShadowDecoration.Parent = this.totalPriceTb;
            this.totalPriceTb.Size = new System.Drawing.Size(200, 33);
            this.totalPriceTb.Style = Guna.UI2.WinForms.Enums.TextBoxStyle.Material;
            this.totalPriceTb.TabIndex = 23;
            // 
            // printPreviewDialog1
            // 
            this.printPreviewDialog1.AutoScrollMargin = new System.Drawing.Size(0, 0);
            this.printPreviewDialog1.AutoScrollMinSize = new System.Drawing.Size(0, 0);
            this.printPreviewDialog1.ClientSize = new System.Drawing.Size(400, 300);
            this.printPreviewDialog1.Enabled = true;
            this.printPreviewDialog1.Icon = ((System.Drawing.Icon)(resources.GetObject("printPreviewDialog1.Icon")));
            this.printPreviewDialog1.Name = "printPreviewDialog1";
            this.printPreviewDialog1.Visible = false;
            // 
            // OrderManage
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1087, 715);
            this.Controls.Add(this.totalPriceTb);
            this.Controls.Add(this.ProductIdTb);
            this.Controls.Add(this.ViewOrderBtn);
            this.Controls.Add(this.InsertOderBtn);
            this.Controls.Add(this.nmQty);
            this.Controls.Add(this.OrderDatedtpk);
            this.Controls.Add(this.label9);
            this.Controls.Add(this.CustomerIdTb);
            this.Controls.Add(this.lbTotal);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.OrderGv);
            this.Controls.Add(this.btnAddOrder);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.CustomerGV);
            this.Controls.Add(this.ProductGV);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.panel1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "OrderManage";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "OrderManage";
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.ProductGV)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.CustomerGV)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.OrderGv)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.nmQty)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label7;
        private Guna.UI2.WinForms.Guna2DataGridView ProductGV;
        private Guna.UI2.WinForms.Guna2DataGridView CustomerGV;
        private System.Windows.Forms.Label label5;
        private Guna.UI2.WinForms.Guna2Button btnAddOrder;
        private Guna.UI2.WinForms.Guna2DataGridView OrderGv;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label lbTotal;
        private Guna.UI2.WinForms.Guna2TextBox CustomerIdTb;
        private System.Windows.Forms.Label label9;
        private Guna.UI2.WinForms.Guna2DateTimePicker OrderDatedtpk;
        private Guna.UI2.WinForms.Guna2NumericUpDown nmQty;
        private Guna.UI2.WinForms.Guna2Button InsertOderBtn;
        private Guna.UI2.WinForms.Guna2Button ViewOrderBtn;
        private Guna.UI2.WinForms.Guna2TextBox ProductIdTb;
        private Guna.UI2.WinForms.Guna2TextBox totalPriceTb;
        private System.Windows.Forms.PrintPreviewDialog printPreviewDialog1;
    }
}