using System;
using System.Collections.Generic;
using static Teste.ConsoleApp.Controle;
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
                "[2] Menu amigos\n[3] Menu empréstimos");
            int opcao_menu_inicial = Convert.ToInt32(Console.ReadLine());
            return opcao_menu_inicial;
        }
        static void Main(string[] args)
        {
            Menu menu = new Menu();

            int opcao_menu_inicial = 0;
            while (opcao_menu_inicial != 4)
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
                }
            }
        }
        #endregion
    }
}

    
