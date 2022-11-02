<%@ Page Title="" Language="C#" MasterPageFile="~/Site1.Master" AutoEventWireup="true" CodeBehind="shoe.aspx.cs" Inherits="shoe_system.shoe" %>
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
                                    <h6>Shoe Management Page</h6>
                                    <hr />
                                </center>
                            </div>
                        </div>

                        <div class="row">
                            <div class="col-md-6">
                                <label>Shoe ID</label>
                                <div class="form-group input-group">
                                    <asp:TextBox ID="TextBox1" runat="server" CssClass="form-control"></asp:TextBox>
                                    <asp:LinkButton ID="LinkButton1" runat="server" CssClass="btn btn-primary text-light" OnClick="LinkButton1_Click"><i class="fas fa-check"></i></asp:LinkButton>
                                </div>
                            </div>
                        </div>

                        <div class="row">
                            <div class="col-md-8">
                                <label>Shoe Brand</label>
                                <div class="form-group">
                                    <asp:DropDownList ID="DropDownList1" CssClass="form-control" runat="server">
                                        <asp:ListItem Value="Adidas" Text="Adidas"></asp:ListItem>
                                         <asp:ListItem Value="AirForce" Text="Airforce"></asp:ListItem>
                                         <asp:ListItem Value="Fila" Text="Fila"></asp:ListItem>
                                         <asp:ListItem Value="Sneakers" Text="Sneakers"></asp:ListItem>
                                    </asp:DropDownList>
                                </div>
                            </div>
                        </div>

                        <div class="row">
                            <div class="col-md-8">
                                <label>Shoe Name</label>
                                <div class="form-group">
                                    <asp:TextBox ID="TextBox2" CssClass="form-control" runat="server"></asp:TextBox>
                                </div>
                            </div>
                        </div>
                        <div class="row">
                            <div class="col-md-8">
                                <label>Gender</label>
                                <div class="form-group">
                                    <asp:DropDownList ID="DropDownList2" CssClass="form-control" runat="server">
                                        <asp:ListItem Value="Male" Text="Male"></asp:ListItem>
                                         <asp:ListItem Value="Female" Text="Female"></asp:ListItem>
                                        
                                    </asp:DropDownList>
                                </div>
                            </div>
                        </div>

                          <div class="row">
                            <div class="col-md-8">
                                <label>Shoe Number Range</label>
                                <div class="form-group">
                                    <asp:TextBox ID="TextBox3" CssClass="form-control" TextMode="Number" runat="server"></asp:TextBox>
                                </div>
                            </div>
                        </div>

                          <div class="row">
                            <div class="col-md-8">
                                <label>Shoe Price</label>
                                <div class="form-group">
                                    <asp:TextBox ID="TextBox4" CssClass="form-control"  runat="server"></asp:TextBox>
                                </div>
                            </div>
                        </div>
                          <div class="row">
                            <div class="col-md-8">
                                <label>Shoe Image</label>
                                <div class="form-group">
                                    <asp:FileUpload ID="FileUpload1" CssClass="form-control" runat="server" />
                                </div>
                            </div>
                        </div>

                          <div class="row">
                            <div class="col-md-4">
                                <div class="form-group">
                                    <asp:LinkButton ID="LinkButton2" CssClass="form-control btn btn-primary btn-block" runat="server" OnClick="LinkButton2_Click">Add</asp:LinkButton>
                                </div>
                            </div>
                               <div class="col-md-4">
                                <div class="form-group">
                                    <asp:LinkButton ID="LinkButton3" CssClass="form-control btn btn-success btn-block" runat="server" OnClick="LinkButton3_Click">Update</asp:LinkButton>
                                </div>
                            </div>
                               <div class="col-md-4">
                                <div class="form-group">
                                    <asp:LinkButton ID="LinkButton4" CssClass="form-control btn btn-danger btn-block" runat="server" OnClick="LinkButton4_Click">Delete</asp:LinkButton>
                                </div>
                            </div>
                        </div>

                    </div>
                </div>
            </div>

            <div class="col-md-6">
                <div class="card">
                    <div class="card-body">
                        <div class="row">
                            <div class="col">
                                <center>
                                    <h6>Shoes Information</h6>
                                    <hr />
                                </center>
                            </div>
                        </div>

                        <div class="row">
                            <asp:SqlDataSource ID="SqlDataSource1" runat="server" ConnectionString="<%$ ConnectionStrings:shoesConnectionString %>" SelectCommand="SELECT * FROM [shoe]"></asp:SqlDataSource>
                            <div class="col">
                                <asp:GridView ID="GridView1" runat="server" CssClass="table" AutoGenerateColumns="False" DataKeyNames="shoe_ID" DataSourceID="SqlDataSource1">
                                    <Columns>
                                        <asp:BoundField DataField="shoe_ID" HeaderText="shoe_ID" ReadOnly="True" SortExpression="shoe_ID" />
                                        <asp:BoundField DataField="shoe_brand" HeaderText="shoe_brand" SortExpression="shoe_brand" />
                                        <asp:BoundField DataField="gender" HeaderText="gender" SortExpression="gender" />
                                        <asp:BoundField DataField="s_name" HeaderText="s_name" SortExpression="s_name" />
                                        <asp:BoundField DataField="s_number" HeaderText="s_number" SortExpression="s_number" />
                                        <asp:BoundField DataField="price" HeaderText="price" SortExpression="price" />
                                    </Columns>
                                </asp:GridView>
                            </div>
                        </div>
                    </div>
                </div>
            </div>
        </div>
    </div>
</asp:Content>
