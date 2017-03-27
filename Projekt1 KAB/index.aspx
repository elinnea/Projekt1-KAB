<%@ Page Title="" Language="C#" MasterPageFile="~/master.Master" AutoEventWireup="true" CodeBehind="index.aspx.cs" Inherits="Projekt1_KAB.index" %>

<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="server">
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" runat="server">    

<div class="container">    
  <div class="row">
      <asp:Literal ID="dynamicArticles" runat="server"></asp:Literal>
  </div>
</div>
</asp:Content>
