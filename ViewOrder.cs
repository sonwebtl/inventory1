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
    public partial class ViewOrder : Form
    {
        OrderDAO objOrder = new OrderDAO();
        public ViewOrder()
        {
            InitializeComponent();
            LoadData();
        }
        #region method
        void LoadData()
        {
            OrderDTGV.DataSource = objOrder.getListOrder();
        }
        #endregion
        private void OrderDTGV_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            if ( printPreviewDialog1.ShowDialog() == DialogResult.OK)
            {
                printDocument1.Print();
            }
        }

        private void label3_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void printDocument1_PrintPage(object sender, System.Drawing.Printing.PrintPageEventArgs e)
        {
            e.Graphics.DrawString("Order Summary", new Font("Century", 25, FontStyle.Bold), Brushes.Red, new Point(230));
            e.Graphics.DrawString("Order Id:" + OrderDTGV.SelectedRows[0].Cells[0].Value.ToString(), new Font("Century", 20, FontStyle.Regular), Brushes.Black, new Point(80, 133));
            e.Graphics.DrawString("Customer Id:" + OrderDTGV.SelectedRows[0].Cells[1].Value.ToString(), new Font("Century", 20, FontStyle.Regular), Brushes.Black, new Point(80, 163));
            e.Graphics.DrawString("Total Price:" + OrderDTGV.SelectedRows[0].Cells[2].Value.ToString(), new Font("Century", 20, FontStyle.Regular), Brushes.Black, new Point(80, 203));
            e.Graphics.DrawString("Order Date:" + OrderDTGV.SelectedRows[0].Cells[3].Value.ToString(), new Font("Century", 20, FontStyle.Regular), Brushes.Black, new Point(80, 233));
        }
    }
}
