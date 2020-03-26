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

namespace TI.CONDOMINIO.ADM.UI
{
    public partial class frmListaMoradorNumApto : Form
    {
        public frmListaMoradorNumApto(int nApto)
        {
            InitializeComponent();

            this.numApto = nApto;
            this.dgvMordor.AutoGenerateColumns = false;
        }

        public int numApto = 0;

        DataTable dadosTabela;
        MoradorRegraNegocios moradorRegraNegocios;

        private void frmListaMoradorNumApto_Load(object sender, EventArgs e)
        {
            ListarNumMorador();
        }

        public void ListarNumMorador()
        {
            try
            {
                dadosTabela = new DataTable();
                moradorRegraNegocios = new MoradorRegraNegocios();

                dadosTabela = moradorRegraNegocios.ListarNumMorador(numApto);

                if (dadosTabela.Rows.Count > 0)
                {
                    dgvMordor.DataSource = null;
                    dgvMordor.DataSource = dadosTabela;
                }
                else
                {
                    dgvMordor.DataSource = null;

                    MessageBox.Show("Nenhum Morador Foi encontrado com  Numero do Apartamento Selecionado.", "Atenção", MessageBoxButtons.OK, MessageBoxIcon.Asterisk);
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }
    }
}
