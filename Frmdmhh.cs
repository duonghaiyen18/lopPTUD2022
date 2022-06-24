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

namespace lopPTUD2022
{
    public partial class Frmdmhh : Form
    {
        SqlConnection conn = new SqlConnection();
        SqlDataAdapter da = new SqlDataAdapter();
        SqlCommand cmd = new SqlCommand();
        DataTable dt = new DataTable();
        string sql, constr;
        int i;
        public Frmdmhh()
        {
            InitializeComponent();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void Frmdmhh_Load(object sender, EventArgs e)
        {
            constr = "Data Source=DUONGHAIYEN\\SQLEXPRESS;Initial Catalog=QLBH;Integrated Security=True";
            conn.ConnectionString = constr;
            conn.Open();
            sql = "select * from tblDMHH";
            da = new SqlDataAdapter(sql, conn);
            dt = new DataTable();
            dt.Clear();
            da.Fill(dt);
            grdData.DataSource = dt;
            NapCT();
        }

        private void grdData_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            NapCT();
        }

        private void NapCT()
        {
            i = grdData.CurrentRow.Index;
            txtmanhom.Text = grdData.Rows[i].Cells["manhom"].Value.ToString();
            txtmaHH.Text = grdData.Rows[i].Cells["maHH"].Value.ToString();
            txttenHH.Text = grdData.Rows[i].Cells["tenHH"].Value.ToString();
            txtdvt.Text = grdData.Rows[i].Cells["dvt"].Value.ToString();
            txtDGvnd.Text = grdData.Rows[i].Cells["DGvnd"].Value.ToString();
            txtsanxuat.Text = grdData.Rows[i].Cells["sanxuat"].Value.ToString();
        }
    }
}
