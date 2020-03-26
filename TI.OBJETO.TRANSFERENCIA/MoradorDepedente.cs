using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TI.OBJETO.TRANSFERENCIA
{
    public class MoradorDepedente
    {
        public int Id { get; set; }
        public int IdMorador { get; set; }
        public string Nome { get; set; }
        public string Genero { get; set; }
        public string Tipo { get; set; }
        public int Idade { get; set; }
        public string DataNascimento { get; set; }
    }
}
