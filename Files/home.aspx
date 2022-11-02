<%@ Page Title="" Language="C#" MasterPageFile="~/Site1.Master" AutoEventWireup="true" CodeBehind="home.aspx.cs" Inherits="shoe_system.home" %>
<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="server">
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" runat="server">
    <br />
    <br />
    <div class="container">
        <div id="carouselExampleControls" class="carousel slide" data-ride="carousel">
  <div class="carousel-inner">
    <div class="carousel-item active">
        <img src="images2/jordan3.jpg" class="d-block w-100" style="height:400px;" />
      
    </div>
    <div class="carousel-item">
        <img src="images2/shop-air-force-1.jpg"  class="d-block w-100" style="height:400px;"/>
     
    </div>
    <div class="carousel-item">
        <img src="images2/shop-sb.jpg"  class="d-block w-100" style="height:400px;" />
      
    </div>
  </div>
  <a class="carousel-control-prev" href="#carouselExampleControls" role="button" data-slide="prev">
    <span class="carousel-control-prev-icon" aria-hidden="true"></span>
    <span class="sr-only">Previous</span>
  </a>
  <a class="carousel-control-next" href="#carouselExampleControls" role="button" data-slide="next">
    <span class="carousel-control-next-icon" aria-hidden="true"></span>
    <span class="sr-only">Next</span>
  </a>
</div>
    </div>
    <div class="container">
       <nav class="navbar navbar-expand-lg bg-dark">
  
  <button class="navbar-toggler" type="button" data-toggle="collapse" data-target="#navbarSupportedContent" aria-controls="navbarSupportedContent" aria-expanded="false" aria-label="Toggle navigation">
    <span class="navbar-toggler-icon"></span>
  </button>

  <div class="collapse navbar-collapse" id="navbarSupportedContent">
    <ul class="navbar-nav mx-auto">
      <li class="nav-item active">
          <h6 class="bg-light text-dark nav-link mr-3">Shoe Brands</h6>
      </li>
        
      <li class="nav-item">
          <asp:LinkButton ID="LinkButton1" CssClass=" nav-link text-light font-weight-bold" runat="server"  >Jordan</asp:LinkButton>
      </li>
         <li class="nav-item">
          <asp:LinkButton ID="LinkButton2" CssClass=" nav-link text-light font-weight-bold" runat="server" >Adidas</asp:LinkButton>
      </li>
         <li class="nav-item">
          <asp:LinkButton ID="LinkButton3" CssClass="nav-link text-light font-weight-bold" runat="server"  >Nike</asp:LinkButton>
      </li>
       
        <li class="nav-item">
          <asp:LinkButton ID="LinkButton5" CssClass="nav-link text-light font-weight-bold" runat="server" >Air Force</asp:LinkButton>
      </li>
         
        <li class="nav-item">
          <asp:LinkButton ID="LinkButton4" CssClass="nav-link text-light font-weight-bold" runat="server"  >Fila</asp:LinkButton>
      </li>
        <li class="nav-item">
          <asp:LinkButton ID="LinkButton6" CssClass="nav-link text-light font-weight-bold" runat="server" >Puma</asp:LinkButton>
      </li>
        <li class="nav-item">
          <asp:LinkButton ID="LinkButton7" CssClass="nav-link text-light font-weight-bold" runat="server" >Sneakers</asp:LinkButton>
      </li>
     
    </ul>
    
  </div>
</nav>
    </div>



    <div class="container">
        <br />
        <div class="row">
                        <div class="col">
                            <center>
                                <h6>Features Products</h6>
                                <hr />
                            </center>
                        </div>
                    </div>
        <asp:DataList ID="DataList1" runat="server" RepeatColumns="3" CellPadding="1"   >
        <ItemTemplate>
            <div class="card  mr-5">
                <div class="card-body">
                    
            <table>
                
                <tr>
                    <td> <asp:Image ID="Image1" runat="server" ImageUrl='<%#Eval("image") %>'   Height="170px" Width="170px" /> </td>
                    
                </tr>
                <tr>
                    <td>
                        <center>
                             <b>shoe Name:</b>
                            <b>
                        <%#Eval("s_name") %>
                                </b>
                        </td>
                    </tr>
                <tr>
                    <td>
                        <center>
                             <b>shoe brand:</b>
                            <b>
                        <%#Eval("shoe_brand") %>
                                </b>
                        </td>
                </tr>
                <tr>
                    <td>
                        <center>
                        <b>shoe price:</b>
                        <br /><%#Eval("price") %>
                            </center>
                            </td>

                </tr>

                <tr>
                    <td>
                        <center>
                        <a href="order.aspx" class="btn btn-dark text-light">Order NOW</a>
                            </center>
                            </td>

                </tr>
                
               
               
                
               
                
            </table>
                    </div>
            </div>
        </ItemTemplate>
    </asp:DataList>
    </div>
</asp:Content>
