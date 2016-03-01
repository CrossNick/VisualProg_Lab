using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace vis_lab_1
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            StringBuilder str = new StringBuilder(textBox1.Text);
            for (int i = 1; i <= str.Length - 1; i++)
                if (str[i] == str[i - 1])
                {
                    str.Remove(i--, 1);
                }
            textBox2.Text = str.ToString();
        }
    }
}
