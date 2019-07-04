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
    public class TransparenciaRegraNegocios
    {
        Conexao conexaoSqlServer = new Conexao();

        public int Salvar(Tranparencias tranparencia)
        {
            try
            {
                conexaoSqlServer.LimparParametros();

                conexaoSqlServer.AdicionarParametros("@ID_LEI", tranparencia.IdLei);
                conexaoSqlServer.AdicionarParametros("@ID_USUARIO", tranparencia.IdUsuario);
                conexaoSqlServer.AdicionarParametros("@ID_PESSOA", tranparencia.IdPessoa);
                conexaoSqlServer.AdicionarParametros("@DATA", tranparencia.Data);
                conexaoSqlServer.AdicionarParametros("@DESCRICAO", tranparencia.Descricao);

                int ret = 0;
                ret = Convert.ToInt32(conexaoSqlServer.ExecutarManipulacao(CommandType.StoredProcedure, "uspTransparenciaSalvar").ToString());
                return ret;
            }
            catch (Exception ex)
            {
                throw new Exception(ex.Message);
            }
        }

        public DataTable ListarAll(int idEmpresa, int idLai)
        {
            try
            {
                conexaoSqlServer.LimparParametros();
                conexaoSqlServer.AdicionarParametros("@ID_EMPRESA", idEmpresa);
                conexaoSqlServer.AdicionarParametros("@ID_LAI", idLai);

                DataTable dadosTabela = new DataTable();
                dadosTabela = conexaoSqlServer.ExecutarConsulta(CommandType.StoredProcedure, "uspListarTransparenciaIdEmpresa");
                return dadosTabela;
            }
            catch (Exception ex)
            {
                throw new Exception(ex.Message);
            }
        }

        public int Deletar(int idEmpresa, int idTransp)
        {

            try
            {
                conexaoSqlServer.LimparParametros();

                conexaoSqlServer.AdicionarParametros("@ID_EMPRESA", idEmpresa);
                conexaoSqlServer.AdicionarParametros("@ID_TRANSPARENCIA", idTransp);

                int ret = 0;
                ret = Convert.ToInt32(conexaoSqlServer.ExecutarManipulacao(CommandType.StoredProcedure, "uspDeletarTransparenciaIdEmpresa").ToString());
                return ret;
            }
            catch (Exception ex)
            {
                throw new Exception(ex.Message);
            }
        }
    }
}
