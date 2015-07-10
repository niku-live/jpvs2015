using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WinForms1
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            button1.Text = "Paspaustas butonas";
            timer1.Enabled = true;

        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            button1.Text = System.DateTime.Now.ToLongTimeString();
            AntrojiForma superforma = new AntrojiForma();
            superforma.Show();

            


            
        }

        private void Form1_FormClosing(object sender, FormClosingEventArgs e)
        {
            //e.Cancel = true;
        }
    }
}
