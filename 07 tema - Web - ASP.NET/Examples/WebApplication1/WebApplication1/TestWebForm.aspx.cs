using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace WebApplication1
{
    public partial class TestWebForm : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {

        }

        protected void Button1_Click(object sender, EventArgs e)
        {
            Label1.Text = "Paspausta";
            System.IO.FileInfo finfo = new System.IO.FileInfo("C:\\Stovyklai\\test.txt");
            var writer = finfo.CreateText();
            writer.WriteLine("Test");
            writer.Close();

        }

        protected void Button2_Click(object sender, EventArgs e)
        {
            TextBox1.Text = "hfdkfdlfkh";
        }
    }
}