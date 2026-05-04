namespace QuanLyTiem
{
    partial class frmTaiKhoan
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
            this.lblTitle = new System.Windows.Forms.Label();
            this.tlpContent = new System.Windows.Forms.TableLayoutPanel();
            this.tlpLeft = new System.Windows.Forms.TableLayoutPanel();
            this.dtgvAccount = new System.Windows.Forms.DataGridView();
            this.tableLayoutPanel1 = new System.Windows.Forms.TableLayoutPanel();
            this.btnAddAccount = new System.Windows.Forms.Button();
            this.btnDeleteAccount = new System.Windows.Forms.Button();
            this.btnEditAccount = new System.Windows.Forms.Button();
            this.pnlContent = new System.Windows.Forms.Panel();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.txtDisplayName = new System.Windows.Forms.TextBox();
            this.nmAccountType = new System.Windows.Forms.NumericUpDown();
            this.txtUserName = new System.Windows.Forms.TextBox();
            this.btnResetPassword = new System.Windows.Forms.Button();
            this.btnRefresh = new System.Windows.Forms.Button();
            this.tlpRoot.SuspendLayout();
            this.pnlHeader.SuspendLayout();
            this.tlpContent.SuspendLayout();
            this.tlpLeft.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dtgvAccount)).BeginInit();
            this.tableLayoutPanel1.SuspendLayout();
            this.pnlContent.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.nmAccountType)).BeginInit();
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
            this.tlpRoot.Size = new System.Drawing.Size(672, 418);
            this.tlpRoot.TabIndex = 0;
            // 
            // pnlHeader
            // 
            this.pnlHeader.Controls.Add(this.lblTitle);
            this.pnlHeader.Dock = System.Windows.Forms.DockStyle.Fill;
            this.pnlHeader.Location = new System.Drawing.Point(3, 3);
            this.pnlHeader.Name = "pnlHeader";
            this.pnlHeader.Size = new System.Drawing.Size(666, 74);
            this.pnlHeader.TabIndex = 0;
            // 
            // lblTitle
            // 
            this.lblTitle.AutoSize = true;
            this.lblTitle.Location = new System.Drawing.Point(28, 26);
            this.lblTitle.Name = "lblTitle";
            this.lblTitle.Size = new System.Drawing.Size(172, 25);
            this.lblTitle.TabIndex = 0;
            this.lblTitle.Text = "Quản lý Tài khoản";
            // 
            // tlpContent
            // 
            this.tlpContent.ColumnCount = 2;
            this.tlpContent.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tlpContent.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tlpContent.Controls.Add(this.tlpLeft, 0, 0);
            this.tlpContent.Controls.Add(this.pnlContent, 1, 0);
            this.tlpContent.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tlpContent.Location = new System.Drawing.Point(3, 83);
            this.tlpContent.Name = "tlpContent";
            this.tlpContent.RowCount = 1;
            this.tlpContent.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tlpContent.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tlpContent.Size = new System.Drawing.Size(666, 332);
            this.tlpContent.TabIndex = 1;
            // 
            // tlpLeft
            // 
            this.tlpLeft.ColumnCount = 1;
            this.tlpLeft.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tlpLeft.Controls.Add(this.dtgvAccount, 0, 0);
            this.tlpLeft.Controls.Add(this.tableLayoutPanel1, 0, 1);
            this.tlpLeft.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tlpLeft.Location = new System.Drawing.Point(3, 3);
            this.tlpLeft.Name = "tlpLeft";
            this.tlpLeft.RowCount = 2;
            this.tlpLeft.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 80F));
            this.tlpLeft.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 20F));
            this.tlpLeft.Size = new System.Drawing.Size(327, 326);
            this.tlpLeft.TabIndex = 0;
            // 
            // dtgvAccount
            // 
            this.dtgvAccount.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dtgvAccount.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dtgvAccount.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dtgvAccount.Location = new System.Drawing.Point(3, 3);
            this.dtgvAccount.Name = "dtgvAccount";
            this.dtgvAccount.RowHeadersWidth = 51;
            this.dtgvAccount.RowTemplate.Height = 24;
            this.dtgvAccount.Size = new System.Drawing.Size(321, 254);
            this.dtgvAccount.TabIndex = 0;
            this.dtgvAccount.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dtgvAccount_CellClick);
            // 
            // tableLayoutPanel1
            // 
            this.tableLayoutPanel1.ColumnCount = 3;
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 33F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 33F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 34F));
            this.tableLayoutPanel1.Controls.Add(this.btnAddAccount, 0, 0);
            this.tableLayoutPanel1.Controls.Add(this.btnDeleteAccount, 1, 0);
            this.tableLayoutPanel1.Controls.Add(this.btnEditAccount, 2, 0);
            this.tableLayoutPanel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tableLayoutPanel1.Location = new System.Drawing.Point(3, 263);
            this.tableLayoutPanel1.Name = "tableLayoutPanel1";
            this.tableLayoutPanel1.RowCount = 1;
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableLayoutPanel1.Size = new System.Drawing.Size(321, 60);
            this.tableLayoutPanel1.TabIndex = 1;
            // 
            // btnAddAccount
            // 
            this.btnAddAccount.Location = new System.Drawing.Point(3, 3);
            this.btnAddAccount.Name = "btnAddAccount";
            this.btnAddAccount.Size = new System.Drawing.Size(99, 54);
            this.btnAddAccount.TabIndex = 0;
            this.btnAddAccount.Text = "Thêm";
            this.btnAddAccount.UseVisualStyleBackColor = true;
            this.btnAddAccount.Click += new System.EventHandler(this.btnAddAccount_Click);
            // 
            // btnDeleteAccount
            // 
            this.btnDeleteAccount.Location = new System.Drawing.Point(108, 3);
            this.btnDeleteAccount.Name = "btnDeleteAccount";
            this.btnDeleteAccount.Size = new System.Drawing.Size(99, 54);
            this.btnDeleteAccount.TabIndex = 1;
            this.btnDeleteAccount.Text = "Xóa";
            this.btnDeleteAccount.UseVisualStyleBackColor = true;
            this.btnDeleteAccount.Click += new System.EventHandler(this.btnDeleteAccount_Click);
            // 
            // btnEditAccount
            // 
            this.btnEditAccount.Location = new System.Drawing.Point(213, 3);
            this.btnEditAccount.Name = "btnEditAccount";
            this.btnEditAccount.Size = new System.Drawing.Size(105, 54);
            this.btnEditAccount.TabIndex = 2;
            this.btnEditAccount.Text = "Sửa";
            this.btnEditAccount.UseVisualStyleBackColor = true;
            this.btnEditAccount.Click += new System.EventHandler(this.btnEditAccount_Click);
            // 
            // pnlContent
            // 
            this.pnlContent.Controls.Add(this.btnRefresh);
            this.pnlContent.Controls.Add(this.btnResetPassword);
            this.pnlContent.Controls.Add(this.txtUserName);
            this.pnlContent.Controls.Add(this.nmAccountType);
            this.pnlContent.Controls.Add(this.txtDisplayName);
            this.pnlContent.Controls.Add(this.label3);
            this.pnlContent.Controls.Add(this.label2);
            this.pnlContent.Controls.Add(this.label1);
            this.pnlContent.Dock = System.Windows.Forms.DockStyle.Fill;
            this.pnlContent.Location = new System.Drawing.Point(336, 3);
            this.pnlContent.Name = "pnlContent";
            this.pnlContent.Size = new System.Drawing.Size(327, 326);
            this.pnlContent.TabIndex = 1;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(6, 45);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(137, 25);
            this.label1.TabIndex = 0;
            this.label1.Text = "Tên tài khoản:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(6, 112);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(120, 25);
            this.label2.TabIndex = 1;
            this.label2.Text = "Tên hiển thị:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(6, 182);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(139, 25);
            this.label3.TabIndex = 2;
            this.label3.Text = "Loại tài khoản:";
            // 
            // txtDisplayName
            // 
            this.txtDisplayName.Location = new System.Drawing.Point(149, 112);
            this.txtDisplayName.Name = "txtDisplayName";
            this.txtDisplayName.Size = new System.Drawing.Size(172, 30);
            this.txtDisplayName.TabIndex = 4;
            // 
            // nmAccountType
            // 
            this.nmAccountType.Location = new System.Drawing.Point(149, 177);
            this.nmAccountType.Name = "nmAccountType";
            this.nmAccountType.Size = new System.Drawing.Size(172, 30);
            this.nmAccountType.TabIndex = 5;
            // 
            // txtUserName
            // 
            this.txtUserName.Location = new System.Drawing.Point(149, 45);
            this.txtUserName.Name = "txtUserName";
            this.txtUserName.Size = new System.Drawing.Size(172, 30);
            this.txtUserName.TabIndex = 6;
            // 
            // btnResetPassword
            // 
            this.btnResetPassword.Location = new System.Drawing.Point(11, 274);
            this.btnResetPassword.Name = "btnResetPassword";
            this.btnResetPassword.Size = new System.Drawing.Size(170, 39);
            this.btnResetPassword.TabIndex = 7;
            this.btnResetPassword.Text = "Đặt lại mật khẩu";
            this.btnResetPassword.UseVisualStyleBackColor = true;
            this.btnResetPassword.Click += new System.EventHandler(this.btnResetPassword_Click);
            // 
            // btnRefresh
            // 
            this.btnRefresh.Location = new System.Drawing.Point(205, 274);
            this.btnRefresh.Name = "btnRefresh";
            this.btnRefresh.Size = new System.Drawing.Size(103, 39);
            this.btnRefresh.TabIndex = 8;
            this.btnRefresh.Text = "Làm mới";
            this.btnRefresh.UseVisualStyleBackColor = true;
            this.btnRefresh.Click += new System.EventHandler(this.btnRefresh_Click);
            // 
            // frmTaiKhoan
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(120F, 120F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Dpi;
            this.ClientSize = new System.Drawing.Size(672, 418);
            this.Controls.Add(this.tlpRoot);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.Name = "frmTaiKhoan";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "frmTaiKhoan";
            this.tlpRoot.ResumeLayout(false);
            this.pnlHeader.ResumeLayout(false);
            this.pnlHeader.PerformLayout();
            this.tlpContent.ResumeLayout(false);
            this.tlpLeft.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dtgvAccount)).EndInit();
            this.tableLayoutPanel1.ResumeLayout(false);
            this.pnlContent.ResumeLayout(false);
            this.pnlContent.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.nmAccountType)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TableLayoutPanel tlpRoot;
        private System.Windows.Forms.Panel pnlHeader;
        private System.Windows.Forms.Label lblTitle;
        private System.Windows.Forms.TableLayoutPanel tlpContent;
        private System.Windows.Forms.TableLayoutPanel tlpLeft;
        private System.Windows.Forms.DataGridView dtgvAccount;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel1;
        private System.Windows.Forms.Button btnAddAccount;
        private System.Windows.Forms.Button btnDeleteAccount;
        private System.Windows.Forms.Button btnEditAccount;
        private System.Windows.Forms.Panel pnlContent;
        private System.Windows.Forms.NumericUpDown nmAccountType;
        private System.Windows.Forms.TextBox txtDisplayName;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txtUserName;
        private System.Windows.Forms.Button btnResetPassword;
        private System.Windows.Forms.Button btnRefresh;
    }
}