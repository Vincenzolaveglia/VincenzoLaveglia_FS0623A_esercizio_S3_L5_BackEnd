<%@ Page Title="" Language="C#" MasterPageFile="~/Templates/BaseTemplate.Master" AutoEventWireup="true" CodeBehind="Cart.aspx.cs" Inherits="Ecommerce.Cart" %>

<asp:Content ID="Content1" ContentPlaceHolderID="Main" runat="server">
    <div class="d-flex justify-content-center">
        <a href="Index.aspx" class="btn btn-primary">HomePage</a>
    </div>
    <div class="container mt-5">
        <div class="row">
            <div class="col">
                <h2>Carrello</h2>
                <hr />
                <asp:Table ID="cartTable" runat="server" CssClass="table table-bordered">
                    <asp:TableHeaderRow>
                        <asp:TableHeaderCell>Nome Prodotto</asp:TableHeaderCell>
                        <asp:TableHeaderCell>Prezzo</asp:TableHeaderCell>
                    </asp:TableHeaderRow>
                </asp:Table>
            </div>
        </div>
        <div class="row mt-3">
            <div class="col">
                <hr />
                <h4>Totale</h4>
                <asp:Table ID="TotalTbl" runat="server" CssClass="table table-bordered">
                    <asp:TableHeaderRow>
                    </asp:TableHeaderRow>
                </asp:Table>
            </div>
        </div>
        <div class="d-flex justify-content-center">
            <asp:Button ID="btnEmptyCart" class="btn btn-danger" runat="server" Text="Svuota Carrello" OnClick="btnRemoveToCart" />
        </div>
    </div>
</asp:Content>
