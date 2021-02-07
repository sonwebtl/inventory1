using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
using System.Data.SqlClient;

namespace quanlykho.DTO
{
    public class Category
    {
        private int iD;
        public int ID
        {
            get { return iD; }
            set { iD = value; }
        }

        private string name;
        public string Name
        {
            get { return name; }
            set { name = value; }
        }

        public Category(int id, string name)
        {
            this.Name = name;
            this.ID = id;
        }

        public Category(DataRow row)
        {
            this.ID = (int)row["id"];
            this.Name = row["name"].ToString();
        }
    }
}
