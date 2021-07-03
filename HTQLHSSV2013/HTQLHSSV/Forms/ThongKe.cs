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
using Microsoft.Reporting.WinForms;

namespace HTQLHSSV.Forms
{
    public partial class ThongKe : Form
    {
        public ThongKe()
        {
            InitializeComponent();
        }

        private void ThongKe_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'qLHSSVDataSet2.SINHVIEN' table. You can move, or remove it, as needed.
            this.sINHVIENTableAdapter.Fill(this.qLHSSVDataSet2.SINHVIEN);
            this.reportViewer1.RefreshReport();

            //
            string sql = "Select distinct DiaChi_TinhThanhPho from SINHVIEN";
            txtTTP.DataSource = Database.Singleton.LoadData(sql);
            txtTTP.DisplayMember = "DiaChi_TinhThanhPho";

        }

        private void btnTKL_Click(object sender, EventArgs e)
        {
            SqlConnection con = new SqlConnection();
            con.ConnectionString = Properties.Settings.Default.QLHSSVConnectionString;
            SqlCommand cmd = new SqlCommand();
            cmd.CommandText = "THONGKE";
            cmd.CommandType = CommandType.StoredProcedure;
            cmd.Connection = con;
            cmd.Parameters.Add(new SqlParameter("@MaLop", txtML.Text));

            DataSet ds = new DataSet();
            SqlDataAdapter da = new SqlDataAdapter(cmd);
            da.Fill(ds);

            reportViewer1.ProcessingMode = ProcessingMode.Local;
            reportViewer1.LocalReport.ReportPath = "Report1.rdlc";

            ReportDataSource rds = new ReportDataSource();
            rds.Name = "DataSet1";
            rds.Value = ds.Tables[0];

            reportViewer1.LocalReport.DataSources.Clear();
            reportViewer1.LocalReport.DataSources.Add(rds);
            reportViewer1.RefreshReport();
        }

        private void btnTKK_Click(object sender, EventArgs e)
        {
            SqlConnection con = new SqlConnection();
            con.ConnectionString = Properties.Settings.Default.QLHSSVConnectionString;
            SqlCommand cmd = new SqlCommand();
            cmd.CommandText = "THONGKE2";
            cmd.CommandType = CommandType.StoredProcedure;
            cmd.Connection = con;
            cmd.Parameters.Add(new SqlParameter("@TenKhoa", txtTKe.Text));

            DataSet ds = new DataSet();
            SqlDataAdapter da = new SqlDataAdapter(cmd);
            da.Fill(ds);

            reportViewer1.ProcessingMode = ProcessingMode.Local;
            reportViewer1.LocalReport.ReportPath = "Report2.rdlc";

            ReportDataSource rds = new ReportDataSource();
            rds.Name = "DataSet2";
            rds.Value = ds.Tables[0];

            reportViewer1.LocalReport.DataSources.Clear();
            reportViewer1.LocalReport.DataSources.Add(rds);
            reportViewer1.RefreshReport();
        }

        private void btnPX_Click(object sender, EventArgs e)
        {
            SqlConnection con = new SqlConnection();
            con.ConnectionString = Properties.Settings.Default.QLHSSVConnectionString;
            SqlCommand cmd = new SqlCommand();
            cmd.CommandText = "THONGKE3";
            cmd.CommandType = CommandType.StoredProcedure;
            cmd.Connection = con;
            cmd.Parameters.Add(new SqlParameter("@DiaChi_PhuongXa", txtPX.Text));

            DataSet ds = new DataSet();
            SqlDataAdapter da = new SqlDataAdapter(cmd);
            da.Fill(ds);

            reportViewer1.ProcessingMode = ProcessingMode.Local;
            reportViewer1.LocalReport.ReportPath = "Report3.rdlc";

            ReportDataSource rds = new ReportDataSource();
            rds.Name = "DataSet3";
            rds.Value = ds.Tables[0];

            reportViewer1.LocalReport.DataSources.Clear();
            reportViewer1.LocalReport.DataSources.Add(rds);
            reportViewer1.RefreshReport();
        }

        private void btnQH_Click(object sender, EventArgs e)
        {
            SqlConnection con = new SqlConnection();
            con.ConnectionString = Properties.Settings.Default.QLHSSVConnectionString;
            SqlCommand cmd = new SqlCommand();
            cmd.CommandText = "THONGKE4";
            cmd.CommandType = CommandType.StoredProcedure;
            cmd.Connection = con;
            cmd.Parameters.Add(new SqlParameter("@DiaChi_QuanHuyen", txtQH.Text));

            DataSet ds = new DataSet();
            SqlDataAdapter da = new SqlDataAdapter(cmd);
            da.Fill(ds);

            reportViewer1.ProcessingMode = ProcessingMode.Local;
            reportViewer1.LocalReport.ReportPath = "Report4.rdlc";

            ReportDataSource rds = new ReportDataSource();
            rds.Name = "DataSet4";
            rds.Value = ds.Tables[0];

            reportViewer1.LocalReport.DataSources.Clear();
            reportViewer1.LocalReport.DataSources.Add(rds);
            reportViewer1.RefreshReport();
        }

        private void btnTTP_Click(object sender, EventArgs e)
        {
            SqlConnection con = new SqlConnection();
            con.ConnectionString = Properties.Settings.Default.QLHSSVConnectionString;
            SqlCommand cmd = new SqlCommand();
            cmd.CommandText = "THONGKE5";
            cmd.CommandType = CommandType.StoredProcedure;
            cmd.Connection = con;
            cmd.Parameters.Add(new SqlParameter("@DiaChi_TinhThanhPho", txtTTP.Text));

            DataSet ds = new DataSet();
            SqlDataAdapter da = new SqlDataAdapter(cmd);
            da.Fill(ds);

            reportViewer1.ProcessingMode = ProcessingMode.Local;
            reportViewer1.LocalReport.ReportPath = "Report5.rdlc";

            ReportDataSource rds = new ReportDataSource();
            rds.Name = "DataSet5";
            rds.Value = ds.Tables[0];

            reportViewer1.LocalReport.DataSources.Clear();
            reportViewer1.LocalReport.DataSources.Add(rds);
            reportViewer1.RefreshReport();
        }

        private void txtTTP_SelectedIndexChanged(object sender, EventArgs e)
        {
            
        }
    }
}
