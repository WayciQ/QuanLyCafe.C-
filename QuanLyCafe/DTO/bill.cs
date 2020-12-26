using System;
using System.Collections.Generic;
using System.Text;
using System.Data;

namespace QuanLyCafe.DTO
{
    class bill
    {
        public bill(int id, DateTime? dateCheckin,int idStaff,int idcustomer, int waitting, float totalPrice, int discount)
        {
            this.ID = id;
            this.DateCheckIn = dateCheckin;
            this.IdStaff = idStaff;
            this.Idcustomer = idcustomer;
            this.Discount = discount;
            this.waittingNum = waitting;
            this.TotalPrice = totalPrice;
        }
        private int discount;

        private int idStaff;
        public int IdStaff
        {
            get => idStaff;
            set => idStaff = value;
        }
        private int waitting;
        public int waittingNum
        {
            get => waitting;
            set => waitting = value;
        }
        private float totalPrice;
        public float TotalPrice
        {
            get => totalPrice;
            set => totalPrice = value;
        }

        private int idcustomer;
        public int Idcustomer
        {
            get => idcustomer;
            set => idcustomer = value;
        }
        public bill(DataRow row)
        {
            this.ID = (int)row["id"];
            this.DateCheckIn = (DateTime?)row["DateCheckIn"];
            this.IdStaff = (int)row["IdStaff"];
            this.Idcustomer = (int)row["IdCustomer"];
            this.Discount = (int)row["discount"];
            this.waittingNum = int.Parse(row["waytingNum"].ToString());
            this.TotalPrice = float.Parse(row["totalprice"].ToString());
        }

        private DateTime? dateCheckIn;
        public DateTime? DateCheckIn
        {
            get => dateCheckIn;
            set => dateCheckIn = value;
        }


        private int iD;

        public int ID { get => iD; set => iD = value; }
        public int Discount { get => discount; set => discount = value; }
    }
}
