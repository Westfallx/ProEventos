using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;
using ProEventos.API.Models;

namespace ProEventos.API.Controllers
{
    [ApiController]
    [Route("api/[controller]")]
    public class EventoController : ControllerBase
    {   
        public IEnumerable<Evento> _evento = new Evento[]
        {
            new Evento()
            {
                EventoId    = 1,
                Local       = "São Paulo",
                DataEvento  = DateTime.Now.AddDays(2),
                Tema        = "Evento 1",
                Quantidade  = 100,
                Lote        = "Lote 1",
                ImgaemURL   = "http://lorempixel.com/400/200/sports/1"
            },
            new Evento()
            {                    
                EventoId    = 2,
                Local       = "Foz do Iguaçu",
                DataEvento  = DateTime.Now.AddDays(3),
                Tema        = "Angular 11 e .Net 5",
                Quantidade  = 350,
                Lote        = "Lote 2",
                ImgaemURL   = "http://www.google.com.br"
            }
        };


        public EventoController()
        {
        }

        [HttpGet]
        public IEnumerable<Evento> Get()
        {
            return _evento;
        }

        [HttpGet("{id}")]	
        public IEnumerable<Evento> Get(int id)
        {
            return _evento.Where(x => x.EventoId == id);
        }
        

        [HttpPost]
        public string Post()
        {
            return "Hello World Post";
        }

        [HttpPut("{id}")]
        public string Put(int id)
        {
            return $"Hello World Put com id = {id}";
        }

        [HttpDelete("{id}")]
        public string Delete(int id)
        {
            return $"Exemplo de Delete com id = {id}";
        }
    }
    
}
