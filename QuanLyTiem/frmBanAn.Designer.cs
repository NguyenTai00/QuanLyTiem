namespace QuanLyTiem
{
    partial class frmBanAn
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
            this.tlpleftContent = new System.Windows.Forms.TableLayoutPanel();
            this.dtgvTable = new System.Windows.Forms.DataGridView();
            this.pnlBottomleft = new System.Windows.Forms.Panel();
            this.btnAddTable = new System.Windows.Forms.Button();
            this.tlpRightContent = new System.Windows.Forms.TableLayoutPanel();
            this.tlpRightTop = new System.Windows.Forms.TableLayoutPanel();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.txtTableID = new System.Windows.Forms.TextBox();
            this.txtTableName = new System.Windows.Forms.TextBox();
            this.txtTableStatus = new System.Windows.Forms.TextBox();
            this.pnlBottomRight = new System.Windows.Forms.Panel();
            this.btnDeleteTable = new System.Windows.Forms.Button();
            this.btnEditTable = new System.Windows.Forms.Button();
            this.tlpRoot.SuspendLayout();
            this.pnlTitle.SuspendLayout();
            this.tlpContent.SuspendLayout();
            this.tlpleftContent.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dtgvTable)).BeginInit();
            this.pnlBottomleft.SuspendLayout();
            this.tlpRightContent.SuspendLayout();
            this.tlpRightTop.SuspendLayout();
            this.pnlBottomRight.SuspendLayout();
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
            this.tlpRoot.Size = new System.Drawing.Size(854, 512);
            this.tlpRoot.TabIndex = 0;
            // 
            // pnlTitle
            // 
            this.pnlTitle.Controls.Add(this.label1);
            this.pnlTitle.Dock = System.Windows.Forms.DockStyle.Fill;
            this.pnlTitle.Location = new System.Drawing.Point(3, 3);
            this.pnlTitle.Name = "pnlTitle";
            this.pnlTitle.Size = new System.Drawing.Size(848, 74);
            this.pnlTitle.TabIndex = 0;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(19, 24);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(145, 25);
            this.label1.TabIndex = 0;
            this.label1.Text = "Quản lý bàn ăn";
            // 
            // tlpContent
            // 
            this.tlpContent.ColumnCount = 2;
            this.tlpContent.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tlpContent.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tlpContent.Controls.Add(this.tlpleftContent, 0, 0);
            this.tlpContent.Controls.Add(this.tlpRightContent, 1, 0);
            this.tlpContent.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tlpContent.Location = new System.Drawing.Point(3, 83);
            this.tlpContent.Name = "tlpContent";
            this.tlpContent.RowCount = 1;
            this.tlpContent.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tlpContent.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tlpContent.Size = new System.Drawing.Size(848, 426);
            this.tlpContent.TabIndex = 1;
            // 
            // tlpleftContent
            // 
            this.tlpleftContent.ColumnCount = 1;
            this.tlpleftContent.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tlpleftContent.Controls.Add(this.dtgvTable, 0, 0);
            this.tlpleftContent.Controls.Add(this.pnlBottomleft, 0, 1);
            this.tlpleftContent.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tlpleftContent.Location = new System.Drawing.Point(3, 3);
            this.tlpleftContent.Name = "tlpleftContent";
            this.tlpleftContent.RowCount = 2;
            this.tlpleftContent.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tlpleftContent.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 80F));
            this.tlpleftContent.Size = new System.Drawing.Size(418, 420);
            this.tlpleftContent.TabIndex = 0;
            // 
            // dtgvTable
            // 
            this.dtgvTable.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dtgvTable.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dtgvTable.Location = new System.Drawing.Point(3, 3);
            this.dtgvTable.Name = "dtgvTable";
            this.dtgvTable.RowHeadersWidth = 51;
            this.dtgvTable.RowTemplate.Height = 24;
            this.dtgvTable.Size = new System.Drawing.Size(412, 334);
            this.dtgvTable.TabIndex = 0;
            // 
            // pnlBottomleft
            // 
            this.pnlBottomleft.Controls.Add(this.btnAddTable);
            this.pnlBottomleft.Dock = System.Windows.Forms.DockStyle.Fill;
            this.pnlBottomleft.Location = new System.Drawing.Point(3, 343);
            this.pnlBottomleft.Name = "pnlBottomleft";
            this.pnlBottomleft.Size = new System.Drawing.Size(412, 74);
            this.pnlBottomleft.TabIndex = 1;
            // 
            // btnAddTable
            // 
            this.btnAddTable.Location = new System.Drawing.Point(110, 13);
            this.btnAddTable.Name = "btnAddTable";
            this.btnAddTable.Size = new System.Drawing.Size(102, 45);
            this.btnAddTable.TabIndex = 0;
            this.btnAddTable.Text = "Thêm";
            this.btnAddTable.UseVisualStyleBackColor = true;
            this.btnAddTable.Click += new System.EventHandler(this.btnAddTable_Click);
            // 
            // tlpRightContent
            // 
            this.tlpRightContent.ColumnCount = 1;
            this.tlpRightContent.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tlpRightContent.Controls.Add(this.tlpRightTop, 0, 0);
            this.tlpRightContent.Controls.Add(this.pnlBottomRight, 0, 1);
            this.tlpRightContent.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tlpRightContent.Location = new System.Drawing.Point(427, 3);
            this.tlpRightContent.Name = "tlpRightContent";
            this.tlpRightContent.RowCount = 2;
            this.tlpRightContent.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tlpRightContent.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 80F));
            this.tlpRightContent.Size = new System.Drawing.Size(418, 420);
            this.tlpRightContent.TabIndex = 1;
            // 
            // tlpRightTop
            // 
            this.tlpRightTop.ColumnCount = 2;
            this.tlpRightTop.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 28.15534F));
            this.tlpRightTop.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 71.84466F));
            this.tlpRightTop.Controls.Add(this.label2, 0, 0);
            this.tlpRightTop.Controls.Add(this.label3, 0, 1);
            this.tlpRightTop.Controls.Add(this.label4, 0, 2);
            this.tlpRightTop.Controls.Add(this.txtTableID, 1, 0);
            this.tlpRightTop.Controls.Add(this.txtTableName, 1, 1);
            this.tlpRightTop.Controls.Add(this.txtTableStatus, 1, 2);
            this.tlpRightTop.Dock = System.Windows.Forms.DockStyle.Top;
            this.tlpRightTop.Location = new System.Drawing.Point(3, 3);
            this.tlpRightTop.Name = "tlpRightTop";
            this.tlpRightTop.RowCount = 3;
            this.tlpRightTop.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 33F));
            this.tlpRightTop.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 33F));
            this.tlpRightTop.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 34F));
            this.tlpRightTop.Size = new System.Drawing.Size(412, 100);
            this.tlpRightTop.TabIndex = 0;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(3, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(36, 25);
            this.label2.TabIndex = 0;
            this.label2.Text = "iD:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(3, 33);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(91, 25);
            this.label3.TabIndex = 1;
            this.label3.Text = "Tên bàn:";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(3, 66);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(106, 25);
            this.label4.TabIndex = 2;
            this.label4.Text = "Trạng thái:";
            // 
            // txtTableID
            // 
            this.txtTableID.Dock = System.Windows.Forms.DockStyle.Fill;
            this.txtTableID.Location = new System.Drawing.Point(119, 3);
            this.txtTableID.Name = "txtTableID";
            this.txtTableID.ReadOnly = true;
            this.txtTableID.Size = new System.Drawing.Size(290, 30);
            this.txtTableID.TabIndex = 3;
            // 
            // txtTableName
            // 
            this.txtTableName.Dock = System.Windows.Forms.DockStyle.Fill;
            this.txtTableName.Location = new System.Drawing.Point(119, 36);
            this.txtTableName.Name = "txtTableName";
            this.txtTableName.Size = new System.Drawing.Size(290, 30);
            this.txtTableName.TabIndex = 4;
            // 
            // txtTableStatus
            // 
            this.txtTableStatus.Dock = System.Windows.Forms.DockStyle.Fill;
            this.txtTableStatus.Location = new System.Drawing.Point(119, 69);
            this.txtTableStatus.Name = "txtTableStatus";
            this.txtTableStatus.ReadOnly = true;
            this.txtTableStatus.Size = new System.Drawing.Size(290, 30);
            this.txtTableStatus.TabIndex = 5;
            // 
            // pnlBottomRight
            // 
            this.pnlBottomRight.Controls.Add(this.btnDeleteTable);
            this.pnlBottomRight.Controls.Add(this.btnEditTable);
            this.pnlBottomRight.Dock = System.Windows.Forms.DockStyle.Fill;
            this.pnlBottomRight.Location = new System.Drawing.Point(3, 343);
            this.pnlBottomRight.Name = "pnlBottomRight";
            this.pnlBottomRight.Size = new System.Drawing.Size(412, 74);
            this.pnlBottomRight.TabIndex = 1;
            // 
            // btnDeleteTable
            // 
            this.btnDeleteTable.Location = new System.Drawing.Point(277, 13);
            this.btnDeleteTable.Name = "btnDeleteTable";
            this.btnDeleteTable.Size = new System.Drawing.Size(75, 45);
            this.btnDeleteTable.TabIndex = 1;
            this.btnDeleteTable.Text = "Xóa";
            this.btnDeleteTable.UseVisualStyleBackColor = true;
            this.btnDeleteTable.Click += new System.EventHandler(this.btnDeleteTable_Click);
            // 
            // btnEditTable
            // 
            this.btnEditTable.Location = new System.Drawing.Point(68, 13);
            this.btnEditTable.Name = "btnEditTable";
            this.btnEditTable.Size = new System.Drawing.Size(75, 45);
            this.btnEditTable.TabIndex = 0;
            this.btnEditTable.Text = "Sửa ";
            this.btnEditTable.UseVisualStyleBackColor = true;
            this.btnEditTable.Click += new System.EventHandler(this.btnEditTable_Click);
            // 
            // frmBanAn
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(120F, 120F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Dpi;
            this.ClientSize = new System.Drawing.Size(854, 512);
            this.Controls.Add(this.tlpRoot);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.Name = "frmBanAn";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "frmBanAn";
            this.tlpRoot.ResumeLayout(false);
            this.pnlTitle.ResumeLayout(false);
            this.pnlTitle.PerformLayout();
            this.tlpContent.ResumeLayout(false);
            this.tlpleftContent.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dtgvTable)).EndInit();
            this.pnlBottomleft.ResumeLayout(false);
            this.tlpRightContent.ResumeLayout(false);
            this.tlpRightTop.ResumeLayout(false);
            this.tlpRightTop.PerformLayout();
            this.pnlBottomRight.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TableLayoutPanel tlpRoot;
        private System.Windows.Forms.Panel pnlTitle;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TableLayoutPanel tlpContent;
        private System.Windows.Forms.TableLayoutPanel tlpleftContent;
        private System.Windows.Forms.DataGridView dtgvTable;
        private System.Windows.Forms.Panel pnlBottomleft;
        private System.Windows.Forms.TableLayoutPanel tlpRightContent;
        private System.Windows.Forms.TableLayoutPanel tlpRightTop;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox txtTableID;
        private System.Windows.Forms.TextBox txtTableName;
        private System.Windows.Forms.TextBox txtTableStatus;
        private System.Windows.Forms.Panel pnlBottomRight;
        private System.Windows.Forms.Button btnAddTable;
        private System.Windows.Forms.Button btnDeleteTable;
        private System.Windows.Forms.Button btnEditTable;
    }
}