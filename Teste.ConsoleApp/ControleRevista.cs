using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static Teste.ConsoleApp.Revista;

namespace Teste.ConsoleApp
{
    internal class ControleRevista
    {
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

            public Revista LocalizarId(int id)
            {
                Revista lr = revistas.Find(x => x.Id == id);
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
    }
}
