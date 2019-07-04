using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TI.OBJETO.TRANSFERENCIA
{
    public class Pessoa
    {
        public int Id { get; set; }
        public string NomeRazao { get; set; }
        
        public string CpfCnpj { get; set; }
        public string IeRg { get; set; }
        public DateTime DataCadastro { get; set; }

        public Condominio Condominio { get; set; }
        public Empresa Empresa { get; set; }
        public Endereco Endereco { get; set; }
        public Telefone Telefone { get; set; }
        public Condomino Condomino { get; set; }
        public Apartamento Apartamento { get; set; }
    }
}
