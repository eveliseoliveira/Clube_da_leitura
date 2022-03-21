using System;
using System.Collections.Generic;
using static Teste.ConsoleApp.ControleRevista;
using static Teste.ConsoleApp.ControleAmigo;
using static Teste.ConsoleApp.ControleEmprestimo;
using static Teste.ConsoleApp.ControleReserva;
using static Teste.ConsoleApp.Revista;
using static Teste.ConsoleApp.Menu;


namespace Teste.ConsoleApp
{
    internal class Program
    {
        #region Menu Principal
        static int MenuPrincipal()
        {
            Console.Title = "### CLUBE DA LEITURA ###";

            Console.Clear();
            Console.WriteLine("### CLUBE DA LEITURA ###\n");
            Console.WriteLine("Selecione uma opcao:\n[1] Menu revistas\n" +
                "[2] Menu amigos\n[3] Menu empréstimos\n[4] Menu Reserva");
            int opcao_menu_inicial = Convert.ToInt32(Console.ReadLine());
            return opcao_menu_inicial;
        }
        static void Main(string[] args)
        {
            ControleRevista revista = new ControleRevista();
            ControleAmigo amigo = new ControleAmigo();
            ControleEmprestimo emprestimo = new ControleEmprestimo();
            ControleReserva reserva = new ControleReserva();



            Menu menu = new Menu();
            menu.ControleRevista = revista;
            menu.ControleAmigo = amigo;
            menu.ControleEmprestimo = emprestimo;
            menu.ControleReserva = reserva;

            int opcao_menu_inicial = 0;
            while (opcao_menu_inicial != 5)
            {
                opcao_menu_inicial = MenuPrincipal();
                Console.Clear();
                switch (opcao_menu_inicial)
                {
                    case 1:
                        menu.MenuRevistas();
                        break;

                    case 2:
                        menu.MenuAmigos();
                        break;

                    case 3:
                        menu.MenuEmprestimos();
                        break;
                    case 4:
                        menu.MenuReservas();
                        break;
                }
            }
        }
        #endregion
    }
}

    
