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
    public partial class frmPrincipal : Form
    {
        public frmPrincipal()
        {
            InitializeComponent();
        }

        private void btnCadCondominos_Click(object sender, EventArgs e)
        {
            frmCadCondomino frmCadCondomino = new frmCadCondomino();
            frmCadCondomino.ShowDialog();
        }

        private void btnCadGruoi_Click(object sender, EventArgs e)
        {
            frmCadGrupo frmCadGrupo = new frmCadGrupo();
            frmCadGrupo.ShowDialog();
        }

        private void btnCadCondominio_Click(object sender, EventArgs e)
        {
            frmCadCondominio frmCadCondominio = new frmCadCondominio();
            frmCadCondominio.ShowDialog();
        }

        private void btnCadApartamento_Click(object sender, EventArgs e)
        {
            frmCadApartamento frmCadApartamento = new frmCadApartamento();
            frmCadApartamento.ShowDialog();
        }

        private void btnControleAcesso_Click(object sender, EventArgs e)
        {
            frmControleAcesso frmControleAcesso = new frmControleAcesso();
            frmControleAcesso.ShowDialog();
        }

        private void btnCadastroEmpresa_Click(object sender, EventArgs e)
        {
            frmCadastroEmpresa frmCadastroEmpresa = new frmCadastroEmpresa();
            frmCadastroEmpresa.ShowDialog();
        }

        private void button15_Click(object sender, EventArgs e)
        {
            frmControleMudancas frmControleMudancas = new frmControleMudancas();
            frmControleMudancas.ShowDialog();
        }
    }
}
