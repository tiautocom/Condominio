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
using TI.OBJETO.TRANSFERENCIA;

namespace TI.CONDOMINIO.ADM.UI
{
    public partial class frmCadCondomino : Form
    {
        public frmCadCondomino()
        {
            InitializeComponent();
        }

        #region CLASSES E OBJETOS

        ApartamentoRegraNegocios apartamentoRegraNegocios;
        DataTable dadosTabela;
        ValidarRegraNegocios validar;

        #endregion

        #region VARIAVEIS

        public int idCondominio, idEndereco = 0;
        public bool valCpf, valEmail;
        public bool liberarAbaDadosApto, liberarAbaDadosAdiCondomino = false;

        #endregion

        private void frmCadCondomino_Load(object sender, EventArgs e)
        {
            ListarApartamentos();
        }

        public void ListarApartamentos()
        {
            try
            {
                apartamentoRegraNegocios = new ApartamentoRegraNegocios();
                dadosTabela = new DataTable();

                dadosTabela = apartamentoRegraNegocios.ListarApartamentoAll();

                if (dadosTabela.Rows.Count > 0)
                {
                    this.cbCondominio.DataSource = null;
                    this.cbCondominio.DataSource = dadosTabela;
                    this.cbCondominio.DisplayMember = "NomeFantasia";
                    this.cbCondominio.ValueMember = "IdPessoa";
                }
                else
                {
                    cbCondominio.DataSource = null;
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void btnPesquisaCond_Click(object sender, EventArgs e)
        {
            Pesquisas();
        }

        public void Pesquisas()
        {
            idCondominio = Convert.ToInt32(cbCondominio.SelectedValue);

            PesquisarBloco();
            PesquisarAndar();
            PesquisarTorre();
            PesquisarApto();
            PesquisarEnderecoApto();
        }

        public void PesquisarBloco()
        {
            try
            {
                apartamentoRegraNegocios = new ApartamentoRegraNegocios();
                dadosTabela = new DataTable();

                dadosTabela = apartamentoRegraNegocios.ListarPesquisarBloco(idCondominio);

                if (dadosTabela.Rows.Count > 0)
                {
                    this.cbBloco.DataSource = null;
                    this.cbBloco.DataSource = dadosTabela;
                    this.cbBloco.DisplayMember = "NumBloco";
                }
                else
                {
                    this.cbBloco.DataSource = null;
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        public void PesquisarAndar()
        {
            try
            {
                apartamentoRegraNegocios = new ApartamentoRegraNegocios();
                dadosTabela = new DataTable();

                dadosTabela = apartamentoRegraNegocios.ListarPesquisarAndar(idCondominio);

                if (dadosTabela.Rows.Count > 0)
                {
                    this.cbAndar.DataSource = null;
                    this.cbAndar.DataSource = dadosTabela;
                    this.cbAndar.DisplayMember = "NumAndar";
                }
                else
                {
                    this.cbAndar.DataSource = null;
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        public void PesquisarTorre()
        {
            try
            {
                apartamentoRegraNegocios = new ApartamentoRegraNegocios();
                dadosTabela = new DataTable();

                dadosTabela = apartamentoRegraNegocios.ListarPesquisarTorre(idCondominio);

                if (dadosTabela.Rows.Count > 0)
                {
                    this.cbTorre.DataSource = null;
                    this.cbTorre.DataSource = dadosTabela;
                    this.cbTorre.DisplayMember = "NumTorre";
                }
                else
                {
                    this.cbTorre.DataSource = null;
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        public void PesquisarApto()
        {
            try
            {
                apartamentoRegraNegocios = new ApartamentoRegraNegocios();
                dadosTabela = new DataTable();

                dadosTabela = apartamentoRegraNegocios.ListarPesquisarApto(idCondominio);

                if (dadosTabela.Rows.Count > 0)
                {
                    this.cbApto.DataSource = null;
                    this.cbApto.DataSource = dadosTabela;
                    this.cbApto.DisplayMember = "NumApto";
                }
                else
                {
                    this.cbTorre.DataSource = null;
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        public void PesquisarEnderecoApto()
        {
            try
            {
                apartamentoRegraNegocios = new ApartamentoRegraNegocios();
                dadosTabela = new DataTable();

                dadosTabela = apartamentoRegraNegocios.PesquisarEnderecoApto(idCondominio);

                if (dadosTabela.Rows.Count > 0)
                {
                    txtLogradouro.Text = dadosTabela.Rows[0]["Logradouro"].ToString().Trim();
                    txtNumero.Text = dadosTabela.Rows[0]["Numero"].ToString().Trim();
                    txtCidade.Text = dadosTabela.Rows[0]["Cidade"].ToString().Trim();
                    txtBairro.Text = dadosTabela.Rows[0]["Bairro"].ToString().Trim();
                    txtCep.Text = dadosTabela.Rows[0]["Cep"].ToString().Trim();
                    txtUf.Text = dadosTabela.Rows[0]["Uf"].ToString().Trim();
                }
                else
                {
                    this.cbTorre.DataSource = null;
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void txtNomeCondomino_TextChanged(object sender, EventArgs e)
        {
            txtTitularDepedente.Text = txtNomeCondomino.Text.Trim();
        }

        private void comboBox1_Leave(object sender, EventArgs e)
        {
            txtQtdeGaragem.Text = cbGaragem.Text.Trim().PadLeft(2, '0');
        }

        private void cbLocalGaragem_Leave(object sender, EventArgs e)
        {
            txtLocalGaragem.Text = cbLocalGaragem.Text.Trim();
        }

        private void tabControl1_Selecting(object sender, TabControlCancelEventArgs e)
        {
            if (e.TabPage == TPDadosAdiconaisCond)
            {
                if (TratarCamposDadosApartamento() == false)
                {
                    this.tabControl1.SelectedTab = TPApartamento;
                }
                else
                {
                    liberarAbaDadosApto = true;
                }
            }

            if (e.TabPage == TPDadosApartamento && liberarAbaDadosApto == true)
            {
                if (TratarCamposDadosCondomino() == false)
                {
                    this.tabControl1.SelectedTab = TPDadosAdiconaisCond;
                }
                else
                {
                    liberarAbaDadosAdiCondomino = true;
                }
            }

            if (e.TabPage == TPTitularDepedente && liberarAbaDadosAdiCondomino == true)
            {
                if (TratarCamposDadosAdicionaisApto() == true && liberarAbaDadosAdiCondomino == true)
                {

                }
            }
        }
        //--------------------------------------------------------------------------------------------------------------

        public bool ValidarCpf()
        {
            try
            {
                if (txtCpfCondomino.Text.Trim().Replace("_", "") != "")
                {
                    validar = new ValidarRegraNegocios();

                    valCpf = validar.IsCpf(txtCpfCondomino.Text.Trim());

                    if (valCpf == false)
                    {
                        MessageBox.Show("Por Favor Informe CPF Válido.", "CPF: " + "[ " + txtCpfCondomino.Text.Trim() + " ]" + ", é Inválido", MessageBoxButtons.OK, MessageBoxIcon.Stop);

                        txtCpfCondomino.Focus();
                        txtCpfCondomino.SelectAll();
                    }
                }

                return valCpf;
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);

                return false;
            }
        }

        public bool ValidarEmail()
        {
            try
            {
                if (txtEmailCondomino.Text.Trim() != "")
                {
                    validar = new ValidarRegraNegocios();

                    valEmail = validar.ValidarEmail(txtEmailCondomino.Text.Trim());

                    if (valEmail == false)
                    {
                        MessageBox.Show("Por Favor Informe E-Mail Válido.", "E-Mail: " + "[ " + txtEmailCondomino.Text.Trim() + " ]" + ", é Inválido", MessageBoxButtons.OK, MessageBoxIcon.Stop);

                        txtEmailCondomino.Focus();
                        txtEmailCondomino.SelectAll();
                    }
                }

                return valEmail;
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);

                return false;
            }
        }

        private void txtCpfCondomino_Leave(object sender, EventArgs e)
        {
            ValidarCpf();
        }

        private void txtEmailCondomino_Leave(object sender, EventArgs e)
        {
            ValidarEmail();
        }

        public bool TratarCamposDadosApartamento()
        {
            try
            {
                if (idCondominio <= 0)
                {
                    MessageBox.Show("Selecione Tipo de Empreendimento Desejado.", "Atenção", MessageBoxButtons.OK, MessageBoxIcon.Stop);

                    return false;
                }
                else if (cbAndar.Text.Trim().Equals(""))
                {
                    MessageBox.Show("Campo Andar não pode ser Nulo ou Vázio.", "Atenção", MessageBoxButtons.OK, MessageBoxIcon.Stop);

                    cbAndar.Focus();
                    cbAndar.SelectAll();

                    return false;
                }
                else if (cbTorre.Text.Trim().Equals(""))
                {
                    MessageBox.Show("Campo Torre não pode ser Nulo ou Vázio.", "Atenção", MessageBoxButtons.OK, MessageBoxIcon.Stop);

                    cbTorre.Focus();
                    cbTorre.SelectAll();

                    return false;
                }

                else if (cbBloco.Text.Trim().Equals(""))
                {
                    MessageBox.Show("Campo Bloco não pode ser Nulo ou Vázio.", "Atenção", MessageBoxButtons.OK, MessageBoxIcon.Stop);

                    cbBloco.Focus();
                    cbBloco.SelectAll();

                    return false;
                }

                else if (cbApto.Text.Trim().Equals(""))
                {
                    MessageBox.Show("Campo Apartamento não pode ser Nulo ou Vázio.", "Atenção", MessageBoxButtons.OK, MessageBoxIcon.Stop);

                    cbApto.Focus();
                    cbApto.SelectAll();

                    return false;
                }

                else if (cbTipo.Text.Trim().Equals(""))
                {
                    MessageBox.Show("Campo Tipo de Morador não pode ser Nulo ou Vázio.", "Atenção", MessageBoxButtons.OK, MessageBoxIcon.Stop);

                    cbTipo.Focus();
                    cbTipo.SelectAll();

                    return false;
                }

                else if (cbGaragem.Text.Trim().Equals(""))
                {
                    MessageBox.Show("Campo Tipo de Morador não pode ser Nulo ou Vázio.", "Atenção", MessageBoxButtons.OK, MessageBoxIcon.Stop);

                    cbGaragem.Focus();
                    cbGaragem.SelectAll();

                    return false;
                }

                else if (cbLocalGaragem.Text.Trim().Equals(""))
                {
                    MessageBox.Show("Campo Local da Geragem não pode ser Nulo ou Vázio.", "Atenção", MessageBoxButtons.OK, MessageBoxIcon.Stop);

                    cbLocalGaragem.Focus();
                    cbLocalGaragem.SelectAll();

                    return false;
                }
                else
                {
                    return true;
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);

                return false;
            }
        }

        public bool TratarCamposDadosCondomino()
        {
            try
            {
                if (txtNomeCondomino.Text.Trim().Equals(""))
                {
                    MessageBox.Show("Campo Nome do Condomino Titular não pode ser Nulo ou Vázio.", "Atenção", MessageBoxButtons.OK, MessageBoxIcon.Stop);

                    txtNomeCondomino.Focus();
                    txtNomeCondomino.SelectAll();

                    return false;
                }
                else if (txtCpfCondomino.Text.Trim().Replace("_", "").Equals(""))
                {
                    MessageBox.Show("Campo CPF do Condomino Titular não pode ser Nulo ou Vázio.", "Atenção", MessageBoxButtons.OK, MessageBoxIcon.Stop);

                    txtCpfCondomino.Focus();
                    txtCpfCondomino.SelectAll();

                    return false;
                }

                else if (valCpf == false)
                {
                    MessageBox.Show("Campo Nome do Condomino Titular não pode ser Nulo ou Vázio.", "Atenção", MessageBoxButtons.OK, MessageBoxIcon.Stop);

                    txtCpfCondomino.Focus();
                    txtCpfCondomino.SelectAll();

                    return false;
                }

                else if (txtRgCondomino.Text.Trim().Replace("_", "").Equals(""))
                {
                    MessageBox.Show("Campo R.G do Condomino Titular não pode ser Nulo ou Vázio.", "Atenção", MessageBoxButtons.OK, MessageBoxIcon.Stop);

                    txtRgCondomino.Focus();
                    txtRgCondomino.SelectAll();

                    return false;
                }

                else if (txtTelCondomino.Text.Trim().Replace("_", "").Equals(""))
                {
                    MessageBox.Show("Campo Telefone do Condomino Titular não pode ser Nulo ou Vázio.", "Atenção", MessageBoxButtons.OK, MessageBoxIcon.Stop);

                    txtTelCondomino.Focus();
                    txtTelCondomino.SelectAll();

                    return false;
                }

                else if (txtCelularCondomino.Text.Trim().Replace("_", "").Equals(""))
                {
                    MessageBox.Show("Campo Celular do Condomino Titular não pode ser Nulo ou Vázio.", "Atenção", MessageBoxButtons.OK, MessageBoxIcon.Stop);

                    txtCelularCondomino.Focus();
                    txtCelularCondomino.SelectAll();

                    return false;
                }
                else
                {
                    return true;
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);

                return true;
            }
        }

        public bool TratarCamposDadosAdicionaisApto()
        {
            try
            {
                if (txtQtdeQuarto.Text.Trim().Equals("0"))
                {
                    MessageBox.Show("Campo Quantidade de Dormitorios do Apartamento não pode ser Nulo ou Zero.", "Atenção", MessageBoxButtons.OK, MessageBoxIcon.Stop);

                    txtQtdeQuarto.Focus();
                    txtQtdeQuarto.SelectAll();

                    return false;
                }
                else if (txtQtdeLavatorio.Text.Trim().Equals("0"))
                {
                    MessageBox.Show("Campo Quantidade de Lavatórios do Apartamento não pode ser Nulo ou Zero.", "Atenção", MessageBoxButtons.OK, MessageBoxIcon.Stop);

                    txtQtdeLavatorio.Focus();
                    txtQtdeLavatorio.SelectAll();

                    return false;
                }
                else if (txtValorCondominio.Text.Trim().Equals("0.00"))
                {
                    MessageBox.Show("Campo Quantidade de Dormitorios do Apartamento não pode ser Nulo ou Zero.", "Atenção", MessageBoxButtons.OK, MessageBoxIcon.Stop);

                    txtQtdeLavatorio.Focus();
                    txtQtdeLavatorio.SelectAll();

                    return false;
                }
                else
                {
                    return true;
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);

                return false;
            }
        }
    }
}
