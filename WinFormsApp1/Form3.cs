using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WinFormsApp1
{
    public partial class Form3 : Form
    {
        public Form3()
        {
            InitializeComponent();
        }

        private void textBox4_TextChanged(object sender, EventArgs e)
        {
            textBox2.UseSystemPasswordChar = true;
            textBox2.Visible = true;
        }

        private void textBox3_TextChanged(object sender, EventArgs e)
        {
            textBox2.UseSystemPasswordChar = true;
            textBox2.Visible = true;
        }
    }
}
