﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;
using ProEventos.API.Data;
using ProEventos.API.Models;

namespace ProEventos.API.Controllers
{
    [ApiController]
    [Route("api/[controller]")]
    public class EventosController : ControllerBase
    {
        public IEnumerable<Evento> _eventos;
        private readonly DataContext context;
        public EventosController(DataContext contexto)
        {
            this.context = contexto;
            // this._eventos = new Evento[] { 
            //     new Evento() {                     
            //     EventoId = 1,
            //     Tema = "Angular 11 e .Net 5",
            //     Local = "São Paulo",
            //     Lote = "1º Lote",
            //     QtdPessoas = 258,
            //     DataEvento = DateTime.Now.AddDays(2).ToString("dd/MM/yyyy"),
            //     ImagemURL = "foto.png"
            //     },
            //     new Evento() {           
            //     EventoId = 2,
            //     Tema = "Angular e suas novidades",
            //     Local = "Belo Horizonte",
            //     Lote = "2º Lote",
            //     QtdPessoas = 150,
            //     DataEvento = DateTime.Now.AddDays(7).ToString("dd/MM/yyyy"),
            //     ImagemURL = "foto1.png"
            //     }
            // };
        }

        [HttpGet]
        public IEnumerable<Evento> Get()
        {
           return context.Eventos;
        }

        [HttpGet("{id}")]
        public Evento GetById(int id)
        {
           return context.Eventos.FirstOrDefault(evento => evento.EventoId == id);
        }

        [HttpPost]
        public string Post()
        {
           return "Exemplo de Post";
        }

        [HttpPut("{id}")]
        public string Put(int id)
        {
           return $"Exemplo de Put, id: {id}";
        }

        [HttpDelete("{id}")]
        public string Delete(int id)
        {
           return $"Exemplo de Delete, id: {id}";
        }
    }
}
