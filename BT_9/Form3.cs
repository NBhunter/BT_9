using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace BT_9
{
    public partial class Form3 : Form
    {
        public int x;
        int[] n;
        public Form3()
        {
            InitializeComponent();
        }
        public string Random()
        {
            n = new int[x];
            int i;

            string chuoi = "";
            int num1;
            Random rd = new Random();
            for (i = 0; i < x; i++)
            {
                num1 = rd.Next(0, x+12);
                n[i] = num1;
            }
            for (i = 0; i < x; i++)
            {
                chuoi += n[i] + " ; ";
            }
            return chuoi;
        }
        public string chan()
        {
            int i;

            string chuoi = "";
            for (i = 0; i < x; i++)
            {
                if(n[i]%2 == 0)
                {
                    chuoi += n[i] + ",";
                }
            }
            return chuoi;
        }
            private void btnexit_Click(object sender, EventArgs e)
        {
            this.Hide();
            this.Close();
        }

        private void Form3_Load(object sender, EventArgs e)
        {
            string kq = Random();
            txtMang.Text = kq;
            string kq2 = chan();
            txtchan.Text = kq2;

        }
    }
}
