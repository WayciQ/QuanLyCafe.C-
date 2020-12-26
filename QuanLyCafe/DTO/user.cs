using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace QuanLyCafe.DTO
{
    public class user
    {
        public user(int id, string nameUser, string email, int type, string passWord, DateTime dateBegin,string phoneNum)
        {
            this.idUser = id;
            this.NameUser = nameUser;
            this.Email = email;
            this.Type = type;
            this.Password = passWord;
            this.DateBegin = dateBegin;
            this.PhoneNum = phoneNum;
        }
        public user(DataRow row)
        {
            this.idUser = int.Parse(row["id"].ToString());
            this.NameUser = row["UserName"].ToString();
            this.Email = row["Email"].ToString();
            this.Type = int.Parse(row["Type"].ToString()) ; 
            this.Password = row["PassWord"].ToString();
            this.DateBegin = DateTime.Parse(row["DateBegin"].ToString());
            this.PhoneNum = row["PhoneNum"].ToString();
        }
        private int id;
        public int idUser { get => id; set => id = value; }
        private string nameUser;
        public string NameUser { get => nameUser; set => nameUser = value; }
        private string email;
        public string Email { get => email; set => email = value; }
        private int type;
        public int Type { get => type; set => type = value; }
        private string phoneNum;
        public string PhoneNum { get => phoneNum; set => phoneNum = value; }
        private string password;
        public string Password { get => password; set => password = value; }
        private DateTime dateBegin;
        public DateTime DateBegin { get => dateBegin; set => dateBegin = value; }






    }
}
