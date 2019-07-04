using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace WebFormsPanel
{
    public partial class Home : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            Panel1.Visible = true;
            Panel2.Visible = false;
            Panel3.Visible = false;
        }

        protected void Button1_Click(object sender, EventArgs e)
        {
            Panel1.Visible = true;
            Panel2.Visible = true;
            Panel3.Visible = false;
        }
        protected void Button2_Click(object sender, EventArgs e)
        {
            Panel1.Visible = true;
            Panel2.Visible = false;
            Panel3.Visible = false;
        }

        protected void Button3_Click(object sender, EventArgs e)
        {
            Panel1.Visible = true;
            Panel2.Visible = true;
            Panel3.Visible = true;
        }
        protected void Button4_Click(object sender, EventArgs e)
        {
            Panel1.Visible = true;
            Panel2.Visible = true;
            Panel3.Visible = false;
        }
        protected void Button5_Click(object sender, EventArgs e)
        {
            Panel1.Visible = true;
            Panel2.Visible = true;
            Panel3.Visible = true;
            Label1.Text = "Name: " + TextBox1.Text.ToString() +
                      "<br />Address: " + TextBox2.Text.ToString() +
                      "<br />Contact: " + TextBox3.Text.ToString() +
                      "<br />Email: " + TextBox4.Text.ToString() +
                      "<br />10th: " + TextBox5.Text.ToString() +
                      "<br />12th: " + TextBox6.Text.ToString() +
                      "<br />BE: " + TextBox7.Text.ToString() +
                      "<br />Experience: " + TextBox8.Text.ToString() +
                      "<br />Known Languages: " + TextBox9.Text.ToString();
        }

    }
}