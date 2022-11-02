<%@ Page Title="" Language="C#" MasterPageFile="~/Site1.Master" AutoEventWireup="true" CodeBehind="order.aspx.cs" Inherits="shoe_system.order" %>
<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="server">
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" runat="server">

    <div class="container">
        <div class="rents">
            <center>
                <h4>Welcome To Your Account </h4>
            </center>
            
        </div>
        <div class="row accounts">
            <div class="col-md-8 mx-auto">
                <br />
                <div class="row">
                    <div class="col">
                        <center><h6>Make Your Orders</h6></center>
                    </div>
                </div>
                <div class="row">
                    <div class="col-md-7 mx-auto">
                        <label>Email Address</label>
                        <div class="form-group">
                            <asp:TextBox ID="TextBox4" CssClass="form-control" TextMode="Email" runat="server"></asp:TextBox>
                        </div>
                    </div>
                </div>

                <div class="row">
                    <div class="col-md-7 mx-auto">
                        <label>Shoe Number</label>
                        <div class="form-group">
                            <asp:TextBox ID="TextBox1" CssClass="form-control" runat="server"></asp:TextBox>
                        </div>
                    </div>
                </div>

                 

                  <div class="row">
                    <div class="col-md-7 mx-auto">
                        <label>Phone Number</label>
                        <div class="form-group">
                            <asp:TextBox ID="TextBox3" CssClass="form-control" runat="server"></asp:TextBox>
                        </div>
                    </div>
                </div>

                  

               
                  <div class="row">
                      <div class="col-md-8 mx-auto">
                          <div class="row">
                              <div class="col-md-6">
                        <asp:LinkButton ID="LinkButton2" CssClass="btn btn-primary btn-block" runat="server" OnClick="LinkButton2_Click">Order Now</asp:LinkButton>
                    </div>
                          
                         
                             <div class="col-md-6">
                        <asp:LinkButton ID="LinkButton3" CssClass="btn btn-danger btn-block" runat="server" OnClick="LinkButton3_Click">Not Sure</asp:LinkButton>
                    </div>
                         
                      </div>
                          </div>
                    </div>
            </div>
        </div>
        
    </div>
</asp:Content>
