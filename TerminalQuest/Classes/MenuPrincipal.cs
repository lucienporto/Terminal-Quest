using Figgle;
using System;
using System.Threading;

namespace TerminalQuest.Classes
{
    public class MenuPrincipal
    {
        private static int selectOption = 0;
        public static void Menu()
        {
            Console.Clear();
            Console.WriteLine(FiggleFonts.Standard.Render("Terminal Quest"));

            Console.WriteLine("\tSelecione uma opção:");
            Console.WriteLine("\n\t1.Iniciar");
            Console.WriteLine("\n\t2.Como jogar");
            Console.WriteLine("\n\t3.Sair do jogo");
     
            try
            {
                selectOption = int.Parse(Console.ReadLine());
            }
            catch (FormatException erro) 
            {
                Console.WriteLine("Ops! Encontramos um erro, tente novamente.");
                Thread.Sleep(1000);
                Menu();
            }

            switch (selectOption) 
            {
                case 1:
                    Gaming.SetupPlayer();
                    break;

                case 2:
                    //manualdo jogo
                    break;

                case 3:
                    Console.WriteLine("Encerrando jogo...");
                    Thread.Sleep(1000);
                    break;

                default:
                    Console.WriteLine("Opção inválida, tente novamente.");
                    Thread.Sleep(1000);
                    Menu();
                    break;
            }

        }

        public static void GameOver()
        {
            Console.Clear();
            Console.WriteLine("Obrigado por jogar");
            Console.WriteLine(FiggleFonts.Standard.Render("Terminal Quest"));
        }
    }
}
