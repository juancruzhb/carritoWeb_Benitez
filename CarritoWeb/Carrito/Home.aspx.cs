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
    public partial class Home : System.Web.UI.Page
    {
        public List<Articulo> listaArticulos { get; set; }
        public List<Categoria> listaCategorias{ get; set; }
        public List<Marca> listaMarcas{ get; set; }
        protected void Page_Load(object sender, EventArgs e)
        {
            ArticuloNegocio negocio = new ArticuloNegocio();
            listaArticulos = negocio.listar();
            repRepeater.DataSource = negocio.listar();
            repRepeater.DataBind();

            CategoriaNegocio categoriaNegocio = new CategoriaNegocio();
            listaCategorias = categoriaNegocio.listar();
            ddlCategorias.DataSource = listaCategorias;
            ddlCategorias.DataTextField = "Descripcion";
            ddlCategorias.DataValueField = "IdCategoria";
            ddlCategorias.DataBind();
            ddlCategorias.Items.Insert(0, new ListItem("--Categoria--", "0"));

            MarcaNegocio marcaNegocio = new MarcaNegocio();
            listaMarcas = marcaNegocio.listar();
            ddlMarcas.DataSource = listaMarcas;
            ddlMarcas.DataTextField = "Descripcion";
            ddlMarcas.DataValueField = "IdMarca";
            ddlMarcas.DataBind();
            ddlMarcas.Items.Insert(0, new ListItem("--Marca--", "0"));


        }



        protected void txtBuscar_TextChanged(object sender, EventArgs e)
        {
            buscar();

        }



        private void buscar() {
            List<Articulo> articulosFiltrados = new List<Articulo>();
            string filtro = txtBuscar.Text;

            if (filtro.Length >= 3)
            {
                articulosFiltrados = listaArticulos.FindAll(x => x.Nombre.ToUpper().Contains(filtro.ToUpper()) || x.oMarca.Descripcion.ToUpper().Contains(filtro.ToUpper()) || x.oCategoria.Descripcion.ToUpper().Contains(filtro.ToUpper()));
            }
            else
            {
                articulosFiltrados = listaArticulos;
            }

            repRepeater.DataSource = null;
            repRepeater.DataSource = articulosFiltrados;
            repRepeater.DataBind();
        }
    }
}