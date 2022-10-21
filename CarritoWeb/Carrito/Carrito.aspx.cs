using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace Carrito
{
    public partial class Carrito : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            if (!string.IsNullOrEmpty(Request.QueryString["IdArticulo"]))
            {
                int id = int.Parse(Request.QueryString["IdArticulo"]);

            }
            if (!IsPostBack)
            {

            }

        }

    }
}