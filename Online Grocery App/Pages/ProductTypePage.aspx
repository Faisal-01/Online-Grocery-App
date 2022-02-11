<%@ Page Title="" Language="C#" MasterPageFile="~/Master.Master" AutoEventWireup="true" CodeBehind="ProductTypePage.aspx.cs" Inherits="Online_Grocery_App.Pages.ProductTypePage" %>
<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="server">
    <link href="../css/ProductTypePage.css" rel="stylesheet" />
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" runat="server">
    <main>
        <div class="space"></div>
        <section>
            <h1 class="categoryName" id="producttypeName" runat="server">Rice</h1>
            <hr>
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
        </section>



        <div class="space"></div>
    </main>
</asp:Content>
