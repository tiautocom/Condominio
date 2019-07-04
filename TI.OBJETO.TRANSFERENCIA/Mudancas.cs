using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TI.OBJETO.TRANSFERENCIA
{
   public class Mudancas
    {
        public int Id { get; set; }
        public DateTime Data { get; set; }
        public int IdTorre { get; set; }
        public int IdBloco { get; set; }
        public string Bloco { get; set; }
        public int IdPeriodo { get; set; }
        public int IdStatus { get; set; }
        public int IdUsuario { get; set; }
        public int IdSindico { get; set; }
        public int Apto { get; set; }
        public int Lado { get; set; }
    }
}
