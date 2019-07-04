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
    public partial class frmControleMudancas : Form
    {
        public frmControleMudancas()
        {
            InitializeComponent();

            this.dgvAgenda.AutoGenerateColumns = false;
        }

        DataTable dadosTabela;
        MudancaRegraNegocios mudancaRegraNegocios;

        public int tipoUsuario = 0;
        public string data, torre, bloco, apto, hInicio, hFim, descPeriodo = "";
        public string horaIni, horaFinal = "";
        public int idMudanca = 0;

        private void frmControleMudancas_Load(object sender, EventArgs e)
        {
            Listar();
        }

        public void Listar()
        {
            try
            {
                dadosTabela = new DataTable();
                mudancaRegraNegocios = new MudancaRegraNegocios();

                dadosTabela = mudancaRegraNegocios.ListarAll();

                if (dadosTabela.Rows.Count > 0)
                {
                    dgvAgenda.DataSource = dadosTabela;
                }
                else
                {
                    dgvAgenda.DataSource = null;
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void dgvAgenda_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            try
            {
                if (dgvAgenda.Columns[e.ColumnIndex].Name.Trim().Equals("colSel"))
                {
                    idMudanca = Convert.ToInt32(dgvAgenda.Rows[e.RowIndex].Cells["colIdMudanca"].Value.ToString());
                    data = Convert.ToDateTime(dgvAgenda.Rows[e.RowIndex].Cells["colData"].Value.ToString().Trim()).ToString("dd/MM/yyyy");
                    torre = dgvAgenda.Rows[e.RowIndex].Cells["colIdTorre"].Value.ToString().Trim().PadLeft(2, '0');
                    bloco = dgvAgenda.Rows[e.RowIndex].Cells["colBloco"].Value.ToString().Trim();
                    apto = dgvAgenda.Rows[e.RowIndex].Cells["colApto"].Value.ToString().Trim();
                    hInicio = dgvAgenda.Rows[e.RowIndex].Cells["colHoraInicio"].Value.ToString().Trim();
                    hFim = dgvAgenda.Rows[e.RowIndex].Cells["colHoraFim"].Value.ToString().Trim();
                    descPeriodo = dgvAgenda.Rows[e.RowIndex].Cells["colPeriodo"].Value.ToString().Trim();
                    horaIni = dgvAgenda.Rows[e.RowIndex].Cells["colInicioMudanca"].Value.ToString().Trim();
                    horaFinal = dgvAgenda.Rows[e.RowIndex].Cells["colFimMudanca"].Value.ToString().Trim();

                    frmMudancaControleDados frmMudancaControleDados = new frmMudancaControleDados(this, horaIni, horaFinal, idMudanca);
                    frmMudancaControleDados.ShowDialog();

                    this.OnLoad(e);
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }
    }
}
