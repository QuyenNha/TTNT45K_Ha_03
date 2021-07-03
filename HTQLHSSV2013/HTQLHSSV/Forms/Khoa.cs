using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;
using System.Data.SqlClient;

namespace HTQLHSSV.Forms
{
    public partial class Khoa : Form
    {
        string sCon = "Data Source=DESKTOP-EFQDFTG\\TDH;Initial Catalog=QLHSSV;Integrated Security=True";   
        public Khoa()
        {
            InitializeComponent();
        }

        private void Khoa_Load(object sender, EventArgs e)
        {
            LoadTheme();
            SqlConnection con = new SqlConnection(sCon);
            try
            {
                con.Open();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Xảy ra lỗi trong quá trình kết nối DB");
            }

            //Bước 2 - lấy dữ liệu về
            string sQuery = "Select * from KHOA";
            SqlDataAdapter adapter = new SqlDataAdapter(sQuery, con);

            DataSet ds = new DataSet();

            adapter.Fill(ds, "KHOA");

            dataGridView1.DataSource = ds.Tables["KHOA"];
            dataGridView1.Columns[0].HeaderText = "Tên khoa";
            dataGridView1.Columns[1].HeaderText = "Địa chỉ";
            dataGridView1.Columns[2].HeaderText = "Số điện thoại";
            
            dataGridView1.Columns[0].Width = 100;
            dataGridView1.Columns[1].Width = 200;
            dataGridView1.Columns[2].Width = 120;


            
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
            textBox1.Text = dataGridView1.Rows[e.RowIndex].Cells["TenKhoa"].Value.ToString();
            textBox2.Text = dataGridView1.Rows[e.RowIndex].Cells["DiaChi"].Value.ToString();
            textBox3.Text = dataGridView1.Rows[e.RowIndex].Cells["DienThoai"].Value.ToString();
            textBox1.Enabled = false;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            //Bước 1
            if (this.textBox1.TextLength == 0 || this.textBox2.TextLength == 0 || this.textBox3.TextLength == 0)
            {
                MessageBox.Show("Vui lòng điền đầy đủ thông tin!", "THÔNG BÁO", MessageBoxButtons.OK, MessageBoxIcon.Error);
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
                string sTenKhoa = textBox1.Text;
                string sDiaChi = textBox2.Text;
                string sDienThoai = textBox3.Text;
                string sQuery1 = sQuery1 = " insert into KHOA values(@TenKhoa, @DiaChi, @DienThoai) ";
                SqlCommand cmd = new SqlCommand(sQuery1, con);
                cmd.Parameters.AddWithValue("@TenKhoa", sTenKhoa);
                cmd.Parameters.AddWithValue("@DiaChi", sDiaChi);
                cmd.Parameters.AddWithValue("@DienThoai", sDienThoai);
                try
                {
                    cmd.ExecuteNonQuery();
                    MessageBox.Show("Thêm mới thành công!", "THÔNG BÁO", MessageBoxButtons.OK);
                }
                catch (Exception ex)
                {
                    if (textBox3.TextLength > 11)
                        MessageBox.Show("Số điện thoại không quá 11 số!", "THÔNG BÁO", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    else
                        MessageBox.Show("Tên khoa đã tồn tại!", "THÔNG BÁO", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
                string sQuery = "Select * from KHOA";
                SqlDataAdapter adapter = new SqlDataAdapter(sQuery, con);

                DataSet ds = new DataSet();

                adapter.Fill(ds, "KHOA");

                dataGridView1.DataSource = ds.Tables["KHOA"];
                con.Close();
            }
        }

        private void button2_Click(object sender, EventArgs e)
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
            string sTenKhoa = textBox1.Text;
            string sDiaChi = textBox2.Text;
            string sDienThoai = textBox3.Text;
            string sQuery2 = "Update KHOA Set DiaChi = @DiaChi, DienThoai = @DienThoai Where TenKhoa = @TenKhoa";

            SqlCommand cmd = new SqlCommand(sQuery2, con);
            cmd.Parameters.AddWithValue("@TenKhoa", sTenKhoa);
            cmd.Parameters.AddWithValue("@DiaChi", sDiaChi);
            cmd.Parameters.AddWithValue("@DienThoai", sDienThoai);

            try
            {
                cmd.ExecuteNonQuery();
                MessageBox.Show("Sửa thành công!", "THÔNG BÁO", MessageBoxButtons.OK);
            }
            catch (Exception ex)
            {
                if (textBox3.TextLength > 11)
                    MessageBox.Show("Số điện thoại không quá 11 số!", "THÔNG BÁO", MessageBoxButtons.OK, MessageBoxIcon.Error);
                else
                    MessageBox.Show("Lỗi nhập dữ liệu", "THÔNG BÁO", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            string sQuery = "Select * from KHOA";
            SqlDataAdapter adapter = new SqlDataAdapter(sQuery, con);

            DataSet ds = new DataSet();

            adapter.Fill(ds, "KHOA");

            dataGridView1.DataSource = ds.Tables["KHOA"];
            con.Close();
        }

        private void button3_Click(object sender, EventArgs e)
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
            string sTenKhoa = textBox1.Text;
            string sQuery2 = "Delete KHOA Where TenKhoa = @TenKhoa";
            SqlCommand cmd = new SqlCommand(sQuery2, con);
            cmd.Parameters.AddWithValue("@TenKhoa", sTenKhoa);
            try
            {
                cmd.ExecuteNonQuery();
                MessageBox.Show("Xóa thành công!");
            }
            catch (Exception ex)
            {
                MessageBox.Show("Bạn không thể xoá được vì khoa có chứa chưa lớp!", "THÔNG BÁO", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            string sQuery = "Select * from KHOA";
            SqlDataAdapter adapter = new SqlDataAdapter(sQuery, con);

            DataSet ds = new DataSet();

            adapter.Fill(ds, "KHOA");

            dataGridView1.DataSource = ds.Tables["KHOA"];
            con.Close();
        }

        private void button4_Click(object sender, EventArgs e)
        {
            //Làm trống ô nhập
            textBox1.Text = "";
            textBox2.Text = "";
            textBox3.Text = "";
            textBox1.Enabled = true;
            //Bước 1
            SqlConnection con = new SqlConnection(sCon);
            //Bước 2 - lấy dữ liệu về
            string sQuery = "Select * from KHOA";
            SqlDataAdapter adapter = new SqlDataAdapter(sQuery, con);
            DataSet ds = new DataSet();
            adapter.Fill(ds, "KHOA");
            dataGridView1.DataSource = ds.Tables["KHOA"];
            con.Close();
        }

        private void button5_Click(object sender, EventArgs e)
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
            string sTenKhoa = textBox4.Text;
            string sQuery = "select *from KHOA where TenKhoa=@TenKhoa";
            SqlDataAdapter adapter = new SqlDataAdapter(sQuery, con);
            SqlCommand cmd = new SqlCommand(sQuery, con);
            cmd.Parameters.AddWithValue("@TenKhoa", sTenKhoa);
            SqlDataReader dr = cmd.ExecuteReader();
            DataTable dt = new DataTable();
            dt.Load(dr);
            dataGridView1.DataSource = dt;
        }


    }
}
