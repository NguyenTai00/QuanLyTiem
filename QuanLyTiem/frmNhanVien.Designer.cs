namespace QuanLyTiem
{
    partial class frmNhanVien
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
            this.pnlTitle = new System.Windows.Forms.Panel();
            this.label1 = new System.Windows.Forms.Label();
            this.tlpContent = new System.Windows.Forms.TableLayoutPanel();
            this.tlpLeftContent = new System.Windows.Forms.TableLayoutPanel();
            this.tlpLeftHeader = new System.Windows.Forms.TableLayoutPanel();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.txtHoTen = new System.Windows.Forms.TextBox();
            this.txtEmail = new System.Windows.Forms.TextBox();
            this.txtDiaChi = new System.Windows.Forms.TextBox();
            this.txtMoTa = new System.Windows.Forms.TextBox();
            this.txtDienThoai = new System.Windows.Forms.TextBox();
            this.tlpSmallLeft = new System.Windows.Forms.TableLayoutPanel();
            this.rdoNam = new System.Windows.Forms.RadioButton();
            this.rdoNu = new System.Windows.Forms.RadioButton();
            this.dtpNgaySinh = new System.Windows.Forms.DateTimePicker();
            this.dtpNgayVaoLam = new System.Windows.Forms.DateTimePicker();
            this.tlpLeftBottom = new System.Windows.Forms.TableLayoutPanel();
            this.btnThemMoi = new System.Windows.Forms.Button();
            this.btnSua = new System.Windows.Forms.Button();
            this.btnXoa = new System.Windows.Forms.Button();
            this.btnHuyGhi = new System.Windows.Forms.Button();
            this.btnGhi = new System.Windows.Forms.Button();
            this.btnKetThuc = new System.Windows.Forms.Button();
            this.tlpRightcontent = new System.Windows.Forms.TableLayoutPanel();
            this.tlpRightHeader = new System.Windows.Forms.TableLayoutPanel();
            this.pnlHeaderRight = new System.Windows.Forms.Panel();
            this.label10 = new System.Windows.Forms.Label();
            this.tlpRightSearch = new System.Windows.Forms.TableLayoutPanel();
            this.txtTimKiem = new System.Windows.Forms.TextBox();
            this.tlpRadio = new System.Windows.Forms.TableLayoutPanel();
            this.rdoTimTheoTen = new System.Windows.Forms.RadioButton();
            this.radioButton2 = new System.Windows.Forms.RadioButton();
            this.dgvNhanVien = new System.Windows.Forms.DataGridView();
            this.tlpRoot.SuspendLayout();
            this.pnlTitle.SuspendLayout();
            this.tlpContent.SuspendLayout();
            this.tlpLeftContent.SuspendLayout();
            this.tlpLeftHeader.SuspendLayout();
            this.tlpSmallLeft.SuspendLayout();
            this.tlpLeftBottom.SuspendLayout();
            this.tlpRightcontent.SuspendLayout();
            this.tlpRightHeader.SuspendLayout();
            this.pnlHeaderRight.SuspendLayout();
            this.tlpRightSearch.SuspendLayout();
            this.tlpRadio.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvNhanVien)).BeginInit();
            this.SuspendLayout();
            // 
            // tlpRoot
            // 
            this.tlpRoot.ColumnCount = 1;
            this.tlpRoot.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tlpRoot.Controls.Add(this.pnlTitle, 0, 0);
            this.tlpRoot.Controls.Add(this.tlpContent, 0, 1);
            this.tlpRoot.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tlpRoot.Location = new System.Drawing.Point(0, 0);
            this.tlpRoot.Name = "tlpRoot";
            this.tlpRoot.RowCount = 2;
            this.tlpRoot.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 80F));
            this.tlpRoot.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tlpRoot.Size = new System.Drawing.Size(992, 639);
            this.tlpRoot.TabIndex = 0;
            // 
            // pnlTitle
            // 
            this.pnlTitle.Controls.Add(this.label1);
            this.pnlTitle.Dock = System.Windows.Forms.DockStyle.Fill;
            this.pnlTitle.Location = new System.Drawing.Point(3, 3);
            this.pnlTitle.Name = "pnlTitle";
            this.pnlTitle.Size = new System.Drawing.Size(986, 74);
            this.pnlTitle.TabIndex = 0;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(25, 25);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(170, 25);
            this.label1.TabIndex = 0;
            this.label1.Text = "Quản lý nhân viên";
            // 
            // tlpContent
            // 
            this.tlpContent.ColumnCount = 2;
            this.tlpContent.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 44.33834F));
            this.tlpContent.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 55.66166F));
            this.tlpContent.Controls.Add(this.tlpLeftContent, 0, 0);
            this.tlpContent.Controls.Add(this.tlpRightcontent, 1, 0);
            this.tlpContent.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tlpContent.Location = new System.Drawing.Point(3, 83);
            this.tlpContent.Name = "tlpContent";
            this.tlpContent.RowCount = 1;
            this.tlpContent.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tlpContent.Size = new System.Drawing.Size(986, 553);
            this.tlpContent.TabIndex = 1;
            // 
            // tlpLeftContent
            // 
            this.tlpLeftContent.ColumnCount = 1;
            this.tlpLeftContent.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tlpLeftContent.Controls.Add(this.tlpLeftHeader, 0, 0);
            this.tlpLeftContent.Controls.Add(this.tlpLeftBottom, 0, 1);
            this.tlpLeftContent.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tlpLeftContent.Location = new System.Drawing.Point(3, 3);
            this.tlpLeftContent.Name = "tlpLeftContent";
            this.tlpLeftContent.RowCount = 2;
            this.tlpLeftContent.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tlpLeftContent.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 80F));
            this.tlpLeftContent.Size = new System.Drawing.Size(431, 547);
            this.tlpLeftContent.TabIndex = 0;
            // 
            // tlpLeftHeader
            // 
            this.tlpLeftHeader.ColumnCount = 2;
            this.tlpLeftHeader.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 41.247F));
            this.tlpLeftHeader.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 58.753F));
            this.tlpLeftHeader.Controls.Add(this.label2, 0, 0);
            this.tlpLeftHeader.Controls.Add(this.label3, 0, 1);
            this.tlpLeftHeader.Controls.Add(this.label4, 0, 2);
            this.tlpLeftHeader.Controls.Add(this.label5, 0, 3);
            this.tlpLeftHeader.Controls.Add(this.label6, 0, 4);
            this.tlpLeftHeader.Controls.Add(this.label7, 0, 5);
            this.tlpLeftHeader.Controls.Add(this.label8, 0, 6);
            this.tlpLeftHeader.Controls.Add(this.label9, 0, 7);
            this.tlpLeftHeader.Controls.Add(this.txtHoTen, 1, 0);
            this.tlpLeftHeader.Controls.Add(this.txtEmail, 1, 4);
            this.tlpLeftHeader.Controls.Add(this.txtDiaChi, 1, 5);
            this.tlpLeftHeader.Controls.Add(this.txtMoTa, 1, 7);
            this.tlpLeftHeader.Controls.Add(this.txtDienThoai, 1, 3);
            this.tlpLeftHeader.Controls.Add(this.tlpSmallLeft, 1, 2);
            this.tlpLeftHeader.Controls.Add(this.dtpNgaySinh, 1, 1);
            this.tlpLeftHeader.Controls.Add(this.dtpNgayVaoLam, 1, 6);
            this.tlpLeftHeader.Dock = System.Windows.Forms.DockStyle.Top;
            this.tlpLeftHeader.Location = new System.Drawing.Point(3, 3);
            this.tlpLeftHeader.Name = "tlpLeftHeader";
            this.tlpLeftHeader.RowCount = 8;
            this.tlpLeftHeader.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 12F));
            this.tlpLeftHeader.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 12F));
            this.tlpLeftHeader.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 12F));
            this.tlpLeftHeader.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 12F));
            this.tlpLeftHeader.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 12F));
            this.tlpLeftHeader.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 12F));
            this.tlpLeftHeader.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 12F));
            this.tlpLeftHeader.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 16F));
            this.tlpLeftHeader.Size = new System.Drawing.Size(425, 354);
            this.tlpLeftHeader.TabIndex = 0;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(3, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(123, 25);
            this.label2.TabIndex = 0;
            this.label2.Text = "Họ và tên(*):";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(3, 42);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(105, 25);
            this.label3.TabIndex = 1;
            this.label3.Text = "Ngày sinh:";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(3, 84);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(88, 25);
            this.label4.TabIndex = 2;
            this.label4.Text = "Giới tính:";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(3, 126);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(105, 25);
            this.label5.TabIndex = 3;
            this.label5.Text = "Điện thoại:";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(3, 168);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(66, 25);
            this.label6.TabIndex = 4;
            this.label6.Text = "Email:";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(3, 210);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(77, 25);
            this.label7.TabIndex = 5;
            this.label7.Text = "Địa chỉ:";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(3, 252);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(159, 25);
            this.label8.TabIndex = 6;
            this.label8.Text = "Ngày vào làm(*):";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(3, 294);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(115, 25);
            this.label9.TabIndex = 7;
            this.label9.Text = "Mô tả thêm:";
            // 
            // txtHoTen
            // 
            this.txtHoTen.Dock = System.Windows.Forms.DockStyle.Fill;
            this.txtHoTen.Location = new System.Drawing.Point(178, 3);
            this.txtHoTen.Name = "txtHoTen";
            this.txtHoTen.Size = new System.Drawing.Size(244, 30);
            this.txtHoTen.TabIndex = 8;
            // 
            // txtEmail
            // 
            this.txtEmail.Dock = System.Windows.Forms.DockStyle.Fill;
            this.txtEmail.Location = new System.Drawing.Point(178, 171);
            this.txtEmail.Name = "txtEmail";
            this.txtEmail.Size = new System.Drawing.Size(244, 30);
            this.txtEmail.TabIndex = 11;
            // 
            // txtDiaChi
            // 
            this.txtDiaChi.Dock = System.Windows.Forms.DockStyle.Fill;
            this.txtDiaChi.Location = new System.Drawing.Point(178, 213);
            this.txtDiaChi.Name = "txtDiaChi";
            this.txtDiaChi.Size = new System.Drawing.Size(244, 30);
            this.txtDiaChi.TabIndex = 12;
            // 
            // txtMoTa
            // 
            this.txtMoTa.Dock = System.Windows.Forms.DockStyle.Fill;
            this.txtMoTa.Location = new System.Drawing.Point(178, 297);
            this.txtMoTa.Name = "txtMoTa";
            this.txtMoTa.Size = new System.Drawing.Size(244, 30);
            this.txtMoTa.TabIndex = 14;
            // 
            // txtDienThoai
            // 
            this.txtDienThoai.Dock = System.Windows.Forms.DockStyle.Fill;
            this.txtDienThoai.Location = new System.Drawing.Point(178, 129);
            this.txtDienThoai.Name = "txtDienThoai";
            this.txtDienThoai.Size = new System.Drawing.Size(244, 30);
            this.txtDienThoai.TabIndex = 15;
            // 
            // tlpSmallLeft
            // 
            this.tlpSmallLeft.ColumnCount = 2;
            this.tlpSmallLeft.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tlpSmallLeft.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tlpSmallLeft.Controls.Add(this.rdoNam, 0, 0);
            this.tlpSmallLeft.Controls.Add(this.rdoNu, 1, 0);
            this.tlpSmallLeft.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tlpSmallLeft.Location = new System.Drawing.Point(178, 87);
            this.tlpSmallLeft.Name = "tlpSmallLeft";
            this.tlpSmallLeft.RowCount = 1;
            this.tlpSmallLeft.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tlpSmallLeft.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tlpSmallLeft.Size = new System.Drawing.Size(244, 36);
            this.tlpSmallLeft.TabIndex = 16;
            // 
            // rdoNam
            // 
            this.rdoNam.AutoSize = true;
            this.rdoNam.Location = new System.Drawing.Point(3, 3);
            this.rdoNam.Name = "rdoNam";
            this.rdoNam.Size = new System.Drawing.Size(74, 29);
            this.rdoNam.TabIndex = 0;
            this.rdoNam.TabStop = true;
            this.rdoNam.Text = "Nam";
            this.rdoNam.UseVisualStyleBackColor = true;
            // 
            // rdoNu
            // 
            this.rdoNu.AutoSize = true;
            this.rdoNu.Location = new System.Drawing.Point(125, 3);
            this.rdoNu.Name = "rdoNu";
            this.rdoNu.Size = new System.Drawing.Size(58, 29);
            this.rdoNu.TabIndex = 1;
            this.rdoNu.TabStop = true;
            this.rdoNu.Text = "Nữ";
            this.rdoNu.UseVisualStyleBackColor = true;
            // 
            // dtpNgaySinh
            // 
            this.dtpNgaySinh.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dtpNgaySinh.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dtpNgaySinh.Location = new System.Drawing.Point(178, 45);
            this.dtpNgaySinh.Name = "dtpNgaySinh";
            this.dtpNgaySinh.Size = new System.Drawing.Size(244, 30);
            this.dtpNgaySinh.TabIndex = 17;
            // 
            // dtpNgayVaoLam
            // 
            this.dtpNgayVaoLam.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dtpNgayVaoLam.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dtpNgayVaoLam.Location = new System.Drawing.Point(178, 255);
            this.dtpNgayVaoLam.Name = "dtpNgayVaoLam";
            this.dtpNgayVaoLam.Size = new System.Drawing.Size(244, 30);
            this.dtpNgayVaoLam.TabIndex = 18;
            // 
            // tlpLeftBottom
            // 
            this.tlpLeftBottom.ColumnCount = 3;
            this.tlpLeftBottom.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 33F));
            this.tlpLeftBottom.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 33F));
            this.tlpLeftBottom.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 34F));
            this.tlpLeftBottom.Controls.Add(this.btnThemMoi, 0, 0);
            this.tlpLeftBottom.Controls.Add(this.btnSua, 1, 0);
            this.tlpLeftBottom.Controls.Add(this.btnXoa, 2, 0);
            this.tlpLeftBottom.Controls.Add(this.btnHuyGhi, 0, 1);
            this.tlpLeftBottom.Controls.Add(this.btnGhi, 1, 1);
            this.tlpLeftBottom.Controls.Add(this.btnKetThuc, 2, 1);
            this.tlpLeftBottom.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tlpLeftBottom.Location = new System.Drawing.Point(3, 470);
            this.tlpLeftBottom.Name = "tlpLeftBottom";
            this.tlpLeftBottom.RowCount = 2;
            this.tlpLeftBottom.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tlpLeftBottom.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tlpLeftBottom.Size = new System.Drawing.Size(425, 74);
            this.tlpLeftBottom.TabIndex = 1;
            // 
            // btnThemMoi
            // 
            this.btnThemMoi.Dock = System.Windows.Forms.DockStyle.Fill;
            this.btnThemMoi.Location = new System.Drawing.Point(3, 3);
            this.btnThemMoi.Name = "btnThemMoi";
            this.btnThemMoi.Size = new System.Drawing.Size(134, 31);
            this.btnThemMoi.TabIndex = 0;
            this.btnThemMoi.Text = "Thêm mới";
            this.btnThemMoi.UseVisualStyleBackColor = true;
            this.btnThemMoi.Click += new System.EventHandler(this.btnThemMoi_Click);
            // 
            // btnSua
            // 
            this.btnSua.Dock = System.Windows.Forms.DockStyle.Fill;
            this.btnSua.Location = new System.Drawing.Point(143, 3);
            this.btnSua.Name = "btnSua";
            this.btnSua.Size = new System.Drawing.Size(134, 31);
            this.btnSua.TabIndex = 1;
            this.btnSua.Text = "Sửa";
            this.btnSua.UseVisualStyleBackColor = true;
            this.btnSua.Click += new System.EventHandler(this.btnSua_Click);
            // 
            // btnXoa
            // 
            this.btnXoa.Dock = System.Windows.Forms.DockStyle.Fill;
            this.btnXoa.Location = new System.Drawing.Point(283, 3);
            this.btnXoa.Name = "btnXoa";
            this.btnXoa.Size = new System.Drawing.Size(139, 31);
            this.btnXoa.TabIndex = 2;
            this.btnXoa.Text = "Xóa";
            this.btnXoa.UseVisualStyleBackColor = true;
            this.btnXoa.Click += new System.EventHandler(this.btnXoa_Click);
            // 
            // btnHuyGhi
            // 
            this.btnHuyGhi.Dock = System.Windows.Forms.DockStyle.Fill;
            this.btnHuyGhi.Location = new System.Drawing.Point(3, 40);
            this.btnHuyGhi.Name = "btnHuyGhi";
            this.btnHuyGhi.Size = new System.Drawing.Size(134, 31);
            this.btnHuyGhi.TabIndex = 3;
            this.btnHuyGhi.Text = "Hủy";
            this.btnHuyGhi.UseVisualStyleBackColor = true;
            this.btnHuyGhi.Click += new System.EventHandler(this.btnHuyGhi_Click);
            // 
            // btnGhi
            // 
            this.btnGhi.Dock = System.Windows.Forms.DockStyle.Fill;
            this.btnGhi.Location = new System.Drawing.Point(143, 40);
            this.btnGhi.Name = "btnGhi";
            this.btnGhi.Size = new System.Drawing.Size(134, 31);
            this.btnGhi.TabIndex = 4;
            this.btnGhi.Text = "Ghi";
            this.btnGhi.UseVisualStyleBackColor = true;
            this.btnGhi.Click += new System.EventHandler(this.btnGhi_Click);
            // 
            // btnKetThuc
            // 
            this.btnKetThuc.Dock = System.Windows.Forms.DockStyle.Fill;
            this.btnKetThuc.Location = new System.Drawing.Point(283, 40);
            this.btnKetThuc.Name = "btnKetThuc";
            this.btnKetThuc.Size = new System.Drawing.Size(139, 31);
            this.btnKetThuc.TabIndex = 5;
            this.btnKetThuc.Text = "Kết thúc";
            this.btnKetThuc.UseVisualStyleBackColor = true;
            // 
            // tlpRightcontent
            // 
            this.tlpRightcontent.ColumnCount = 1;
            this.tlpRightcontent.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tlpRightcontent.Controls.Add(this.tlpRightHeader, 0, 0);
            this.tlpRightcontent.Controls.Add(this.dgvNhanVien, 0, 1);
            this.tlpRightcontent.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tlpRightcontent.Location = new System.Drawing.Point(440, 3);
            this.tlpRightcontent.Name = "tlpRightcontent";
            this.tlpRightcontent.RowCount = 2;
            this.tlpRightcontent.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 108F));
            this.tlpRightcontent.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tlpRightcontent.Size = new System.Drawing.Size(543, 547);
            this.tlpRightcontent.TabIndex = 1;
            // 
            // tlpRightHeader
            // 
            this.tlpRightHeader.ColumnCount = 2;
            this.tlpRightHeader.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 21.25237F));
            this.tlpRightHeader.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 78.74763F));
            this.tlpRightHeader.Controls.Add(this.pnlHeaderRight, 0, 0);
            this.tlpRightHeader.Controls.Add(this.tlpRightSearch, 1, 0);
            this.tlpRightHeader.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tlpRightHeader.Location = new System.Drawing.Point(3, 3);
            this.tlpRightHeader.Name = "tlpRightHeader";
            this.tlpRightHeader.RowCount = 1;
            this.tlpRightHeader.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tlpRightHeader.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tlpRightHeader.Size = new System.Drawing.Size(537, 102);
            this.tlpRightHeader.TabIndex = 0;
            // 
            // pnlHeaderRight
            // 
            this.pnlHeaderRight.Controls.Add(this.label10);
            this.pnlHeaderRight.Location = new System.Drawing.Point(3, 3);
            this.pnlHeaderRight.Name = "pnlHeaderRight";
            this.pnlHeaderRight.Size = new System.Drawing.Size(108, 96);
            this.pnlHeaderRight.TabIndex = 0;
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Location = new System.Drawing.Point(3, 21);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(97, 25);
            this.label10.TabIndex = 0;
            this.label10.Text = "Tìm kiếm:";
            // 
            // tlpRightSearch
            // 
            this.tlpRightSearch.ColumnCount = 1;
            this.tlpRightSearch.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tlpRightSearch.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tlpRightSearch.Controls.Add(this.txtTimKiem, 0, 1);
            this.tlpRightSearch.Controls.Add(this.tlpRadio, 0, 0);
            this.tlpRightSearch.Dock = System.Windows.Forms.DockStyle.Top;
            this.tlpRightSearch.Location = new System.Drawing.Point(117, 3);
            this.tlpRightSearch.Name = "tlpRightSearch";
            this.tlpRightSearch.RowCount = 2;
            this.tlpRightSearch.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tlpRightSearch.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tlpRightSearch.Size = new System.Drawing.Size(417, 96);
            this.tlpRightSearch.TabIndex = 1;
            // 
            // txtTimKiem
            // 
            this.txtTimKiem.Dock = System.Windows.Forms.DockStyle.Fill;
            this.txtTimKiem.Location = new System.Drawing.Point(3, 51);
            this.txtTimKiem.Name = "txtTimKiem";
            this.txtTimKiem.Size = new System.Drawing.Size(411, 30);
            this.txtTimKiem.TabIndex = 0;
            this.txtTimKiem.TextChanged += new System.EventHandler(this.txtTimKiem_TextChanged);
            // 
            // tlpRadio
            // 
            this.tlpRadio.ColumnCount = 2;
            this.tlpRadio.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tlpRadio.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tlpRadio.Controls.Add(this.rdoTimTheoTen, 0, 0);
            this.tlpRadio.Controls.Add(this.radioButton2, 1, 0);
            this.tlpRadio.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tlpRadio.Location = new System.Drawing.Point(3, 3);
            this.tlpRadio.Name = "tlpRadio";
            this.tlpRadio.RowCount = 1;
            this.tlpRadio.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tlpRadio.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tlpRadio.Size = new System.Drawing.Size(411, 42);
            this.tlpRadio.TabIndex = 1;
            // 
            // rdoTimTheoTen
            // 
            this.rdoTimTheoTen.AutoSize = true;
            this.rdoTimTheoTen.Location = new System.Drawing.Point(3, 3);
            this.rdoTimTheoTen.Name = "rdoTimTheoTen";
            this.rdoTimTheoTen.Size = new System.Drawing.Size(168, 29);
            this.rdoTimTheoTen.TabIndex = 0;
            this.rdoTimTheoTen.TabStop = true;
            this.rdoTimTheoTen.Text = "Tìm theo họ tên";
            this.rdoTimTheoTen.UseVisualStyleBackColor = true;
            // 
            // radioButton2
            // 
            this.radioButton2.AutoSize = true;
            this.radioButton2.Location = new System.Drawing.Point(208, 3);
            this.radioButton2.Name = "radioButton2";
            this.radioButton2.Size = new System.Drawing.Size(140, 29);
            this.radioButton2.TabIndex = 1;
            this.radioButton2.TabStop = true;
            this.radioButton2.Text = "Tìm theo sđt";
            this.radioButton2.UseVisualStyleBackColor = true;
            // 
            // dgvNhanVien
            // 
            this.dgvNhanVien.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvNhanVien.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dgvNhanVien.Location = new System.Drawing.Point(3, 111);
            this.dgvNhanVien.Name = "dgvNhanVien";
            this.dgvNhanVien.RowHeadersWidth = 51;
            this.dgvNhanVien.RowTemplate.Height = 24;
            this.dgvNhanVien.Size = new System.Drawing.Size(537, 433);
            this.dgvNhanVien.TabIndex = 1;
            this.dgvNhanVien.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvNhanVien_CellClick);
            this.dgvNhanVien.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvNhanVien_CellContentClick);
            // 
            // frmNhanVien
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(120F, 120F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Dpi;
            this.ClientSize = new System.Drawing.Size(992, 639);
            this.Controls.Add(this.tlpRoot);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.Name = "frmNhanVien";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "frmNhanVien";
            this.tlpRoot.ResumeLayout(false);
            this.pnlTitle.ResumeLayout(false);
            this.pnlTitle.PerformLayout();
            this.tlpContent.ResumeLayout(false);
            this.tlpLeftContent.ResumeLayout(false);
            this.tlpLeftHeader.ResumeLayout(false);
            this.tlpLeftHeader.PerformLayout();
            this.tlpSmallLeft.ResumeLayout(false);
            this.tlpSmallLeft.PerformLayout();
            this.tlpLeftBottom.ResumeLayout(false);
            this.tlpRightcontent.ResumeLayout(false);
            this.tlpRightHeader.ResumeLayout(false);
            this.pnlHeaderRight.ResumeLayout(false);
            this.pnlHeaderRight.PerformLayout();
            this.tlpRightSearch.ResumeLayout(false);
            this.tlpRightSearch.PerformLayout();
            this.tlpRadio.ResumeLayout(false);
            this.tlpRadio.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvNhanVien)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TableLayoutPanel tlpRoot;
        private System.Windows.Forms.Panel pnlTitle;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TableLayoutPanel tlpContent;
        private System.Windows.Forms.TableLayoutPanel tlpLeftContent;
        private System.Windows.Forms.TableLayoutPanel tlpRightcontent;
        private System.Windows.Forms.TableLayoutPanel tlpLeftHeader;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.TextBox txtHoTen;
        private System.Windows.Forms.TextBox txtEmail;
        private System.Windows.Forms.TextBox txtDiaChi;
        private System.Windows.Forms.TextBox txtMoTa;
        private System.Windows.Forms.TextBox txtDienThoai;
        private System.Windows.Forms.TableLayoutPanel tlpSmallLeft;
        private System.Windows.Forms.RadioButton rdoNam;
        private System.Windows.Forms.RadioButton rdoNu;
        private System.Windows.Forms.TableLayoutPanel tlpLeftBottom;
        private System.Windows.Forms.Button btnThemMoi;
        private System.Windows.Forms.Button btnSua;
        private System.Windows.Forms.Button btnXoa;
        private System.Windows.Forms.Button btnHuyGhi;
        private System.Windows.Forms.Button btnGhi;
        private System.Windows.Forms.Button btnKetThuc;
        private System.Windows.Forms.TableLayoutPanel tlpRightHeader;
        private System.Windows.Forms.Panel pnlHeaderRight;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.TableLayoutPanel tlpRightSearch;
        private System.Windows.Forms.TextBox txtTimKiem;
        private System.Windows.Forms.TableLayoutPanel tlpRadio;
        private System.Windows.Forms.RadioButton rdoTimTheoTen;
        private System.Windows.Forms.RadioButton radioButton2;
        private System.Windows.Forms.DataGridView dgvNhanVien;
        private System.Windows.Forms.DateTimePicker dtpNgaySinh;
        private System.Windows.Forms.DateTimePicker dtpNgayVaoLam;
    }
}