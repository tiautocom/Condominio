using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TI.ACESSO.DADOS;
using TI.OBJETO.TRANSFERENCIA;

namespace TI.REGRA.NEGOCIOS
{
    public class PessoaRegraNegocios
    {
        Conexao conexaoSqlServer = new Conexao();

        public int SalvarCondominio(Pessoa pessoa)
        {
            try
            {
                conexaoSqlServer.LimparParametros();
                conexaoSqlServer.AdicionarParametros("@ID", 0);
                conexaoSqlServer.AdicionarParametros("@NOME_RAZAO", pessoa.NomeRazao);
                conexaoSqlServer.AdicionarParametros("@CPF_CNPJ", pessoa.CpfCnpj);
                conexaoSqlServer.AdicionarParametros("@IE", pessoa.IeRg);

                conexaoSqlServer.AdicionarParametros("@NOME_FANTASIA", pessoa.Condominio.NomeFantasia);

                conexaoSqlServer.AdicionarParametros("@LOGRADOURO", pessoa.Endereco.Logradouro);
                conexaoSqlServer.AdicionarParametros("@NUMERO", pessoa.Endereco.Numero);
                conexaoSqlServer.AdicionarParametros("@CIDADE", pessoa.Endereco.Cidade);
                conexaoSqlServer.AdicionarParametros("@BAIRRO", pessoa.Endereco.Bairro);
                conexaoSqlServer.AdicionarParametros("@COMPLEMENTO", pessoa.Endereco.Complemento);
                conexaoSqlServer.AdicionarParametros("@CEP", pessoa.Endereco.Cep);
                conexaoSqlServer.AdicionarParametros("@UF", pessoa.Endereco.Uf);

                int ret = 0;
                ret = Convert.ToInt32(conexaoSqlServer.ExecutarManipulacao(CommandType.StoredProcedure, "uspPessoaCondominioSalvar").ToString());
                return ret;
            }
            catch (Exception ex)
            {
                throw new Exception(ex.Message);
            }
        }

        public DataTable PesquisarEmpresa(string login, string senha, string senhaSeg)
        {
            try
            {
                conexaoSqlServer.LimparParametros();
                conexaoSqlServer.AdicionarParametros("@LOGIN", login);
                conexaoSqlServer.AdicionarParametros("@SENHA", senha);
                conexaoSqlServer.AdicionarParametros("@TOKEN", senhaSeg);
             
                DataTable dadosTabela = new DataTable();
                dadosTabela = conexaoSqlServer.ExecutarConsulta(CommandType.StoredProcedure, "uspLoginAdmin");
                return dadosTabela;
            }
            catch (Exception ex)
            {
                throw new Exception(ex.Message);
            }
        }

        public DataTable PesquisarEmpresaId(int idEmpresa, string bloco, string andar, string apto)
        {
            try
            {
                conexaoSqlServer.LimparParametros();
                conexaoSqlServer.AdicionarParametros("@ID_EMPRESA", idEmpresa);
                conexaoSqlServer.AdicionarParametros("@NUM_BLOCO", bloco);
                conexaoSqlServer.AdicionarParametros("@NUM_ANDAR", andar);
                conexaoSqlServer.AdicionarParametros("@NUM_APTO", apto);
                DataTable dadosTabela = new DataTable();
                dadosTabela = conexaoSqlServer.ExecutarConsulta(CommandType.StoredProcedure, "uspPesquisarEmpresaId");
                return dadosTabela;
            }
            catch (Exception ex)
            {
                throw new Exception(ex.Message);
            }
        }

        public int SalvarApartamento(Apartamento apartamento)
        {
            try
            {
                conexaoSqlServer.LimparParametros();
                conexaoSqlServer.AdicionarParametros("@ID_EMPRESA", apartamento.IdPessoa);
                conexaoSqlServer.AdicionarParametros("@NUM_APTO", apartamento.NumApto);
                conexaoSqlServer.AdicionarParametros("@NUM_BLOCO", apartamento.NumBloco);
                conexaoSqlServer.AdicionarParametros("@NUM_ANDAR", apartamento.NumAndar);

                int ret = 0;
                ret = Convert.ToInt32(conexaoSqlServer.ExecutarManipulacao(CommandType.StoredProcedure, "uspPessoApartamentoSalvar").ToString());
                return ret;
            }
            catch (Exception ex)
            {
                throw new Exception(ex.Message);
            }
        }

        public int SalvarEmpresa(Pessoa pessoa)
        {
            try
            {
                conexaoSqlServer.LimparParametros();
               
                conexaoSqlServer.AdicionarParametros("@NOME_RAZAO", pessoa.NomeRazao);
                conexaoSqlServer.AdicionarParametros("@CPF_CNPJ", pessoa.CpfCnpj);
                conexaoSqlServer.AdicionarParametros("@IE", pessoa.IeRg);
                conexaoSqlServer.AdicionarParametros("@DATA_CAD", pessoa.DataCadastro);
             

                conexaoSqlServer.AdicionarParametros("@LOGRADOURO", pessoa.Endereco.Logradouro);
                conexaoSqlServer.AdicionarParametros("@NUMERO", pessoa.Endereco.Numero);
                conexaoSqlServer.AdicionarParametros("@CIDADE", pessoa.Endereco.Cidade);
                conexaoSqlServer.AdicionarParametros("@BAIRRO", pessoa.Endereco.Bairro);
                conexaoSqlServer.AdicionarParametros("@COMPLEMENTO", pessoa.Endereco.Complemento);
                conexaoSqlServer.AdicionarParametros("@CEP", pessoa.Endereco.Cep);
                conexaoSqlServer.AdicionarParametros("@UF", pessoa.Endereco.Uf);

                conexaoSqlServer.AdicionarParametros("@NOME_FANTASIA", pessoa.Empresa.NomeFantasia);
                conexaoSqlServer.AdicionarParametros("@CARACTERISTICA", pessoa.Empresa.Caracterisca);
                conexaoSqlServer.AdicionarParametros("@EMAIL", pessoa.Empresa.Email);
                conexaoSqlServer.AdicionarParametros("@COD_SEG", pessoa.Empresa.CodigoSeguracanca);

                int ret = 0;
                ret = Convert.ToInt32(conexaoSqlServer.ExecutarManipulacao(CommandType.StoredProcedure, "uspPessoEmpresaSalvar").ToString());
                return ret;
            }
            catch (Exception ex)
            {
                throw new Exception(ex.Message);
            }
        }
    }
}
