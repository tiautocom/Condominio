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
                conexaoSqlServer.AdicionarParametros("@Url", ata.Url);
                conexaoSqlServer.AdicionarParametros("@DataCadastro", DateTime.Now.Date);
                conexaoSqlServer.AdicionarParametros("@IdEmpresa", ata.TipoAssembleia);

                int ret = 0;
                ret = Convert.ToInt32(conexaoSqlServer.ExecutarManipulacao(CommandType.StoredProcedure, "uspAtaSalvar").ToString());
                return ret;
            }
            catch (Exception ex)
            {
                throw new Exception(ex.Message);
            }
        }
    }
}
