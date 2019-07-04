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
    public partial class frmControleAcesso : Form
    {
        public frmControleAcesso()
        {
            InitializeComponent();
        }

        public int tipo = 0;
        public string documento = "";

        private void cbDocumento_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (cbDocumento.Text.Trim() != "")
            {
                tipo = Convert.ToInt32(cbDocumento.Text.Trim().Substring(0, 1));

                frmTipoDocumentoPesquisa frmTipoDocumentoPesquisa = new frmTipoDocumentoPesquisa(tipo);
                frmTipoDocumentoPesquisa.ShowDialog();

                documento = frmTipoDocumentoPesquisa.retorno;
            }
        }
    }
}
