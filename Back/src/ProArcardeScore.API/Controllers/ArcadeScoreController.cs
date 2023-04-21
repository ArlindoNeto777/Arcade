using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;
using ProArcardeScore.API.Models;

namespace ProArcardeScore.API.Controllers
{
    [ApiController]
    [Route("[controller]")]
    public class ArcadeScoreController : ControllerBase
    {
        public IEnumerable<RegistrarPonto> _registrarPontos = new RegistrarPonto[]
            {
               new RegistrarPonto()
               {
                    Id = 1,
                    DataPartida = null,
                    Pontuacao = 35,
                    NomeJogador = "Cebolinha"
               },
               new RegistrarPonto()
               {
                    Id = 2,
                    DataPartida = null,
                    Pontuacao = 20,
                    NomeJogador = "Arrascaeta"
               }

            };
        public ArcadeScoreController(){}

        [HttpGet]
        public IEnumerable<RegistrarPonto> Get()
        {
            return _registrarPontos;            
        }

        [HttpPost]
        public string Post()
        {
            return "Exemplo de post";
        }

        [HttpPut("{id}")]
        public string Put(int id)
        {
            return $"Exemplo de Put com o id {id}";
        }

        [HttpDelete("{id}")]
        public string Delete(int id)
        {
            return $"Exemplo de id com o id {id}";
        }
    }
}
