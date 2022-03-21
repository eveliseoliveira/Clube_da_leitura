using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Teste.ConsoleApp
{
    internal class ControleAmigo
    {
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
    }
}
