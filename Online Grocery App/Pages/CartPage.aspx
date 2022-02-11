<%@ Page Title="" Language="C#" MasterPageFile="~/Master.Master" AutoEventWireup="true" CodeBehind="CartPage.aspx.cs" Inherits="Online_Grocery_App.Pages.CartPage" %>
<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="server">
    <link href="../css/CartPage.css" rel="stylesheet" />
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" runat="server">
    <main>
        <div class="space"></div>
        <section>
            <asp:Panel ID="Panel1" runat="server"></asp:Panel>
        </section>
        <div class="space"></div>
    </main>
</asp:Content>
