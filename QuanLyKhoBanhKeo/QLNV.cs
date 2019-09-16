using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace QuanLyKhoBanhKeo
{
    public partial class QLNV : Form
    {

        public QLNV()
        {
            InitializeComponent();
        }
        private void ketnoicsdl()
        {
            SqlConnection cnn = new SqlConnection(@"Data Source=DESKTOP-RPK6PAD\SQLEXPRESS;Initial Catalog=N02_QuanLyKhoBanhKeo;Integrated Security = True");

            
            cnn.Open();
            string sql = "select * from NhanVien";  // lay het du lieu trong bang sinh vien
            SqlCommand com = new SqlCommand(sql, cnn); //bat dau truy van
            com.CommandType = CommandType.Text;
            SqlDataAdapter da = new SqlDataAdapter(com); //chuyen du lieu ve
            DataTable dt = new DataTable(); //tạo một kho ảo để lưu trữ dữ liệu
            da.Fill(dt);  // đổ dữ liệu vào kho
            cnn.Close();  // đóng kết nối
            dataGridView1.DataSource = dt; //đổ dữ liệu vào datagridview
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            
            // Bind the DataGridView to the BindingSource
            // and load the data from the database.
            ketnoicsdl();
        }
    }
}
