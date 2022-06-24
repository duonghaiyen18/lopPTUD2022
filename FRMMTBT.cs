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
    public partial class FRMMTBT : Form
    {
        float dt1, dt2;
        string pheptinh;
        public FRMMTBT()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            hienthi1.Text = hienthi1.Text + "7";
        }

        private void FRMMTBT_Load(object sender, EventArgs e)
        {

        }

        private void button13_Click(object sender, EventArgs e)
        {
            if(pheptinh=="cộng")
            {
                dt2 = dt1 + float.Parse(hienthi1.Text);
                hienthi2.Text = dt1.ToString() + "+" + float.Parse(hienthi1.Text) + "=";
                hienthi1.Text = dt2.ToString();

            }
            if (pheptinh == "trừ")
            {
                dt2 = dt1 - float.Parse(hienthi1.Text);
                hienthi2.Text = dt1.ToString() + "-" + float.Parse(hienthi1.Text) + "=";
                hienthi1.Text = dt2.ToString();

            }
            if (pheptinh == "nhân")
            {
                dt2 = dt1 * float.Parse(hienthi1.Text);
                hienthi2.Text = dt1.ToString() + "*" + float.Parse(hienthi1.Text) + "=";
                hienthi1.Text = dt2.ToString();

            }
            if (pheptinh == "chia")
            {
                if(float.Parse(hienthi1.Text) ==0)
                {
                    hienthi1.Text = "Không chia được";
                }
                else
                {
                    dt2 = dt1 / float.Parse(hienthi1.Text);
                    hienthi2.Text = dt1.ToString() + "/" + float.Parse(hienthi1.Text) + "=";
                    hienthi1.Text = dt2.ToString();
                }
                

            }
        }

        private void button15_Click(object sender, EventArgs e)
        {
            hienthi1.Text = hienthi1.Text + "0";

        }

        private void button12_Click(object sender, EventArgs e)
        {
            hienthi1.Text = hienthi1.Text + "1";
        }

        private void button11_Click(object sender, EventArgs e)
        {
            hienthi1.Text = hienthi1.Text + "2";
        }

        private void button10_Click(object sender, EventArgs e)
        {
            hienthi1.Text = hienthi1.Text + "3";
        }

        private void button8_Click(object sender, EventArgs e)
        {
            hienthi1.Text = hienthi1.Text + "4";
        }

        private void button7_Click(object sender, EventArgs e)
        {
            hienthi1.Text = hienthi1.Text + "5";
        }

        private void button6_Click(object sender, EventArgs e)
        {
            hienthi1.Text = hienthi1.Text + "6";
        }

        private void button2_Click(object sender, EventArgs e)
        {
            hienthi1.Text = hienthi1.Text + "8";
        }

        private void button3_Click(object sender, EventArgs e)
        {
            hienthi1.Text = hienthi1.Text + "9";
        }

        private void button14_Click(object sender, EventArgs e)
        {
            hienthi1.Text = hienthi1.Text + ".";
        }

        private void button9_Click(object sender, EventArgs e)
        {
            pheptinh = "cộng";
            dt1 = float.Parse(hienthi1.Text);
            hienthi1.Clear();
        }

        private void button5_Click(object sender, EventArgs e)
        {
            pheptinh = "trừ";
            dt1 = float.Parse(hienthi1.Text);
            hienthi1.Clear();
        }

        private void button4_Click(object sender, EventArgs e)
        {
            pheptinh = "nhân";
            dt1 = float.Parse(hienthi1.Text);
            hienthi1.Clear();
        }

        private void button17_Click(object sender, EventArgs e)
        {
           
                pheptinh = "chia";
                dt1 = float.Parse(hienthi1.Text);
                hienthi1.Clear();
            
        }

        private void button18_Click(object sender, EventArgs e)
        {
            hienthi1.Clear();
            hienthi2.Clear();
            
        }
    }
}
