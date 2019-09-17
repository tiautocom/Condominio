using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TI.OBJETO.TRANSFERENCIA
{
    public class Ata
    {
        public int Id { get; set; }
        public string Titulo { get; set; }
        public DateTime Data { get; set; }
        public int IdUsuario { get; set; }
        public string Sindico { get; set; }
        public string SubSindico { get; set; }
        public string TipoAssembleia { get; set; }
        public string Url { get; set; }
        public string Descricao { get; set; }
    }
}
