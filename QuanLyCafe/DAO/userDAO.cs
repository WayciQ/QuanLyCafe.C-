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
    class userDAO
    {
        private static userDAO instance;

        public static userDAO Instance
        {
            get { if (instance == null) instance = new userDAO(); return instance; }
            private set { instance = value; }
        }
        public bool Login(string Email, string passWord)
        {
            string query = "USP_Login @email , @passWord";
            DataTable result = dataProvider.Instance.ExecuteQuery(query, new object[] { Email, passWord });
            return result.Rows.Count > 0;
        }

        private userDAO() { }

        public user GetAccountByEmail(string email)
        {
            DataTable data = dataProvider.Instance.ExecuteQuery("Select * from Staff where Email = '" + email + "'");

            foreach (DataRow item in data.Rows)
            {
                return new user(item);
            }

            return null;
        }
        public user GetAccountByID(int id)
        {
            DataTable data = dataProvider.Instance.ExecuteQuery("Select * from Staff where id = '" + id + "'");

            foreach (DataRow item in data.Rows)
            {
                return new user(item);
            }

            return null;
        }

        public bool UpdateAccount(string email, string pass, string newPass, string userName, string Phone,int id)
        {
            int result = dataProvider.Instance.ExecuteNonQuery("exec USP_UpdateStaff @userName , @email , @password , @newPassword , @Phone , @id", new object[] { userName, email, pass, newPass, Phone,id });

            return result > 0;
        }
       

        public bool InsertUser(string phone, string nameUser, string email, int type, string passWord, DateTime dateBegin)
        {
            string query = string.Format("INSERT dbo.Staff ( PhoneNum, UserName, Email, Type, PassWord, dateBegin )VALUES  ( N'{0}', N'{1}', N'{2}', N'{3}', N'{4}', '{5}')", phone, nameUser, email, type, passWord, dateBegin);
            int result = dataProvider.Instance.ExecuteNonQuery(query);

            return result > 0;
        }
        public bool UpdateUser(string phone, string nameUser, string email, int type, string passWord,int id)
        {
            string query = string.Format("UPDATE dbo.Staff SET PhoneNum = N'{0}', UserName = N'{1}', Email = N'{2}', Type = N'{3}', PassWord = N'{4}' WHERE id = {5}", phone, nameUser, email, type, passWord,id);
            int result = dataProvider.Instance.ExecuteNonQuery(query);

            return result > 0;
        }
        public List<user> GetListUser()
        {
            List<user> list = new List<user>();

            string query = "select * from Staff";

            DataTable data = dataProvider.Instance.ExecuteQuery(query);

            foreach (DataRow item in data.Rows)
            {
                user user = new user(item);
                list.Add(user);
            }

            return list;
        }

        public List<user> SearchStaffByEmail(string name)
        {
            List<user> list = new List<user>();

            string query = string.Format("SELECT * FROM dbo.Staff WHERE dbo.fuConvertToUnsign1(Email) LIKE N'%' + dbo.fuConvertToUnsign1(N'{0}') + '%'", name);

            DataTable data = dataProvider.Instance.ExecuteQuery(query);

            foreach (DataRow item in data.Rows)
            {
                user cus = new user(item);
                list.Add(cus);
            }
            return list;
        }
        public bool CheckStaffByEmail(string name)
        {
            List<user> list = new List<user>();

            string query = string.Format("SELECT * FROM dbo.Staff WHERE Email = N'{0}'", name);

            DataTable data = dataProvider.Instance.ExecuteQuery(query);

            foreach (DataRow item in data.Rows)
            {
                user cus = new user(item);
                list.Add(cus);
            }
            return !list.Any();
        }
        public bool DeleteUser(int id)
        {
            string query = string.Format("Delete Staff where id = {0}", id);
            int result = dataProvider.Instance.ExecuteNonQuery(query);

            return result > 0;
        }
        public bool ResetPassword(int id)
        {
            string query = string.Format("update Staff set password = N'1' where id = {0}", id);
            int result = dataProvider.Instance.ExecuteNonQuery(query);

            return result > 0;
        }   


    }
}
