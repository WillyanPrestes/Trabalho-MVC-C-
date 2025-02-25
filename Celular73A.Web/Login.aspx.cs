using Celular73A.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace Celular73A.Web
{
    public partial class Login : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {

        }
        protected void btnComprar_Click(object sender, EventArgs e)
        {
            int id = Servico.fazLogin(txtNome.Text, txtSenha.Text);
            if (id > 0)
            {
                //chave_login
            }
        }
    }
}