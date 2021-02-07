using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
using System.Data.SqlClient;

namespace quanlykho.DTO
{
    public class Product
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

        private int qty;
        public int Qty
        {
            get { return qty; }
            set { qty = value; }
        }
        private float price;
        public float Price
        {
            get { return price; }
            set { price = value; }
        }

        private int idCat;
        public int IdCat
        {
            get { return idCat; }
            set { idCat = value; }
        }

        public Product(int id, string name,int idCat, float price,int qty)
        {
            this.ID = id;
            this.Name = name;
            this.IdCat = idCat;
            this.Price = price;
            this.Qty = qty;
        }

        public Product(DataRow row)
        {
            this.ID = (int)row["id"];
            this.Name = row["name"].ToString();
            this.IdCat = (int)row["idCat"];
            this.Price = (float)Convert.ToDouble(row["price"]);
            this.Qty = (int)row["qty"];
        }
    }
}
