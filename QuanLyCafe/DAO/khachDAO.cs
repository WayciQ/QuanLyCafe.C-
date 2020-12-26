using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using QuanLyCafe.DTO;

namespace QuanLyCafe.DAO
{
    class khachDAO
    {

        private static khachDAO instance;
        public static khachDAO Instance
        {
            get { if (instance == null) instance = new khachDAO(); return instance; }
            private set { instance = value; }
        }
        private khachDAO() { }
        public List<customer> GetListCus()
        {
            List<customer> list = new List<customer>();

            string query = "select * from Customer";

            DataTable data = dataProvider.Instance.ExecuteQuery(query);

            foreach (DataRow item in data.Rows)
            {
                customer cus = new customer(item);
                list.Add(cus);
            }

            return list;
        }
        public List<customer> SearchCustomerByPhone(string phone)
        {
            List<customer> list = new List<customer>();

            string query = string.Format("SELECT * FROM dbo.Customer WHERE dbo.fuConvertToUnsign1(PhoneNumber) LIKE N'%' + dbo.fuConvertToUnsign1(N'{0}') + '%'", phone);

            DataTable data = dataProvider.Instance.ExecuteQuery(query);

            foreach (DataRow item in data.Rows)
            {
                customer cus = new customer(item);
                list.Add(cus);
            }
            return list;
        }
        public customer GetCustomerByPhone(string phone)
        {
            string query = string.Format("SELECT * FROM dbo.Customer WHERE PhoneNumber = N'{0}' ", phone);

            DataTable data = dataProvider.Instance.ExecuteQuery(query);

            foreach (DataRow item in data.Rows)
            {
                return new customer(item);
            }

            return null;
        }
        public customer GetCustomerByID(int id)
        {
            string query = string.Format("SELECT * FROM dbo.Customer WHERE id = N'{0}' ", id);

            DataTable data = dataProvider.Instance.ExecuteQuery(query);

            foreach (DataRow item in data.Rows)
            {
                return new customer(item);
            }

            return null;
        }
        public bool  CheckCustomerByPhone(string phone)
        {
            List<customer> list = new List<customer>();

            string query = string.Format("SELECT * FROM dbo.Customer WHERE PhoneNumber = N'{0}' ", phone);

            DataTable data = dataProvider.Instance.ExecuteQuery(query);

            foreach (DataRow item in data.Rows)
            {
                customer cus = new customer(item);
                list.Add(cus);
            }
            return !list.Any();
        }

        public bool InsertCustomer(string name, string phone,DateTime date)
        {
            string query = string.Format("INSERT dbo.Customer ( name, PhoneNumber, DateBegin)VALUES  ( N'{0}', N'{1}', '{2}')", name, phone, date);
            int result = dataProvider.Instance.ExecuteNonQuery(query);
            return result > 0;
        }
        public bool UpdateCustomer(int id, string name, string phone)
        {
            string query = string.Format("UPDATE dbo.Customer SET name = N'{0}', PhoneNumber = N'{1}', WHERE id = {2}", name,phone, id );
            int result = dataProvider.Instance.ExecuteNonQuery(query);
            return result > 0;
        }
        public bool UpdateCustomerPayed(int id, float Payed)
        {
            string query = string.Format("UPDATE dbo.Customer SET Payed = N'{0}' WHERE id = {1}", Payed, id);
            int result = dataProvider.Instance.ExecuteNonQuery(query);
            return result > 0;
        }

        public bool DeleteCustomer(int id)
        {
            string query = string.Format("Delete Customer where id = {0}", id);
            int result = dataProvider.Instance.ExecuteNonQuery(query);
            return result > 0;
        }
    }
}
