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
    public partial class Detalhes : System.Web.UI.Page
    {
        protected Aparelho aparelho;
        List<Cliente> clientes;
        protected void Page_Load(object sender, EventArgs e)
        {
            Int64 id_aparelho = Convert.ToInt64(Request.QueryString["aparelho"]);
            aparelho = Servico.buscarAparelhos(id_aparelho);
            


            clientes = Servico.todosClientes();
            foreach (Cliente f in clientes)
                cmbClientes.Items.Add(f.nome);
        }

        protected void btnComprar_Click(object sender, EventArgs e)
        {
            Servico.fazerPedido(aparelho,clientes[cmbClientes.SelectedIndex].nome);
            Response.Redirect("default.aspx");
        }
    }
}