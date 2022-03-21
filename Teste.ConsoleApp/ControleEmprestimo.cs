using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Teste.ConsoleApp
{
    internal class ControleEmprestimo
    {
        public class ListaDeEmprestimos
        {

            private List<Emprestimo> emprestimos;
            public List<Emprestimo> Emprestimos
            {
                get
                {
                    return emprestimos;
                }
            }

            public ListaDeEmprestimos()
            {
                emprestimos = new List<Emprestimo>();
            }

            public Boolean CadastroEmprestimo(Emprestimo emprestimo)
            {
                Boolean resultado = true;
                try
                {
                    Emprestimo e = emprestimos.Find(x => x.Id_emprestimo == emprestimo.Id_emprestimo);
                    if (e == null)
                    {
                        emprestimos.Add(emprestimo);
                    }
                    else
                    {
                        resultado = false;
                    }
                }
                catch (Exception erro)
                {
                    resultado = false;
                }
                return resultado;
            }
            public Boolean AlterarEmprestimo(Emprestimo emprestimo)
            {
                Boolean resultado = false;
                Emprestimo e = emprestimos.Find(x => x.Id_emprestimo == emprestimo.Id_emprestimo);
                if (e != null)
                {
                    e.Id_emprestimo = emprestimo.Id_emprestimo;
                    e.Nome_emprestimo = emprestimo.Nome_emprestimo;
                    e.Id_revista = emprestimo.Id_revista;
                    e.Data_emprestimo = emprestimo.Data_emprestimo;
                    e.Data_devolucao = emprestimo.Data_devolucao;
                    resultado = true;
                }
                return resultado;
            }
            public Boolean ExcluirEmprestimo(int id)
            {
                Boolean resultado = false;
                Emprestimo e = emprestimos.Find(x => x.Id_emprestimo == id);
                if (e != null)
                {
                    resultado = emprestimos.Remove(e);
                }
                return resultado;
            }
            public List<Emprestimo> LocalizaNome(String nome)
            {
                List<Emprestimo> localiza_nome = emprestimos.FindAll(x => x.Nome_emprestimo.Contains(nome.ToUpper()));
                return localiza_nome;
            }
        }
    }
}
