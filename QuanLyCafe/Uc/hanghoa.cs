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
    public partial class hanghoa : UserControl
    {
        BindingSource foodList = new BindingSource();
        BindingSource cateFoodList = new BindingSource();
        int ChangeTabSP = 0;// 0: san pham; 1: loai san pham
        public hanghoa()
        {
            InitializeComponent();
            loadFood();
        }
        void loadFood()
        {
            loadListFood();
            LoadCategoryIntoCombobox(cbCateFood);
            dtgvSP.DataSource = foodList;
            //AddFoodBinding();
            ClearCateBinding();
        }
        void loadCate()
        {
            loadListCateFood();
            dtgvSP.DataSource = cateFoodList;
            //AddCateBinding();
            ClearFoodBinding();
        }
        void loadListFood()
        {
            foodList.DataSource = foodDAO.Instance.GetListFood();
        }
        void loadListCateFood()
        {
            cateFoodList.DataSource = categoryDAO.Instance.GetListCategory();
        }

        private void tabControl1_SelectedIndexChanged(object sender, EventArgs e)
        {
            if(ChangeTabSP == 0)
            {
                ChangeTabSP++;
                loadCate();
                reserFood();
            }
            else
            {
                ChangeTabSP = 0;
                loadFood();
                reserCate();
            }
        }
        void reserFood()
        {
            txtIdFood.Text = null;
            txtNameFood.Text = null;
            txtPrice.Text = null;
            cbCateFood.Text = null;
            ClearFoodBinding();
        }
        void reserCate()
        {
            txtIdCate.Text = null;
            txtNameCate.Text = null;
            ClearCateBinding();
        }
        List<food> SearchFoodByName(string name)
        {
            List<food> listFood = foodDAO.Instance.SearchFoodByName(name);
            return listFood;
        }
        List<category> SearchCategoryByName(string name)
        {
            List<category> listFood = categoryDAO.Instance.SearchCategoryByName(name);
            return listFood;
        }
        public bool checkTxtFood()
        {
            if (txtNameFood.Text == null || cbCateFood.SelectedItem == null || txtPrice.Text == null)
            {
                MessageBox.Show("Bạn nhập dữ liệu chưa đủ", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return false;
            }
            else return true;
        }
        public bool checkTxtCateFood()
        {
            if (txtNameCate.Text == null)
            {
                MessageBox.Show("Bạn nhập dữ liệu chưa đủ", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return false;
            }
            else return true;
        }

        void LoadCategoryIntoCombobox(ComboBox cb)
        {
            cb.DataSource = categoryDAO.Instance.GetListCategory();
            cb.DisplayMember = "name";
        }
        void AddFoodBinding()
        {
            txtIdFood.DataBindings.Add(new Binding("Text", dtgvSP.DataSource, "id"));
            txtNameFood.DataBindings.Add(new Binding("Text", dtgvSP.DataSource, "name"));
            //cbCateFood.DataBindings.Add(new Binding("Text", dtgvSP.DataSource, "CategoryID"));
            txtPrice.DataBindings.Add(new Binding("Text", dtgvSP.DataSource, "price"));
            
            
        }
        void ClearFoodBinding()
        {
            txtIdFood.DataBindings.Clear();
            txtNameFood.DataBindings.Clear();
            cbCateFood.DataBindings.Clear(); 
            txtPrice.DataBindings.Clear();
        }
        void ClearCateBinding()
        {
            txtIdCate.DataBindings.Clear();
            txtNameCate.DataBindings.Clear();
        }
        void AddCateBinding()
        {
            txtIdCate.DataBindings.Add(new Binding("Text", dtgvSP.DataSource, "id"));
            txtNameCate.DataBindings.Add(new Binding("Text", dtgvSP.DataSource, "name"));
        }

        private void txtIdFood_TextChanged(object sender, EventArgs e)
        {
            if (ChangeTabSP == 0)
            {
                int id = (int)dtgvSP.SelectedCells[0].OwningRow.Cells["CategoryID"].Value;
                category category = categoryDAO.Instance.GetCategoryByID(id);
                cbCateFood.SelectedItem = category;
                int index = -1;
                int i = 0;
                foreach (category item in cbCateFood.Items)
                {
                    if (item.ID == category.ID)
                    {
                        index = i;
                        break;
                    }
                    i++;
                }

                cbCateFood.SelectedIndex = index;
            }
        }

        private void btnAddSP_Click(object sender, EventArgs e)
        {
            if (ChangeTabSP == 0)
            {
                if (checkTxtFood())
                {
                    string Name = txtNameFood.Text;
                    int CategoryID = (cbCateFood.SelectedItem as category).ID;
                    float price = float.Parse(txtPrice.Text);
                    if (foodDAO.Instance.InsertFood(Name, CategoryID, price))
                    {
                        reserFood();
                        loadListFood();
                        MessageBox.Show("Đã thêm thành công", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    }
                    else
                    {
                        MessageBox.Show("Đã có lỗi xảy ra xin thử lại sau!", "Thông báo lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                }
            }
            else
            {
                if (checkTxtCateFood())
                {
                    string name = txtNameCate.Text;
                    if (categoryDAO.Instance.insertCategory(name))
                    {
                        reserCate();
                        loadListCateFood();
                        MessageBox.Show("Đã thêm thành công", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    }
                    else
                    {
                        MessageBox.Show("Đã có lỗi xảy ra xin thử lại sau!", "Thông báo lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                }
            }
        }

        private void btnDelSP_Click(object sender, EventArgs e)
        {
            if (ChangeTabSP == 0)
            {
                int ID = int.Parse(txtIdFood.Text);
                if (MessageBox.Show("Bạn có thật sự muốn xoá thức uống này?", "Thông báo", MessageBoxButtons.OKCancel) == System.Windows.Forms.DialogResult.OK)
                {
                   
                    if (foodDAO.Instance.DeleteFood(ID))
                    {
                        reserFood();
                        loadListFood();
                        MessageBox.Show("Đã xóa thành công", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    }
                    else
                    {
                        MessageBox.Show("Đã có lỗi xảy ra xin thử lại sau!", "Thông báo lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                }
                 
            }
            else
            {
                int ID = int.Parse(txtIdCate.Text);
                if (MessageBox.Show("Bạn có thật sự muốn loại thức uống này?", "Thông báo", MessageBoxButtons.OKCancel) == System.Windows.Forms.DialogResult.OK)
                {
                    
                    if (categoryDAO.Instance.DeleteCategory(ID))
                    {
                        reserCate();
                        loadListCateFood();
                        MessageBox.Show("Đã xoá thành công", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    }
                    else
                    {
                        MessageBox.Show("Đã có lỗi xảy ra xin thử lại sau!", "Thông báo lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                }
                    
                
            }   
        }

        private void btnUpSP_Click(object sender, EventArgs e)
        {
            if (ChangeTabSP == 0)
            {
                if (checkTxtFood())
                {
                    int ID = int.Parse(txtIdFood.Text);
                    string name = txtNameFood.Text;
                    int CategoryID = (cbCateFood.SelectedItem as category).ID;
                    float price = float.Parse(txtPrice.Text);
                    if (foodDAO.Instance.UpdateFood(ID,name, CategoryID, price))
                    {
                        reserFood();
                        loadListFood();
                        MessageBox.Show("Đã sửa thành công", "Thông báo");
                    }
                    else
                    {
                        MessageBox.Show("Đã có lỗi xảy ra xin thử lại sau!", "Thông báo lỗi");
                    }
                }
            }
            else
            {
                if (checkTxtCateFood())
                {
                    int ID = int.Parse(txtIdCate.Text);
                    string name = txtNameCate.Text;
                    if (categoryDAO.Instance.UpdateCategory(ID,name))
                    {
                        reserCate();
                        loadListCateFood();
                        MessageBox.Show("Đã sửa thành công", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    }
                    else
                    {
                        MessageBox.Show("Đã có lỗi xảy ra xin thử lại sau!", "Thông báo lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                }
            }
        }

        private void btnSearchSP_Click(object sender, EventArgs e)
        {
            if(ChangeTabSP == 0)
            {
                foodList.DataSource = SearchFoodByName(txtSearchSP.Text);
                LoadCategoryIntoCombobox(cbCateFood);
                //dtgvSP.DataSource = foodList;
                //AddFoodBinding();
                //ClearCateBinding();
                
            }
            else
            {
                cateFoodList.DataSource = SearchCategoryByName(txtSearchSP.Text);
                //dtgvSP.DataSource = cateFoodList;
                //AddCateBinding();
                //ClearFoodBinding();
                
            }
        }

        private void lbReset_Click(object sender, EventArgs e)
        {
            if (ChangeTabSP == 0)
            {
                loadListFood();
                txtSearchSP.Text = null;
            }
            else
            {
                loadListCateFood();
                txtSearchSP.Text = null;
            }
        }

        private void dtgvSP_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (ChangeTabSP == 0)
            {
                AddFoodBinding();
                ClearFoodBinding();
            }
            else
            {
                AddCateBinding();
                ClearCateBinding();
            }
        }
    }
}
