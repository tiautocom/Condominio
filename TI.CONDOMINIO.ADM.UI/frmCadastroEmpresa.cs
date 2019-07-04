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
    public partial class frmCadastroEmpresa : Form
    {
        public frmCadastroEmpresa()
        {
            InitializeComponent();
        }

        #region CLASSES E OBJETOS

        Pessoa pessoa;
        PessoaRegraNegocios pessoaRegraNegocios;
        BuscarCepRegraNegocios buscarCepRegraNegocios;
        ValidarRegraNegocios validar;

        #endregion

        #region VARIAVEIS

        public string xml = "";
        public bool valCnpj;
        public string senha = "";

        #endregion

        private void frmCadastroEmpresa_Load(object sender, EventArgs e)
        {

        }

        private void btnNovo_Click(object sender, EventArgs e)
        {
            LimpaCampos();
        }

        public void LimpaCampos()
        {
            try
            {
                //PESSOA
                txtId.Text = "0";
                txtNomeRazao.Text = "";
                txtNomeFantasia.Text = "";
                txtCpfCnpj.Text = "";
                txtRgIe.Text = "";

                //END
                txtLogradouro.Text = "";
                txtCidade.Text = "";
                txtBairro.Text = "";
                txtCep.Text = "";
                txtUf.Text = "";
                txtComplemento.Text = "";
                txtNumero.Text = "";

                //CARACERISTICA
                cbTipoCaracteristica.Text = "";
                txtEmail.Text = "";
                txtTelefone.Text = "";

                txtNomeRazao.Focus();
                txtNomeRazao.SelectAll();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        public bool TratamentoCampos()
        {
            try
            {
                if (txtNomeRazao.Text.Trim().Equals(""))
                {
                    MessageBox.Show("Campo Razão Social não Pode ser Nulo ou Vázio.", "Atenção", MessageBoxButtons.OK, MessageBoxIcon.Stop);
                    txtNomeRazao.Focus();
                    txtNomeRazao.SelectAll();

                    return false;
                }
                else if (txtNomeFantasia.Text.Trim().Equals(""))
                {
                    MessageBox.Show("Campo Nome Fantasia não Pode ser Nulo ou Vázio.", "Atenção", MessageBoxButtons.OK, MessageBoxIcon.Stop);
                    txtNomeFantasia.Focus();
                    txtNomeFantasia.SelectAll();

                    return false;
                }
                else if (txtCpfCnpj.Text.Trim().Equals(""))
                {
                    MessageBox.Show("Campo CNPJ não Pode ser Nulo ou Vázio.", "Atenção", MessageBoxButtons.OK, MessageBoxIcon.Stop);
                    txtCpfCnpj.Focus();
                    txtCpfCnpj.SelectAll();

                    return false;
                }
                else if (txtRgIe.Text.Trim().Equals(""))
                {
                    MessageBox.Show("Campo I.E (Inscição Estadual) não Pode ser Nulo ou Vázio.", "Atenção", MessageBoxButtons.OK, MessageBoxIcon.Stop);
                    txtRgIe.Focus();
                    txtRgIe.SelectAll();

                    return false;
                }
                else if (txtLogradouro.Text.Trim().Equals(""))
                {
                    MessageBox.Show("Campo Logradouro não Pode ser Nulo ou Vázio.", "Atenção", MessageBoxButtons.OK, MessageBoxIcon.Stop);
                    txtLogradouro.Focus();
                    txtLogradouro.SelectAll();

                    return false;
                }
                else if (txtNumero.Text.Trim().Equals(""))
                {
                    MessageBox.Show("Campo Numero não Pode ser Nulo ou Vázio.", "Atenção", MessageBoxButtons.OK, MessageBoxIcon.Stop);
                    txtNumero.Focus();
                    txtNumero.SelectAll();

                    return false;
                }
                else if (txtCidade.Text.Trim().Equals(""))
                {
                    MessageBox.Show("Campo Cidade não Pode ser Nulo ou Vázio.", "Atenção", MessageBoxButtons.OK, MessageBoxIcon.Stop);
                    txtCidade.Focus();
                    txtCidade.SelectAll();

                    return false;
                }
                else if (txtBairro.Text.Trim().Equals(""))
                {
                    MessageBox.Show("Campo Bairro não Pode ser Nulo ou Vázio.", "Atenção", MessageBoxButtons.OK, MessageBoxIcon.Stop);
                    txtBairro.Focus();
                    txtBairro.SelectAll();

                    return false;
                }
                else if (txtCep.Text.Trim().Equals(""))
                {
                    MessageBox.Show("Campo CEP não Pode ser Nulo ou Vázio.", "Atenção", MessageBoxButtons.OK, MessageBoxIcon.Stop);
                    txtCep.Focus();
                    txtCep.SelectAll();

                    return false;
                }
                else if (txtUf.Text.Trim().Equals(""))
                {
                    MessageBox.Show("Campo U.F não Pode ser Nulo ou Vázio.", "Atenção", MessageBoxButtons.OK, MessageBoxIcon.Stop);
                    txtUf.Focus();
                    txtUf.SelectAll();

                    return false;
                }
                else if (txtEmail.Text.Trim().Equals(""))
                {
                    MessageBox.Show("Campo E-Mail não Pode ser Nulo ou Vázio.", "Atenção", MessageBoxButtons.OK, MessageBoxIcon.Stop);
                    txtEmail.Focus();
                    txtEmail.SelectAll();

                    return false;
                }
                else if (txtTelefone.Text.Trim().Equals(""))
                {
                    MessageBox.Show("Campo Telefone não Pode ser Nulo ou Vázio.", "Atenção", MessageBoxButtons.OK, MessageBoxIcon.Stop);
                    txtTelefone.Focus();
                    txtTelefone.SelectAll();

                    return false;
                }
                else if (cbTipoCaracteristica.Text.Trim().Equals(""))
                {
                    MessageBox.Show("Campo Tipo de Caracterisca da Empresa não Pode ser Nulo ou Vázio.", "Atenção", MessageBoxButtons.OK, MessageBoxIcon.Stop);
                    cbTipoCaracteristica.Focus();
                    cbTipoCaracteristica.SelectAll();

                    return false;
                }
                else
                {
                    Salvar();

                    return true;
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);

                return false;
            }
        }

        public void Salvar()
        {
            try
            {
                GerarSenhas();

                pessoa = new Pessoa();

                pessoa.NomeRazao = txtNomeRazao.Text.Trim();
                pessoa.CpfCnpj = txtCpfCnpj.Text.Trim();
                pessoa.IeRg = txtRgIe.Text.Trim();
                pessoa.DataCadastro = DateTime.Now.Date;

                pessoa.Empresa = new Empresa();
                pessoa.Empresa.Id = Convert.ToInt32(txtId.Text);
                pessoa.Empresa.NomeFantasia = txtNomeFantasia.Text.Trim();
                pessoa.Empresa.Caracterisca = cbTipoCaracteristica.Text.Trim();
                pessoa.Empresa.Email = txtEmail.Text.Trim().ToLower();
                pessoa.Empresa.CodigoSeguracanca = senha.Trim();

                pessoa.Endereco = new Endereco();
                pessoa.Endereco.Id = Convert.ToInt32(txtId.Text);
                pessoa.Endereco.Logradouro = txtLogradouro.Text.Trim();
                pessoa.Endereco.Numero = txtNumero.Text.Trim();
                pessoa.Endereco.Cidade = txtCidade.Text.Trim();
                pessoa.Endereco.Bairro = txtBairro.Text.Trim();
                pessoa.Endereco.Complemento = txtComplemento.Text.Trim();
                pessoa.Endereco.Cep = txtCep.Text.Trim();
                pessoa.Endereco.Uf = txtUf.Text.Trim();

                pessoa.Telefone = new Telefone();
                pessoa.Telefone.Id = Convert.ToInt32(txtId.Text);
                pessoa.Telefone.Tel = txtTelefone.Text.Trim();

                pessoaRegraNegocios = new PessoaRegraNegocios();

                int idRet = pessoaRegraNegocios.SalvarEmpresa(pessoa);

                if (idRet > 0)
                {
                    MessageBox.Show("Empresa, " + txtNomeRazao.Text.Trim() + " foi Realizado com Sucesso.", "Informação", MessageBoxButtons.OK, MessageBoxIcon.Information);

                    LimpaCampos();
                }
                else
                {
                    MessageBox.Show("Erro ao Salvar Empresa, " + txtNomeRazao.Text.Trim(), "Erro", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void btnSalvar_Click(object sender, EventArgs e)
        {
            if (ValidarCnpj() == true)
            {
                TratamentoCampos();
            }
            else
            {
                MessageBox.Show("Informe um CNPJ Válido.", "CNPJ É Inválido", MessageBoxButtons.OK, MessageBoxIcon.Stop);

                txtCpfCnpj.Focus();
                txtCpfCnpj.SelectAll();
            }
        }

        public string GerarSenhas()
        {
            int Tamanho = 10; // Numero de digitos da senha
            senha = string.Empty;

            for (int i = 0; i < Tamanho; i++)
            {
                Random random = new Random();
                int codigo = Convert.ToInt32(random.Next(48, 122).ToString());

                if ((codigo >= 48 && codigo <= 57) || (codigo >= 97 && codigo <= 122))
                {
                    string _char = ((char)codigo).ToString();

                    if (!senha.Contains(_char))
                    {
                        senha += _char;
                    }
                    else
                    {
                        i--;
                    }
                }
                else
                {
                    i--;
                }
            }

            return senha;
        }


        public bool ValidarCnpj()
        {
            try
            {
                validar = new ValidarRegraNegocios();

                valCnpj = validar.IsCnpj(txtCpfCnpj.Text.Trim());

                return valCnpj;
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
                return valCnpj;
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (txtCep.Text.Trim().Equals(""))
            {
                MessageBox.Show("Para Pesquisar CEP, Campo não pode ser Nulo ou Vázio.", "Atenção", MessageBoxButtons.OK, MessageBoxIcon.Stop);

                txtCep.Focus();
                txtCep.SelectAll();
            }
            else
            {
                BuscarCep();
            }
        }

        public void BuscarCep()
        {
            try
            {
                buscarCepRegraNegocios = new BuscarCepRegraNegocios();

                string xml = buscarCepRegraNegocios.BuscaCEP(txtCep.Text.Trim());

                DataSet ds = new DataSet();
                ds.ReadXml(xml);
                DataTable dataTabela = new DataTable();
                dataTabela = ds.Tables[0];

                int resultado = Convert.ToInt32(dataTabela.Rows[0][0].ToString().Trim());

                if (resultado > 0)
                {
                    txtLogradouro.Text = dataTabela.Rows[0][5].ToString().Trim() + ", " + dataTabela.Rows[0][6].ToString().Trim();
                    txtBairro.Text = dataTabela.Rows[0][4].ToString().Trim();
                    txtCidade.Text = dataTabela.Rows[0][3].ToString().Trim().ToUpper();
                    txtUf.Text = dataTabela.Rows[0][2].ToString().Trim().ToUpper();

                    txtNumero.Focus();
                    txtNumero.SelectAll();
                }
                else
                {
                    MessageBox.Show("CEP:" + txtCep.Text.Trim() + " não foi Localizado.", "Atenção", MessageBoxButtons.OK, MessageBoxIcon.Stop);

                    txtCep.Focus();
                    txtCep.SelectAll();
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }
    }
}
