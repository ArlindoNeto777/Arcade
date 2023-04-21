using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;
using ProArcardeScore.API.Data;
using ProArcardeScore.API.Models;

namespace ProArcardeScore.API.Controllers
{
    [ApiController]
    [Route("[controller]")]
    public class ArcadeScoreController : ControllerBase
    {
        private readonly DataContext _context;
        
        public ArcadeScoreController(DataContext context)
        {
            _context = context;
        }

        [HttpGet]
        public IEnumerable<RegistrarPonto> Get()
        {
            return _context.RegistrarPontos;          
        }

        [HttpGet("{id}")]
        public RegistrarPonto GetById(int id)
        {
            return _context.RegistrarPontos.FirstOrDefault(rp => rp.Id == id);
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
