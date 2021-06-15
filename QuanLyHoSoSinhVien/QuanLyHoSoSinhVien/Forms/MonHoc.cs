using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
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
    public partial class MonHoc : Form
    {
        string sCon = "Data Source=DESKTOP-EFQDFTG\\TDH;Initial Catalog=QLHSSV;Integrated Security=True";
        public MonHoc()
        {
            InitializeComponent();
        }

        private void MonHoc_Load(object sender, EventArgs e)
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
            string sQuery = "Select * from MONHOC";
            SqlDataAdapter adapter = new SqlDataAdapter(sQuery, con);

            DataSet ds = new DataSet();

            adapter.Fill(ds, "MONHOC");

            dataGridView1.DataSource = ds.Tables["MONHOC"];

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
            textBox6.Text = dataGridView1.Rows[e.RowIndex].Cells["MaMH"].Value.ToString();
            textBox9.Text = dataGridView1.Rows[e.RowIndex].Cells["TenMH"].Value.ToString();
            comboBox1.Text = dataGridView1.Rows[e.RowIndex].Cells["TinChi"].Value.ToString();
            comboBox2.Text = dataGridView1.Rows[e.RowIndex].Cells["TenKhoa"].Value.ToString();
            textBox6.Enabled = false;
        }
        private void button11_Click(object sender, EventArgs e)
        {
            if (this.textBox6.TextLength == 0 || this.textBox9.TextLength == 0
                || this.comboBox1.Text == null || this.comboBox2.Text == null)
            {
                MessageBox.Show("Bạn vui lòng điền đầy đủ thông tin!", "THÔNG BÁO", MessageBoxButtons.OK);
            }
            else
            {
                //Bước 1
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
                string sMaMH = textBox6.Text;
                string sTenMH = textBox9.Text;
                string sTinChi = comboBox1.Text;
                string sTenKhoa = comboBox2.Text;
                string sQuery1 = sQuery1 = " insert into MONHOC values(@MaMH,@TenMH,@TinChi,@TenKhoa) ";
                SqlCommand cmd = new SqlCommand(sQuery1, con);
                cmd.Parameters.AddWithValue("@MaMH", sMaMH);
                cmd.Parameters.AddWithValue("@TenMH", sTenMH);
                cmd.Parameters.AddWithValue("@TinChi", sTinChi);
                cmd.Parameters.AddWithValue("@TenKhoa", sTenKhoa);
                try
                {
                    cmd.ExecuteNonQuery();
                    MessageBox.Show("Thêm mới thành công!");
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Mã Môn Môn Học Đã Tồn Tại!");
                }
                string sQuery = "Select * from MONHOC";
                SqlDataAdapter adapter = new SqlDataAdapter(sQuery, con);

                DataSet ds = new DataSet();

                adapter.Fill(ds, "MONHOC");

                dataGridView1.DataSource = ds.Tables["MONHOC"];
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
                string sMaMH = textBox6.Text;
                string sTenMH = textBox9.Text;
                string sTinChi = comboBox1.Text;
                string sTenKhoa = comboBox2.Text;
                string sQuery2 = "Update MonHoc Set TenMH = @TenMH, Tinchi =@TinChi, TenKhoa=@TenKhoa Where MaMH = @MaMH";

                SqlCommand cmd = new SqlCommand(sQuery2, con);
                cmd.Parameters.AddWithValue("@MaMH", sMaMH);
                cmd.Parameters.AddWithValue("@TenMH", sTenMH);
                cmd.Parameters.AddWithValue("@TinChi", sTinChi);
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
                string sQuery = "Select * from MONHOC";
                SqlDataAdapter adapter = new SqlDataAdapter(sQuery, con);

                DataSet ds = new DataSet();

                adapter.Fill(ds, "MONHOC");

                dataGridView1.DataSource = ds.Tables["MONHOC"];
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
            string sMaMH = textBox6.Text;
            string sQuery2 = "Delete MonHoc Where MaMH  = @MaMH ";
            SqlCommand cmd = new SqlCommand(sQuery2, con);
            cmd.Parameters.AddWithValue("@MaMH", sMaMH);
            try
            {
                cmd.ExecuteNonQuery();
                MessageBox.Show("Xóa thành công!");
            }
            catch (Exception ex)
            {
                MessageBox.Show("Xóa Thất Bại!");
            }
            string sQuery = "Select * from MONHOC";
            SqlDataAdapter adapter = new SqlDataAdapter(sQuery, con);

            DataSet ds = new DataSet();

            adapter.Fill(ds, "MONHOC");

            dataGridView1.DataSource = ds.Tables["MONHOC"];
            con.Close();
        }
        private void button2_Click(object sender, EventArgs e)
        {
            //Làm trống ô nhập
            textBox1.Text = "";
            textBox2.Text = "";
            comboBox1.Text = "";
            comboBox1.Text = "";
            textBox1.Enabled = true;
            //Bước 1
            SqlConnection con = new SqlConnection(sCon);
            //Bước 2 - lấy dữ liệu về
            string sQuery = "Select * from MONHOC";
            SqlDataAdapter adapter = new SqlDataAdapter(sQuery, con);
            DataSet ds = new DataSet();
            adapter.Fill(ds, "MONHOC");
            dataGridView1.DataSource = ds.Tables["MONHOC"];
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
            string sMaMH = textBox6.Text;
            string sQuery = "select *from MONHOC where MaMH=@MaMH";
            SqlDataAdapter adapter = new SqlDataAdapter(sQuery, con);
            SqlCommand cmd = new SqlCommand(sQuery, con);
            cmd.Parameters.AddWithValue("@MaMH", sMaMH);
            SqlDataReader dr = cmd.ExecuteReader();
            DataTable dt = new DataTable();
            dt.Load(dr);
            dataGridView1.DataSource = dt;
        }

        private void button2_Click_1(object sender, EventArgs e)
        {
            textBox6.Text = "";
            textBox9.Text = "";
            comboBox1.Text = "";
            comboBox2.Text = "";
            textBox6.Enabled = true;
            //Bước 1
            SqlConnection con = new SqlConnection(sCon);
            //Bước 2 - lấy dữ liệu về
            string sQuery = "Select * from MonHoc";
            SqlDataAdapter adapter = new SqlDataAdapter(sQuery, con);
            DataSet ds = new DataSet();
            adapter.Fill(ds, "MonHoc");
            dataGridView1.DataSource = ds.Tables["MonHoc"];
            con.Close();
        }

        private void button1_Click_1(object sender, EventArgs e)
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
            string sMaMH = textBox6.Text;
            string sQuery = "select *from MonHoc where MaMH=@MaMH";
            SqlDataAdapter adapter = new SqlDataAdapter(sQuery, con);
            SqlCommand cmd = new SqlCommand(sQuery, con);
            cmd.Parameters.AddWithValue("@MaMH", sMaMH);
            SqlDataReader dr = cmd.ExecuteReader();
            DataTable dt = new DataTable();
            dt.Load(dr);
            dataGridView1.DataSource = dt;
        }
    }
}
