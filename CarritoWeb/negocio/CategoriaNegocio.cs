using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;
using dominio;

namespace negocio
{
    public class CategoriaNegocio
    {
        public List<Categoria> listar()
        {
            List<Categoria> categorias = new List<Categoria>();

            using(SqlConnection conexion = new SqlConnection(Conexion.CN))
            {
                SqlCommand cmd = new SqlCommand("sp_obtenerCategorias", conexion);
                cmd.CommandType = System.Data.CommandType.StoredProcedure;
                try
                {
                    conexion.Open();
                    SqlDataReader reader = cmd.ExecuteReader();

                    while (reader.Read())
                    {
                        categorias.Add(new Categoria()
                        {
                            IdCategoria = (int)reader["ID"],
                            Descripcion = (string)reader["Descripcion"]
                        });

                    }

                }
                catch (Exception)
                {

                    throw;
                }
                finally { conexion.Close(); }
            }
            return categorias;

              
        }
    }
}
