﻿<%@ Page Title="" Language="C#" MasterPageFile="~/master.Master" AutoEventWireup="true" CodeBehind="MyPages.aspx.cs" Inherits="Projekt1_KAB.MyPages" %>
<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="server">
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" runat="server">
    <table id="regtable" style="text-align: left">
       
       <asp:Label ID="LabelRegisterBox" style="font:bold 18px verdana; text-align: left" runat="server" Text="Mina uppgifter"></asp:Label>

       <tr><td>Kundnummer: </td><td><asp:Label ID="LabelCustomerID" runat="server"></asp:Label></td></tr>
       <tr><td>Användarnamn: </td><td><asp:Label ID="LabelUserName" runat="server"></asp:Label></td></tr>
       <tr><td>Lösenord: </td><td><asp:TextBox ID="TextBoxPassWord" runat="server"></asp:TextBox></td></tr>
       <tr><td>Förnamn: </td><td><asp:TextBox ID="TextBoxFirstName" runat="server"></asp:TextBox></td></tr>
       <tr><td>Efternamn: </td><td><asp:TextBox ID="TextBoxLastName" runat="server"></asp:TextBox></td></tr>
       <tr><td>Adress: </td><td><asp:TextBox ID="TextBoxAdress" runat="server"></asp:TextBox></td></tr>
       <tr><td>Postnr: </td><td><asp:TextBox ID="TextBoxZip" runat="server"></asp:TextBox></td></tr>
       <tr><td>Ort: </td><td><asp:TextBox ID="TextBoxCity" runat="server"></asp:TextBox></td></tr>
       <tr><td>Landskod: </td><td><asp:TextBox ID="TextBoxCountryCode" placeholder=" ex. SE för Sverige" runat="server"></asp:TextBox></td></tr>
       <tr><td>E-mail: </td><td><asp:TextBox ID="TextBoxEmail" runat="server"></asp:TextBox></td></tr>
       <tr><td>Telefonnummer: </td><td><asp:TextBox ID="TextBoxPhoneNumber" runat="server"></asp:TextBox></td></tr>
       <tr><td></td><td></td></tr>
       <%--<tr><td></td><td><asp:Button ID="ButtonRegister" class="btn btn-success btn-block" runat="server" Text="Registrera dig" OnClick="ButtonRegister_Click"></asp:Button></td></tr>
       <tr><td colspan="2">
               <asp:Label ID="LabelSuccess" runat="server" Text="Välkommen som kund!" Visible="false" ForeColor="Green"></asp:Label>
           </td></tr>--%>
   </table>

</asp:Content>
