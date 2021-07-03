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
            dataGridView1.Columns[0].HeaderText = "Mã môm học";
            dataGridView1.Columns[1].HeaderText = "Môn học";
            dataGridView1.Columns[2].HeaderText = "Số tín chỉ";
            dataGridView1.Columns[3].HeaderText = "Tên khoa";

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
            textBox1.Text = dataGridView1.Rows[e.RowIndex].Cells["MaMH"].Value.ToString();
            textBox2.Text = dataGridView1.Rows[e.RowIndex].Cells["TenMH"].Value.ToString();
            comboBox1.Text = dataGridView1.Rows[e.RowIndex].Cells["TinChi"].Value.ToString();
            comboBox2.Text = dataGridView1.Rows[e.RowIndex].Cells["TenKhoa"].Value.ToString();
            textBox1.Enabled = false;
        }

        private void button1_Click(object sender, System.EventArgs e)
        {
            if (this.textBox1.TextLength == 0 || this.textBox2.TextLength == 0
                || this.comboBox1.Text == null || this.comboBox2.Text == null)
            {
                MessageBox.Show("Vui lòng điền đầy đủ thông tin!", "THÔNG BÁO", MessageBoxButtons.OK);
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
                string sMaMH = textBox1.Text;
                string sTenMH = textBox2.Text;
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
                    MessageBox.Show("Thêm mới thành công!", "THÔNG BÁO", MessageBoxButtons.OK);
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Mã môn học đã tồn tại!", "THÔNG BÁO", MessageBoxButtons.OK);
                }
                string sQuery = "Select * from MONHOC";
                SqlDataAdapter adapter = new SqlDataAdapter(sQuery, con);

                DataSet ds = new DataSet();

                adapter.Fill(ds, "MONHOC");

                dataGridView1.DataSource = ds.Tables["MONHOC"];
                con.Close();
            }
        }

        private void button2_Click(object sender, System.EventArgs e)
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
            string sMaMH = textBox1.Text;
            string sTenMH = textBox2.Text;
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
                MessageBox.Show("Sửa thành công!", "THÔNG BÁO", MessageBoxButtons.OK);
            }
            catch (Exception ex)
            {
                MessageBox.Show("Lỗi nhập dữ liệu: " + ex.Message, "THÔNG BÁO", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            string sQuery = "Select * from MONHOC";
            SqlDataAdapter adapter = new SqlDataAdapter(sQuery, con);

            DataSet ds = new DataSet();

            adapter.Fill(ds, "MONHOC");

            dataGridView1.DataSource = ds.Tables["MONHOC"];
            con.Close();

        }

        private void button3_Click(object sender, System.EventArgs e)
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
            string sMaMH = textBox1.Text;
            string sQuery2 = "Delete MonHoc Where MaMH  = @MaMH ";
            SqlCommand cmd = new SqlCommand(sQuery2, con);
            cmd.Parameters.AddWithValue("@MaMH", sMaMH);
            try
            {
                cmd.ExecuteNonQuery();
                MessageBox.Show("Xóa thành công!", "THÔNG BÁO", MessageBoxButtons.OK);
            }
            catch (Exception ex)
            {
                MessageBox.Show("Xóa Thất Bại!", "THÔNG BÁO", MessageBoxButtons.OK);
            }
            string sQuery = "Select * from MONHOC";
            SqlDataAdapter adapter = new SqlDataAdapter(sQuery, con);

            DataSet ds = new DataSet();

            adapter.Fill(ds, "MONHOC");

            dataGridView1.DataSource = ds.Tables["MONHOC"];
            con.Close();
        }

        private void button4_Click(object sender, System.EventArgs e)
        {
            //Làm trống ô nhập
            textBox1.Text = "";
            textBox2.Text = "";
            comboBox1.Text = "";
            comboBox2.Text = "";
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

        private void button5_Click(object sender, System.EventArgs e)
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
            string sMaMH = textBox3.Text;
            string sQuery = "select *from MONHOC where MaMH=@MaMH";
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
