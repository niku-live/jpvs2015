using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Vol2Ex1_MovingButton
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

 
        private void button1_MouseMove(object sender, MouseEventArgs e)
        {
            Point location = button1.Location;
            location.X += 10;
            location.Y += 10;
            button1.Location = location;
        }
    }
}
