using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using TI.OBJETO.TRANSFERENCIA;
using TI.REGRA.NEGOCIOS;

namespace TI.CONDOMINIO.ADM.UI
{
    public partial class frmListarApartamentos : Form
    {
        public frmListarApartamentos(int idEmp, string nomeEmpresa)
        {
            InitializeComponent();

            dgvApartamento.AutoGenerateColumns = false;

            idEmpresa = idEmp;
            txtNomeTitular.Text = nomeEmpresa.Trim();
        }

        #region VARIAVEIS

        public int idEmpresa, idApartamento = 0;
        public string numApto, bloco, andar, empresa = "";

        #endregion

        #region CLASSES E OBJETOS

        DataTable dadosTabela;
        ApartamentoRegraNegocios apartamentoRegraNegocios;

        #endregion

        private void frmListarApartamentos_Load(object sender, EventArgs e)
        {
            ListarApartamentos();
        }

        public void ListarApartamentos()
        {
            try
            {
                apartamentoRegraNegocios = new ApartamentoRegraNegocios();
                dadosTabela = new DataTable();

                dadosTabela = apartamentoRegraNegocios.ListarApartamentoId(idEmpresa);

                if (dadosTabela.Rows.Count > 0)
                {
                    dgvApartamento.DataSource = null;
                    dgvApartamento.DataSource = dadosTabela;
                }
                else
                {
                    dgvApartamento.DataSource = null;
                }

                lblQtde.Text = dgvApartamento.Rows.Count.ToString().PadLeft(3, '0').Trim();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void dgvApartamento_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            if (dgvApartamento.Rows.Count > 0)
            {
                empresa = txtNomeTitular.Text.Trim();
                numApto = dgvApartamento.Rows[e.RowIndex].Cells["colnumApto"].Value.ToString().Trim();
                bloco = dgvApartamento.Rows[e.RowIndex].Cells["colNumBloco"].Value.ToString().Trim();
                andar = dgvApartamento.Rows[e.RowIndex].Cells["colNumANDAR"].Value.ToString().Trim();

                if (dgvApartamento.Columns[e.ColumnIndex].Name.Trim().Equals("colDel"))
                {
                    if (MessageBox.Show("Realmente Deseja Cancelar Apartamento Numero: " + numApto + ".\nBloco: " + bloco + ".\nAndar: " + andar + ".", "Confirmação para Deletar Dados", MessageBoxButtons.YesNo, MessageBoxIcon.Question, MessageBoxDefaultButton.Button2) == DialogResult.Yes)
                    {
                        idApartamento = Convert.ToInt32(dgvApartamento.Rows[e.RowIndex].Cells["colId"].Value.ToString().Trim());

                        apartamentoRegraNegocios = new ApartamentoRegraNegocios();

                        int idRet = apartamentoRegraNegocios.DeletarApartamento(idApartamento);

                        if (idRet > 0)
                        {
                            MessageBox.Show("Apartamento Numero: " + numApto + " Foi Deletado com Sucesso.", "Informação", MessageBoxButtons.OK, MessageBoxIcon.Information);

                            this.OnLoad(e);
                        }
                        else
                        {
                            MessageBox.Show("Erro ao Deletar Apartamento Numero: " + numApto, "Erro", MessageBoxButtons.OK, MessageBoxIcon.Error);
                        }
                    }
                }

                if (dgvApartamento.Columns[e.ColumnIndex].Name.Trim().Equals("colAlt"))
                {
                    idApartamento = Convert.ToInt32(dgvApartamento.Rows[e.RowIndex].Cells["colId"].Value.ToString().Trim());

                    frmAlterarApartamento frmAlterarApartamento = new frmAlterarApartamento(idApartamento, empresa, bloco, andar, numApto);
                    frmAlterarApartamento.ShowDialog();

                    this.OnLoad(e);
                }
            }
        }
    }
}
