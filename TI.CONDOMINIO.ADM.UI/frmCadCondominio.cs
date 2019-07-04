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
    public partial class frmCadCondominio : Form
    {
        public frmCadCondominio()
        {
            InitializeComponent();
        }

        #region CLASSES E OBJETOS

        Pessoa pessoa;
        PessoaRegraNegocios pessoaRegraNegocios;

        #endregion

        #region VARIAVEIS

        public int idRet = 0;
        public bool retorno;

        #endregion

        private void btnSalvar_Click(object sender, EventArgs e)
        {
            Salvar(e);
        }

        public void Salvar(EventArgs e)
        {
            try
            {
                PesquisarCampos();

                if (retorno == true)
                {
                    pessoa = new Pessoa();
                    pessoa.Id = 0;
                    pessoa.NomeRazao = txtNomeRazao.Text.Trim();
                    pessoa.CpfCnpj = txtCpfCnpj.Text.Trim();
                    pessoa.IeRg = txtRgIe.Text.Trim();

                    pessoa.Endereco = new Endereco();
                    pessoa.Endereco.Logradouro = txtLogradouro.Text.Trim();
                    pessoa.Endereco.Numero = txtNumero.Text.Trim();
                    pessoa.Endereco.Cidade = txtCidade.Text.Trim();
                    pessoa.Endereco.Bairro = txtBairro.Text.Trim();
                    pessoa.Endereco.Complemento = txtComplemento.Text.Trim();
                    pessoa.Endereco.Cep = txtCep.Text.Trim();
                    pessoa.Endereco.Uf = txtUf.Text.Trim();

                    pessoa.Condominio = new Condominio();
                    pessoa.Condominio.NomeFantasia = txtNomeFantasia.Text.Trim();

                    pessoaRegraNegocios = new PessoaRegraNegocios();

                    idRet = pessoaRegraNegocios.SalvarCondominio(pessoa);

                    if (idRet > 0)
                    {
                        MessageBox.Show("Cadastro de Condominio foi Realizado com Sucesso", "Informação", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        LimparCampos();
                        this.OnLoad(e);
                    }
                    else
                    {
                        MessageBox.Show("Erro ao Salvar um Novo Condominio.", "Erro", MessageBoxButtons.OK, MessageBoxIcon.Error);

                        txtNomeRazao.Focus();
                        txtNomeRazao.SelectAll();
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        public void LimparCampos()
        {
            txtCodigoCondomino.Text = "0";
            txtNomeRazao.Text = "";
            txtNomeFantasia.Text = "";
            txtCpfCnpj.Text = "";
            txtRgIe.Text = "";
            txtLogradouro.Text = "";
            txtNumero.Text = "";
            txtCidade.Text = "";
            txtBairro.Text = "";
            txtCep.Text = "";
            txtUf.Text = "";
            txtComplemento.Text = "";
            txtTelefone.Text = "";

            txtNomeRazao.Focus();
            txtNomeRazao.SelectAll();
        }

        public bool PesquisarCampos()
        {
            try
            {
                if (txtNomeRazao.Text.Trim().Equals(""))
                {
                    MessageBox.Show("Campo Razão Social não Pode ser Nulo ou Vázio.", "Atenção", MessageBoxButtons.OK, MessageBoxIcon.Stop);

                    txtNomeRazao.Focus();
                    txtNomeRazao.SelectAll();
                    retorno = false;
                }
                else if (txtNomeFantasia.Text.Trim().Equals(""))
                {
                    MessageBox.Show("Campo *Nome Fanatsia não Pode ser Nulo ou Vázio.", "Atenção", MessageBoxButtons.OK, MessageBoxIcon.Stop);

                    txtNomeFantasia.Focus();
                    txtNomeFantasia.SelectAll();
                    retorno = false;
                }
                else if (txtCpfCnpj.Text.Trim().Equals(""))
                {
                    MessageBox.Show("Campo *CNPJ não Pode ser Nulo ou Vázio.", "Atenção", MessageBoxButtons.OK, MessageBoxIcon.Stop);

                    txtCpfCnpj.Focus();
                    txtCpfCnpj.SelectAll();
                    retorno = false;
                }
                else if (txtRgIe.Text.Trim().Equals(""))
                {
                    MessageBox.Show("Campo *I.E não Pode ser Nulo ou Vázio.", "Atenção", MessageBoxButtons.OK, MessageBoxIcon.Stop);

                    txtRgIe.Focus();
                    txtRgIe.SelectAll();
                    retorno = false;
                }
                else if (txtLogradouro.Text.Trim().Equals(""))
                {
                    MessageBox.Show("Campo *Logradouro não Pode ser Nulo ou Vázio.", "Atenção", MessageBoxButtons.OK, MessageBoxIcon.Stop);

                    txtLogradouro.Focus();
                    txtLogradouro.SelectAll();
                    retorno = false;
                }
                else if (txtNumero.Text.Trim().Equals(""))
                {
                    MessageBox.Show("Campo *Numero não Pode ser Nulo ou Vázio.", "Atenção", MessageBoxButtons.OK, MessageBoxIcon.Stop);

                    txtNumero.Focus();
                    txtNumero.SelectAll();
                    retorno = false;
                }
                else if (txtCidade.Text.Trim().Equals(""))
                {
                    MessageBox.Show("Campo *Cidade não Pode ser Nulo ou Vázio.", "Atenção", MessageBoxButtons.OK, MessageBoxIcon.Stop);

                    txtCidade.Focus();
                    txtCidade.SelectAll();
                    retorno = false;
                }
                else if (txtBairro.Text.Trim().Equals(""))
                {
                    MessageBox.Show("Campo *Bairro não Pode ser Nulo ou Vázio.", "Atenção", MessageBoxButtons.OK, MessageBoxIcon.Stop);

                    txtBairro.Focus();
                    txtBairro.SelectAll();
                    retorno = false;
                }
                else if (txtCep.Text.Trim().Equals(""))
                {
                    MessageBox.Show("Campo *Cep não Pode ser Nulo ou Vázio.", "Atenção", MessageBoxButtons.OK, MessageBoxIcon.Stop);

                    txtCep.Focus();
                    txtCep.SelectAll();
                    retorno = false;
                }
                else if (txtUf.Text.Trim().Equals(""))
                {
                    MessageBox.Show("Campo *U.F não Pode ser Nulo ou Vázio.", "Atenção", MessageBoxButtons.OK, MessageBoxIcon.Stop);

                    txtUf.Focus();
                    txtUf.SelectAll();
                    retorno = false;
                }
                else
                {
                    retorno = true;
                }

                return retorno;
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);

                return retorno;
            }
        }
    }
}
