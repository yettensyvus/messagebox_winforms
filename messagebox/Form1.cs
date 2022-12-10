using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace messagebox
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (frm_messagebox.Show("Do you want to logout?", "Alert!", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
            {
                MessageBox.Show("hello");
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            frm_messagebox.Show("Do you want to logout?", "Alert!", MessageBoxButtons.OKCancel, MessageBoxIcon.Error);
        }

        private void button3_Click(object sender, EventArgs e)
        {
            DialogResult dialogResult = MessageBox.Show("Sure", "Some Title", MessageBoxButtons.YesNo);
            if (dialogResult == DialogResult.Yes)
            {
                //do something
            }
            frm_messagebox.Show("Do you want to logout?", "Alert!", MessageBoxButtons.RetryCancel, MessageBoxIcon.Information);

        }

        private void button4_Click(object sender, EventArgs e)
        {
            frm_messagebox.Show("Do you want to logout?", "Alert!", MessageBoxButtons.YesNo, MessageBoxIcon.Warning);

        }
    }
}
