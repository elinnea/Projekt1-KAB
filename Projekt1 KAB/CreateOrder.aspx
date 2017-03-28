<%@ Page Title="" Language="C#" MasterPageFile="~/master.Master" AutoEventWireup="true" CodeBehind="CreateOrder.aspx.cs" Inherits="Projekt1_KAB.CreateOrder" %>

<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="server">
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" runat="server">
        <form id="createOrder" runat="server">
            <asp:Literal ID="Literal1" runat="server"></asp:Literal>
            <div class="container">
                <div class="rowOrder">
                    <asp:Literal ID="dynamicOrder" runat="server"></asp:Literal>
                   <%-- <asp:Button ID="logOut" runat="server" Text="Logga ut" OnClick="goToCreateOrder_Click" />--%>
                </div>
                <div class="rowOrder">
                    <asp:Literal ID="dynamicOrderDetails" runat="server"></asp:Literal>
                </div>
            </div>
        </form>
   
</asp:Content>
