using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Reservas.Entities
{

    public class Vuelo : EntityVuelo
    {
        public string Numero_Vuelo { get; set; }
        public DateTime Fecha_Vuelo { get; set; }
        public decimal Impuesto { get; set; }
    }
}
