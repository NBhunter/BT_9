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
    public partial class Form2 : Form
    {
        public Form2()
        {
            InitializeComponent();
        }
        public int x;
        public int ktsohoanhao(int n)
        {
            int count = 0;
            for(int i=1; i < n; i++)
            {
                if(n%i == 0)
                {
                    count += i;
                }
            }
            if (count == n & n != 0) { 

                return 1;
            }    
            else
            return 0;
        }

        private void Form2_Load(object sender, EventArgs e)
        {
            int kq = ktsohoanhao(x);
            if(kq == 1)
            {
                string LB = x.ToString() + " Là số Hoàn Hảo";
                lbKQ.Text = LB;
            }
            else
            {
                string LB = x.ToString() + " không phải Là số Hoàn Hảo";
                lbKQ.Text = LB;
            }    
        }

        private void btnexit_Click(object sender, EventArgs e)
        {
            this.Hide();
            this.Close();
        }
    }
}
