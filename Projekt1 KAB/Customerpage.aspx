<%@ Page Title="" Language="C#" MasterPageFile="~/master.Master" AutoEventWireup="true" CodeBehind="Customerpage.aspx.cs" Inherits="Projekt1_KAB.Redirectpage" %>

<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="server">
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" runat="server">
    <form id="formCustomerpage" runat="server">
        <div>

            <h2>Kundnummer:<asp:Label ID="Label1" runat="server"></asp:Label></h2>
            <asp:Literal ID="Literal1" runat="server"></asp:Literal>
        </div>
        <div>
            <asp:Button ID="Button1" runat="server" Height="47px" OnClick="Button1_Click"
                Text="Logout" Width="92px" />
        </div>
    </form>

</asp:Content>
