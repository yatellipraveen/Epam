using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace GlobalEvents
{
    public partial class _Default : Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            Session["New"] = "Session1";

        }

      

        protected void SessionEndButton_Click(object sender, EventArgs e)
        {
            Session.Abandon();
        }
    }
}