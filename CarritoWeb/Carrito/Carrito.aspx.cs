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
    public partial class Carrito : System.Web.UI.Page
    {

        List<Carro> carritos = new List<Carro>();

        protected void Page_Load(object sender, EventArgs e)
        {


            Articulo articulo = new Articulo();
            ArticuloNegocio negocio = new ArticuloNegocio();
            Carro nuevoCarro = new Carro();
            if (!string.IsNullOrEmpty(Request.QueryString["IdArticulo"]))
            {
                nuevoCarro = carroPorId(int.Parse(Request.QueryString["IdArticulo"]));

                List<Carro> carritoCompra = new List<Carro>();
                //Get previous values
                if (Session["data"] != null)
                    carritoCompra = (List<Carro>)Session["data"];
                //Add new one
                carritoCompra.Add(nuevoCarro);
                //Save updated list
                Session["data"] = carritoCompra;

                dgCarrito.DataSource = carritoCompra;
                dgCarrito.DataBind();
            }
            

        }


        private Carro carroPorId(int id)
        {
            Articulo aux = new Articulo();
            ArticuloNegocio negocio = new ArticuloNegocio();
            List<Articulo> articulos = new List<Articulo>();
            articulos = negocio.listar();

            aux = articulos.Find(x => x.IdArticulo == id);

            Carro carro = new Carro()
            {
                oArticulo = aux,
                Cantidad = 1
            };

            return carro;
        }
    }
}
