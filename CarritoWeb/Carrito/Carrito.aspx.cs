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

            int idArticuloSeleccionado = Convert.ToInt32(dgCarrito.SelectedRow.Cells[0].Text);

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

        protected void btnSuprimir_Command(object sender, CommandEventArgs e)
        {
            int idArticulo = Convert.ToInt32(e.CommandArgument.ToString());
            List<Carro> aux = new List<Carro>();
            aux = carritos;
            siRemueveTermina(idArticulo, aux);
        }

        protected void btnSumar_Command(object sender, CommandEventArgs e)
        {
            int idArticulo = Convert.ToInt32(e.CommandArgument.ToString());
            foreach (var item in carritos.Where(x => x.oArticulo.IdArticulo == idArticulo))
                item.Cantidad++;
            cargarGrilla();
        }
        
        private bool siRemueveTermina(int id, List<Carro> lista)
        {
            foreach (var item in lista.Where(x => x.oArticulo.IdArticulo == id))
            {
                if (item.Cantidad == 1)
                {
                    carritos.RemoveAll(x => x.oArticulo.IdArticulo == id);
                    cargarGrilla();
                    return false;

                }
                else
                {
                    item.Cantidad--;
                    cargarGrilla();
                }
            }
            return true;
        }
    }

   
}
