using Microsoft.AspNetCore.Mvc;
using Reservas.Application;
using Reservas.Entities;
using Reservas.WebApi.DTOs;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.Json;
using System.Threading.Tasks;

namespace Reservas.WebApi.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class ReservasController : ControllerBase
    {
        IApplicationReserva<Reserva> _Reserva;
        IApplicationReserva<Reserva> _genericApplication;
        public ReservasController(IApplicationReserva<Reserva> reserva, IApplicationReserva<Reserva> genericApplication)
        {
            _Reserva = reserva;
            _genericApplication = genericApplication;
        }
        [Route("Obtiene todas las reservas")]
        [HttpGet]
        public IActionResult Get()
        {
            return Ok(_Reserva.GetAll());
        }
        [Route("Crea una reserva")]
        [HttpPost]
        public IActionResult Save(ReservaDTO dto)
        {
            var DtoReserva = new Reserva()
            {
                Costo = dto.Costo,
                Aeropuerto_Destino = dto.Aeropuerto_Destino,
                Aeropuerto_Origen = dto.Aeropuerto_Origen,
                fecha = dto.fecha,
                Hora = dto.Hora,
                Id_Vuelo = dto.Id_Vuelo,
                Tipo_Pasajero = dto.Tipo_Pasajero,
                Observaciones = dto.Observaciones
            };
            return Ok(_Reserva.Save(DtoReserva));
        }
        [HttpGet]
        [Route("{IdReserva}")]
        public IActionResult GetOne(int IdReserva)
        {
            if (IdReserva == 0) return NotFound();

            var DtoReserva = _Reserva.GetById(IdReserva);
            return Ok(DtoReserva);
        }

        [HttpGet]
        [Route("Obtiene reservas por Aeropuerto Origen")]
        public IActionResult GetOnebookingOrigin(string Name)
        {
            if (Name == "") return NotFound();

            var DtoReserva = _Reserva.GetAll();
            var DtoResult = DtoReserva.Where(x => x.Aeropuerto_Origen == Name);
            return Ok(DtoResult);
        }
        [HttpGet]
        [Route("Obtiene reservas por Aeropuerto Destino")]
        public IActionResult GetOnebookingDestination(string Name)
        {
            if (Name == "") return NotFound();

            var DtoReserva = _Reserva.GetAll();
            var DtoResult = DtoReserva.Where(x => x.Aeropuerto_Destino == Name);
            return Ok(DtoResult);
        }
        [HttpGet]
        [Route("Obtiene reservas por Fecha")]
        public IActionResult GetOnebookingDate(DateTime Fecha)
        {
            if (Fecha == null) return NotFound();

            var DtoReserva = _Reserva.GetAll();
            var DtoResult = DtoReserva.Where(x => x.fecha == Fecha);
            return Ok(DtoResult);
        }
        //[HttpPut]
        //[Route("{IdReserva}")]
        //public IActionResult Update(int IdReserva, ReservaDTO dto)
        //{
        //    if (IdReserva == 0 || dto == null) return NotFound();

        //    var tmp = _Reserva.GetById(IdReserva);
        //    if (tmp != null)
        //    {
        //        tmp.Costo = dto.Costo;
        //        tmp.Aeropuerto_Destino = dto.Aeropuerto_Destino;
        //        tmp.Aeropuerto_Origen = dto.Aeropuerto_Origen;
        //        tmp.fecha = dto.fecha;
        //        tmp.Hora = dto.Hora;
        //        tmp.Id_Vuelo = dto.Id_Vuelo;
        //        tmp.Tipo_Pasajero = dto.Tipo_Pasajero;
        //        tmp.Observaciones = dto.Observaciones;
        //    }
        //    _Reserva.Save(tmp);
        //    return Ok(tmp);

        //}

        //[HttpDelete]
        //[Route("{IdReserva}")]
        //public IActionResult Delete(int IdReserva)
        //{
        //    if (IdReserva == 0) return NotFound();

        //    _Reserva.DeleteAsync(IdReserva);
        //    return Ok();
        //}
    }
}
