using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace Vol7Ex4
{
    public partial class details : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            XmlDataSource1.XPath = String.Format("Data/User[{0}]", this.Request["id"]);
        }
    }
}