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
    public partial class frmComprar : Form
    {
        public frmComprar(Aparelho aparelao)
        {
            aparelho = aparelao;
            InitializeComponent();
        }
        private Aparelho aparelho;
        private List<Cliente> clientes;

        private void frmComprar_Load(object sender, EventArgs e)
        {
            txtFabricante.Text = aparelho.Fabricante.Nome;
            txtModelo.Text = aparelho.Modelo;
            nunAltura.Value = aparelho.Altura;
            nunEspessura.Value = aparelho.Espessura;
            nunLargura.Value = aparelho.Largura;
            nunQuantidade.Value = aparelho.Quantidade;
            numDesconto.Value = aparelho.Desconto;
            numPeso.Value = aparelho.Peso;
            numPreco.Value = aparelho.Preco;

            clientes = Servico.todosClientes();
            foreach (Cliente f in clientes)
                comboBox1.Items.Add(f.nome);

        }

        private void btnComprar_Click(object sender, EventArgs e)
        {
            Servico.fazerPedido(aparelho, clientes[comboBox1.SelectedIndex].nome);
            this.Close();
        }

        private void btnSair_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
