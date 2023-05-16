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
    public class CD_ROL
    {
        public List<Rol> Listar()
        {
            List<Rol> Listar = new List<Rol>();
            using (SqlConnection oconexion = new SqlConnection(Conexion.cadena))
            {
                try
                {
                    string query = "SELECT IdRol, Descripcion FROM ROL";

                    SqlCommand command = new SqlCommand(query, oconexion);
                    command.CommandType = CommandType.Text;
                    oconexion.Open();
                    using (SqlDataReader reader = command.ExecuteReader())
                    {
                        while (reader.Read())
                        {
                            Listar.Add(new Rol()
                            {
                                IdRol = Convert.ToInt32(reader["IdRol"]),
                                Descripcion = reader["Descripcion"].ToString()

                            }); ;
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
