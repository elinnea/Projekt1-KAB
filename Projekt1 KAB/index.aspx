<%@ Page Title="" Language="C#" MasterPageFile="~/master.Master" AutoEventWireup="true" CodeBehind="index.aspx.cs" Inherits="Projekt1_KAB.index" %>

<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="server">
    <script>
        function BuyItem(id) {
            $.getJSON("svc/svc_cart.aspx?AddToCart=1&articleID=" + id)
                .done(function (data) {
                    alert(data);
                })
        }
    </script>
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" runat="server">
    <div class="container">
<%--    <form id="formIndex">
        <div id="myCarousel" class="carousel slide" data-ride="carousel">
            <!-- Indicators -->
            <ol class="carousel-indicators">
                <li data-target="#myCarousel" data-slide-to="0" class="active"></li>
                <li data-target="#myCarousel" data-slide-to="1"></li>
                <li data-target="#myCarousel" data-slide-to="2"></li>
                <li data-target="#myCarousel" data-slide-to="3"></li>
            </ol>

            <!-- Wrapper for slides -->
            <div class="carousel-inner" role="listbox">
                <div class="item active">
                    <img src="Image/Rum.png" />
                    alt="Chania">
                    <div class="carousel-caption">
                        <h3>Chania</h3>
                        <p>The atmosphere in Chania has a touch of Florence and Venice.</p>
                    </div>
                </div>

                <div class="item">
                    <img src="Image/gard3-1024x600.jpg" />
                    alt="Flower">
                    <div class="carousel-caption">
                        <h3>Flowers</h3>
                        <p>Beatiful flowers in Kolymbari, Crete.</p>
                    </div>
                </div>
            </div>
        </div>
    </form>--%>
    
        <div class="row">
            <asp:Literal ID="dynamicArticles" runat="server"></asp:Literal>
        </div>
    </div>
</asp:Content>
