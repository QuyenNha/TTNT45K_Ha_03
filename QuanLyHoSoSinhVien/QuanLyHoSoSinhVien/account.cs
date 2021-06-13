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
    public partial class account : Form
    {
        string sCon = "Data Source=DESKTOP-EFQDFTG\\TDH;Initial Catalog=QLHSSV;Integrated Security=True";
        public account()
        {
            InitializeComponent();
        }
        private void buttonexit_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void buttonupdate_Click(object sender, EventArgs e)
        {
            SqlConnection con = new SqlConnection(sCon);
            string sTaiKhoan = textBoxusername.Text;
            string sMatkhaucu = textboxpass1.Text;
            string sMatkhau = textboxpass3.Text;
            //
            string sql = "select *from TAIKHOAN where TaiKhoan ='" + sTaiKhoan + "' and MatKhau='" + sMatkhaucu + "'";
            SqlCommand cmd1 = new SqlCommand(sql, con);
            SqlDataReader dta = cmd1.ExecuteReader();
            //
            //Bước 1
            if (textBoxusername.Text == "")
                MessageBox.Show("Chưa nhập tài khoản hiện tại");
            else if (textboxpass1.Text == "")
                MessageBox.Show("Chưa nhập mật khẩu hiện tại");
            else if (textboxpass2.Text == "")
                MessageBox.Show("Chưa nhập mật khẩu mới");
            else if (textboxpass2.Text != textboxpass3.Text)
                MessageBox.Show("Mật khẩu mới không trùng khớp");
            else if (dta.Read() == false)
            {
                MessageBox.Show("Sai tên đăng nhập hoặc mật khẩu!");
            }
            
            }
        }
    }


