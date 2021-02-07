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

namespace quanlykho
{
    public partial class OrderManage : Form
    {
        CustomerDAO custDao = new CustomerDAO();
        ProductDAO proDao = new ProductDAO();
        OrderDAO objOrder = new OrderDAO();
        BindingSource bsProduct = new BindingSource();
        BindingSource bsCust = new BindingSource();

        DataTable tableOrder = new DataTable();
        public OrderManage()
        {
            InitializeComponent();
            LoadData();
        }
        int stt = 0;
        int flag = 0;
        double sum = 0;
        int stock;
        int qty;
        double proPrice, totalPrice;
        string nameProduct;
        int idCustomer;
        int idProd;
        #region method
        void LoadData()
        {
            ProductGV.DataSource = bsProduct;
            CustomerGV.DataSource = bsCust;
            LoadListCustomer();
            LoadListProduct();
            LoadOrderGv();
        }
        void LoadListProduct()
        {
            bsProduct.DataSource = proDao.getListProduct();
        }
        void LoadListCustomer()
        {
            bsCust.DataSource = custDao.GetListCustomer();
        }
        void LoadOrderGv()
        {
            tableOrder.Columns.Add("Stt", typeof(int));
            tableOrder.Columns.Add("Product", typeof(string));
            tableOrder.Columns.Add("Quantity", typeof(int));
            tableOrder.Columns.Add("Product Price", typeof(double));
            tableOrder.Columns.Add("Total Price", typeof(double));

            OrderGv.DataSource = tableOrder;
        }
        void UpdateProduct()
        {
            int idProduct = Convert.ToInt32(ProductGV.SelectedRows[0].Cells[0].Value.ToString());
            int newQty;
            newQty = stock - (int)nmQty.Value;
            if ( newQty < 0)
            {
                MessageBox.Show("Operation failed");
                return;
            }else
            {
                //MessageBox.Show(newQty.ToString());
                
                proDao.UpdateQtyProduct(idProduct, newQty);
                LoadListProduct();
                
            }
        }
        #endregion
        private void label4_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void ProductGV_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            flag = 1;
            idProd = Convert.ToInt32( ProductGV.SelectedRows[0].Cells[0].Value.ToString());
            nameProduct = ProductGV.SelectedRows[0].Cells[1].Value.ToString();
            proPrice = Convert.ToDouble( ProductGV.SelectedRows[0].Cells[3].Value.ToString());
            stock = Convert.ToInt32( ProductGV.SelectedRows[0].Cells[2].Value.ToString());

            ProductIdTb.Text = idProd.ToString();
        }

        private void CustomerGV_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            idCustomer = Convert.ToInt32(CustomerGV.SelectedRows[0].Cells[0].Value.ToString());
            CustomerIdTb.Text = idCustomer.ToString();
        }

        private void InsertOderBtn_Click(object sender, EventArgs e)
        {
            if ( CustomerIdTb.Text == "" || totalPriceTb.Text == "")
            {
                MessageBox.Show("Fill the data correctly");
            }
            else
            {
                try
                {
                    var orderDate = OrderDatedtpk.Value;
                    if ( objOrder.InsertOrder(idCustomer,sum,orderDate) )
                    {
                        MessageBox.Show("Insert Order successfully");
                        LoadListProduct();
                    }
                }catch(Exception ex)
                {
                    MessageBox.Show(ex.Message);
                }
            }
        }

        private void ViewOrderBtn_Click(object sender, EventArgs e)
        {
            ViewOrder f = new ViewOrder();
            f.ShowDialog();
        }

        private void btnAddOrder_Click(object sender, EventArgs e)
        {
            if ( flag == 0)
            {
                MessageBox.Show("Please select the Product");
                return;
            }else if ( nmQty.Value > stock)
            {
                MessageBox.Show("No Enought to Available");
            }else
            {
                stt += 1;
                qty = (int)nmQty.Value;
                totalPrice = qty * proPrice;

               
                ProductIdTb.Text = idProd.ToString();
               
                try
                {
                    tableOrder.Rows.Add(stt, nameProduct, qty, proPrice, totalPrice);
                    OrderGv.DataSource = tableOrder;
                    flag = 0;

                    sum = sum + totalPrice;
                    lbTotal.Text = sum.ToString();
                    totalPriceTb.Text = sum.ToString();
                    UpdateProduct();
                }
                catch(Exception ex)
                {
                    MessageBox.Show(ex.Message);
                }
                
            }

           
        }
    }
}
