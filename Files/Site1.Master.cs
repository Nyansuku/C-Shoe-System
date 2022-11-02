using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace shoe_system
{
    public partial class Site1 : System.Web.UI.MasterPage
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            //visibility of linkbutton
            //if no one is logged in
            if (string.IsNullOrEmpty((string)Session["role"]))
            {
                LinkButton1.Visible = true; //signup
                LinkButton2.Visible = true; //member login
                LinkButton3.Visible = true; //admin login
                LinkButton5.Visible = false; //logout
                LinkButton4.Visible = false; //Account
                LinkButton8.Visible = false; //admin
                LinkButton7.Visible = false; //admin
                LinkButton6.Visible = false; //admin

            }
            else if (Session["role"].Equals("admin"))
            {


                LinkButton1.Visible = false; //signup
                LinkButton2.Visible = false; //member login
                LinkButton3.Visible = false; //admin login
                LinkButton5.Visible = true; //logout
                LinkButton4.Visible = false; //account
                LinkButton8.Visible = true; //admin

                LinkButton7.Visible = true;//admin
                LinkButton6.Visible = true; //admin

            }

            else if (Session["role"].Equals("user"))
            {
                LinkButton1.Visible = false; //signup
                LinkButton2.Visible = false; //member login
                LinkButton3.Visible = false; //admin login
                LinkButton5.Visible = true; //logout
                LinkButton4.Text = Session["name"] + " " + "Account";
                LinkButton4.Visible = true; //account
                LinkButton8.Visible = false; //admin
                LinkButton7.Visible = false; //admin
                LinkButton6.Visible = false; //admin
               




            }

        }
        //signup
        protected void LinkButton1_Click(object sender, EventArgs e)
        {
            Response.Redirect("signup.aspx");
        }

        protected void LinkButton2_Click(object sender, EventArgs e)
        {
            Response.Redirect("login.aspx");
        }

        protected void LinkButton3_Click(object sender, EventArgs e)
        {
            Response.Redirect("adminlogin.aspx");
        }

       
        protected void LinkButton4_Click(object sender, EventArgs e)
        {
            Response.Redirect("account.aspx");
        }

        protected void LinkButton8_Click(object sender, EventArgs e)
        {
            Response.Redirect("add_admin.aspx");
        }

        protected void LinkButton6_Click(object sender, EventArgs e)
        {
            Response.Redirect("shoe.aspx");
        }

        protected void LinkButton7_Click(object sender, EventArgs e)
        {
            Response.Redirect("member.aspx");
        }

        protected void LnkButton5_Click(object sender, EventArgs e)
        {
            //set all the session to empty
            Session["emailaddress"] = "";
            Session["name"] = "";
            Session["role"] = "";
            LinkButton1.Visible = true; //signup
            LinkButton2.Visible = true; //member login
            LinkButton3.Visible = true; //admin login
            LinkButton5.Visible = false; //logout
            LinkButton4.Visible = false; //Account
            LinkButton8.Visible = false; //admin
            LinkButton7.Visible = false; //admin
            LinkButton6.Visible = false; //admin
            Response.Redirect("home.aspx");

        }
    }
}