<%@ Page Title="" Language="C#" MasterPageFile="~/Site1.Master" AutoEventWireup="true" CodeBehind="member.aspx.cs" Inherits="shoe_system.member" %>
<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="server">
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" runat="server">
    <br />
    <div class="container">
        <div class="row">
            <div class="col-md-6">
                <div class="card">
                    <div class="card-body">
                        <div class="row">
                    <div class="col">
                        <center>
                            <h5>Member Management </h5>
                        </center>
                    </div>
                    </div>
                        <div class="row">
                            <div class="col">
                                <label>Email Addres</label>
                                <div class="form-group">
                                    <asp:TextBox ID="TextBox8" CssClass="form-control" TextMode="Email" runat="server"></asp:TextBox>
                                  
                                </div>
                            </div>
                        </div>

                        <div class="row">
                            <div class="col-md-6">
                                <label>First Name</label>
                                <div class="form-group">
                                    <asp:TextBox ID="TextBox1" class="form-control" placeholder="first name" runat="server"></asp:TextBox>
                                </div>
                            </div>
                            <div class="col-md-6">
                                <label>Last Name</label>
                                <div class="form-group">
                                    <asp:TextBox ID="TextBox2" class="form-control" placeholder="Last Name" runat="server"></asp:TextBox>
                                </div>
                            </div>
                        </div>

                        <div class="row">
                            
                            <div class="col-md-6">
                                <label>Email Address</label>
                                <div class="form-group">
                                    <asp:TextBox ID="TextBox4" TextMode="Email" class="form-control" placeholder="email" runat="server"></asp:TextBox>
                                </div>
                            </div>
                        </div>

      
                         <div class="row">
                   
                         <div class="col-md-6 mx-auto">
                             <div class="form-group">
                             <asp:LinkButton ID="LinkButton2" CssClass="btn btn-danger btn-block form-control" runat="server" OnClick="LinkButton2_Click" >Delete Member</asp:LinkButton>
                    </div>
                </div>
</div>

                    </div>
                </div>
            </div>
            <div class="col-md-6">
                <div class="row">
                    <div class="col">
                        <center>
                            <h5>member Information</h5>
                        </center>
                        <hr />
                    </div>
                    </div>
                
                <div class="row">
                    <asp:SqlDataSource ID="SqlDataSource1" runat="server" ConnectionString="<%$ ConnectionStrings:shoesConnectionString %>" SelectCommand="SELECT * FROM [users]"></asp:SqlDataSource>
                    <div class="col">
                        <asp:GridView ID="GridView1" class="table" runat="server" AutoGenerateColumns="False" DataKeyNames="user_email" DataSourceID="SqlDataSource1">
                            <Columns>
                                <asp:BoundField DataField="fname" HeaderText="fname" SortExpression="fname" />
                                <asp:BoundField DataField="lname" HeaderText="lname" SortExpression="lname" />
                                <asp:BoundField DataField="user_email" HeaderText="user_email" ReadOnly="True" SortExpression="user_email" />
                            </Columns>
                        </asp:GridView>
                    </div>
                </div>
                </div>
            
        </div>
        </div>
</asp:Content>
