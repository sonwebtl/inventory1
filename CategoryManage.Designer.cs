
namespace quanlykho
{
    partial class CategoryManage
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle7 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle8 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle9 = new System.Windows.Forms.DataGridViewCellStyle();
            this.panel1 = new System.Windows.Forms.Panel();
            this.label5 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.splitContainer1 = new System.Windows.Forms.SplitContainer();
            this.btnHome = new Guna.UI2.WinForms.Guna2Button();
            this.btnDelete = new Guna.UI2.WinForms.Guna2Button();
            this.btnEdit = new Guna.UI2.WinForms.Guna2Button();
            this.btnAdd = new Guna.UI2.WinForms.Guna2Button();
            this.CatNameTb = new Guna.UI2.WinForms.Guna2TextBox();
            this.CatIdTb = new Guna.UI2.WinForms.Guna2TextBox();
            this.CatGV = new Guna.UI2.WinForms.Guna2DataGridView();
            this.label3 = new System.Windows.Forms.Label();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer1)).BeginInit();
            this.splitContainer1.Panel1.SuspendLayout();
            this.splitContainer1.Panel2.SuspendLayout();
            this.splitContainer1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.CatGV)).BeginInit();
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
            this.panel1.Size = new System.Drawing.Size(835, 67);
            this.panel1.TabIndex = 0;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(802, 0);
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
            this.label4.Click += new System.EventHandler(this.label4_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(370, 32);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(218, 29);
            this.label2.TabIndex = 1;
            this.label2.Text = "Manage Category";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(269, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(432, 32);
            this.label1.TabIndex = 0;
            this.label1.Text = "Inventory Management System";
            this.label1.Click += new System.EventHandler(this.label1_Click);
            // 
            // splitContainer1
            // 
            this.splitContainer1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.splitContainer1.Location = new System.Drawing.Point(0, 67);
            this.splitContainer1.Name = "splitContainer1";
            // 
            // splitContainer1.Panel1
            // 
            this.splitContainer1.Panel1.Controls.Add(this.btnHome);
            this.splitContainer1.Panel1.Controls.Add(this.btnDelete);
            this.splitContainer1.Panel1.Controls.Add(this.btnEdit);
            this.splitContainer1.Panel1.Controls.Add(this.btnAdd);
            this.splitContainer1.Panel1.Controls.Add(this.CatNameTb);
            this.splitContainer1.Panel1.Controls.Add(this.CatIdTb);
            // 
            // splitContainer1.Panel2
            // 
            this.splitContainer1.Panel2.Controls.Add(this.CatGV);
            this.splitContainer1.Panel2.Controls.Add(this.label3);
            this.splitContainer1.Panel2.Paint += new System.Windows.Forms.PaintEventHandler(this.splitContainer1_Panel2_Paint);
            this.splitContainer1.Size = new System.Drawing.Size(835, 445);
            this.splitContainer1.SplitterDistance = 334;
            this.splitContainer1.TabIndex = 1;
            // 
            // btnHome
            // 
            this.btnHome.CheckedState.Parent = this.btnHome;
            this.btnHome.CustomImages.Parent = this.btnHome;
            this.btnHome.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.btnHome.ForeColor = System.Drawing.Color.White;
            this.btnHome.HoverState.Parent = this.btnHome;
            this.btnHome.Location = new System.Drawing.Point(132, 273);
            this.btnHome.Name = "btnHome";
            this.btnHome.ShadowDecoration.Parent = this.btnHome;
            this.btnHome.Size = new System.Drawing.Size(96, 35);
            this.btnHome.TabIndex = 8;
            this.btnHome.Text = "Home";
            // 
            // btnDelete
            // 
            this.btnDelete.CheckedState.Parent = this.btnDelete;
            this.btnDelete.CustomImages.Parent = this.btnDelete;
            this.btnDelete.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.btnDelete.ForeColor = System.Drawing.Color.White;
            this.btnDelete.HoverState.Parent = this.btnDelete;
            this.btnDelete.Location = new System.Drawing.Point(254, 221);
            this.btnDelete.Name = "btnDelete";
            this.btnDelete.ShadowDecoration.Parent = this.btnDelete;
            this.btnDelete.Size = new System.Drawing.Size(96, 35);
            this.btnDelete.TabIndex = 7;
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
            this.btnEdit.Location = new System.Drawing.Point(132, 221);
            this.btnEdit.Name = "btnEdit";
            this.btnEdit.ShadowDecoration.Parent = this.btnEdit;
            this.btnEdit.Size = new System.Drawing.Size(96, 35);
            this.btnEdit.TabIndex = 6;
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
            this.btnAdd.Location = new System.Drawing.Point(12, 221);
            this.btnAdd.Name = "btnAdd";
            this.btnAdd.ShadowDecoration.Parent = this.btnAdd;
            this.btnAdd.Size = new System.Drawing.Size(96, 35);
            this.btnAdd.TabIndex = 4;
            this.btnAdd.Text = "Add";
            this.btnAdd.Click += new System.EventHandler(this.btnAdd_Click);
            // 
            // CatNameTb
            // 
            this.CatNameTb.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.CatNameTb.DefaultText = "";
            this.CatNameTb.DisabledState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(208)))), ((int)(((byte)(208)))));
            this.CatNameTb.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(226)))), ((int)(((byte)(226)))), ((int)(((byte)(226)))));
            this.CatNameTb.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.CatNameTb.DisabledState.Parent = this.CatNameTb;
            this.CatNameTb.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.CatNameTb.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.CatNameTb.FocusedState.Parent = this.CatNameTb;
            this.CatNameTb.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold);
            this.CatNameTb.HoverState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.CatNameTb.HoverState.Parent = this.CatNameTb;
            this.CatNameTb.Location = new System.Drawing.Point(28, 140);
            this.CatNameTb.Name = "CatNameTb";
            this.CatNameTb.PasswordChar = '\0';
            this.CatNameTb.PlaceholderForeColor = System.Drawing.Color.OrangeRed;
            this.CatNameTb.PlaceholderText = "Cat Name";
            this.CatNameTb.SelectedText = "";
            this.CatNameTb.ShadowDecoration.Parent = this.CatNameTb;
            this.CatNameTb.Size = new System.Drawing.Size(220, 36);
            this.CatNameTb.TabIndex = 5;
            // 
            // CatIdTb
            // 
            this.CatIdTb.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.CatIdTb.DefaultText = "";
            this.CatIdTb.DisabledState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(208)))), ((int)(((byte)(208)))));
            this.CatIdTb.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(226)))), ((int)(((byte)(226)))), ((int)(((byte)(226)))));
            this.CatIdTb.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.CatIdTb.DisabledState.Parent = this.CatIdTb;
            this.CatIdTb.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.CatIdTb.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.CatIdTb.FocusedState.Parent = this.CatIdTb;
            this.CatIdTb.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold);
            this.CatIdTb.HoverState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.CatIdTb.HoverState.Parent = this.CatIdTb;
            this.CatIdTb.Location = new System.Drawing.Point(28, 76);
            this.CatIdTb.Name = "CatIdTb";
            this.CatIdTb.PasswordChar = '\0';
            this.CatIdTb.PlaceholderForeColor = System.Drawing.Color.OrangeRed;
            this.CatIdTb.PlaceholderText = "ID Cat";
            this.CatIdTb.ReadOnly = true;
            this.CatIdTb.SelectedText = "";
            this.CatIdTb.ShadowDecoration.Parent = this.CatIdTb;
            this.CatIdTb.Size = new System.Drawing.Size(220, 36);
            this.CatIdTb.TabIndex = 4;
            // 
            // CatGV
            // 
            dataGridViewCellStyle7.BackColor = System.Drawing.Color.White;
            this.CatGV.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle7;
            this.CatGV.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.CatGV.BackgroundColor = System.Drawing.Color.White;
            this.CatGV.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.CatGV.CellBorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.SingleHorizontal;
            this.CatGV.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            dataGridViewCellStyle8.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle8.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(100)))), ((int)(((byte)(88)))), ((int)(((byte)(255)))));
            dataGridViewCellStyle8.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle8.ForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle8.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle8.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle8.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.CatGV.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle8;
            this.CatGV.ColumnHeadersHeight = 4;
            dataGridViewCellStyle9.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle9.BackColor = System.Drawing.Color.White;
            dataGridViewCellStyle9.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle9.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(71)))), ((int)(((byte)(69)))), ((int)(((byte)(94)))));
            dataGridViewCellStyle9.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(231)))), ((int)(((byte)(229)))), ((int)(((byte)(255)))));
            dataGridViewCellStyle9.SelectionForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(71)))), ((int)(((byte)(69)))), ((int)(((byte)(94)))));
            dataGridViewCellStyle9.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.CatGV.DefaultCellStyle = dataGridViewCellStyle9;
            this.CatGV.EnableHeadersVisualStyles = false;
            this.CatGV.GridColor = System.Drawing.Color.FromArgb(((int)(((byte)(231)))), ((int)(((byte)(229)))), ((int)(((byte)(255)))));
            this.CatGV.Location = new System.Drawing.Point(3, 76);
            this.CatGV.Name = "CatGV";
            this.CatGV.RowHeadersVisible = false;
            this.CatGV.RowHeadersWidth = 62;
            this.CatGV.RowTemplate.Height = 28;
            this.CatGV.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.CatGV.Size = new System.Drawing.Size(482, 298);
            this.CatGV.TabIndex = 3;
            this.CatGV.Theme = Guna.UI2.WinForms.Enums.DataGridViewPresetThemes.Default;
            this.CatGV.ThemeStyle.AlternatingRowsStyle.BackColor = System.Drawing.Color.White;
            this.CatGV.ThemeStyle.AlternatingRowsStyle.Font = null;
            this.CatGV.ThemeStyle.AlternatingRowsStyle.ForeColor = System.Drawing.Color.Empty;
            this.CatGV.ThemeStyle.AlternatingRowsStyle.SelectionBackColor = System.Drawing.Color.Empty;
            this.CatGV.ThemeStyle.AlternatingRowsStyle.SelectionForeColor = System.Drawing.Color.Empty;
            this.CatGV.ThemeStyle.BackColor = System.Drawing.Color.White;
            this.CatGV.ThemeStyle.GridColor = System.Drawing.Color.FromArgb(((int)(((byte)(231)))), ((int)(((byte)(229)))), ((int)(((byte)(255)))));
            this.CatGV.ThemeStyle.HeaderStyle.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(100)))), ((int)(((byte)(88)))), ((int)(((byte)(255)))));
            this.CatGV.ThemeStyle.HeaderStyle.BorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            this.CatGV.ThemeStyle.HeaderStyle.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.CatGV.ThemeStyle.HeaderStyle.ForeColor = System.Drawing.Color.White;
            this.CatGV.ThemeStyle.HeaderStyle.HeaightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.EnableResizing;
            this.CatGV.ThemeStyle.HeaderStyle.Height = 4;
            this.CatGV.ThemeStyle.ReadOnly = false;
            this.CatGV.ThemeStyle.RowsStyle.BackColor = System.Drawing.Color.White;
            this.CatGV.ThemeStyle.RowsStyle.BorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.SingleHorizontal;
            this.CatGV.ThemeStyle.RowsStyle.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.CatGV.ThemeStyle.RowsStyle.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(71)))), ((int)(((byte)(69)))), ((int)(((byte)(94)))));
            this.CatGV.ThemeStyle.RowsStyle.Height = 28;
            this.CatGV.ThemeStyle.RowsStyle.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(231)))), ((int)(((byte)(229)))), ((int)(((byte)(255)))));
            this.CatGV.ThemeStyle.RowsStyle.SelectionForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(71)))), ((int)(((byte)(69)))), ((int)(((byte)(94)))));
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.BackColor = System.Drawing.Color.Transparent;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.ForeColor = System.Drawing.Color.Crimson;
            this.label3.Location = new System.Drawing.Point(203, 12);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(166, 29);
            this.label3.TabIndex = 2;
            this.label3.Text = "Category List";
            // 
            // CategoryManage
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(10F, 22F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(835, 512);
            this.Controls.Add(this.splitContainer1);
            this.Controls.Add(this.panel1);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "CategoryManage";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Quản lý danh mục sản phẩm";
            this.Load += new System.EventHandler(this.CategoryManage_Load);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.splitContainer1.Panel1.ResumeLayout(false);
            this.splitContainer1.Panel2.ResumeLayout(false);
            this.splitContainer1.Panel2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer1)).EndInit();
            this.splitContainer1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.CatGV)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.SplitContainer splitContainer1;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label5;
        private Guna.UI2.WinForms.Guna2Button btnHome;
        private Guna.UI2.WinForms.Guna2Button btnDelete;
        private Guna.UI2.WinForms.Guna2Button btnEdit;
        private Guna.UI2.WinForms.Guna2Button btnAdd;
        private Guna.UI2.WinForms.Guna2TextBox CatNameTb;
        private Guna.UI2.WinForms.Guna2TextBox CatIdTb;
        private Guna.UI2.WinForms.Guna2DataGridView CatGV;
    }
}