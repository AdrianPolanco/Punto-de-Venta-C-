using CapaEntidad;
using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CapaDatos
{
    public class CD_PERMISOS
    {
        public List<Permisos> Listar(int IdUsuario)
        {
            List<Permisos> Listar = new List<Permisos>();
            using (SqlConnection oconexion = new SqlConnection(Conexion.cadena))
            {
                try
                {
                    string query = @"SELECT p.IdRol,p.NombreMenu FROM PERMISOS p  INNER JOIN ROL r 
                    ON r.IdRol = p.IdRol INNER JOIN USUARIO u ON u.IdRol = r.IdRol WHERE u.IdUsuario=@IdUsuario";

                    SqlCommand command = new SqlCommand(query, oconexion);
                    command.Parameters.AddWithValue("@IdUsuario", IdUsuario);
                    command.CommandType = CommandType.Text;
                    oconexion.Open();
                    using (SqlDataReader reader = command.ExecuteReader())
                    {
                        while (reader.Read())
                        {
                            Listar.Add(new Permisos()
                            {
                                oRol = new Rol() { IdRol= Convert.ToInt32(reader["IdRol"])},
                                NombreMenu = reader["NombreMenu"].ToString()
                            });
                        }
                    }
                }
                catch (Exception ex)
                {

                }
            }


            return Listar;
        }
    }
}
