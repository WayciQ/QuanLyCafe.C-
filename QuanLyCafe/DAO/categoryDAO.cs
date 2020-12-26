using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using QuanLyCafe.DTO;

namespace QuanLyCafe.DAO
{
    class categoryDAO
    {
        private static categoryDAO instance;

        public static categoryDAO Instance
        {
            get { if (instance == null) instance = new categoryDAO(); return categoryDAO.instance; }
            private set { categoryDAO.instance = value; }
        }

        private categoryDAO() { }


        public List<category> GetListCategory()
        {
            List<category> list = new List<category>();

            string query = "select * from FoodCategory";

            DataTable data = dataProvider.Instance.ExecuteQuery(query);

            foreach (DataRow item in data.Rows)
            {
                category category = new category(item);
                list.Add(category);
            }

            return list;
        }
        public List<category> GetListCategoryStaff()
        {
            List<category> list = new List<category>();

            string query = "select * from StaffCategory";

            DataTable data = dataProvider.Instance.ExecuteQuery(query);

            foreach (DataRow item in data.Rows)
            {
                category category = new category(item);
                list.Add(category);
            }

            return list;
        }

        public List<category> SearchCategoryByName(string name)
        {
            List<category> list = new List<category>();

            string query = string.Format("SELECT * FROM dbo.FoodCategory WHERE dbo.fuConvertToUnsign1(name) LIKE N'%' + dbo.fuConvertToUnsign1(N'{0}') + '%'", name);

            DataTable data = dataProvider.Instance.ExecuteQuery(query);

            foreach (DataRow item in data.Rows)
            {
                category category = new category(item);
                list.Add(category);
            }

            return list;
        }

        public category GetCategoryByID(int id)
        {
            category category = null;

            List<category> list = new List<category>();

            string query = "select * from FoodCategory where id = " + id;

            DataTable data = dataProvider.Instance.ExecuteQuery(query);

            foreach (DataRow item in data.Rows)
            {
                category = new category(item);
                return category;
            }

            return category;
        }

        public DataTable GetAllCategory()
        {
            string query = "select * from FoodCategory";
            DataTable data = dataProvider.Instance.ExecuteQuery(query);
            return data;
        }


        public bool insertCategory(string name)
        {
            string queryInsert = string.Format("insert FoodCategory(name) values (N'{0}')", name);

            int result = dataProvider.Instance.ExecuteNonQuery(queryInsert);
            return result > 0;

        }
        public bool UpdateCategory(int id, string name)
        {
            string query = string.Format("update FoodCategory set name = N'{0}' where id = {1}", name, id);

            int result = dataProvider.Instance.ExecuteNonQuery(query);
            return result > 0;

        }
        public bool DeleteCategory(int idCategory)
        {
            string query = string.Format("delete FoodCategory where id = '{0}'", idCategory);

            int result = dataProvider.Instance.ExecuteNonQuery(query);
            return result > 0;

        }
    }
}
