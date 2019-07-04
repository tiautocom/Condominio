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
    public class MudancaRegraNegocios
    {
        Conexao conexaoSqlServer = new Conexao();

        public DataTable ListarAll()
        {
            try
            {
                conexaoSqlServer.LimparParametros();
                DataTable dadosTabela = new DataTable();
                dadosTabela = conexaoSqlServer.ExecutarConsulta(CommandType.StoredProcedure, "uspListarMudancaAll");
                return dadosTabela;
            }
            catch (Exception ex)
            {
                throw new Exception(ex.Message);
            }
        }

        public DataTable PesquisarTorres(int idNumTorre, string bloco, int apto)
        {
            try
            {
                conexaoSqlServer.LimparParametros();

                conexaoSqlServer.AdicionarParametros("@NUM_TORRE", idNumTorre);
                conexaoSqlServer.AdicionarParametros("@NUM_BLOCO", bloco);
                conexaoSqlServer.AdicionarParametros("@NUM_APTO", apto);

                DataTable dadosTabela = new DataTable();
                dadosTabela = conexaoSqlServer.ExecutarConsulta(CommandType.StoredProcedure, "uspListarTorreId");
                return dadosTabela;
            }
            catch (Exception ex)
            {
                throw new Exception(ex.Message);
            }
        }

        public int IniciarMudanca(int id, string hora)
        {
            try
            {
                conexaoSqlServer.LimparParametros();
                conexaoSqlServer.AdicionarParametros("@Id", id);
                conexaoSqlServer.AdicionarParametros("@Inicio", hora);

                int ret = 0;

                ret = Convert.ToInt32(conexaoSqlServer.ExecutarManipulacao(CommandType.StoredProcedure, "uspMudancaIniciar").ToString());

                return ret;
            }
            catch (Exception ex)
            {
                throw new Exception(ex.Message);
            }
        }

        public DataTable PesquisarDataMudanca(string data, int lado, int periodo, int numTorre)
        {
            try
            {
                conexaoSqlServer.LimparParametros();

                conexaoSqlServer.AdicionarParametros("@DATA", data.ToString());
                conexaoSqlServer.AdicionarParametros("@LADO", lado);
                conexaoSqlServer.AdicionarParametros("@PERIODO", periodo);
                conexaoSqlServer.AdicionarParametros("@NUM_TORRE", numTorre);

                DataTable dadosTabela = new DataTable();
                dadosTabela = conexaoSqlServer.ExecutarConsulta(CommandType.StoredProcedure, "uspListarTorrePerido");
                return dadosTabela;
            }
            catch (Exception ex)
            {
                throw new Exception(ex.Message);
            }
        }

        public int FecharMudanca(int id, string hora)
        {
            try
            {
                conexaoSqlServer.LimparParametros();
                conexaoSqlServer.AdicionarParametros("@Id", id);
                conexaoSqlServer.AdicionarParametros("@Termino", hora);

                int ret = 0;

                ret = Convert.ToInt32(conexaoSqlServer.ExecutarManipulacao(CommandType.StoredProcedure, "uspMudancaFinalizar").ToString());
                return ret;
            }
            catch (Exception ex)
            {
                throw new Exception(ex.Message);
            }
        }

        public DataTable PesquisarDataMudancaId(int idMudanca)
        {
            try
            {
                conexaoSqlServer.LimparParametros();

                conexaoSqlServer.AdicionarParametros("@Id", idMudanca);

                DataTable dadosTabela = new DataTable();
                dadosTabela = conexaoSqlServer.ExecutarConsulta(CommandType.StoredProcedure, "uspListarDataMudancaId");
                return dadosTabela;
            }
            catch (Exception ex)
            {
                throw new Exception(ex.Message);
            }
        }

        public int Cadastrar(Mudancas mudancas)
        {
            try
            {
                conexaoSqlServer.LimparParametros();
                conexaoSqlServer.AdicionarParametros("@Data", mudancas.Data.ToString("yyyy-MM-dd"));
                conexaoSqlServer.AdicionarParametros("@IdTorre", mudancas.IdTorre);
                conexaoSqlServer.AdicionarParametros("@IdBloco", mudancas.IdBloco);
                conexaoSqlServer.AdicionarParametros("@IdPeriodo", mudancas.IdPeriodo);
                conexaoSqlServer.AdicionarParametros("@IdStatus", mudancas.IdStatus);
                conexaoSqlServer.AdicionarParametros("@IdUsuario", mudancas.IdUsuario);
                conexaoSqlServer.AdicionarParametros("@IdSindico", mudancas.IdSindico);
                conexaoSqlServer.AdicionarParametros("@Apto", mudancas.Apto);
                conexaoSqlServer.AdicionarParametros("@DataCad", DateTime.Now);
                conexaoSqlServer.AdicionarParametros("@Lado", mudancas.Lado);
                conexaoSqlServer.AdicionarParametros("@Bloco", mudancas.Bloco);

                int ret = 0;
                ret = Convert.ToInt32(conexaoSqlServer.ExecutarManipulacao(CommandType.StoredProcedure, "uspMudancaSalvar").ToString());
                return ret;
            }
            catch (Exception ex)
            {
                throw new Exception(ex.Message);
            }
        }
    }
}
