<%@ Page Title="" Language="C#" MasterPageFile="~/master.Master" AutoEventWireup="true" CodeBehind="Login.aspx.cs" Inherits="Projekt1_KAB.LoginForm_demo" %>

<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="server">
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" runat="server">
    <form id="formLogin" runat="server">
        <center><div>
            <table style="text-align:left">
                <asp:Label ID="LabelRegisterBox" style="font:bold 22px glyphicon; text-align: left" runat="server" Text="Logga in"></asp:Label>
                
                    <td class="style2"></td><td></td><td></td>
                <tr><td class="style2">Användarnamn:</td>
                    <td><asp:TextBox ID="TextBoxUsername" placeholder="Ange användarnamn" runat="server"></asp:TextBox></td>
                    <td><%-- <asp:RequiredFieldValidator ID="RequiredFieldValidator2" runat="server" ControlToValidate="TextBoxUsername" ErrorMessage="Please Enter Your Username"
                                ForeColor="Red"></asp:RequiredFieldValidator>--%></td>
                </tr>
                <tr> <td class="style2">Lösenord:</td>
                    <td><asp:TextBox ID="TextBoxPassword" placeholder="Ange lösenord" TextMode="Password" runat="server"></asp:TextBox></td>
                    <td> <%--<asp:RequiredFieldValidator ID="RequiredFieldValidator1" runat="server" ControlToValidate="TextBox2" ErrorMessage="Please Enter Your Password"
                                ForeColor="Red"></asp:RequiredFieldValidator>--%></td>
                </tr>
                <tr><td class="style2"></td><td></td><td></td></tr>
                <tr><td class="style2"></td>
                    <td><asp:Button class="btn btn-primary btn-block" ID="ButtonLogIN" runat="server" Text="Logga in" OnClick="ButtonLogIN_Click" /></td>
                </tr>
            </table>
                    <asp:Label ID="LabelLoginMsg" runat="server"></asp:Label>
            <div style="float:none">
            Är du inte kund hos oss ännu? <br />
             <a href="Register.aspx" style="text-decoration-line:underline">Registera dig idag!</a>
            </div>
        </div></center>
    </form>
</asp:Content>
