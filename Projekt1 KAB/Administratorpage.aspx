<%@ Page Title="" Language="C#" MasterPageFile="~/master.Master" AutoEventWireup="true" CodeBehind="Administratorpage.aspx.cs" Inherits="Projekt1_KAB.Administratorpage" %>
<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="server">
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" runat="server">
    <table style="width:100%;">
        <tr>
            <td>&nbsp;</td>
            <td>&nbsp;</td>
            <td>&nbsp;</td>
        </tr>
        <tr>
            <td>Artikelnummer</td>
            <td>
                <asp:Label ID="LabelArticleNummer" runat="server" Text="Label"></asp:Label>
            </td>
            <td>&nbsp;</td>
        </tr>
        <tr>
            <td>Namn</td>
            <td>
                <asp:TextBox ID="TextBoxArticleName" runat="server"></asp:TextBox>
            </td>
            <td>&nbsp;</td>
        </tr>
        <tr>
            <td>Pris</td>
            <td>
                <asp:TextBox ID="TextBoxArticlePrice" runat="server"></asp:TextBox>
            </td>
            <td>&nbsp;</td>
        </tr>
        <tr>
            <td>Kategori</td>
            <td>
                <asp:TextBox ID="TextBoxArticleCategory" runat="server"></asp:TextBox>
            </td>
            <td>&nbsp;</td>
        </tr>
        <tr>
            <td>Beskrivning</td>
            <td>
                <asp:TextBox ID="TextBoxArticleDescription" runat="server"></asp:TextBox>
            </td>
            <td>&nbsp;</td>
        </tr>
        <tr>
            <td>Aktiv</td>
            <td>
                <asp:CheckBox ID="CheckBoxIsActive" runat="server" OnCheckedChanged="CheckBoxIsActive_CheckedChanged" AutoPostBack="True" />
            </td>
            <td>&nbsp;</td>
        </tr>
        <tr>
            <td>I lager</td>
            <td>
                <asp:CheckBox ID="CheckBoxIsInStock" runat="server" OnCheckedChanged="CheckBoxIsInStock_CheckedChanged" AutoPostBack="True" />
            </td>
            <td>&nbsp;</td>
        </tr>
        <tr>
            <td>&nbsp;</td>
            <td>
                <asp:Button ID="ButtonAddArticle" runat="server" Text="Lägg till" OnClick="ButtonAddArticle_Click" />
            </td>
            <td>&nbsp;</td>
        </tr>
    </table>
</asp:Content>
