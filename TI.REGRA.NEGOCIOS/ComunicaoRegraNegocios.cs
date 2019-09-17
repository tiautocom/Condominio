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
    public class ComunicaoRegraNegocios
    {
        Conexao conexaoSqlServer = new Conexao();

        public int Salvar(Comunicado comunicado)
        {
            try
            {
                conexaoSqlServer.LimparParametros();
                //conexaoSqlServer.AdicionarParametros("@Id", comunicado.id);
                conexaoSqlServer.AdicionarParametros("@Descricao", comunicado.Descricao);
                conexaoSqlServer.AdicionarParametros("@Data", comunicado.Data);
                conexaoSqlServer.AdicionarParametros("@IdUsuario", comunicado.IdUsuario);
                conexaoSqlServer.AdicionarParametros("@Url", comunicado.Url);

                int ret = 0;

                ret = Convert.ToInt32(conexaoSqlServer.ExecutarManipulacao(CommandType.StoredProcedure, "uspComunicaoSalvar").ToString());

                return ret;
            }
            catch (Exception ex)
            {
                throw new Exception(ex.Message);
            }
        }
    }
}
