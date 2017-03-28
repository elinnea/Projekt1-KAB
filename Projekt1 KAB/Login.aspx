<%@ Page Title="" Language="C#" MasterPageFile="~/master.Master" AutoEventWireup="true" CodeBehind="Login.aspx.cs" Inherits="Projekt1_KAB.LoginForm_demo" %>

<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="server">
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" runat="server">
    <form id="formLogin" runat="server">
        <div>
            <table style="width: 100%;">
                <caption class="style1">
                    <strong>Login Form</strong>
                </caption>
                <tr>
                    <td class="style2"></td>
                    <td></td>
                    <td></td>
                </tr>
                <tr>
                    <td class="style2">Username:</td>
                    <td>
                        <asp:TextBox ID="TextBox1" runat="server"></asp:TextBox>
                    </td>
                    <td>
                        <%--<asp:RequiredFieldValidator ID="RequiredFieldValidator2" runat="server"
                                ControlToValidate="TextBox1" ErrorMessage="Please Enter Your Username"
                                ForeColor="Red"></asp:RequiredFieldValidator>--%>
                    </td>
                </tr>
                <tr>
                    <td class="style2">Password:</td>
                    <td>
                        <asp:TextBox ID="TextBox2" runat="server"></asp:TextBox>
                    </td>
                    <td>
                        <%--<asp:RequiredFieldValidator ID="RequiredFieldValidator1" runat="server"
                                ControlToValidate="TextBox2" ErrorMessage="Please Enter Your Password"
                                ForeColor="Red"></asp:RequiredFieldValidator>--%>
                    </td>
                </tr>
                <tr>
                    <td class="style2"></td>
                    <td></td>
                    <td></td>
                </tr>
                <tr>
                    <td class="style2"></td>
                    <td>
                        <asp:Button ID="Button1" runat="server" Text="Log In" OnClick="Button1_Click" />
                    </td>
                    <td>
                        <asp:Label ID="Label1" runat="server"></asp:Label>
                    </td>
                </tr>
            </table>
        </div>
    </form>
</asp:Content>
