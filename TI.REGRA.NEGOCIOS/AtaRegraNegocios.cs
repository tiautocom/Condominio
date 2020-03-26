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
    public class AtaRegraNegocios
    {
        Conexao conexaoSqlServer = new Conexao();

        public int Salvar(Ata ata)
        {
            try
            {
                conexaoSqlServer.LimparParametros();
                conexaoSqlServer.AdicionarParametros("@Titulo", ata.Titulo);
                conexaoSqlServer.AdicionarParametros("@Data", ata.Data);
                conexaoSqlServer.AdicionarParametros("@IdUsuario", ata.IdUsuario);
                conexaoSqlServer.AdicionarParametros("@DataCadastro", DateTime.Now.Date);
                conexaoSqlServer.AdicionarParametros("@TipoAssembleia", ata.TipoAssembleia);
                conexaoSqlServer.AdicionarParametros("@IdEmpresa", ata.IdEmpresa);
                conexaoSqlServer.AdicionarParametros("@Url", ata.Url);
                conexaoSqlServer.AdicionarParametros("@Descricao", ata.Descricao);

                int ret = 0;

                ret = Convert.ToInt32(conexaoSqlServer.ExecutarManipulacao(CommandType.StoredProcedure, "uspAtaSalvar").ToString());

                return ret;
            }
            catch (Exception ex)
            {
                throw new Exception(ex.Message);
            }
        }

        public DataTable Listar(int idEmpresa, string Data)
        {
            try
            {
                conexaoSqlServer.LimparParametros();
                conexaoSqlServer.AdicionarParametros("@Data", Data);
                conexaoSqlServer.AdicionarParametros("@IdEmpresa", idEmpresa);
                DataTable dadosTabela = new DataTable();
                dadosTabela = conexaoSqlServer.ExecutarConsulta(CommandType.StoredProcedure, "uspListarAtas");
                return dadosTabela;
            }
            catch (Exception ex)
            {
                throw new Exception(ex.Message);
            }
        }
    }
}
