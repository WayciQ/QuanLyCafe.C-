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
    public partial class hoadon : UserControl
    {
        BindingSource listBill = new BindingSource();
        BindingSource listInfo = new BindingSource();
        public hoadon()
        {
            InitializeComponent();
            LoadBillAndCart();
        }
        void LoadBillAndCart()
        {
            loadlistBill();
            dtgvBill.DataSource = listBill;
        }
        void loadlistBill()
        {
            listBill.DataSource = billDAO.Instance.GetListBill();
        }
        void loadListCartByBillId(int id)
        {
            listInfo.DataSource = BillInforDAO.Instance.GetCart(id);
        }
        int idBill;
        void AddBindingBill()
        {
            txtIdBill.DataBindings.Add(new Binding("Text", dtgvBill.DataSource, "id"));
            txtDateBill.DataBindings.Add(new Binding("Text", dtgvBill.DataSource, "DateCheckIn"));
            idBill = int.Parse(txtIdBill.Text);
        }
        void ClearBindingBill()
        {
            txtIdBill.DataBindings.Clear();
            txtDateBill.DataBindings.Clear();
        }
        private void dtgvBill_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            
        }

        private void dtgvBill_CellClick_1(object sender, DataGridViewCellEventArgs e)
        {
            AddBindingBill();
            ClearBindingBill();
            loadListCartByBillId(idBill);
            dtgvBillInfo.DataSource = listInfo;
        }

        private void btnDeleteBill_Click(object sender, EventArgs e)
        {
            if (billDAO.Instance.DeleteBillById(idBill))
            {
                txtDateBill.ResetText();
                txtIdBill.ResetText();
                loadlistBill();
                dtgvBillInfo.Refresh();
                MessageBox.Show("Đã xoá thành công", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            else
            {
                MessageBox.Show("Đã có lỗi xảy ra xin thử lại sau!", "Thông báo lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void printBIll_Click(object sender, EventArgs e)
        {
            printPreviewDialog1.Document = printDocument1;
            printPreviewDialog1.ShowDialog();
        }

        private void copyBill_Click(object sender, EventArgs e)
        {

        }
        string nameCus;
        string nameStaff;
        int waiting;
        string phone;
        float TotalPrice;
        int discount;
        void getInfoBill()
        {
            bill bill = billDAO.Instance.GetBillByID(idBill);
            customer cus = khachDAO.Instance.GetCustomerByID(bill.Idcustomer);
            nameCus = cus.NameCustomer;
            phone = cus.PhoneNum;
            user user = userDAO.Instance.GetAccountByID(bill.IdStaff);
            nameStaff = user.NameUser;
            waiting = bill.waittingNum;
            TotalPrice = bill.TotalPrice;
            discount = bill.Discount;
        }
        private void printDocument1_PrintPage(object sender, System.Drawing.Printing.PrintPageEventArgs e)
        {
            getInfoBill();
            e.Graphics.DrawString("The Coffee House", new Font("Arial", 16, FontStyle.Regular), Brushes.Black, new Point(290, 90));
            e.Graphics.DrawString("Mã HD: " + txtIdBill.Text, new Font("Arial", 9, FontStyle.Regular), Brushes.Black, new Point(25, 130));
            e.Graphics.DrawString("Date: " + txtDateBill.Text, new Font("Arial", 9, FontStyle.Regular), Brushes.Black, new Point(25, 160));
            e.Graphics.DrawString("Số chờ: " + waiting, new Font("Arial", 9, FontStyle.Regular), Brushes.Black, new Point(150, 130));
            e.Graphics.DrawString("Nhân viên: "+ nameStaff, new Font("Arial", 9, FontStyle.Regular), Brushes.Black, new Point(25, 190));
            e.Graphics.DrawString("Khách hàng: " + nameCus, new Font("Arial", 9, FontStyle.Regular), Brushes.Black, new Point(25, 220));
            e.Graphics.DrawString("SDT: " + phone, new Font("Arial", 9, FontStyle.Regular), Brushes.Black, new Point(150, 220));

            e.Graphics.DrawString("------------------------------------------------------------------------------------------------------------------------------------", new Font("Arial", 12, FontStyle.Regular), Brushes.Black, new Point(25, 235));

            e.Graphics.DrawString("Tên Món", new Font("Arial", 9, FontStyle.Regular), Brushes.Black, new Point(30, 255));
            e.Graphics.DrawString("Só lượng", new Font("Arial", 9, FontStyle.Regular), Brushes.Black, new Point(380, 255));
            e.Graphics.DrawString("Giá thành", new Font("Arial", 9, FontStyle.Regular), Brushes.Black, new Point(510, 255));
            e.Graphics.DrawString("Tổng tiền", new Font("Arial", 9, FontStyle.Regular), Brushes.Black, new Point(660, 255));
            e.Graphics.DrawString("------------------------------------------------------------------------------------------------------------------------------------", new Font("Arial", 12, FontStyle.Regular), Brushes.Black, new Point(25, 270));

            int yPos = 295;
            for (int i = 0; i < dtgvBillInfo.Rows.Count; i++)
            {
                e.Graphics.DrawString(dtgvBillInfo.Rows[i].Cells[0].Value.ToString(), new Font("Arial", 9, FontStyle.Regular), Brushes.Black, new Point(30, yPos));
                e.Graphics.DrawString(dtgvBillInfo.Rows[i].Cells[1].Value.ToString(), new Font("Arial", 9, FontStyle.Regular), Brushes.Black, new Point(400, yPos));
                e.Graphics.DrawString(dtgvBillInfo.Rows[i].Cells[2].Value.ToString(), new Font("Arial", 9, FontStyle.Regular), Brushes.Black, new Point(525, yPos));
                e.Graphics.DrawString(dtgvBillInfo.Rows[i].Cells[3].Value.ToString(), new Font("Arial", 9, FontStyle.Regular), Brushes.Black, new Point(675, yPos));

                yPos += 30;

            }


            e.Graphics.DrawString("------------------------------------------------------------------------------------------------------------------------------------", new Font("Arial", 12, FontStyle.Regular), Brushes.Black, new Point(25, yPos));

            e.Graphics.DrawString("Total Amount:      " + TotalPrice + "đ", new Font("Arial", 9, FontStyle.Regular), Brushes.Black, new Point(550, yPos + 30));
            e.Graphics.DrawString("Giảm giá:          " + discount + "đ", new Font("Arial", 9, FontStyle.Regular), Brushes.Black, new Point(550, yPos + 60));
        }

        private void btnSearchKhach_Click(object sender, EventArgs e)
        {
            int Day = datePick.Value.Day;
            int Month = datePick.Value.Month;
            int Year = datePick.Value.Year;
            DateTime date = new DateTime(Year, Month, Day);
            SearchBillByDate(date);
        }
        void SearchBillByDate(DateTime CheckIn)
        {
            dtgvBill.DataSource = billDAO.Instance.GetListBillByDate(CheckIn); 
        }

        private void label3_Click(object sender, EventArgs e)
        {
            loadlistBill();
        }
    }
}
