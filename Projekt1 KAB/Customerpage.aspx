﻿<%@ Page Title="" Language="C#" MasterPageFile="~/master.Master" AutoEventWireup="true" CodeBehind="Customerpage.aspx.cs" Inherits="Projekt1_KAB.Redirectpage" %>

<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="server">
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" runat="server">
    <div>
        <asp:Label ID="Label1" runat="server"></asp:Label>
        <asp:Button ID="Button1" runat="server" Height="47px" OnClick="Button1_Click"
            Text="Logout" Width="92px" />
    </div>

</asp:Content>
