using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GestionTallerAutomotriz.Datos
{
    public class VehiculosDTO
    {
        public int VehiculoID { get; set; }
        public String Placa { get; set; }
        public string Marca { get; set; }
        public string Modelo { get; set; }
        public int Anio { get; set; }
        public int ClienteID { get; set; }

    }
}
