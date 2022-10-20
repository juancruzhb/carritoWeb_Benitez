using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using dominio;
using System.Data.SqlClient;

namespace negocio
{
    public class ArticuloNegocio
    { 
        public List<Articulo> listar()
        {
            List<Articulo> productos = new List<Articulo>();

            using (SqlConnection conexion = new SqlConnection(Conexion.CN))
            {
                SqlCommand cmd = new SqlCommand("sp_obtenerProducto", conexion);
                cmd.CommandType = System.Data.CommandType.StoredProcedure;

                try
                {
                    conexion.Open();
                    SqlDataReader reader = cmd.ExecuteReader();

                    while (reader.Read())
                    {
                        productos.Add(new Articulo()
                        {
                            IdArticulo = (int)reader["Id"],
                            Codigo = (string)reader["codigo"],
                            Nombre = (string)reader["nombre"],
                            Descripcion = (string)reader["descripcion"],
                            UrlImagen = (string)reader["imagenurl"],
                            Precio = Convert.ToDouble(reader["Precio"]),

                            oMarca = new Marca()
                            {
                                IdMarca = (int)reader["IdMarca"],
                                Descripcion = (string)reader["Mar"]
                            },

                            oCategoria = new Categoria()
                            {
                                IdCategoria = (int)reader["IdCategoria"],
                                Descripcion = (string)reader["Cat"]
                            }
                    });
                    }
                }
                catch (Exception)
                {

                    throw;
                }
                finally { conexion.Close(); }
            }





                return productos;
        }
    
    }
}
