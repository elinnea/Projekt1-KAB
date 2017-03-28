<%@ Page Title="" Language="C#" MasterPageFile="~/master.Master" AutoEventWireup="true" CodeBehind="index.aspx.cs" Inherits="Projekt1_KAB.index" %>

<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="server">
<%--    <script>
        function BuyItem(id) {
            console.log(id);
            //Session["Item"] = id;
            //Response.Redirect("Cart.aspx");
        }
    </script>--%>
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" runat="server">

    <div class="container">
        <div class="row">
            <form id="articlesForm" runat="server"></form>
            <asp:literal id="dynamicArticles" runat="server"></asp:literal>
        </div>
    </div>

</asp:Content>
