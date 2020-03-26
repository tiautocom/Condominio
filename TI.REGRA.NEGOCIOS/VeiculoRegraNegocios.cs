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
    public class VeiculoRegraNegocios
    {
        Conexao conexaoSqlServer = new Conexao();

        public object Salvar(Veiculo veiculo)
        {
            try
            {
                conexaoSqlServer.LimparParametros();

                conexaoSqlServer.AdicionarParametros("@IdMorador", veiculo.IdMorador);
                conexaoSqlServer.AdicionarParametros("@Modelo", veiculo.Modelo);
                conexaoSqlServer.AdicionarParametros("@Marca", veiculo.Marca);
                conexaoSqlServer.AdicionarParametros("@Placa", veiculo.Placa);
                conexaoSqlServer.AdicionarParametros("@Cor", veiculo.Cor);
                conexaoSqlServer.AdicionarParametros("@Tipo", veiculo.Tipo);
                conexaoSqlServer.AdicionarParametros("@NumVaga", veiculo.NumVaga);

                int ret = 0;

                ret = Convert.ToInt32(conexaoSqlServer.ExecutarManipulacao(CommandType.StoredProcedure, "uspVeiculoSalvar").ToString());
                return ret;
            }
            catch (Exception ex)
            {
                throw new Exception(ex.Message);
            }
        }

        public DataTable Listar(int idMorador)
        {
            try
            {
                conexaoSqlServer.LimparParametros();
                conexaoSqlServer.AdicionarParametros("@IdMorador", idMorador);

                DataTable dadosTabela = new DataTable();
                dadosTabela = conexaoSqlServer.ExecutarConsulta(CommandType.StoredProcedure, "uspVeiculoListar");
                return dadosTabela;
            }
            catch (Exception ex)
            {
                throw new Exception(ex.Message);
            }
        }

        public int Alterar(Veiculo veiculo)
        {
            try
            {
                conexaoSqlServer.LimparParametros();

                conexaoSqlServer.AdicionarParametros("@Id", veiculo.Id);
                conexaoSqlServer.AdicionarParametros("@Modelo", veiculo.Modelo);
                conexaoSqlServer.AdicionarParametros("@Marca", veiculo.Marca);
                conexaoSqlServer.AdicionarParametros("@Placa", veiculo.Placa);
                conexaoSqlServer.AdicionarParametros("@Cor", veiculo.Cor);
                conexaoSqlServer.AdicionarParametros("@Tipo", veiculo.Tipo);
                conexaoSqlServer.AdicionarParametros("@NumVaga", veiculo.NumVaga);

                int ret = 0;

                ret = Convert.ToInt32(conexaoSqlServer.ExecutarManipulacao(CommandType.StoredProcedure, "uspVeiculoAlterar").ToString());
                return ret;
            }
            catch (Exception ex)
            {
                throw new Exception(ex.Message);
            }
        }

        public int Deletar(Veiculo veiculo)
        {
            try
            {
                conexaoSqlServer.LimparParametros();

                conexaoSqlServer.AdicionarParametros("@id", veiculo.Id);

                int ret = 0;
                ret = Convert.ToInt32(conexaoSqlServer.ExecutarManipulacao(CommandType.StoredProcedure, "uspVeiculoDeletar").ToString());
                return ret;
            }
            catch(Exception ex)
            {
                throw new Exception(ex.Message);
            }
        }
    }
}
