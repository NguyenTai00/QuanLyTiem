using QuanLyTiem.Dao;
using System;
using System.Windows.Forms;

namespace QuanLyTiem
{
    public partial class frmHangHoa : Form
    {
        BindingSource foodList = new BindingSource();

        public frmHangHoa()
        {
            InitializeComponent();
            // dtgvTable là tên mặc định trong Designer của bạn
            dtgvTable.DataSource = foodList;
            LoadListFood();
            AddFoodBinding();
        }

        void LoadListFood()
        {
            foodList.DataSource = FoodDAO.Instance.GetListFood();
            dtgvTable.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
        }

        void AddFoodBinding()
        {
            // Xóa các liên kết cũ
            textBox6.DataBindings.Clear();
            textBox7.DataBindings.Clear();
            textBox8.DataBindings.Clear();
            textBox9.DataBindings.Clear();
            textBox10.DataBindings.Clear();

            // Liên kết TextBox với dữ liệu (Tên cột "ID", "Name"... phải đúng trong SQL)
            textBox6.DataBindings.Add(new Binding("Text", foodList, "ID", true, DataSourceUpdateMode.Never));
            textBox7.DataBindings.Add(new Binding("Text", foodList, "Name", true, DataSourceUpdateMode.Never));
            textBox8.DataBindings.Add(new Binding("Text", foodList, "Unit", true, DataSourceUpdateMode.Never));
            textBox9.DataBindings.Add(new Binding("Text", foodList, "Price", true, DataSourceUpdateMode.Never));
            textBox10.DataBindings.Add(new Binding("Text", foodList, "Quantity", true, DataSourceUpdateMode.Never));
        }

        // Các hàm sự kiện nút bấm
        private void button1_Click(object sender, EventArgs e) // Nút Thêm
        {

        }

        private void button3_Click(object sender, EventArgs e) // Nút Sửa
        {
            if (FoodDAO.Instance.UpdateFood(int.Parse(textBox6.Text), textBox7.Text, textBox8.Text, float.Parse(textBox9.Text), int.Parse(textBox10.Text)))
            {
                MessageBox.Show("Sửa thành công!");
                LoadListFood();
            }
        }

        private void button2_Click(object sender, EventArgs e) // Nút Xóa
        {
            if (FoodDAO.Instance.DeleteFood(int.Parse(textBox6.Text)))
            {
                MessageBox.Show("Xóa thành công!");
                LoadListFood();
            }
        }
    }
}