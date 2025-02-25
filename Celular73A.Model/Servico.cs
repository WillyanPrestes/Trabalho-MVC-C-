using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Celular73A.Model.Entidades;
using Celular73A.Model.suporte;
using Npgsql;



namespace Celular73A.Model
{
    public class Servico
    {
       
            private static Fabricante objFabricante(ref NpgsqlDataReader dtr)
            {
                Fabricante f = new Fabricante();
                f.Id_Fabricante = Convert.ToInt16(dtr["id_fabricante"]);
                f.Nome = (String)dtr["nome"];
                return f;
            }

            private static Cliente objCliente(ref NpgsqlDataReader dtr)
            {
                Cliente f = new Cliente();
                f.Id_cliente = Convert.ToInt16(dtr["id_cliente"]);
                f.nome = (String)dtr["nome"];
                f.email= (String)dtr["email"];
                f.senha = (String)dtr["senha"];
                return f;
            }

            private static Fabricante objetoFabricante(ref NpgsqlDataReader dtr)
            {
                Fabricante f = new Fabricante();
                f.Id_Fabricante = Convert.ToInt16(dtr["id_fabricante"]);
                f.Nome = (String)dtr["nome"];
                return f;
            }

            private static Aparelho objetoAparelho(ref NpgsqlDataReader dtr)
            {
                try
                {
                    Aparelho a = new Aparelho();
                    a.Id_Aparelho = Convert.ToInt64( dtr["id_aparelho"]);
                    a.Modelo = (String)dtr["modelo"];
                    a.Largura = (decimal)dtr["largura"];
                    a.Altura = (decimal)dtr["altura"];
                    a.Espessura = (decimal)dtr["espessura"];
                    a.Peso = (decimal)dtr["peso"];
                    a.Quantidade = (int)dtr["quantidade"];
                    a.Preco = (decimal)dtr["preco"];
                    a.Desconto = (decimal)dtr["desconto"];
                    //Para o fabricante teremos de buscar o registro relacionado
                    /*NpgsqlDataReader dtr2 = ConexaoBanco.selecionar(
                    "SELECT * FROM fabricante WHERE id_fabricante = " +
                    dtr["idFabricante"]);
                    dtr2.Read();
                    a.Fabricante = objFabricante(ref dtr2);
                    dtr2.Close();*/
                    a.Fabricante = objFabricante(ref dtr);
                    return a;
                }
                catch(Exception ex)
                {
                    throw new ApplicationException(ex.Message);
                }
            }
        
            public static void salvar(Aparelho a)
            {
                String sql;
                // Se tem 'id' igual a zero é porque ainda não foi inserido
                if (a.Id_Aparelho == 0)
                {
                    sql = "INSERT INTO aparelho " +
                    "(id_fabricante, modelo, largura, altura, espessura," +
                    "peso, quantidade, preco, desconto) VALUES (" +
                    a.Fabricante.Id_Fabricante + ",'" + a.Modelo + "'," + a.Largura.ToString().Replace(",", ".") +
                    "," + a.Altura.ToString().Replace(",", ".") + "," + a.Espessura.ToString().Replace(",", ".") + 
                    "," + a.Peso.ToString().Replace(",", ".") + "," + a.Quantidade.ToString().Replace(",", ".") + "," +
                    a.Preco.ToString().Replace(",", ".") + "," + a.Desconto.ToString().Replace(",", ".") + ")";
                    ConexaoBanco.executar(sql);
                    // Devemos capturar o id do aparelho registrado
                    sql = "SELECT max(id_aparelho) as id_aparelho FROM aparelho";
                    NpgsqlDataReader dtr = ConexaoBanco.selecionar(sql);
                    dtr.Read();
                    a.Id_Aparelho = Convert.ToInt16( dtr["id_aparelho"]);
                ConexaoBanco.desconectar();
                }
                else // Senão apenas atualiza
                {
                    sql = "UPDATE aparelho SET " +
                    "id_fabricante = " + a.Fabricante.Id_Fabricante + "," +
                    "modelo = '" + a.Modelo.ToString().Replace(",", ".") + "'," +
                    "largura = " + a.Largura.ToString().Replace(",", ".") + "," +
                    "altura = " + a.Altura.ToString().Replace(",", ".") + "," +
                    "espessura = " + a.Espessura.ToString().Replace(",", ".") + "," +
                    "peso = " + a.Peso.ToString().Replace(",", ".") + "," +
                    "quantidade = " + a.Quantidade.ToString().Replace(",", ".") + "," +
                    "preco = " + a.Preco.ToString().Replace(",", ".") + "," +
                    "desconto = " + a.Desconto.ToString().Replace(",", ".") + " " +
                    "WHERE id_aparelho = " + a.Id_Aparelho;
                    ConexaoBanco.executar(sql);
                }
            }

            public static void salvar(Cliente a)
            {
                String sql;
                // Se tem 'id' igual a zero é porque ainda não foi inserido
                if (a.Id_cliente == 0)
                {
                    sql = "INSERT INTO cliente " +
                    "(nome, email,senha) VALUES ('"+a.nome+"','"+a.email+"','"+a.senha+"')";
                    ConexaoBanco.executar(sql);
                    // Devemos capturar o id do aparelho registrado
                    sql = "SELECT max(id_cliente) as id_cliente FROM cliente";
                    NpgsqlDataReader dtr = ConexaoBanco.selecionar(sql);
                    dtr.Read();
                    a.Id_cliente = Convert.ToInt16(dtr["id_cliente"]);
                    ConexaoBanco.desconectar();
                }
                else // Senão apenas atualiza
                {
                    sql = "UPDATE aparelho SET " +
                    "id_cliente = " + a.Id_cliente + "," + 
                    "nome = '" + a.nome + "'," + "email = '" + a.email +", senha='"+a.senha+"'"+
                    "WHERE id_cliente = " + a.Id_cliente;
                    ConexaoBanco.executar(sql);
                }
            }

            #region buscarAparelhos
            public static List<Aparelho> buscarAparelhos()
            {
                List<Aparelho> aparelhos = new List<Aparelho>();

                string sql = "SELECT * FROM aparelho INNER JOIN fabricante on " +
                            "aparelho.id_fabricante=fabricante.id_fabricante WHERE quantidade > 0order by modelo";
                NpgsqlDataReader dtr = ConexaoBanco.selecionar(sql);
                while (dtr.Read())
                    aparelhos.Add(objetoAparelho(ref dtr));
                dtr.Close();
            
                return aparelhos;
            }

            public static List<Aparelho> buscarAparelhos(String modelo)
            {
                List<Aparelho> aparelhos = new List<Aparelho>();

                string sql = "SELECT * FROM aparelho INNER JOIN fabricante on " + 
                            "aparelho.id_aparelho=fabricante.id_fabricante"+
                            " WHERE upper(modelo) LIKE '%" + modelo.ToUpper() + "%'" + " order by modelo";
                NpgsqlDataReader dtr = ConexaoBanco.selecionar(sql);
                while (dtr.Read())
                    aparelhos.Add(objetoAparelho(ref dtr));
                dtr.Close();
                return aparelhos;
            }

            public static List<Aparelho> buscarAparelhos(decimal precoMin, decimal precoMax)
            {
                List<Aparelho> aparelhos = new List<Aparelho>();
            String sql = "SELECT * FROM aparelho " +
                "INNER JOIN fabricante on aparelho.id_fabricante=fabricante.id_fabricante" +
                " WHERE preco between " + precoMin.ToString().Replace(",",".") +
                " and " + precoMax.ToString().Replace(",", ".") + " order by preco";
                NpgsqlDataReader dtr = ConexaoBanco.selecionar(sql);
                while (dtr.Read())
                    aparelhos.Add(objetoAparelho(ref dtr));
                dtr.Close();
                return aparelhos;
            }

            public static List<Aparelho> buscarAparelhos(Fabricante f)
            {
                List<Aparelho> aparelhos = new List<Aparelho>();
                NpgsqlDataReader dtr = ConexaoBanco.selecionar(
                "SELECT * FROM aparelho INNER JOIN fabricante on aparelho.id_fabricante=fabricante.id_fabricante" +
                " WHERE fabricante.id_fabricante=" + f.Id_Fabricante);
                while (dtr.Read())
                    aparelhos.Add(objetoAparelho(ref dtr));
                dtr.Close();
                return aparelhos;
            }

            public static Aparelho buscarAparelhos(Int64 id_aparelhos)
            {
                Aparelho aparelhos = new Aparelho();

                string sql = "SELECT * FROM aparelho INNER JOIN fabricante on " +
                            "aparelho.id_fabricante=fabricante.id_fabricante Where id_aparelho="+id_aparelhos.ToString()+" order by modelo";
                NpgsqlDataReader dtr = ConexaoBanco.selecionar(sql);
                dtr.Read();
                aparelhos=objetoAparelho(ref dtr);
                dtr.Close();
                return aparelhos;
            }

            public static Aparelho buscaAparelhos(String modelo)
            {
                Aparelho aparelhos = new Aparelho();

                string sql = "SELECT * FROM aparelho INNER JOIN fabricante on " +
                            "aparelho.id_fabricante=fabricante.id_fabricante" +
                            " WHERE upper(modelo) LIKE '%" + modelo.ToUpper() + "%'" + " order by modelo";
            NpgsqlDataReader dtr = ConexaoBanco.selecionar(sql);
                dtr.Read();
                aparelhos = objetoAparelho(ref dtr);
                dtr.Close();
                return aparelhos;
            }


        #endregion

        public static Cliente buscarCliente(Int64 id)
            {
                Cliente cliente = new Cliente();

                string sql = "SELECT * FROM cliente Where id_cliente=" + id.ToString() + " order by modelo";
                NpgsqlDataReader dtr = ConexaoBanco.selecionar(sql);
                dtr.Read();
                cliente = objCliente(ref dtr);
                dtr.Close();
                return cliente;
            }

        public static Cliente buscarCliente(string nome)
        {
            Cliente cliente = new Cliente();

            string sql = "SELECT * FROM cliente Where nome='" + nome.ToString() + "' order by nome";
            NpgsqlDataReader dtr = ConexaoBanco.selecionar(sql);
            dtr.Read();
            cliente = objCliente(ref dtr);
            dtr.Close();
            return cliente;
        }

        public static List<Fabricante> todosFabricantes()
            {
                List<Fabricante> fabricantes = new List<Fabricante>();
                NpgsqlDataReader dtr = ConexaoBanco.selecionar(
                "SELECT * FROM fabricante order by nome");
                while (dtr.Read())
                    fabricantes.Add(objetoFabricante(ref dtr));

                dtr.Close();
                return fabricantes;
            }
            public static List<Cliente> todosClientes()
            {
                List<Cliente> fabricantes = new List<Cliente>();
                NpgsqlDataReader dtr = ConexaoBanco.selecionar(
                "SELECT * FROM cliente order by nome");
                while (dtr.Read())
                    fabricantes.Add(objCliente(ref dtr));

                dtr.Close();
                return fabricantes;
            }
             public static Pedido fazerPedido(Aparelho a)
            {
                Pedido p = new Pedido();
                p.Aparelho = a;
                p.DataHoraPedido = DateTime.Now;
                String sql = "INSERT INTO pedido (id_aparelho, datahorapedido) " +
                "VALUES (" + p.Aparelho.Id_Aparelho + ",'" + p.DataHoraPedido + "')";
                ConexaoBanco.executar(sql);
                // Dando baixa no estoque do aparelho
                a.Quantidade--;
                salvar(a);
                return p;
            }

        public static Pedido fazerPedido(Aparelho a,string nome)
        {
            Cliente cli = buscarCliente(nome);

            Pedido p = new Pedido();
            p.Aparelho = a;
            p.DataHoraPedido = DateTime.Now;
            String sql = "INSERT INTO pedido (id_aparelho, datahorapedido,id_cliente) " +
            "VALUES (" + p.Aparelho.Id_Aparelho + ",'" + p.DataHoraPedido + "',"+cli.Id_cliente+")";
            ConexaoBanco.executar(sql);
            // Dando baixa no estoque do aparelho
            a.Quantidade--;
            salvar(a);
            return p;
        }


        public static int fazLogin(String nome, String senha)
            {
                string sql = "SELECT id_cliente FROM cliente Where senha='" + senha + "' AND nome ='"+nome+"' order by modelo";
                NpgsqlDataReader dtr = ConexaoBanco.selecionar(sql);
                dtr.Read();
                int vai = Convert.ToInt16(dtr["id_cliente"]);
                dtr.Close();
                return vai;
            }
       

    }
}
