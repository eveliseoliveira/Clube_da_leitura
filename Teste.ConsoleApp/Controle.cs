using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static Teste.ConsoleApp.Revista;

namespace Teste.ConsoleApp
{
    internal class Controle
    {
        #region Controle De Revistas
        public class ListaDeRevistas
        {

            private List<Revista> revistas;
            public List<Revista> Revistas
            {
                get
                {
                    return revistas;
                }
            }

            public ListaDeRevistas()
            {
                revistas = new List<Revista>();
            }

            public Boolean Inserir(Revista revista)
            {
                Boolean resultado = true;
                try
                {
                    Revista r = revistas.Find(x => x.Id == revista.Id);

                    if (r == null)
                    {
                        revistas.Add(revista);
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
            public Boolean Alterar(Revista revista)
            {
                Boolean resultado = false;
                Revista r = revistas.Find(x => x.Id == revista.Id);
                if (r != null)
                {
                    r.Nome = revista.Nome;
                    r.Descricao = revista.Descricao;
                    r.Genero = revista.Genero;
                    r.Tipo_Revista = revista.Tipo_Revista;
                    r.Caixa_cor = revista.Caixa_cor;
                    resultado = true;
                }
                return resultado;
            }
            public Boolean Excluir(int id)
            {
                Boolean resultado = false;
                Revista r = revistas.Find(x => x.Id == id);
                if (r != null)
                {
                    resultado = revistas.Remove(r);
                }
                return resultado;
            }
            public List<Revista> Localizar(String nome)
            {
                List<Revista> lr = revistas.FindAll(x => x.Nome.Contains(nome.ToUpper()));
                return lr;
            }

            public List<Revista> ListarPorGenero(TipoGenero genero)
            {
                List<Revista> lr = revistas.FindAll(x => x.Genero.Equals(genero));
                return lr;
            }

            public List<Revista> ListarPorTipo(TipoRevista tipo_revista)
            {
                List<Revista> lr = revistas.FindAll(x => x.Tipo_Revista.Equals(tipo_revista));
                return lr;
            }

            public List<Revista> ListarPorCaixa(CaixaCor caixa_cor)
            {
                List<Revista> lr = revistas.FindAll(x => x.Caixa_cor.Equals(caixa_cor));
                return lr;
            }

        }
        #endregion

        #region Controle De Amigos
        public class ListaDeAmigos
        {

            private List<Amigo> amigos;
            public List<Amigo> Amigos
            {
                get
                {
                    return amigos;
                }
            }

            public ListaDeAmigos()
            {
                amigos = new List<Amigo>();
            }

            public Boolean InserirAmigo(Amigo amigo)
            {
                Boolean resultado = true;
                try
                {
                    Amigo a = amigos.Find(x => x.Nome == amigo.Nome);
                    if (a == null)
                    {
                        amigos.Add(amigo);
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
            public Boolean AlterarAmigo(Amigo amigo)
            {
                Boolean resultado = false;
                Amigo a = amigos.Find(x => x.Id == amigo.Id);
                if (a != null)
                {
                    a.Nome = amigo.Nome;
                    a.Nome_responsavel = amigo.Nome_responsavel;
                    a.Telefone = amigo.Telefone;
                    a.Endereco = amigo.Endereco;
                    resultado = true;
                }
                return resultado;
            }
            public Boolean ExcluirAmigo(int id)
            {
                Boolean resultado = false;
                Amigo a = amigos.Find(x => x.Id == id);
                if (a != null)
                {
                    resultado = amigos.Remove(a);
                }
                return resultado;
            }
            public List<Amigo> LocalizaNome(String nome)
            {
                List<Amigo> localiza_nome = amigos.FindAll(x => x.Nome.Contains(nome.ToUpper()));
                return localiza_nome;
            }

            public List<Amigo> LocalizaTelefone(String etiqueta)
            {
                List<Amigo> localiza_telefone = amigos.FindAll(x => x.Telefone.Equals(etiqueta.ToUpper()));
                return localiza_telefone;
            }
        }
        #endregion

        #region Controle De Emprestimos
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
                    Emprestimo e = emprestimos.Find(x => x.Id == emprestimo.Id);
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
                Emprestimo e = emprestimos.Find(x => x.Id == emprestimo.Id);
                if (e != null)
                {
                    e.Id = emprestimo.Id;
                    e.Nome = emprestimo.Nome;
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
                Emprestimo e = emprestimos.Find(x => x.Id == id);
                if (e != null)
                {
                    resultado = emprestimos.Remove(e);
                }
                return resultado;
            }
            public List<Emprestimo> LocalizaNome(String nome)
            {
                List<Emprestimo> localiza_nome = emprestimos.FindAll(x => x.Nome.Contains(nome.ToUpper()));
                return localiza_nome;
            }
        }
        #endregion
    }
}

