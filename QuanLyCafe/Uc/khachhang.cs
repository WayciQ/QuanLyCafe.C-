using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using QuanLyCafe.DAO;
using QuanLyCafe.DTO;

namespace QuanLyCafe.Uc
{
    public partial class khachhang : UserControl
    {
        BindingSource customerList = new BindingSource();
        public khachhang()
        {
            InitializeComponent();
            loadCus();
        }
        void loadCus()
        {
            loadListCus();
            dtgvKH.DataSource = customerList;
            
        }
        void AddCusBinding()
        {
            txtIdCus.DataBindings.Add(new Binding("Text", dtgvKH.DataSource, "Id"));
            txtNameCus.DataBindings.Add(new Binding("Text", dtgvKH.DataSource, "NameCustomer"));
            txtDate.DataBindings.Add(new Binding("Text", dtgvKH.DataSource, "DateBegin"));
            txtPhone.DataBindings.Add(new Binding("Text", dtgvKH.DataSource, "PhoneNum"));
            txtPay.DataBindings.Add(new Binding("Text", dtgvKH.DataSource, "Payed"));
        }
        void ClearCusBinding()
        {
            txtIdCus.DataBindings.Clear();
            txtNameCus.DataBindings.Clear();
            txtDate.DataBindings.Clear();
            txtPhone.DataBindings.Clear();
            txtPay.DataBindings.Clear();
        }
        void loadListCus()
        {
            customerList.DataSource = khachDAO.Instance.GetListCus();
        }
        bool checkDataKH()
        {
            if (txtNameCus.Text == null ||  txtPhone.Text == null)
            {
                MessageBox.Show("Bạn nhập dữ liệu chưa đủ", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return false;
            }
            
            else return true;
        }
        bool CheckTT()
        {
            if (!khachDAO.Instance.CheckCustomerByPhone(txtPhone.Text))
            {
                MessageBox.Show("Đã tồn tại số điện thoại này", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                return false;
            }
            else return true;
        }
        void resetKH()
        {
            txtDate.Text = null;
            txtIdCus.Text = null;
            txtNameCus.Text = null;
            txtPay.Text = null;
            txtPhone.Text = null;
        }
        private void btnAdd_Click(object sender, EventArgs e)
        {
            if (checkDataKH()&& CheckTT())
            {
                string name = txtNameCus.Text;
                string phone = txtPhone.Text;
                DateTime date = DateTime.Now;
                if(khachDAO.Instance.InsertCustomer(name,phone,date))
                {
                    resetKH();
                    loadListCus();
                    MessageBox.Show("Đã thêm thành công", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
                else
                {
                    MessageBox.Show("Đã có lỗi xảy ra xin thử lại sau!", "Thông báo lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
        }

        private void btnDel_Click(object sender, EventArgs e)
        {
            int id = int.Parse(txtIdCus.Text);
            if (MessageBox.Show("Bạn có thật sự muốn xoá khách hàng này?", "Thông báo", MessageBoxButtons.OKCancel) == System.Windows.Forms.DialogResult.OK)
            {
                
                if (khachDAO.Instance.DeleteCustomer(id))
                {
                    resetKH();
                    loadListCus();
                    MessageBox.Show("Đã xoá thành công", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
                else
                {
                    MessageBox.Show("Đã có lỗi xảy ra xin thử lại sau!", "Thông báo lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
                
        }

        private void btnUp_Click(object sender, EventArgs e)
        {
            if (checkDataKH())
            {
                int id = int.Parse(txtIdCus.Text);
                string name = txtNameCus.Text;
                string phone = txtPhone.Text;
                if (khachDAO.Instance.UpdateCustomer(id,name, phone))
                {
                    resetKH();
                    loadListCus();
                    MessageBox.Show("Đã sửa thành công", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
                else
                {
                    MessageBox.Show("Đã có lỗi xảy ra xin thử lại sau!", "Thông báo lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
        }

        private void btnSearchKhach_Click(object sender, EventArgs e)
        {
            customerList.DataSource = khachDAO.Instance.SearchCustomerByPhone(txtSearch.Text);
        }

        private void dtgvKH_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            AddCusBinding();
            ClearCusBinding();
        }

        private void txtPhone_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar) &&
           (e.KeyChar != '.'))
            {
                e.Handled = true;
            }

            // only allow one decimal point
            if ((e.KeyChar == '.') && ((sender as TextBox).Text.IndexOf('.') > -1))
            {
                e.Handled = true;
            }
        }

        private void txtSearch_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar) &&
           (e.KeyChar != '.'))
            {
                e.Handled = true;
            }

            // only allow one decimal point
            if ((e.KeyChar == '.') && ((sender as TextBox).Text.IndexOf('.') > -1))
            {
                e.Handled = true;
            }
        }

        private void label1_Click(object sender, EventArgs e)
        {
            loadCus();
        }
    }
}
