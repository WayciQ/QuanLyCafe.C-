using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


namespace QuanLyCafe.DTO
{
    class customer
    {
        public customer(int id, string nameCustomer, string phoneNum, DateTime dateBegin, float payed)
        {
            this.Id = id;
            this.NameCustomer = nameCustomer;
            this.PhoneNum = phoneNum;
            this.DateBegin = dateBegin;
            this.Payed = payed;
        }
        public customer(DataRow row)
        {
            this.Id = (int)row["id"];
            this.NameCustomer = row["name"].ToString();
            this.PhoneNum = row["PhoneNumber"].ToString();
            this.DateBegin = DateTime.Parse(row["DateBegin"].ToString());
            this.Payed = (float)Convert.ToDouble(row["Payed"].ToString());
        }
        private int id;
        public int Id { get => id; set => id = value; }
        private float payed;
        public float Payed { get => payed; set => payed = value; }
        private string nameCustomer;
        public string NameCustomer { get => nameCustomer; set => nameCustomer = value; }
        private string phoneNum;
        public string PhoneNum { get => phoneNum; set => phoneNum = value; }
        private DateTime dateBegin;
        public DateTime DateBegin { get => dateBegin; set => dateBegin = value; }

    }
}
