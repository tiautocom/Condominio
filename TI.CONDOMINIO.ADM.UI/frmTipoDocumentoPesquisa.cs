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
    public partial class frmTipoDocumentoPesquisa : Form
    {
        public frmTipoDocumentoPesquisa(int _tipo)
        {
            InitializeComponent();

            this.tipo = _tipo;
        }

        public int tipo = 0;
        public string documeto = "";
        public string retorno = "";

        private void frmTipoDocumentoPesquisa_Load(object sender, EventArgs e)
        {
            if (tipo == 1)
            {
                txtDocs.Mask = "###,###,###-##";
            }
        }

        private void txtDocs_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                btnSalvar_Click(sender, e);
            }
        }

        private void btnSalvar_Click(object sender, EventArgs e)
        {
            TipoDocumento();
        }

        public string TipoDocumento()
        {
            try
            {
                if (documeto.Trim().Equals(""))
                {
                    documeto = txtDocs.Text.Trim();
                    retorno = "";
                }
                else
                {
                    documeto = txtDocs.Text.Trim();
                    retorno = documeto;
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
