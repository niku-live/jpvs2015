using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Vol2Ex3_DesktopCopy
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private Bitmap _screenBitmap;

        private void Form1_Load(object sender, EventArgs e)
        {
            _screenBitmap = new Bitmap(Screen.PrimaryScreen.Bounds.Width, Screen.PrimaryScreen.Bounds.Height);

            using (Graphics g = Graphics.FromImage(_screenBitmap))
            {
                g.CopyFromScreen(Screen.PrimaryScreen.Bounds.X,
                                 Screen.PrimaryScreen.Bounds.Y,
                                 0, 0,
                                 _screenBitmap.Size,
                                 CopyPixelOperation.SourceCopy);
            }
        }

        private void Form1_Shown(object sender, EventArgs e)
        {
            this.Width = _screenBitmap.Width;
            this.Height = _screenBitmap.Height;
            pictureBox1.Image = _screenBitmap;
            this.Location = new Point(0, 0);
        }
    }
}
