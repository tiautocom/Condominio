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
    public partial class frmHoraMudanca : Form
    {
        public frmHoraMudanca(string hIn, string hFim, int IdMundanca)
        {
            InitializeComponent();

            this.hInicio = hIn;
            this.hFim = hFim;
            this.idMudanca = IdMundanca;
        }

        DataTable dadosTabela;

        public string status = "";
        public string hInicio, hFim = "";
        public int idMudanca = 0;

        MudancaRegraNegocios mudancaRegraNegocios;

        private void btnSalvar_Click(object sender, EventArgs e)
        {
            if (hInicio.Trim().Equals("00:00"))
            {
                if (MessageBox.Show("Realmente Deseja Inicializar Hora Entrada de Mudança?", "Entrada de Mudança", MessageBoxButtons.YesNo, MessageBoxIcon.Question, MessageBoxDefaultButton.Button2) == DialogResult.Yes)
                {
                    Iniciar();
                }
            }
            else if (txtHoraIni.Text.Trim() != "00:00")
            {
                if (MessageBox.Show("Realmente Deseja Finalizar Hora de Mudança?", "Entrada de Mudança", MessageBoxButtons.YesNo, MessageBoxIcon.Question, MessageBoxDefaultButton.Button2) == DialogResult.Yes)
                {
                    Fechar();
                }
            }
        }

        public void Iniciar()
        {
            try
            {
                mudancaRegraNegocios = new MudancaRegraNegocios();

                int idRet = mudancaRegraNegocios.IniciarMudanca(idMudanca, Convert.ToDateTime(txtHoraIni.Text).ToString("hh:mm"));

                if (idRet > 0)
                {
                    MessageBox.Show("Hora do Inicio da Mudança foi Inicializado com Sucesso.", "Informação", MessageBoxButtons.OK, MessageBoxIcon.Information);

                    this.Close();
                }
                else
                {
                    MessageBox.Show("Erro ao Iniciar Hora da Mudança.\nCaso Problema Persistir Entre em Contato com seu Administrador.", "Erro", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        public void Fechar()
        {
            try
            {
                mudancaRegraNegocios = new MudancaRegraNegocios();

                int idRet = mudancaRegraNegocios.FecharMudanca(idMudanca, DateTime.Now.ToString("hh:mm"));

                if (idRet > 0)
                {
                    MessageBox.Show("Mudança foi Finalizado com Sucesso.", "Informação", MessageBoxButtons.OK, MessageBoxIcon.Information);

                    this.Close();
                }
                else
                {
                    MessageBox.Show("Erro ao Iniciar Hora da Mudança.\nCaso Problema Persistir Entre em Contato com seu Administrador.", "Erro", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        public void PesquisaHoras()
        {
            try
            {
                dadosTabela = new DataTable();

                mudancaRegraNegocios = new MudancaRegraNegocios();

                dadosTabela = mudancaRegraNegocios.PesquisarDataMudancaId(idMudanca);

                if (dadosTabela.Rows.Count > 0)
                {
                    txtHoraIni.Text = hInicio = dadosTabela.Rows[0]["HoraInicio"].ToString().Trim();
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void frmHoraMudanca_Load(object sender, EventArgs e)
        {
            PesquisaHoras();

            if (hInicio.Trim().Equals("00:00"))
            {
                status = "INICIAR";

                txtHoraIni.Text = DateTime.Now.ToString("hh:mm");
            }
            else
            {
                status = "FECHAR";
            }

            btnSalvar.Text = status;
        }
    }
}
