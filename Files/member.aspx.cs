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
    public partial class member : System.Web.UI.Page
    {
        //connection string variable

        string strcon = ConfigurationManager.ConnectionStrings["dbconnection"].ConnectionString;
        protected void Page_Load(object sender, EventArgs e)
        {
            GridView1.DataBind();
        }
        //delete member
        protected void LinkButton2_Click(object sender, EventArgs e)
        {
            if (checkmember())
            {
                delete_member();
            }
            else
            {
                Response.Write("<script>alert('Cant Delete Member,email address doesnt exist')</script>");
            }
        }
        //check if member exist
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
        void delete_member()
        {
            //connection object
            SqlConnection con = new SqlConnection(strcon);
            //check if connection is open
            if (con.State == ConnectionState.Closed)
            {
                con.Open();
            }
            SqlCommand cmd = new SqlCommand("delete from users where user_email='"+TextBox8.Text.Trim()+"'", con);
            //execute code
            cmd.ExecuteNonQuery();
            //close the connec tion
            con.Close();
            GridView1.DataBind();
            Response.Write("<script>alert('member Deleted Successfully')</script>");
        }

    }
}