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

            //Bước 2 - lấy dữ liệu 
            string sQuery = "Select * from SINHVIEN";
            SqlDataAdapter adapter = new SqlDataAdapter(sQuery, con);

            DataSet ds = new DataSet();

            adapter.Fill(ds, "SinhVien");
            //B3 - Sửa tên cột
            dataGridView1.DataSource = ds.Tables["SinhVien"];
            dataGridView1.Columns[0].HeaderText = "Mã sinh viên";
            dataGridView1.Columns[1].HeaderText = "Họ tên";
            dataGridView1.Columns[2].HeaderText = "Ngày sinh";
            dataGridView1.Columns[3].HeaderText = "Giới tính";
            dataGridView1.Columns[4].HeaderText = "Phường/Xã";
            dataGridView1.Columns[5].HeaderText = "Quận/Huyện";
            dataGridView1.Columns[6].HeaderText = "Tỉnh/Thành phố";
            dataGridView1.Columns[7].HeaderText = "Số điện thoại";
            dataGridView1.Columns[8].HeaderText = "Mã lớp";
            //B4 - Chỉnh size cột
            dataGridView1.Columns[0].Width = 80;
            dataGridView1.Columns[1].Width = 120;
            dataGridView1.Columns[2].Width = 65;
            dataGridView1.Columns[3].Width = 50;
            dataGridView1.Columns[4].Width = 90;
            dataGridView1.Columns[5].Width = 90;
            dataGridView1.Columns[6].Width = 90;
            dataGridView1.Columns[7].Width = 75;
            dataGridView1.Columns[8].Width = 50;

            // Lấy dữ liệu cho combobox mã lớp
            string sql = "Select * from LOPSH";
            comboBox3.DataSource = Database.Singleton.LoadData(sql);
            comboBox3.DisplayMember = "MaLop";

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
                    MessageBox.Show("Thêm mới thành công!", "THÔNG BÁO", MessageBoxButtons.OK);
                }
                catch (Exception ex)
                {
                    if (textBox1.TextLength >12)
                        MessageBox.Show("Mã sinh viên không được lớn hơn 12 số!", "THÔNG BÁO", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    else
                        MessageBox.Show("Mã sinh viên đã tồn tại!", "THÔNG BÁO", MessageBoxButtons.OK, MessageBoxIcon.Error);
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
            string sQuery2 = "Update SINHVIEN Set HoTen = @HoTen, NgaySinh = @NgaySinh, GioiTinh = @GioiTinh, DiaChi_PhuongXa = @DiaChi_PhuongXa, DiaChi_QuanHuyen = @DiaChi_QuanHuyen,DiaChi_TinhThanhPho=@DiaChi_TinhThanhPho, DienThoai=@DienThoai, MaLop=@MaLop Where MaSV = @MaSV";

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
                MessageBox.Show("Sửa thành công!", "THÔNG BÁO", MessageBoxButtons.OK);
            }
            catch (Exception ex)
            {
                MessageBox.Show("Lỗi nhập dữ liệu: " + ex.Message, "THÔNG BÁO", MessageBoxButtons.OK, MessageBoxIcon.Error);
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
                MessageBox.Show("Xóa thành công!", "THÔNG BÁO", MessageBoxButtons.OK);
            }
            catch (Exception ex)
            {
                MessageBox.Show("Xóa thất bại!", "THÔNG BÁO", MessageBoxButtons.OK,MessageBoxIcon.Error);
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
