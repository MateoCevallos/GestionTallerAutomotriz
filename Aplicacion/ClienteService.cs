using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GestionTallerAutomotriz.Aplicacion
{
    public class ClienteService
    {
        private readonly AccesoDatos.ClienteDAO _clienteDAO = new AccesoDatos.ClienteDAO();
        public List<Datos.ClientesDTO> todos() {
            return _clienteDAO.todos();
        }
        public string insertar(Datos.ClientesDTO clienteDTO) {
            return _clienteDAO.insertar(clienteDTO);
        }
        public string eliminar(int ClienteID)
        {
            return _clienteDAO.eliminar(ClienteID);
        }
        public string actualizar(Datos.ClientesDTO cliente)
        {
            return _clienteDAO.actualizar(cliente);
        }
    }
}
