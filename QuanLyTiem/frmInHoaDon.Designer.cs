namespace QuanLyTiem
{
    partial class frmInHoaDon
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

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.tlpRoot = new System.Windows.Forms.TableLayoutPanel();
            this.pnlHeader = new System.Windows.Forms.Panel();
            this.label1 = new System.Windows.Forms.Label();
            this.pnlBill = new System.Windows.Forms.Panel();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.lblTable = new System.Windows.Forms.Label();
            this.lblDate = new System.Windows.Forms.Label();
            this.lblStaff = new System.Windows.Forms.Label();
            this.dgvBillDetails = new System.Windows.Forms.DataGridView();
            this.lblTotalPrice = new System.Windows.Forms.Label();
            this.lblDiscount = new System.Windows.Forms.Label();
            this.lblFinalPrice = new System.Windows.Forms.Label();
            this.btnPrint = new System.Windows.Forms.Button();
            this.btnClose = new System.Windows.Forms.Button();
            this.printDocument1 = new System.Drawing.Printing.PrintDocument();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.tlpRoot.SuspendLayout();
            this.pnlHeader.SuspendLayout();
            this.pnlBill.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvBillDetails)).BeginInit();
            this.SuspendLayout();
            // 
            // tlpRoot
            // 
            this.tlpRoot.ColumnCount = 1;
            this.tlpRoot.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tlpRoot.Controls.Add(this.pnlHeader, 0, 0);
            this.tlpRoot.Controls.Add(this.pnlBill, 0, 1);
            this.tlpRoot.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tlpRoot.Location = new System.Drawing.Point(0, 0);
            this.tlpRoot.Name = "tlpRoot";
            this.tlpRoot.RowCount = 2;
            this.tlpRoot.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 80F));
            this.tlpRoot.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tlpRoot.Size = new System.Drawing.Size(474, 648);
            this.tlpRoot.TabIndex = 0;
            // 
            // pnlHeader
            // 
            this.pnlHeader.Controls.Add(this.label1);
            this.pnlHeader.Dock = System.Windows.Forms.DockStyle.Fill;
            this.pnlHeader.Location = new System.Drawing.Point(3, 3);
            this.pnlHeader.Name = "pnlHeader";
            this.pnlHeader.Size = new System.Drawing.Size(468, 74);
            this.pnlHeader.TabIndex = 0;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(125, 24);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(202, 25);
            this.label1.TabIndex = 0;
            this.label1.Text = "Hóa Đơn Thanh Toán";
            // 
            // pnlBill
            // 
            this.pnlBill.Controls.Add(this.label7);
            this.pnlBill.Controls.Add(this.label6);
            this.pnlBill.Controls.Add(this.label5);
            this.pnlBill.Controls.Add(this.btnClose);
            this.pnlBill.Controls.Add(this.btnPrint);
            this.pnlBill.Controls.Add(this.lblFinalPrice);
            this.pnlBill.Controls.Add(this.lblDiscount);
            this.pnlBill.Controls.Add(this.lblTotalPrice);
            this.pnlBill.Controls.Add(this.dgvBillDetails);
            this.pnlBill.Controls.Add(this.lblStaff);
            this.pnlBill.Controls.Add(this.lblDate);
            this.pnlBill.Controls.Add(this.lblTable);
            this.pnlBill.Controls.Add(this.label4);
            this.pnlBill.Controls.Add(this.label3);
            this.pnlBill.Controls.Add(this.label2);
            this.pnlBill.Dock = System.Windows.Forms.DockStyle.Fill;
            this.pnlBill.Location = new System.Drawing.Point(3, 83);
            this.pnlBill.Name = "pnlBill";
            this.pnlBill.Size = new System.Drawing.Size(468, 562);
            this.pnlBill.TabIndex = 1;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(96, 15);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(244, 25);
            this.label2.TabIndex = 0;
            this.label2.Text = "Tiệm ăn vặt Tài handsome";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(145, 51);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(137, 25);
            this.label3.TabIndex = 1;
            this.label3.Text = "69 Hoa Thánh";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(145, 87);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(122, 25);
            this.label4.TabIndex = 2;
            this.label4.Text = "0968936082";
            // 
            // lblTable
            // 
            this.lblTable.AutoSize = true;
            this.lblTable.Location = new System.Drawing.Point(10, 124);
            this.lblTable.Name = "lblTable";
            this.lblTable.Size = new System.Drawing.Size(68, 25);
            this.lblTable.TabIndex = 3;
            this.lblTable.Text = "Bàn:...";
            // 
            // lblDate
            // 
            this.lblDate.AutoSize = true;
            this.lblDate.Location = new System.Drawing.Point(10, 153);
            this.lblDate.Name = "lblDate";
            this.lblDate.Size = new System.Drawing.Size(79, 25);
            this.lblDate.TabIndex = 4;
            this.lblDate.Text = "Ngày:...";
            // 
            // lblStaff
            // 
            this.lblStaff.AutoSize = true;
            this.lblStaff.Location = new System.Drawing.Point(10, 182);
            this.lblStaff.Name = "lblStaff";
            this.lblStaff.Size = new System.Drawing.Size(106, 25);
            this.lblStaff.TabIndex = 5;
            this.lblStaff.Text = "Nhân viên:";
            // 
            // dgvBillDetails
            // 
            this.dgvBillDetails.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.dgvBillDetails.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvBillDetails.Location = new System.Drawing.Point(15, 223);
            this.dgvBillDetails.Name = "dgvBillDetails";
            this.dgvBillDetails.RowHeadersWidth = 51;
            this.dgvBillDetails.RowTemplate.Height = 24;
            this.dgvBillDetails.Size = new System.Drawing.Size(445, 150);
            this.dgvBillDetails.TabIndex = 6;
            // 
            // lblTotalPrice
            // 
            this.lblTotalPrice.AutoSize = true;
            this.lblTotalPrice.Location = new System.Drawing.Point(172, 404);
            this.lblTotalPrice.Name = "lblTotalPrice";
            this.lblTotalPrice.Size = new System.Drawing.Size(112, 25);
            this.lblTotalPrice.TabIndex = 7;
            this.lblTotalPrice.Text = "Tổng cộng:";
            // 
            // lblDiscount
            // 
            this.lblDiscount.AutoSize = true;
            this.lblDiscount.Location = new System.Drawing.Point(172, 437);
            this.lblDiscount.Name = "lblDiscount";
            this.lblDiscount.Size = new System.Drawing.Size(95, 25);
            this.lblDiscount.TabIndex = 8;
            this.lblDiscount.Text = "Giảm giá:";
            // 
            // lblFinalPrice
            // 
            this.lblFinalPrice.AutoSize = true;
            this.lblFinalPrice.Location = new System.Drawing.Point(172, 473);
            this.lblFinalPrice.Name = "lblFinalPrice";
            this.lblFinalPrice.Size = new System.Drawing.Size(118, 25);
            this.lblFinalPrice.TabIndex = 9;
            this.lblFinalPrice.Text = "Thanh toán:";
            // 
            // btnPrint
            // 
            this.btnPrint.Location = new System.Drawing.Point(74, 508);
            this.btnPrint.Name = "btnPrint";
            this.btnPrint.Size = new System.Drawing.Size(92, 29);
            this.btnPrint.TabIndex = 10;
            this.btnPrint.Text = "In";
            this.btnPrint.UseVisualStyleBackColor = true;
            this.btnPrint.Click += new System.EventHandler(this.btnPrint_Click);
            // 
            // btnClose
            // 
            this.btnClose.Location = new System.Drawing.Point(272, 501);
            this.btnClose.Name = "btnClose";
            this.btnClose.Size = new System.Drawing.Size(118, 36);
            this.btnClose.TabIndex = 11;
            this.btnClose.Text = "Đóng";
            this.btnClose.UseVisualStyleBackColor = true;
            this.btnClose.Click += new System.EventHandler(this.btnClose_Click);
            // 
            // printDocument1
            // 
            this.printDocument1.PrintPage += new System.Drawing.Printing.PrintPageEventHandler(this.printDocument1_PrintPage);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(15, 404);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(100, 25);
            this.label5.TabIndex = 12;
            this.label5.Text = "Tổng tiền:";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(20, 437);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(95, 25);
            this.label6.TabIndex = 13;
            this.label6.Text = "Giảm giá:";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(20, 477);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(126, 25);
            this.label7.TabIndex = 14;
            this.label7.Text = "Thanh Toán:";
            // 
            // frmInHoaDon
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(12F, 25F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(474, 648);
            this.Controls.Add(this.tlpRoot);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "frmInHoaDon";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "frmInHoaDon";
            this.tlpRoot.ResumeLayout(false);
            this.pnlHeader.ResumeLayout(false);
            this.pnlHeader.PerformLayout();
            this.pnlBill.ResumeLayout(false);
            this.pnlBill.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvBillDetails)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TableLayoutPanel tlpRoot;
        private System.Windows.Forms.Panel pnlHeader;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Panel pnlBill;
        private System.Windows.Forms.DataGridView dgvBillDetails;
        private System.Windows.Forms.Label lblStaff;
        private System.Windows.Forms.Label lblDate;
        private System.Windows.Forms.Label lblTable;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button btnClose;
        private System.Windows.Forms.Button btnPrint;
        private System.Windows.Forms.Label lblFinalPrice;
        private System.Windows.Forms.Label lblDiscount;
        private System.Windows.Forms.Label lblTotalPrice;
        private System.Drawing.Printing.PrintDocument printDocument1;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label5;
    }
}