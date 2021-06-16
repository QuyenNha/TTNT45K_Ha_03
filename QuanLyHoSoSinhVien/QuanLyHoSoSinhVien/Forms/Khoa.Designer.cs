
namespace QuanLyHoSoSinhVien.Forms
{
    partial class Khoa
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
            this.textBox7 = new System.Windows.Forms.TextBox();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.textBox2 = new System.Windows.Forms.TextBox();
            this.button2 = new System.Windows.Forms.Button();
            this.button1 = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.button12 = new System.Windows.Forms.Button();
            this.button11 = new System.Windows.Forms.Button();
            this.button10 = new System.Windows.Forms.Button();
            this.label3 = new System.Windows.Forms.Label();
            this.textBox3 = new System.Windows.Forms.TextBox();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // textBox7
            // 
            this.textBox7.Location = new System.Drawing.Point(569, 284);
            this.textBox7.Name = "textBox7";
            this.textBox7.Size = new System.Drawing.Size(183, 23);
            this.textBox7.TabIndex = 117;
            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(222, 48);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(183, 23);
            this.textBox1.TabIndex = 97;
            // 
            // textBox2
            // 
            this.textBox2.Location = new System.Drawing.Point(222, 97);
            this.textBox2.Name = "textBox2";
            this.textBox2.Size = new System.Drawing.Size(183, 23);
            this.textBox2.TabIndex = 98;
            // 
            // button2
            // 
            this.button2.FlatAppearance.BorderSize = 0;
            this.button2.Font = new System.Drawing.Font("Segoe UI", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.button2.Location = new System.Drawing.Point(379, 262);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(101, 45);
            this.button2.TabIndex = 107;
            this.button2.Text = "Khởi tạo";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // button1
            // 
            this.button1.FlatAppearance.BorderSize = 0;
            this.button1.Font = new System.Drawing.Font("Segoe UI", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.button1.Location = new System.Drawing.Point(758, 262);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(101, 45);
            this.button1.TabIndex = 108;
            this.button1.Text = "Tìm kiếm";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Segoe UI", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label2.Location = new System.Drawing.Point(55, 97);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(78, 28);
            this.label2.TabIndex = 111;
            this.label2.Text = "Địa Chỉ:";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Segoe UI", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label1.Location = new System.Drawing.Point(55, 43);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(95, 28);
            this.label1.TabIndex = 110;
            this.label1.Text = "Tên Khoa:";
            // 
            // dataGridView1
            // 
            this.dataGridView1.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Location = new System.Drawing.Point(55, 313);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.RowTemplate.Height = 25;
            this.dataGridView1.Size = new System.Drawing.Size(804, 323);
            this.dataGridView1.TabIndex = 109;
            this.dataGridView1.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView1_CellClick);
            // 
            // button12
            // 
            this.button12.FlatAppearance.BorderSize = 0;
            this.button12.Font = new System.Drawing.Font("Segoe UI", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.button12.Location = new System.Drawing.Point(162, 262);
            this.button12.Name = "button12";
            this.button12.Size = new System.Drawing.Size(75, 45);
            this.button12.TabIndex = 106;
            this.button12.Text = "Sửa";
            this.button12.UseVisualStyleBackColor = true;
            this.button12.Click += new System.EventHandler(this.button12_Click);
            // 
            // button11
            // 
            this.button11.FlatAppearance.BorderSize = 0;
            this.button11.Font = new System.Drawing.Font("Segoe UI", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.button11.Location = new System.Drawing.Point(55, 262);
            this.button11.Name = "button11";
            this.button11.Size = new System.Drawing.Size(82, 45);
            this.button11.TabIndex = 104;
            this.button11.Text = "Thêm";
            this.button11.UseVisualStyleBackColor = true;
            this.button11.Click += new System.EventHandler(this.button11_Click);
            // 
            // button10
            // 
            this.button10.FlatAppearance.BorderSize = 0;
            this.button10.Font = new System.Drawing.Font("Segoe UI", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.button10.Location = new System.Drawing.Point(271, 262);
            this.button10.Name = "button10";
            this.button10.Size = new System.Drawing.Size(82, 45);
            this.button10.TabIndex = 105;
            this.button10.Text = "Xóa";
            this.button10.UseVisualStyleBackColor = true;
            this.button10.Click += new System.EventHandler(this.button10_Click);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Segoe UI", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label3.Location = new System.Drawing.Point(55, 157);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(109, 28);
            this.label3.TabIndex = 112;
            this.label3.Text = "Điện Thoại:";
            // 
            // textBox3
            // 
            this.textBox3.Location = new System.Drawing.Point(222, 157);
            this.textBox3.Name = "textBox3";
            this.textBox3.Size = new System.Drawing.Size(183, 23);
            this.textBox3.TabIndex = 118;
            // 
            // Khoa
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(914, 679);
            this.Controls.Add(this.textBox3);
            this.Controls.Add(this.textBox7);
            this.Controls.Add(this.textBox1);
            this.Controls.Add(this.textBox2);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.button12);
            this.Controls.Add(this.button11);
            this.Controls.Add(this.button10);
            this.Name = "Khoa";
            this.Text = "930, 718";
            this.Load += new System.EventHandler(this.Khoa_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.TextBox textBox7;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.TextBox textBox2;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.Button button12;
        private System.Windows.Forms.Button button11;
        private System.Windows.Forms.Button button10;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox textBox3;
    }
}