using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TI.ACESSO.DADOS;

namespace TI.REGRA.NEGOCIOS
{
    public class FotoRegraNegocios
    {
        Conexao conexaoSqlServer = new Conexao();

        public int SalvarFotoGaleria(string titulo, string caminho, int idUsuario, int idRet)
        {
            try
            {
                conexaoSqlServer.LimparParametros();

                conexaoSqlServer.AdicionarParametros("@Titulo", titulo);
                conexaoSqlServer.AdicionarParametros("@UrlFoto", caminho);
                conexaoSqlServer.AdicionarParametros("@IdUsuario", idUsuario);
                conexaoSqlServer.AdicionarParametros("@IdGaleria", idRet);

                int ret = 0;
                ret = Convert.ToInt32(conexaoSqlServer.ExecutarManipulacao(CommandType.StoredProcedure, "uspFotoGaleriaSalvar").ToString());
                return ret;
            }
            catch (Exception ex)
            {
                throw new Exception(ex.Message);
            }
        }

        public int SalvarFotoGaleriaPlus(string titulo, string navegador, int idUsuario, int idGaleria)
        {
            try
            {
                conexaoSqlServer.LimparParametros();

                conexaoSqlServer.AdicionarParametros("@Titulo", titulo);
                conexaoSqlServer.AdicionarParametros("@UrlFoto", navegador);
                conexaoSqlServer.AdicionarParametros("@IdUsuario", idUsuario);
                conexaoSqlServer.AdicionarParametros("@IdGaleria", idGaleria);

                int ret = 0;
                ret = Convert.ToInt32(conexaoSqlServer.ExecutarManipulacao(CommandType.StoredProcedure, "uspFotoGaleriaSalvarPlus").ToString());
                return ret;
            }
            catch (Exception ex)
            {
                throw new Exception(ex.Message);
            }
        }
    }
}
