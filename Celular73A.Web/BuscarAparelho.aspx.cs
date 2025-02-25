using Celular73A.Model;
using Celular73A.Model.Entidades;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace Celular73A.Web
{
    public partial class BuscarAparelho : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {

        }
        protected void btnComprar_Click(object sender, EventArgs e)
        {
            Aparelho Apa=Servico.buscaAparelhos(txtPesquisa.Text);
            txtFabricanteNome.Text = Apa.Fabricante.Nome;
           
            txtModelo.Text = Apa.Modelo;
            txtPreco.Text = Apa.Preco.ToString();
            txtQuantidade.Text = Apa.Quantidade.ToString();
            
        }
    }
}