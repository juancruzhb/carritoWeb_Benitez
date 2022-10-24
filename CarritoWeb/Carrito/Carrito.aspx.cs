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

            ArticuloNegocio negocio = new ArticuloNegocio();
            Carro nuevoCarro = new Carro();

            List<Carro> carritoCompra = new List<Carro>();

            if (!string.IsNullOrEmpty(Request.QueryString["IdArticulo"]))
            {
                int id = int.Parse(Request.QueryString["IdArticulo"]);

                nuevoCarro = carroPorId(id);
                //Get previous values
                if (Session["data"] != null)
                {
                    carritoCompra = (List<Carro>)Session["data"];
                }

                if(estaEnCarrito(nuevoCarro, carritoCompra))
                {
                    foreach (var item in carritoCompra.Where(x => x.oArticulo.IdArticulo == id))
                        item.Cantidad++;
                }
                else
                {
                    carritoCompra.Add(nuevoCarro);
                }
                Session["data"] = carritoCompra;

                carritos = carritoCompra;

                cargarGrilla();
            }
            if (Session["data"] != null)
            {
            
                carritoCompra = (List<Carro>)Session["data"];

            }

            Session["data"] = carritoCompra;
            carritos = carritoCompra;


            cargarGrilla();

        }

        private Articulo articuloPorId(int id)
        {
            Articulo aux = new Articulo();
            ArticuloNegocio negocio = new ArticuloNegocio();
            List<Articulo> articulos = new List<Articulo>();
            articulos = negocio.listar();

            aux = articulos.Find(x => x.IdArticulo == id);

            return aux;
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

        private bool estaEnCarrito(Carro carro, List<Carro> lista )
        {
            foreach (var item in lista)
            {
                if (lista.Any(x => x.oArticulo.IdArticulo == carro.oArticulo.IdArticulo))
                {
                    return true;
                }
                
            }
            return false;
        }



        protected void dgCarrito_SelectedIndexChanged(object sender, EventArgs e)
        {


            int idArticuloSeleccionado =Convert.ToInt32( dgCarrito.SelectedRow.Cells[0].Text);


            carritos.RemoveAll(x => x.oArticulo.IdArticulo == idArticuloSeleccionado);

            cargarGrilla();
           
 
        }

        private void cargarGrilla()
        {
            dgCarrito.DataSource = carritos;
            dgCarrito.DataBind();
            double precio = 0;
            foreach (var item in carritos)
            {
                precio += item.Cantidad * item.oArticulo.Precio;
            }
            lblPrecio.Text = precio.ToString();
        }

    }


}
