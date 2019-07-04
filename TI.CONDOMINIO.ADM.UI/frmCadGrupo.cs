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
    public partial class frmCadGrupo : Form
    {
        public frmCadGrupo()
        {
            InitializeComponent();

            dgvGrupo.AutoGenerateColumns = false;
        }

        #region CLASSES E OBJETOS

        GrupoRegraNegocios grupoRegraNegocios;
        EmpresaRegraNegocios empresaRegraNrgocios;
        Grupos grupo;
        DataTable dadosTabela = new DataTable();

        #endregion

        #region VARIAVEIS

        public int idEmpresa = 0;

        #endregion

        private void frmCadGrupo_Load(object sender, EventArgs e)
        {
            LoadTela();
        }

        public void LoadTela()
        {
            ListarEmpresa();
            ListarGrupo();
        }

        public void ListarGrupo()
        {
            try
            {
                if (idEmpresa > 0)
                {
                    grupoRegraNegocios = new GrupoRegraNegocios();
                    dadosTabela = new DataTable();

                    dadosTabela = grupoRegraNegocios.ListarGrupo(idEmpresa);

                    if (dadosTabela.Rows.Count > 0)
                    {
                        dgvGrupo.DataSource = null;
                        dgvGrupo.DataSource = dadosTabela;
                    }
                    else
                    {
                        dgvGrupo.DataSource = null;
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
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

        private void cbEmpresa_SelectedIndexChanged(object sender, EventArgs e)
        {
            try
            {
                var dataRowView = this.cbEmpresa.SelectedItem as DataRowView;
                var valor = dataRowView.Row.ItemArray[0];

                idEmpresa = Convert.ToInt32(valor);

                ListarGrupo();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        public void Salvar(EventArgs e)
        {
            try
            {
                grupo = new Grupos();
                grupoRegraNegocios = new GrupoRegraNegocios();

                grupo.Descricao = txtDescricao.Text.Trim();
                grupo.IdEmpresa = Convert.ToInt32(cbEmpresa.SelectedValue);

                int idRet = grupoRegraNegocios.Savar(grupo);

                if (idRet > 0)
                {
                    MessageBox.Show("Novo Grupo foi Cadastrado com Sucesso.", "Informação", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    this.OnLoad(e);
                }
                else
                {
                    MessageBox.Show("Erro ao Cadastrar Novo Grupo.", "Erro", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void btnSelecionarAssinaturaDig_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("Realmente Deseja Cadastrar Novo Grupo", "Conformação", MessageBoxButtons.YesNo, MessageBoxIcon.Question, MessageBoxDefaultButton.Button2) == DialogResult.Yes)
            {
                Salvar(e);
            }
        }

        private void btnNovo_Click(object sender, EventArgs e)
        {
            Limpar();
        }

        public void Limpar()
        {
            ListarEmpresa();
            txtDescricao.Text = "";
            txtDescricao.Focus();
        }
    }
}
