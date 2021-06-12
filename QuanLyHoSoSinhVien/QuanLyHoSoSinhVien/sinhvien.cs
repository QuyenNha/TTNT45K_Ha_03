using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;
using System.Data.SqlClient;

namespace QuanLyHoSoSinhVien
{
    public partial class quanly : Form
    {
        string sCon = "Data Source=DESKTOP-EFQDFTG\\TDH;Initial Catalog=QLHSSV;Integrated Security=True";

        public quanly()
        {
            InitializeComponent();
        }
        private void button14_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void button8_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void button27_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void button40_Click(object sender, EventArgs e)
        {
            this.Close();
        }
        private void quanly_Load(object sender, EventArgs e)
        {
            //Bước 1
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
            string sQuery = "Select * from SINHVIEN";
            SqlDataAdapter adapter = new SqlDataAdapter(sQuery, con);

            DataSet ds = new DataSet();

            adapter.Fill(ds, "SinhVien");

            dataGridView1.DataSource = ds.Tables["SinhVien"];

            con.Close();
        }
        private void button11_Click(object sender, EventArgs e)
        {
            //Bước 1
            SqlConnection con = new SqlConnection(sCon);
            try
            {
                con.Open();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Xảy ra lỗi trong quá trình kết nối DB");
            }
            //Bước 2 
            // chuan bi du lieu
            // kiem tra tinh hop le
            // gan du lieu vao bien
            string sMaSV = textBox1.Text;
            string sTenSV = textBox2.Text;
            string sDienThoai = textBox3.Text;
            string sDiaChi = textBox4.Text;
            string sMaLop = textBox5.Text;
            string sDiemTB = textBox6.Text;
            string sGioiTinh = comboBox1.Text;
            string sNgaySinh = dateTimePicker1.Value.ToString("yyy-MM-dd");
            string sQuery1 = " insert into sinhvien values(@MaSV, @HoTen, @NgaySinh, @GioiTinh, @DiaChi, @DienThoai, @MaLop, @DiemTB ) ";
            SqlCommand cmd = new SqlCommand(sQuery1, con);
            cmd.Parameters.AddWithValue("@MaSV", sMaSV);
            cmd.Parameters.AddWithValue("@HoTen", sTenSV);
            cmd.Parameters.AddWithValue("@DiaChi", sDiaChi);
            cmd.Parameters.AddWithValue("@NgaySinh", sNgaySinh);
            cmd.Parameters.AddWithValue("@GioiTinh", sGioiTinh);
            cmd.Parameters.AddWithValue("@DienThoai", sDienThoai);
            cmd.Parameters.AddWithValue("@MaLop", sMaLop);
            cmd.Parameters.AddWithValue("@DiemTB", sDiemTB);
            try
            {
                cmd.ExecuteNonQuery();
                MessageBox.Show("Thêm mới thành công");
            }
            catch (Exception ex)
            {
                MessageBox.Show("Xảy ra lỗi trong quá trình thêm mới");
            }
            string sQuery = "Select * from SINHVIEN";
            SqlDataAdapter adapter = new SqlDataAdapter(sQuery, con);

            DataSet ds = new DataSet();

            adapter.Fill(ds, "SinhVien");

            dataGridView1.DataSource = ds.Tables["SinhVien"];
            con.Close();
        }
        private void button9_Click(object sender, EventArgs e)
        {
            SqlConnection con = new SqlConnection(sCon);
            try
            {
                con.Open();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Xảy ra lỗi trong quá trình kết nối DB");
            }
            string sMaSV = textBox1.Text;
            string sTenSV = textBox2.Text;
            string sDienThoai = textBox3.Text;
            string sDiaChi = textBox4.Text;
            string sMaLop = textBox5.Text;
            string sDiemTB = textBox6.Text;
            string sGioiTinh = comboBox1.Text;
            string sNgaySinh = dateTimePicker1.Value.ToString("yyy-MM-dd");


            string sQuery = " update sinhvien set Hoten = @HoTen, NgaySinh = @NgaySinh, " +
                "GioiTinh = @GioiTinh, DiaChi = @DiaChi, DienThoai = @DienThoai, MaLop = @MaLop, DiemTB = @DiemTB " +
                "where MaSV = @MaSV";


            SqlCommand cmd = new SqlCommand(sQuery, con);
            cmd.Parameters.AddWithValue("@MaSV", sMaSV);
            cmd.Parameters.AddWithValue("@HoTen", sTenSV);
            cmd.Parameters.AddWithValue("@DiaChi", sDiaChi);
            cmd.Parameters.AddWithValue("@NgaySinh", sNgaySinh);
            cmd.Parameters.AddWithValue("@GioiTinh", sGioiTinh);
            cmd.Parameters.AddWithValue("@DienThoai", sDienThoai);
            cmd.Parameters.AddWithValue("@MaLop", sMaLop);
            cmd.Parameters.AddWithValue("@DiemTB", sDiemTB);

            try
            {
                cmd.ExecuteNonQuery();
                MessageBox.Show("Tìm kiếm thành công");
            }
            catch (Exception ex)
            {
                MessageBox.Show("Xảy ra lỗi trong quá tìm kiếm");
            }

            con.Close();
        
    }

        private void dataGridView1_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            textBox1.Text = dataGridView1.Rows[e.RowIndex].Cells["MaSV"].Value.ToString();
            textBox2.Text = dataGridView1.Rows[e.RowIndex].Cells["HoTen"].Value.ToString();
            textBox3.Text = dataGridView1.Rows[e.RowIndex].Cells["DienThoai"].Value.ToString();
            textBox4.Text = dataGridView1.Rows[e.RowIndex].Cells["DiaChi"].Value.ToString();
            textBox5.Text = dataGridView1.Rows[e.RowIndex].Cells["MaLop"].Value.ToString();
            textBox6.Text = dataGridView1.Rows[e.RowIndex].Cells["DiemTB"].Value.ToString();
            comboBox1.Text = dataGridView1.Rows[e.RowIndex].Cells["GioiTinh"].Value.ToString();
            dateTimePicker1.Value = Convert.ToDateTime(dataGridView1.Rows[e.RowIndex].Cells["NgaySinh"].Value);
            textBox1.Enabled = false;
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
                MessageBox.Show("Xảy ra lỗi trong quá trình kết nối DB");
            }
            string sMaSV = textBox1.Text;
            string sQuery3 = "delete sinhvien where MaSV = @MaSV";

            SqlCommand cmd = new SqlCommand(sQuery3, con);
            cmd.Parameters.AddWithValue("@MaSV", sMaSV);

            try
            {
                cmd.ExecuteNonQuery();
                MessageBox.Show("Xóa thành công");
            }
            catch (Exception ex)
            {
                MessageBox.Show("Xảy ra lỗi trong quá trình xóa");
            }
            string sQuery = "Select * from SINHVIEN";
            SqlDataAdapter adapter = new SqlDataAdapter(sQuery, con);

            DataSet ds = new DataSet();

            adapter.Fill(ds, "SinhVien");

            dataGridView1.DataSource = ds.Tables["SinhVien"];
            con.Close();
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
                MessageBox.Show("Xảy ra lỗi trong quá trình kết nối DB");
            }
            string sMaSV = textBox1.Text;
            string sTenSV = textBox2.Text;
            string sDienThoai = textBox3.Text;
            string sDiaChi = textBox4.Text;
            string sMaLop = textBox5.Text;
            string sDiemTB = textBox6.Text;
            string sGioiTinh = comboBox1.Text;
            string sNgaySinh = dateTimePicker1.Value.ToString("yyy-MM-dd");

            string sQuery2 = " update sinhvien set Hoten = @HoTen, NgaySinh = @NgaySinh, " +
                "GioiTinh = @GioiTinh, DiaChi = @DiaChi, DienThoai = @DienThoai, MaLop = @MaLop, DiemTB = @DiemTB " +
                "where MaSV = @MaSV";

            SqlCommand cmd = new SqlCommand(sQuery2, con);
            cmd.Parameters.AddWithValue("@MaSV", sMaSV);
            cmd.Parameters.AddWithValue("@HoTen", sTenSV);
            cmd.Parameters.AddWithValue("@DiaChi", sDiaChi);
            cmd.Parameters.AddWithValue("@NgaySinh", sNgaySinh);
            cmd.Parameters.AddWithValue("@GioiTinh", sGioiTinh);
            cmd.Parameters.AddWithValue("@DienThoai", sDienThoai);
            cmd.Parameters.AddWithValue("@MaLop", sMaLop);
            cmd.Parameters.AddWithValue("@DiemTB", sDiemTB);

            try
            {
                cmd.ExecuteNonQuery();
                MessageBox.Show("Sửa thành công");
            }
            catch (Exception ex)
            {
                MessageBox.Show("Xảy ra lỗi trong quá trình sửa");
            }
            string sQuery = "Select * from SINHVIEN";
            SqlDataAdapter adapter = new SqlDataAdapter(sQuery, con);

            DataSet ds = new DataSet();

            adapter.Fill(ds, "SinhVien");

            dataGridView1.DataSource = ds.Tables["SinhVien"];
            con.Close();
        }
        private void button1_Click_2(object sender, EventArgs e)
        {
            SqlConnection con = new SqlConnection(sCon);
            try
            {
                con.Open();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Xảy ra lỗi trong quá trình kết nối DB");
            }
            string sMaSV = textBox7.Text;
            
            string sQuery4 = " SELECT * from sinhvien where MaSV = @MaSV";

            SqlCommand cmd = new SqlCommand(sQuery4, con);
            cmd.Parameters.AddWithValue("@MaSV", sMaSV);
            SqlDataReader dr = cmd.ExecuteReader();
            DataTable dt = new DataTable();
            dt.Load(dr);
            dataGridView1.DataSource = dt;
        }
        private void button2_Click(object sender, EventArgs e)
        {
            //Làm trống ô nhập
            textBox1.Text ="";
            textBox2.Text ="";
            textBox3.Text ="";
            textBox4.Text ="";
            textBox5.Text ="";
            textBox6.Text ="";
            comboBox1.Text ="";
            dateTimePicker1.Value = new DateTime(2001, 1, 1);
            textBox1.Enabled = true;
            //Bước 1
            SqlConnection con = new SqlConnection(sCon);
            //Bước 2 - lấy dữ liệu về
            string sQuery = "Select * from SINHVIEN";
            SqlDataAdapter adapter = new SqlDataAdapter(sQuery, con);
            DataSet ds = new DataSet();
            adapter.Fill(ds, "SinhVien");
            dataGridView1.DataSource = ds.Tables["SinhVien"];
            con.Close();
        }
    }
}