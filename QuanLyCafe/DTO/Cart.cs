using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;

namespace QuanLyCafe.DTO
{
    class Cart
    {
        public Cart(string name, int SL, float unitPrice, float totalPrice)
        {
            this.ItemName = name;
            this.SL = SL;
            this.UnitPrice = unitPrice;
            this.TotalPrice = totalPrice;
        }
        public string ItemName { get; set; }
        public int SL { get; set; }
        public float UnitPrice { get; set; }
        public float TotalPrice { get; set; }

        public Cart(DataRow row)
        {
            this.ItemName = row["Tên Món"].ToString();
            this.SL = int.Parse(row["Số Lượng"].ToString());
            this.UnitPrice = int.Parse(row["Giá Thành"].ToString());
            this.TotalPrice = int.Parse(row["Tổng Tiền"].ToString());

        }
    }
}
