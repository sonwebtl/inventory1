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
    public class ProductDAO:DataAccess
    {
        public List<Product> getListProduct()
        {
            List<Product> listProducts = new List<Product>();
            string query = "select * from ProductTbl";
            OpenConnection();
            SqlCommand cmd = new SqlCommand(query, conn);
            SqlDataAdapter ada = new SqlDataAdapter(cmd);
            DataTable data = new DataTable();
            ada.Fill(data);
            foreach(DataRow row in data.Rows)
            {
                Product prod = new Product(row);
                listProducts.Add(prod);
            }
            CloseConnection();
            return listProducts;
        }

        public bool InsertProduct(string name,double price,int qty,int idCat)
        {
            OpenConnection();
            SqlCommand cmd2 = new SqlCommand();
            cmd2.CommandType = CommandType.Text;
            string query = "Insert into ProductTbl (name,idCat,price,qty)" +
                            " values (@name,@idCat,@price,@qty) ";
            cmd2.CommandText = query;
            cmd2.Connection = conn;

            cmd2.Parameters.Add("@name", SqlDbType.VarChar).Value = name;
            cmd2.Parameters.Add("@idCat", SqlDbType.Int).Value = idCat;
            cmd2.Parameters.Add("@price", SqlDbType.Float).Value = price;
            cmd2.Parameters.Add("@qty", SqlDbType.Int).Value = qty;

            int result = cmd2.ExecuteNonQuery();

            CloseConnection();
            return result > 0;
        }
        
        public void UpdateQtyProduct(int id, int qty)
        {
            OpenConnection();
            string query = "update ProductTbl set qty = @qty where id = @id";
            SqlCommand cmd2 = new SqlCommand();
            cmd2.CommandText = query;
            cmd2.Connection = conn;
            cmd2.Parameters.Add("@qty", SqlDbType.Int).Value = qty;
            cmd2.Parameters.Add("@id", SqlDbType.Int).Value = id;
            cmd2.ExecuteNonQuery();
            CloseConnection();
        }
        public bool UpdateProduct(string name, double price, int qty, int idCat,int id)
        {
            OpenConnection();
            SqlCommand cmd2 = new SqlCommand();
            cmd2.CommandType = CommandType.Text;
            string query = "Update ProductTbl set name = @name,idCat = @idCat ,price = @price ,qty = @qty where id = @id";                   
            cmd2.CommandText = query;
            cmd2.Connection = conn;

            cmd2.Parameters.Add("@name", SqlDbType.VarChar).Value = name;
            cmd2.Parameters.Add("@idCat", SqlDbType.Int).Value = idCat;
            cmd2.Parameters.Add("@price", SqlDbType.Float).Value = price;
            cmd2.Parameters.Add("@qty", SqlDbType.Int).Value = qty;
            cmd2.Parameters.Add("@id", SqlDbType.Int).Value = id;
            int result = cmd2.ExecuteNonQuery();

            CloseConnection();
            return result > 0;
        }

        public int getCatIdbyProductId(int idProduct)
        {
            string query = "select idCat from productTbl where id = '"+idProduct+"' ";
            OpenConnection();
            SqlCommand cmd2 = new SqlCommand();
            cmd2.CommandType = CommandType.Text;
            cmd2.CommandText = query;
            cmd2.Connection = conn;
            int idCat = (int)cmd2.ExecuteScalar();
            CloseConnection();
            return idCat;
        }

        public bool DeleteProduct(int id)
        {
            int result;
            OpenConnection();
            string query = string.Format("delete ProductTbl where id = {0} ", id);
            SqlCommand cmd = new SqlCommand(query, conn);
            result = cmd.ExecuteNonQuery();
            CloseConnection();
            return result > 0;
        }
    }
}
