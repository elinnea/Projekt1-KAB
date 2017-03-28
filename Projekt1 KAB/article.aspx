<%@ Page Title="" Language="C#" MasterPageFile="~/master.Master" AutoEventWireup="true" CodeBehind="article.aspx.cs" Inherits="Projekt1_KAB.article" %>
<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="server">
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" runat="server">    
    <asp:literal id="articleContent" runat="server"></asp:literal>
    <asp:CheckBox ID="CheckBoxInStock" runat="server" />
</asp:Content>
