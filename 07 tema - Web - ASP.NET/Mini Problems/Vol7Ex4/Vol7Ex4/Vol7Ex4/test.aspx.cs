using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace Vol7Ex4
{
    public partial class test : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            System.IO.FileInfo finfo = new System.IO.FileInfo("C:\\Devel\\test.txt");
            if (finfo.Exists)
            {
                System.IO.StreamReader reader = finfo.OpenText();
                string text = reader.ReadLine();
                reader.Close();
                TextBox1.Text = text;
            }
        }

        protected void Button1_Click(object sender, EventArgs e)
        {
            string text = TextBox1.Text;
            Label3.Text = text;
            TextBox1.Text = "";
            System.IO.FileInfo finfo = new System.IO.FileInfo("C:\\Devel\\test.txt");
            System.IO.StreamWriter writer = finfo.CreateText();
            writer.WriteLine(text);
            writer.Close();
        }

        protected void GridView1_SelectedIndexChanged(object sender, EventArgs e)
        {            
            Response.Redirect(String.Format("details.aspx?id={0}", GridView1.SelectedIndex + 1));
        }
    }
}