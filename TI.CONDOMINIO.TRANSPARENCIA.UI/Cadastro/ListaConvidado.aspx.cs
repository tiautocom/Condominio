using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace TI.CONDOMINIO.TRANSPARENCIA.UI.Cadastro
{
    public partial class ListaConvidado : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            ListarMoradores();
        }

        public int capcidade = 0;

        public void ListarMoradores()
        {
            try
            {
                for (int i = 0; i < 40; i++)
                {
                    gdvMorador.Rows[i].Cells[0].Text = (1 + 1).ToString();
                }
            }
            catch (Exception ex)
            {

                throw;
            }
        }
    }
}