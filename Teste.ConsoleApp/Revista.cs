using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Teste.ConsoleApp
{
    internal class Revista
    {
        public enum TipoGenero { Acao, Aventura, Romance, Fantasia, SciFi, Horror, Drama, SliceOfLife, Outro }
        public enum TipoRevista { Quadrinho, Hq, Manga, Manhwa, Manhua, LightNovel, Livro, Outro }
        public enum CaixaCor { Azul, Amarelo, Branco, Rosa }
        public enum CaixaEtiqueta { A1, B2, C3, D4 }
        public enum CaixaNumero { Um, Dois, Tres, Quatro }

        public Revista()
        {
            this.Id = 1;
            this.Nome = "";
            this.Ano = "";
            this.Descricao = "";
            this.Genero = TipoGenero.Outro;
            this.Tipo_Revista = TipoRevista.Outro;
            this.Caixa_cor = CaixaCor.Rosa;
            this.Caixa_etiqueta = CaixaEtiqueta.D4;
            this.Caixa_numero = CaixaNumero.Quatro;
        }

        public Revista(int id, String nome, String ano, String descricao, TipoGenero genero, TipoRevista tipo_revista, CaixaCor caixa_cor, CaixaEtiqueta caixa_etiqueta, CaixaNumero caixa_numero)
        {
            this.Id = id;
            this.Nome = nome;
            this.Ano = ano;
            this.Descricao = descricao;
            this.Genero = genero;
            this.Tipo_Revista = tipo_revista;
            this.Caixa_cor = caixa_cor;
            this.Caixa_etiqueta = caixa_etiqueta;
            this.Caixa_numero = caixa_numero;
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

        private String ano;

        public String Ano
        {
            get { return ano; }
            set { ano = value.ToUpper(); }
        }

        private String descricao;

        public String Descricao
        {
            get { return descricao; }
            set { descricao = value.ToUpper(); }
        }

        public TipoRevista Tipo_Revista { get; set; }
        public TipoGenero Genero { get; set; }
        public CaixaEtiqueta Caixa_etiqueta { get; set; }
        public CaixaCor Caixa_cor { get; set; }
        public CaixaNumero Caixa_numero { get; set; }
    }
}

