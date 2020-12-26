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
    public partial class suaThongTin : Form
    {
        
        int id;
        private user LoginAccount;
        public user loginAccount
        {
            get { return LoginAccount; }
            set { LoginAccount = value; setStaff(); }
        }
        void setStaff()
        {
            id = loginAccount.idUser;
            txtNameStaff.Text = loginAccount.NameUser;
            txtEmail.Text = loginAccount.Email;
            txtPhoneStaff.Text = loginAccount.PhoneNum;
            txtNewPass1.Text = txtNewPass2.Text = "";
        }
        public suaThongTin()
        {
            InitializeComponent();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            this.Close();
        }
        public bool checkDataUser()
        {
            if (txtNameStaff.Text == null || txtEmail.Text == null  || txtPhoneStaff.Text == null)
            {
                MessageBox.Show("Bạn nhập dữ liệu chưa đủ", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return false;
            }
            else if (txtEmail.Text != loginAccount.Email && !userDAO.Instance.CheckStaffByEmail(txtEmail.Text))
            {
                MessageBox.Show("Đã tồn tại Email này", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                return false;
            }
            else if(txtNewPass1.Text != txtNewPass2.Text)
            {
                MessageBox.Show("vui lòng nhập đúng mật khẩu", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                return false;
            }
            else return true;
        }
        private void btnSave_Click(object sender, EventArgs e)
        {
            if (checkDataUser())
            {
                string name = txtNameStaff.Text;
                string email = txtEmail.Text;
                string pass1 = txtNewPass1.Text;
                string pass2 = txtNewPass2.Text;
                string phone = txtPhoneStaff.Text;
                if (userDAO.Instance.UpdateAccount(email, pass1, pass2, name, phone,id))
                {
                    MessageBox.Show("Đã thêm thành công", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
                else
                {
                    MessageBox.Show("Đã có lỗi xảy ra xin thử lại sau!", "Thông báo lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
        }
    }
}
