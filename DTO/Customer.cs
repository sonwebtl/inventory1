using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
using System.Data.SqlClient;

namespace quanlykho.DTO
{
    public class Customer
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

        private string email;
        public string Email
        {
            get { return email; }
            set { email = value; }
        }

        private string phone;
        public string Phone
        {
            get { return phone; }
            set { phone = value; }
        }

        public Customer(int id, string name, string email, string phone)
        {
            this.ID = id;
            this.Name = name;
            this.Email = email;
            this.Phone = phone;
        }

        public Customer(DataRow row)
        {
            this.ID = (int)row["id"];
            this.Name = row["name"].ToString();
            this.Email = row["email"].ToString();
            this.Phone = row["phone"].ToString();
        }
    }
}
