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
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void btntaomang_Click(object sender, EventArgs e)
        {
            Form3 frm3 = new Form3();
            frm3.x = int.Parse(txtN.Text);
            frm3.Show();
        }
        private void taomang()
        {
            Form3 frm3 = new Form3();
            frm3.x = int.Parse(txtN.Text);
            frm3.Show();

        }
        private void txtN_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar) && (e.KeyChar != '.'))
            {
                e.Handled = true;
                MessageBox.Show("Giá trị vừa nhập không phải là số, hãy nhập lại", "Thông Báo");
            }
            else
            {
                btnrefresh.Enabled = true;
                btnktsohoanhao.Enabled = true;
                btntaomang.Enabled = true;
                kiểmTraSốHoànHảoToolStripMenuItem.Enabled = true;
                tạoMảngToolStripMenuItem.Enabled = true;
            }
        }

        private void btnktsohoanhao_Click(object sender, EventArgs e)
        {
            Form2 frm2 = new Form2();
            frm2.x = int.Parse(txtN.Text);
            frm2.Show();
        }

        private void btnrefresh_Click(object sender, EventArgs e)
        {
            txtN.Clear();
            btnrefresh.Enabled = false;
            btnktsohoanhao.Enabled = false;
            btntaomang.Enabled = false;
            kiểmTraSốHoànHảoToolStripMenuItem.Enabled = false;
            tạoMảngToolStripMenuItem.Enabled = false;

            kiểmTraSốHoànHảoToolStripMenuItem1.Enabled = false;
            tạoMảngToolStripMenuItem1.Enabled = false;
        }

        private void btnexit_Click(object sender, EventArgs e)
        {
            DialogResult traloi;
            traloi = MessageBox.Show("Bạn có muốn đóng chương trình không?", "Thông báo",
            MessageBoxButtons.OKCancel, MessageBoxIcon.Question);
            if (traloi == DialogResult.OK)
                Application.Exit();
        }

        private void kiểmTraSốHoànHảoToolStripMenuItem_Click(object sender, EventArgs e)
        {
            btnktsohoanhao_Click(sender, e);
        }

        private void tạoMảngToolStripMenuItem_Click(object sender, EventArgs e)
        {
            btntaomang_Click(sender, e);
        }

        private void kiểmTraSốHoànHảoToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            btnktsohoanhao_Click(sender, e);
        }

        private void tạoMảngToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            btntaomang_Click(sender, e);
        }

        private void thoátToolStripMenuItem_Click(object sender, EventArgs e)
        {
            btnexit_Click(sender, e);
        }

        private void thoátToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            btnexit_Click(sender, e);
        }
    }
}
