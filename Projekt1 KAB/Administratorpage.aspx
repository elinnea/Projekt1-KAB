<%@ Page Title="" Language="C#" MasterPageFile="~/master.Master" AutoEventWireup="true" CodeBehind="Administratorpage.aspx.cs" Inherits="Projekt1_KAB.Administratorpage" %>
<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="server">
    <style type="text/css">
        .auto-style1 {
            height: 22px;
        }
    </style>
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
                <asp:Label ID="LabelArticleID" runat="server" Text="Label"></asp:Label>
            </td>
            <td>
                <asp:Button ID="ButtonReadArticles" runat="server" OnClick="ButtonReadArticles_Click" Text="Se alla artiklar" />
            </td>
        </tr>
        <tr>
            <td>Namn</td>
            <td>
                <asp:TextBox ID="TextBoxArticleName" runat="server"></asp:TextBox>
            </td>
            <td>
                <asp:ListBox ID="ListBoxArticles" runat="server" AutoPostBack="True" OnSelectedIndexChanged="ListBoxArticles_SelectedIndexChanged"></asp:ListBox>
            </td>
        </tr>
        <tr>
            <td class="auto-style1">Pris</td>
            <td class="auto-style1">
                <asp:TextBox ID="TextBoxArticlePrice" runat="server"></asp:TextBox>
            </td>
            <td class="auto-style1"></td>
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
                <asp:Button ID="ButtonUpdateArticle" runat="server" Text="Ändra" />
            </td>
            <td>&nbsp;</td>
        </tr>
    </table>
</asp:Content>
