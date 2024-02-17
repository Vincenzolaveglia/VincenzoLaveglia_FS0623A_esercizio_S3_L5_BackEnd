<%@ Page Title="" Language="C#" MasterPageFile="~/Templates/BaseTemplate.Master" AutoEventWireup="true" CodeBehind="Details.aspx.cs" Inherits="Ecommerce.Details" %>

<asp:Content ID="Content1" ContentPlaceHolderID="Main" runat="server">
     <div class="d-flex justify-content-center">
        <a href="Index.aspx" class="btn btn-primary me-2">HomePage</a>
        <a href="Cart.aspx" class="btn btn-warning">Visualizza Carrello</a>
    </div>
    <div class="container mt-5 mb-5">
        <div class="row justify-content-center">
            <div class="col-md-6">
                <div class="card shadow">
                    <div class="card-body">
                        <h3 class="card-title text-center mb-4">
                            <asp:Label ID="lblProductName" runat="server" CssClass="h4" />
                        </h3>
                        <div class="text-center mb-4">
                            <asp:Image ID="imgProduct" runat="server" CssClass="img-fluid rounded" Style="max-width: 250px; max-height: 250px;" />
                        </div>
                        <p class="card-text text-center">
                            <asp:Label ID="lblProductDescription" runat="server" CssClass="text-muted" />
                        </p>
                        <p class="card-text text-center">
                            <asp:Label ID="lblMoreDescription" runat="server" CssClass="text-muted" />
                        </p>
                        <p class="card-text text-center">
                            <asp:Label ID="lblProductPrice" runat="server" CssClass="h5 text-success" />
                        </p>
                        <div class="text-center">
                            <asp:Button ID="BtnAdd" runat="server" Text="Aggiungi al Carrello" CssClass="btn btn-primary" OnClick="BtnAddToCart" />
                        </div>
                    </div>
                </div>
            </div>
        </div>
    </div>
</asp:Content>
