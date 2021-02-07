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
    public partial class ProductManage : Form
    {
        BindingSource bsProduct = new BindingSource();
        ProductDAO proDao = new ProductDAO();
        CategoryDAO catDao = new CategoryDAO();
        public ProductManage()
        {
            InitializeComponent();

            LoadData();
        }

        #region method
        void LoadData()
        {
            ProductGV.DataSource = bsProduct;
            LoadListProduct();
            LoadCbCategory();
            AddDataBinding();
        }
        void LoadListProduct()
        {
            bsProduct.DataSource = proDao.getListProduct();
        }
        void LoadCbCategory()
        {
            cbCat.DataSource = catDao.GetListCategory();
            cbCat.DisplayMember = "name";
            cbCat.ValueMember = "id";
        }
        void AddDataBinding()
        {
            ProductTbId.DataBindings.Add(new Binding("Text", ProductGV.DataSource, "id", true, DataSourceUpdateMode.Never));
            ProductNameTb.DataBindings.Add(new Binding("Text", ProductGV.DataSource, "name", true, DataSourceUpdateMode.Never));
            ProductPriceTb.DataBindings.Add(new Binding("Text", ProductGV.DataSource, "price", true, DataSourceUpdateMode.Never));
            QtyProdcutTb.DataBindings.Add(new Binding("Text", ProductGV.DataSource, "qty", true, DataSourceUpdateMode.Never));
        }
        #endregion
        private void ProductManage_Load(object sender, EventArgs e)
        {

        }

        private void label6_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void btnDelete_Click(object sender, EventArgs e)
        {
            int id = Int32.Parse(ProductTbId.Text);
            if (proDao.DeleteProduct(id))
            {
                MessageBox.Show("Delete successfully");
                LoadListProduct();
            }
            else
            {
                MessageBox.Show("Delete Fail");
            }
        }

        private void btnAdd_Click(object sender, EventArgs e)
        {
            string name = ProductNameTb.Text;
            
            int idCat = (int)cbCat.SelectedValue;
           // MessageBox.Show(idCat.ToString());
            

            if ( name == "" || ProductPriceTb.Text == "" || QtyProdcutTb.Text == "")
            {
                MessageBox.Show("Please enter name or price or qty");
            }else
            {
                try
                {
                    double price = Convert.ToDouble(ProductPriceTb.Text);
                    int qty = Int32.Parse(QtyProdcutTb.Text);
                    proDao.InsertProduct(name, price, qty, idCat);
                    MessageBox.Show("Add product successfully ");
                    LoadListProduct();

                }catch(Exception ex)
                {
                    MessageBox.Show(ex.Message);
                }
            }
            
        }

        private void btnEdit_Click(object sender, EventArgs e)
        {
            int id = Int32.Parse( ProductTbId.Text);
            string name = ProductNameTb.Text;
            int idProduct = Int32.Parse(ProductTbId.Text);
            int idCat = (int)cbCat.SelectedValue;
            if (name == "" || ProductPriceTb.Text == "" || QtyProdcutTb.Text == "")
            {
                MessageBox.Show("Please enter name or price or qty");
            }
            else
            {
                try
                {
                    double price = Convert.ToDouble(ProductPriceTb.Text);
                    int qty = Int32.Parse(QtyProdcutTb.Text);
                    proDao.UpdateProduct(name, price, qty, idCat,id);
                    MessageBox.Show("Update product successfully ");
                    LoadListProduct();

                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message);
                }
            }
        }

        private void ProductTbId_TextChanged(object sender, EventArgs e)
        {
            
            try
            {
                if ( ProductGV.SelectedCells.Count > 0)
                {
                    int idProduct = Int32.Parse(ProductTbId.Text);
                    //int index = proDao.getCatIdbyProductId(idProduct);
                    int index = (int)ProductGV.SelectedCells[0].OwningRow.Cells["idCat"].Value;
                    cbCat.SelectedIndex = index -1;
                }
            }
            catch(Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
           
           // MessageBox.Show(index.ToString());
        }
    }
}
