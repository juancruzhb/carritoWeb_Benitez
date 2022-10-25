<%@ Page Title="" Language="C#" MasterPageFile="~/Master.Master" AutoEventWireup="true" CodeBehind="Carrito.aspx.cs" Inherits="Carrito.Carrito" EnableEventValidation="false" %>

<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="server">
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="MainContent" runat="server">
    <h2>Detalle de productos</h2>
    <div>
        <a href="Home.aspx">Seguir comprando</a>
        <hr />
        <asp:GridView runat="server" ID="dgCarrito" CssClass="table" AutoGenerateColumns="false" OnSelectedIndexChanged="dgCarrito_SelectedIndexChanged">
            <Columns>
                <asp:BoundField HeaderText="Id" DataField="oArticulo.IdArticulo" Visible="true" />
                <asp:BoundField HeaderText="Producto" DataField="oArticulo.Nombre" />
                <asp:BoundField HeaderText="Descripcion" DataField="oArticulo.Descripcion" />
                <asp:BoundField HeaderText="Marca" DataField="oArticulo.oMarca.Descripcion" />
                <asp:TemplateField>
                    <ItemTemplate>
                        <asp:LinkButton Text=" - " ID="btnSuprimir" CssClass="btn btn-danger" CommandName="IdArticulo" CommandArgument='<%#Eval("oArticulo.IdArticulo") %>' runat="server" OnCommand="btnSuprimir_Command" />
                    </ItemTemplate>
                </asp:TemplateField>
                <asp:BoundField HeaderText="Cantidad" DataField="Cantidad" />
                <asp:TemplateField>
                    <ItemTemplate>
                        <asp:LinkButton Text=" + " ID="btnSumar" CssClass="btn btn-success" CommandName="IdArticulo" CommandArgument='<%#Eval("oArticulo.IdArticulo") %>' runat="server" OnCommand="btnSumar_Command" />
                    </ItemTemplate>
                </asp:TemplateField>
                <asp:BoundField HeaderText="Precio" DataField="oArticulo.Precio" />
                <asp:CommandField ShowSelectButton="true" SelectText="Eliminar" HeaderText="Accion" />
            </Columns>
        </asp:GridView>
        <div class="align-content-center">

            <asp:Label Text="Total a pagar: " runat="server" ID="lblTotal" />
            <asp:Label Text="$" runat="server" ID="lblPrecio" />
        </div>
        <div class="container">
            <asp:Button Text="Finalizar compra" CssClass="btn btn-primary" runat="server" OnClientClick="return false;" />
        </div>
    </div>
</asp:Content>
