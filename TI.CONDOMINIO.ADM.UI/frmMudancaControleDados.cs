using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using TI.REGRA.NEGOCIOS;
using TI.OBJETO.TRANSFERENCIA;

namespace TI.CONDOMINIO.ADM.UI
{
    public partial class frmMudancaControleDados : Form
    {
        frmControleMudancas frmControleMudancas;

        public frmMudancaControleDados(frmControleMudancas fControleMudancas, string hInicio, string hFim, int idMud)
        {
            InitializeComponent();

            this.frmControleMudancas = fControleMudancas;
            this.dgvEmpresa.AutoGenerateColumns = false;
            this.horaInicio = hInicio;
            this.horaFinal = hFim;
            this.idMudanca = idMud;
        }

        #region CLASSES E OBJETOS

        UsuarioRegraNegocios usuarioRegraNegocios;
        DataTable dadosTabela;
        Prestador prestador;

        #endregion

        #region VARIAVEIS

        public int tag = 0;
        public int tipo = 0;
        public int idPrestador = 0;
        public int idMudanca = 0;
        public string horaInicio, horaFinal = "";
        public string statusDescricao = "";

        #endregion

        private void frmMudancaControleDados_Load(object sender, EventArgs e)
        {
            LoadTela();
        }

        public void LoadTela()
        {
            try
            {
                txtData.Text = frmControleMudancas.data;
                txtTorre.Text = frmControleMudancas.torre;
                txtBloco.Text = frmControleMudancas.bloco;
                txtApto.Text = frmControleMudancas.apto;
                txtHoraInicio.Text = frmControleMudancas.hInicio;
                txtHoraFim.Text = frmControleMudancas.hFim;
                lblDescPeriodo.Text = frmControleMudancas.descPeriodo;
                lblDescricaoMudanca.Text = frmControleMudancas.statusMudanca;

                txtPesquisas.Focus();
                txtPesquisas.SelectAll();

                Listar();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        public void Listar()
        {
            try
            {
                usuarioRegraNegocios = new UsuarioRegraNegocios();
                dadosTabela = new DataTable();

                tipo = Convert.ToInt32(cbxTipoPesquisa.Text.Trim().Substring(0, 1));

                dadosTabela = usuarioRegraNegocios.ListarPrestador(txtPesquisas.Text, tipo);

                if (dadosTabela.Rows.Count > 0)
                {
                    dgvEmpresa.DataSource = null;
                    dgvEmpresa.DataSource = dadosTabela;
                }
                else
                {
                    dgvEmpresa.DataSource = null;
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void dgvEmpresa_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            try
            {
                if (dgvEmpresa.Columns[e.ColumnIndex].Name.Trim().Equals("colSel"))
                {
                    tag = 1;

                    idPrestador = Convert.ToInt32(dgvEmpresa.Rows[e.RowIndex].Cells["colid"].Value.ToString());
                    txtNome.Text = dgvEmpresa.Rows[e.RowIndex].Cells["colNome"].Value.ToString().Trim();
                    cbTipoDocs.Text = dgvEmpresa.Rows[e.RowIndex].Cells["colTipo"].Value.ToString().Trim();
                    txtDocumento.Text = dgvEmpresa.Rows[e.RowIndex].Cells["colDocumento"].Value.ToString().Trim();
                    txtCelular.Text = dgvEmpresa.Rows[e.RowIndex].Cells["colCelular"].Value.ToString().Trim();
                    txtTelefone.Text = dgvEmpresa.Rows[e.RowIndex].Cells["colTefefone"].Value.ToString().Trim();
                    txtEmpresa.Text = dgvEmpresa.Rows[e.RowIndex].Cells["colEmpresa"].Value.ToString().Trim();
                    txtVeiculo.Text = dgvEmpresa.Rows[e.RowIndex].Cells["colVeiculo"].Value.ToString().Trim();
                    txtPlaca.Text = dgvEmpresa.Rows[e.RowIndex].Cells["colPlaca"].Value.ToString().Trim();

                    gbxResponsavel.Enabled = true;
                    btnIniciarMudanca.Enabled = true;

                    txtNome.Focus();
                    txtNome.SelectAll();
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        public void Limpar()
        {
            tag = 0;
            idPrestador = 0;
            txtNome.Text = "";
            cbTipoDocs.Text = "";
            txtDocumento.Text = "";
            txtCelular.Text = "";
            txtEmpresa.Text = "";
            txtVeiculo.Text = "";
            txtPlaca.Text = "";

            gbxResponsavel.Enabled = true;

            txtNome.Focus();
            txtNome.SelectAll();
        }

        private void txtPesquisas_TextChanged(object sender, EventArgs e)
        {
            Listar();
        }

        private void cbxTipoPesquisa_SelectedIndexChanged(object sender, EventArgs e)
        {
            txtPesquisas.Focus();
            txtPesquisas.SelectAll();
        }

        private void btnNovo_Click(object sender, EventArgs e)
        {
            if (idPrestador == 0 && MessageBox.Show("Realmente Deseja Iniciar um Novo Cadastro de Prestador de Serviço", "Confirmação", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
            {
                Limpar();
            }
        }

        private void cbTipoDocs_SelectedIndexChanged(object sender, EventArgs e)
        {
            txtDocumento.Focus();
            txtDocumento.SelectAll();
        }

        private void btnSalvar_Click(object sender, EventArgs e)
        {
            Salvar(e);
        }

        public void Salvar(EventArgs e)
        {
            try
            {
                if (txtNome.Text.Trim().Equals(""))
                {
                    MessageBox.Show("Campo Nome do Prestador não Pode ser nulo ou Vázio.", "Atenção", MessageBoxButtons.OK, MessageBoxIcon.Stop);

                    txtNome.Focus();
                    txtNome.SelectAll();
                }
                else if (cbTipoDocs.Text.Trim().Equals(""))
                {
                    MessageBox.Show("Campo Tipo Documento não Pode ser nulo ou Vázio.", "Atenção", MessageBoxButtons.OK, MessageBoxIcon.Stop);

                    cbTipoDocs.Focus();
                    cbTipoDocs.SelectAll();
                }
                else if (txtDocumento.Text.Trim().Equals(""))
                {
                    MessageBox.Show("Campo Documento não Pode ser nulo ou Vázio.", "Atenção", MessageBoxButtons.OK, MessageBoxIcon.Stop);

                    txtDocumento.Focus();
                    txtDocumento.SelectAll();
                }
                else if (txtCelular.Text.Trim().Equals(""))
                {
                    MessageBox.Show("Campo Telefone não Pode ser nulo ou Vázio.", "Atenção", MessageBoxButtons.OK, MessageBoxIcon.Stop);

                    txtCelular.Focus();
                    txtCelular.SelectAll();
                }
                else if (txtEmpresa.Text.Trim().Equals(""))
                {
                    MessageBox.Show("Campo Nome da Empresa não Pode ser nulo ou Vázio.", "Atenção", MessageBoxButtons.OK, MessageBoxIcon.Stop);

                    txtEmpresa.Focus();
                    txtEmpresa.SelectAll();
                }
                else if (txtVeiculo.Text.Trim().Equals(""))
                {
                    MessageBox.Show("Campo Veiculo da Empresa não Pode ser nulo ou Vázio.", "Atenção", MessageBoxButtons.OK, MessageBoxIcon.Stop);

                    txtVeiculo.Focus();
                    txtVeiculo.SelectAll();
                }
                else if (txtPlaca.Text.Trim().Equals(""))
                {
                    MessageBox.Show("Campo Placa do Veiculo da Empresa não Pode ser nulo ou Vázio.", "Atenção", MessageBoxButtons.OK, MessageBoxIcon.Stop);

                    txtPlaca.Focus();
                    txtPlaca.SelectAll();
                }
                else
                {
                    prestador = new Prestador();

                    prestador.Id = idPrestador;
                    prestador.Nome = txtNome.Text.Trim();
                    prestador.Tipo = cbTipoDocs.Text.Trim();
                    prestador.Documento = txtDocumento.Text.Trim();
                    prestador.Telefone = txtTelefone.Text.Trim();
                    prestador.Celular = txtCelular.Text.Trim();
                    prestador.Empresa = txtEmpresa.Text.Trim();
                    prestador.Veiculo = txtVeiculo.Text.Trim().Trim();
                    prestador.Placa = txtPlaca.Text.Trim().Trim();

                    int idRet = usuarioRegraNegocios.SalvarPrestador(prestador);

                    if (idRet > 0)
                    {
                        if (tag == 0)
                        {
                            MessageBox.Show("Cadastro de Prestador foi Realizado com Sucesso.", "Informação", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        }
                        else
                        {
                            MessageBox.Show("Prestador de Serviço foi Alterado com Sucesso.", "Informação", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                        }

                        this.OnLoad(e);
                    }
                    else
                    {
                        MessageBox.Show("Erro ao Salvar Prestador de Serviço.", "Erro", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            frmHoraMudanca frmHoraMudanca = new frmHoraMudanca(horaInicio, horaFinal, idMudanca);
            frmHoraMudanca.ShowDialog();

            this.OnLoad(e);
        }

        public void DescricaoStatusMudanca()
        {
            if (true)
            {
                lblDescricaoMudanca.Text = statusDescricao;
            }
        }
    }
}
