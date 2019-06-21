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
    public partial class Register : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
          
        }

        protected void Button1_Click(object sender, EventArgs e)
        {
            string name = TextBox1.Text;
            string address = TextBox2.Text;
            int cont = int.Parse(TextBox3.Text);
            int age = int.Parse(TextBox4.Text);
            string email = TextBox5.Text;
            string username = TextBox6.Text;
            string password = TextBox7.Text;
            string CS = ConfigurationManager.ConnectionStrings["EmployeeConnectionString"].ConnectionString;
            using (SqlConnection con = new SqlConnection(CS))
            {
                con.Open();
                SqlCommand cmd = new SqlCommand("insert into employee(Name, Address, Contact, Age, Email,Username,Password) values (@Name, @Address, @Contact, @Age, @Email,@Username,@Password)", con);
                cmd.Parameters.AddWithValue("Name", name);
                cmd.Parameters.AddWithValue("Address", address);
                cmd.Parameters.AddWithValue("Contact", cont);
                cmd.Parameters.AddWithValue("Age", age);
                cmd.Parameters.AddWithValue("Email", email);
                cmd.Parameters.AddWithValue("Username", username);
                cmd.Parameters.AddWithValue("Password", password);

                cmd.ExecuteNonQuery();
                Label6.Visible = true;
                Label6.Text = "Registration Successful";
                
           
                con.Close();
                Response.Redirect("Home.aspx");

            }
        }
    }
}