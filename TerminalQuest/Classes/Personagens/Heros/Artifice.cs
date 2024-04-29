using System;

namespace TerminalQuest.Classes.Personagens
{
    public class Artifice
    {
        public static int[] hp = {15, 21, 30, 43, 62, 89}; //O hp aumenta em 45% a cada batalha.
        public static int bombas = 5;
        public static int potions = 0;
        public static int damage;

        public static void StatusBar()
        {
            Console.WriteLine($"\t\t\tHP: {hp[0]}, Bombas restantes: {bombas}, Poções {potions}");
        }

        public static void AtacaMartelo()
        {
            Random random = new Random();

            int d10 = random.Next(1, 11);
            damage = d10;
            Console.WriteLine($"Você desfere um golpe com seu martelo causando {d10} de dano.");
        }

        public static void AtacaBombas()
        {
            Random random = new Random();

            int d12 = random.Next(1, 13);
            damage = d12;
            Console.WriteLine($"Você utiliza uma de suas bombas, a explosão causa {d12} de dano.");
            bombas--;
        }
        
        public static void BatalhaLobo()
        {
            while (Lobo.loboHP > 0 && hp[0] > 0)
            {
                Console.Clear();
                StatusBar();

                Console.WriteLine("\nEscolha sua ação:");
                Console.WriteLine("\n1.Atacar com o martelo");
                Console.WriteLine("\n2.Usar uma bomba");

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
                    AtacaMartelo();
                    Lobo.loboHP = Lobo.loboHP - damage;
                }
                else if (Gaming.selectOption == 2)
                {
                    if (bombas > 0)
                    {
                        AtacaBombas();
                        Lobo.loboHP = Lobo.loboHP - damage;
                    }
                    else
                    {
                        Console.WriteLine("Você procura em seu cinto por suas bombas, mas já usou todas elas.");
                    }
                }

                if (Lobo.loboHP >= 1)
                {
                    Lobo.Mordida();
                }
                else
                {
                    Console.WriteLine("\nO pobre animal se debate no chão enquanto sua vida se esvai. Você aplica um último golpe com seu martelo e encerra de vez seu sofrimento.");
                    Console.WriteLine("\nPressione ENTER para continuar.");
                    Console.ReadLine();
                    continue;
                }

                if (hp[0] <= 0)
                {
                    Console.WriteLine("Você sente as mandíbulas do animal se fechando em seu pescoço enquanto o mundo escurece ao seu redor. O predador faminto teria uma refeição aquela noite.");
                    Console.WriteLine("\nPressione ENTER para continuar.");
                    Console.ReadLine();
                    continue;
                }
            }
        }

        public static void BatalhaZumbi()
        {
            while (Zumbi.zumbiHP > 0 && hp[0] > 0)
            {
                Console.Clear();
                StatusBar();

                Console.WriteLine("\nEscolha sua ação:");
                Console.WriteLine("\n1.Atacar com o martelo");
                Console.WriteLine("\n2.Usar uma bomba");
                //Console.WriteLine("\n3.Beber uma poção");

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
                    AtacaMartelo();
                    Zumbi.zumbiHP = Zumbi.zumbiHP - damage;
                }
                else if (Gaming.selectOption == 2)
                {
                    if (bombas > 0)
                    {
                        AtacaBombas();
                        Zumbi.zumbiHP = Zumbi.zumbiHP - damage;
                    }
                    else
                    {
                        Console.WriteLine("Você procura em seu cinto por suas bombas, mas já usou todas elas.");
                    }
                }

                if (Zumbi.zumbiHP >= 1)
                {
                    Random random = new Random();
                    int ataque = random.Next(0,2);
                    
                    if (ataque == 0)
                    {
                        Zumbi.Arranhar();
                    } else
                    {
                        Zumbi.Mordida();
                    }
                }
                else
                {
                    Console.WriteLine("\nO morto-vivo cai no chão emitindo um baque seco. A carcaça reanimada por necromancia já não apresenta perigo.");
                    Console.WriteLine("\nPressione ENTER para continuar.");
                    Console.ReadLine();
                    continue;
                }

                if (hp[0] <= 0)
                {
                    Console.WriteLine("Com arranhões e mordidas, o zumbi arranca pedaços e destrói seu corpo. Em seus últimos momentos você se sente patético por ter sido derrotado.");
                    Console.WriteLine("\nPressione ENTER para continuar.");
                    Console.ReadLine();
                    continue;
                }
            }
        }
    }
}
