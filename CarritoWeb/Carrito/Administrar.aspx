<%@ Page Title="" Language="C#" MasterPageFile="~/Master.Master" AutoEventWireup="true" CodeBehind="Administrar.aspx.cs" Inherits="Carrito.Administrar" EnableViewState="true" %>

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
                                <asp:TextBox runat="server" ID="txtCodigo" />
                            </div>
                            <div>
                                <asp:Label Text="Nombre: " runat="server" />
                                <asp:TextBox runat="server" ID="txtNombre" />
                            </div>
                            <div>
                                <asp:DropDownList ID="ddlMarca" runat="server"></asp:DropDownList>
                            </div>
                            <div>
                                <asp:DropDownList ID="ddlCategoria" runat="server"></asp:DropDownList>
                            </div>
                            <div>
                                <asp:Label Text="Descripcion: " runat="server" />
                                <asp:TextBox ID="txtDescripcion" runat="server" />
                            </div>
                            <div>
                                <asp:Label Text="Precio: " runat="server" />
                                <asp:TextBox runat="server" ID="txtPrecio" />
                            </div>
                            <div>
                                <asp:Label Text="UrlImagen: " runat="server" />
                                <asp:TextBox runat="server" ID="txtUrlImagen" />
                            </div>

                        </div>
                        <div class="modal-footer">
                            <button type="button" class="btn btn-secondary" data-bs-dismiss="modal">Cancelar</button>
                            <asp:Button Text="Aceptar" ID="btnAceptar" runat="server" CssClass="btn btn-primary" OnClick="btnAceptar_Click" />
                        </div>
                    </div>
                </div>
            </div>
        </div>
        <div class="container">
            <hr />
            <asp:GridView ID="gvArticulos" runat="server" CssClass="table" AutoGenerateColumns="false">
                <Columns>
                    <asp:BoundField HeaderText="Codigo" DataField="Codigo" />
                    <asp:BoundField HeaderText="Nombre" DataField="Nombre" />
                    <asp:BoundField HeaderText="Descripcion" DataField="Descripcion" />
                    <asp:BoundField HeaderText="Marca" DataField="oMarca.Descripcion" />
                    <asp:BoundField HeaderText="Categoria" DataField="oCategoria.Descripcion" />
                    <asp:BoundField HeaderText="Precio" DataField="Precio" />
                    <asp:CommandField ShowEditButton="true" ButtonType="Button" />
                    <asp:CommandField ShowDeleteButton="true" ButtonType="Button" />
                    <asp:TemplateField>
                        <ItemTemplate>
                            <asp:Button ID="deletebtn" runat="server" CommandName="Delete"
                                Text="Delete" OnClientClick="return confirm('Are you sure?');" />
                        </ItemTemplate>
                    </asp:TemplateField>
                </Columns>
            </asp:GridView>

        </div>
    </div>
</asp:Content>
