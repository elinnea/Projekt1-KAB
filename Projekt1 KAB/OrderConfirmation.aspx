﻿<%@ Page Title="" Language="C#" MasterPageFile="~/master.Master" AutoEventWireup="true" CodeBehind="OrderConfirmation.aspx.cs" Inherits="Projekt1_KAB.OrderConfirmation" %>
<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="server">
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" runat="server">
    <form runat="server">
        <div>
           <p style="text-align: center; font:bold 22px glyphicon"> Tack för din beställning, ditt ordernummer är: <asp:Literal ID="orderNo" runat="server"></asp:Literal></p>
            <p style="text-align: center; font:bold 22px glyphicon">Ha en underbar dag! </p>
               </>
        </div>

        </form>
</asp:Content>
