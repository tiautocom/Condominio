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
    public partial class frmCadApartamento : Form
    {
        public frmCadApartamento()
        {
            InitializeComponent();
        }

        #region CLASSES E OBJETOS

        EmpresaRegraNegocios empresaRegraNrgocios;
        PessoaRegraNegocios pessoaRegraNegocios;
        Apartamento apartamento;
        DataTable dadosTabela;

        #endregion

        #region VARIAVEIS

        public int idEmpresa, idEndereco = 0;
        public string bloco, apt, anda, empresa = "";
        public bool retorno;

        #endregion

        public void LoadTela()
        {
            ListarEmpresa();
        }

        public void ListarEmpresa()
        {
            try
            {
                dadosTabela = new DataTable();
                empresaRegraNrgocios = new EmpresaRegraNegocios();

                dadosTabela = empresaRegraNrgocios.ListarAll();

                if (dadosTabela.Rows.Count > 0)
                {
                    //this.cbEmpresa.DataSource = null;
                    this.cbEmpresa.DataSource = dadosTabela;
                    this.cbEmpresa.DisplayMember = "NomeRazao";
                    this.cbEmpresa.ValueMember = "IdPessoa";
                }
                else
                {
                    this.cbEmpresa.DataSource = null;
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void frmCadApartamento_Load(object sender, EventArgs e)
        {
            LoadTela();
        }

        private void btnSelecionarAssinaturaDig_Click(object sender, EventArgs e)
        {
            TratarCampos(e);
        }

        private void linkLabel1_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            frmListarApartamentos frmListarApartamentos = new frmListarApartamentos(Convert.ToInt32(cbEmpresa.SelectedValue), cbEmpresa.Text.Trim());
            frmListarApartamentos.ShowDialog();
        }

        private void btnNovo_Click(object sender, EventArgs e)
        {
            txtAndar.Text = "";
            txtApartamento.Text = "";
            txtBloco.Text = "";
            txtApartamento.Focus();
            txtApartamento.SelectAll();

            this.OnLoad(e);
        }

        public void PesquisarApartamentoSalvarId(EventArgs e)
        {
            try
            {
                dadosTabela = new DataTable();
                pessoaRegraNegocios = new PessoaRegraNegocios();

                idEmpresa = Convert.ToInt32(cbEmpresa.SelectedValue);

                dadosTabela = new DataTable();

                dadosTabela = pessoaRegraNegocios.PesquisarEmpresaId(idEmpresa, txtBloco.Text.Trim(), txtAndar.Text.Trim(), txtApartamento.Text.Trim());

                if (dadosTabela.Rows.Count == 0)
                {
                    apartamento = new Apartamento();

                    apartamento.IdPessoa = idEmpresa;
                    apartamento.NumAndar = txtAndar.Text.Trim().PadLeft(2, '0');
                    apartamento.NumBloco = txtBloco.Text.Trim();
                    apartamento.NumApto = txtApartamento.Text.Trim().PadLeft(3, '0');
                    apartamento.Ativo = false;

                    int idRet = pessoaRegraNegocios.SalvarApartamento(apartamento);

                    if (idRet > 0)
                    {
                        MessageBox.Show("Empresa: " + cbEmpresa.Text + ".\n" + "APARTAMENTO: " + apartamento.NumApto + ".\nANDAR: " + apartamento.NumAndar.PadLeft(2, '0') + ".\nBLOCO: " + apartamento.NumBloco + "\nApartamento Cadastrado com Sucesso.", "Informação", MessageBoxButtons.OK, MessageBoxIcon.Information);

                        LimparCampo();
                    }
                    else
                    {
                        MessageBox.Show("Erro ao Salvar Apartamento", "Erro", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                }
                else
                {
                    MessageBox.Show("Informação do Apartamento já Consta na Base de Dados.");
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        public bool TratarCampos(EventArgs e)
        {
            try
            {
                if (txtApartamento.Text.Trim().Equals(""))
                {
                    MessageBox.Show("Campo Numero do Apartamento não Pode ser Nulo ou Vázio.", "Atenção", MessageBoxButtons.OK, MessageBoxIcon.Stop);
                    txtApartamento.Focus();
                }
                else if (cbEmpresa.Text.Trim().Equals(""))
                {
                    MessageBox.Show("Campo Numero do Andar não Pode ser Nulo ou Vázio.", "Atenção", MessageBoxButtons.OK, MessageBoxIcon.Stop);
                    txtAndar.Focus();
                }
                else if (txtBloco.Text.Trim().Equals(""))
                {
                    MessageBox.Show("Campo Numero do Bloco não Pode ser Nulo ou Vázio.", "Atenção", MessageBoxButtons.OK, MessageBoxIcon.Stop);
                    txtBloco.Focus();
                }
                else
                {
                    PesquisarApartamentoSalvarId(e);
                }

                return retorno;
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
                return false;
            }
        }

        public void LimparCampo()
        {
            txtApartamento.Text = "";
            txtApartamento.Focus();
            txtApartamento.SelectAll();
        }
    }
}
