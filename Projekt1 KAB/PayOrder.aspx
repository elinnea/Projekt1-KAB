<%@ Page Title="" Language="C#" MasterPageFile="~/master.Master" AutoEventWireup="true" CodeBehind="PayOrder.aspx.cs" Inherits="Projekt1_KAB.PayOrder" %>

<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="server">
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" runat="server">
    <form class="form-horizontal" id="payform" runat="server">
        <div class="container">
            <fieldset>
                <legend>BETALNING</legend>
                <div class="form-group">
                    <label class="col-sm-3 control-label" for="card-holder-name">Namn</label>
                    <div class="col-sm-6">
                        <%--<input type="text" class="form-control" name="card-holder-name" id="card-holder-name" placeholder="Kortinnehavarens namn" />--%>
                        <asp:TextBox class="textboxes" ID="TextBoxCardName" placeholder=" Kortinnehavarens namn" runat="server"></asp:TextBox>
                    </div>
                </div>
                <div class="form-group">
                    <label class="col-sm-3 control-label" for="card-number">Kortnummer</label>
                    <div class="col-sm-6">
                        <%--<input type="text" class="form-control" name="card-number" id="card-number" placeholder="Kortnummer" />--%>
                        <asp:TextBox class="textboxes" ID="TextBoxCardNo" placeholder=" Kortnummer" MaxLength="16" runat="server"></asp:TextBox>
                    </div>
                </div>
                <div class="form-group">
                    <label class="col-sm-3 control-label" for="expiry-month">Utångsdatum</label>
                    <div class="col-sm-6">
                        <div class="row">
                            <div class="col-xs-6">
                                <select class="form-control col-sm-6" name="expiry-month" id="expiry-month">
                                    <option value="01">01</option>
                                    <option value="02">02</option>
                                    <option value="03">03</option>
                                    <option value="04">04</option>
                                    <option value="05">05</option>
                                    <option value="06">06</option>
                                    <option value="07">07</option>
                                    <option value="08">08</option>
                                    <option value="09">09</option>
                                    <option value="10">10</option>
                                    <option value="11">11</option>
                                    <option value="12">12</option>
                                </select>
                            </div>
                            <div class="col-xs-6">
                                <select class="form-control col-sm-6" name="expiry-year">
                                    <option value="17">2017</option>
                                    <option value="18">2018</option>
                                    <option value="19">2019</option>
                                    <option value="20">2020</option>
                                    <option value="21">2021</option>
                                    <option value="22">2022</option>
                                    <option value="23">2023</option>
                                </select>
                            </div>
                        </div>
                    </div>
                </div>
                <div class="form-group">
                    <label class="col-sm-3 control-label" for="cvv">CVV</label>
                    <div class="col-sm-3">
                        <%--<input type="text" class="form-control" name="cvv" id="cvv" placeholder="CVV kod" />--%>
                        <asp:TextBox class="textboxes" ID="TextBox1" placeholder=" CVV kod" MaxLength="3" runat="server"></asp:TextBox>
                    </div>
                </div>
                <div class="form-group">
                    <div class="col-sm-offset-3 col-sm-9">
                        <asp:Button ID="Button1" class="btn-primary btn-lg" runat="server" Text="BETALA" OnClick="Button1_Click" />
                        <%--<button type="button" class="btn btn-success">BETALA</button>--%>
                    </div>
                    <div class="row"></div>
                </div>
            </fieldset>
        </div>
    </form>
</asp:Content>
