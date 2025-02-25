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
    public partial class CadastrarAparelho : System.Web.UI.Page
    {
        List<Fabricante> fabricantes;
        protected Aparelho aparelho;
        protected void Page_Load(object sender, EventArgs e)
        {
            fabricantes = Servico.todosFabricantes();
            foreach (Fabricante f in fabricantes)
                cmbFabricantes.Items.Add(f.Nome);
        }
        protected void btnComprar_Click(object sender, EventArgs e)
        {
            Aparelho novo = new Aparelho();
            novo.Modelo = txtModelo.Text;
            novo.Largura = Convert.ToDecimal(txtLargura.Text);
            novo.Altura = Convert.ToDecimal(txtAltura.Text);
            novo.Espessura = Convert.ToDecimal(txtEspessura.Text);
            novo.Peso = Convert.ToInt16(txtPeso.Text);
            novo.Quantidade = Convert.ToInt16(txtQuantidade.Text);
            novo.Preco = Convert.ToDecimal(txtPreco.Text);
            novo.Desconto = Convert.ToDecimal(txtDesconto.Text);
            novo.Fabricante = fabricantes[cmbFabricantes.SelectedIndex];
            Servico.salvar(novo);
            Response.Redirect("default.aspx");
        }
        protected void Page_Unload(object sender, EventArgs e)
        {

        }
    }
}