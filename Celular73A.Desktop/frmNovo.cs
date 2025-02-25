using Celular73A.Model;
using Celular73A.Model.Entidades;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Celular73A.Desktop
{
    public partial class frmNovo : Form
    {
        public frmNovo()
        {
            InitializeComponent();
        }
        private List<Fabricante> fabricantes;
        private Aparelho aparelho;
            
        private void frmNovo_Load(object sender, EventArgs e)
        {
            fabricantes = Servico.todosFabricantes();

            cmbFabricante.Items.Clear();
            foreach (Fabricante aparelho in fabricantes)
                cmbFabricante.Items.Add(aparelho.Nome);
        }

        private void btnSair_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnCriar_Click(object sender, EventArgs e)
        {
            aparelho = new Aparelho();
            aparelho.Fabricante = fabricantes[cmbFabricante.SelectedIndex];
            aparelho.Altura = nunAltura.Value;
            aparelho.Desconto = numDesconto.Value;
            aparelho.Espessura = nunEspessura.Value;
            aparelho.Largura = nunLargura.Value;
            aparelho.Modelo = txtModelo.Text;
            aparelho.Peso = numPeso.Value;
            aparelho.Preco = numPreco.Value;
            aparelho.Quantidade =Convert.ToInt16( nunQuantidade.Value);
            Servico.salvar(aparelho);
        }
    }
}
