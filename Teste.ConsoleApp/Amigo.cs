using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Teste.ConsoleApp
{
    internal class Amigo
    {
        public Amigo()
        {
            this.Id = 1;
            this.Nome = "";
            this.Nome_responsavel = "";
            this.Telefone = "";
            this.Endereco = "";
        }

        public Amigo(String nome, String nome_responsavel, String telefone, String endereco, int id)
        {
            this.Id = id;
            this.Nome = nome;
            this.Nome_responsavel = nome_responsavel;
            this.Telefone = telefone;
            this.Endereco = endereco;
        }

        private int id;

        public int Id
        {
            get { return id; }
            set
            {
                if (value >= 0) id = value;
                else
                {
                    throw new Exception("Permitido apenas numeros positivos!");
                }
            }
        }

        private String nome;

        public String Nome
        {
            get { return nome; }
            set { nome = value.ToUpper(); }
        }

        private String nome_responsavel;

        public String Nome_responsavel
        {
            get { return nome_responsavel; }
            set { nome_responsavel = value.ToUpper(); }
        }

        private String telefone;

        public String Telefone
        {
            get { return telefone; }
            set { telefone = value.ToUpper(); }
        }

        private String endereco;

        public String Endereco
        {
            get { return endereco; }
            set { endereco = value.ToUpper(); }
        }
    }
}
