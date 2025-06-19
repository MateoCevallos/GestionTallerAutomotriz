using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GestionTallerAutomotriz.Aplicacion
{
    public class ServicioService
    {
        private readonly AccesoDatos.ServicioDAO _servicioDAO = new AccesoDatos.ServicioDAO();

        public List<Datos.ServicioDTO> todos()
        {
            return _servicioDAO.todos();
        }

        public string insertar(Datos.ServicioDTO servicioDTO)
        {
            return _servicioDAO.insertar(servicioDTO);
        }

        public string eliminar(int servicioID)
        {
            return _servicioDAO.eliminar(servicioID);
        }

        public string actualizar(Datos.ServicioDTO servicio)
        {
            return _servicioDAO.actualizar(servicio);
        }
    }
}
