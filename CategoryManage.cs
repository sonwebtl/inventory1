using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using quanlykho.DAO;
using quanlykho.DTO;

namespace quanlykho
{
    public partial class CategoryManage : Form
    {
        CategoryDAO catd = new CategoryDAO();
        BindingSource categoryList = new BindingSource();
        public CategoryManage()
        {
            InitializeComponent();
            LoadData();
        }
        #region method
        void LoadData()
        {
            CatGV.DataSource = categoryList;
            LoadCategory();
            AddCategoryBinding();
        }
        void LoadCategory()
        {
            
            List<Category> listCategory = catd.GetListCategory();
            categoryList.DataSource = listCategory;
        }
        void AddCategoryBinding()
        {
            CatIdTb.DataBindings.Add(new Binding("Text", CatGV.DataSource, "id", true, DataSourceUpdateMode.Never));
            CatNameTb.DataBindings.Add(new Binding("Text", CatGV.DataSource, "name", true, DataSourceUpdateMode.Never));
        }
        #endregion
        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void label4_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void label5_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void splitContainer1_Panel2_Paint(object sender, PaintEventArgs e)
        {

        }

        private void CategoryManage_Load(object sender, EventArgs e)
        {

        }

        private void btnAdd_Click(object sender, EventArgs e)
        {
            string nameCat = CatNameTb.Text;
            if ( nameCat == "")
            {
                MessageBox.Show("Vui lòng nhập tên danh mục");
            }else
            {
                if (catd.InsertCategory(nameCat))
                {
                    MessageBox.Show("Thêm danh mục thành công");
                    LoadCategory();
                }
                else
                {
                    MessageBox.Show("Thêm thất bại");
                }
            }
            
        }

        private void btnEdit_Click(object sender, EventArgs e)
        {
            string nameCat = CatNameTb.Text;
            int id = Int32.Parse(CatIdTb.Text);
            if (nameCat == "")
            {
                MessageBox.Show("Vui lòng nhập tên danh mục");
            }
            else
            {
                if (catd.UpdateCategory(id,nameCat))
                {
                    MessageBox.Show("Sửa danh mục thành công");
                    LoadCategory();
                }
                else
                {
                    MessageBox.Show("Thêm thất bại");
                }
            }
        }

        private void btnDelete_Click(object sender, EventArgs e)
        {
            int id = Int32.Parse(CatIdTb.Text);
            if (catd.DeleteCategory(id))
            {
                MessageBox.Show("Delete danh mục thành công");
                LoadCategory();
            }
            else
            {
                MessageBox.Show("Delete thất bại");
            }
        }
    }
}
