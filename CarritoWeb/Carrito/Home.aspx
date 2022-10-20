<%@ Page Title="" Language="C#" MasterPageFile="~/Master.Master" AutoEventWireup="true" CodeBehind="Home.aspx.cs" Inherits="Carrito.Home" %>

<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="server">
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="MainContent" runat="server">
    <div class="row row-cols-1 row-cols-md-5 g-4">
        <asp:Repeater ID="repRepeater" runat="server">
            <ItemTemplate>
                <div class="col">
                    <div class="card h-30">
                        <img src="<%#Eval("UrlImagen") %>" class="card-img-top" alt="..." " >
                        <div class="card-body">
                            <h5 class="card-title"><%#Eval("Nombre") %></h5>
                            <p class="card-text"><%#Eval("Descripcion") %></p>
                            <a href="DetalleProducto.aspx?id=<%#Eval("IdArticulo") %>">Añadir al carrito</a>
                        </div>
                    </div>
                </div>

            </ItemTemplate>

        </asp:Repeater>
    </div>
</asp:Content>
