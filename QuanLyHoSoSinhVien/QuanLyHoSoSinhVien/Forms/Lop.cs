using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;
using System.Data.SqlClient;

namespace QuanLyHoSoSinhVien.Forms
{
    public partial class Lop : Form
    {
        string sCon = "Data Source=DESKTOP-EFQDFTG\\TDH;Initial Catalog=QLHSSV;Integrated Security=True";
        public Lop()
        {
            InitializeComponent();
        }

        private void Lop_Load(object sender, EventArgs e)
        {
            LoadTheme();
            SqlConnection con = new SqlConnection(sCon);
            try
            {
                con.Open();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Xảy ra lỗi trong quá trình kết nối DB!");
            }

            //Bước 2 - lấy dữ liệu về
            string sQuery = "Select * from LopSH";
            SqlDataAdapter adapter = new SqlDataAdapter(sQuery, con);

            DataSet ds = new DataSet();

            adapter.Fill(ds, "LopSH");

            dataGridView1.DataSource = ds.Tables["LopSH"];

            con.Close();
        }
        private void LoadTheme()
        {
            foreach (Control btns in this.Controls)
            {
                if (btns.GetType() == typeof(Button))
                {
                    Button btn = (Button)btns;
                    btn.BackColor = ThemeColor.PrimaryColor;
                    btn.ForeColor = Color.White;
                    btn.FlatAppearance.BorderColor = ThemeColor.SecondaryColor;
                }
            }
        }
        private void dataGridView1_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            textBox1.Text = dataGridView1.Rows[e.RowIndex].Cells["MaLop"].Value.ToString();
            textBox2.Text = dataGridView1.Rows[e.RowIndex].Cells["TenLop"].Value.ToString();
            comboBox1.Text = dataGridView1.Rows[e.RowIndex].Cells["TenKhoa"].Value.ToString();
            textBox1.Enabled = false;
        }

        private void button11_Click(object sender, EventArgs e)
        {
            //Bước 1
            if (this.textBox1.TextLength == 0 || this.textBox2.TextLength == 0 || this.comboBox1.Text == null )
            {
                MessageBox.Show("Bạn vui lòng điền đầy đủ thông tin!", "THÔNG BÁO", MessageBoxButtons.OK);
            }

            else
            {
                SqlConnection con = new SqlConnection(sCon);
                try
                {
                    con.Open();
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Xảy ra lỗi trong quá trình kết nối DB!");
                }
                //Bước 2 
                // chuan bi du lieu
                // kiem tra tinh hop le
                // gan du lieu vao bien
                string sMaLop = textBox1.Text;
                string sTenLop = textBox2.Text;
                string sTenKhoa = comboBox1.Text;
                string sQuery1 = sQuery1 = " insert into LopSH values(@MaLop, @TenLop, @TenKhoa) ";
                SqlCommand cmd = new SqlCommand(sQuery1, con);
                cmd.Parameters.AddWithValue("@MaLop", sMaLop);
                cmd.Parameters.AddWithValue("@TenLop", sTenLop);
                cmd.Parameters.AddWithValue("@TenKhoa", sTenKhoa);
                try
                {
                    cmd.ExecuteNonQuery();
                    MessageBox.Show("Thêm mới thành công!");
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Mã Lớp Đã Tồn Tại!");
                }
                string sQuery = "Select * from LopSH";
                SqlDataAdapter adapter = new SqlDataAdapter(sQuery, con);

                DataSet ds = new DataSet();

                adapter.Fill(ds, "LopSH");

                dataGridView1.DataSource = ds.Tables["LopSH"];
                con.Close();
            }
        }
        private void button12_Click(object sender, EventArgs e)
        {
            SqlConnection con = new SqlConnection(sCon);
            try
            {
                con.Open();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Xảy ra lỗi trong quá trình kết nối DB!");
            }
            string sMaLop = textBox1.Text;
            string sTenLop = textBox2.Text;
            string sTenKhoa = comboBox1.Text;
            string sQuery2 = "Update LopSH Set TenLop = @TenLop, TenKhoa = @TenKhoa Where MaLop = @MaLop";

            SqlCommand cmd = new SqlCommand(sQuery2, con);
            cmd.Parameters.AddWithValue("@MaLop", sMaLop);
            cmd.Parameters.AddWithValue("@TenLop", sTenLop);
            cmd.Parameters.AddWithValue("@TenKhoa", sTenKhoa);

            try
            {
                cmd.ExecuteNonQuery();
                MessageBox.Show("Sửa thành công!");
            }
            catch (Exception ex)
            {
                MessageBox.Show("Tên Khoa không tồn tại!");
            }
            string sQuery = "Select * from LopSH";
            SqlDataAdapter adapter = new SqlDataAdapter(sQuery, con);

            DataSet ds = new DataSet();

            adapter.Fill(ds, "LopSH");

            dataGridView1.DataSource = ds.Tables["LopSH"];
            con.Close();
        }

        private void button10_Click(object sender, EventArgs e)
        {
            SqlConnection con = new SqlConnection(sCon);
            try
            {
                con.Open();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Xảy ra lỗi trong quá trình kết nối DB!");
            }
            string sMaLop = textBox1.Text;
            string sQuery2 = "Delete LopSH Where MaLop = @MaLop";
            SqlCommand cmd = new SqlCommand(sQuery2, con);
            cmd.Parameters.AddWithValue("@MaLop", sMaLop);
            try
            {
                cmd.ExecuteNonQuery();
                MessageBox.Show("Xóa thành công!");
            }
            catch (Exception ex)
            {
                MessageBox.Show("Bạn không thể xoá được vì lớp có chứa sinh viên!");
            }
            string sQuery = "Select * from LopSH";
            SqlDataAdapter adapter = new SqlDataAdapter(sQuery, con);

            DataSet ds = new DataSet();

            adapter.Fill(ds, "LopSH");

            dataGridView1.DataSource = ds.Tables["LopSH"];
            con.Close();
        }
        private void button2_Click(object sender, EventArgs e)
        {
            //Làm trống ô nhập
            textBox1.Text = "";
            textBox2.Text = "";
            comboBox1.Text = "";
            textBox1.Enabled = true;
            //Bước 1
            textBox1.Enabled = true;
            SqlConnection con = new SqlConnection(sCon);
            //Bước 2 - lấy dữ liệu về
            string sQuery = "Select * from LopSH";
            SqlDataAdapter adapter = new SqlDataAdapter(sQuery, con);
            DataSet ds = new DataSet();
            adapter.Fill(ds, "LopSH");
            dataGridView1.DataSource = ds.Tables["LopSH"];
            con.Close();
        }
        private void button1_Click(object sender, EventArgs e)
        {
            SqlConnection con = new SqlConnection(sCon);
            try
            {
                con.Open();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Xảy ra lỗi trong quá trình kết nối DB!");
            }
            string sMaLop = textBox7.Text;
            string sQuery = "select *from LopSH where MaLop=@MaLop";
            SqlDataAdapter adapter = new SqlDataAdapter(sQuery, con);
            SqlCommand cmd = new SqlCommand(sQuery, con);
            cmd.Parameters.AddWithValue("@MaLop", sMaLop);
            SqlDataReader dr = cmd.ExecuteReader();
            DataTable dt = new DataTable();
            dt.Load(dr);
            dataGridView1.DataSource = dt;
        }
    }
}
