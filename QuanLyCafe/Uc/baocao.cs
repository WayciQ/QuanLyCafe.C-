using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using QuanLyCafe.DTO;
using QuanLyCafe.DAO;

namespace QuanLyCafe.Uc
{
    
    public partial class baocao : UserControl
    {
        BindingSource DataBaocao = new BindingSource();
        public baocao()
        {
            InitializeComponent();
        }
        //int Action = -1;
        
        
        void loadCbDT(ComboBox cb)
        {
            cb.Items.Clear();
            cb.Text = null;
            string a = "Theo tháng";
            cb.Items.Add(a);
        }

        void loadCbKH(ComboBox cb)
        {
            cb.Text = null;
            cb.Items.Clear();
            string a = "Khách Hàng mua nhiều nhất";
            cb.Items.Add(a);
        }
        void loadCbSP(ComboBox cb)
        {
            cb.Text = null;
            cb.Items.Clear();
            string a = "Sản phẩm bán chạy";
            cb.Items.Add(a);
        }
        void loadCbNV(ComboBox cb)
        {
            cb.Text = null;
            cb.Items.Clear();
            string a = "Nhân viên ...";
            cb.Items.Add(a);
        }


        private void cbMain_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (cbMain.SelectedItem.ToString() == "Khách hàng")
            {
                loadCbKH(cbFollow);
            }
            else if (cbMain.SelectedItem.ToString()  == "Doanh thu")
            {
                loadCbDT(cbFollow); 
            }
            else if (cbMain.SelectedItem.ToString() == "Hàng hoá")
            {
                loadCbSP(cbFollow);
            }
            else if (cbMain.SelectedItem.ToString() == "Nhân viên")
            {
                loadCbNV(cbFollow);
            }
        }

        private void btnCreReport_Click(object sender, EventArgs e)
        {
            DataBaocao.DataSource = baocaoDAO.Instance.GetTopBuyer();
            dtgvBC.DataSource = DataBaocao;
        }
    }
}
