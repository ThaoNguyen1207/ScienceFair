using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ScienceFair
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
            this.BuildButton.Click += new System.EventHandler(this.BuildButton_Click);
            this.RunButton.Click += new System.EventHandler(this.BuildButton_Click);
        }

        private void ClickThisButton_Click(object sender, EventArgs e)
        {
            
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBox2_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
