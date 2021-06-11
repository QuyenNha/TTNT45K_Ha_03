using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace MyApp
{
    public partial class frmCalculator : Form
    {
        Double result = 0;
        String operation = "";
            bool enter_Value = false;
        public frmCalculator()
        {
            InitializeComponent();
        }

        private void Number_Click(object sender, EventArgs e)
        {
            //Xóa số 0 ở đầu 
            

            enter_Value = false;

            //Hiển thị số
            Button b = (Button)sender;
            if (b.Text == ".")
            {
                if (!txtTinh.Text.Contains("."))
                    txtTinh.Text = txtTinh.Text + b.Text;
            }
            else
            {
                if (txtTinh.Text == "0" | (enter_Value))
                    txtTinh.Clear();
                txtTinh.Text = txtTinh.Text + b.Text;
            }
        }

        private void Operator_Click(object sender, EventArgs e)
        {
            Button b = (Button)sender;
            
            if (result != 0)
            {
                btnbang.PerformClick();
                operation = b.Text;
                lbKQ.Text = result + " " + operation;
                enter_Value = true;
            }
            else
            {
                operation = b.Text;
                result = double.Parse(txtTinh.Text);
                lbKQ.Text = result + " " + operation;
                enter_Value = true;
            }
        }

        private void C_Click(object sender, EventArgs e)
        {
            txtTinh.Text = "0";
            result = 0;
        }

        private void CE_Click(object sender, EventArgs e)
        {
            txtTinh.Text = "0";
        }

        private void btnbang_Click(object sender, EventArgs e)
        {
            switch (operation)
            {
                case "+":
                    txtTinh.Text = (result + Double.Parse(txtTinh.Text)).ToString();
                    break;
                case "-":
                    txtTinh.Text = (result - Double.Parse(txtTinh.Text)).ToString();
                    break;
                case "x":
                    txtTinh.Text = (result * Double.Parse(txtTinh.Text)).ToString();
                    break;
                case "/":
                    txtTinh.Text = (result / Double.Parse(txtTinh.Text)).ToString();
                    break;
                default:
                    break;
            }
            result = double.Parse(txtTinh.Text);
            lbKQ.Text = "";
        }

    }
}
