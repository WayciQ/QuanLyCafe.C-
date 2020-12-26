namespace QuanLyCafe.Uc
{
    partial class hanghoa
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
            this.panel3 = new System.Windows.Forms.Panel();
            this.dtgvSP = new System.Windows.Forms.DataGridView();
            this.panel1 = new System.Windows.Forms.Panel();
            this.tabControl1 = new System.Windows.Forms.TabControl();
            this.tabPage1 = new System.Windows.Forms.TabPage();
            this.panel5 = new System.Windows.Forms.Panel();
            this.txtIdFood = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.panel9 = new System.Windows.Forms.Panel();
            this.txtPrice = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.panel7 = new System.Windows.Forms.Panel();
            this.cbCateFood = new System.Windows.Forms.ComboBox();
            this.label4 = new System.Windows.Forms.Label();
            this.panel6 = new System.Windows.Forms.Panel();
            this.txtNameFood = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.tabPage2 = new System.Windows.Forms.TabPage();
            this.panel10 = new System.Windows.Forms.Panel();
            this.txtNameCate = new System.Windows.Forms.TextBox();
            this.label7 = new System.Windows.Forms.Label();
            this.panel8 = new System.Windows.Forms.Panel();
            this.txtIdCate = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.panel2 = new System.Windows.Forms.Panel();
            this.btnUpSP = new System.Windows.Forms.Button();
            this.btnAddSP = new System.Windows.Forms.Button();
            this.btnDelSP = new System.Windows.Forms.Button();
            this.panel4 = new System.Windows.Forms.Panel();
            this.btnSearchSP = new System.Windows.Forms.Button();
            this.lbReset = new System.Windows.Forms.Label();
            this.txtSearchSP = new System.Windows.Forms.TextBox();
            this.panel3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dtgvSP)).BeginInit();
            this.panel1.SuspendLayout();
            this.tabControl1.SuspendLayout();
            this.tabPage1.SuspendLayout();
            this.panel5.SuspendLayout();
            this.panel9.SuspendLayout();
            this.panel7.SuspendLayout();
            this.panel6.SuspendLayout();
            this.tabPage2.SuspendLayout();
            this.panel10.SuspendLayout();
            this.panel8.SuspendLayout();
            this.panel2.SuspendLayout();
            this.panel4.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel3
            // 
            this.panel3.Controls.Add(this.dtgvSP);
            this.panel3.Location = new System.Drawing.Point(454, 105);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(863, 652);
            this.panel3.TabIndex = 2;
            // 
            // dtgvSP
            // 
            this.dtgvSP.BackgroundColor = System.Drawing.SystemColors.Control;
            this.dtgvSP.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dtgvSP.Location = new System.Drawing.Point(3, 3);
            this.dtgvSP.Name = "dtgvSP";
            this.dtgvSP.RowHeadersWidth = 51;
            this.dtgvSP.RowTemplate.Height = 24;
            this.dtgvSP.Size = new System.Drawing.Size(857, 646);
            this.dtgvSP.TabIndex = 0;
            this.dtgvSP.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dtgvSP_CellClick);
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.tabControl1);
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(448, 760);
            this.panel1.TabIndex = 0;
            // 
            // tabControl1
            // 
            this.tabControl1.Controls.Add(this.tabPage1);
            this.tabControl1.Controls.Add(this.tabPage2);
            this.tabControl1.Location = new System.Drawing.Point(7, 3);
            this.tabControl1.Name = "tabControl1";
            this.tabControl1.SelectedIndex = 0;
            this.tabControl1.Size = new System.Drawing.Size(441, 721);
            this.tabControl1.TabIndex = 6;
            this.tabControl1.SelectedIndexChanged += new System.EventHandler(this.tabControl1_SelectedIndexChanged);
            // 
            // tabPage1
            // 
            this.tabPage1.Controls.Add(this.panel5);
            this.tabPage1.Controls.Add(this.panel9);
            this.tabPage1.Controls.Add(this.panel7);
            this.tabPage1.Controls.Add(this.panel6);
            this.tabPage1.Location = new System.Drawing.Point(4, 25);
            this.tabPage1.Name = "tabPage1";
            this.tabPage1.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage1.Size = new System.Drawing.Size(433, 692);
            this.tabPage1.TabIndex = 0;
            this.tabPage1.Text = "Sản phẩm";
            this.tabPage1.UseVisualStyleBackColor = true;
            // 
            // panel5
            // 
            this.panel5.Controls.Add(this.txtIdFood);
            this.panel5.Controls.Add(this.label2);
            this.panel5.Location = new System.Drawing.Point(3, 46);
            this.panel5.Name = "panel5";
            this.panel5.Size = new System.Drawing.Size(424, 61);
            this.panel5.TabIndex = 0;
            // 
            // txtIdFood
            // 
            this.txtIdFood.Location = new System.Drawing.Point(32, 33);
            this.txtIdFood.Name = "txtIdFood";
            this.txtIdFood.ReadOnly = true;
            this.txtIdFood.Size = new System.Drawing.Size(341, 22);
            this.txtIdFood.TabIndex = 1;
            this.txtIdFood.TextChanged += new System.EventHandler(this.txtIdFood_TextChanged);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(29, 13);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(93, 17);
            this.label2.TabIndex = 0;
            this.label2.Text = "Mã sản phẩm";
            // 
            // panel9
            // 
            this.panel9.Controls.Add(this.txtPrice);
            this.panel9.Controls.Add(this.label6);
            this.panel9.Location = new System.Drawing.Point(3, 238);
            this.panel9.Name = "panel9";
            this.panel9.Size = new System.Drawing.Size(424, 58);
            this.panel9.TabIndex = 4;
            // 
            // txtPrice
            // 
            this.txtPrice.Location = new System.Drawing.Point(32, 33);
            this.txtPrice.Name = "txtPrice";
            this.txtPrice.Size = new System.Drawing.Size(341, 22);
            this.txtPrice.TabIndex = 1;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(29, 13);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(58, 17);
            this.label6.TabIndex = 0;
            this.label6.Text = "Giá bán";
            // 
            // panel7
            // 
            this.panel7.Controls.Add(this.cbCateFood);
            this.panel7.Controls.Add(this.label4);
            this.panel7.Location = new System.Drawing.Point(3, 174);
            this.panel7.Name = "panel7";
            this.panel7.Size = new System.Drawing.Size(424, 58);
            this.panel7.TabIndex = 2;
            // 
            // cbCateFood
            // 
            this.cbCateFood.FormattingEnabled = true;
            this.cbCateFood.Location = new System.Drawing.Point(32, 31);
            this.cbCateFood.Name = "cbCateFood";
            this.cbCateFood.Size = new System.Drawing.Size(341, 24);
            this.cbCateFood.TabIndex = 2;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(29, 13);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(101, 17);
            this.label4.TabIndex = 0;
            this.label4.Text = "Loại sản phẩm";
            // 
            // panel6
            // 
            this.panel6.Controls.Add(this.txtNameFood);
            this.panel6.Controls.Add(this.label3);
            this.panel6.Location = new System.Drawing.Point(3, 110);
            this.panel6.Name = "panel6";
            this.panel6.Size = new System.Drawing.Size(424, 58);
            this.panel6.TabIndex = 1;
            // 
            // txtNameFood
            // 
            this.txtNameFood.Location = new System.Drawing.Point(32, 33);
            this.txtNameFood.Name = "txtNameFood";
            this.txtNameFood.Size = new System.Drawing.Size(341, 22);
            this.txtNameFood.TabIndex = 1;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(29, 13);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(99, 17);
            this.label3.TabIndex = 0;
            this.label3.Text = "Tên sản phẩm";
            // 
            // tabPage2
            // 
            this.tabPage2.Controls.Add(this.panel10);
            this.tabPage2.Controls.Add(this.panel8);
            this.tabPage2.Location = new System.Drawing.Point(4, 25);
            this.tabPage2.Name = "tabPage2";
            this.tabPage2.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage2.Size = new System.Drawing.Size(433, 692);
            this.tabPage2.TabIndex = 1;
            this.tabPage2.Text = "Loại sản phẩm";
            this.tabPage2.UseVisualStyleBackColor = true;
            // 
            // panel10
            // 
            this.panel10.Controls.Add(this.txtNameCate);
            this.panel10.Controls.Add(this.label7);
            this.panel10.Location = new System.Drawing.Point(3, 113);
            this.panel10.Name = "panel10";
            this.panel10.Size = new System.Drawing.Size(424, 58);
            this.panel10.TabIndex = 2;
            // 
            // txtNameCate
            // 
            this.txtNameCate.Location = new System.Drawing.Point(32, 33);
            this.txtNameCate.Name = "txtNameCate";
            this.txtNameCate.Size = new System.Drawing.Size(341, 22);
            this.txtNameCate.TabIndex = 1;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(29, 13);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(64, 17);
            this.label7.TabIndex = 0;
            this.label7.Text = "Tên Loại";
            // 
            // panel8
            // 
            this.panel8.Controls.Add(this.txtIdCate);
            this.panel8.Controls.Add(this.label5);
            this.panel8.Location = new System.Drawing.Point(3, 46);
            this.panel8.Name = "panel8";
            this.panel8.Size = new System.Drawing.Size(424, 61);
            this.panel8.TabIndex = 1;
            // 
            // txtIdCate
            // 
            this.txtIdCate.Location = new System.Drawing.Point(32, 33);
            this.txtIdCate.Name = "txtIdCate";
            this.txtIdCate.ReadOnly = true;
            this.txtIdCate.Size = new System.Drawing.Size(341, 22);
            this.txtIdCate.TabIndex = 1;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(29, 13);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(58, 17);
            this.label5.TabIndex = 0;
            this.label5.Text = "Mã Loại";
            // 
            // panel2
            // 
            this.panel2.Controls.Add(this.btnUpSP);
            this.panel2.Controls.Add(this.btnAddSP);
            this.panel2.Controls.Add(this.btnDelSP);
            this.panel2.Controls.Add(this.panel4);
            this.panel2.Location = new System.Drawing.Point(454, 3);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(863, 96);
            this.panel2.TabIndex = 1;
            // 
            // btnUpSP
            // 
            this.btnUpSP.Location = new System.Drawing.Point(193, 25);
            this.btnUpSP.Name = "btnUpSP";
            this.btnUpSP.Size = new System.Drawing.Size(89, 56);
            this.btnUpSP.TabIndex = 4;
            this.btnUpSP.Text = "Sửa";
            this.btnUpSP.UseVisualStyleBackColor = true;
            this.btnUpSP.Click += new System.EventHandler(this.btnUpSP_Click);
            // 
            // btnAddSP
            // 
            this.btnAddSP.Location = new System.Drawing.Point(3, 25);
            this.btnAddSP.Name = "btnAddSP";
            this.btnAddSP.Size = new System.Drawing.Size(89, 56);
            this.btnAddSP.TabIndex = 3;
            this.btnAddSP.Text = "Thêm ";
            this.btnAddSP.UseVisualStyleBackColor = true;
            this.btnAddSP.Click += new System.EventHandler(this.btnAddSP_Click);
            // 
            // btnDelSP
            // 
            this.btnDelSP.Location = new System.Drawing.Point(98, 25);
            this.btnDelSP.Name = "btnDelSP";
            this.btnDelSP.Size = new System.Drawing.Size(89, 56);
            this.btnDelSP.TabIndex = 2;
            this.btnDelSP.Text = "Xoá ";
            this.btnDelSP.UseVisualStyleBackColor = true;
            this.btnDelSP.Click += new System.EventHandler(this.btnDelSP_Click);
            // 
            // panel4
            // 
            this.panel4.Controls.Add(this.btnSearchSP);
            this.panel4.Controls.Add(this.lbReset);
            this.panel4.Controls.Add(this.txtSearchSP);
            this.panel4.Location = new System.Drawing.Point(382, 3);
            this.panel4.Name = "panel4";
            this.panel4.Size = new System.Drawing.Size(430, 78);
            this.panel4.TabIndex = 1;
            // 
            // btnSearchSP
            // 
            this.btnSearchSP.Image = global::QuanLyCafe.Properties.Resources.search_48px;
            this.btnSearchSP.Location = new System.Drawing.Point(349, 12);
            this.btnSearchSP.Name = "btnSearchSP";
            this.btnSearchSP.Size = new System.Drawing.Size(70, 53);
            this.btnSearchSP.TabIndex = 8;
            this.btnSearchSP.UseVisualStyleBackColor = true;
            this.btnSearchSP.Click += new System.EventHandler(this.btnSearchSP_Click);
            // 
            // lbReset
            // 
            this.lbReset.AutoSize = true;
            this.lbReset.Location = new System.Drawing.Point(3, 30);
            this.lbReset.Name = "lbReset";
            this.lbReset.Size = new System.Drawing.Size(64, 17);
            this.lbReset.TabIndex = 1;
            this.lbReset.Text = "Tìm kiếm";
            this.lbReset.Click += new System.EventHandler(this.lbReset_Click);
            // 
            // txtSearchSP
            // 
            this.txtSearchSP.Location = new System.Drawing.Point(80, 27);
            this.txtSearchSP.Name = "txtSearchSP";
            this.txtSearchSP.Size = new System.Drawing.Size(263, 22);
            this.txtSearchSP.TabIndex = 0;
            // 
            // hanghoa
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.Control;
            this.Controls.Add(this.panel3);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.panel1);
            this.Name = "hanghoa";
            this.Size = new System.Drawing.Size(1320, 760);
            this.panel3.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dtgvSP)).EndInit();
            this.panel1.ResumeLayout(false);
            this.tabControl1.ResumeLayout(false);
            this.tabPage1.ResumeLayout(false);
            this.panel5.ResumeLayout(false);
            this.panel5.PerformLayout();
            this.panel9.ResumeLayout(false);
            this.panel9.PerformLayout();
            this.panel7.ResumeLayout(false);
            this.panel7.PerformLayout();
            this.panel6.ResumeLayout(false);
            this.panel6.PerformLayout();
            this.tabPage2.ResumeLayout(false);
            this.panel10.ResumeLayout(false);
            this.panel10.PerformLayout();
            this.panel8.ResumeLayout(false);
            this.panel8.PerformLayout();
            this.panel2.ResumeLayout(false);
            this.panel4.ResumeLayout(false);
            this.panel4.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.DataGridView dtgvSP;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.TabControl tabControl1;
        private System.Windows.Forms.TabPage tabPage1;
        private System.Windows.Forms.Panel panel5;
        private System.Windows.Forms.TextBox txtIdFood;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Panel panel9;
        private System.Windows.Forms.TextBox txtPrice;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Panel panel7;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Panel panel6;
        private System.Windows.Forms.TextBox txtNameFood;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TabPage tabPage2;
        private System.Windows.Forms.Panel panel10;
        private System.Windows.Forms.TextBox txtNameCate;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Panel panel8;
        private System.Windows.Forms.TextBox txtIdCate;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Button btnUpSP;
        private System.Windows.Forms.Button btnAddSP;
        private System.Windows.Forms.Button btnDelSP;
        private System.Windows.Forms.Panel panel4;
        private System.Windows.Forms.Label lbReset;
        private System.Windows.Forms.TextBox txtSearchSP;
        private System.Windows.Forms.Button btnSearchSP;
        private System.Windows.Forms.ComboBox cbCateFood;
    }
}
