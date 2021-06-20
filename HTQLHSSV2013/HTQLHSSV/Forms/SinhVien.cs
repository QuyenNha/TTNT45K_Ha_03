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
    public partial class SinhVien : Form
    {
        string sCon = "Data Source=DESKTOP-EFQDFTG\\TDH;Initial Catalog=QLHSSV;Integrated Security=True";
        public SinhVien()
        {
            InitializeComponent();
        }

        private void SinhVien_Load(object sender, EventArgs e)
        {

            LoadTheme();
            SqlConnection con = new SqlConnection(sCon);
            try
            {
                con.Open();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Xảy ra lỗi trong quá trình kết nối DB!1");
            }

            //Bước 2 - lấy dữ liệu về
            string sQuery = "Select * from SINHVIEN";
            SqlDataAdapter adapter = new SqlDataAdapter(sQuery, con);

            DataSet ds = new DataSet();

            adapter.Fill(ds, "SinhVien");

            dataGridView1.DataSource = ds.Tables["SinhVien"];

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

        private void button1_Click(object sender, EventArgs e)
        {
            //Bước 1
            if (this.textBox1.TextLength == 0 || this.textBox2.TextLength == 0 || this.textBox3.TextLength == 0 || this.textBox4.TextLength == 0 | this.textBox5.TextLength == 0
               || this.textBox6.TextLength == 0 || this.dateTimePicker1.Value == null || this.comboBox1.Text == null || this.comboBox3.Text == null
                 )
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
                    MessageBox.Show("Xảy ra lỗi trong quá trình kết nối DB2!");
                }
                //Bước 2 
                // chuan bi du lieu
                // kiem tra tinh hop le
                // gan du lieu vao bien
                string sMaSV = textBox1.Text;
                string sHoTen = textBox2.Text;
                string sDienThoai = textBox3.Text;
                string sDiaChi_PhuongXa = textBox4.Text;
                string sDiaChi_QuanHuyen = textBox5.Text;
                string sDiaChi_TinhThanhPho = textBox6.Text;
                string sGioiTinh = comboBox1.Text;
                string sMaLop = comboBox3.Text;
                string sNgaySinh = dateTimePicker1.Value.ToString("yyy-MM-dd");
                string sQuery1 = " insert into SINHVIEN values(@MaSV,@HoTen,@NgaySinh,@GioiTinh,@DiaChi_PhuongXa,@DiaChi_QuanHuyen,@DiaChi_TinhThanhPho,@DienThoai,@MaLop) ";
                SqlCommand cmd = new SqlCommand(sQuery1, con);
                cmd.Parameters.AddWithValue("@MaSV", sMaSV);
                cmd.Parameters.AddWithValue("@HoTen", sHoTen);
                cmd.Parameters.AddWithValue("@NgaySinh", sNgaySinh);
                cmd.Parameters.AddWithValue("@GioiTinh", sGioiTinh);
                cmd.Parameters.AddWithValue("@DiaChi_PhuongXa", sDiaChi_PhuongXa);
                cmd.Parameters.AddWithValue("@DiaChi_QuanHuyen", sDiaChi_QuanHuyen);
                cmd.Parameters.AddWithValue("@DiaChi_TinhThanhPho", sDiaChi_TinhThanhPho);
                cmd.Parameters.AddWithValue("@DienThoai", sDienThoai);
                cmd.Parameters.AddWithValue("@MaLop", sMaLop);

                try
                {
                    cmd.ExecuteNonQuery();
                    MessageBox.Show("Thêm thành công!");
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Mã Sinh Viên Đã Tồn Tại!");
                }
                string sQuery = "Select * from SINHVIEN";
                SqlDataAdapter adapter = new SqlDataAdapter(sQuery, con);

                DataSet ds = new DataSet();

                adapter.Fill(ds, "SinhVien");

                dataGridView1.DataSource = ds.Tables["SinhVien"];
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
                MessageBox.Show("Xảy ra lỗi trong quá trình kết nối DB3!");
            }
            string sMaSV = textBox1.Text;
            string sHoTen = textBox2.Text;
            string sDienThoai = textBox3.Text;
            string sDiaChi_PhuongXa = textBox4.Text;
            string sDiaChi_QuanHuyen = textBox5.Text;
            string sDiaChi_TinhThanhPho = textBox6.Text;
            string sGioiTinh = comboBox1.Text;
            string sMaLop = comboBox3.Text;
            string sNgaySinh = dateTimePicker1.Value.ToString("yyy-MM-dd");
            string sQuery2 = "Update SINHVIEN Set HoTen = @HoTen, NgaySinh = @NgaySinh, GioiTinh = @GioiTinh, DiaChi_PhuongXa = @DiaChi_PhuongXa, DiaChi_QuanHuyen = @DiaChi_QuanHuyen,DiaChi_TinhThanhPho=@DiaChi_TinhThanhPho,@DienThoai=DienThoai,@MaLop=MaLop Where MaSV = @MaSV";

            SqlCommand cmd = new SqlCommand(sQuery2, con);
            cmd.Parameters.AddWithValue("@MaSV", sMaSV);
            cmd.Parameters.AddWithValue("@HoTen", sHoTen);
            cmd.Parameters.AddWithValue("@NgaySinh", sNgaySinh);
            cmd.Parameters.AddWithValue("@GioiTinh", sGioiTinh);
            cmd.Parameters.AddWithValue("@DiaChi_PhuongXa", sDiaChi_PhuongXa);
            cmd.Parameters.AddWithValue("@DiaChi_QuanHuyen", sDiaChi_QuanHuyen);
            cmd.Parameters.AddWithValue("@DiaChi_TinhThanhPho", sDiaChi_TinhThanhPho);
            cmd.Parameters.AddWithValue("@DienThoai", sDienThoai);
            cmd.Parameters.AddWithValue("@MaLop", sMaLop);

            try
            {
                cmd.ExecuteNonQuery();
                MessageBox.Show("Sửa thành công!");
            }
            catch (Exception ex)
            {
                MessageBox.Show("Mã lớp không tồn tại!");
            }
            string sQuery = "Select * from SINHVIEN";
            SqlDataAdapter adapter = new SqlDataAdapter(sQuery, con);

            DataSet ds = new DataSet();

            adapter.Fill(ds, "SinhVien");

            dataGridView1.DataSource = ds.Tables["SinhVien"];
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
                MessageBox.Show("Xảy ra lỗi trong quá trình kết nối DB4!");
            }
            string sMaSV = textBox1.Text;
            string sQuery2 = "delete SINHVIEN where MaSV=@MaSV";
            SqlCommand cmd = new SqlCommand(sQuery2, con);
            cmd.Parameters.AddWithValue("@MaSV", sMaSV);
            try
            {
                cmd.ExecuteNonQuery();
                MessageBox.Show("Xóa thành công!");
            }
            catch (Exception ex)
            {
                MessageBox.Show("Xóa thất bại!");
            }
            string sQuery = "Select * from SINHVIEN";
            SqlDataAdapter adapter = new SqlDataAdapter(sQuery, con);

            DataSet ds = new DataSet();

            adapter.Fill(ds, "SinhVien");

            dataGridView1.DataSource = ds.Tables["SinhVien"];
            con.Close();
        }

        private void button4_Click(object sender, EventArgs e)
        {
            //Làm trống ô nhập
            textBox1.Text = "";
            textBox2.Text = "";
            textBox3.Text = "";
            textBox4.Text = "";
            textBox5.Text = "";
            textBox6.Text = "";
            comboBox3.Text = "";
            comboBox1.Text = "";
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

        private void button5_Click(object sender, EventArgs e)
        {
            SqlConnection con = new SqlConnection(sCon);
            try
            {
                con.Open();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Xảy ra lỗi trong quá trình kết nối DB5!");
            }
            string sMaSV = textBox7.Text;
            string sQuery = "select *from SINHVIEN where MaSV=@MaSV";
            SqlDataAdapter adapter = new SqlDataAdapter(sQuery, con);
            SqlCommand cmd = new SqlCommand(sQuery, con);
            cmd.Parameters.AddWithValue("@MaSV", sMaSV);
            SqlDataReader dr = cmd.ExecuteReader();
            DataTable dt = new DataTable();
            dt.Load(dr);
            dataGridView1.DataSource = dt;
        }

        private void dataGridView1_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            textBox1.Text = dataGridView1.Rows[e.RowIndex].Cells["MaSV"].Value.ToString();
            textBox2.Text = dataGridView1.Rows[e.RowIndex].Cells["HoTen"].Value.ToString();
            textBox3.Text = dataGridView1.Rows[e.RowIndex].Cells["DienThoai"].Value.ToString();
            textBox4.Text = dataGridView1.Rows[e.RowIndex].Cells["DiaChi_PhuongXa"].Value.ToString();
            textBox5.Text = dataGridView1.Rows[e.RowIndex].Cells["DiaChi_QuanHuyen"].Value.ToString();
            textBox6.Text = dataGridView1.Rows[e.RowIndex].Cells["DiaChi_TinhThanhPho"].Value.ToString();
            comboBox3.Text = dataGridView1.Rows[e.RowIndex].Cells["MaLop"].Value.ToString();
            comboBox1.Text = dataGridView1.Rows[e.RowIndex].Cells["GioiTinh"].Value.ToString();
            dateTimePicker1.Value = Convert.ToDateTime(dataGridView1.Rows[e.RowIndex].Cells["NgaySinh"].Value);
            textBox1.Enabled = false;
        }
 
    }
}
