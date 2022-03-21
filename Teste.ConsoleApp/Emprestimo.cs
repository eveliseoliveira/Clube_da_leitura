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
            this.Id_emprestimo = 1;
            this.Nome_emprestimo = "";
            this.Id_revista = 1;
            this.Data_emprestimo = "";
            this.Data_devolucao = "";
        }

        public Emprestimo(String nome_emprestimo, int id_emprestimo, int id_revista, String data_emprestimo, String data_devolucao)
        {
            this.Id_emprestimo = id_emprestimo;
            this.Nome_emprestimo = nome_emprestimo;
            this.Id_revista = id_revista;
            this.Data_emprestimo = data_emprestimo;
            this.Data_devolucao = data_devolucao;
        }

        private int id_emprestimo;

        public int Id_emprestimo
        {
            get { return id_emprestimo; }
            set
            {
                if (value >= 0) id_emprestimo = value;
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

        private String nome_emprestimo;

        public String Nome_emprestimo
        {
            get { return nome_emprestimo; }
            set { nome_emprestimo = value.ToUpper(); }
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

        public Revista revista
        {
            get;
            set; 
        }
    }
}
