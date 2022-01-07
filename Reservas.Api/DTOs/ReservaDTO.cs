using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Threading.Tasks;

namespace Reservas.WebApi.DTOs
{
    public class ReservaDTO
    {
        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public decimal Costo { get; set; }
        public DateTime fecha { get; set; }
        public string Hora { get; set; }
        public string Observaciones { get; set; }
        public string Aeropuerto_Origen { get; set; }
        public string Aeropuerto_Destino { get; set; }
        public int Id_Vuelo { get; set; }
        public string Tipo_Pasajero { get; set; }
    }
}
