using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TI.OBJETO.TRANSFERENCIA
{
    public class Morador
    {
        public int Id { get; set; }
        public string Torre { get; set; }
        public string Bloco { get; set; }
        public string Apto { get; set; }
        public string TipoMorador { get; set; }
        public string DataNascimento { get; set; }
        public string Observacao { get; set; }
        public string Titulo { get; set; }
        public string Email { get; set; }
        public string Cpf { get; set; }
        public string Rg { get; set; }
        public string Telefone { get; set; }
        public string Celular { get; set; }
        public string Comercial { get; set; }
        public bool Status { get; set; }
        public int IdEmpresa { get; set; }

        public MoradorVisitante MoradorVisitante { get; set; }
    }
}
