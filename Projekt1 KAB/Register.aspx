<%@ Page Title="" Language="C#" MasterPageFile="~/master.Master" AutoEventWireup="true" CodeBehind="Register.aspx.cs" Inherits="Projekt1_KAB.Register" %>

<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="server">
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" runat="server">
    <form runat="server">
<center>
    <table id="regtable" style="text-align: left">
        
        <asp:Label ID="LabelRegisterBox" style="font:bold 18px verdana; text-align: left" runat="server" Text="Registrera dig som kund"></asp:Label>

        <tr><td>Användarnamn: </td><td><asp:TextBox ID="TextBoxUserName" placeholder=" Ange användarnamn" runat="server"></asp:TextBox></td></tr>
        <tr><td>Lösenord: </td><td><asp:TextBox ID="TextBoxPassWord" placeholder=" Lösenord, minst sex tecken" runat="server"></asp:TextBox></td></tr>
        <tr><td>Förnamn: </td><td><asp:TextBox ID="TextBoxFirstName" placeholder=" Ange förnamn" runat="server"></asp:TextBox></td></tr>
        <tr><td>Efternamn: </td><td><asp:TextBox ID="TextBoxLastName" placeholder=" Ange efternamn" runat="server"></asp:TextBox></td></tr>
        <tr><td>Adress: </td><td><asp:TextBox ID="TextBoxAdress" placeholder=" Ange adress" runat="server"></asp:TextBox></td></tr>
        <tr><td>Postnr: </td><td><asp:TextBox ID="TextBoxZip" placeholder=" Ange postnummer" runat="server"></asp:TextBox></td></tr>
        <tr><td>Ort: </td><td><asp:TextBox ID="TextBoxCity" placeholder=" Ange ort/stad" runat="server"></asp:TextBox></td></tr>
        <tr><td>Landskod: </td><td><asp:TextBox ID="TextBoxCountryCode" placeholder=" ex. SE för Sverige" runat="server"></asp:TextBox></td></tr>
        <tr><td>E-mail: </td><td><asp:TextBox ID="TextBoxEmail" placeholder=" Ange e-mailadress" runat="server"></asp:TextBox></td></tr>
        <tr><td>Telefonnummer: </td><td><asp:TextBox ID="TextBoxPhoneNumber" placeholder=" Ange telefonnummer" runat="server"></asp:TextBox></td></tr>
        <tr><td></td><td></td></tr>
        <tr><td></td><td><asp:Button ID="ButtonRegister" class="btn btn-success btn-block" runat="server" Text="Registrera dig" OnClick="ButtonRegister_Click"></asp:Button></td></tr>
        <tr><td colspan="2">
                <asp:Label ID="LabelSuccess" runat="server" Text="Välkommen som kund!" Visible="false" ForeColor="Green"></asp:Label>
            </td></tr>
    </table>

    </center>

        </form>
</asp:Content>
