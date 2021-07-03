namespace HTQLHSSV.Forms
{
    partial class ThongKe
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            this.panel1 = new System.Windows.Forms.Panel();
            this.txtTTP = new System.Windows.Forms.ComboBox();
            this.txtTK = new System.Windows.Forms.ComboBox();
            this.txtML = new System.Windows.Forms.ComboBox();
            this.btnTTP = new System.Windows.Forms.Button();
            this.btnQH = new System.Windows.Forms.Button();
            this.btnPX = new System.Windows.Forms.Button();
            this.btnTKK = new System.Windows.Forms.Button();
            this.btnTKL = new System.Windows.Forms.Button();
            this.txtQH = new System.Windows.Forms.TextBox();
            this.txtPX = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.panel2 = new System.Windows.Forms.Panel();
            this.reportViewer1 = new Microsoft.Reporting.WinForms.ReportViewer();
            this.qLHSSVDataSet2 = new HTQLHSSV.QLHSSVDataSet2();
            this.sINHVIENBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.sINHVIENTableAdapter = new HTQLHSSV.QLHSSVDataSet2TableAdapters.SINHVIENTableAdapter();
            this.panel1.SuspendLayout();
            this.panel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.qLHSSVDataSet2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.sINHVIENBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.txtTTP);
            this.panel1.Controls.Add(this.txtTK);
            this.panel1.Controls.Add(this.txtML);
            this.panel1.Controls.Add(this.btnTTP);
            this.panel1.Controls.Add(this.btnQH);
            this.panel1.Controls.Add(this.btnPX);
            this.panel1.Controls.Add(this.btnTKK);
            this.panel1.Controls.Add(this.btnTKL);
            this.panel1.Controls.Add(this.txtQH);
            this.panel1.Controls.Add(this.txtPX);
            this.panel1.Controls.Add(this.label5);
            this.panel1.Controls.Add(this.label4);
            this.panel1.Controls.Add(this.label3);
            this.panel1.Controls.Add(this.label2);
            this.panel1.Controls.Add(this.label1);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel1.Font = new System.Drawing.Font("Segoe UI", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(964, 188);
            this.panel1.TabIndex = 1;
            // 
            // txtTTP
            // 
            this.txtTTP.FormattingEnabled = true;
            this.txtTTP.Location = new System.Drawing.Point(620, 133);
            this.txtTTP.Name = "txtTTP";
            this.txtTTP.Size = new System.Drawing.Size(190, 36);
            this.txtTTP.TabIndex = 13;
            this.txtTTP.SelectedIndexChanged += new System.EventHandler(this.txtTTP_SelectedIndexChanged);
            // 
            // txtTK
            // 
            this.txtTK.FormattingEnabled = true;
            this.txtTK.Items.AddRange(new object[] {
            "Kinh doanh quốc tế",
            "Quản trị kinh doanh",
            "Du lịch",
            "Kinh tế",
            "Thống kê - Tin học",
            "Kế toán",
            "Ngân hàng",
            "Thương mại điện tử",
            "Lý luận chính trị",
            "Marketing",
            "Luật",
            "Tài chính"});
            this.txtTK.Location = new System.Drawing.Point(124, 84);
            this.txtTK.Name = "txtTK";
            this.txtTK.Size = new System.Drawing.Size(190, 36);
            this.txtTK.TabIndex = 12;
            // 
            // txtML
            // 
            this.txtML.FormattingEnabled = true;
            this.txtML.Items.AddRange(new object[] {
            "45K01  ",
            "45K02  ",
            "45K03  ",
            "45K04  ",
            "45K05  ",
            "45K06  ",
            "45K07  ",
            "45K08  ",
            "45K09  ",
            "45K12  ",
            "45K13  ",
            "45K14  ",
            "45K15  ",
            "45K16  ",
            "45K17  ",
            "45K18  ",
            "45K19  ",
            "45K20  ",
            "45K21  ",
            "45K22  ",
            "45K23  ",
            "45K25  ",
            "45K26  ",
            "45K27  ",
            "45K28  ",
            "45K29  "});
            this.txtML.Location = new System.Drawing.Point(124, 29);
            this.txtML.Name = "txtML";
            this.txtML.Size = new System.Drawing.Size(190, 36);
            this.txtML.TabIndex = 11;
            // 
            // btnTTP
            // 
            this.btnTTP.Location = new System.Drawing.Point(816, 133);
            this.btnTTP.Name = "btnTTP";
            this.btnTTP.Size = new System.Drawing.Size(105, 40);
            this.btnTTP.TabIndex = 10;
            this.btnTTP.Text = "Thống kê";
            this.btnTTP.UseVisualStyleBackColor = true;
            this.btnTTP.Click += new System.EventHandler(this.btnTTP_Click);
            // 
            // btnQH
            // 
            this.btnQH.Location = new System.Drawing.Point(816, 77);
            this.btnQH.Name = "btnQH";
            this.btnQH.Size = new System.Drawing.Size(105, 40);
            this.btnQH.TabIndex = 8;
            this.btnQH.Text = "Thống kê";
            this.btnQH.UseVisualStyleBackColor = true;
            this.btnQH.Click += new System.EventHandler(this.btnQH_Click);
            // 
            // btnPX
            // 
            this.btnPX.Location = new System.Drawing.Point(816, 25);
            this.btnPX.Name = "btnPX";
            this.btnPX.Size = new System.Drawing.Size(105, 40);
            this.btnPX.TabIndex = 6;
            this.btnPX.Text = "Thống kê";
            this.btnPX.UseVisualStyleBackColor = true;
            this.btnPX.Click += new System.EventHandler(this.btnPX_Click);
            // 
            // btnTKK
            // 
            this.btnTKK.Location = new System.Drawing.Point(320, 82);
            this.btnTKK.Name = "btnTKK";
            this.btnTKK.Size = new System.Drawing.Size(105, 40);
            this.btnTKK.TabIndex = 4;
            this.btnTKK.Text = "Thống kê";
            this.btnTKK.UseVisualStyleBackColor = true;
            this.btnTKK.Click += new System.EventHandler(this.btnTKK_Click);
            // 
            // btnTKL
            // 
            this.btnTKL.Location = new System.Drawing.Point(320, 27);
            this.btnTKL.Name = "btnTKL";
            this.btnTKL.Size = new System.Drawing.Size(105, 40);
            this.btnTKL.TabIndex = 2;
            this.btnTKL.Text = "Thống kê";
            this.btnTKL.UseVisualStyleBackColor = true;
            this.btnTKL.Click += new System.EventHandler(this.btnTKL_Click);
            // 
            // txtQH
            // 
            this.txtQH.Location = new System.Drawing.Point(620, 84);
            this.txtQH.Name = "txtQH";
            this.txtQH.Size = new System.Drawing.Size(190, 34);
            this.txtQH.TabIndex = 7;
            // 
            // txtPX
            // 
            this.txtPX.Location = new System.Drawing.Point(620, 29);
            this.txtPX.Name = "txtPX";
            this.txtPX.Size = new System.Drawing.Size(190, 34);
            this.txtPX.TabIndex = 5;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Segoe UI", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(472, 136);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(148, 28);
            this.label5.TabIndex = 0;
            this.label5.Text = "Tỉnh thành phố:";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Segoe UI", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(472, 81);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(127, 28);
            this.label4.TabIndex = 0;
            this.label4.Text = "Quận/Huyện:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Segoe UI", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(472, 29);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(115, 28);
            this.label3.TabIndex = 0;
            this.label3.Text = "Phường/Xã:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Segoe UI", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(30, 87);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(93, 28);
            this.label2.TabIndex = 0;
            this.label2.Text = "Tên khoa:";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Segoe UI", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(30, 32);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(78, 28);
            this.label1.TabIndex = 0;
            this.label1.Text = "Mã lớp:";
            // 
            // panel2
            // 
            this.panel2.Controls.Add(this.reportViewer1);
            this.panel2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel2.Location = new System.Drawing.Point(0, 188);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(964, 491);
            this.panel2.TabIndex = 2;
            // 
            // reportViewer1
            // 
            this.reportViewer1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.reportViewer1.LocalReport.ReportEmbeddedResource = "HTQLHSSV.Report1.rdlc";
            this.reportViewer1.Location = new System.Drawing.Point(0, 0);
            this.reportViewer1.Name = "reportViewer1";
            this.reportViewer1.Size = new System.Drawing.Size(964, 491);
            this.reportViewer1.TabIndex = 0;
            // 
            // qLHSSVDataSet2
            // 
            this.qLHSSVDataSet2.DataSetName = "QLHSSVDataSet2";
            this.qLHSSVDataSet2.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // sINHVIENBindingSource
            // 
            this.sINHVIENBindingSource.DataMember = "SINHVIEN";
            this.sINHVIENBindingSource.DataSource = this.qLHSSVDataSet2;
            // 
            // sINHVIENTableAdapter
            // 
            this.sINHVIENTableAdapter.ClearBeforeFill = true;
            // 
            // ThongKe
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(964, 679);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.panel1);
            this.Name = "ThongKe";
            this.Text = "ThongKe";
            this.Load += new System.EventHandler(this.ThongKe_Load);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.panel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.qLHSSVDataSet2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.sINHVIENBindingSource)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Button btnTTP;
        private System.Windows.Forms.Button btnQH;
        private System.Windows.Forms.Button btnPX;
        private System.Windows.Forms.Button btnTKK;
        private System.Windows.Forms.Button btnTKL;
        private System.Windows.Forms.TextBox txtQH;
        private System.Windows.Forms.TextBox txtPX;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Panel panel2;
        private Microsoft.Reporting.WinForms.ReportViewer reportViewer1;
        private System.Windows.Forms.ComboBox txtTK;
        private System.Windows.Forms.ComboBox txtML;
        private System.Windows.Forms.ComboBox txtTTP;
        private QLHSSVDataSet2 qLHSSVDataSet2;
        private System.Windows.Forms.BindingSource sINHVIENBindingSource;
        private QLHSSVDataSet2TableAdapters.SINHVIENTableAdapter sINHVIENTableAdapter;
    }
}