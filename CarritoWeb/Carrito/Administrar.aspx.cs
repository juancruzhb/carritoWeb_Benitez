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
        protected void Page_Load(object sender, EventArgs e)
        {
            ArticuloNegocio negocio = new ArticuloNegocio();
            articulos = negocio.listar();

            gvArticulos.DataSource = articulos;
            gvArticulos.DataBind();

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