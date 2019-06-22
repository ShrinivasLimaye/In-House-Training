using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace Assignment_2__19_6_2019_
{
    public partial class GenHome : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            if (Session["log"] == null)
            {
                Response.Redirect("Home.aspx");
            }
            if (Session["nu"] != null)
            {
                string str = Convert.ToString(Session["nu"]);
                string u = str;
                Label1.Text ="Hello,"+ u;
            }
        }
    }
}