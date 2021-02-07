using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
using System.Data.SqlClient;
using quanlykho.DTO;

namespace quanlykho.DAO
{
    public class OrderDAO:DataAccess
    {
        public List<Order> getListOrder()
        {
            List<Order> listOrders = new List<Order>();
            string query = "select * from HoadonTbl";
            OpenConnection();
            SqlCommand cmd = new SqlCommand(query, conn);
            SqlDataAdapter ada = new SqlDataAdapter(cmd);
            DataTable data = new DataTable();
            ada.Fill(data);
            foreach (DataRow row in data.Rows)
            {
                Order objOrder = new Order(row);
                listOrders.Add(objOrder);
            }
            CloseConnection();
            return listOrders;
        }
        public bool InsertOrder(int CustomerId,double totalPrice, DateTime OrderDate)
        {
            OpenConnection();
            SqlCommand cmd2 = new SqlCommand();
            cmd2.CommandType = CommandType.Text;
            string query = "Insert into HoadonTbl (customerId,OrderDate,totalPrice)" +
                            " values (@CustomerId,@OrderDate,@totalPrice) ";
            cmd2.CommandText = query;
            cmd2.Connection = conn;

            cmd2.Parameters.Add("@CustomerId", SqlDbType.Int).Value = CustomerId;
            cmd2.Parameters.Add("@OrderDate", SqlDbType.DateTime).Value = OrderDate;
            cmd2.Parameters.Add("@totalPrice", SqlDbType.Float).Value = totalPrice;
          

            int result = cmd2.ExecuteNonQuery();

            CloseConnection();
            return result > 0;
        }
    }
}
