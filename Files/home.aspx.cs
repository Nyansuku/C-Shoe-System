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
    public partial class home : System.Web.UI.Page
    {
        string strcon = ConfigurationManager.ConnectionStrings["dbconnection"].ConnectionString;
        protected void Page_Load(object sender, EventArgs e)
        {
            //connection object
            SqlConnection con = new SqlConnection(strcon);
            //check if connection is open
            if (con.State == ConnectionState.Closed)
            {
                con.Open();
            }
            //query
            SqlCommand cmd = new SqlCommand("select * from shoe", con);
            SqlDataAdapter sda = new SqlDataAdapter(cmd);
            DataSet ds = new DataSet();
            sda.Fill(ds);
            DataList1.DataSource = ds;
            DataList1.DataBind();
            con.Close();
        }

        
    }
}