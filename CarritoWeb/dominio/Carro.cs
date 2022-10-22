using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace dominio
{
    public class Carro
    {
        public int IdCarrito { get; set; }
        public Articulo oArticulo { get; set; }
        public int Cantidad { get; set; }
        //public Usuario oUsuario { get; set; }
    }
}
