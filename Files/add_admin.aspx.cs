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
    public partial class add_admin : System.Web.UI.Page
    {
        //connection string variable

        string strcon = ConfigurationManager.ConnectionStrings["dbconnection"].ConnectionString;
        protected void Page_Load(object sender, EventArgs e)
        {

        }

        protected void LinkButton1_Click(object sender, EventArgs e)
        {
            if (checkadmin())
            {
                Response.Write("<script>alert('username or email already Exist,try Another One')</script>");
            }
            else
            {
                add_Admin();
            }
        }
        //check if admin exist
        bool checkadmin()
        {
            //connection object
            SqlConnection con = new SqlConnection(strcon);
            //check if connection is open
            if (con.State == ConnectionState.Closed)
            {
                con.Open();
            }
            //query
            SqlCommand cmd = new SqlCommand("select * from admin where admin_email='" + TextBox4.Text.Trim() + "' ", con);
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
        //add admin code
        void add_Admin()
        {
            //connection object
            SqlConnection con = new SqlConnection(strcon);
            //check if connection is open
            if (con.State == ConnectionState.Closed)
            {
                con.Open();
            }
            SqlCommand cmd = new SqlCommand("insert into admin(admin_email,admin_name,password) " +
                    "values(@admin_email,@admin_name,@password)", con);

            cmd.Parameters.AddWithValue("@admin_email", TextBox4.Text.Trim());
            cmd.Parameters.AddWithValue("@admin_name", TextBox1.Text.Trim());
          
            cmd.Parameters.AddWithValue("@password", TextBox5.Text.Trim());

            //execute code
            cmd.ExecuteNonQuery();
            //close the connec tion
            con.Close();
            //message
            if (TextBox5.Text == TextBox6.Text)
            {
                Response.Write("<script>alert('Admin  Added Successfully')</script>");
                Response.Redirect("login.aspx");
            }
            else
            {
                Response.Write("<script>alert('Passwords Doesnt Match')</script>");
            }
        }
    }
}