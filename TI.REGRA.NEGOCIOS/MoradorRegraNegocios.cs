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
    public class MoradorRegraNegocios
    {
        Conexao conexaoSqlServer = new Conexao();

        public DataTable ListarNumMorador(int numApto)
        {
            try
            {
                conexaoSqlServer.LimparParametros();
                DataTable dadosTabela = new DataTable();
                dadosTabela = conexaoSqlServer.ExecutarConsulta(CommandType.StoredProcedure, "uspListarEmpresa");
                return dadosTabela;
            }
            catch (Exception ex)
            {
                throw new Exception(ex.Message);
            }
        }

        public DataTable ListarMoradoresLista(int tipo, string pesquisar)
        {
            try
            {
                conexaoSqlServer.LimparParametros();
                conexaoSqlServer.AdicionarParametros("@Pesquisar", pesquisar);
                DataTable dadosTabela = new DataTable();

                if (tipo == 0)
                {
                    dadosTabela = conexaoSqlServer.ExecutarConsulta(CommandType.StoredProcedure, "uspListarMoradoresLista");
                }
                else if (tipo == 1)
                {
                    dadosTabela = conexaoSqlServer.ExecutarConsulta(CommandType.StoredProcedure, "uspListarMoradoresNome");
                }
                else if (tipo == 2)
                {
                    dadosTabela = conexaoSqlServer.ExecutarConsulta(CommandType.StoredProcedure, "uspListarMoradoresCpf");
                }

                return dadosTabela;
            }
            catch (Exception ex)
            {
                throw new Exception(ex.Message);
            }
        }

        public DataTable ListarMoradores()
        {
            try
            {
                conexaoSqlServer.LimparParametros();
                DataTable dadosTabela = new DataTable();
                dadosTabela = conexaoSqlServer.ExecutarConsulta(CommandType.StoredProcedure, "uspListarMoradores");
                return dadosTabela;
            }
            catch (Exception ex)
            {
                throw new Exception(ex.Message);
            }
        }

        public int SalvarDepedente(MoradorDepedente moradorDepedente)
        {
            try
            {
                conexaoSqlServer.LimparParametros();

                conexaoSqlServer.AdicionarParametros("@IdMorador", moradorDepedente.IdMorador);
                conexaoSqlServer.AdicionarParametros("@Nome", moradorDepedente.Nome);
                conexaoSqlServer.AdicionarParametros("@Tipo", moradorDepedente.Tipo);
                conexaoSqlServer.AdicionarParametros("@Genero", moradorDepedente.Genero);
                conexaoSqlServer.AdicionarParametros("@Idade", moradorDepedente.Idade);

                int ret = 0;
                ret = Convert.ToInt32(conexaoSqlServer.ExecutarManipulacao(CommandType.StoredProcedure, "uspSalvarMoradorDepedente").ToString());
                return ret;
            }
            catch (Exception ex)
            {
                throw new Exception(ex.Message);
            }
        }

        public DataTable ListarMoradoresDepedente(int idMorador)
        {
            try
            {
                conexaoSqlServer.LimparParametros();
                conexaoSqlServer.AdicionarParametros("@IdMorador", idMorador);
                DataTable dadosTabela = new DataTable();
                dadosTabela = conexaoSqlServer.ExecutarConsulta(CommandType.StoredProcedure, "uspListarMoradoresDepedente");
                return dadosTabela;
            }
            catch (Exception ex)
            {
                throw new Exception(ex.Message);
            }
        }

        public DataTable ListarUltimoMoradorCadastrado()
        {
            try
            {
                conexaoSqlServer.LimparParametros();
                DataTable dadosTabela = new DataTable();
                dadosTabela = conexaoSqlServer.ExecutarConsulta(CommandType.StoredProcedure, "uspListarUltimoMoradorCadastrado");
                return dadosTabela;
            }
            catch (Exception ex)
            {
                throw new Exception(ex.Message);
            }
        }

        public int Salvar(Morador morador)
        {
            try
            {
                conexaoSqlServer.LimparParametros();

                conexaoSqlServer.AdicionarParametros("@Torre", morador.Torre);
                conexaoSqlServer.AdicionarParametros("@Bloco", morador.Bloco);
                conexaoSqlServer.AdicionarParametros("@Apto", morador.Apto);
                conexaoSqlServer.AdicionarParametros("@TipoMorador", morador.TipoMorador);
                conexaoSqlServer.AdicionarParametros("@DataNascimento", morador.DataNascimento);
                conexaoSqlServer.AdicionarParametros("@Observacao", morador.Observacao);
                conexaoSqlServer.AdicionarParametros("@Titular", morador.Titulo);
                conexaoSqlServer.AdicionarParametros("@Email", morador.Email);
                conexaoSqlServer.AdicionarParametros("@Cpf", morador.Cpf);
                conexaoSqlServer.AdicionarParametros("@Rg", morador.Rg);
                conexaoSqlServer.AdicionarParametros("@Telefone", morador.Telefone);
                conexaoSqlServer.AdicionarParametros("@Celular", morador.Celular);
                conexaoSqlServer.AdicionarParametros("@Comercial", morador.Comercial);
                conexaoSqlServer.AdicionarParametros("@Data", DateTime.Now);
                conexaoSqlServer.AdicionarParametros("@Ativo", morador.Status);

                int ret = 0;
                ret = Convert.ToInt32(conexaoSqlServer.ExecutarManipulacao(CommandType.StoredProcedure, "uspSalvarMorador").ToString());
                return ret;
            }
            catch (Exception ex)
            {
                throw new Exception(ex.Message);
            }
        }

        public object AlterarMorador(Morador morador)
        {
            try
            {
                conexaoSqlServer.LimparParametros();

                conexaoSqlServer.AdicionarParametros("@Id", morador.Id);
                conexaoSqlServer.AdicionarParametros("@Titular", morador.Titulo);
                conexaoSqlServer.AdicionarParametros("@Torre", morador.Torre);
                conexaoSqlServer.AdicionarParametros("@Bloco", morador.Bloco);
                conexaoSqlServer.AdicionarParametros("@Apto", morador.Apto);
                conexaoSqlServer.AdicionarParametros("@TipoMorador", morador.TipoMorador);
                conexaoSqlServer.AdicionarParametros("@Observacao", morador.Observacao);
                conexaoSqlServer.AdicionarParametros("@Email", morador.Email);
                conexaoSqlServer.AdicionarParametros("@Cpf", morador.Cpf);
                conexaoSqlServer.AdicionarParametros("@Rg", morador.Rg);
                conexaoSqlServer.AdicionarParametros("@Telefone", morador.Telefone);
                conexaoSqlServer.AdicionarParametros("@Celular", morador.Celular);
                conexaoSqlServer.AdicionarParametros("@Comercial", morador.Comercial);
                conexaoSqlServer.AdicionarParametros("@Ativo", morador.Status);

                int ret = 0;
                ret = Convert.ToInt32(conexaoSqlServer.ExecutarManipulacao(CommandType.StoredProcedure, "uspAlterarMorador").ToString());
                return ret;
            }
            catch (Exception ex)
            {
                throw new Exception(ex.Message);
            }
        }

        public DataTable ListarMoradoresId(int idMorador)
        {
            try
            {
                conexaoSqlServer.LimparParametros();
                conexaoSqlServer.AdicionarParametros("@IdMorador", idMorador);
                DataTable dadosTabela = new DataTable();
                dadosTabela = conexaoSqlServer.ExecutarConsulta(CommandType.StoredProcedure, "uspListarMoradorId");
                return dadosTabela;
            }
            catch (Exception ex)
            {
                throw new Exception(ex.Message);
            }
        }

        public int AlterarMoradorDepedente(MoradorDepedente moradorDepedente)
        {
            try
            {
                conexaoSqlServer.LimparParametros();

                conexaoSqlServer.AdicionarParametros("@Id", moradorDepedente.Id);
                conexaoSqlServer.AdicionarParametros("@Nome", moradorDepedente.Nome);
                conexaoSqlServer.AdicionarParametros("@Tipo", moradorDepedente.Tipo);
                conexaoSqlServer.AdicionarParametros("@Genero", moradorDepedente.Genero);
                conexaoSqlServer.AdicionarParametros("@Idade", moradorDepedente.Idade);

                int ret = 0;
                ret = Convert.ToInt32(conexaoSqlServer.ExecutarManipulacao(CommandType.StoredProcedure, "uspAlterarMoradorDepedente").ToString());
                return ret;
            }
            catch (Exception ex)
            {
                throw new Exception(ex.Message);
            }
        }

        public int Deletar(MoradorDepedente moradorDepedente)
        {
            try
            {
                conexaoSqlServer.LimparParametros();

                conexaoSqlServer.AdicionarParametros("@Id", moradorDepedente.Id);

                int ret = 0;
                ret = Convert.ToInt32(conexaoSqlServer.ExecutarManipulacao(CommandType.StoredProcedure, "uspMoradorDependenteDeletarId").ToString());
                return ret;
            }
            catch (Exception ex)
            {
                throw new Exception(ex.Message);
            }
        }
    }
}
