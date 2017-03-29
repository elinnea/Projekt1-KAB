<%@ Page Title="" Language="C#" MasterPageFile="~/master.Master" AutoEventWireup="true" CodeBehind="Administratorpage.aspx.cs" Inherits="Projekt1_KAB.Administratorpage" %>
<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="server">
    <style type="text/css">
        .auto-style1 {
            height: 22px;
        }
        .auto-style2 {
            height: 24px;
        }
        .auto-style3 {
            height: 27px;
        }
    </style>
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" runat="server">
    <form id="form1" runat="server">
   
        <table style="width:35%; float:left">
        <tr><td>&nbsp;</td>
            <td>&nbsp;</td>
            <td>&nbsp;</td>

        </tr>
        <td></td><td><asp:Label style="font:bold 18px verdana; text-align: left" runat="server" Text="Lägg till artikelnummer"></asp:Label></td>
        <tr><td></td><td>Artikelnummer</td><td><asp:Label ID="LabelArticleID" runat="server" Text="Label"></asp:Label></td></tr>

        <tr><td></td><td>Namn</td><td><asp:TextBox class="textboxes" ID="TextBoxArticleName" placeholder="Ange artikelnamn" runat="server"></asp:TextBox></td></tr>

        <tr><td></td><td class="auto-style1">Pris</td>
            <td class="auto-style1"><asp:TextBox class="textboxes" ID="TextBoxArticlePrice" placeholder="Ange artikelpris" runat="server"></asp:TextBox></td>
            

        <tr><td class="auto-style3"></td><td class="auto-style3">Kategori</td>
            <td class="auto-style3"><asp:TextBox class="textboxes" ID="TextBoxArticleCategory" placeholder="Ange artikelkategori" runat="server"></asp:TextBox></td>
           
        
        <tr><td></td><td class="auto-style2">Beskrivning</td>
            <td class="auto-style2"><asp:TextBox class="textboxes" ID="TextBoxArticleDescription" placeholder="Ange beskrivning" runat="server"></asp:TextBox></td>
            
        
        <tr><td></td><td><asp:Label ID="LabelURL" runat="server" Text="URL"></asp:Label></td>
            <td><asp:TextBox class="textboxes" ID="TextBoxURL" placeholder="Ange URL" runat="server"></asp:TextBox></td>
            <td>&nbsp;</td>
        </tr>
        <tr>
            <td></td><td>Aktiv</td>
            <td>
                <asp:CheckBox ID="CheckBoxIsActive" runat="server" OnCheckedChanged="CheckBoxIsActive_CheckedChanged" AutoPostBack="True" />
            </td>
            <td>&nbsp;</td>
        </tr>
        <tr>
            <td></td><td>I lager</td>
            <td>
                <asp:CheckBox ID="CheckBoxIsInStock" runat="server" OnCheckedChanged="CheckBoxIsInStock_CheckedChanged" AutoPostBack="True" />
            </td>
            <td>&nbsp;</td>
        </tr>
        <tr>
            <td>&nbsp;</td>
            <td></td><td>
                <asp:Button class="btn btn-primary" ID="ButtonAddArticle" runat="server" Text="Lägg till" OnClick="ButtonAddArticle_Click" />
                <asp:Button class="btn btn-primary" ID="ButtonUpdateArticle" runat="server" Text="Ändra" OnClick="ButtonUpdateArticle_Click" />
            </td>
            <td>&nbsp;</td>
        </tr>
    </table>
        
        <table style="float:inherit; height: 130px;">

             <tr><td><asp:Button class="btn btn-primary" ID="ButtonReadArticles" runat="server" OnClick="ButtonReadArticles_Click" Text="Se alla artiklar" />
            <asp:Button class="btn btn-primary" ID="ButtonReadInActiveArticles" runat="server" OnClick="ButtonReadInActiveArticles_Click" Text="Se inaktiva artiklar" />
                 </td></tr>
            <tr><td><asp:ListBox ID="ListBoxArticles" runat="server" AutoPostBack="True" OnSelectedIndexChanged="ListBoxArticles_SelectedIndexChanged" Height="252px" Width="357px"></asp:ListBox></td></tr>
        </table>

   
    </form>
</asp:Content>
