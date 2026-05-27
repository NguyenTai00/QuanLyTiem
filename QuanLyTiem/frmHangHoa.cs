using QuanLyTiem.Dao;
using QuanLyTiem.DTO;
using System;
using System.Collections.Generic;
using System.Windows.Forms;

namespace QuanLyTiem
{
    public partial class frmHangHoa : Form
    {
        BindingSource foodList = new BindingSource();

        public frmHangHoa()
        {
            InitializeComponent();
            LoadListFood();
            AddFoodBinding();
        }

        void LoadListFood()
        {
            // Lấy dữ liệu từ FoodDAO
            foodList.DataSource = FoodDAO.Instance.GetListFood();
            dtgvTable.DataSource = foodList; 
            dtgvTable.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
        }

        void AddFoodBinding()
        {
           
            textBox6.DataBindings.Add(new Binding("Text", foodList, "ID", true, DataSourceUpdateMode.Never));
            textBox7.DataBindings.Add(new Binding("Text", foodList, "Name", true, DataSourceUpdateMode.Never));
            
            textBox9.DataBindings.Add(new Binding("Text", foodList, "Price", true, DataSourceUpdateMode.Never));
            
        }

        private void button1_Click(object sender, EventArgs e) // Nút Thêm
        {
            string name = textBox7.Text;
            float price = (float)Convert.ToDouble(textBox9.Text);
            int idCategory = 1; 

            if (FoodDAO.Instance.InsertFood(name, idCategory, price))
            {
                MessageBox.Show("Thêm thành công!");
                LoadListFood();
            }
        }

        private void button3_Click(object sender, EventArgs e) 
        {
            int id = Convert.ToInt32(textBox6.Text);
            string name = textBox7.Text;
            float price = (float)Convert.ToDouble(textBox9.Text);
            int idCategory = 1;

            if (FoodDAO.Instance.UpdateFood(id, name, idCategory, price))
            {
                MessageBox.Show("Sửa thành công!");
                LoadListFood();
            }
        }

        private void button2_Click(object sender, EventArgs e) // Nút Xóa
        {
            int id = Convert.ToInt32(textBox6.Text);
            if (FoodDAO.Instance.DeleteFood(id))
            {
                MessageBox.Show("Xóa thành công!");
                LoadListFood();
            }
        }
    }
}