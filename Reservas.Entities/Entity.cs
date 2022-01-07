using Reservas.Abstraction;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Reservas.Entities
{
    public abstract class EntityAerolinea : IAerolinea
    {
        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public int IdAerolinea { get; set; }
    }

    public abstract class EntityAeropuerto : IAeropuerto
    {
        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public int IdAeropuerto { get; set; }
    }
    public abstract class EntityReserva : IReserva
    {
        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public int IdReserva { get; set; }
    }
    public abstract class EntityTarifa : ITarifa
    {
        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public int IdTarifa { get; set; }
    }
    public abstract class EntityVuelo : IVuelo
    {
        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public int IdVuelo { get; set; }
    }
}
