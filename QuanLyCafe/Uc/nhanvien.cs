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
    public partial class nhanvien : UserControl
    {
        BindingSource userList = new BindingSource();
        public user LoginAccount;

        public nhanvien()
        {
            InitializeComponent();
            load();
        }
        void load()
        {
            LoadCategoryIntoCombobox(cbCateStaff);  
            loadUserList(); 
            dtgvNV.DataSource = userList;
            //AddUserBinding();
        }
        void LoadCategoryIntoCombobox(ComboBox cb)
        {
            cb.DataSource = categoryDAO.Instance.GetListCategoryStaff();
            cb.DisplayMember = "name";
        }
        void AddUserBinding()
        {
            txtIdStaff.DataBindings.Add(new Binding("Text", dtgvNV.DataSource, "idUser"));
            txtNameStaff.DataBindings.Add(new Binding("Text", dtgvNV.DataSource, "NameUser"));
            txtEmail.DataBindings.Add(new Binding("Text", dtgvNV.DataSource, "Email"));
            txtPassword.DataBindings.Add(new Binding("Text", dtgvNV.DataSource, "Password"));
            txtPhoneStaff.DataBindings.Add(new Binding("Text", dtgvNV.DataSource, "PhoneNum"));
            cbCateStaff.DataBindings.Add(new Binding("Text", dtgvNV.DataSource, "Type"));
            txtDateBegin.DataBindings.Add(new Binding("Text", dtgvNV.DataSource, "DateBegin"));
        }
        void ClearUserBingding()
        {
            txtIdStaff.DataBindings.Clear();
            txtNameStaff.DataBindings.Clear();
            txtEmail.DataBindings.Clear();
            txtPassword.DataBindings.Clear();
            txtPhoneStaff.DataBindings.Clear();
            cbCateStaff.DataBindings.Clear();
            txtDateBegin.DataBindings.Clear();
        }
        void loadUserList()
        {
            userList.DataSource = userDAO.Instance.GetListUser();
        }

        void resetValueUser()
        {
            txtDateBegin.Text = txtEmail.Text = txtIdStaff.Text = txtNameStaff.Text = txtPassword.Text = txtPhoneStaff.Text = cbCateStaff.Text =  null;
            ClearUserBingding();
        }
        private void btnAddNV_Click(object sender, EventArgs e)
        {
            if (checkDataUser()&& CheckTT())
            {
                string name = txtNameStaff.Text;
                string email = txtEmail.Text;
                string pass = txtPassword.Text;
                string phone = txtPhoneStaff.Text;
                int type  = (cbCateStaff.SelectedItem as category).ID;
                DateTime date = DateTime.Now;
                if (userDAO.Instance.InsertUser(phone, name, email, type, pass, date))
                {
                    resetValueUser();
                    loadUserList();
                    MessageBox.Show("Đã thêm thành công", "Thông báo");
                }
                else
                {
                    MessageBox.Show("Đã có lỗi xảy ra xin thử lại sau!", "Thông báo lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
        }
        public bool checkDataUser()
        {
            if (txtNameStaff.Text == null || txtEmail.Text == null || txtPassword.Text == null || txtPhoneStaff.Text == null || cbCateStaff.SelectedItem == null)
            {
                MessageBox.Show("Bạn nhập dữ liệu chưa đủ", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return false;
            }
           
            else return true;
        }
        bool CheckTT()
        {
             if (!userDAO.Instance.CheckStaffByEmail(txtEmail.Text))
            {
                MessageBox.Show("Đã tồn tại Email này", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                return false;
            }
            else return true;
        }

        private void btnDelNV_Click(object sender, EventArgs e)
        {
            int id = int.Parse(txtIdStaff.Text);
            if (MessageBox.Show("Bạn có thật sự muốn xoá nhân viên này?", "Thông báo", MessageBoxButtons.OKCancel) == System.Windows.Forms.DialogResult.OK)
            {
                
                if (userDAO.Instance.DeleteUser(id))
                {
                    resetValueUser();
                    loadUserList();
                    MessageBox.Show("Đã Xoá thành công", "Thông báo");
                }
                else
                {
                    MessageBox.Show("Đã có lỗi xảy ra xin thử lại sau!", "Thông báo lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
                

        }

        private void BtnUpNV_Click(object sender, EventArgs e)
        {
            if (checkDataUser())
            {
                int id = int.Parse(txtIdStaff.Text);
                string name = txtNameStaff.Text;
                string email = txtEmail.Text;
                string pass = txtPassword.Text;
                string phone = txtPhoneStaff.Text;
                int type = (cbCateStaff.SelectedItem as category).ID;
                if (userDAO.Instance.UpdateUser(phone, name, email, type, pass, id))
                {
                    resetValueUser();
                    loadUserList();
                    MessageBox.Show("Đã sửa thành công", "Thông báo");
                }
                else
                {
                    MessageBox.Show("Đã có lỗi xảy ra xin thử lại sau!", "Thông báo lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
        }

        private void btnSearch_Click(object sender, EventArgs e)
        {
            userList.DataSource = userDAO.Instance.SearchStaffByEmail(txtSearch.Text);
        }

        private void dtgvNV_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            AddUserBinding();
            ClearUserBingding();
        }
    }
}
