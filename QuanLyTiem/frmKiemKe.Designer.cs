namespace QuanLyTiem
{
    partial class frmKiemKe
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            this.tlpRoot = new System.Windows.Forms.TableLayoutPanel();
            this.pnlHeader = new System.Windows.Forms.Panel();
            this.label1 = new System.Windows.Forms.Label();
            this.tlpContent = new System.Windows.Forms.TableLayoutPanel();
            this.tlpContentLeft = new System.Windows.Forms.TableLayoutPanel();
            this.tlpBottomBuutton = new System.Windows.Forms.TableLayoutPanel();
            this.btnView = new System.Windows.Forms.Button();
            this.btnPrint = new System.Windows.Forms.Button();
            this.btnExit = new System.Windows.Forms.Button();
            this.tlpGroupBox = new System.Windows.Forms.TableLayoutPanel();
            this.pnlGroupBoxTop = new System.Windows.Forms.Panel();
            this.grb1 = new System.Windows.Forms.GroupBox();
            this.grb2 = new System.Windows.Forms.GroupBox();
            this.tlpKieuBaoCao = new System.Windows.Forms.TableLayoutPanel();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.txtStaffName = new System.Windows.Forms.TextBox();
            this.dtpDate = new System.Windows.Forms.DateTimePicker();
            this.rdoByBill = new System.Windows.Forms.RadioButton();
            this.rdoByFood = new System.Windows.Forms.RadioButton();
            this.tlpKetQua = new System.Windows.Forms.TableLayoutPanel();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.dgvReport = new System.Windows.Forms.DataGridView();
            this.txtTotalBill = new System.Windows.Forms.TextBox();
            this.txtTotalRevenue = new System.Windows.Forms.TextBox();
            this.txtFoodCount = new System.Windows.Forms.TextBox();
            this.txtBestSeller = new System.Windows.Forms.TextBox();
            this.tlpRoot.SuspendLayout();
            this.pnlHeader.SuspendLayout();
            this.tlpContent.SuspendLayout();
            this.tlpContentLeft.SuspendLayout();
            this.tlpBottomBuutton.SuspendLayout();
            this.tlpGroupBox.SuspendLayout();
            this.pnlGroupBoxTop.SuspendLayout();
            this.grb1.SuspendLayout();
            this.grb2.SuspendLayout();
            this.tlpKieuBaoCao.SuspendLayout();
            this.tlpKetQua.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvReport)).BeginInit();
            this.SuspendLayout();
            // 
            // tlpRoot
            // 
            this.tlpRoot.ColumnCount = 1;
            this.tlpRoot.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tlpRoot.Controls.Add(this.pnlHeader, 0, 0);
            this.tlpRoot.Controls.Add(this.tlpContent, 0, 1);
            this.tlpRoot.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tlpRoot.Location = new System.Drawing.Point(0, 0);
            this.tlpRoot.Name = "tlpRoot";
            this.tlpRoot.RowCount = 2;
            this.tlpRoot.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 80F));
            this.tlpRoot.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tlpRoot.Size = new System.Drawing.Size(1064, 730);
            this.tlpRoot.TabIndex = 0;
            // 
            // pnlHeader
            // 
            this.pnlHeader.Controls.Add(this.label1);
            this.pnlHeader.Dock = System.Windows.Forms.DockStyle.Fill;
            this.pnlHeader.Location = new System.Drawing.Point(3, 3);
            this.pnlHeader.Name = "pnlHeader";
            this.pnlHeader.Size = new System.Drawing.Size(1058, 74);
            this.pnlHeader.TabIndex = 0;
            // 
            // label1
            // 
            this.label1.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.SystemColors.HotTrack;
            this.label1.Location = new System.Drawing.Point(21, 22);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(365, 25);
            this.label1.TabIndex = 0;
            this.label1.Text = "KIỂM KÊ BÁN HÀNG TRONG NGÀY";
            // 
            // tlpContent
            // 
            this.tlpContent.ColumnCount = 2;
            this.tlpContent.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 40F));
            this.tlpContent.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 60F));
            this.tlpContent.Controls.Add(this.tlpContentLeft, 0, 0);
            this.tlpContent.Controls.Add(this.dgvReport, 1, 0);
            this.tlpContent.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tlpContent.Location = new System.Drawing.Point(3, 83);
            this.tlpContent.Name = "tlpContent";
            this.tlpContent.RowCount = 1;
            this.tlpContent.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tlpContent.Size = new System.Drawing.Size(1058, 644);
            this.tlpContent.TabIndex = 1;
            // 
            // tlpContentLeft
            // 
            this.tlpContentLeft.ColumnCount = 1;
            this.tlpContentLeft.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tlpContentLeft.Controls.Add(this.tlpBottomBuutton, 0, 1);
            this.tlpContentLeft.Controls.Add(this.tlpGroupBox, 0, 0);
            this.tlpContentLeft.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tlpContentLeft.Location = new System.Drawing.Point(3, 3);
            this.tlpContentLeft.Name = "tlpContentLeft";
            this.tlpContentLeft.RowCount = 2;
            this.tlpContentLeft.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tlpContentLeft.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 80F));
            this.tlpContentLeft.Size = new System.Drawing.Size(417, 638);
            this.tlpContentLeft.TabIndex = 0;
            // 
            // tlpBottomBuutton
            // 
            this.tlpBottomBuutton.ColumnCount = 3;
            this.tlpBottomBuutton.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 33F));
            this.tlpBottomBuutton.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 33F));
            this.tlpBottomBuutton.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 34F));
            this.tlpBottomBuutton.Controls.Add(this.btnView, 0, 0);
            this.tlpBottomBuutton.Controls.Add(this.btnPrint, 1, 0);
            this.tlpBottomBuutton.Controls.Add(this.btnExit, 2, 0);
            this.tlpBottomBuutton.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tlpBottomBuutton.Location = new System.Drawing.Point(3, 561);
            this.tlpBottomBuutton.Name = "tlpBottomBuutton";
            this.tlpBottomBuutton.RowCount = 1;
            this.tlpBottomBuutton.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tlpBottomBuutton.Size = new System.Drawing.Size(411, 74);
            this.tlpBottomBuutton.TabIndex = 0;
            // 
            // btnView
            // 
            this.btnView.Dock = System.Windows.Forms.DockStyle.Fill;
            this.btnView.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(200)))), ((int)(((byte)(200)))), ((int)(((byte)(200)))));
            this.btnView.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnView.ForeColor = System.Drawing.Color.RoyalBlue;
            this.btnView.Location = new System.Drawing.Point(3, 3);
            this.btnView.Name = "btnView";
            this.btnView.Size = new System.Drawing.Size(129, 68);
            this.btnView.TabIndex = 0;
            this.btnView.Text = "Xem";
            this.btnView.UseVisualStyleBackColor = true;
            this.btnView.Click += new System.EventHandler(this.btnView_Click);
            // 
            // btnPrint
            // 
            this.btnPrint.Dock = System.Windows.Forms.DockStyle.Fill;
            this.btnPrint.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(200)))), ((int)(((byte)(200)))), ((int)(((byte)(200)))));
            this.btnPrint.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnPrint.ForeColor = System.Drawing.Color.LimeGreen;
            this.btnPrint.Location = new System.Drawing.Point(138, 3);
            this.btnPrint.Name = "btnPrint";
            this.btnPrint.Size = new System.Drawing.Size(129, 68);
            this.btnPrint.TabIndex = 1;
            this.btnPrint.Text = "In";
            this.btnPrint.UseVisualStyleBackColor = true;
            this.btnPrint.Click += new System.EventHandler(this.btnPrint_Click);
            // 
            // btnExit
            // 
            this.btnExit.Dock = System.Windows.Forms.DockStyle.Fill;
            this.btnExit.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(200)))), ((int)(((byte)(200)))), ((int)(((byte)(200)))));
            this.btnExit.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnExit.ForeColor = System.Drawing.Color.Crimson;
            this.btnExit.Location = new System.Drawing.Point(273, 3);
            this.btnExit.Name = "btnExit";
            this.btnExit.Size = new System.Drawing.Size(135, 68);
            this.btnExit.TabIndex = 2;
            this.btnExit.Text = "Kết thúc";
            this.btnExit.UseVisualStyleBackColor = true;
            this.btnExit.Click += new System.EventHandler(this.btnExit_Click);
            // 
            // tlpGroupBox
            // 
            this.tlpGroupBox.ColumnCount = 1;
            this.tlpGroupBox.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tlpGroupBox.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tlpGroupBox.Controls.Add(this.pnlGroupBoxTop, 0, 0);
            this.tlpGroupBox.Controls.Add(this.grb2, 0, 1);
            this.tlpGroupBox.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tlpGroupBox.Location = new System.Drawing.Point(3, 3);
            this.tlpGroupBox.Name = "tlpGroupBox";
            this.tlpGroupBox.RowCount = 2;
            this.tlpGroupBox.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 53.99061F));
            this.tlpGroupBox.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 46.00939F));
            this.tlpGroupBox.Size = new System.Drawing.Size(411, 552);
            this.tlpGroupBox.TabIndex = 1;
            // 
            // pnlGroupBoxTop
            // 
            this.pnlGroupBoxTop.Controls.Add(this.grb1);
            this.pnlGroupBoxTop.Dock = System.Windows.Forms.DockStyle.Fill;
            this.pnlGroupBoxTop.Location = new System.Drawing.Point(3, 3);
            this.pnlGroupBoxTop.Name = "pnlGroupBoxTop";
            this.pnlGroupBoxTop.Size = new System.Drawing.Size(405, 292);
            this.pnlGroupBoxTop.TabIndex = 0;
            // 
            // grb1
            // 
            this.grb1.Controls.Add(this.tlpKieuBaoCao);
            this.grb1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.grb1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.grb1.ForeColor = System.Drawing.Color.DodgerBlue;
            this.grb1.Location = new System.Drawing.Point(0, 0);
            this.grb1.Name = "grb1";
            this.grb1.Size = new System.Drawing.Size(405, 292);
            this.grb1.TabIndex = 0;
            this.grb1.TabStop = false;
            this.grb1.Text = "Kiểu báo cáo kiểm kê";
            // 
            // grb2
            // 
            this.grb2.Controls.Add(this.tlpKetQua);
            this.grb2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.grb2.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.grb2.ForeColor = System.Drawing.Color.DodgerBlue;
            this.grb2.Location = new System.Drawing.Point(3, 301);
            this.grb2.Name = "grb2";
            this.grb2.Size = new System.Drawing.Size(405, 248);
            this.grb2.TabIndex = 1;
            this.grb2.TabStop = false;
            this.grb2.Text = "Kiểu tổng hợp";
            // 
            // tlpKieuBaoCao
            // 
            this.tlpKieuBaoCao.ColumnCount = 2;
            this.tlpKieuBaoCao.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 154F));
            this.tlpKieuBaoCao.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tlpKieuBaoCao.Controls.Add(this.label2, 0, 0);
            this.tlpKieuBaoCao.Controls.Add(this.label3, 0, 1);
            this.tlpKieuBaoCao.Controls.Add(this.txtStaffName, 1, 0);
            this.tlpKieuBaoCao.Controls.Add(this.dtpDate, 1, 1);
            this.tlpKieuBaoCao.Controls.Add(this.rdoByBill, 0, 2);
            this.tlpKieuBaoCao.Controls.Add(this.rdoByFood, 0, 3);
            this.tlpKieuBaoCao.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tlpKieuBaoCao.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tlpKieuBaoCao.Location = new System.Drawing.Point(3, 26);
            this.tlpKieuBaoCao.Name = "tlpKieuBaoCao";
            this.tlpKieuBaoCao.RowCount = 4;
            this.tlpKieuBaoCao.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 25F));
            this.tlpKieuBaoCao.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 25F));
            this.tlpKieuBaoCao.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 25F));
            this.tlpKieuBaoCao.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 25F));
            this.tlpKieuBaoCao.Size = new System.Drawing.Size(399, 263);
            this.tlpKieuBaoCao.TabIndex = 0;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.SystemColors.ControlText;
            this.label2.Location = new System.Drawing.Point(3, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(106, 25);
            this.label2.TabIndex = 0;
            this.label2.Text = "Nhân viên:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.ForeColor = System.Drawing.SystemColors.ControlText;
            this.label3.Location = new System.Drawing.Point(3, 65);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(139, 25);
            this.label3.TabIndex = 1;
            this.label3.Text = "Ngày báo cáo:";
            // 
            // txtStaffName
            // 
            this.txtStaffName.Dock = System.Windows.Forms.DockStyle.Fill;
            this.txtStaffName.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtStaffName.Location = new System.Drawing.Point(157, 3);
            this.txtStaffName.Name = "txtStaffName";
            this.txtStaffName.Size = new System.Drawing.Size(239, 30);
            this.txtStaffName.TabIndex = 2;
            // 
            // dtpDate
            // 
            this.dtpDate.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dtpDate.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dtpDate.Location = new System.Drawing.Point(157, 68);
            this.dtpDate.Name = "dtpDate";
            this.dtpDate.Size = new System.Drawing.Size(239, 30);
            this.dtpDate.TabIndex = 3;
            // 
            // rdoByBill
            // 
            this.rdoByBill.AutoSize = true;
            this.tlpKieuBaoCao.SetColumnSpan(this.rdoByBill, 2);
            this.rdoByBill.ForeColor = System.Drawing.SystemColors.ControlText;
            this.rdoByBill.Location = new System.Drawing.Point(3, 133);
            this.rdoByBill.Name = "rdoByBill";
            this.rdoByBill.Size = new System.Drawing.Size(236, 29);
            this.rdoByBill.TabIndex = 4;
            this.rdoByBill.TabStop = true;
            this.rdoByBill.Text = "Tổng hợp theo hóa đơn";
            this.rdoByBill.UseVisualStyleBackColor = true;
            this.rdoByBill.CheckedChanged += new System.EventHandler(this.rdoByBill_CheckedChanged);
            // 
            // rdoByFood
            // 
            this.rdoByFood.AutoSize = true;
            this.tlpKieuBaoCao.SetColumnSpan(this.rdoByFood, 2);
            this.rdoByFood.ForeColor = System.Drawing.SystemColors.ControlText;
            this.rdoByFood.Location = new System.Drawing.Point(3, 198);
            this.rdoByFood.Name = "rdoByFood";
            this.rdoByFood.Size = new System.Drawing.Size(246, 29);
            this.rdoByFood.TabIndex = 5;
            this.rdoByFood.TabStop = true;
            this.rdoByFood.Text = "Tổng hợp theo mặt hàng";
            this.rdoByFood.UseVisualStyleBackColor = true;
            this.rdoByFood.CheckedChanged += new System.EventHandler(this.rdoByFood_CheckedChanged);
            // 
            // tlpKetQua
            // 
            this.tlpKetQua.ColumnCount = 2;
            this.tlpKetQua.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 174F));
            this.tlpKetQua.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tlpKetQua.Controls.Add(this.label4, 0, 0);
            this.tlpKetQua.Controls.Add(this.label5, 0, 1);
            this.tlpKetQua.Controls.Add(this.label6, 0, 2);
            this.tlpKetQua.Controls.Add(this.label7, 0, 3);
            this.tlpKetQua.Controls.Add(this.txtTotalBill, 1, 0);
            this.tlpKetQua.Controls.Add(this.txtTotalRevenue, 1, 1);
            this.tlpKetQua.Controls.Add(this.txtFoodCount, 1, 2);
            this.tlpKetQua.Controls.Add(this.txtBestSeller, 1, 3);
            this.tlpKetQua.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tlpKetQua.Location = new System.Drawing.Point(3, 26);
            this.tlpKetQua.Name = "tlpKetQua";
            this.tlpKetQua.RowCount = 4;
            this.tlpKetQua.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 25F));
            this.tlpKetQua.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 25F));
            this.tlpKetQua.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 25F));
            this.tlpKetQua.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 25F));
            this.tlpKetQua.Size = new System.Drawing.Size(399, 219);
            this.tlpKetQua.TabIndex = 0;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.ForeColor = System.Drawing.SystemColors.ControlText;
            this.label4.Location = new System.Drawing.Point(3, 0);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(166, 25);
            this.label4.TabIndex = 0;
            this.label4.Text = "Tổng số hóa đơn:";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.ForeColor = System.Drawing.SystemColors.ControlText;
            this.label5.Location = new System.Drawing.Point(3, 54);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(137, 50);
            this.label5.TabIndex = 1;
            this.label5.Text = "Tổng tiền bán hàng:";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.ForeColor = System.Drawing.SystemColors.ControlText;
            this.label6.Location = new System.Drawing.Point(3, 108);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(155, 50);
            this.label6.TabIndex = 2;
            this.label6.Text = "Số mặt hàng đã bán:";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.ForeColor = System.Drawing.SystemColors.ControlText;
            this.label7.Location = new System.Drawing.Point(3, 162);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(148, 50);
            this.label7.TabIndex = 3;
            this.label7.Text = "Mặt hàng nhập bán nhất";
            // 
            // dgvReport
            // 
            this.dgvReport.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgvReport.BackgroundColor = System.Drawing.Color.White;
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle1.BackColor = System.Drawing.Color.DodgerBlue;
            dataGridViewCellStyle1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle1.ForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle1.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dgvReport.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle1;
            this.dgvReport.ColumnHeadersHeight = 35;
            this.dgvReport.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dgvReport.EnableHeadersVisualStyles = false;
            this.dgvReport.Location = new System.Drawing.Point(426, 3);
            this.dgvReport.Name = "dgvReport";
            this.dgvReport.RowHeadersVisible = false;
            this.dgvReport.RowHeadersWidth = 51;
            this.dgvReport.RowTemplate.Height = 24;
            this.dgvReport.Size = new System.Drawing.Size(629, 638);
            this.dgvReport.TabIndex = 1;
            // 
            // txtTotalBill
            // 
            this.txtTotalBill.Dock = System.Windows.Forms.DockStyle.Fill;
            this.txtTotalBill.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtTotalBill.Location = new System.Drawing.Point(177, 3);
            this.txtTotalBill.Name = "txtTotalBill";
            this.txtTotalBill.Size = new System.Drawing.Size(219, 30);
            this.txtTotalBill.TabIndex = 4;
            // 
            // txtTotalRevenue
            // 
            this.txtTotalRevenue.Dock = System.Windows.Forms.DockStyle.Fill;
            this.txtTotalRevenue.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtTotalRevenue.Location = new System.Drawing.Point(177, 57);
            this.txtTotalRevenue.Name = "txtTotalRevenue";
            this.txtTotalRevenue.Size = new System.Drawing.Size(219, 30);
            this.txtTotalRevenue.TabIndex = 5;
            // 
            // txtFoodCount
            // 
            this.txtFoodCount.Dock = System.Windows.Forms.DockStyle.Fill;
            this.txtFoodCount.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtFoodCount.Location = new System.Drawing.Point(177, 111);
            this.txtFoodCount.Name = "txtFoodCount";
            this.txtFoodCount.Size = new System.Drawing.Size(219, 30);
            this.txtFoodCount.TabIndex = 6;
            // 
            // txtBestSeller
            // 
            this.txtBestSeller.Dock = System.Windows.Forms.DockStyle.Fill;
            this.txtBestSeller.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtBestSeller.Location = new System.Drawing.Point(177, 165);
            this.txtBestSeller.Name = "txtBestSeller";
            this.txtBestSeller.Size = new System.Drawing.Size(219, 30);
            this.txtBestSeller.TabIndex = 7;
            // 
            // frmKiemKe
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(120F, 120F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Dpi;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(1064, 730);
            this.Controls.Add(this.tlpRoot);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.Name = "frmKiemKe";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "frmKiemKe";
            this.Load += new System.EventHandler(this.frmKiemKe_Load);
            this.tlpRoot.ResumeLayout(false);
            this.pnlHeader.ResumeLayout(false);
            this.pnlHeader.PerformLayout();
            this.tlpContent.ResumeLayout(false);
            this.tlpContentLeft.ResumeLayout(false);
            this.tlpBottomBuutton.ResumeLayout(false);
            this.tlpGroupBox.ResumeLayout(false);
            this.pnlGroupBoxTop.ResumeLayout(false);
            this.grb1.ResumeLayout(false);
            this.grb2.ResumeLayout(false);
            this.tlpKieuBaoCao.ResumeLayout(false);
            this.tlpKieuBaoCao.PerformLayout();
            this.tlpKetQua.ResumeLayout(false);
            this.tlpKetQua.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvReport)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TableLayoutPanel tlpRoot;
        private System.Windows.Forms.Panel pnlHeader;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TableLayoutPanel tlpContent;
        private System.Windows.Forms.TableLayoutPanel tlpContentLeft;
        private System.Windows.Forms.TableLayoutPanel tlpBottomBuutton;
        private System.Windows.Forms.Button btnView;
        private System.Windows.Forms.Button btnPrint;
        private System.Windows.Forms.Button btnExit;
        private System.Windows.Forms.TableLayoutPanel tlpGroupBox;
        private System.Windows.Forms.Panel pnlGroupBoxTop;
        private System.Windows.Forms.GroupBox grb1;
        private System.Windows.Forms.TableLayoutPanel tlpKieuBaoCao;
        private System.Windows.Forms.GroupBox grb2;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox txtStaffName;
        private System.Windows.Forms.DateTimePicker dtpDate;
        private System.Windows.Forms.RadioButton rdoByBill;
        private System.Windows.Forms.RadioButton rdoByFood;
        private System.Windows.Forms.TableLayoutPanel tlpKetQua;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.DataGridView dgvReport;
        private System.Windows.Forms.TextBox txtTotalBill;
        private System.Windows.Forms.TextBox txtTotalRevenue;
        private System.Windows.Forms.TextBox txtFoodCount;
        private System.Windows.Forms.TextBox txtBestSeller;
    }
}