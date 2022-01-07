using System;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace Reservas.Entities
{
    public class Aerolinea : EntityAerolinea
    {
        public string Identificacion { get; set; }
        public string Nombre { get; set; }
    }
}
