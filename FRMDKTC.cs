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
    public partial class FRMDKTC : Form
    {
        public FRMDKTC()
        {
            InitializeComponent();
        }

        private void FRMDKTC_Load(object sender, EventArgs e)
        {

        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void textBox1_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (((e.KeyChar >= '0') && (e.KeyChar <= '9')) || (e.KeyChar == '-') || (e.KeyChar == '.') ||(Convert.ToInt32(e.KeyChar) == 8) || (Convert.ToInt32(e.KeyChar) == 13 ))
                    e.Handled = false;
            else e.Handled = true;
        }

        private void button2_Click(object sender, EventArgs e)
        {
            FRMGĐKTC Frm = new FRMGĐKTC();
            Frm.Show();
            this.Hide();
        }
    }
}
