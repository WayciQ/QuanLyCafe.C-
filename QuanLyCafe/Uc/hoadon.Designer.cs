namespace QuanLyCafe.Uc
{
    partial class hoadon
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(hoadon));
            this.panel3 = new System.Windows.Forms.Panel();
            this.dtgvBill = new System.Windows.Forms.DataGridView();
            this.panel1 = new System.Windows.Forms.Panel();
            this.panel4 = new System.Windows.Forms.Panel();
            this.dtgvBillInfo = new System.Windows.Forms.DataGridView();
            this.panel2 = new System.Windows.Forms.Panel();
            this.txtDateBill = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.panel5 = new System.Windows.Forms.Panel();
            this.txtIdBill = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.panel6 = new System.Windows.Forms.Panel();
            this.panel7 = new System.Windows.Forms.Panel();
            this.datePick = new System.Windows.Forms.DateTimePicker();
            this.btnSearchKhach = new System.Windows.Forms.Button();
            this.comboBox1 = new System.Windows.Forms.ComboBox();
            this.label3 = new System.Windows.Forms.Label();
            this.copyBill = new System.Windows.Forms.Button();
            this.printBIll = new System.Windows.Forms.Button();
            this.btnDeleteBill = new System.Windows.Forms.Button();
            this.printDocument1 = new System.Drawing.Printing.PrintDocument();
            this.printPreviewDialog1 = new System.Windows.Forms.PrintPreviewDialog();
            this.panel3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dtgvBill)).BeginInit();
            this.panel1.SuspendLayout();
            this.panel4.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dtgvBillInfo)).BeginInit();
            this.panel2.SuspendLayout();
            this.panel5.SuspendLayout();
            this.panel6.SuspendLayout();
            this.panel7.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel3
            // 
            this.panel3.Controls.Add(this.dtgvBill);
            this.panel3.Location = new System.Drawing.Point(551, 165);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(766, 592);
            this.panel3.TabIndex = 9;
            // 
            // dtgvBill
            // 
            this.dtgvBill.AllowUserToAddRows = false;
            this.dtgvBill.AllowUserToDeleteRows = false;
            this.dtgvBill.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dtgvBill.Location = new System.Drawing.Point(24, 3);
            this.dtgvBill.Name = "dtgvBill";
            this.dtgvBill.ReadOnly = true;
            this.dtgvBill.RowHeadersWidth = 51;
            this.dtgvBill.RowTemplate.Height = 24;
            this.dtgvBill.Size = new System.Drawing.Size(766, 586);
            this.dtgvBill.TabIndex = 0;
            this.dtgvBill.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dtgvBill_CellClick_1);
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.panel4);
            this.panel1.Controls.Add(this.panel2);
            this.panel1.Controls.Add(this.panel5);
            this.panel1.Location = new System.Drawing.Point(3, 3);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(542, 760);
            this.panel1.TabIndex = 10;
            // 
            // panel4
            // 
            this.panel4.Controls.Add(this.dtgvBillInfo);
            this.panel4.Location = new System.Drawing.Point(3, 162);
            this.panel4.Name = "panel4";
            this.panel4.Size = new System.Drawing.Size(536, 592);
            this.panel4.TabIndex = 10;
            // 
            // dtgvBillInfo
            // 
            this.dtgvBillInfo.AllowUserToAddRows = false;
            this.dtgvBillInfo.AllowUserToDeleteRows = false;
            this.dtgvBillInfo.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dtgvBillInfo.Location = new System.Drawing.Point(-3, 0);
            this.dtgvBillInfo.Name = "dtgvBillInfo";
            this.dtgvBillInfo.ReadOnly = true;
            this.dtgvBillInfo.RowHeadersWidth = 51;
            this.dtgvBillInfo.RowTemplate.Height = 24;
            this.dtgvBillInfo.Size = new System.Drawing.Size(539, 586);
            this.dtgvBillInfo.TabIndex = 0;
            this.dtgvBillInfo.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dtgvBill_CellClick);
            // 
            // panel2
            // 
            this.panel2.Controls.Add(this.txtDateBill);
            this.panel2.Controls.Add(this.label1);
            this.panel2.Location = new System.Drawing.Point(3, 81);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(424, 61);
            this.panel2.TabIndex = 9;
            // 
            // txtDateBill
            // 
            this.txtDateBill.Location = new System.Drawing.Point(32, 33);
            this.txtDateBill.Name = "txtDateBill";
            this.txtDateBill.Size = new System.Drawing.Size(341, 22);
            this.txtDateBill.TabIndex = 1;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(29, 13);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(65, 17);
            this.label1.TabIndex = 0;
            this.label1.Text = "Ngày tạo";
            // 
            // panel5
            // 
            this.panel5.Controls.Add(this.txtIdBill);
            this.panel5.Controls.Add(this.label2);
            this.panel5.Location = new System.Drawing.Point(3, 14);
            this.panel5.Name = "panel5";
            this.panel5.Size = new System.Drawing.Size(424, 61);
            this.panel5.TabIndex = 8;
            // 
            // txtIdBill
            // 
            this.txtIdBill.Location = new System.Drawing.Point(32, 33);
            this.txtIdBill.Name = "txtIdBill";
            this.txtIdBill.Size = new System.Drawing.Size(341, 22);
            this.txtIdBill.TabIndex = 1;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(29, 13);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(83, 17);
            this.label2.TabIndex = 0;
            this.label2.Text = "Mã hoá đơn";
            // 
            // panel6
            // 
            this.panel6.Controls.Add(this.panel7);
            this.panel6.Controls.Add(this.copyBill);
            this.panel6.Controls.Add(this.printBIll);
            this.panel6.Controls.Add(this.btnDeleteBill);
            this.panel6.Location = new System.Drawing.Point(551, 3);
            this.panel6.Name = "panel6";
            this.panel6.Size = new System.Drawing.Size(763, 156);
            this.panel6.TabIndex = 11;
            // 
            // panel7
            // 
            this.panel7.Controls.Add(this.datePick);
            this.panel7.Controls.Add(this.btnSearchKhach);
            this.panel7.Controls.Add(this.comboBox1);
            this.panel7.Controls.Add(this.label3);
            this.panel7.Location = new System.Drawing.Point(94, 3);
            this.panel7.Name = "panel7";
            this.panel7.Size = new System.Drawing.Size(696, 97);
            this.panel7.TabIndex = 7;
            // 
            // datePick
            // 
            this.datePick.Location = new System.Drawing.Point(105, 49);
            this.datePick.Name = "datePick";
            this.datePick.Size = new System.Drawing.Size(483, 22);
            this.datePick.TabIndex = 8;
            // 
            // btnSearchKhach
            // 
            this.btnSearchKhach.Image = global::QuanLyCafe.Properties.Resources.search_48px;
            this.btnSearchKhach.Location = new System.Drawing.Point(594, 16);
            this.btnSearchKhach.Name = "btnSearchKhach";
            this.btnSearchKhach.Size = new System.Drawing.Size(73, 61);
            this.btnSearchKhach.TabIndex = 10;
            this.btnSearchKhach.UseVisualStyleBackColor = true;
            this.btnSearchKhach.Click += new System.EventHandler(this.btnSearchKhach_Click);
            // 
            // comboBox1
            // 
            this.comboBox1.FormattingEnabled = true;
            this.comboBox1.Items.AddRange(new object[] {
            "Ngày ",
            "Tháng",
            "Năm"});
            this.comboBox1.Location = new System.Drawing.Point(105, 16);
            this.comboBox1.Name = "comboBox1";
            this.comboBox1.Size = new System.Drawing.Size(483, 24);
            this.comboBox1.TabIndex = 1;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(3, 16);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(96, 17);
            this.label3.TabIndex = 0;
            this.label3.Text = "Tìm kiếm theo";
            this.label3.Click += new System.EventHandler(this.label3_Click);
            // 
            // copyBill
            // 
            this.copyBill.Location = new System.Drawing.Point(284, 103);
            this.copyBill.Name = "copyBill";
            this.copyBill.Size = new System.Drawing.Size(89, 56);
            this.copyBill.TabIndex = 6;
            this.copyBill.Text = "Copy";
            this.copyBill.UseVisualStyleBackColor = true;
            this.copyBill.Visible = false;
            this.copyBill.Click += new System.EventHandler(this.copyBill_Click);
            // 
            // printBIll
            // 
            this.printBIll.Location = new System.Drawing.Point(189, 103);
            this.printBIll.Name = "printBIll";
            this.printBIll.Size = new System.Drawing.Size(89, 56);
            this.printBIll.TabIndex = 5;
            this.printBIll.Text = "In";
            this.printBIll.UseVisualStyleBackColor = true;
            this.printBIll.Click += new System.EventHandler(this.printBIll_Click);
            // 
            // btnDeleteBill
            // 
            this.btnDeleteBill.Location = new System.Drawing.Point(94, 103);
            this.btnDeleteBill.Name = "btnDeleteBill";
            this.btnDeleteBill.Size = new System.Drawing.Size(89, 56);
            this.btnDeleteBill.TabIndex = 4;
            this.btnDeleteBill.Text = "Xoá";
            this.btnDeleteBill.UseVisualStyleBackColor = true;
            this.btnDeleteBill.Click += new System.EventHandler(this.btnDeleteBill_Click);
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
            this.printPreviewDialog1.Enabled = true;
            this.printPreviewDialog1.Icon = ((System.Drawing.Icon)(resources.GetObject("printPreviewDialog1.Icon")));
            this.printPreviewDialog1.Name = "printPreviewDialog1";
            this.printPreviewDialog1.Visible = false;
            // 
            // hoadon
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.panel6);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.panel3);
            this.Name = "hoadon";
            this.Size = new System.Drawing.Size(1320, 760);
            this.panel3.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dtgvBill)).EndInit();
            this.panel1.ResumeLayout(false);
            this.panel4.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dtgvBillInfo)).EndInit();
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            this.panel5.ResumeLayout(false);
            this.panel5.PerformLayout();
            this.panel6.ResumeLayout(false);
            this.panel7.ResumeLayout(false);
            this.panel7.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.DataGridView dtgvBill;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Panel panel4;
        private System.Windows.Forms.DataGridView dtgvBillInfo;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.TextBox txtDateBill;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Panel panel5;
        private System.Windows.Forms.TextBox txtIdBill;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Panel panel6;
        private System.Windows.Forms.Panel panel7;
        private System.Windows.Forms.ComboBox comboBox1;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Button copyBill;
        private System.Windows.Forms.Button printBIll;
        private System.Windows.Forms.Button btnDeleteBill;
        private System.Windows.Forms.DateTimePicker datePick;
        private System.Windows.Forms.Button btnSearchKhach;
        private System.Drawing.Printing.PrintDocument printDocument1;
        private System.Windows.Forms.PrintPreviewDialog printPreviewDialog1;
    }
}
