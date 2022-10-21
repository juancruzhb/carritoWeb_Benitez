using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using negocio;
using dominio;

namespace Carrito
{
    public partial class Administrar : System.Web.UI.Page
    {
        List<Articulo> articulos = new List<Articulo>();
        List<Categoria> categorias = new List<Categoria>();
        List<Marca> marcas = new List<Marca>();
        protected void Page_Load(object sender, EventArgs e)
        {
            ArticuloNegocio negocio = new ArticuloNegocio();
            articulos = negocio.listar();

            gvArticulos.DataSource = articulos;
            gvArticulos.DataBind();

            MarcaNegocio marcaNegocio = new MarcaNegocio();
            CategoriaNegocio categoriaNegocio = new CategoriaNegocio();

            marcas = marcaNegocio.listar();
            categorias = categoriaNegocio.listar();

            ddlMarca.DataSource = marcas;
            ddlMarca.DataTextField = "Descripcion";
            ddlMarca.DataValueField = "IdMarca";
            ddlMarca.DataBind();
            ddlMarca.Items.Insert(0, new ListItem("--Marca--", "0"));


            ddlCategoria.DataSource = categorias;
            ddlCategoria.DataTextField = "Descripcion";
            ddlCategoria.DataValueField = "IdCategoria";
            ddlCategoria.DataBind();
            ddlCategoria.Items.Insert(0, new ListItem("--Categoria--", "0"));

        }



        protected void btnAceptar_Click(object sender, EventArgs e)
        {
            Articulo articulo = new Articulo()
            {
                Nombre = txtNombre.Text,
                Codigo = txtCodigo.Text,
                Descripcion = txtDescripcion.Text,
                UrlImagen = txtUrlImagen.Text

            };
    }
    }
}