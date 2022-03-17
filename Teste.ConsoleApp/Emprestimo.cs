using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Teste.ConsoleApp
{
    internal class Emprestimo
    {
        public Emprestimo()
        {
            this.Id = 1;
            this.Nome = "";
            this.Id_revista = 1;
            this.Data_emprestimo = "";
            this.Data_devolucao = "";
        }

        public Emprestimo(String nome, int id, int id_revista, String data_emprestimo, String data_devolucao)
        {
            this.Id = id;
            this.Nome = nome;
            this.Id_revista = id_revista;
            this.Data_emprestimo = data_emprestimo;
            this.Data_devolucao = data_devolucao;
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

        public int id_revista;
        public int Id_revista
        {
            get { return id_revista; }
            set
            {
                if (value >= 0) id_revista = value;
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

        private String data_emprestimo;

        public String Data_emprestimo
        {
            get { return data_emprestimo; }
            set { data_emprestimo = value.ToUpper(); }
        }

        private String data_devolucao;

        public String Data_devolucao
        {
            get { return data_devolucao; }
            set { data_devolucao = value.ToUpper(); }
        }
    }
}
