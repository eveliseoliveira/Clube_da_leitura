using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static Teste.ConsoleApp.Revista;
using static Teste.ConsoleApp.Amigo;
using static Teste.ConsoleApp.Emprestimo;
using static Teste.ConsoleApp.Reserva;
using static Teste.ConsoleApp.ControleRevista;
using static Teste.ConsoleApp.ControleAmigo;
using static Teste.ConsoleApp.ControleEmprestimo;
using static Teste.ConsoleApp.ControleReserva;

namespace Teste.ConsoleApp
{
    internal class Menu
    {
        private object revista;

        public ControleRevista ControleRevista { get; set; }
        public ControleAmigo ControleAmigo { get; set; }
        public ControleEmprestimo ControleEmprestimo { get; set; }
        public ControleReserva ControleReserva { get; set; }


        #region  Menu Revistas
        public int MenuPrincipalRevistas()
        {
            Console.Clear();
            Console.WriteLine("### CLUBE DA LEITURA ###\n");
            Console.WriteLine("Selecione uma opcao:\n\n[1] Cadastrar um revista\n" +
                "[2] Excluir um revista\n[3] Alterar um revista\n" +
                "[4] Localizar um revista por nome\n[5] Mostrar revista por Genero\n" +
                "[6] Mostrar revista por tipo\n[7] Mostrar por caixa\n" +
                "[8] Mostrar todas as revista\n[9] Mostrar dados das caixas\n[10] Sair\n");
            int opcao = Convert.ToInt32(Console.ReadLine());
            return opcao;
        }

        public void MenuRevistas()
        {

            ListaDeRevistas lista_revistas = new ListaDeRevistas();
            List<Revista> lista_revista = new List<Revista>(); 
            String nomerevista = "";
            int id = 0;

            Revista revista = new Revista();

            int opcao = 0; 
            while (opcao != 10)
            {
                opcao = MenuPrincipalRevistas();
                Console.Clear();
                switch (opcao)
                {
                    case 1: //inserir
                        Console.WriteLine("Inserir uma nova revista\n");
                        revista = new Revista();

                        Console.Write("Id: ");
                        revista.Id = Convert.ToInt32(Console.ReadLine());

                        Console.Write("Nome: ");
                        revista.Nome = Console.ReadLine();

                        Console.Write("Ano: ");
                        revista.Ano = Console.ReadLine();

                        Console.Write("Descricao: ");
                        revista.Descricao = Console.ReadLine();

                        Console.WriteLine("\nInforme o Genero:\n\n[0] Açao\n[1] Aventura\n[2] Romance\n[3] Fantasia\n" +
                            "[4] Sci-Fi\n[5] Horror\n[6] Drama\n[7] Slice Of Life\n[8] Outro\n");
                        revista.Genero = (Revista.TipoGenero)Convert.ToInt32(Console.ReadLine());

                        Console.WriteLine("\nInforme o Tipo:\n\n[0] Quadrinho\n[1] Hq\n[2] Manga\n[3] Manhwa\n" +
                            "[4] Manhua\n[5] Light Novel\n[6] Livro\n[7] Outro\n");
                        revista.Tipo_Revista = (Revista.TipoRevista)Convert.ToInt32(Console.ReadLine());

                        Console.WriteLine("\nInforme a caixa:\n[0] Azul\n[1] Amarela\n[2] Branca\n[3] Rosa\n");
                        revista.Caixa_cor = (Revista.CaixaCor)Convert.ToInt32(Console.ReadLine());

                        if (lista_revistas.Inserir(revista))
                        {
                            Console.WriteLine("\nRevista inserida!");
                        }
                        else
                        {
                            Console.WriteLine("\nRevista não inserida!");
                        }
                        Console.ReadKey();
                        break;
                    case 2: //excluir
                        Console.WriteLine("Excluir revista");
                        Console.Write("\nInforme o id da revista: ");
                        id = Convert.ToInt32(Console.ReadLine());
                        if (lista_revistas.Excluir(id))
                        {
                            Console.WriteLine("\nRevista excluida!");
                        }
                        else
                        {
                            Console.WriteLine("\nRevista não excluida!");
                        }
                        Console.ReadKey();
                        break;

                    case 3: //Editar
                        Console.WriteLine("Alterar revista\n");
                        revista = new Revista();

                        Console.Write("Id: ");
                        revista.Id = Convert.ToInt32(Console.ReadLine());

                        Console.Write("Nome: ");
                        revista.Nome = Console.ReadLine();

                        Console.Write("Descricao: ");
                        revista.Descricao = Console.ReadLine();

                        Console.Write("Informe o Genero:\n[0] Açao\n[1] Aventura\n[2] Romance\n[3] Fantasia\n" +
                            "[4] Sci-Fi\n[5] Horror\n[6] Drama\n[7] Slice Of Life\n[8] Outro\n");
                        revista.Genero = (TipoGenero)Convert.ToInt32(Console.ReadLine())
                            ;
                        Console.Write("Informe o Tipo:\n[0] Quadrinho\n[1] Hq\n[2] Manga\n[3] Manhwa\n" +
                            "[4] Manhua\n[5] Light Novel\n[6] Livro\n[7] Outro\n");
                        revista.Tipo_Revista = (TipoRevista)Convert.ToInt32(Console.ReadLine());

                        Console.WriteLine("\nInforme a caixa:\n[0] Azul\n[1] Amarela\n[2] Branca\n[3] Rosa\n");
                        revista.Caixa_cor = (Revista.CaixaCor)Convert.ToInt32(Console.ReadLine());

                        if (lista_revistas.Alterar(revista))
                        {
                            Console.WriteLine("\nRevista alterada!");
                        }
                        else
                        {
                            Console.WriteLine("\nRevista não alterada!");
                        }
                        Console.ReadKey();
                        break;

                    case 4: //Localizar por nome
                        Console.WriteLine("Localizar revista\n");
                        Console.Write("Informe o nome da revista:\n");
                        nomerevista = Console.ReadLine();
                        lista_revista = lista_revistas.Localizar(nomerevista);

                        foreach (var r in lista_revista)
                        {
                            Console.Write("Id: " + r.Id);
                            Console.Write(" - Nome: " + r.Nome);
                            Console.Write(" - Ano: " + r.Ano);
                            Console.Write(" - Descricao: " + r.Descricao);
                            Console.Write(" - Genero: " + r.Genero);
                            Console.Write(" - Tipo: " + r.Tipo_Revista);
                            Console.Write(" - Caixa: " + r.Caixa_cor);
                            Console.WriteLine();
                        }

                        Console.WriteLine("Aperte uma tecla para continuar");
                        Console.ReadKey();
                        break;

                    case 5: //Listar Gênero
                        Console.WriteLine("Mostrar todas as revistas por gênero\n");
                        Console.Write("Informe o Genero:\n[0] Açao\n[1] Aventura\n[2] Romance[3] Fantasia\n" +
                            "[4] Sci-Fi\n[5] Horror\n[6] Drama\n[7] Slice Of Life\n[8] Outro\n");
                        TipoGenero genero = (TipoGenero)Convert.ToInt32(Console.ReadLine());
                        lista_revista = lista_revistas.ListarPorGenero(genero);

                        foreach (var r in lista_revista)
                        {
                            Console.Write("Id: " + r.Id);
                            Console.Write(" - Nome: " + r.Nome);
                            Console.Write(" - Ano: " + r.Ano);
                            Console.Write(" - Descricao: " + r.Descricao);
                            Console.Write(" - Genero: " + r.Genero);
                            Console.Write(" - Tipo: " + r.Tipo_Revista);
                            Console.Write(" - Caixa: " + r.Caixa_cor);
                            Console.WriteLine();
                        }
                        Console.WriteLine("Aperte uma tecla para continuar");
                        Console.ReadKey();
                        break;
                    case 6: //Listar Tipo de Revista
                        Console.WriteLine("Mostrar todos as revistas por tipo\n");
                        Console.Write("Informe o Tipo:\n[0] Quadrinho\n[1] Hq\n[2] Manga\n[3] Manhwa\n" +
                            "[4] Manhua\n[5] Light Novel\n[6] Livro\n[7] Outro\n");
                        TipoRevista tipo_revista = (TipoRevista)Convert.ToInt32(Console.ReadLine());
                        lista_revista = lista_revistas.ListarPorTipo(tipo_revista);

                        foreach (var r in lista_revista)
                        {
                            Console.Write("Id: " + r.Id);
                            Console.Write(" - Nome: " + r.Nome);
                            Console.Write(" - Ano: " + r.Ano);
                            Console.Write(" - Descricao: " + r.Descricao);
                            Console.Write(" - Genero: " + r.Genero);
                            Console.Write(" - Tipo: " + r.Tipo_Revista);
                            Console.Write(" - Caixa: " + r.Caixa_cor);
                            Console.WriteLine();
                        }
                        Console.WriteLine("Aperte uma tecla para continuar");
                        Console.ReadKey();
                        break;

                    case 7:  //Listar por caixa
                        Console.WriteLine("\nInforme a caixa:\n[0] Azul\n[1] Amarela\n[2] Branca\n[3] Rosa\n");
                        CaixaCor caixa_cor = (CaixaCor)Convert.ToInt32(Console.ReadLine());
                        lista_revista = lista_revistas.ListarPorCaixa(caixa_cor);

                        foreach (var r in lista_revista)
                        {
                            Console.Write("Id: " + r.Id);
                            Console.Write(" - Nome: " + r.Nome);
                            Console.Write(" - Ano: " + r.Ano);
                            Console.Write(" - Descricao: " + r.Descricao);
                            Console.Write(" - Genero: " + r.Genero);
                            Console.Write(" - Tipo: " + r.Tipo_Revista);
                            Console.Write(" - Caixa: " + r.Caixa_cor);
                            Console.WriteLine();
                        }
                        Console.WriteLine("Aperte uma tecla para continuar");
                        Console.ReadKey();
                        break;

                    case 8: //Listar todas as revistas
                        Console.WriteLine("Mostrar todas as revistas\n");
                        foreach (var r in lista_revistas.Revistas)
                        {
                            Console.Write("Id: " + r.Id);
                            Console.Write(" - Nome: " + r.Nome);
                            Console.Write(" - Ano: " + r.Ano);
                            Console.Write(" - Descricao: " + r.Descricao);
                            Console.Write(" - Genero: " + r.Genero);
                            Console.Write(" - Tipo: " + r.Tipo_Revista);
                            Console.Write(" - Caixa: " + r.Caixa_cor);
                            Console.WriteLine();
                        }
                        Console.WriteLine("Aperte uma tecla para continuar");
                        Console.ReadKey();
                        break;

                    case 9:
                        Console.WriteLine("Mostrar dados das caixas\n");

                        CaixaCor azul = CaixaCor.Azul;
                        Console.Write("Cor: " + azul);
                        CaixaEtiqueta etiqueta_azul = CaixaEtiqueta.A1;
                        Console.Write(" - Etiqueta: " + etiqueta_azul);
                        CaixaNumero numero_azul = CaixaNumero.Um;
                        Console.Write(" - Número: " + numero_azul);
                        Console.WriteLine();

                        CaixaCor amarelo = CaixaCor.Amarelo;
                        Console.Write("Cor: " + amarelo);
                        CaixaEtiqueta etiqueta_amarelo = CaixaEtiqueta.B2;
                        Console.Write(" - Etiqueta: " + etiqueta_amarelo);
                        CaixaNumero numero_amarelo = CaixaNumero.Dois;
                        Console.Write(" - Número: " + numero_amarelo);
                        Console.WriteLine();

                        CaixaCor branco = CaixaCor.Branco;
                        Console.Write("Cor: " + branco);
                        CaixaEtiqueta etiqueta_branco = CaixaEtiqueta.C3;
                        Console.Write(" - Etiqueta: " + etiqueta_branco);
                        CaixaNumero numero_branco = CaixaNumero.Tres;
                        Console.Write(" - Número: " + numero_branco);
                        Console.WriteLine();

                        CaixaCor rosa = CaixaCor.Rosa;
                        Console.Write("Cor: " + rosa);
                        CaixaEtiqueta etiqueta_rosa = CaixaEtiqueta.D4;
                        Console.Write(" - Etiqueta: " + etiqueta_rosa);
                        CaixaNumero numero_rosa = CaixaNumero.Quatro;
                        Console.Write(" - Número: " + numero_rosa);
                        Console.WriteLine();

                        Console.WriteLine("Aperte uma tecla para continuar");
                        Console.ReadKey();
                        break;
                }
            }
        }
        #endregion

        #region Menu Amigo
        public int MenuPrincipalAmigos()
        {
            Console.Clear();
            Console.WriteLine("### CLUBE DA LEITURA ###\n");
            Console.WriteLine("Selecione uma opcao:\n\n[1] Cadastrar amigo\n" +
                "[2] Excluir amigo\n[3] Alterar amigo\n" +
                "[4] Localizar amigo pelo nome\n[5] Localizar amigo por telefone\n" +
                "[6] Mostrar todas os amigos\n[9] Sair\n");
            int opcao = Convert.ToInt32(Console.ReadLine());
            return opcao;
        }

        public void MenuAmigos()
        {

            ListaDeAmigos lista_amigos = new ListaDeAmigos();
            List<Amigo> lista = new List<Amigo>(); 
            String nome = "";
            String telefone = "";
            int id = 0;

            Amigo amigo = new Amigo();

            int opcao = 0; 
            while (opcao != 9)
            {
                opcao = MenuPrincipalAmigos();
                Console.Clear();
                switch (opcao)
                {
                    case 1: //inserir
                        Console.WriteLine("Inserir amigo\n");
                        amigo = new Amigo();

                        Console.Write("Id: ");
                        amigo.Id = Convert.ToInt32(Console.ReadLine());

                        Console.Write("Nome: ");
                        amigo.Nome = Console.ReadLine();

                        Console.Write("Nome responsável: ");
                        amigo.Nome_responsavel = Console.ReadLine();

                        Console.Write("Telefone: ");
                        amigo.Telefone = Console.ReadLine();

                        Console.Write("Endereço: ");
                        amigo.Endereco = Console.ReadLine();

                        if (lista_amigos.InserirAmigo(amigo))
                        {
                            Console.WriteLine("\nAmigo inserido!");
                        }
                        else
                        {
                            Console.WriteLine("\nAmigo não inserido!");
                        }
                        Console.ReadKey();
                        break;

                    case 2: //excluir
                        Console.WriteLine("Excluir amigo");
                        Console.Write("\nInforme o id: ");
                        id = Convert.ToInt32(Console.ReadLine());

                        if (lista_amigos.ExcluirAmigo(id))
                        {
                            Console.WriteLine("\nAmigo excluido!");
                        }
                        else
                        {
                            Console.WriteLine("\nAmigo não excluido!");
                        }
                        Console.ReadKey();
                        break;

                    case 3: //Editar
                        Console.WriteLine("Alterar amigo\n");
                        amigo = new Amigo();

                        Console.Write("Id: ");
                        amigo.Id = Convert.ToInt32(Console.ReadLine());

                        Console.Write("\nNome: ");
                        amigo.Nome = Console.ReadLine();

                        Console.Write("Nome responsavel: ");
                        amigo.Nome_responsavel = Console.ReadLine();

                        Console.Write("Telefone: ");
                        amigo.Telefone = Console.ReadLine();

                        Console.Write("Endereço: ");
                        amigo.Endereco = Console.ReadLine();

                        if (lista_amigos.AlterarAmigo(amigo))
                        {
                            Console.WriteLine("\nAmigo alterado!");
                        }
                        else
                        {
                            Console.WriteLine("\nAmigo não alterado!");
                        }
                        Console.ReadKey();
                        break;

                    case 4: //Localizar por nome
                        Console.WriteLine("Localizar amigo\n");
                        Console.Write("Informe o nome: ");
                        nome = Console.ReadLine();
                        lista = lista_amigos.LocalizaNome(nome);

                        foreach (var a in lista)
                        {
                            Console.Write("Nome: " + a.Nome);
                            Console.Write(" - Nome responsável: " + a.Nome_responsavel);
                            Console.Write(" - Telefone: " + a.Telefone);
                            Console.Write(" - Endereço: " + a.Endereco);
                            Console.WriteLine();
                        }
                        Console.WriteLine("Aperte uma tecla para continuar");
                        Console.ReadKey();
                        break;

                    case 5: //Localizar por telefone
                        Console.WriteLine("Localizar amigo\n");
                        Console.Write("Informe o número do telefone: ");
                        telefone = Console.ReadLine();
                        lista = lista_amigos.LocalizaTelefone(telefone);

                        foreach (var a in lista)
                        {
                            Console.Write("Nome: " + a.Nome);
                            Console.Write(" - Nome responsável: " + a.Nome_responsavel);
                            Console.Write(" - Telefone: " + a.Telefone);
                            Console.Write(" - Endereço: " + a.Endereco);
                            Console.WriteLine();
                        }
                        Console.WriteLine("Aperte uma tecla para continuar");
                        Console.ReadKey();
                        break;

                    case 6: //Listar todos os amigos
                        Console.WriteLine("Mostrar todas os amigos\n");
                        foreach (var a in lista_amigos.Amigos)
                        {
                            Console.Write("Nome: " + a.Nome);
                            Console.Write(" - Nome responsável: " + a.Nome_responsavel);
                            Console.Write(" - Telefone: " + a.Telefone);
                            Console.Write(" - Endereço: " + a.Endereco);
                            Console.WriteLine();
                        }
                        Console.WriteLine("Aperte uma tecla para continuar");
                        Console.ReadKey();
                        break;
                }
            }
        }
        #endregion

        #region Menu Empréstimo
        public int MenuPrincipalEmprestimos()
        {
            Console.Clear();
            Console.WriteLine("### CLUBE DA LEITURA ###\n");
            Console.WriteLine("Selecione uma opcao:\n\n[1] Cadastrar empréstimo\n" +
                "[2] Excluir empréstimo\n[3] Alterar empréstimo\n" +
                "[4] Localizar empréstimo\n[5] Mostrar todas os empréstimos\n[6] Sair\n");
            int opcao = Convert.ToInt32(Console.ReadLine());
            return opcao;
        }
        public void MenuEmprestimos()
        {

            ListaDeEmprestimos lista_emprestimos = new ListaDeEmprestimos();
            List<Emprestimo> lista = new List<Emprestimo>(); //utilizado nos cases
            String nome_emprestimo = "";
            int id_emprestimo = 0;

            ListaDeRevistas lista_revistas = new ListaDeRevistas();
            List<Revista> lista_revista = new List<Revista>();
            int Id = 0;


            Emprestimo emprestimo = new Emprestimo();

            int opcao = 0; //valor da operação que o usuário era realizar
            while (opcao != 6)
            {
                opcao = MenuPrincipalEmprestimos();
                Console.Clear();
                switch (opcao)
                {
                    case 1: //inserir
                        Console.WriteLine("Cadastrar emprestimo\n");
                        emprestimo = new Emprestimo();

                        Console.Write("Id: ");
                        emprestimo.Id_emprestimo = Convert.ToInt32(Console.ReadLine());

                        Console.Write("Nome: ");
                        emprestimo.Nome_emprestimo = Console.ReadLine();

                        Console.Write("Data do empréstimo: ");
                        emprestimo.Data_emprestimo = Console.ReadLine();

                        Console.Write("Data da Devolução: ");
                        emprestimo.Data_devolucao = Console.ReadLine();

                        if (lista_emprestimos.CadastroEmprestimo(emprestimo))
                        {
                            Console.WriteLine("\nEmprestimo cadastrado!");
                        }
                        else
                        {
                            Console.WriteLine("\nEmprestimo não cadastrado!");
                        }
                        Console.ReadKey();
                        break;

                    case 2: //excluir
                        Console.WriteLine("Excluir empréstimo\n");
                        Console.Write("Informe o id: ");
                        id_emprestimo = Convert.ToInt32(Console.ReadLine());

                        if (lista_emprestimos.ExcluirEmprestimo(id_emprestimo))
                        {
                            Console.WriteLine("\nEmpréstimo excluido!");
                        }
                        else
                        {
                            Console.WriteLine("\nEmpréstimo não excluido!");
                        }
                        Console.ReadKey();
                        break;

                    case 3: //Editar
                        Console.WriteLine("Alterar empréstimo\n");
                        emprestimo = new Emprestimo();

                        Console.Write("Id: ");
                        emprestimo.Id_emprestimo = Convert.ToInt32(Console.ReadLine());

                        Console.Write("Nome: ");
                        emprestimo.Nome_emprestimo = Console.ReadLine();

                        Console.Write("Id da revista: ");
                        emprestimo.Id_revista = Convert.ToInt32(Console.ReadLine());

                        Console.Write("Data de empréstimo: ");
                        emprestimo.Data_emprestimo = Console.ReadLine();

                        Console.Write("Data de dovolução: ");
                        emprestimo.Data_devolucao = Console.ReadLine();

                        if (lista_emprestimos.AlterarEmprestimo(emprestimo))
                        {
                            Console.WriteLine("\nEmpréstimo alterado!");
                        }
                        else
                        {
                            Console.WriteLine("\nEmpréstimo não alterado!");
                        }
                        Console.ReadKey();
                        break;

                    case 4: //Localizar por nome
                        Console.WriteLine("Localizar empréstimo\n");
                        Console.Write("Informe o nome: ");
                        nome_emprestimo = Console.ReadLine();
                        lista = lista_emprestimos.LocalizaNome(nome_emprestimo);

                        foreach (var e in lista)
                        {
                            Console.Write("Id: " + e.Id_emprestimo);
                            Console.Write("Nome: " + e.Nome_emprestimo);
                            Console.Write(" - Id revista: " + e.Id_revista);
                            Console.Write(" - Data de emprestimo: " + e.Data_emprestimo);
                            Console.Write(" - Data de devolução: " + e.Data_devolucao);
                            Console.WriteLine();
                        }
                        Console.WriteLine("Aperte uma tecla para continuar");
                        Console.ReadKey();
                        break;

                    case 5: //Listar todos os empréstimos
                        Console.WriteLine("Mostrar todos os empréstimos\n");
                        foreach (var e in lista_emprestimos.Emprestimos)
                        {
                            Console.Write("Id: " + e.Id_emprestimo);
                            Console.Write("Nome: " + e.Nome_emprestimo);
                            Console.Write(" - Id revista: " + e.Id_revista);
                            Console.Write(" - Data de emprestimo: " + e.Data_emprestimo);
                            Console.Write(" - Data de devolução: " + e.Data_devolucao);
                            Console.WriteLine();
                        }
                        Console.WriteLine("Aperte uma tecla para continuar");
                        Console.ReadKey();
                        break;
                }
            }
        }
        #endregion

        #region Menu Reserva
        public int MenuPrincipalReserva()
        {
            Console.Clear();
            Console.WriteLine("### CLUBE DA LEITURA ###\n");
            Console.WriteLine("Selecione uma opcao:\n\n[1] Cadastrar uma reserva\n" +
                "[2] Excluir uma reserva\n[3] Alterar uma reserva\n[4] Localizar uma reserva por nome\n" +
                "[5] Listar por categoria\n[6] Mostrar todas as reservas\n[7] Fazer emprestimo\n[8] Sair\n");
            int opcao = Convert.ToInt32(Console.ReadLine());
            return opcao;
        }

        public void MenuReservas()
        {

            ListaDeReservas lista_reservas = new ListaDeReservas();
            List<Reserva> lista = new List<Reserva>();
            String nomereserva = "";
            int dias_reserva = 0;

            Reserva reserva = new Reserva();

            int opcao = 0;
            while (opcao != 8)
            {
                opcao = MenuPrincipalReserva();
                Console.Clear();
                switch (opcao)
                {
                    case 1: //inserir
                        Console.WriteLine("Cadastrar reserva\n");
                        reserva = new Reserva();

                        Console.Write("Nome: ");
                        reserva.Nome_reserva = Console.ReadLine();

                        Console.Write("Dias de reserva: ");
                        reserva.Dias_reserva = Convert.ToInt32(Console.ReadLine());

                        Console.Write("Revista: ");
                        reserva.Revista_reserva = Console.ReadLine();

                        Console.WriteLine("\nInforme a categoria:\n[0] Regular\n[1] Novidade\n");
                        reserva.Dias_revista = (Reserva.DiasRevistas)Convert.ToInt32(Console.ReadLine());

                        if (lista_reservas.InserirReserva(reserva))
                        {
                            Console.WriteLine("\nRevista inserida!");

                            if (reserva.Dias_revista != 0)
                            {
                                Console.WriteLine("Item categorizado como Novidade, apenas 3 dias para emprestimo!");
                            }
                            else
                            {
                                Console.WriteLine("Item categorizado como Regular, apenas 2 dias para emprestimo!");
                            }
                        }
                        else
                        {
                            Console.WriteLine("\nRevista não inserida!");
                        }
                        Console.ReadKey();
                        break;
                    case 2: //excluir
                        Console.WriteLine("Excluir revista");
                        Console.Write("\nInforme o id da revista: ");
                        dias_reserva = Convert.ToInt32(Console.ReadLine());
                        if (lista_reservas.ExcluirReserva(dias_reserva))
                        {
                            Console.WriteLine("\nRevista reserva excluida!");
                        }
                        else
                        {
                            Console.WriteLine("\nRevista reserva não excluida!");
                        }
                        Console.ReadKey();
                        break;

                    case 3: //Editar
                        Console.WriteLine("Alterar reserva\n");
                        reserva = new Reserva();

                        Console.Write("Nome: ");
                        reserva.Nome_reserva = Console.ReadLine();

                        Console.Write("Dias de reserva: ");
                        reserva.Dias_reserva = Convert.ToInt32(Console.ReadLine());

                        Console.Write("Revista: ");
                        reserva.Revista_reserva = Console.ReadLine();

                        Console.WriteLine("\nInforme a categoria:\n[0] Regular\n[1] Novidade");
                        reserva.Dias_revista = (Reserva.DiasRevistas)Convert.ToInt32(Console.ReadLine());

                        if (lista_reservas.AlterarReserva(reserva))
                        {
                            Console.WriteLine("\nRevista reserva alterada!");
                        }
                        else
                        {
                            Console.WriteLine("\nRevista reserva não alterada!");
                        }
                        Console.ReadKey();
                        break;

                    case 4: //Localizar por nome
                        Console.WriteLine("Localizar reserva\n");
                        Console.Write("Informe o nome da revista:\n");
                        nomereserva = Console.ReadLine();
                        lista = lista_reservas.LocalizarReserva(nomereserva);

                        foreach (var r in lista)
                        {
                            Console.Write("Nome: " + r.Nome_reserva);
                            Console.Write(" - Dias de reserva: " + r.Dias_reserva);
                            Console.Write(" - Revista: " + r.Revista_reserva);
                            Console.Write(" - Categoria: " + r.Dias_revista);
                            Console.WriteLine();
                        }

                        Console.WriteLine("Aperte uma tecla para continuar");
                        Console.ReadKey();
                        break;
                    case 5: //Listar Por Categoria
                        Console.WriteLine("Listar por categoria");
                        Console.WriteLine("\nInforme a categoria:\n[0] Regular\n[1] Novidade");
                        DiasRevistas dias_revista = (DiasRevistas)Convert.ToInt32(Console.ReadLine());
                        lista = lista_reservas.ListarPorCategoria(dias_revista);

                            foreach (var r in lista)
                        {
                            Console.Write("Nome: " + r.Nome_reserva);
                            Console.Write(" - Dias de reserva: " + r.Dias_reserva);
                            Console.Write(" - Revista: " + r.Revista_reserva);
                            Console.Write(" - Categoria: " + r.Dias_revista);
                            Console.WriteLine();
                        }
                        Console.WriteLine("Aperte uma tecla para continuar");
                        Console.ReadKey();
                        break;
                    case 6: //Listar todas as revistas
                        Console.WriteLine("Mostrar todas as revistas reservas\n");
                        foreach (var r in lista_reservas.Reservas)
                        {
                            Console.Write("Nome: " + r.Nome_reserva);
                            Console.Write(" - Dias de reserva: " + r.Dias_reserva);
                            Console.Write(" - Revista: " + r.Revista_reserva);
                            Console.Write(" - Categoria: " + r.Dias_revista);
                            Console.WriteLine();
                        }
                        Console.WriteLine("Aperte uma tecla para continuar");
                        Console.ReadKey();
                        break;
                    case 7:
                        MenuPrincipalEmprestimos();
                        MenuEmprestimos();
                        break;
                }
            }
        }
        #endregion
    }
}
