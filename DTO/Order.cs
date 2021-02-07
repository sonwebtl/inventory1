using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
using System.Data.SqlClient;

namespace quanlykho.DTO
{
    public class Order
    {
        private int iD;
        public int ID
        {
            get { return iD; }
            set { iD = value; }
        }

        private int customerId;
        public int CustomerId
        {
            get { return customerId; }
            set { customerId = value; }
        }
       
      

        private float totalPrice;
        public float TotalPrice
        {
            get { return totalPrice; }
            set { totalPrice = value; }
        }

        private DateTime orderDate;
        public DateTime OrderDate
        {
            get { return orderDate; }
            set { orderDate = value; }
        }

        public Order(int id, int customerId, float totalPrice, DateTime orderDate)
        {
            this.ID = id;
            this.CustomerId = customerId;
         
            this.TotalPrice = totalPrice;
            this.OrderDate = orderDate;
        }

        public Order(DataRow row)
        {
            this.ID = (int)row["id"];
            this.CustomerId = (int)row["customerId"];
           
            this.TotalPrice = (float)Convert.ToDouble( row["totalPrice"]);
            this.OrderDate =(DateTime)row["orderDate"];
        }
    }
}
