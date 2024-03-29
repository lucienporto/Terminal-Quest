using Figgle;
using System;
using System.Threading;

namespace TerminalQuest.Classes
{
    public class Gaming
    {   
        private static int selectOption = 0;
        private static int fugaBatalhas = 0;
        public static string nome = "";
        public static int hp = 20;
        public static int usosMagia = 5;
        public static int potions = 0;
        public static void SetupPlayer()
        {
            Console.Clear();
            Console.WriteLine(FiggleFonts.Standard.Render("Terminal Quest"));
            Console.WriteLine("Insira o nome do seu personagem: ");
            nome = Console.ReadLine();

            Historia.Parte1();
            
            BatalhaLobo();

            if (hp > 0)
            {
                Historia.Parte2();
                
                Historia.PerguntasSobreFogo();

                Historia.Parte3();

                Console.Clear();
                Console.WriteLine("Updates em breve.");
                Thread.Sleep(5000);
                MenuPrincipal.GameOver();

            }
            else
            {
                MenuPrincipal.GameOver();
            }  
        }

        private static void StatusBar()
        {
            Console.WriteLine($"\t\t\tHP: {hp}, Magias restantes: {usosMagia}, Poções {potions}");
        }

        private static void BatalhaLobo()
        {
            int loboHP = 10;

            Random random = new Random();

            while (loboHP > 0 && hp > 0)
            {
                Console.Clear();
                StatusBar();

                Console.WriteLine("\nEscolha sua ação:");
                Console.WriteLine("\n1.Atacar com espada larga");
                Console.WriteLine("\n2.Atacar com magia de fogo");

                try
                {
                    selectOption = int.Parse(Console.ReadLine());
                }
                catch (FormatException erro)
                {
                    Console.WriteLine("Detectamos um erro, tente novamente.");
                    BatalhaLobo();
                }

                if (selectOption == 1)
                {
                    int d10 = random.Next(1,10);
                    loboHP = loboHP - d10;
                    Console.WriteLine($"Você ataca com sua espada causando {d10} de dano.");
                    Console.WriteLine("\nPressione ENTER para continuar.");
                    Console.ReadLine();
                }
                else if (selectOption == 2)
                {
                    int d12 = random.Next(1, 13);
                    usosMagia--;
                    loboHP = loboHP - d12;
                    Console.WriteLine($"Você ataca com sua espada causando {d12} de dano.");
                    Console.WriteLine("\nPressione ENTER para continuar.");
                    Console.ReadLine();
                }

                if (loboHP >= 1)
                {
                    int d4 = random.Next(1, 5);
                    hp = hp - d4;
                    Console.WriteLine($"O lobo te ataca com uma mordida, te causando {d4} de dano.");
                    Console.WriteLine("\nPressione ENTER para continuar.");
                    Console.ReadLine();
                }
                else
                {
                    Console.WriteLine("O pobre animal se debate no chão enquanto sua vida se esvai. Você aplica um último golpe e encerra de vez seu sofrimento.");
                    Console.WriteLine("\nPressione ENTER para continuar.");
                    Console.ReadLine();
                    continue;
                }

                if (hp <= 0)
                {
                    Console.WriteLine("Você sente as mandíbulas do animal se fechando em seu pescoço. O mundo escurece ao seu redor e você se entrega a uma morte patética.");
                    Console.WriteLine("\nPressione ENTER para continuar.");
                    Console.ReadLine();
                    continue;
                }
            }


        }

    }
}
