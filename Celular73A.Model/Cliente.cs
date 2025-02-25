using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Celular73A.Model
{
    public class Cliente
    {
        private Int64 id_cliente;
        private string Nome;
        private string Email;
        private string Senha;

        // Propriedades da classe
        public Int64 Id_cliente
        {
            get { return id_cliente; }
            set { id_cliente = value; }
        }
        public string nome
        {
            get { return Nome; }
            set
            {
                if (String.IsNullOrEmpty(value))
                    throw new ApplicationException("O nome do cliente deve estar preenchido!!");
                Nome = value;
            }
        }
        public string email
        {
            get { return Email; }
            set
            {
                if (String.IsNullOrEmpty(value))
                    throw new ApplicationException("O Email do cliente deve estar preenchido!!");
                Email = value;
            }
        }
        public string senha
        {
            get { return Senha; }
            set
            {
                if (String.IsNullOrEmpty(value))
                    throw new ApplicationException("A Senha do cliente deve estar preenchido!!");
                Senha = value;
            }
        }
    }
}
