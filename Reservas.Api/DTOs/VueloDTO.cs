using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Threading.Tasks;

namespace Reservas.WebApi.DTOs
{
    public class VueloDTO
    {
        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public string Numero_Vuelo { get; set; }
        public DateTime Fecha_Vuelo { get; set; }
        public decimal Impuesto { get; set; }
    }
}
