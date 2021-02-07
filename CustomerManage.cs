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
    public partial class CustomerManage : Form
    {
        CustomerDAO custDao = new CustomerDAO();
        BindingSource bsCust = new BindingSource();
        public CustomerManage()
        {
            InitializeComponent();
           
        }
        #region method
        void LoadData()
        {
            CustomerGV.DataSource = bsCust;
            LoadListCustomer();
            AddDataBinding();
        }
        void LoadListCustomer()
        {
            bsCust.DataSource = custDao.GetListCustomer();
        }
        void AddDataBinding()
        {
            CustomerdTbId.DataBindings.Add(new Binding("Text", CustomerGV.DataSource, "id", true, DataSourceUpdateMode.Never));
            CustNameTb.DataBindings.Add(new Binding("Text", CustomerGV.DataSource, "name", true, DataSourceUpdateMode.Never));
            CustPhoneTb.DataBindings.Add(new Binding("Text", CustomerGV.DataSource, "email", true, DataSourceUpdateMode.Never));
            CustEmailTb.DataBindings.Add(new Binding("Text", CustomerGV.DataSource, "phone", true, DataSourceUpdateMode.Never));
        }
        #endregion
        private void splitContainer1_Panel2_Paint(object sender, PaintEventArgs e)
        {

        }

        private void CustomerManage_Load(object sender, EventArgs e)
        {
            LoadData();
        }

        private void label5_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void btnAdd_Click(object sender, EventArgs e)
        {
            string nameCust = CustNameTb.Text;
            string emailCust = CustEmailTb.Text;
            string phoneCust = CustPhoneTb.Text;

            if ( custDao.InsertCustomer(nameCust,emailCust,phoneCust))
            {
                MessageBox.Show("Insert successfull");
                LoadListCustomer();
            }else
            {
                MessageBox.Show("Fail Insert");
            }
        }

        private void btnClear_Click(object sender, EventArgs e)
        {
            CustEmailTb.Text = "";
            CustNameTb.Text = "";
            CustPhoneTb.Text = "";
            CustomerdTbId.Text = "";
        }

        private void btnDelete_Click(object sender, EventArgs e)
        {
            int id = Int32.Parse(CustomerdTbId.Text);
            if (custDao.DeleteCustomer(id))
            {
                MessageBox.Show("Delete successfully");
                LoadListCustomer();
            }else
            {
                MessageBox.Show("Delete Fail");
            }
        }

        private void btnEdit_Click(object sender, EventArgs e)
        {
            int id = Int32.Parse(CustomerdTbId.Text);
            string nameCust = CustNameTb.Text;
            string emailCust = CustEmailTb.Text;
            string phoneCust = CustPhoneTb.Text;

            if (custDao.UpdateCustomer(id,nameCust, emailCust, phoneCust))
            {
                MessageBox.Show("Update successfull");
                LoadListCustomer();
            }
            else
            {
                MessageBox.Show("Fail Update");
            }
        }
    }
}
