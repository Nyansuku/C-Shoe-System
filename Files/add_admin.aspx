<%@ Page Title="" Language="C#" MasterPageFile="~/Site1.Master" AutoEventWireup="true" CodeBehind="add_admin.aspx.cs" Inherits="shoe_system.add_admin" %>
<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="server">
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" runat="server">
    <br />
    <br />
    <div class="container login">
        <div class="row">
            <div class="col-md-8 mx-auto">
                <div class="row">
                    <div class="col">
                        <center>
                            <h6>Add A side Admin</h6>
                            <hr />
                        </center>
                    </div>
                </div>

                <div class="row">
                    <div class="col-md-7 mx-auto">
                       <label>First Name</label>
                        <div class="form-group">
                            <asp:TextBox ID="TextBox1" CssClass="form-control" runat="server"></asp:TextBox>
                        </div>
                    </div>
                </div>

                 

               

                <div class="row">
                    <div class="col">
                        <center>
                            <h6>Login Credentials</h6>
                            <hr />
                        </center>
                    </div>
                </div>
                 <div class="row">
                    <div class="col-md-7 mx-auto">
                       <label>Admin Email</label>
                        <div class="form-group">
                            <asp:TextBox ID="TextBox4" CssClass="form-control" TextMode="Email" runat="server"></asp:TextBox>
                        </div>
                    </div>
                </div>

                  <div class="row">
                    <div class="col-md-7 mx-auto">
                       <label>Password</label>
                        <div class="form-group">
                            <asp:TextBox ID="TextBox5" CssClass="form-control" TextMode="Password" runat="server"></asp:TextBox>
                        </div>
                    </div>
                </div>

                  <div class="row">
                    <div class="col-md-7 mx-auto">
                       <label>Confirm Password</label>
                        <div class="form-group">
                            <asp:TextBox ID="TextBox6" CssClass="form-control" TextMode="Password" runat="server"></asp:TextBox>
                        </div>
                    </div>
                </div>

                <div class="row">
                    <div class="col-md-7 mx-auto">
                        <div class="form-group">
                        <asp:LinkButton ID="LinkButton1" CssClass="btn btn-primary form-control" runat="server" OnClick="LinkButton1_Click" >Create An Account</asp:LinkButton>
                    </div>
                        </div>
                </div>
            </div>
        </div>
    </div>
</asp:Content>
