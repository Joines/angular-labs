using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Mime;
using Back.src.Proeventos.API;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;
using Proeventos.API.Models;

namespace Proeventos.API.Controllers
{
    [ApiController]
    [Route("api/[controller]")]
    public class EventosController : ControllerBase
    {
        public static IList<Evento> _eventos =  new List<Evento>
            {
                new Evento {
                EventoId = 1,
                Tema = "Angular and .NET 5",
                Local = "Belo Horizonte",
                Lote = "1º lote",
                QtdPessoas = 250,
                DataEvento = "04/12/2022" }
            };

        public EventosController()
        {

        }

        [HttpGet]
        public IEnumerable<Evento> Get()
        {
            return _eventos;
        }

        [HttpGet("{id}")]
        public Evento GetById(int id)
        {
            return _eventos.FirstOrDefault(e => e.EventoId == id);
        }

        [HttpPost]
        public string PostTeste([FromForm] Evento evento)
        {

            _eventos.Add(evento);

            return $"Evento criado com sucesso: \n\rEvento Id: {evento.EventoId} " +
                   $"\n\rTema: {evento.Tema}\n\rLocal: {evento.Local}" +
                   $"\n\rData do evento: {evento.DataEvento}";
        }
    }
}
