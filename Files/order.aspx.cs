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
    public partial class order : System.Web.UI.Page
    {
        string strcon = ConfigurationManager.ConnectionStrings["dbconnection"].ConnectionString;
        protected void Page_Load(object sender, EventArgs e)
        {
           

        }
        //order
        protected void LinkButton2_Click(object sender, EventArgs e)
        {
            SqlConnection con = new SqlConnection(strcon);
            //check if connection is open
            if (con.State == ConnectionState.Closed)
            {
                con.Open();
            }
            //query
            SqlCommand cmd = new SqlCommand("insert into orders(email_address,phone_number,shoe_number) values(@email_address,@phone_number,@shoe_number)", con);
            cmd.Parameters.AddWithValue("@email_address", TextBox4.Text.Trim());
            cmd.Parameters.AddWithValue("@phone_number", TextBox3.Text.Trim());
            cmd.Parameters.AddWithValue("@shoe_number", TextBox1.Text.Trim());


            cmd.ExecuteNonQuery();
            con.Close();
            Response.Write("<script>alert('Will Send A Confirmation Message,delivery and payment information  To " + TextBox3.Text + "')</script>");
        }

        protected void LinkButton3_Click(object sender, EventArgs e)
        {
            Response.Redirect("home.aspx");
        }
    }
}