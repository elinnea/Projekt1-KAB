﻿<%@ Page Title="" Language="C#" MasterPageFile="~/master.Master" AutoEventWireup="true" CodeBehind="Cart.aspx.cs" Inherits="Projekt1_KAB.Cart" %>
<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="server">
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" runat="server">
    <asp:Literal ID="Literal1" runat="server"></asp:Literal>
        <div class="container">
        <div class="row">
            <asp:literal id="dynamicCart" runat="server"></asp:literal>
        </div>
    </div>
</asp:Content>
