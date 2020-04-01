using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TI.OBJETO.TRANSFERENCIA
{
    public class MoradorVisitante
    {
        public int Id { get; set; }
        public string Nome { get; set; }
        public int IdMorador { get; set; }
        public int IdTipoVisitante { get; set; }
        public string Observacao { get; set; }
        public DateTime DataAutorizacao { get; set; }
    }
}
