using System;
using System.Collections.Generic;
using System.Configuration;
using System.Data;
using System.Data.SqlClient;
using System.IO;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace shoe_system
{
    public partial class shoe : System.Web.UI.Page
    {
        string strcon = ConfigurationManager.ConnectionStrings["dbconnection"].ConnectionString;
        protected void Page_Load(object sender, EventArgs e)
        {
            GridView1.DataBind();
        }
        //add
        protected void LinkButton2_Click(object sender, EventArgs e)
        {
            if (checkshoe())
            {
                Response.Write("<script>alert('Shoe Already already exist')</script>");
            }
            else
            {
                add_shoe();
            }
        }
        //update
        protected void LinkButton3_Click(object sender, EventArgs e)
        {
            if (checkshoe())
            {
                update();
            }
            else
            {
                Response.Write("<script>alert('cant Update,shoe doesnt exist')</script>");
            }
        }
        //delete
        protected void LinkButton4_Click(object sender, EventArgs e)
        {
            if (checkshoe())
            {
                delete();
            }
            else
            {
                Response.Write("<script>alert('cant delete,shoe doesnt exist')</script>");
            }
        }
        //check if the shoe id already exist in db
        bool checkshoe()
        {
            //connection object
            SqlConnection con = new SqlConnection(strcon);
            //check if connection is open
            if (con.State == ConnectionState.Closed)
            {
                con.Open();
            }
            //query
            SqlCommand cmd = new SqlCommand("select * from shoe where shoe_ID='" + TextBox1.Text.Trim() + "' ", con);
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

        //add shoe
        void add_shoe()
        {
            //how to get image from file upload to db
            //into another folder into upload
            //how to get image path to the datatabase and image to another folder
            string filepath = "upload/i1.jpg";
            //geting the content from fileupload asp button
            //the file will be posted to the server
            string filename = Path.GetFileName(FileUpload1.PostedFile.FileName);
            //save the image to the folder that we want to store
            FileUpload1.SaveAs(Server.MapPath("upload/" + filename));
            filepath = "upload/" + filename;
            //connection object
            SqlConnection con = new SqlConnection(strcon);
            //check if connection is open
            if (con.State == ConnectionState.Closed)
            {
                con.Open();
            }
            SqlCommand cmd = new SqlCommand("insert into shoe(shoe_ID,shoe_brand,gender,s_name,s_number,price,image) " +
                    "values(@shoe_ID,@shoe_brand,@gender,@s_name,@s_number,@price,@image)", con);

            cmd.Parameters.AddWithValue("@shoe_ID", TextBox1.Text.Trim());
            cmd.Parameters.AddWithValue("@shoe_brand", DropDownList1.SelectedItem.Value);
            cmd.Parameters.AddWithValue("@gender", DropDownList2.SelectedItem.Value);
            cmd.Parameters.AddWithValue("@s_name", TextBox2.Text.Trim());
            cmd.Parameters.AddWithValue("@s_number", TextBox3.Text.Trim());
            cmd.Parameters.AddWithValue("@price", TextBox4.Text.Trim());
            cmd.Parameters.AddWithValue("@image",filepath);

            //execute code
            cmd.ExecuteNonQuery();
            //close the connec tion
            con.Close();
            //message
           
                Response.Write("<script>alert('Shoe information Added Successfully')</script>");
            GridView1.DataBind();
            
            
        }

        //update shoe price
        void update()
        {
            //connection object
            SqlConnection con = new SqlConnection(strcon);
            //check if connection is open
            if (con.State == ConnectionState.Closed)
            {
                con.Open();
            }
            //query
            SqlCommand cmd = new SqlCommand("update  shoe set  price='" + TextBox4.Text.Trim() + "' where shoe_ID='" + TextBox1.Text.Trim() + "'", con);

            cmd.ExecuteNonQuery();
            //close the connec tion
            con.Close();
            //message

            Response.Write("<script>alert('shoe price Updated Successfully')</script>");
            GridView1.DataBind();
           
        }

        //delete shoe
        void delete()
        {
            //connection object
            SqlConnection con = new SqlConnection(strcon);
            //check if connection is open
            if (con.State == ConnectionState.Closed)
            {
                con.Open();
            }
            //query
            SqlCommand cmd = new SqlCommand("delete shoe  where shoe_ID='" + TextBox1.Text.Trim() + "'", con);

            cmd.ExecuteNonQuery();
            //close the connec tion
            con.Close();
            //message

            Response.Write("<script>alert('shoe Deleted Successfully')</script>");
            GridView1.DataBind();
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
            //query
            SqlCommand cmd = new SqlCommand("select * from shoe where shoe_ID='" + TextBox1.Text.Trim() + "'", con);
            SqlDataAdapter sda = new SqlDataAdapter(cmd);
            DataTable dt = new DataTable();
            sda.Fill(dt);
            //check if row exist
            if (dt.Rows.Count > 0)
            {
                DropDownList1.SelectedValue = dt.Rows[0][1].ToString();
                DropDownList2.SelectedValue = dt.Rows[0][2].ToString();
                TextBox1.Text = dt.Rows[0][0].ToString();
                TextBox2.Text = dt.Rows[0][3].ToString();
                TextBox3.Text = dt.Rows[0][4].ToString();
                TextBox4.Text = dt.Rows[0][5].ToString();


                //image here
            }
            else
            {
                Response.Write("<script>alert('invalid ID')</script>");
            }
        }
    }
}