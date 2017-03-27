<%@ Page Title="" Language="C#" MasterPageFile="~/master.Master" AutoEventWireup="true" CodeBehind="index.aspx.cs" Inherits="Projekt1_KAB.index" %>

<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="server">
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" runat="server">
    
    <div id ="articles">        
        <asp:PlaceHolder ID="PlaceHolder1" runat="server">
            <asp:Literal ID="LiteralArticleName" runat="server"></asp:Literal>
            <asp:Image ID="Image1" runat="server" />
            <asp:Literal ID="LiteralArticleDescription" runat="server"></asp:Literal>
            <asp:Literal ID="LiteralPrice" runat="server"></asp:Literal>
            <asp:CheckBox ID="CheckBoxInStock" runat="server" />
        </asp:PlaceHolder>
    </div>
</asp:Content>
