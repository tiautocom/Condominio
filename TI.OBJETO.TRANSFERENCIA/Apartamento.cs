using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TI.OBJETO.TRANSFERENCIA
{
    public class Apartamento
    {
        public int Id { get; set; }
        public int IdPessoa { get; set; }
        public string NumBloco { get; set; }
        public string NumAndar { get; set; }
        public string NumApto { get; set; }
        public bool Ativo { get; set; }
    }
}
