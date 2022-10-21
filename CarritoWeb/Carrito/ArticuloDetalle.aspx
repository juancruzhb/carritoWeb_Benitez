<%@ Page Title="" Language="C#" MasterPageFile="~/Master.Master" AutoEventWireup="true" CodeBehind="ArticuloDetalle.aspx.cs" Inherits="Carrito.ArticuloDetalle1" %>

<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="server">
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="MainContent" runat="server">
    <asp:Repeater ID="pdRepeater" runat="server">
        <ItemTemplate>
            <div class="card" style="width: 40rem; margin: 0 auto">
                <div style="margin: 0 auto">
                    <img src="<%#Eval("UrlImagen") %>" class="card-img-top" alt="..." style="width:20rem">
                </div>
                <div class="card-body">
                    <h5 class="card-title"><%#Eval("Nombre") %></h5>
                    <p class="card-text"><%#Eval("Descripcion") %></p>
                </div>
                <ul class="list-group list-group-flush">
                    <li class="list-group-item">Marca: <%#Eval("oMarca.Descripcion") %></li>
                    <li class="list-group-item">Descripcion: <%#Eval("oCategoria.Descripcion") %></li>
                    <li class="list-group-item">Precio: <%#Eval("Precio") %></li>
                </ul>
                <div class="card-body">
                    <a href="Home.aspx" class="card-link">Seguir Comprando</a>
                    <a href="#" class="card-link">Agregar al Carrito</a>
                </div>
            </div>
        </ItemTemplate>
    </asp:Repeater>

</asp:Content>
