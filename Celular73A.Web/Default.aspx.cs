using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using Celular73A.Model.Entidades;
using Celular73A.Model;

namespace Celular73A.Web
{
    public partial class _Default : Page
    {
        protected List<Aparelho> lstAparelho;

        protected void Page_Load(object sender, EventArgs e)
        {
            lstAparelho = Servico.buscarAparelhos();

        }
    }
}