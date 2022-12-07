using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Mime;
using Back.src.Proeventos.API;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;
using Proeventos.API.Models;
using Proeventos.Back.src.Proeventos.API.Data;

namespace Proeventos.API.Controllers
{
    [ApiController]
    [Route("api/[controller]")]
    public class EventosController : ControllerBase
    {
        private readonly DataContext _context;
        
        public EventosController(DataContext context)
        {
            _context = context;
        }

        [HttpGet]
        public IEnumerable<Evento> Get()
        {
            return _context.Eventos;
        }

        [HttpGet("{id}")]
        public Evento GetById(int id)
        {
            return _context.Eventos.FirstOrDefault(e => e.EventoId == id);
        }

        [HttpPost]
        public string PostTeste([FromForm] Evento evento)
        {
            _context.Eventos.Add(evento);
            _context.SaveChanges();

            return $"Evento criado com sucesso: \n\rEvento Id: {evento.EventoId} " +
                   $"\n\rTema: {evento.Tema}\n\rLocal: {evento.Local}" +
                   $"\n\rData do evento: {evento.DataEvento}";
        }
    }
}
