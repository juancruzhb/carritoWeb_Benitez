<%@ Page Title="" Language="C#" MasterPageFile="~/Master.Master" AutoEventWireup="true" CodeBehind="Administrar.aspx.cs" Inherits="Carrito.Administrar" EnableViewState="true"%>

<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="server">
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="MainContent" runat="server">
    <div>
        <div>
            <button type="button" class="btn btn-primary" data-bs-toggle="modal" data-bs-target="#staticBackdrop">
                Agregar nuevo
            </button>

            <!-- Modal -->
            <div class="modal fade " id="staticBackdrop" data-bs-backdrop="static" data-bs-keyboard="false" tabindex="-1" aria-labelledby="staticBackdropLabel" aria-hidden="true">
                <div class="modal-dialog modal-dialog-centered">
                    <div class="modal-content">
                        <div class="modal-header">
                            <h1 class="modal-title fs-5" id="staticBackdropLabel">Articulo nuevo</h1>
                            <button type="button" class="btn-close" data-bs-dismiss="modal" aria-label="Close"></button>
                        </div>
                        <div class="modal-body">
                            <div>
                                <asp:Label Text="Codigo: " runat="server" />
                                <asp:TextBox runat="server" Id="txtCodigo"/>
                            </div>
                            <div>
                                <asp:Label Text="Nombre: " runat="server" />
                                <asp:TextBox runat="server" ID="txtNombre"/>
                            </div>
                            <div>
                                <asp:DropDownList ID="ddlMarca" runat="server"></asp:DropDownList>
                            </div>
                             <div>
                                <asp:DropDownList ID="ddlCategoria" runat="server"></asp:DropDownList>
                            </div>
                            <div>
                                <asp:Label Text="Descripcion: " runat="server"  />
                                <asp:TextBox ID="txtDescripcion" runat="server" />
                            </div>
                            <div>
                                <asp:Label Text="Precio: " runat="server"  />
                                <asp:TextBox runat="server" ID="txtPrecio"/>
                            </div>
                            <div>
                                <asp:Label Text="UrlImagen: " runat="server" />
                                <asp:TextBox runat="server" ID="txtUrlImagen" />
                            </div>

                        </div>
                        <div class="modal-footer">
                            <button type="button" class="btn btn-secondary" data-bs-dismiss="modal">Cancelar</button>
                            <asp:Button Text="Aceptar" Id="btnAceptar" runat="server" CssClass="btn btn-primary" OnClick="btnAceptar_Click"  />
                        </div>
                    </div>
                </div>
            </div>
        </div>
        <asp:GridView ID="gvArticulos" runat="server" CssClass="table"></asp:GridView>
    </div>
</asp:Content>
