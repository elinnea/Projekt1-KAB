<%@ Page Title="" Language="C#" MasterPageFile="~/master.Master" AutoEventWireup="true" CodeBehind="MyPages.aspx.cs" Inherits="Projekt1_KAB.MyPages" %>

<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="server">
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" runat="server">
    <form id="formMyPages" runat="server" method="post">
        <table id="regtable" style="text-align: left">

            <asp:Label ID="LabelWelcome" Style="font: bold 18px verdana; text-align: center" runat="server"></asp:Label><br />
            <asp:Literal ID="LiteralWelcome" runat="server"></asp:Literal><br />

            <asp:Label ID="LabelRegisterBox" Style="font: bold 16px verdana; text-align: left" runat="server" Text="Mina uppgifter"></asp:Label>

            <tr>
                <td>Kundnummer: </td>
                <td>
                    <asp:Label ID="LabelCustomerID" runat="server"></asp:Label></td>
            </tr>
            <tr>
                <td>Användarnamn: </td>
                <td>
                    <asp:Label ID="LabelUserName" runat="server"></asp:Label></td>
            </tr>
            <tr>
                <td>Lösenord: </td>
                <td>
                    <asp:TextBox ID="TextBoxPassWord" runat="server"></asp:TextBox></td>
            </tr>
            <tr>
                <td>Förnamn: </td>
                <td>
                    <asp:TextBox ID="TextBoxFirstName" runat="server"></asp:TextBox></td>
            </tr>
            <tr>
                <td>Efternamn: </td>
                <td>
                    <asp:TextBox ID="TextBoxLastName" runat="server"></asp:TextBox></td>
            </tr>
            <tr>
                <td>Adress: </td>
                <td>
                    <asp:TextBox ID="TextBoxAdress" runat="server"></asp:TextBox></td>
            </tr>
            <tr>
                <td>Postnr: </td>
                <td>
                    <asp:TextBox ID="TextBoxZip" runat="server"></asp:TextBox></td>
            </tr>
            <tr>
                <td>Ort: </td>
                <td>
                    <asp:TextBox ID="TextBoxCity" runat="server"></asp:TextBox></td>
            </tr>
            <tr>
                <td>Landskod: </td>
                <td>
                    <asp:TextBox ID="DropDownListCountryCode" placeholder=" ex. SE för Sverige" runat="server"></asp:TextBox></td>
            </tr>
            <tr>
                <td>E-mail: </td>
                <td>
                    <asp:TextBox ID="TextBoxEmail" runat="server"></asp:TextBox></td>
            </tr>
            <tr>
                <td>Telefonnummer: </td>
                <td>
                    <asp:TextBox ID="TextBoxPhoneNumber" runat="server"></asp:TextBox></td>
            </tr>
            <tr>
                <td></td>
                <td></td>
            </tr>

       <tr><td>Kundnummer: </td><td><asp:Label ID="LabelCustomerID" runat="server"></asp:Label></td></tr>
       <tr><td>Användarnamn: </td><td><asp:Label ID="LabelUserName" runat="server"></asp:Label></td></tr>
       <tr><td>Lösenord: </td><td><asp:TextBox ID="TextBoxPassWord" runat="server"></asp:TextBox></td></tr>
       <tr><td>Förnamn: </td><td><asp:TextBox ID="TextBoxFirstName" runat="server"></asp:TextBox></td></tr>
       <tr><td>Efternamn: </td><td><asp:TextBox ID="TextBoxLastName" runat="server"></asp:TextBox></td></tr>
       <tr><td>Adress: </td><td><asp:TextBox ID="TextBoxAdress" runat="server"></asp:TextBox></td></tr>
       <tr><td>Postnr: </td><td><asp:TextBox ID="TextBoxZip" runat="server"></asp:TextBox></td></tr>
       <tr><td>Ort: </td><td><asp:TextBox ID="TextBoxCity" runat="server"></asp:TextBox></td></tr>
        <tr><td>Landskod: </td><td><asp:DropDownList ID="DropDownListCountryCode" runat="server"><asp:ListItem>SE</asp:ListItem><asp:ListItem>NO</asp:ListItem><asp:ListItem>FI</asp:ListItem></asp:DropDownList></td></tr>
       <tr><td>E-mail: </td><td><asp:TextBox ID="TextBoxEmail" runat="server"></asp:TextBox></td></tr>
       <tr><td>Telefonnummer: </td><td><asp:TextBox ID="TextBoxPhoneNumber" runat="server"></asp:TextBox></td></tr>
       <tr><td></td><td></td></tr>     
   </table>

        </table>
        <table>
        <tr>
            <td></td>
            <td>
                <asp:Button ID="ButtonUpdateCustomer" class="btn btn-primary btn-block" runat="server" Text="Ändra" OnClick="ButtonUpdateCustomer_Click"></asp:Button></td>
        </tr>
         </table>
        <div class="rowOrder">
            <asp:Literal ID="LiteralOrderHeadInfo" runat="server"></asp:Literal>
            <asp:Literal ID="dynamicOrderHead" runat="server"></asp:Literal>
        </div>
    </form>
</asp:Content>
