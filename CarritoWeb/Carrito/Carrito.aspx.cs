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
            carritos = (List<Carro>)Session["listaDeArticulosAgregados"];
            if (carritos != null)
                cargarGrilla();
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
