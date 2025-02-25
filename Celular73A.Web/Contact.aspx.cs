using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace Celular73A.Web
{
    public partial class Contact : Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            //TextBox1.Text= "cti";
           
        }

        protected void btnOk_Click(object sender, EventArgs e)
        {
            TextBox1.Text += " :( ";
        }
    }
}