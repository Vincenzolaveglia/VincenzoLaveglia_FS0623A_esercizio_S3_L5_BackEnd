<%@ Page Title="" Language="C#" MasterPageFile="~/Templates/BaseTemplate.Master" AutoEventWireup="true" CodeBehind="Index.aspx.cs" Inherits="Ecommerce.Index" %>

<asp:Content ID="Content2" ContentPlaceHolderID="Main" runat="server">
    <div class="d-flex justify-content-center">
        <a href="Cart.aspx" class="btn btn-warning">Visualizza Carrello</a>
    </div>
    <div id="RowCards" class="row row-cols-1 row-cols-sm-2 row-cols-md-3 row-cols-lg-4 g-3 mt-3 mb-3 ms-2 me-2" runat="server"></div>
</asp:Content>
