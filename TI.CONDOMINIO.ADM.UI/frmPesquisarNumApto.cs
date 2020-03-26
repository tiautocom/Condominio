using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace TI.CONDOMINIO.ADM.UI
{
    public partial class frmPesquisarNumApto : Form
    {
        public frmPesquisarNumApto()
        {
            InitializeComponent();
        }

        private void frmPesquisarNumApto_Load(object sender, EventArgs e)
        {

        }

        private void txtxNumApto_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                btnPesquisar_Click(sender, e);
            }
        }

        private void btnPesquisar_Click(object sender, EventArgs e)
        {
            if (txtxNumApto.Text.Trim().Equals(""))
            {
                MessageBox.Show("Campo Numero do Apartamento não Pode ser Nulo ou Vázio.", "Atenção", MessageBoxButtons.OK, MessageBoxIcon.Stop);

                txtxNumApto.Focus();
                txtxNumApto.SelectAll();
            }
            else
            {
                frmListaMoradorNumApto frmListaMoradorNumApto = new frmListaMoradorNumApto(Convert.ToInt32(txtxNumApto.Text));
                frmListaMoradorNumApto.ShowDialog();
            }
        }
    }
}
