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
    public partial class frmAlterarApartamento : Form
    {
        public frmAlterarApartamento(int _idApto, string _empresa, string _bloco, string _andar, string _apto)
        {
            InitializeComponent();

            idApartamento = _idApto;
            empresa = _empresa;
            bloco = _bloco;
            andar = _andar;
            apto = _apto;
        }

        public int idApartamento = 0;
        public string andar, bloco, apto, empresa = "";

        ApartamentoRegraNegocios apartamentoRegraNegocios;

        private void btnSelecionarAssinaturaDig_Click(object sender, EventArgs e)
        {
            AlterarDados();
        }

        public void AlterarDados()
        {
            try
            {
                if (MessageBox.Show("Realmente Deseja Alterar Dados do Apartmento Numero: " + txtApartamento.Text.Trim(), "Confirmação de Alteração", MessageBoxButtons.YesNo, MessageBoxIcon.Question, MessageBoxDefaultButton.Button2) == DialogResult.Yes)
                {
                    apartamentoRegraNegocios = new ApartamentoRegraNegocios();

                    int idRet = apartamentoRegraNegocios.AlterarApartamento(txtAndar.Text.Trim(), txtBloco.Text.Trim(), txtApartamento.Text.Trim(), idApartamento);

                    if (idRet > 0)
                    {
                        MessageBox.Show("Apartamento Alterado com Sucesso.", "Informação", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    }
                    else
                    {
                        MessageBox.Show("Erro ao Alterar Dados do Apartamento Numero: " + apto + ".", "Erro", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void frmAlterarApartamento_Load(object sender, EventArgs e)
        {
            ListarCampos();
        }

        public void ListarCampos()
        {
            txtEmpresa.Text = empresa.Trim();
            txtAndar.Text = andar.Trim();
            txtApartamento.Text = apto.Trim();
            txtBloco.Text = bloco.Trim();
        }
    }
}
