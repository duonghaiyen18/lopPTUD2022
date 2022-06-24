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
    public partial class FRMLTCB : Form
    {
        int n, i, T;
        public FRMLTCB()
        {
            InitializeComponent();
        }

        private void button4_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            n = Convert.ToInt16(txtN.Text);
            T = 0;
            i = 1;
            while( i<= n)
            {
                if( i%2==0 )
                {
                    T = T + i;
                }
                i++;
            }    
            lblKQ.Text = " Kết quả tính theo While là: " + Convert.ToString(T);
        }

        private void button3_Click(object sender, EventArgs e)
        {
            n = Convert.ToInt16(txtN.Text);
            T = 0;
            do
            {
                if (i % 2 == 0)
                {
                    T = T + i;
                }
                i++;
            }
            while (i <= n);
            lblKQ.Text = " Kết quả tính theo Do...While là: " + Convert.ToString(T);
        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            n = Convert.ToInt16(txtN.Text);
            T = 0;
            for(int i=1;i<=n;i++)
            {
                if(i%2== 0 )
                T = T + i;
            }
            lblKQ.Text = " Kết quả tính theo For là: " + Convert.ToString(T);
        }
    }
}
