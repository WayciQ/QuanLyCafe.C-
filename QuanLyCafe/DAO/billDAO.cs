using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using QuanLyCafe.DTO;
using System.Data;
namespace QuanLyCafe.DAO
{
    class billDAO
    {

        private static billDAO instance;
        public static billDAO Instance
        {
            get { if (instance == null) instance = new billDAO(); return billDAO.instance; }
            private set { billDAO.instance = value; }
        }

        private billDAO() { }
        public List<bill> GetListBill()
        {
            List<bill> list = new List<bill>();

            string query = "select * from Bill";

            DataTable data = dataProvider.Instance.ExecuteQuery(query);

            foreach (DataRow item in data.Rows)
            {
                bill bill = new bill(item);
                list.Add(bill);
            }

            return list;
        }
        public DataTable GetListBillByDate(DateTime date)
        {

            return dataProvider.Instance.ExecuteQuery("exec USP_GetListBillByDate @checkIn ", new object[] { date });

            
        }
        public bill GetBillByID(int id)
        {
            string query = "select * from dbo.Bill WHERE id = " + id;

            DataTable data = dataProvider.Instance.ExecuteQuery(query);

            foreach (DataRow item in data.Rows)
            {
                return new bill(item);
            }

            return null;
        }
        public void createBill(int wait, int idCus, int idStaff)
        {
            dataProvider.Instance.ExecuteNonQuery("exec USP_InsertBill @waiting , @idCustomer , @idStaff ", new object[] { wait,idCus,idStaff });
        }
        public void ThanhToan(int id, int discount, float totalPrice)
        {
            string query = "UPDATE dbo.Bill SET discount = " + discount + ", totalPrice = " + totalPrice + " WHERE id = " + id;
            dataProvider.Instance.ExecuteNonQuery(query);

        }
        public bool DeleteBillById(int id)
        {
            BillInforDAO.Instance.DeleteBillInforByIddBill(id);
            string query = string.Format("DELETE  Bill where id = " + id);
            int result = dataProvider.Instance.ExecuteNonQuery(query);
            return result > 0 ;
        }
        public int GetMaxIDBill()
        {
            return (int)dataProvider.Instance.ExecuteScalar("select max(id) from Bill");
        }
    }
}
