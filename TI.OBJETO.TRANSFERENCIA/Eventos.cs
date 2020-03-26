using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TI.OBJETO.TRANSFERENCIA
{
    public class Eventos
    {
        public int Id { get; set; }
        public int IdMorador { get; set; }
        public int IdLocal { get; set; }
        public int IdUsuario { get; set; }
        public DateTime Date { get; set; }
        public string HoraInicio { get; set; }
        public string HoraFim { get; set; }
        public string Observacao { get; set; }
        public DateTime DataCadastro { get; set; }
        public int Capacidade { get; set; }
    }
}
