using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace lopPTUD2022
{
    public partial class FRMMain : Form
    {
        public FRMMain()
        {
            InitializeComponent();
        }

        private void nhậpHóaĐơnBánHàngToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }

        private void kếtThúcToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void tínhTổngSốChắnToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Status1.Text = "Tính Tổng";
            FRMLTCB f = new FRMLTCB();
            f.ShowDialog();
            Status1.Text = "Ready!";
        }

        private void máyTínhBỏTúiToolStripMenuItem_Click(object sender, EventArgs e)
        {
            FRMMTBT f = new FRMMTBT();
            f.Show();
        }

        private void kếtThúcToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void đăngNhậpLạiToolStripMenuItem_Click(object sender, EventArgs e)
        {
            FRMDKTC f = new FRMDKTC();
            f.Show();
        }

        private void toolStripButton3_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void toolStripButton1_Click(object sender, EventArgs e)
        {
            FRMDKTC f = new FRMDKTC();
            f.Show();
        }

        private void đăngNhậpHệThốngToolStripMenuItem_Click(object sender, EventArgs e)
        {
            FRMDKTC f = new FRMDKTC();
            f.Show();
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            Status1.Text = System.DateTime.Now.ToString();
        }

        private void statusStrip1_ItemClicked(object sender, ToolStripItemClickedEventArgs e)
        {

        }

        private void status2_Click(object sender, EventArgs e)
        {

        }

        private void FRMMain_Load(object sender, EventArgs e)
        {

        }
    }
}
