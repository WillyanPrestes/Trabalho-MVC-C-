using Celular73A.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace Celular73A.Web
{
    public partial class CadastroCliente : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {

        }
        protected void btnComprar_Click(object sender, EventArgs e)
        {
            Cliente cli = new Cliente();
            cli.nome = txtNome.Text;
            cli.email = txtEmail.Text;
            cli.senha = txtSenha.Text;
            Servico.salvar(cli);
            Response.Redirect("default.aspx");
        }
        protected void Page_Unload(object sender, EventArgs e)
        {

        }
    }
}