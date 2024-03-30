using System;

namespace TerminalQuest.Classes.Personagens
{
    public class Paladino
    {
        public static int hp = 25;
        public static int magias = 5;
        public static int potions = 0;
        public static int damage = 0;

        public static void StatusBar()
        {
            Console.WriteLine($"\t\t\tHP: {hp}, Benção restante: {magias}, Poções {potions}");
        }

        public static void AtacaEspada()
        {
            Random random = new Random();

            int d8 = random.Next(1, 9);
            damage = d8;
            Console.WriteLine($"Com um corte preciso, você causa {d8} de dano com sua espada.");
        }

        public static void MagiaDivina()
        {
            Random random = new Random();

            int d12 = random.Next(1, 13);
            damage = d12;
            Console.WriteLine($"Banhando sua espada em uma aura divina, seu ataque causa {d12} de dano.");
            magias--;
        }

        public static void BatalhaLobo()
        {
            while (Lobo.loboHP > 0 && hp > 0)
            {
                Console.Clear();
                StatusBar();

                Console.WriteLine("\nEscolha sua ação:");
                Console.WriteLine("\n1.Atacar com a espada");
                Console.WriteLine("\n2.Usar o banimento divino");

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
                    AtacaEspada();
                    Lobo.loboHP = Lobo.loboHP - damage;
                }
                else if (Gaming.selectOption == 2)
                {
                    if (magias > 0)
                    {
                        MagiaDivina();
                        Lobo.loboHP = Lobo.loboHP - damage;
                    }
                    else
                    {
                        Console.WriteLine("A faz a prece para invocar a magia divina, mas por exaustão ela não tem efeito.");
                    }
                }

                if (Lobo.loboHP >= 1)
                {
                    Lobo.Mordida();
                }
                else
                {
                    Console.WriteLine("\nO pobre animal se debate no chão enquanto sua vida se esvai. Você faz uma oração rápida e encerra de vez seu sofrimento.");
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
