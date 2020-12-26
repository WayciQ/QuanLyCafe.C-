namespace QuanLyCafe.Uc
{
    partial class banhang
    {
        /// <summary> 
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary> 
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Component Designer generated code

        /// <summary> 
        /// Required method for Designer support - do not modify 
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(banhang));
            this.panel1 = new System.Windows.Forms.Panel();
            this.btnDelFood = new System.Windows.Forms.Button();
            this.dtgvBH = new System.Windows.Forms.DataGridView();
            this.btnAddFood = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.cbFood = new System.Windows.Forms.ComboBox();
            this.cbCate = new System.Windows.Forms.ComboBox();
            this.quanLyCafeDataSetBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.quanLyCafeDataSet = new QuanLyCafe.QuanLyCafeDataSet();
            this.contextMenuStrip1 = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.panel2 = new System.Windows.Forms.Panel();
            this.panel10 = new System.Windows.Forms.Panel();
            this.btnAddKhach = new System.Windows.Forms.Button();
            this.label12 = new System.Windows.Forms.Label();
            this.txtNameCus = new System.Windows.Forms.TextBox();
            this.panel9 = new System.Windows.Forms.Panel();
            this.label11 = new System.Windows.Forms.Label();
            this.txtWaiting = new System.Windows.Forms.TextBox();
            this.btnTT = new System.Windows.Forms.Button();
            this.panel8 = new System.Windows.Forms.Panel();
            this.txtFund = new System.Windows.Forms.TextBox();
            this.label10 = new System.Windows.Forms.Label();
            this.panel7 = new System.Windows.Forms.Panel();
            this.label8 = new System.Windows.Forms.Label();
            this.txtPay = new System.Windows.Forms.TextBox();
            this.panel6 = new System.Windows.Forms.Panel();
            this.txtPayedPrice = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.panel5 = new System.Windows.Forms.Panel();
            this.label5 = new System.Windows.Forms.Label();
            this.txtTotalPrice = new System.Windows.Forms.TextBox();
            this.panel4 = new System.Windows.Forms.Panel();
            this.label4 = new System.Windows.Forms.Label();
            this.txtDiscount = new System.Windows.Forms.TextBox();
            this.panel3 = new System.Windows.Forms.Panel();
            this.btnSearchKhach = new System.Windows.Forms.Button();
            this.label3 = new System.Windows.Forms.Label();
            this.txtPhoneCus = new System.Windows.Forms.TextBox();
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.AccountMENU = new System.Windows.Forms.ToolStripMenuItem();
            this.sửaThôngTinToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.đăngXuấtToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.printDocument1 = new System.Drawing.Printing.PrintDocument();
            this.printPreviewDialog1 = new System.Windows.Forms.PrintPreviewDialog();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dtgvBH)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.quanLyCafeDataSetBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.quanLyCafeDataSet)).BeginInit();
            this.panel2.SuspendLayout();
            this.panel10.SuspendLayout();
            this.panel9.SuspendLayout();
            this.panel8.SuspendLayout();
            this.panel7.SuspendLayout();
            this.panel6.SuspendLayout();
            this.panel5.SuspendLayout();
            this.panel4.SuspendLayout();
            this.panel3.SuspendLayout();
            this.menuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.btnDelFood);
            this.panel1.Controls.Add(this.dtgvBH);
            this.panel1.Controls.Add(this.btnAddFood);
            this.panel1.Controls.Add(this.label2);
            this.panel1.Controls.Add(this.label1);
            this.panel1.Controls.Add(this.cbFood);
            this.panel1.Controls.Add(this.cbCate);
            this.panel1.Location = new System.Drawing.Point(573, 3);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(751, 741);
            this.panel1.TabIndex = 0;
            // 
            // btnDelFood
            // 
            this.btnDelFood.Location = new System.Drawing.Point(664, 33);
            this.btnDelFood.Name = "btnDelFood";
            this.btnDelFood.Size = new System.Drawing.Size(84, 54);
            this.btnDelFood.TabIndex = 6;
            this.btnDelFood.Text = "Xoá";
            this.btnDelFood.UseVisualStyleBackColor = true;
            this.btnDelFood.Click += new System.EventHandler(this.btnDelFood_Click);
            // 
            // dtgvBH
            // 
            this.dtgvBH.AllowUserToAddRows = false;
            this.dtgvBH.AllowUserToDeleteRows = false;
            this.dtgvBH.BackgroundColor = System.Drawing.SystemColors.Control;
            this.dtgvBH.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dtgvBH.Location = new System.Drawing.Point(3, 112);
            this.dtgvBH.Name = "dtgvBH";
            this.dtgvBH.ReadOnly = true;
            this.dtgvBH.RowHeadersWidth = 51;
            this.dtgvBH.RowTemplate.Height = 24;
            this.dtgvBH.Size = new System.Drawing.Size(745, 645);
            this.dtgvBH.TabIndex = 5;
            this.dtgvBH.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dtgvBH_CellClick);
            // 
            // btnAddFood
            // 
            this.btnAddFood.Location = new System.Drawing.Point(572, 33);
            this.btnAddFood.Name = "btnAddFood";
            this.btnAddFood.Size = new System.Drawing.Size(84, 54);
            this.btnAddFood.TabIndex = 4;
            this.btnAddFood.Text = "Thêm";
            this.btnAddFood.UseVisualStyleBackColor = true;
            this.btnAddFood.Click += new System.EventHandler(this.btnAddFood_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(22, 66);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(107, 17);
            this.label2.TabIndex = 3;
            this.label2.Text = "Chọn sản phẩm";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(22, 36);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(67, 17);
            this.label1.TabIndex = 2;
            this.label1.Text = "Chọn loại";
            // 
            // cbFood
            // 
            this.cbFood.FormattingEnabled = true;
            this.cbFood.Location = new System.Drawing.Point(135, 63);
            this.cbFood.Name = "cbFood";
            this.cbFood.Size = new System.Drawing.Size(419, 24);
            this.cbFood.TabIndex = 1;
            // 
            // cbCate
            // 
            this.cbCate.FormattingEnabled = true;
            this.cbCate.Location = new System.Drawing.Point(135, 33);
            this.cbCate.Name = "cbCate";
            this.cbCate.Size = new System.Drawing.Size(419, 24);
            this.cbCate.TabIndex = 0;
            this.cbCate.SelectedIndexChanged += new System.EventHandler(this.cbCate_SelectedIndexChanged);
            // 
            // quanLyCafeDataSetBindingSource
            // 
            this.quanLyCafeDataSetBindingSource.DataSource = this.quanLyCafeDataSet;
            this.quanLyCafeDataSetBindingSource.Position = 0;
            // 
            // quanLyCafeDataSet
            // 
            this.quanLyCafeDataSet.DataSetName = "QuanLyCafeDataSet";
            this.quanLyCafeDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // contextMenuStrip1
            // 
            this.contextMenuStrip1.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.contextMenuStrip1.Name = "contextMenuStrip1";
            this.contextMenuStrip1.Size = new System.Drawing.Size(61, 4);
            // 
            // panel2
            // 
            this.panel2.Controls.Add(this.panel10);
            this.panel2.Controls.Add(this.panel9);
            this.panel2.Controls.Add(this.btnTT);
            this.panel2.Controls.Add(this.panel8);
            this.panel2.Controls.Add(this.panel7);
            this.panel2.Controls.Add(this.panel6);
            this.panel2.Controls.Add(this.panel5);
            this.panel2.Controls.Add(this.panel4);
            this.panel2.Controls.Add(this.panel3);
            this.panel2.Controls.Add(this.menuStrip1);
            this.panel2.Location = new System.Drawing.Point(3, 3);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(567, 741);
            this.panel2.TabIndex = 2;
            // 
            // panel10
            // 
            this.panel10.Controls.Add(this.btnAddKhach);
            this.panel10.Controls.Add(this.label12);
            this.panel10.Controls.Add(this.txtNameCus);
            this.panel10.Location = new System.Drawing.Point(3, 203);
            this.panel10.Name = "panel10";
            this.panel10.Size = new System.Drawing.Size(547, 79);
            this.panel10.TabIndex = 16;
            // 
            // btnAddKhach
            // 
            this.btnAddKhach.Image = global::QuanLyCafe.Properties.Resources.add_48px;
            this.btnAddKhach.Location = new System.Drawing.Point(492, 23);
            this.btnAddKhach.Name = "btnAddKhach";
            this.btnAddKhach.Size = new System.Drawing.Size(49, 53);
            this.btnAddKhach.TabIndex = 7;
            this.btnAddKhach.UseVisualStyleBackColor = true;
            this.btnAddKhach.Click += new System.EventHandler(this.btnAddKhach_Click);
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.Location = new System.Drawing.Point(3, 10);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(111, 17);
            this.label12.TabIndex = 6;
            this.label12.Text = "Tên khách hàng";
            // 
            // txtNameCus
            // 
            this.txtNameCus.Location = new System.Drawing.Point(6, 35);
            this.txtNameCus.Name = "txtNameCus";
            this.txtNameCus.Size = new System.Drawing.Size(480, 22);
            this.txtNameCus.TabIndex = 0;
            this.txtNameCus.Text = "Vãng lai";
            // 
            // panel9
            // 
            this.panel9.Controls.Add(this.label11);
            this.panel9.Controls.Add(this.txtWaiting);
            this.panel9.Location = new System.Drawing.Point(3, 52);
            this.panel9.Name = "panel9";
            this.panel9.Size = new System.Drawing.Size(547, 60);
            this.panel9.TabIndex = 14;
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Location = new System.Drawing.Point(3, 10);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(73, 17);
            this.label11.TabIndex = 6;
            this.label11.Text = "Thẻ thứ tự";
            // 
            // txtWaiting
            // 
            this.txtWaiting.Location = new System.Drawing.Point(6, 35);
            this.txtWaiting.Name = "txtWaiting";
            this.txtWaiting.Size = new System.Drawing.Size(535, 22);
            this.txtWaiting.TabIndex = 0;
            this.txtWaiting.Text = "1";
            this.txtWaiting.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtWaiting_KeyPress);
            // 
            // btnTT
            // 
            this.btnTT.Location = new System.Drawing.Point(316, 550);
            this.btnTT.Name = "btnTT";
            this.btnTT.Size = new System.Drawing.Size(234, 109);
            this.btnTT.TabIndex = 13;
            this.btnTT.Text = "Thanh toán";
            this.btnTT.UseVisualStyleBackColor = true;
            this.btnTT.Click += new System.EventHandler(this.btnTT_Click);
            // 
            // panel8
            // 
            this.panel8.Controls.Add(this.txtFund);
            this.panel8.Controls.Add(this.label10);
            this.panel8.Location = new System.Drawing.Point(3, 487);
            this.panel8.Name = "panel8";
            this.panel8.Size = new System.Drawing.Size(547, 43);
            this.panel8.TabIndex = 12;
            // 
            // txtFund
            // 
            this.txtFund.Location = new System.Drawing.Point(404, 10);
            this.txtFund.Name = "txtFund";
            this.txtFund.ReadOnly = true;
            this.txtFund.Size = new System.Drawing.Size(137, 22);
            this.txtFund.TabIndex = 9;
            this.txtFund.Text = "0";
            this.txtFund.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Location = new System.Drawing.Point(3, 10);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(68, 17);
            this.label10.TabIndex = 6;
            this.label10.Text = "Tiền thừa";
            // 
            // panel7
            // 
            this.panel7.Controls.Add(this.label8);
            this.panel7.Controls.Add(this.txtPay);
            this.panel7.Location = new System.Drawing.Point(3, 441);
            this.panel7.Name = "panel7";
            this.panel7.Size = new System.Drawing.Size(547, 40);
            this.panel7.TabIndex = 11;
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(3, 10);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(120, 17);
            this.label8.TabIndex = 6;
            this.label8.Text = "Khách thanh toán";
            // 
            // txtPay
            // 
            this.txtPay.Location = new System.Drawing.Point(177, 7);
            this.txtPay.Name = "txtPay";
            this.txtPay.Size = new System.Drawing.Size(364, 22);
            this.txtPay.TabIndex = 0;
            this.txtPay.Text = "0";
            this.txtPay.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            this.txtPay.TextChanged += new System.EventHandler(this.txtPay_TextChanged);
            this.txtPay.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtPay_KeyPress);
            // 
            // panel6
            // 
            this.panel6.Controls.Add(this.txtPayedPrice);
            this.panel6.Controls.Add(this.label6);
            this.panel6.Location = new System.Drawing.Point(3, 392);
            this.panel6.Name = "panel6";
            this.panel6.Size = new System.Drawing.Size(547, 43);
            this.panel6.TabIndex = 10;
            // 
            // txtPayedPrice
            // 
            this.txtPayedPrice.Location = new System.Drawing.Point(404, 10);
            this.txtPayedPrice.Name = "txtPayedPrice";
            this.txtPayedPrice.ReadOnly = true;
            this.txtPayedPrice.Size = new System.Drawing.Size(137, 22);
            this.txtPayedPrice.TabIndex = 8;
            this.txtPayedPrice.Text = "0";
            this.txtPayedPrice.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(3, 10);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(96, 17);
            this.label6.TabIndex = 6;
            this.label6.Text = "Khách cần trả";
            // 
            // panel5
            // 
            this.panel5.Controls.Add(this.label5);
            this.panel5.Controls.Add(this.txtTotalPrice);
            this.panel5.Location = new System.Drawing.Point(3, 346);
            this.panel5.Name = "panel5";
            this.panel5.Size = new System.Drawing.Size(547, 40);
            this.panel5.TabIndex = 9;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(3, 10);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(68, 17);
            this.label5.TabIndex = 6;
            this.label5.Text = "Tổng tiền";
            // 
            // txtTotalPrice
            // 
            this.txtTotalPrice.Location = new System.Drawing.Point(177, 7);
            this.txtTotalPrice.Name = "txtTotalPrice";
            this.txtTotalPrice.Size = new System.Drawing.Size(364, 22);
            this.txtTotalPrice.TabIndex = 0;
            this.txtTotalPrice.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            // 
            // panel4
            // 
            this.panel4.Controls.Add(this.label4);
            this.panel4.Controls.Add(this.txtDiscount);
            this.panel4.Location = new System.Drawing.Point(3, 297);
            this.panel4.Name = "panel4";
            this.panel4.Size = new System.Drawing.Size(547, 43);
            this.panel4.TabIndex = 8;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(3, 10);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(64, 17);
            this.label4.TabIndex = 6;
            this.label4.Text = "Giảm giá";
            // 
            // txtDiscount
            // 
            this.txtDiscount.Location = new System.Drawing.Point(177, 10);
            this.txtDiscount.Name = "txtDiscount";
            this.txtDiscount.Size = new System.Drawing.Size(364, 22);
            this.txtDiscount.TabIndex = 0;
            this.txtDiscount.Text = "0";
            this.txtDiscount.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            this.txtDiscount.TextChanged += new System.EventHandler(this.txtDiscount_TextChanged);
            this.txtDiscount.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtDiscount_KeyPress);
            this.txtDiscount.Leave += new System.EventHandler(this.txtDiscount_Leave);
            // 
            // panel3
            // 
            this.panel3.Controls.Add(this.btnSearchKhach);
            this.panel3.Controls.Add(this.label3);
            this.panel3.Controls.Add(this.txtPhoneCus);
            this.panel3.Location = new System.Drawing.Point(3, 118);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(547, 79);
            this.panel3.TabIndex = 7;
            // 
            // btnSearchKhach
            // 
            this.btnSearchKhach.Image = global::QuanLyCafe.Properties.Resources.search_48px;
            this.btnSearchKhach.Location = new System.Drawing.Point(488, 20);
            this.btnSearchKhach.Name = "btnSearchKhach";
            this.btnSearchKhach.Size = new System.Drawing.Size(59, 53);
            this.btnSearchKhach.TabIndex = 7;
            this.btnSearchKhach.UseVisualStyleBackColor = true;
            this.btnSearchKhach.Click += new System.EventHandler(this.btnSearchKhach_Click);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(3, 10);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(152, 17);
            this.label3.TabIndex = 6;
            this.label3.Text = "Nhập SĐT khách hàng";
            // 
            // txtPhoneCus
            // 
            this.txtPhoneCus.Location = new System.Drawing.Point(6, 35);
            this.txtPhoneCus.Name = "txtPhoneCus";
            this.txtPhoneCus.Size = new System.Drawing.Size(480, 22);
            this.txtPhoneCus.TabIndex = 0;
            this.txtPhoneCus.Text = "0";
            this.txtPhoneCus.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtPhoneCus_KeyPress);
            // 
            // menuStrip1
            // 
            this.menuStrip1.BackColor = System.Drawing.SystemColors.Control;
            this.menuStrip1.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.AccountMENU});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(567, 30);
            this.menuStrip1.TabIndex = 15;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // AccountMENU
            // 
            this.AccountMENU.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.sửaThôngTinToolStripMenuItem,
            this.đăngXuấtToolStripMenuItem});
            this.AccountMENU.Font = new System.Drawing.Font("Arial", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.AccountMENU.Name = "AccountMENU";
            this.AccountMENU.Size = new System.Drawing.Size(171, 26);
            this.AccountMENU.Text = "{Tên Tài khoan}";
            // 
            // sửaThôngTinToolStripMenuItem
            // 
            this.sửaThôngTinToolStripMenuItem.Font = new System.Drawing.Font("Arial", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.sửaThôngTinToolStripMenuItem.Name = "sửaThôngTinToolStripMenuItem";
            this.sửaThôngTinToolStripMenuItem.Size = new System.Drawing.Size(188, 26);
            this.sửaThôngTinToolStripMenuItem.Text = "Sửa thông tin";
            this.sửaThôngTinToolStripMenuItem.Click += new System.EventHandler(this.sửaThôngTinToolStripMenuItem_Click);
            // 
            // đăngXuấtToolStripMenuItem
            // 
            this.đăngXuấtToolStripMenuItem.Font = new System.Drawing.Font("Arial", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.đăngXuấtToolStripMenuItem.Name = "đăngXuấtToolStripMenuItem";
            this.đăngXuấtToolStripMenuItem.Size = new System.Drawing.Size(188, 26);
            this.đăngXuấtToolStripMenuItem.Text = "Đăng xuất";
            this.đăngXuấtToolStripMenuItem.Click += new System.EventHandler(this.đăngXuấtToolStripMenuItem_Click);
            // 
            // printDocument1
            // 
            this.printDocument1.PrintPage += new System.Drawing.Printing.PrintPageEventHandler(this.printDocument1_PrintPage);
            // 
            // printPreviewDialog1
            // 
            this.printPreviewDialog1.AutoScrollMargin = new System.Drawing.Size(0, 0);
            this.printPreviewDialog1.AutoScrollMinSize = new System.Drawing.Size(0, 0);
            this.printPreviewDialog1.ClientSize = new System.Drawing.Size(400, 300);
            this.printPreviewDialog1.Document = this.printDocument1;
            this.printPreviewDialog1.Enabled = true;
            this.printPreviewDialog1.Icon = ((System.Drawing.Icon)(resources.GetObject("printPreviewDialog1.Icon")));
            this.printPreviewDialog1.Name = "printPreviewDialog1";
            this.printPreviewDialog1.Visible = false;
            // 
            // banhang
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.panel1);
            this.Name = "banhang";
            this.Size = new System.Drawing.Size(1340, 760);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dtgvBH)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.quanLyCafeDataSetBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.quanLyCafeDataSet)).EndInit();
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            this.panel10.ResumeLayout(false);
            this.panel10.PerformLayout();
            this.panel9.ResumeLayout(false);
            this.panel9.PerformLayout();
            this.panel8.ResumeLayout(false);
            this.panel8.PerformLayout();
            this.panel7.ResumeLayout(false);
            this.panel7.PerformLayout();
            this.panel6.ResumeLayout(false);
            this.panel6.PerformLayout();
            this.panel5.ResumeLayout(false);
            this.panel5.PerformLayout();
            this.panel4.ResumeLayout(false);
            this.panel4.PerformLayout();
            this.panel3.ResumeLayout(false);
            this.panel3.PerformLayout();
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.DataGridView dtgvBH;
        private System.Windows.Forms.Button btnAddFood;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ComboBox cbFood;
        private System.Windows.Forms.ComboBox cbCate;
        private System.Windows.Forms.ContextMenuStrip contextMenuStrip1;
        private System.Windows.Forms.Button btnDelFood;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Panel panel9;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.TextBox txtWaiting;
        private System.Windows.Forms.Button btnTT;
        private System.Windows.Forms.Panel panel8;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.Panel panel7;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.TextBox txtPay;
        private System.Windows.Forms.Panel panel6;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Panel panel5;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox txtTotalPrice;
        private System.Windows.Forms.Panel panel4;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox txtDiscount;
        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.Button btnSearchKhach;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox txtPhoneCus;
        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem AccountMENU;
        private System.Windows.Forms.ToolStripMenuItem sửaThôngTinToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem đăngXuấtToolStripMenuItem;
        private System.Windows.Forms.Panel panel10;
        private System.Windows.Forms.Button btnAddKhach;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.TextBox txtNameCus;
        private System.Windows.Forms.TextBox txtPayedPrice;
        private System.Windows.Forms.TextBox txtFund;
        private System.Drawing.Printing.PrintDocument printDocument1;
        private System.Windows.Forms.BindingSource quanLyCafeDataSetBindingSource;
        private QuanLyCafeDataSet quanLyCafeDataSet;
        private System.Windows.Forms.PrintPreviewDialog printPreviewDialog1;
    }
}
