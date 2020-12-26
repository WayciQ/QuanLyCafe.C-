using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using QuanLyCafe.DAO;
using QuanLyCafe.DTO;

namespace QuanLyCafe
{
    public partial class fLogin : Form
    {   
        
        public fLogin()
        {
            InitializeComponent();
            this.KeyPreview = true;
        }

        private void btnLogin_Click(object sender, EventArgs e)
        {

            string email = txtEmail.Text;
            string passWord = txtPassword.Text;
            if (userDAO.Instance.Login(email, passWord))
            {
                user loginUser = userDAO.Instance.GetAccountByEmail(email);
                
                fTableManager fTableManager = new fTableManager(loginUser);
                this.Hide();
                fTableManager.ShowDialog();
            }
            else
            {
                MessageBox.Show("Sai tên tài khoản hoặc mật khẩu!");
            }


        }

        private void btnCanel_Click(object sender, EventArgs e)
        {
           
            if (MessageBox.Show("Bạn có thật sự muốn thoát chương trình ?", "Thông báo", MessageBoxButtons.OKCancel) == System.Windows.Forms.DialogResult.OK) Application.Exit();
        }

        private void fLogin_FormClosing(object sender, FormClosingEventArgs e)
        {
           
        }
    }
}
