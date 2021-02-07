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
    public class CustomerDAO:DataAccess
    {
        public List<Customer> GetListCustomer()
        {
            List<Customer> ListCustomer = new List<Customer>();
            OpenConnection();
            string query = "select * from CustomerTbl ";
            SqlCommand cmd = new SqlCommand(query, conn);
            SqlDataAdapter ada = new SqlDataAdapter(cmd);
            DataTable data = new DataTable();
            ada.Fill(data);

            foreach(DataRow row in data.Rows)
            {
                Customer cust = new Customer(row);
                ListCustomer.Add(cust);
            }
            CloseConnection();
            return ListCustomer;
        }

        public bool InsertCustomer(string namekh,string emailkh,string phonekh)
        {
           
            OpenConnection();
            SqlCommand cmd2 = new SqlCommand();
            cmd2.CommandType = CommandType.Text;
            string query = "Insert into CustomerTbl (name,email,phone)" +
                            " values (@name,@email,@phone) ";
            cmd2.CommandText = query;
            cmd2.Connection = conn;
            cmd2.Parameters.Add("@name", SqlDbType.VarChar).Value = namekh;
            cmd2.Parameters.Add("@email", SqlDbType.VarChar).Value = emailkh;
            cmd2.Parameters.Add("@phone", SqlDbType.VarChar).Value = phonekh;

            int result = cmd2.ExecuteNonQuery();
            CloseConnection();
            return result > 0;
        }

        public bool UpdateCustomer(int id ,string namekh, string emailkh, string phonekh)
        {

            OpenConnection();
            SqlCommand cmd2 = new SqlCommand();
            cmd2.CommandType = CommandType.Text;
            string query = "Update CustomerTbl" +
                            " set name = @name , email = @email , phone = @phone where id = @id ";
            cmd2.CommandText = query;
            cmd2.Connection = conn;
            cmd2.Parameters.Add("@name", SqlDbType.VarChar).Value = namekh;
            cmd2.Parameters.Add("@email", SqlDbType.VarChar).Value = emailkh;
            cmd2.Parameters.Add("@phone", SqlDbType.VarChar).Value = phonekh;
            cmd2.Parameters.Add("@id", SqlDbType.Int).Value = id;
            int result = cmd2.ExecuteNonQuery();
            CloseConnection();
            return result > 0;
        }

        public bool DeleteCustomer(int id)
        {
            int result;
            OpenConnection();
            string query = string.Format("delete CustomerTbl where id = {0} ", id);
            SqlCommand cmd = new SqlCommand(query, conn);
            result = cmd.ExecuteNonQuery();
            CloseConnection();
            return result > 0;
        }
    }
}
