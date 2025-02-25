using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Celular73A.Model.Entidades
{
    public class Fabricante
    {
        // Atributos internos da classe
        private Int64 id_fabricante;
        private string nome;

        // Propriedades da classe
        public Int64 Id_Fabricante
        {
            get { return id_fabricante; }
            set { id_fabricante = value; }
        }
        public string Nome
        {
            get { return nome; }
            set {
                if (String.IsNullOrEmpty(value))
                    throw new ApplicationException("O nome do fabricante deve estar preenchido!!");
                nome = value;
            }
        }
    }

    public class Aparelho
    {
        private Int64 id_aparelho;
        private Fabricante fabricante;
        private string modelo;
        private decimal altura, largura, espessura;
        private decimal peso, preco, desconto;
        private Int32 quantidade;

        public Int64 Id_Aparelho
        {
            get { return id_aparelho; }
            set { id_aparelho = value; }
        }

        public string Modelo
        {
            get { return modelo; }
            set { modelo = value; }
        }

        public Fabricante Fabricante
        {
            get { return fabricante; }
            set { fabricante = value; }
        }

        public decimal Largura
        {
            get { return largura; }
            set { largura = value; }
        }

        public decimal Altura
        {
            get { return altura; }
            set { altura = value; }
        }

        public decimal Espessura
        {
            get { return espessura; }
            set { espessura = value; }
        }

        public decimal Peso
        {
            get { return peso; }
            set { peso = value; }
        }

        public decimal Preco
        {
            get {
                    return preco; }
            set {
                if (value <= 0)
                    throw new ApplicationException("O preço não pode ser menor ou igual a zero!!!");
                    preco = value; }
        }

        public Int32 Quantidade
        {
            get { return quantidade; }
            set { quantidade = value; }
        }

        public decimal Desconto
        {
            get { return desconto; }
            set { desconto = value; }
        }

        public override string ToString()
        {
            return Fabricante.Nome + " - " + Modelo + " - " +
                Preco.ToString("C") + " (" + quantidade + ") em estoque";

        }
    }

    public class Pedido
    {
        private Int64 id_pedido;
        private Aparelho aparelho;
        private DateTime datahorapedido;

        public Int64 Id_Pedido
        {
            get { return id_pedido; }
            set { id_pedido = value; }
        }

        public Aparelho Aparelho
        {
            get { return aparelho; }
            set { aparelho = value; }
        }

        public DateTime DataHoraPedido
        {
            get { return datahorapedido; }
            set { datahorapedido = value; }
        }
    }
}
