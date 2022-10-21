using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using dominio;
using negocio;

namespace Carrito
{
    public partial class ArticuloDetalle1 : System.Web.UI.Page
    {
        List<Articulo> articulos = new List<Articulo>();
        protected void Page_Load(object sender, EventArgs e)
        {
            int id = int.Parse(Request.QueryString["IdArticulo"]);
            pdRepeater.DataSource = articuloPorId(id);
            pdRepeater.DataBind();

        }

        private List<Articulo> articuloPorId(int id)
        {
            ArticuloNegocio negocio = new ArticuloNegocio();
            List<Articulo> articulosFiltrados = new List<Articulo>();
            Articulo filtrado;
            articulos = negocio.listar();

            filtrado = articulos.Find(x => x.IdArticulo == id);
            articulosFiltrados.Add(filtrado);
            return articulosFiltrados;
        }
    }
}