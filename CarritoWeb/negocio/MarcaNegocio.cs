using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;
using dominio;

namespace negocio
{
    public class MarcaNegocio
    {
       public List<Marca> listar()
        {
            List<Marca> marcas = new List<Marca>();

            using(SqlConnection conexion = new SqlConnection(Conexion.CN))
            {
                SqlCommand cmd = new SqlCommand("sp_obtenerMarcas",conexion);
                cmd.CommandType = System.Data.CommandType.StoredProcedure;

                try
                {
                    conexion.Open();
                    SqlDataReader reader = cmd.ExecuteReader();

                    while (reader.Read())
                    {
                        marcas.Add(new Marca()
                        {
                            IdMarca = (int)reader["Id"],
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
            return marcas;
        }
    }
}
