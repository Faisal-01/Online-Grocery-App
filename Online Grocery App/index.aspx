<%@ Page Title="" Language="C#" MasterPageFile="~/Master.Master" AutoEventWireup="true" CodeBehind="index.aspx.cs" Inherits="Online_Grocery_App.index" %>
<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="server">
    <script defer src="javascript/index.js"></script>
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" runat="server">
    <div id="slider">
      <picture>
        <source media="(max-width:650px)" srcset="./Images/sliderSmall1.jpg" />
        <img src="./Images/slider1.jpg" alt="" />
      </picture>
      <i class="leftArrow fa fa-chevron-circle-left"></i>

      <i class="rightArrow fa fa-chevron-circle-right"></i>
    </div>
    <main>
      <div class="space"></div>

      <section>
        <div id="section1">
          <br />
          <div class="sectionName">
            <h1 class="heading">Our Exclusive Products</h1>
            <button onserverclick="BtnViewExclusive" type="button" runat="server">
              View All
            </button>
          </div>
          

          <div class="ProductsDiv" runat="server" id="productDiv1">
              <asp:Panel CssClass="panel-class" ID="Panel1" runat="server">

              </asp:Panel>
          </div>
        </div>

        <div id="section2">
          <br />
          <div class="sectionName">
            <h1 class="heading">Latest Products</h1>

            <button onserverclick="BtnViewLatest" type="button" runat="server">
              View All
            </button>
          </div>

          <div class="ProductsDiv" runat="server" id="productDiv2">
            <asp:Panel CssClass="panel-class" ID="Panel2" runat="server">

              </asp:Panel>
              
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

        <div id="section3">
          <br />
          <div class="sectionName">
            <h1 class="heading">Just for You</h1>

            <button onserverclick="BtnViewForAll" type="button" runat="server">
              View All
            </button>
          </div>

          <div class="ProductsDiv" id="productDiv3" runat="server">
            <asp:Panel CssClass="panel-class" ID="Panel3" runat="server">

              </asp:Panel>
          </div>
        </div>
      </section>

      <div class="space"></div>
    </main>
    <script src="javascript/addCart.js"></script>
</asp:Content>
