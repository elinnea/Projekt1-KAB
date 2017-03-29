<%@ Page Title="" Language="C#" MasterPageFile="~/master.Master" AutoEventWireup="true" CodeBehind="CreateOrder.aspx.cs" Inherits="Projekt1_KAB.CreateOrder" %>

<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="server">
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" runat="server">
        <form id="createOrder" runat="server">
<%--            <div class="container">--%>
                <div class="rowOrder">
                    <asp:Literal ID="dynamicOrder" runat="server"></asp:Literal>
                    <asp:Button ID="OrderInfo" runat="server" Text="Order info" OnClick="goToBetala_Click" />
                </div>
                <div class="rowOrder">
                    <asp:Literal ID="dynamicOrderDetails" runat="server"></asp:Literal>
                </div>
<%--            </div>--%>
        </form>
   
</asp:Content>
