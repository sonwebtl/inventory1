
namespace quanlykho
{
    partial class CustomerManage
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle4 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle5 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle6 = new System.Windows.Forms.DataGridViewCellStyle();
            this.panel1 = new System.Windows.Forms.Panel();
            this.label5 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.splitContainer1 = new System.Windows.Forms.SplitContainer();
            this.btnClear = new Guna.UI2.WinForms.Guna2Button();
            this.CustEmailTb = new Guna.UI2.WinForms.Guna2TextBox();
            this.CustPhoneTb = new Guna.UI2.WinForms.Guna2TextBox();
            this.btnHome = new Guna.UI2.WinForms.Guna2Button();
            this.btnDelete = new Guna.UI2.WinForms.Guna2Button();
            this.btnEdit = new Guna.UI2.WinForms.Guna2Button();
            this.btnAdd = new Guna.UI2.WinForms.Guna2Button();
            this.CustNameTb = new Guna.UI2.WinForms.Guna2TextBox();
            this.CustomerdTbId = new Guna.UI2.WinForms.Guna2TextBox();
            this.CustomerGV = new Guna.UI2.WinForms.Guna2DataGridView();
            this.label3 = new System.Windows.Forms.Label();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer1)).BeginInit();
            this.splitContainer1.Panel1.SuspendLayout();
            this.splitContainer1.Panel2.SuspendLayout();
            this.splitContainer1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.CustomerGV)).BeginInit();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.Crimson;
            this.panel1.Controls.Add(this.label5);
            this.panel1.Controls.Add(this.label4);
            this.panel1.Controls.Add(this.label2);
            this.panel1.Controls.Add(this.label1);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel1.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.panel1.ForeColor = System.Drawing.Color.LavenderBlush;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(933, 67);
            this.panel1.TabIndex = 1;
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
            this.label5.Click += new System.EventHandler(this.label5_Click);
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
            this.label2.Size = new System.Drawing.Size(225, 29);
            this.label2.TabIndex = 1;
            this.label2.Text = "Manage Customer";
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
            this.splitContainer1.Panel1.Controls.Add(this.btnClear);
            this.splitContainer1.Panel1.Controls.Add(this.CustEmailTb);
            this.splitContainer1.Panel1.Controls.Add(this.CustPhoneTb);
            this.splitContainer1.Panel1.Controls.Add(this.btnHome);
            this.splitContainer1.Panel1.Controls.Add(this.btnDelete);
            this.splitContainer1.Panel1.Controls.Add(this.btnEdit);
            this.splitContainer1.Panel1.Controls.Add(this.btnAdd);
            this.splitContainer1.Panel1.Controls.Add(this.CustNameTb);
            this.splitContainer1.Panel1.Controls.Add(this.CustomerdTbId);
            // 
            // splitContainer1.Panel2
            // 
            this.splitContainer1.Panel2.Controls.Add(this.CustomerGV);
            this.splitContainer1.Panel2.Controls.Add(this.label3);
            this.splitContainer1.Panel2.Paint += new System.Windows.Forms.PaintEventHandler(this.splitContainer1_Panel2_Paint);
            this.splitContainer1.Size = new System.Drawing.Size(933, 426);
            this.splitContainer1.SplitterDistance = 375;
            this.splitContainer1.TabIndex = 2;
            // 
            // btnClear
            // 
            this.btnClear.CheckedState.Parent = this.btnClear;
            this.btnClear.CustomImages.Parent = this.btnClear;
            this.btnClear.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.btnClear.ForeColor = System.Drawing.Color.White;
            this.btnClear.HoverState.Parent = this.btnClear;
            this.btnClear.Location = new System.Drawing.Point(65, 306);
            this.btnClear.Name = "btnClear";
            this.btnClear.ShadowDecoration.Parent = this.btnClear;
            this.btnClear.Size = new System.Drawing.Size(96, 35);
            this.btnClear.TabIndex = 17;
            this.btnClear.Text = "Clear";
            this.btnClear.Click += new System.EventHandler(this.btnClear_Click);
            // 
            // CustEmailTb
            // 
            this.CustEmailTb.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.CustEmailTb.DefaultText = "";
            this.CustEmailTb.DisabledState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(208)))), ((int)(((byte)(208)))));
            this.CustEmailTb.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(226)))), ((int)(((byte)(226)))), ((int)(((byte)(226)))));
            this.CustEmailTb.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.CustEmailTb.DisabledState.Parent = this.CustEmailTb;
            this.CustEmailTb.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.CustEmailTb.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.CustEmailTb.FocusedState.Parent = this.CustEmailTb;
            this.CustEmailTb.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold);
            this.CustEmailTb.HoverState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.CustEmailTb.HoverState.Parent = this.CustEmailTb;
            this.CustEmailTb.Location = new System.Drawing.Point(21, 198);
            this.CustEmailTb.Name = "CustEmailTb";
            this.CustEmailTb.PasswordChar = '\0';
            this.CustEmailTb.PlaceholderForeColor = System.Drawing.Color.OrangeRed;
            this.CustEmailTb.PlaceholderText = "Email";
            this.CustEmailTb.SelectedText = "";
            this.CustEmailTb.ShadowDecoration.Parent = this.CustEmailTb;
            this.CustEmailTb.Size = new System.Drawing.Size(220, 36);
            this.CustEmailTb.TabIndex = 16;
            // 
            // CustPhoneTb
            // 
            this.CustPhoneTb.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.CustPhoneTb.DefaultText = "";
            this.CustPhoneTb.DisabledState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(208)))), ((int)(((byte)(208)))));
            this.CustPhoneTb.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(226)))), ((int)(((byte)(226)))), ((int)(((byte)(226)))));
            this.CustPhoneTb.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.CustPhoneTb.DisabledState.Parent = this.CustPhoneTb;
            this.CustPhoneTb.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.CustPhoneTb.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.CustPhoneTb.FocusedState.Parent = this.CustPhoneTb;
            this.CustPhoneTb.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold);
            this.CustPhoneTb.HoverState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.CustPhoneTb.HoverState.Parent = this.CustPhoneTb;
            this.CustPhoneTb.Location = new System.Drawing.Point(21, 142);
            this.CustPhoneTb.Name = "CustPhoneTb";
            this.CustPhoneTb.PasswordChar = '\0';
            this.CustPhoneTb.PlaceholderForeColor = System.Drawing.Color.OrangeRed;
            this.CustPhoneTb.PlaceholderText = "Customer Phone";
            this.CustPhoneTb.SelectedText = "";
            this.CustPhoneTb.ShadowDecoration.Parent = this.CustPhoneTb;
            this.CustPhoneTb.Size = new System.Drawing.Size(220, 36);
            this.CustPhoneTb.TabIndex = 15;
            // 
            // btnHome
            // 
            this.btnHome.CheckedState.Parent = this.btnHome;
            this.btnHome.CustomImages.Parent = this.btnHome;
            this.btnHome.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.btnHome.ForeColor = System.Drawing.Color.White;
            this.btnHome.HoverState.Parent = this.btnHome;
            this.btnHome.Location = new System.Drawing.Point(185, 306);
            this.btnHome.Name = "btnHome";
            this.btnHome.ShadowDecoration.Parent = this.btnHome;
            this.btnHome.Size = new System.Drawing.Size(96, 35);
            this.btnHome.TabIndex = 14;
            this.btnHome.Text = "Home";
            // 
            // btnDelete
            // 
            this.btnDelete.CheckedState.Parent = this.btnDelete;
            this.btnDelete.CustomImages.Parent = this.btnDelete;
            this.btnDelete.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.btnDelete.ForeColor = System.Drawing.Color.White;
            this.btnDelete.HoverState.Parent = this.btnDelete;
            this.btnDelete.Location = new System.Drawing.Point(259, 252);
            this.btnDelete.Name = "btnDelete";
            this.btnDelete.ShadowDecoration.Parent = this.btnDelete;
            this.btnDelete.Size = new System.Drawing.Size(96, 35);
            this.btnDelete.TabIndex = 13;
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
            this.btnEdit.Location = new System.Drawing.Point(137, 252);
            this.btnEdit.Name = "btnEdit";
            this.btnEdit.ShadowDecoration.Parent = this.btnEdit;
            this.btnEdit.Size = new System.Drawing.Size(96, 35);
            this.btnEdit.TabIndex = 12;
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
            this.btnAdd.Location = new System.Drawing.Point(14, 250);
            this.btnAdd.Name = "btnAdd";
            this.btnAdd.ShadowDecoration.Parent = this.btnAdd;
            this.btnAdd.Size = new System.Drawing.Size(96, 35);
            this.btnAdd.TabIndex = 9;
            this.btnAdd.Text = "Add";
            this.btnAdd.Click += new System.EventHandler(this.btnAdd_Click);
            // 
            // CustNameTb
            // 
            this.CustNameTb.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.CustNameTb.DefaultText = "";
            this.CustNameTb.DisabledState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(208)))), ((int)(((byte)(208)))));
            this.CustNameTb.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(226)))), ((int)(((byte)(226)))), ((int)(((byte)(226)))));
            this.CustNameTb.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.CustNameTb.DisabledState.Parent = this.CustNameTb;
            this.CustNameTb.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.CustNameTb.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.CustNameTb.FocusedState.Parent = this.CustNameTb;
            this.CustNameTb.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold);
            this.CustNameTb.HoverState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.CustNameTb.HoverState.Parent = this.CustNameTb;
            this.CustNameTb.Location = new System.Drawing.Point(21, 84);
            this.CustNameTb.Name = "CustNameTb";
            this.CustNameTb.PasswordChar = '\0';
            this.CustNameTb.PlaceholderForeColor = System.Drawing.Color.OrangeRed;
            this.CustNameTb.PlaceholderText = "Customer Name";
            this.CustNameTb.SelectedText = "";
            this.CustNameTb.ShadowDecoration.Parent = this.CustNameTb;
            this.CustNameTb.Size = new System.Drawing.Size(220, 36);
            this.CustNameTb.TabIndex = 11;
            // 
            // CustomerdTbId
            // 
            this.CustomerdTbId.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.CustomerdTbId.DefaultText = "";
            this.CustomerdTbId.DisabledState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(208)))), ((int)(((byte)(208)))));
            this.CustomerdTbId.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(226)))), ((int)(((byte)(226)))), ((int)(((byte)(226)))));
            this.CustomerdTbId.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.CustomerdTbId.DisabledState.Parent = this.CustomerdTbId;
            this.CustomerdTbId.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.CustomerdTbId.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.CustomerdTbId.FocusedState.Parent = this.CustomerdTbId;
            this.CustomerdTbId.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold);
            this.CustomerdTbId.HoverState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.CustomerdTbId.HoverState.Parent = this.CustomerdTbId;
            this.CustomerdTbId.Location = new System.Drawing.Point(21, 20);
            this.CustomerdTbId.Name = "CustomerdTbId";
            this.CustomerdTbId.PasswordChar = '\0';
            this.CustomerdTbId.PlaceholderForeColor = System.Drawing.Color.OrangeRed;
            this.CustomerdTbId.PlaceholderText = "ID Customer";
            this.CustomerdTbId.ReadOnly = true;
            this.CustomerdTbId.SelectedText = "";
            this.CustomerdTbId.ShadowDecoration.Parent = this.CustomerdTbId;
            this.CustomerdTbId.Size = new System.Drawing.Size(220, 36);
            this.CustomerdTbId.TabIndex = 10;
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
            this.CustomerGV.ColumnHeadersHeight = 4;
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
            this.CustomerGV.Location = new System.Drawing.Point(15, 52);
            this.CustomerGV.Name = "CustomerGV";
            this.CustomerGV.RowHeadersVisible = false;
            this.CustomerGV.RowHeadersWidth = 62;
            this.CustomerGV.RowTemplate.Height = 28;
            this.CustomerGV.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.CustomerGV.Size = new System.Drawing.Size(506, 298);
            this.CustomerGV.TabIndex = 4;
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
            this.CustomerGV.ThemeStyle.HeaderStyle.Height = 4;
            this.CustomerGV.ThemeStyle.ReadOnly = false;
            this.CustomerGV.ThemeStyle.RowsStyle.BackColor = System.Drawing.Color.White;
            this.CustomerGV.ThemeStyle.RowsStyle.BorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.SingleHorizontal;
            this.CustomerGV.ThemeStyle.RowsStyle.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.CustomerGV.ThemeStyle.RowsStyle.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(71)))), ((int)(((byte)(69)))), ((int)(((byte)(94)))));
            this.CustomerGV.ThemeStyle.RowsStyle.Height = 28;
            this.CustomerGV.ThemeStyle.RowsStyle.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(231)))), ((int)(((byte)(229)))), ((int)(((byte)(255)))));
            this.CustomerGV.ThemeStyle.RowsStyle.SelectionForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(71)))), ((int)(((byte)(69)))), ((int)(((byte)(94)))));
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.BackColor = System.Drawing.Color.Transparent;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.ForeColor = System.Drawing.Color.Crimson;
            this.label3.Location = new System.Drawing.Point(160, 20);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(173, 29);
            this.label3.TabIndex = 3;
            this.label3.Text = "Customer List";
            // 
            // CustomerManage
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(10F, 22F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(933, 493);
            this.Controls.Add(this.splitContainer1);
            this.Controls.Add(this.panel1);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "CustomerManage";
            this.Text = "CustomerManage";
            this.Load += new System.EventHandler(this.CustomerManage_Load);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.splitContainer1.Panel1.ResumeLayout(false);
            this.splitContainer1.Panel2.ResumeLayout(false);
            this.splitContainer1.Panel2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer1)).EndInit();
            this.splitContainer1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.CustomerGV)).EndInit();
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
        private Guna.UI2.WinForms.Guna2DataGridView CustomerGV;
        private Guna.UI2.WinForms.Guna2TextBox CustEmailTb;
        private Guna.UI2.WinForms.Guna2TextBox CustPhoneTb;
        private Guna.UI2.WinForms.Guna2Button btnHome;
        private Guna.UI2.WinForms.Guna2Button btnDelete;
        private Guna.UI2.WinForms.Guna2Button btnEdit;
        private Guna.UI2.WinForms.Guna2Button btnAdd;
        private Guna.UI2.WinForms.Guna2TextBox CustNameTb;
        private Guna.UI2.WinForms.Guna2TextBox CustomerdTbId;
        private Guna.UI2.WinForms.Guna2Button btnClear;
    }
}