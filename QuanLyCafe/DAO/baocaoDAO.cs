using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;

namespace QuanLyCafe.DAO
{
    class baocaoDAO
    {
        private static baocaoDAO instance;
        public static baocaoDAO Instance
        {
            get { if (instance == null) instance = new baocaoDAO(); return baocaoDAO.instance; }
            private set { baocaoDAO.instance = value; }
        }

        private baocaoDAO() { }
        public DataTable GetTopSeller()
        {
            string query = "select * from dbo.Food where id =" +
                                "(select id" +
                                    " from"+
                                        "(select id, sum(count) as total_order," +
                                        "max(sum(count)) over() as maxSm   from billInfo"+
                                        " group by id)"+
                                        "where total_order = maxSm) ";
           
            DataTable data = dataProvider.Instance.ExecuteQuery(query);
            return data;
        }
        public DataTable GetTopBuyer()
        {
            string query = "select top 5 from Customer group by name Order by Payed desc ";
                                

            DataTable data = dataProvider.Instance.ExecuteQuery(query);
            return data;
        }
    }
}
