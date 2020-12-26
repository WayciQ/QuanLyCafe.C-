using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using QuanLyCafe.DTO;
using QuanLyCafe.Uc;

namespace QuanLyCafe
{
    public partial class fTableManager : Form
    {
        banhang banhang = new banhang();
        hanghoa hanghoa = new hanghoa();
        nhanvien nhanvien = new nhanvien();
        khachhang khachhang = new khachhang();
        hoadon hoadon = new hoadon();
        baocao baocao = new baocao();
        public user loginAccount;
        public user LoginAccount
        {
            get { return loginAccount; }
            set { loginAccount = value; ChangeAccountAdmin(loginAccount.Type); }
        }
       
        public fTableManager(user Acc)
        {
            InitializeComponent();
            this.LoginAccount = Acc;
            pnlDisplay.Controls.Clear();
            banhang.loginAccount = Acc;

        }
        void ChangeAccountAdmin(int type)
        {
            if (type == 1)
                btnNhanvien.Enabled = true;
            else
                btnNhanvien.Enabled = false;
        }

        private void fTableManager_Load(object sender, EventArgs e)
        {
            //banhang.loginAccount = LoginAccount;
            pnlDisplay.Controls.Add(banhang);
            btnBanhang.BackColor = System.Drawing.Color.LightSkyBlue;
        }

        private void btnBanhang_Click(object sender, EventArgs e)
        {
            
            //banhang.loginAccount = LoginAccount;
            pnlDisplay.Controls.Add(banhang);
            btnBanhang.BackColor = System.Drawing.Color.LightSkyBlue;
            btnBaocao.BackColor = System.Drawing.Color.AliceBlue;
            btnHanghoa.BackColor = System.Drawing.Color.AliceBlue;
            btnHoadon.BackColor = System.Drawing.Color.AliceBlue;
            btnkhachhang.BackColor = System.Drawing.Color.AliceBlue;
            btnNhanvien.BackColor = System.Drawing.Color.AliceBlue;
            hanghoa.Visible = false;
            nhanvien.Visible = false;
            khachhang.Visible = false;
            banhang.Visible = true;
            hoadon.Visible = false;
            baocao.Visible = false;

        }

        private void btnHanghoa_Click(object sender, EventArgs e)
        {
            pnlDisplay.Controls.Add(hanghoa);
            hanghoa.Visible = true;
            nhanvien.Visible = false;
            khachhang.Visible = false;
            banhang.Visible = false;
            hoadon.Visible = false;
            baocao.Visible = false;
            btnBanhang.BackColor = System.Drawing.Color.AliceBlue;
            btnBaocao.BackColor = System.Drawing.Color.AliceBlue;
            btnHanghoa.BackColor = System.Drawing.Color.LightSkyBlue;
            btnHoadon.BackColor = System.Drawing.Color.AliceBlue;
            btnkhachhang.BackColor = System.Drawing.Color.AliceBlue;
            btnNhanvien.BackColor = System.Drawing.Color.AliceBlue;

        }

        private void btnNhanvien_Click(object sender, EventArgs e)
        {
            nhanvien.LoginAccount = LoginAccount;
            pnlDisplay.Controls.Add(nhanvien);
            nhanvien.Visible = true;
            hanghoa.Visible = false;
            khachhang.Visible = false;
            banhang.Visible = false;
            hoadon.Visible = false;
            baocao.Visible = false;
            btnBanhang.BackColor = System.Drawing.Color.AliceBlue;
            btnBaocao.BackColor = System.Drawing.Color.AliceBlue;
            btnHanghoa.BackColor = System.Drawing.Color.AliceBlue;
            btnHoadon.BackColor = System.Drawing.Color.AliceBlue;
            btnkhachhang.BackColor = System.Drawing.Color.AliceBlue;
            btnNhanvien.BackColor = System.Drawing.Color.LightSkyBlue;
        }

        private void btnkhachhang_Click(object sender, EventArgs e)
        {
            pnlDisplay.Controls.Add(khachhang);
            hanghoa.Visible = false;
            nhanvien.Visible = false;
            khachhang.Visible = true;
            banhang.Visible = false;
            hoadon.Visible = false;
            baocao.Visible = false;
            btnBanhang.BackColor = System.Drawing.Color.AliceBlue;
            btnBaocao.BackColor = System.Drawing.Color.AliceBlue;
            btnHanghoa.BackColor = System.Drawing.Color.AliceBlue;
            btnHoadon.BackColor = System.Drawing.Color.AliceBlue;
            btnkhachhang.BackColor = System.Drawing.Color.LightSkyBlue;
            btnNhanvien.BackColor = System.Drawing.Color.AliceBlue;
        }

        private void btnHoadon_Click(object sender, EventArgs e)
        {
            pnlDisplay.Controls.Add(hoadon);
            hanghoa.Visible = false;
            nhanvien.Visible = false;
            khachhang.Visible = false;
            banhang.Visible = false;
            hoadon.Visible = true;
            baocao.Visible = false;
            btnBanhang.BackColor = System.Drawing.Color.AliceBlue;
            btnBaocao.BackColor = System.Drawing.Color.AliceBlue;
            btnHanghoa.BackColor = System.Drawing.Color.AliceBlue;
            btnHoadon.BackColor = System.Drawing.Color.LightSkyBlue;
            btnkhachhang.BackColor = System.Drawing.Color.AliceBlue;
            btnNhanvien.BackColor = System.Drawing.Color.AliceBlue;

        }

        private void btnBaocao_Click(object sender, EventArgs e)
        {
            pnlDisplay.Controls.Add(baocao);
            hanghoa.Visible = false;
            nhanvien.Visible = false;
            khachhang.Visible = false;
            banhang.Visible = false;
            hoadon.Visible = false;
            baocao.Visible = true;
            btnBanhang.BackColor = System.Drawing.Color.AliceBlue;
            btnBaocao.BackColor = System.Drawing.Color.LightSkyBlue;
            btnHanghoa.BackColor = System.Drawing.Color.AliceBlue;
            btnHoadon.BackColor = System.Drawing.Color.AliceBlue;
            btnkhachhang.BackColor = System.Drawing.Color.AliceBlue;
            btnNhanvien.BackColor = System.Drawing.Color.AliceBlue;
        }

        private void fTableManager_FormClosed(object sender, FormClosedEventArgs e)
        {
            this.Close();
            fLogin fLogin = new fLogin();
            fLogin.Show();
        }
    }
}
