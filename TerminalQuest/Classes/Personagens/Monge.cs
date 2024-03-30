using System;

namespace TerminalQuest.Classes.Personagens
{
    public class Monge
    {
        public static int hp = 20;
        public static int lanca = 5;
        public static int potions = 0;
        public static int damage = 0;

        public static void StatusBar()
        {
            Console.WriteLine($"\t\t\tHP: {hp}, Vitalidade da Lança: {lanca}, Poções {potions}");
        }

        public static void AtacaPunhos()
        {
            Random random = new Random();

            int numeroAtaques = random.Next(1, 7);

            if (numeroAtaques == 1 || numeroAtaques == 3)
            {
                int d4 = random.Next(1, 5);
                damage = d4;
                Console.WriteLine($"Você ataca com seu punho causando {d4} de dano.");
            }
            else if (numeroAtaques == 2 || numeroAtaques ==4)
            {
                int d41 = random.Next(1, 5);
                int d42 = random.Next(1,5);
                damage = d41 + d42;
                Console.WriteLine($"Após uma acrobacia, você ataca com dois socos velozes causando {d41} e {d42} de dano.");
            }
            else
            {
                int d4a = random.Next(1, 5);
                int d4b = random.Next(1, 5);
                int d4c = random.Next(1, 5);
                damage = d4a + d4b + d4c;
                Console.WriteLine($"Utilizando sua agiligidade, você desfere uma sequência de golpes dando {d4a}, {d4b} e {d4c} de dano.");
            }
        }

        public static void AtacaLança()
        {
            Random random = new Random();

            int d10 = random.Next(1, 11);
            damage = d10;
            Console.WriteLine($"Você utiliza uma de suas bombas, a explosão causa {d10} de dano.");
            lanca--;
        }

        public static void BatalhaLobo()
        {
            while (Lobo.loboHP > 0 && hp > 0)
            {
                Console.Clear();
                StatusBar();

                Console.WriteLine("\nEscolha sua ação:");
                Console.WriteLine("\n1.Atacar com os punhos");
                Console.WriteLine("\n2.Usar a lança");

                try
                {
                    Gaming.selectOption = int.Parse(Console.ReadLine());
                }
                catch (FormatException erro)
                {
                    Console.WriteLine("Detectamos um erro, tente novamente.");
                    BatalhaLobo();
                }

                if (Gaming.selectOption == 1)
                {
                    AtacaPunhos();
                    Lobo.loboHP = Lobo.loboHP - damage;
                }
                else if (Gaming.selectOption == 2)
                {
                    if (lanca > 0)
                    {
                        AtacaLança();
                        Lobo.loboHP = Lobo.loboHP - damage;
                    }
                    else
                    {
                        Console.WriteLine("Apesar dos ornamentos impedirem ela de se partir, sua lança está quebrada e inutilizada para batalhas.");
                    }
                }

                if (Lobo.loboHP >= 1)
                {
                    Lobo.Mordida();
                }
                else
                {
                    Console.WriteLine("\nO pobre animal se debate no chão enquanto sua vida se esvai. Você recita um mantra enquanto aplica um último golpe para encerrar de vez seu sofrimento.");
                    Console.WriteLine("\nPressione ENTER para continuar.");
                    Console.ReadLine();
                    continue;
                }

                if (hp <= 0)
                {
                    Console.WriteLine("Você sente as mandíbulas do animal se fechando em seu pescoço enquanto o mundo escurece ao seu redor. O predador faminto teria uma refeição aquela noite.");
                    Console.WriteLine("\nPressione ENTER para continuar.");
                    Console.ReadLine();
                    continue;
                }
            }
        }
    }
}
