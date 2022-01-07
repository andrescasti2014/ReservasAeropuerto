using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Threading.Tasks;

namespace Reservas.WebApi.DTOs
{
    public class TarifaDTO
    {
        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public string Clase { get; set; }
        public decimal Precio { get; set; }
        public decimal Impuesto { get; set; }
    }
}
