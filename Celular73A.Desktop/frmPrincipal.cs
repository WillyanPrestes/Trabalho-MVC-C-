using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Celular73A.Model.Entidades;
using Celular73A.Model;

namespace Celular73A.Desktop
{
    public partial class frmPrincipal : Form
    {
        List<Fabricante> fabricantes = new List<Fabricante>();
        List<Aparelho> aparelhos = new List<Aparelho>();

        public frmPrincipal()
        {
            InitializeComponent();
        }

        private void frmPrincipal_Load(object sender, EventArgs e)
        {
            fabricantes = Servico.todosFabricantes();
            //carregaAparelhos() ;
            foreach (Fabricante fabricante in fabricantes)
                cmbFabricante.Items.Add(fabricante.Nome);
            
        }

        private void frmPrincipal_Activated(object sender, EventArgs e)
        {
            aparelhos = Servico.buscarAparelhos("");
            carregaAparelhos();
        }

        private void carregaAparelhos()
        {
            lstAparelho.Items.Clear();
            foreach (Aparelho aparelho in aparelhos)
                lstAparelho.Items.Add(aparelho.ToString());
        }

        private void btnPesquisarPreco_Click(object sender, EventArgs e)
        {
            decimal precoMin = numPrecoMin.Value;
            decimal precoMax = numPrecoMax.Value;
            aparelhos = Servico.buscarAparelhos(precoMin, precoMax);
            carregaAparelhos();

        }

        private void btnPesquisarModelo_Click(object sender, EventArgs e)
        {
            aparelhos = Servico.buscarAparelhos(txtModelo.Text);
        }

        private void btnPesquisarFabricantt_Click(object sender, EventArgs e)
        {
            string nome = cmbFabricante.Text;
            aparelhos = Servico.buscarAparelhos(fabricantes[cmbFabricante.SelectedIndex]);
        }

        private void btnComprar_Click(object sender, EventArgs e)
        {
            Aparelho selecionado = aparelhos[lstAparelho.SelectedIndex];
            if (selecionado.Quantidade > 0)
                new frmComprar(selecionado).Show();
            else
                MessageBox.Show("O produto esta vazio, impossivel comprar");

        }

        private void btnNovo_Click(object sender, EventArgs e)
        {
            new frmNovo().Show();
        }
    }
}
