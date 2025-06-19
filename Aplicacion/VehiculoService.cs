using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GestionTallerAutomotriz.Aplicacion
{
    public class VehiculoService
    {
        private readonly AccesoDatos.VehiculoDAO _vehiculoDAO = new AccesoDatos.VehiculoDAO();

        public List<Datos.VehiculosDTO> todos()
        {
            return _vehiculoDAO.todos();
        }

        public string insertar(Datos.VehiculosDTO vehiculoDTO)
        {
            return _vehiculoDAO.insertar(vehiculoDTO);
        }

        public string eliminar(int VehiculoID)
        {
            return _vehiculoDAO.eliminar(VehiculoID);
        }

        public string actualizar(Datos.VehiculosDTO vehiculo)
        {
            return _vehiculoDAO.actualizar(vehiculo);
        }
    }
}
