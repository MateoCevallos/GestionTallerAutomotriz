using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using MySql.Data.MySqlClient;

namespace GestionTallerAutomotriz.AccesoDatos
{
    class ClienteDAO
    {
        private Conexion _conexion = new Conexion();

        public List<Datos.ClientesDTO> todos() {
            List<Datos.ClientesDTO> listaClientesDTO = new List<Datos.ClientesDTO>();
            using (MySqlConnection cn = _conexion.AbrirConexion())
            {
                string cadena = "SELECT * FROM `clientes`";
                using (MySqlCommand cmd = new MySqlCommand(cadena, cn))
                {
                    using (MySqlDataReader lector = cmd.ExecuteReader())
                    {
                        while (lector.Read())
                        {
                            Datos.ClientesDTO user = new Datos.ClientesDTO
                            {
                                ClienteID = lector.GetInt32(0),
                                Nombre = lector.GetString(1),
                                Cedula = lector.GetString(2),
                                Telefono = lector.GetString(3),
                                Email = lector.GetString(4),                                                   
                            };
                            listaClientesDTO.Add(user);
                        }
                    }
                }
            }
            return listaClientesDTO;
        }

        public string insertar(Datos.ClientesDTO clienteDTO) {
            using (MySqlConnection cn = _conexion.AbrirConexion())
            {
                string cadena =
                       "INSERT INTO `clientes`(`Nombre`, `Cedula`, `Telefono`, `Email`) VALUES " +
                       "(@Nombre, @Cedula, @Telefono, @Email)";
                MySqlCommand sqlCommand = new MySqlCommand(cadena, cn);
                sqlCommand.Parameters.AddWithValue("@Nombre", clienteDTO.Nombre);
                sqlCommand.Parameters.AddWithValue("@Cedula", clienteDTO.Cedula);
                sqlCommand.Parameters.AddWithValue("@Telefono", clienteDTO.Telefono);
                sqlCommand.Parameters.AddWithValue("@Email", clienteDTO.Email);
                int filasAfectadas = sqlCommand.ExecuteNonQuery();

                if (filasAfectadas > 0)
                {
                    return "ok";
                }
                else
                {
                   
                    return "error";
                }

            }

        }
        public string actualizar(Datos.ClientesDTO cliente)
        {
            using (MySqlConnection cn = _conexion.AbrirConexion())
            {
                string cadena = "UPDATE clientes SET Nombre = @Nombre, Cedula = @Cedula, Telefono = @Telefono, Email = @Email WHERE ClienteID = @ClienteID";
                MySqlCommand cmd = new MySqlCommand(cadena, cn);
                cmd.Parameters.AddWithValue("@Nombre", cliente.Nombre);
                cmd.Parameters.AddWithValue("@Cedula", cliente.Cedula);
                cmd.Parameters.AddWithValue("@Telefono", cliente.Telefono);
                cmd.Parameters.AddWithValue("@Email", cliente.Email);
                cmd.Parameters.AddWithValue("@ClienteID", cliente.ClienteID);

                int filasAfectadas = cmd.ExecuteNonQuery();
                return filasAfectadas > 0 ? "ok" : "error";
            }
        }

        public string eliminar(int ClienteID)
        {
            try
            {
                using (MySqlConnection cn = _conexion.AbrirConexion())
                {
                    string cadena = "DELETE FROM `clientes` WHERE `ClienteID` = @ClienteID";
                    MySqlCommand sqlCommand = new MySqlCommand(cadena, cn);
                    sqlCommand.Parameters.AddWithValue("@ClienteID", ClienteID);
                    int filasAfectadas = sqlCommand.ExecuteNonQuery();

                    if (filasAfectadas > 0)
                    {
                        return "ok";
                    }
                    else
                    {
                        return "error";
                    }
                }
            }
            catch (MySqlException ex)
            {
                if (ex.Message.Contains("foreign key constraint fails"))
                {
                    return "tiene_vehiculos";
                }
                return "error";
            }
        }
    }
}
