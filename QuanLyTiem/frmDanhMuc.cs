using QuanLyTiem.Dao;
using QuanLyTiem.DTO;
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
    public partial class frmDanhMuc : Form
    {
        // 1. Tạo một "nguồn dữ liệu" trung gian
        BindingSource categoryList = new BindingSource();

        public frmDanhMuc()
        {
            InitializeComponent();
            // 2. Kết nối Bảng với nguồn dữ liệu trung gian
            dtgvCategory.DataSource = categoryList;

            LoadListCategory();
            AddCategoryBinding();
        }

        // Hàm tải dữ liệu từ SQL lên
        void LoadListCategory()
        {
            categoryList.DataSource = CategoryDAO.Instance.GetListCategory();
            dtgvCategory.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
        }

        // ĐÂY LÀ BINDING: Nối cột của bảng với TextBox
        void AddCategoryBinding()
        {
            // Nối thuộc tính "Text" của txtCategoryID với giá trị cột "ID" trong bảng
            txtCategoryID.DataBindings.Add(new Binding("Text", dtgvCategory.DataSource, "ID", true, DataSourceUpdateMode.Never));

            // Nối thuộc tính "Text" của txtCategoryName với giá trị cột "Name" trong bảng
            txtCategoryName.DataBindings.Add(new Binding("Text", dtgvCategory.DataSource, "Name", true, DataSourceUpdateMode.Never));
        }

        private void btnAddCategory_Click(object sender, EventArgs e)
        {
            string name = txtCategoryName.Text;
            if (CategoryDAO.Instance.InsertCategory(name))
            {
                MessageBox.Show("Thêm thành công!");
                LoadListCategory();
            }
            else { MessageBox.Show("Thất bại!"); }
        }

        private void btnEditCategory_Click(object sender, EventArgs e)
        {
            int id = Convert.ToInt32(txtCategoryID.Text);
            string name = txtCategoryName.Text;
            if (CategoryDAO.Instance.UpdateCategory(id, name))
            {
                MessageBox.Show("Sửa thành công!");
                LoadListCategory();
            }
            else { MessageBox.Show("Thất bại!"); }
        }

        private void btnDeleteCategory_Click(object sender, EventArgs e)
        {
            int id = Convert.ToInt32(txtCategoryID.Text);
            if (CategoryDAO.Instance.DeleteCategory(id))
            {
                MessageBox.Show("Xóa thành công!");
                LoadListCategory();
            }
            else { MessageBox.Show("Thất bại (Có thể danh mục này đang có món ăn)!"); }
        }

        private void btnShowCategory_Click(object sender, EventArgs e)
        {
            LoadListCategory();
        }
    }   
}
