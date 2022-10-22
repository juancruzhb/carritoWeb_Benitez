<%@ Page Title="" Language="C#" MasterPageFile="~/Master.Master" AutoEventWireup="true" CodeBehind="Carrito.aspx.cs" Inherits="Carrito.Carrito" %>

<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="server">
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="MainContent" runat="server">
    <h2>Detalle de productos</h2>
    <div>
        <a href="Home.aspx">Seguir comprando</a>
        <hr />
        <asp:GridView runat="server" ID="dgCarrito" CssClass="table" AutoGenerateColumns="false">
            <Columns>
                <asp:BoundField HeaderText="Producto" DataField="oArticulo.Nombre" />
                <asp:BoundField HeaderText="Descripcion" DataField="oArticulo.Descripcion" />
                <asp:BoundField HeaderText="Marca" DataField="oArticulo.oMarca.Descripcion" />
                <asp:BoundField HeaderText="Cantidad" DataField="Cantidad" />
                <asp:BoundField HeaderText="Precio" DataField="oArticulo.Precio" />
                <asp:CommandField ShowDeleteButton="true" ButtonType="Button" />

            </Columns>
        </asp:GridView>
        <div class="container">
            <asp:Button Text="Finaliza compra" CssClass="btn btn-primary" runat="server" />
        </div>
    </div>
</asp:Content>
