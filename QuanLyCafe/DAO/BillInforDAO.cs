using QuanLyCafe.DTO;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;

namespace QuanLyCafe.DAO
{
    class BillInforDAO
    {
        private static BillInforDAO instance;

        public static BillInforDAO Instance
        {
            get { if (instance == null) instance = new BillInforDAO(); return BillInforDAO.instance; }
            private set { BillInforDAO.instance = value; }
        }

        private BillInforDAO() { }

        public void InsertBillInfo(int idBill, int idFood, int count)
        {
            dataProvider.Instance.ExecuteNonQuery("exec USP_InsertBillInfo @idBill , @idFood , @count ", new object[] { idBill, idFood, count });
        }

        public void DeleteBillInforByFoodID(int id,int idFood)
        {
            dataProvider.Instance.ExecuteQuery("delete dbo.BillInfo where idBill = " + id + "and  idFood = " + idFood);
        }
        public void DeleteBillInforByIddBill(int id)
        {
            dataProvider.Instance.ExecuteQuery("delete dbo.BillInfo where idBill = " + id );
        }
        public List<Cart> GetCart(int idBill)
        {
            List<Cart> list = new List<Cart>();
            DataTable data = dataProvider.Instance.ExecuteQuery("select f.name as [Tên Món], bi.count as [Số lượng] ,f.price as [Giá Thành], f.price*bi.count as [Tổng Tiền] from dbo.BillInfo as bi, dbo.Bill as b, dbo.Food as f where bi.idBill = b.id and bi.idFood = f.id   and b.id = " + idBill);

            foreach (DataRow item in data.Rows)
            {
                Cart cus = new Cart(item);
                list.Add(cus);
            }
            return list;
        }
    }
}
