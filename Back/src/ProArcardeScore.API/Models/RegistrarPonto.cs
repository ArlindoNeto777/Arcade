using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace ProArcardeScore.API.Models
{
    public class RegistrarPonto
    {
        public int Id { get; set; }
        public string DataPartida { get; set; }
        public int Pontuacao { get; set; }
        public string NomeJogador { get; set; }
    }
}