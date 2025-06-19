using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using MySql.Data.MySqlClient;

namespace GestionTallerAutomotriz.AccesoDatos
{
    class ServicioDAO
    {
        private Conexion _conexion = new Conexion();

        // Obtener todos los servicios
        public List<Datos.ServicioDTO> todos()
        {
            List<Datos.ServicioDTO> listaServicios = new List<Datos.ServicioDTO>();

            using (MySqlConnection cn = _conexion.AbrirConexion())
            {
                string cadena = "SELECT * FROM servicios";
                using (MySqlCommand cmd = new MySqlCommand(cadena, cn))
                {
                    using (MySqlDataReader lector = cmd.ExecuteReader())
                    {
                        while (lector.Read())
                        {
                            Datos.ServicioDTO servicio = new Datos.ServicioDTO
                            {
                                ServicioID = lector.GetInt32(0),
                                VehiculoID = lector.GetInt32(1),
                                Fecha = lector.GetDateTime(2),
                                TipoServicio = lector.GetString(3),
                                Costo = lector.GetDouble(4),
                                Observaciones = lector.GetString(5)
                            };
                            listaServicios.Add(servicio);
                        }
                    }
                }
            }

            return listaServicios;
        }

        // Insertar nuevo servicio
        public string insertar(Datos.ServicioDTO servicio)
        {
            using (MySqlConnection cn = _conexion.AbrirConexion())
            {
                string cadena = "INSERT INTO servicios (VehiculoID, Fecha, TipoServicio, Costo, Observaciones) " +
                                "VALUES (@VehiculoID, @Fecha, @TipoServicio, @Costo, @Observaciones)";

                using (MySqlCommand cmd = new MySqlCommand(cadena, cn))
                {
                    cmd.Parameters.AddWithValue("@VehiculoID", servicio.VehiculoID);
                    cmd.Parameters.AddWithValue("@Fecha", servicio.Fecha);
                    cmd.Parameters.AddWithValue("@TipoServicio", servicio.TipoServicio);
                    cmd.Parameters.AddWithValue("@Costo", servicio.Costo);
                    cmd.Parameters.AddWithValue("@Observaciones", servicio.Observaciones);

                    int filas = cmd.ExecuteNonQuery();
                    return filas > 0 ? "ok" : "error";
                }
            }
        }

        // Actualizar un servicio existente
        public string actualizar(Datos.ServicioDTO servicio)
        {
            using (MySqlConnection cn = _conexion.AbrirConexion())
            {
                string cadena = "UPDATE servicios SET VehiculoID = @VehiculoID, Fecha = @Fecha, TipoServicio = @TipoServicio, " +
                                "Costo = @Costo, Observaciones = @Observaciones WHERE ServicioID = @ServicioID";

                using (MySqlCommand cmd = new MySqlCommand(cadena, cn))
                {
                    cmd.Parameters.AddWithValue("@VehiculoID", servicio.VehiculoID);
                    cmd.Parameters.AddWithValue("@Fecha", servicio.Fecha);
                    cmd.Parameters.AddWithValue("@TipoServicio", servicio.TipoServicio);
                    cmd.Parameters.AddWithValue("@Costo", servicio.Costo);
                    cmd.Parameters.AddWithValue("@Observaciones", servicio.Observaciones);
                    cmd.Parameters.AddWithValue("@ServicioID", servicio.ServicioID);

                    int filas = cmd.ExecuteNonQuery();
                    return filas > 0 ? "ok" : "error";
                }
            }
        }

        // Eliminar un servicio por ID
        public string eliminar(int servicioID)
        {
            using (MySqlConnection cn = _conexion.AbrirConexion())
            {
                string cadena = "DELETE FROM servicios WHERE ServicioID = @ServicioID";

                using (MySqlCommand cmd = new MySqlCommand(cadena, cn))
                {
                    cmd.Parameters.AddWithValue("@ServicioID", servicioID);
                    int filas = cmd.ExecuteNonQuery();
                    return filas > 0 ? "ok" : "error";
                }
            }
        }
    }
}
