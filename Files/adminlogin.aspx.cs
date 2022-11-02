using System;
using System.Collections.Generic;
using System.Configuration;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace shoe_system
{
    public partial class adminlogin : System.Web.UI.Page
    {
        string strcon = ConfigurationManager.ConnectionStrings["dbconnection"].ConnectionString;
        protected void Page_Load(object sender, EventArgs e)
        {

        }

        protected void LinkButton1_Click(object sender, EventArgs e)
        {
            //connection object
            SqlConnection con = new SqlConnection(strcon);
            //check if connection is open
            if (con.State == ConnectionState.Closed)
            {
                con.Open();
            }
            //select query
            SqlCommand cmd = new SqlCommand("select * from admin where admin_email='" + TextBox1.Text + "' AND password='" + TextBox2.Text + "'", con);
            //using connected architecture
            SqlDataReader dr = cmd.ExecuteReader();
            //check if row exsit
            if (dr.HasRows)
            {
                //if rows exists
                //read value on the row
                while (dr.Read())
                {
                    //will add session variable in this section
                    Session["emailaddress"] = dr.GetValue(0).ToString();
                    Session["name"] = dr.GetValue(1).ToString();
                    Session["role"] = "admin";
                }
                Response.Redirect("home.aspx");

            }
            else
            {
                Response.Write("<script>alert('wrong credentials')</script");
            }
        }
    }
}