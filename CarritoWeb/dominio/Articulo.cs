using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace dominio
{
    public class Articulo
    {
        public int IdProducto { get; set; }
        public string Codigo { get; set; }
        public string Nombre { get; set; }
        public string Descripcion { get; set; }
        public double Precio { get; set; }
        public string UrlImagen { get; set; }
        public bool Activo { get; set; }
        
        public Categoria oCategoria { get; set; }
        public Marca oMarca { get; set; }
    }
}
