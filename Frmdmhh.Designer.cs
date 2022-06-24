
namespace lopPTUD2022
{
    partial class Frmdmhh
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle3 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle4 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle5 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle6 = new System.Windows.Forms.DataGridViewCellStyle();
            this.grdData = new System.Windows.Forms.DataGridView();
            this.manhom = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.MaHH = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.TenHH = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dvt = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.DGvnd = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.sanxuat = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.label1 = new System.Windows.Forms.Label();
            this.txtmanhom = new System.Windows.Forms.TextBox();
            this.txtmaHH = new System.Windows.Forms.TextBox();
            this.txttenHH = new System.Windows.Forms.TextBox();
            this.txtdvt = new System.Windows.Forms.TextBox();
            this.txtsanxuat = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.txtDGvnd = new System.Windows.Forms.TextBox();
            this.label7 = new System.Windows.Forms.Label();
            this.button1 = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.button3 = new System.Windows.Forms.Button();
            this.button4 = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.grdData)).BeginInit();
            this.SuspendLayout();
            // 
            // grdData
            // 
            this.grdData.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.grdData.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.manhom,
            this.MaHH,
            this.TenHH,
            this.dvt,
            this.DGvnd,
            this.sanxuat});
            this.grdData.Location = new System.Drawing.Point(29, 55);
            this.grdData.Name = "grdData";
            this.grdData.Size = new System.Drawing.Size(594, 328);
            this.grdData.TabIndex = 0;
            this.grdData.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.grdData_CellContentClick);
            // 
            // manhom
            // 
            this.manhom.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.DisplayedCells;
            this.manhom.DataPropertyName = "MaNhom";
            dataGridViewCellStyle1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.manhom.DefaultCellStyle = dataGridViewCellStyle1;
            this.manhom.HeaderText = "Nhóm hàng";
            this.manhom.Name = "manhom";
            this.manhom.Width = 87;
            // 
            // MaHH
            // 
            this.MaHH.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.DisplayedCells;
            this.MaHH.DataPropertyName = "MaHH";
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.MaHH.DefaultCellStyle = dataGridViewCellStyle2;
            this.MaHH.HeaderText = "Mã Hàng";
            this.MaHH.Name = "MaHH";
            this.MaHH.Width = 76;
            // 
            // TenHH
            // 
            this.TenHH.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.DisplayedCells;
            this.TenHH.DataPropertyName = "TenHH";
            dataGridViewCellStyle3.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.TenHH.DefaultCellStyle = dataGridViewCellStyle3;
            this.TenHH.HeaderText = "Tên Hàng ";
            this.TenHH.Name = "TenHH";
            this.TenHH.Width = 83;
            // 
            // dvt
            // 
            this.dvt.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.DisplayedCells;
            this.dvt.DataPropertyName = "dvt";
            dataGridViewCellStyle4.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle4.Format = "C0";
            dataGridViewCellStyle4.NullValue = null;
            this.dvt.DefaultCellStyle = dataGridViewCellStyle4;
            this.dvt.HeaderText = "Đơn vị tính";
            this.dvt.Name = "dvt";
            this.dvt.Width = 85;
            // 
            // DGvnd
            // 
            this.DGvnd.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.DisplayedCells;
            this.DGvnd.DataPropertyName = "DGvnd";
            dataGridViewCellStyle5.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleRight;
            dataGridViewCellStyle5.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle5.Format = "N0";
            dataGridViewCellStyle5.NullValue = null;
            this.DGvnd.DefaultCellStyle = dataGridViewCellStyle5;
            this.DGvnd.HeaderText = "Đơn giá";
            this.DGvnd.Name = "DGvnd";
            this.DGvnd.Width = 69;
            // 
            // sanxuat
            // 
            this.sanxuat.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.DisplayedCells;
            this.sanxuat.DataPropertyName = "sanxuat";
            dataGridViewCellStyle6.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.sanxuat.DefaultCellStyle = dataGridViewCellStyle6;
            this.sanxuat.HeaderText = "Nước sản xuất";
            this.sanxuat.Name = "sanxuat";
            this.sanxuat.Width = 101;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.Blue;
            this.label1.Location = new System.Drawing.Point(33, 26);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(279, 26);
            this.label1.TabIndex = 1;
            this.label1.Text = "Quản lí danh mục hàng hóa";
            this.label1.Click += new System.EventHandler(this.label1_Click);
            // 
            // txtmanhom
            // 
            this.txtmanhom.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtmanhom.Location = new System.Drawing.Point(701, 55);
            this.txtmanhom.Name = "txtmanhom";
            this.txtmanhom.Size = new System.Drawing.Size(211, 26);
            this.txtmanhom.TabIndex = 2;
            this.txtmanhom.TextChanged += new System.EventHandler(this.textBox1_TextChanged);
            // 
            // txtmaHH
            // 
            this.txtmaHH.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtmaHH.Location = new System.Drawing.Point(701, 112);
            this.txtmaHH.Name = "txtmaHH";
            this.txtmaHH.Size = new System.Drawing.Size(211, 26);
            this.txtmaHH.TabIndex = 3;
            // 
            // txttenHH
            // 
            this.txttenHH.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txttenHH.Location = new System.Drawing.Point(701, 169);
            this.txttenHH.Name = "txttenHH";
            this.txttenHH.Size = new System.Drawing.Size(211, 26);
            this.txttenHH.TabIndex = 4;
            // 
            // txtdvt
            // 
            this.txtdvt.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtdvt.Location = new System.Drawing.Point(701, 226);
            this.txtdvt.Name = "txtdvt";
            this.txtdvt.Size = new System.Drawing.Size(211, 26);
            this.txtdvt.TabIndex = 5;
            // 
            // txtsanxuat
            // 
            this.txtsanxuat.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtsanxuat.Location = new System.Drawing.Point(701, 340);
            this.txtsanxuat.Name = "txtsanxuat";
            this.txtsanxuat.Size = new System.Drawing.Size(211, 26);
            this.txtsanxuat.TabIndex = 6;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(642, 63);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(53, 13);
            this.label2.TabIndex = 7;
            this.label2.Text = "Mã Nhóm";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(646, 120);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(49, 13);
            this.label3.TabIndex = 8;
            this.label3.Text = "Mã hàng";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(642, 182);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(53, 13);
            this.label4.TabIndex = 9;
            this.label4.Text = "Tên hàng";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(635, 234);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(60, 13);
            this.label5.TabIndex = 10;
            this.label5.Text = "Đơn vị tính";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(619, 348);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(76, 13);
            this.label6.TabIndex = 11;
            this.label6.Text = "Nước sản xuất";
            // 
            // txtDGvnd
            // 
            this.txtDGvnd.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtDGvnd.Location = new System.Drawing.Point(701, 283);
            this.txtDGvnd.Name = "txtDGvnd";
            this.txtDGvnd.Size = new System.Drawing.Size(200, 26);
            this.txtDGvnd.TabIndex = 12;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(642, 291);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(44, 13);
            this.label7.TabIndex = 13;
            this.label7.Text = "Đơn giá";
            // 
            // button1
            // 
            this.button1.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button1.Location = new System.Drawing.Point(59, 398);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(75, 34);
            this.button1.TabIndex = 14;
            this.button1.Text = "Đầu";
            this.button1.UseVisualStyleBackColor = true;
            // 
            // button2
            // 
            this.button2.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button2.Location = new System.Drawing.Point(192, 398);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(75, 34);
            this.button2.TabIndex = 15;
            this.button2.Text = "Trước";
            this.button2.UseVisualStyleBackColor = true;
            // 
            // button3
            // 
            this.button3.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button3.Location = new System.Drawing.Point(361, 398);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(75, 34);
            this.button3.TabIndex = 16;
            this.button3.Text = "Sau ";
            this.button3.UseVisualStyleBackColor = true;
            // 
            // button4
            // 
            this.button4.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button4.Location = new System.Drawing.Point(520, 398);
            this.button4.Name = "button4";
            this.button4.Size = new System.Drawing.Size(75, 34);
            this.button4.TabIndex = 17;
            this.button4.Text = "Cuối";
            this.button4.UseVisualStyleBackColor = true;
            // 
            // Frmdmhh
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(913, 450);
            this.Controls.Add(this.button4);
            this.Controls.Add(this.button3);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.txtDGvnd);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.txtsanxuat);
            this.Controls.Add(this.txtdvt);
            this.Controls.Add(this.txttenHH);
            this.Controls.Add(this.txtmaHH);
            this.Controls.Add(this.txtmanhom);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.grdData);
            this.Name = "Frmdmhh";
            this.Text = "Frmdmhh";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.Load += new System.EventHandler(this.Frmdmhh_Load);
            ((System.ComponentModel.ISupportInitialize)(this.grdData)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView grdData;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.DataGridViewTextBoxColumn manhom;
        private System.Windows.Forms.DataGridViewTextBoxColumn MaHH;
        private System.Windows.Forms.DataGridViewTextBoxColumn TenHH;
        private System.Windows.Forms.DataGridViewTextBoxColumn dvt;
        private System.Windows.Forms.DataGridViewTextBoxColumn DGvnd;
        private System.Windows.Forms.DataGridViewTextBoxColumn sanxuat;
        private System.Windows.Forms.TextBox txtmanhom;
        private System.Windows.Forms.TextBox txtmaHH;
        private System.Windows.Forms.TextBox txttenHH;
        private System.Windows.Forms.TextBox txtdvt;
        private System.Windows.Forms.TextBox txtsanxuat;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.TextBox txtDGvnd;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Button button3;
        private System.Windows.Forms.Button button4;
    }
}