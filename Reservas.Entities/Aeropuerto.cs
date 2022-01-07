using System;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace Reservas.Entities
{
    public class Aeropuerto : EntityAeropuerto
    {
        public string Nombre { get; set; }
        public string Pais { get; set; }
    }
}
