using QuanLyTiem.Dao;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace QuanLyTiem
{
    public partial class frmBanAn : Form
    {
        BindingSource tableList = new BindingSource();

        public frmBanAn()
        {
            InitializeComponent();
            dtgvTable.DataSource = tableList;
            LoadListTable();
            AddTableBinding();
        }

        void LoadListTable()
        {
            tableList.DataSource = TableDAO.Instance.GetListTable();
            dtgvTable.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
        }

        void AddTableBinding()
        {
            txtTableID.DataBindings.Add(new Binding("Text", dtgvTable.DataSource, "ID", true, DataSourceUpdateMode.Never));
            txtTableName.DataBindings.Add(new Binding("Text", dtgvTable.DataSource, "Name", true, DataSourceUpdateMode.Never));
            txtTableStatus.DataBindings.Add(new Binding("Text", dtgvTable.DataSource, "Status", true, DataSourceUpdateMode.Never));
        }

        private void btnAddTable_Click(object sender, EventArgs e)
        {
            string name = txtTableName.Text;
            if (TableDAO.Instance.InsertTable(name))
            {
                MessageBox.Show("Thêm bàn thành công!");
                LoadListTable();
            }
            else { MessageBox.Show("Thêm bàn thất bại!"); }
        }

        private void btnEditTable_Click(object sender, EventArgs e)
        {
            int id = Convert.ToInt32(txtTableID.Text);
            string name = txtTableName.Text;
            if (TableDAO.Instance.UpdateTable(id, name))
            {
                MessageBox.Show("Sửa bàn thành công!");
                LoadListTable();
            }
        }

        private void btnDeleteTable_Click(object sender, EventArgs e)
        {
            int id = Convert.ToInt32(txtTableID.Text);
            if (TableDAO.Instance.DeleteTable(id))
            {
                MessageBox.Show("Xóa bàn thành công!");
                LoadListTable();
            }
        }
    }
}
