<%@ Page Title="" Language="C#" MasterPageFile="~/master.Master" AutoEventWireup="true" CodeBehind="Cart.aspx.cs" Inherits="Projekt1_KAB.Cart" %>

<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="server">
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" runat="server">
    <asp:Literal ID="Literal1" runat="server"></asp:Literal>

    <div class="container">
        <div class="row">
            <asp:Literal ID="dynamicCart" runat="server"></asp:Literal>
        </div>
    </div>

</asp:Content>
