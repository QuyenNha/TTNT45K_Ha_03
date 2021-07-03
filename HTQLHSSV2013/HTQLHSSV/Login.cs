using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SqlClient;

namespace HTQLHSSV
{
    public partial class Login : Form
    {
        string sCon = "Data Source=DESKTOP-EFQDFTG\\TDH;Initial Catalog=QLHSSV;Integrated Security=True";
        public Login()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (this.textBox1.TextLength == 0 || this.textBox2.TextLength == 0)
            {
                MessageBox.Show("Bạn vui lòng điền đầy đủ thông tin!", "THÔNG BÁO", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }

            else
            {
                SqlConnection con = new SqlConnection(sCon);
                try
                {

                    con.Open();
                    string tk = textBox1.Text;
                    string mk = textBox2.Text;
                    string sql = "select *from TAIKHOAN where TaiKhoan ='" + tk + "' and MatKhau='" + mk + "'";
                    SqlCommand cmd = new SqlCommand(sql, con);
                    SqlDataReader dta = cmd.ExecuteReader();
                    if (dta.Read() == true)
                    {
                        MainMenu f = new MainMenu();
                        this.Hide();
                        f.ShowDialog();
                        this.Show();
                    }   
                    else
                    {
                        MessageBox.Show("Sai tên đăng nhập hoặc mật khẩu!", "THÔNG BÁO", MessageBoxButtons.OK, MessageBoxIcon.Error);
                        textBox2.Text = "";
                    }
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Xảy ra lỗi trong quá trình kết nối DB");
                }
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

    }
}
