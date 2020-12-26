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
using System.IO;

namespace QuanLyCafe.Uc
{
    public partial class banhang : UserControl
    {


        float TotalPrice = 0;
        int WaitNum;
        private user LoginAccount;
        public user loginAccount
        {
            get { return LoginAccount; }
            set { LoginAccount = value; setStaff(); }
        }
        int idStaff;
        int idCustomer = 3;
        void setStaff()
        {
            if(loginAccount.Type == 1)
            {
                AccountMENU.Text = "Quản lý: " + loginAccount.NameUser;
            }
            else if (loginAccount.Type == 2)
            {
                AccountMENU.Text = "Nhân viên: " + loginAccount.NameUser;
            }

            idStaff = loginAccount.idUser;
        }                                                                                       
        public banhang()
        {
            InitializeComponent();
            loadListCategoryToCbBox(cbCate);
            loadListFoodToCbBox(cbFood, (cbCate.SelectedItem as category).ID);
        }

       
        void AddBindingCb()
        {
            cbFood.DataBindings.Add(new Binding("Text", dtgvBH.DataSource, "itemName"));
        }
        void ClearBindingCb()
        {
            cbFood.DataBindings.Clear();
        }
        void loadListCategoryToCbBox(ComboBox cb)
        {
            cb.DataSource = categoryDAO.Instance.GetListCategory();
            cb.DisplayMember = "name";
        }
        void loadListFoodToCbBox(ComboBox cb,int id)
        {
            cb.DataSource = foodDAO.Instance.GetFoodByCategoryID(id);
            cb.DisplayMember = "name";
        }

        private void btnSearchKhach_Click(object sender, EventArgs e)
        {
            if (!khachDAO.Instance.CheckCustomerByPhone(txtPhoneCus.Text))
            {
                customer  list = khachDAO.Instance.GetCustomerByPhone(txtPhoneCus.Text);
                txtNameCus.Text = list.NameCustomer;
                idCustomer = list.Id;
                if(txtWaiting.Text != null)
                    WaitNum = int.Parse(txtWaiting.Text);
            }
            else
            {
                MessageBox.Show("Không tìm thấy khách hàng !", "Thông báo lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
                txtNameCus.Text = "Vãng lai";
                txtPhoneCus.Text = "0";
            }
        }

        private void btnAddKhach_Click(object sender, EventArgs e)
        {
            themKhach themkhach = new themKhach();
            themkhach.Show();
        }
        #region task bar 
        private void sửaThôngTinToolStripMenuItem_Click(object sender, EventArgs e)
        {

            suaThongTin suaThongTin = new suaThongTin();
            suaThongTin.loginAccount = loginAccount;
            suaThongTin.ShowDialog();
        }

        private void đăngXuấtToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.ParentForm.Close();
        }
        #endregion
        int InstanceState = 0;
        int idbill;
        private void btnAddFood_Click(object sender, EventArgs e)
        {
            int idFood = (cbFood.SelectedItem as food).ID;
            int count = 1;
            if (InstanceState == 0)
            {
                billDAO.Instance.createBill(WaitNum, idCustomer, idStaff);
                idbill = billDAO.Instance.GetMaxIDBill();
                BillInforDAO.Instance.InsertBillInfo(idbill, idFood, count);
                InstanceState++;
            }
            else
            {
                BillInforDAO.Instance.InsertBillInfo(idbill, idFood, count);
            }
            ShowListBill(idbill);
        }
        void ShowListBill(int id)
        {
            
            dtgvBH.DataSource = BillInforDAO.Instance.GetCart(id);
            if(dtgvBH.Rows.Count > 0)
            {
                float rowMoney = float.Parse(dataProvider.Instance.ExecuteScalar("select sum(f.price*bi.count) from dbo.BillInfo as bi, dbo.Bill as b, dbo.Food  as f where bi.idBill = b.id and bi.idFood = f.id  and b.id = " + id).ToString());
                txtTotalPrice.Text = rowMoney.ToString();
                txtPayedPrice.Text = rowMoney.ToString();
                txtFund.Text = (float.Parse(txtPay.Text) - rowMoney).ToString();
                TotalPrice = rowMoney;
            }
            else
            {
                txtPayedPrice.Text = "0";
                txtTotalPrice.Text = "0";
                txtFund.Text = "0";
            }
            
        }
        
        
        private void btnTT_Click(object sender, EventArgs e)
        {

            if (InstanceState != 0)
            {

                printPreviewDialog1.Document = printDocument1;
                printPreviewDialog1.ShowDialog();
                billDAO.Instance.ThanhToan(idbill, discount, TotalPrice);
                khachDAO.Instance.UpdateCustomerPayed(idCustomer, TotalPrice);
                resetAll();
            }

        }
       
       
        void resetAll()
        {
            dtgvBH.DataSource = null;
            txtTotalPrice.ResetText();
            InstanceState = 0;
            txtWaiting.ResetText();
            txtNameCus.ResetText();
            txtPhoneCus.ResetText();
            txtPayedPrice.ResetText();
            txtDiscount.Text = "0";
            txtFund.Text = "0";
        }

        private void dtgvBH_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            AddBindingCb();
            ClearBindingCb();
        }

        private void btnDelFood_Click(object sender, EventArgs e)
        {
            int idFood = (cbFood.SelectedItem as food).ID;
            BillInforDAO.Instance.DeleteBillInforByFoodID(idbill, idFood);
            ShowListBill(idbill);
        }
        int discount = 0;
        private void txtPay_TextChanged(object sender, EventArgs e)
        {
            if(txtPay.Text == "")
            {
                txtPay.Text = "0";
            }
            if (txtPay.Text != null && txtTotalPrice != null)
            {
                float pay = float.Parse(txtPay.Text);
                txtFund.Text = (pay - TotalPrice).ToString();
            }
        }

        private void txtDiscount_TextChanged(object sender, EventArgs e)
        {

            if (txtDiscount.Text == "")
            {
                txtDiscount.Text = "0";
            }
            else
            {
                int dis = int.Parse(txtDiscount.Text);
                if (dis != 0)
                {
                    if (dis > 100)
                    {
                        txtDiscount.Text = "100";
                    }
                    else if (dis < 0)
                    {
                        txtDiscount.Text = "0";
                    }
                    discount = int.Parse(txtDiscount.Text);
                    float a = TotalPrice;
                    a = a - (a / 100) * discount;
                    txtTotalPrice.Text = a.ToString();
                }
            }


        }
        #region KeyPress
        private void txtPay_KeyPress(object sender, KeyPressEventArgs e)
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

        private void txtDiscount_KeyPress(object sender, KeyPressEventArgs e)
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

        private void txtWaiting_KeyPress(object sender, KeyPressEventArgs e)
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

        private void txtPhoneCus_KeyPress(object sender, KeyPressEventArgs e)
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
        #endregion

        private void printDocument1_PrintPage(object sender, System.Drawing.Printing.PrintPageEventArgs e)
        {
            e.Graphics.DrawString("The Coffee House", new Font("Arial", 16, FontStyle.Regular), Brushes.Black, new Point(290, 90));
            e.Graphics.DrawString("Mã HD: " + idbill, new Font("Arial", 9, FontStyle.Regular), Brushes.Black, new Point(25, 130));
            e.Graphics.DrawString("Số chờ: " + WaitNum, new Font("Arial", 9, FontStyle.Regular), Brushes.Black, new Point(150, 130));
            e.Graphics.DrawString("Date: " + DateTime.Now.ToShortDateString(), new Font("Arial", 9, FontStyle.Regular), Brushes.Black, new Point(25, 160));
            e.Graphics.DrawString(AccountMENU.Text, new Font("Arial", 9, FontStyle.Regular), Brushes.Black, new Point(25, 190));
            e.Graphics.DrawString("Khách hàng: "+txtNameCus.Text, new Font("Arial", 9, FontStyle.Regular), Brushes.Black, new Point(25, 220));
            e.Graphics.DrawString("SDT: " + txtPhoneCus.Text, new Font("Arial", 9, FontStyle.Regular), Brushes.Black, new Point(150, 220));

            e.Graphics.DrawString("------------------------------------------------------------------------------------------------------------------------------------", new Font("Arial", 12, FontStyle.Regular), Brushes.Black, new Point(25, 235));

            e.Graphics.DrawString("Tên Món", new Font("Arial", 9, FontStyle.Regular), Brushes.Black, new Point(30, 255));
            e.Graphics.DrawString("Só lượng", new Font("Arial", 9, FontStyle.Regular), Brushes.Black, new Point(380, 255));
            e.Graphics.DrawString("Giá thành", new Font("Arial", 9, FontStyle.Regular), Brushes.Black, new Point(510, 255));
            e.Graphics.DrawString("Tổng tiền", new Font("Arial", 9, FontStyle.Regular), Brushes.Black, new Point(660, 255));
            e.Graphics.DrawString("------------------------------------------------------------------------------------------------------------------------------------", new Font("Arial", 12, FontStyle.Regular), Brushes.Black, new Point(25, 270));

            int yPos = 295;
            for (int i = 0; i < dtgvBH.Rows.Count; i++)
            {
                e.Graphics.DrawString(dtgvBH.Rows[i].Cells[0].Value.ToString(), new Font("Arial", 9, FontStyle.Regular), Brushes.Black, new Point(30, yPos));
                e.Graphics.DrawString(dtgvBH.Rows[i].Cells[1].Value.ToString(), new Font("Arial", 9, FontStyle.Regular), Brushes.Black, new Point(400, yPos));
                e.Graphics.DrawString(dtgvBH.Rows[i].Cells[2].Value.ToString(), new Font("Arial", 9, FontStyle.Regular), Brushes.Black, new Point(525, yPos));
                e.Graphics.DrawString(dtgvBH.Rows[i].Cells[3].Value.ToString(), new Font("Arial", 9, FontStyle.Regular), Brushes.Black, new Point(675, yPos));

                yPos += 30;
               
            }


            e.Graphics.DrawString("------------------------------------------------------------------------------------------------------------------------------------", new Font("Arial", 12, FontStyle.Regular), Brushes.Black, new Point(25, yPos));

            e.Graphics.DrawString("Total Amount:      " + txtTotalPrice.Text+"đ", new Font("Arial", 9, FontStyle.Regular), Brushes.Black, new Point(550, yPos + 30));
            e.Graphics.DrawString("Giảm giá:           " + txtDiscount.Text + "%", new Font("Arial", 9, FontStyle.Regular), Brushes.Black, new Point(550, yPos + 60));
            e.Graphics.DrawString("Total To Pay:       " + txtPay.Text + "đ", new Font("Arial", 9, FontStyle.Regular), Brushes.Black, new Point(550, yPos + 90));
            e.Graphics.DrawString("Total To Pay:       " + txtFund.Text + "đ", new Font("Arial", 9, FontStyle.Regular), Brushes.Black, new Point(550, yPos + 120));
        }

        private void cbCate_SelectedIndexChanged(object sender, EventArgs e)
        {
            loadListFoodToCbBox(cbFood, (cbCate.SelectedItem as category).ID);
        }

        private void txtDiscount_Leave(object sender, EventArgs e)
        {
            
        }
    }
}
