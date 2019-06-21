using System;
using System.Collections.Generic;
using System.Configuration;
using System.Data.SqlClient;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace Assignment_2__19_6_2019_
{
    public partial class Home : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            Label4.Text = "Welcome to Test Website..!!";

            if(!IsPostBack)
            {
            ViewState["Attempt"] = 0;
            }
        }

        protected void Button1_Click(object sender, EventArgs e)
        {
            if (ViewState["Attempt"] != null)
            {
                string CS = ConfigurationManager.ConnectionStrings["EmployeeConnectionString"].ConnectionString;
                using (SqlConnection con = new SqlConnection(CS))
                {

                    string uid = TextBox1.Text;
                    string pass = TextBox2.Text;
                    con.Open();
                    string qry = "select * from Employee where Username='" + uid + "' and Password='" + pass + "'";
                    SqlCommand cmd = new SqlCommand(qry, con);
                    SqlDataReader sdr = cmd.ExecuteReader();
                    if (sdr.Read())
                    {
                        Session["log"] = 1;

                        Response.Redirect("AuthHome.aspx");
                    }
                    else
                    {

                        if ((int)ViewState["Attempt"] < 3)
                        {
                            var a = (int)ViewState["Attempt"] + 1;
                            var b = 3-(int)ViewState["Attempt"] ;
                            Label3.Text = "Try again...You have " +""+b+""+ " attempts remaining";
                            ViewState["Attempt"] = a;
                        }
                        else
                        {
                            Button1.Enabled = false;
                            Label3.Text = "Too many wrong attempts...try again later";
                            
                        }
                    }
                     con.Close();
                    
                }
            }
        }

        protected void Button2_Click(object sender, EventArgs e)
        {
                Response.Redirect("Register.aspx");
        }
    }
}
   
