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
    public class CategoryDAO:DataAccess
    {
        public List<Category> GetListCategory()
        {
            List<Category> listCategory = new List<Category>();
            OpenConnection();
            string query = "select * from Category";
            SqlCommand cmd = new SqlCommand(query, conn);
            DataTable data = new DataTable();
            SqlDataAdapter ada = new SqlDataAdapter(cmd);
            ada.Fill(data);

            foreach(DataRow row in data.Rows)
            {
                Category cat = new Category(row);
                listCategory.Add(cat);
            }
            CloseConnection();
            return listCategory;
        }

        public bool InsertCategory(string name)
        {
            int result;
            OpenConnection();
            string query = string.Format("insert into Category (name) values (N'{0}') ",name);
            SqlCommand cmd = new SqlCommand(query, conn);
            result = cmd.ExecuteNonQuery();
            CloseConnection();
            return result > 0;
        }

        public bool UpdateCategory(int idCat,string name)
        {
            int result;
            OpenConnection();
            string query = string.Format("update Category set name = N'{0}' where id = {1} ", name,idCat);
            SqlCommand cmd = new SqlCommand(query, conn);
            result = cmd.ExecuteNonQuery();
            CloseConnection();
            return result > 0;
        }

        public bool DeleteCategory(int id)
        {
            int result;
            OpenConnection();
            string query = string.Format("delete Category where id = {0} ",id);
            SqlCommand cmd = new SqlCommand(query, conn);
            result = cmd.ExecuteNonQuery();
            CloseConnection();
            return result > 0;
        }
    }
}
