using Figgle;
using System;
using System.Net;
using System.Threading;
using TerminalQuest.Classes.Personagens;

namespace TerminalQuest.Classes
{
    public class Gaming
    {   
        public static int selectOption = 0;
        private static int fugaBatalhas = 0;
        public static string nome;
        public static void SetupPlayer()
        {
            Console.Clear();
            Console.WriteLine(FiggleFonts.Standard.Render("Terminal Quest"));
            Console.WriteLine("Insira o nome do seu personagem: ");
            nome = Console.ReadLine();

            Console.WriteLine("Escolha a classe do seu personagem:");
            Console.WriteLine("1. Artifice - HP: 15; Martelo: dano de concussão 1d10; Bombas: dano de fogo 1d12");
            Console.WriteLine("2. Mago - HP: 10; Mísseis Mágicos: dano mágico 1d6; Choque Elétrico: dano mágico elemental 1d20");
            Console.WriteLine("3. Paladino - HP: 25; Espada Longa: dano de corte 1d8; Banimento Divino: dano mágico sagrado 1d12");
            Console.WriteLine("4. Soldado - HP: 20; Lança: dano perfurante 1d6; Escudo: absorve 1d10 de dano");

            try
            {
                selectOption = int.Parse(Console.ReadLine());
            }
            catch (FormatException erro)
            {
                Console.WriteLine("Detectamos um erro, tente novamente");
                SetupPlayer();
            }

            switch (selectOption)
            {
                case 1:
                    Brancaster.Parte1();
                    Artifice.BatalhaLobo();

                    if (Artifice.hp > 0)
                    {
                        Brancaster.Parte2();
                        Brancaster.PerguntasSobreFogo();
                        Brancaster.Parte3();
                    }

                    Console.Clear();
                    Console.WriteLine("Updates em breve.");
                    Thread.Sleep(5000);
                    MenuPrincipal.GameOver();
                    break;

                case 2:
                    Brancaster.Parte1();
                    Mago.BatalhaLobo();

                    if (Mago.hp > 0)
                    {
                        Brancaster.Parte2();
                        Brancaster.PerguntasSobreFogo();
                        Brancaster.Parte3();
                    }

                    Console.Clear();
                    Console.WriteLine("Updates em breve.");
                    Thread.Sleep(5000);
                    MenuPrincipal.GameOver();
                    break;
            }
        }

    }
}
