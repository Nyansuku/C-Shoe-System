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
    public partial class signup : System.Web.UI.Page
    {

        //connection string variable

        string strcon = ConfigurationManager.ConnectionStrings["dbconnection"].ConnectionString;
        protected void Page_Load(object sender, EventArgs e)
        {

        }
        //signup code
        protected void LinkButton1_Click(object sender, EventArgs e)
        {
            if (checkmember())
            {
                Response.Write("<script>alert('username or email already Exist,try Another One')</script>");
            }
            else
            {
                addmember();
            }
        }
        //check if the member exist
        bool checkmember()
        {
            //connection object
            SqlConnection con = new SqlConnection(strcon);
            //check if connection is open
            if (con.State == ConnectionState.Closed)
            {
                con.Open();
            }
            //query
            SqlCommand cmd = new SqlCommand("select * from users where user_email='" + TextBox4.Text.Trim() + "' ", con);
            SqlDataAdapter sda = new SqlDataAdapter(cmd);
            DataTable dt = new DataTable();
            //fill the dattable using the data adapters
            sda.Fill(dt);
            //check if we have any record
            //if we have any record of the same id
            if (dt.Rows.Count > 0)
            {
                return true;
            }
            //else
            else
            {
                return false;
            }
        }
        void addmember()
        {
            //connection object
            SqlConnection con = new SqlConnection(strcon);
            //check if connection is open
            if (con.State == ConnectionState.Closed)
            {
                con.Open();
            }
            SqlCommand cmd = new SqlCommand("insert into users(fname,lname,user_email,password) " +
                    "values(@fname,@lname,@user_email,@password)", con);

            cmd.Parameters.AddWithValue("@fname", TextBox1.Text.Trim());
            cmd.Parameters.AddWithValue("@lname", TextBox2.Text.Trim());
            cmd.Parameters.AddWithValue("@user_email", TextBox4.Text.Trim());
            cmd.Parameters.AddWithValue("@password", TextBox5.Text.Trim());

            //execute code
            cmd.ExecuteNonQuery();
            //close the connec tion
            con.Close();
            //message
            if (TextBox5.Text == TextBox6.Text)
            {
                Response.Write("<script>alert('member Added Successfully')</script>");
                Response.Redirect("login.aspx");
            }
            else
            {
                Response.Write("<script>alert('Passwords Doesnt Match')</script>");
            }
        }

    }
}