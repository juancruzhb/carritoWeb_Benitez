<%@ Page Title="" Language="C#" MasterPageFile="~/Master.Master" AutoEventWireup="true" CodeBehind="Home.aspx.cs" Inherits="Carrito.Home" EnableEventValidation="false" %>

<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="server">

</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="MainContent" runat="server">
    <div>
        <div class="btn-group" >
            <asp:DropDownList ID="ddlCategorias" runat="server" CssClass="form-control">
            </asp:DropDownList>
            <asp:DropDownList ID="ddlMarcas" runat="server"></asp:DropDownList>
            <asp:Button ID="btbBuscarMC" runat="server" Text="Filtrar" CssClass="btn btn-primary" />
            <asp:Label ID="Label2" runat="server" Text="Label">Busqueda: </asp:Label>
            <asp:TextBox ID="txtBuscar" runat="server" OnTextChanged ="txtBuscar_TextChanged"></asp:TextBox>
            <asp:Button ID="Button2" runat="server" Text="Buscar" CssClass="btn btn-primary"  />
        </div>
        <hr />
    </div>
    <div class="row row-cols-1 row-cols-md-5 g-4">
        <asp:Repeater ID="repRepeater" runat="server">
            <ItemTemplate>
                <div class="col">
                    <div class="card">
                        <img src="<%#Eval("UrlImagen") %>" class="card-img-top" alt="..." " >
                        <div class="card-body">
                            <h5 class="card-title"><%#Eval("Nombre") %></h5>
                            <p class="card-text"><%#Eval("Descripcion") %></p>
                            <asp:Label ID="Label1" runat="server" >$ <%#Eval("Precio") %></asp:Label>
                            <div class="d-flex justify-content-lg-start">
                                <div class="d-grid gap-2 col-6 mx-auto">
                                <asp:LinkButton Text="Agregar a Carrito" CssClass="btn btn-primary"  ID="lbAgregar_a_Carrito" CommandName="IdArticulo" CommandArgument='<%#Eval("IdArticulo")%>' runat="server" OnCommand="lbAgregar_a_Carrito_Command" />
                                <a class="btn btn-primary" href="ArticuloDetalle.aspx?IdArticulo=<%#Eval("IdArticulo") %>">Ver detalles</a>
                                </div>
                            </div>
                             <div class="d-flex justify-content-lg-start">
                            </div>
                        </div>
                    </div>
                </div>

            </ItemTemplate>

        </asp:Repeater>
    </div>
</asp:Content>
