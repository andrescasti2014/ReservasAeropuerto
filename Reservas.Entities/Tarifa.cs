using System;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace Reservas.Entities
{
    public class Tarifa : EntityTarifa
    {
        public string Clase { get; set; }
        public decimal Precio { get; set; }
        public decimal Impuesto { get; set; }
    }
}
