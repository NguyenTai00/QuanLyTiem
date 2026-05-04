namespace QuanLyTiem
{
    partial class frmNhaCungCap
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
            this.tlpLeftTop = new System.Windows.Forms.TableLayoutPanel();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.txtTenNCC = new System.Windows.Forms.TextBox();
            this.txtDiaChi = new System.Windows.Forms.TextBox();
            this.txtDienThoai = new System.Windows.Forms.TextBox();
            this.txtEmail = new System.Windows.Forms.TextBox();
            this.tlpLeftBottom = new System.Windows.Forms.TableLayoutPanel();
            this.btnThemMoi = new System.Windows.Forms.Button();
            this.btnSua = new System.Windows.Forms.Button();
            this.btnXoa = new System.Windows.Forms.Button();
            this.btnGhi = new System.Windows.Forms.Button();
            this.btnHuyGhi = new System.Windows.Forms.Button();
            this.btnKetThuc = new System.Windows.Forms.Button();
            this.tlpRightContent = new System.Windows.Forms.TableLayoutPanel();
            this.tlpSearch = new System.Windows.Forms.TableLayoutPanel();
            this.tlpSearchRight = new System.Windows.Forms.TableLayoutPanel();
            this.tlpRadion = new System.Windows.Forms.TableLayoutPanel();
            this.rdoTenNCC = new System.Windows.Forms.RadioButton();
            this.rdoSDT = new System.Windows.Forms.RadioButton();
            this.txtTimKiem = new System.Windows.Forms.TextBox();
            this.pnlSearch = new System.Windows.Forms.Panel();
            this.label6 = new System.Windows.Forms.Label();
            this.dgvNCC = new System.Windows.Forms.DataGridView();
            this.tlpRoot.SuspendLayout();
            this.pnlTitle.SuspendLayout();
            this.tlpContent.SuspendLayout();
            this.tlpLeftContent.SuspendLayout();
            this.tlpLeftTop.SuspendLayout();
            this.tlpLeftBottom.SuspendLayout();
            this.tlpRightContent.SuspendLayout();
            this.tlpSearch.SuspendLayout();
            this.tlpSearchRight.SuspendLayout();
            this.tlpRadion.SuspendLayout();
            this.pnlSearch.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvNCC)).BeginInit();
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
            this.tlpRoot.Size = new System.Drawing.Size(1013, 586);
            this.tlpRoot.TabIndex = 0;
            // 
            // pnlTitle
            // 
            this.pnlTitle.Controls.Add(this.label1);
            this.pnlTitle.Dock = System.Windows.Forms.DockStyle.Fill;
            this.pnlTitle.Location = new System.Drawing.Point(3, 3);
            this.pnlTitle.Name = "pnlTitle";
            this.pnlTitle.Size = new System.Drawing.Size(1007, 74);
            this.pnlTitle.TabIndex = 0;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(9, 23);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(203, 25);
            this.label1.TabIndex = 0;
            this.label1.Text = "Quản lý nhà cung cấp";
            // 
            // tlpContent
            // 
            this.tlpContent.ColumnCount = 2;
            this.tlpContent.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 42.8004F));
            this.tlpContent.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 57.1996F));
            this.tlpContent.Controls.Add(this.tlpLeftContent, 0, 0);
            this.tlpContent.Controls.Add(this.tlpRightContent, 1, 0);
            this.tlpContent.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tlpContent.Location = new System.Drawing.Point(3, 83);
            this.tlpContent.Name = "tlpContent";
            this.tlpContent.RowCount = 1;
            this.tlpContent.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tlpContent.Size = new System.Drawing.Size(1007, 500);
            this.tlpContent.TabIndex = 1;
            // 
            // tlpLeftContent
            // 
            this.tlpLeftContent.ColumnCount = 1;
            this.tlpLeftContent.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tlpLeftContent.Controls.Add(this.tlpLeftTop, 0, 0);
            this.tlpLeftContent.Controls.Add(this.tlpLeftBottom, 0, 1);
            this.tlpLeftContent.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tlpLeftContent.Location = new System.Drawing.Point(3, 3);
            this.tlpLeftContent.Name = "tlpLeftContent";
            this.tlpLeftContent.RowCount = 2;
            this.tlpLeftContent.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tlpLeftContent.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 80F));
            this.tlpLeftContent.Size = new System.Drawing.Size(425, 494);
            this.tlpLeftContent.TabIndex = 0;
            // 
            // tlpLeftTop
            // 
            this.tlpLeftTop.ColumnCount = 2;
            this.tlpLeftTop.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 30.46218F));
            this.tlpLeftTop.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 69.53782F));
            this.tlpLeftTop.Controls.Add(this.label2, 0, 0);
            this.tlpLeftTop.Controls.Add(this.label3, 0, 1);
            this.tlpLeftTop.Controls.Add(this.label4, 0, 2);
            this.tlpLeftTop.Controls.Add(this.label5, 0, 3);
            this.tlpLeftTop.Controls.Add(this.txtTenNCC, 1, 0);
            this.tlpLeftTop.Controls.Add(this.txtDiaChi, 1, 1);
            this.tlpLeftTop.Controls.Add(this.txtDienThoai, 1, 2);
            this.tlpLeftTop.Controls.Add(this.txtEmail, 1, 3);
            this.tlpLeftTop.Dock = System.Windows.Forms.DockStyle.Top;
            this.tlpLeftTop.Location = new System.Drawing.Point(3, 3);
            this.tlpLeftTop.Name = "tlpLeftTop";
            this.tlpLeftTop.RowCount = 4;
            this.tlpLeftTop.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 25F));
            this.tlpLeftTop.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 25F));
            this.tlpLeftTop.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 25F));
            this.tlpLeftTop.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 25F));
            this.tlpLeftTop.Size = new System.Drawing.Size(419, 258);
            this.tlpLeftTop.TabIndex = 0;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(3, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(120, 50);
            this.label2.TabIndex = 0;
            this.label2.Text = "Tên nhà cung cấp(*):";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(3, 64);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(104, 25);
            this.label3.TabIndex = 1;
            this.label3.Text = "Địa chỉ (*):";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(3, 128);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(104, 50);
            this.label4.TabIndex = 2;
            this.label4.Text = "Điện thoại (*):";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(3, 192);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(66, 25);
            this.label5.TabIndex = 3;
            this.label5.Text = "Email:";
            // 
            // txtTenNCC
            // 
            this.txtTenNCC.Dock = System.Windows.Forms.DockStyle.Fill;
            this.txtTenNCC.Location = new System.Drawing.Point(130, 3);
            this.txtTenNCC.Name = "txtTenNCC";
            this.txtTenNCC.Size = new System.Drawing.Size(286, 30);
            this.txtTenNCC.TabIndex = 4;
            // 
            // txtDiaChi
            // 
            this.txtDiaChi.Dock = System.Windows.Forms.DockStyle.Fill;
            this.txtDiaChi.Location = new System.Drawing.Point(130, 67);
            this.txtDiaChi.Name = "txtDiaChi";
            this.txtDiaChi.Size = new System.Drawing.Size(286, 30);
            this.txtDiaChi.TabIndex = 5;
            // 
            // txtDienThoai
            // 
            this.txtDienThoai.Dock = System.Windows.Forms.DockStyle.Fill;
            this.txtDienThoai.Location = new System.Drawing.Point(130, 131);
            this.txtDienThoai.Name = "txtDienThoai";
            this.txtDienThoai.Size = new System.Drawing.Size(286, 30);
            this.txtDienThoai.TabIndex = 6;
            // 
            // txtEmail
            // 
            this.txtEmail.Dock = System.Windows.Forms.DockStyle.Fill;
            this.txtEmail.Location = new System.Drawing.Point(130, 195);
            this.txtEmail.Name = "txtEmail";
            this.txtEmail.Size = new System.Drawing.Size(286, 30);
            this.txtEmail.TabIndex = 7;
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
            this.tlpLeftBottom.Controls.Add(this.btnGhi, 0, 1);
            this.tlpLeftBottom.Controls.Add(this.btnHuyGhi, 1, 1);
            this.tlpLeftBottom.Controls.Add(this.btnKetThuc, 2, 1);
            this.tlpLeftBottom.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tlpLeftBottom.Location = new System.Drawing.Point(3, 417);
            this.tlpLeftBottom.Name = "tlpLeftBottom";
            this.tlpLeftBottom.RowCount = 2;
            this.tlpLeftBottom.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tlpLeftBottom.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tlpLeftBottom.Size = new System.Drawing.Size(419, 74);
            this.tlpLeftBottom.TabIndex = 1;
            // 
            // btnThemMoi
            // 
            this.btnThemMoi.Dock = System.Windows.Forms.DockStyle.Fill;
            this.btnThemMoi.Location = new System.Drawing.Point(3, 3);
            this.btnThemMoi.Name = "btnThemMoi";
            this.btnThemMoi.Size = new System.Drawing.Size(132, 31);
            this.btnThemMoi.TabIndex = 0;
            this.btnThemMoi.Text = "Thêm mới";
            this.btnThemMoi.UseVisualStyleBackColor = true;
            this.btnThemMoi.Click += new System.EventHandler(this.btnThemMoi_Click);
            // 
            // btnSua
            // 
            this.btnSua.Dock = System.Windows.Forms.DockStyle.Fill;
            this.btnSua.Location = new System.Drawing.Point(141, 3);
            this.btnSua.Name = "btnSua";
            this.btnSua.Size = new System.Drawing.Size(132, 31);
            this.btnSua.TabIndex = 1;
            this.btnSua.Text = "Sửa";
            this.btnSua.UseVisualStyleBackColor = true;
            this.btnSua.Click += new System.EventHandler(this.btnSua_Click);
            // 
            // btnXoa
            // 
            this.btnXoa.Dock = System.Windows.Forms.DockStyle.Fill;
            this.btnXoa.Location = new System.Drawing.Point(279, 3);
            this.btnXoa.Name = "btnXoa";
            this.btnXoa.Size = new System.Drawing.Size(137, 31);
            this.btnXoa.TabIndex = 2;
            this.btnXoa.Text = "Xóa";
            this.btnXoa.UseVisualStyleBackColor = true;
            this.btnXoa.Click += new System.EventHandler(this.btnXoa_Click);
            // 
            // btnGhi
            // 
            this.btnGhi.Dock = System.Windows.Forms.DockStyle.Fill;
            this.btnGhi.Location = new System.Drawing.Point(3, 40);
            this.btnGhi.Name = "btnGhi";
            this.btnGhi.Size = new System.Drawing.Size(132, 31);
            this.btnGhi.TabIndex = 3;
            this.btnGhi.Text = "Ghi";
            this.btnGhi.UseVisualStyleBackColor = true;
            this.btnGhi.Click += new System.EventHandler(this.btnGhi_Click);
            // 
            // btnHuyGhi
            // 
            this.btnHuyGhi.Dock = System.Windows.Forms.DockStyle.Fill;
            this.btnHuyGhi.Location = new System.Drawing.Point(141, 40);
            this.btnHuyGhi.Name = "btnHuyGhi";
            this.btnHuyGhi.Size = new System.Drawing.Size(132, 31);
            this.btnHuyGhi.TabIndex = 4;
            this.btnHuyGhi.Text = "Hủy Ghi";
            this.btnHuyGhi.UseVisualStyleBackColor = true;
            this.btnHuyGhi.Click += new System.EventHandler(this.btnHuyGhi_Click);
            // 
            // btnKetThuc
            // 
            this.btnKetThuc.Dock = System.Windows.Forms.DockStyle.Fill;
            this.btnKetThuc.Location = new System.Drawing.Point(279, 40);
            this.btnKetThuc.Name = "btnKetThuc";
            this.btnKetThuc.Size = new System.Drawing.Size(137, 31);
            this.btnKetThuc.TabIndex = 5;
            this.btnKetThuc.Text = "Kết thúc";
            this.btnKetThuc.UseVisualStyleBackColor = true;
            this.btnKetThuc.Click += new System.EventHandler(this.btnKetThuc_Click);
            // 
            // tlpRightContent
            // 
            this.tlpRightContent.ColumnCount = 1;
            this.tlpRightContent.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tlpRightContent.Controls.Add(this.tlpSearch, 0, 0);
            this.tlpRightContent.Controls.Add(this.dgvNCC, 0, 1);
            this.tlpRightContent.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tlpRightContent.Location = new System.Drawing.Point(434, 3);
            this.tlpRightContent.Name = "tlpRightContent";
            this.tlpRightContent.RowCount = 2;
            this.tlpRightContent.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 104F));
            this.tlpRightContent.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tlpRightContent.Size = new System.Drawing.Size(570, 494);
            this.tlpRightContent.TabIndex = 1;
            // 
            // tlpSearch
            // 
            this.tlpSearch.ColumnCount = 2;
            this.tlpSearch.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 23.22695F));
            this.tlpSearch.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 76.77305F));
            this.tlpSearch.Controls.Add(this.tlpSearchRight, 1, 0);
            this.tlpSearch.Controls.Add(this.pnlSearch, 0, 0);
            this.tlpSearch.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tlpSearch.Location = new System.Drawing.Point(3, 3);
            this.tlpSearch.Name = "tlpSearch";
            this.tlpSearch.RowCount = 1;
            this.tlpSearch.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tlpSearch.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tlpSearch.Size = new System.Drawing.Size(564, 98);
            this.tlpSearch.TabIndex = 0;
            // 
            // tlpSearchRight
            // 
            this.tlpSearchRight.ColumnCount = 1;
            this.tlpSearchRight.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tlpSearchRight.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tlpSearchRight.Controls.Add(this.tlpRadion, 0, 0);
            this.tlpSearchRight.Controls.Add(this.txtTimKiem, 0, 1);
            this.tlpSearchRight.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tlpSearchRight.Location = new System.Drawing.Point(134, 3);
            this.tlpSearchRight.Name = "tlpSearchRight";
            this.tlpSearchRight.RowCount = 2;
            this.tlpSearchRight.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tlpSearchRight.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tlpSearchRight.Size = new System.Drawing.Size(427, 92);
            this.tlpSearchRight.TabIndex = 0;
            // 
            // tlpRadion
            // 
            this.tlpRadion.ColumnCount = 2;
            this.tlpRadion.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tlpRadion.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tlpRadion.Controls.Add(this.rdoTenNCC, 0, 0);
            this.tlpRadion.Controls.Add(this.rdoSDT, 1, 0);
            this.tlpRadion.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tlpRadion.Location = new System.Drawing.Point(3, 3);
            this.tlpRadion.Name = "tlpRadion";
            this.tlpRadion.RowCount = 1;
            this.tlpRadion.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tlpRadion.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tlpRadion.Size = new System.Drawing.Size(421, 40);
            this.tlpRadion.TabIndex = 0;
            // 
            // rdoTenNCC
            // 
            this.rdoTenNCC.AutoSize = true;
            this.rdoTenNCC.Location = new System.Drawing.Point(3, 3);
            this.rdoTenNCC.Name = "rdoTenNCC";
            this.rdoTenNCC.Size = new System.Drawing.Size(98, 29);
            this.rdoTenNCC.TabIndex = 0;
            this.rdoTenNCC.TabStop = true;
            this.rdoTenNCC.Text = "Họ Tên";
            this.rdoTenNCC.UseVisualStyleBackColor = true;
            // 
            // rdoSDT
            // 
            this.rdoSDT.AutoSize = true;
            this.rdoSDT.Location = new System.Drawing.Point(213, 3);
            this.rdoSDT.Name = "rdoSDT";
            this.rdoSDT.Size = new System.Drawing.Size(74, 29);
            this.rdoSDT.TabIndex = 1;
            this.rdoSDT.TabStop = true;
            this.rdoSDT.Text = "SĐT";
            this.rdoSDT.UseVisualStyleBackColor = true;
            // 
            // txtTimKiem
            // 
            this.txtTimKiem.Dock = System.Windows.Forms.DockStyle.Fill;
            this.txtTimKiem.Location = new System.Drawing.Point(3, 49);
            this.txtTimKiem.Name = "txtTimKiem";
            this.txtTimKiem.Size = new System.Drawing.Size(421, 30);
            this.txtTimKiem.TabIndex = 1;
            this.txtTimKiem.TextChanged += new System.EventHandler(this.txtTimKiem_TextChanged);
            // 
            // pnlSearch
            // 
            this.pnlSearch.Controls.Add(this.label6);
            this.pnlSearch.Location = new System.Drawing.Point(3, 3);
            this.pnlSearch.Name = "pnlSearch";
            this.pnlSearch.Size = new System.Drawing.Size(125, 92);
            this.pnlSearch.TabIndex = 1;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(3, 22);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(97, 25);
            this.label6.TabIndex = 0;
            this.label6.Text = "Tìm kiếm:";
            // 
            // dgvNCC
            // 
            this.dgvNCC.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgvNCC.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvNCC.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dgvNCC.Location = new System.Drawing.Point(3, 107);
            this.dgvNCC.Name = "dgvNCC";
            this.dgvNCC.RowHeadersWidth = 51;
            this.dgvNCC.RowTemplate.Height = 24;
            this.dgvNCC.Size = new System.Drawing.Size(564, 384);
            this.dgvNCC.TabIndex = 1;
            this.dgvNCC.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvNCC_CellClick);
            // 
            // frmNhaCungCap
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(120F, 120F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Dpi;
            this.ClientSize = new System.Drawing.Size(1013, 586);
            this.Controls.Add(this.tlpRoot);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.Name = "frmNhaCungCap";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "frmNhaCungCap";
            this.tlpRoot.ResumeLayout(false);
            this.pnlTitle.ResumeLayout(false);
            this.pnlTitle.PerformLayout();
            this.tlpContent.ResumeLayout(false);
            this.tlpLeftContent.ResumeLayout(false);
            this.tlpLeftTop.ResumeLayout(false);
            this.tlpLeftTop.PerformLayout();
            this.tlpLeftBottom.ResumeLayout(false);
            this.tlpRightContent.ResumeLayout(false);
            this.tlpSearch.ResumeLayout(false);
            this.tlpSearchRight.ResumeLayout(false);
            this.tlpSearchRight.PerformLayout();
            this.tlpRadion.ResumeLayout(false);
            this.tlpRadion.PerformLayout();
            this.pnlSearch.ResumeLayout(false);
            this.pnlSearch.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvNCC)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TableLayoutPanel tlpRoot;
        private System.Windows.Forms.Panel pnlTitle;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TableLayoutPanel tlpContent;
        private System.Windows.Forms.TableLayoutPanel tlpLeftContent;
        private System.Windows.Forms.TableLayoutPanel tlpRightContent;
        private System.Windows.Forms.TableLayoutPanel tlpLeftTop;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox txtTenNCC;
        private System.Windows.Forms.TextBox txtDiaChi;
        private System.Windows.Forms.TextBox txtDienThoai;
        private System.Windows.Forms.TextBox txtEmail;
        private System.Windows.Forms.TableLayoutPanel tlpLeftBottom;
        private System.Windows.Forms.Button btnThemMoi;
        private System.Windows.Forms.Button btnSua;
        private System.Windows.Forms.Button btnXoa;
        private System.Windows.Forms.Button btnGhi;
        private System.Windows.Forms.Button btnHuyGhi;
        private System.Windows.Forms.Button btnKetThuc;
        private System.Windows.Forms.TableLayoutPanel tlpSearch;
        private System.Windows.Forms.TableLayoutPanel tlpSearchRight;
        private System.Windows.Forms.TableLayoutPanel tlpRadion;
        private System.Windows.Forms.RadioButton rdoTenNCC;
        private System.Windows.Forms.RadioButton rdoSDT;
        private System.Windows.Forms.TextBox txtTimKiem;
        private System.Windows.Forms.Panel pnlSearch;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.DataGridView dgvNCC;
    }
}