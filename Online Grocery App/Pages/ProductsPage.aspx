<%@ Page Title="" Language="C#" MasterPageFile="~/Master.Master" AutoEventWireup="true" CodeBehind="ProductsPage.aspx.cs" Inherits="Online_Grocery_App.Pages.ProductsPage" %>
<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="server">
    <link href="../css/ProductsPage.css" rel="stylesheet" />
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" runat="server">
    <main>
        <div class="space"></div>
        <section runat="server">
            <div id="productDiv" runat="server">
                <div id="imageDiv" runat="server">

                </div>
                <div id="contentDiv" runat="server">
                    <h1 id="productName" runat="server"></h1>
                    <hr id="productLine"/>
                    <div>
                        <div class="priceDiv"><h2>Price:</h2><p id="productPrice" runat="server"></p></div>
                        <p id="productBrand" runat="server"></p>
                        <h2>Description</h2>
                        <p id="productDescription" runat="server"></p>
                        <h2>Quantity</h2>
                        <asp:DropDownList ID="DropDownList1" runat="server"></asp:DropDownList>
                        <asp:Button CssClass="btnAddToCart" ID="btnAddToCart" onclick="BtnAddToCart" runat="server" Text="Add to Cart" />
                    </div>
                
                </div>
            </div>
            
            <div id="section1">
          <br />
          <div class="sectionName">
            <h1 class="heading">You may also like</h1>
            <button onserverclick="btnViewAll" type="button" runat="server">
              View All
            </button>
          </div>
          

          <div class="ProductsDiv" runat="server" id="pageProductDiv1">
              <asp:Panel CssClass="panel-class" ID="Panel1" runat="server"></asp:Panel>
            <%--<div>
              <a href="#">
                <img src="./Images/sample_pic.jpg" alt="" />
                <div class="products">
                  <p>Price</p>
                  <p>
                    Lorem ipsum, dolor sit amet consectetur adipisicing elit.
                    Inventore, expedita!
                  </p>
                  <p>Brand Name</p>
                </div>
              </a>
              <div class="AddCartDiv">
                <button type="button" class="cartBtn">Add to Cart</button>
              </div>
              
            </div>--%>
            
          </div>
        </div>
        </section>
        <div class="space"></div>
    </main>
    
</asp:Content>
