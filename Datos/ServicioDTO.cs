using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GestionTallerAutomotriz.Datos
{
    public class ServicioDTO
    {
        public int ServicioID { get; set; }
        public int VehiculoID { get; set; }
        public DateTime Fecha { get; set; }
        public string TipoServicio { get; set; }
        public double Costo { get; set; }
        public string Observaciones { get; set; }
    }
}
