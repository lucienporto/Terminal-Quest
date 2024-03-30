using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TerminalQuest.Classes.Personagens
{
    internal class Mago
    {
        public static int hp = 10;
        public static int magias = 5;
        public static int potions = 0;
        public static int damage = 0;

        public static void StatusBar()
        {
            Console.WriteLine($"\t\t\tHP: {hp}, Mana restante: {magias}, Poções {potions}");
        }

        public static void MisseisMagicos()
        {
            Random random = new Random();

            int d6 = random.Next(1, 7);
            damage = d6;
            Console.WriteLine($"Você dispara um de seus mísseis mágicos causando {d6} de dano.");
        }

        public static void ChoqueEletrico()
        {
            Random random = new Random();

            int d20 = random.Next(1, 21);
            damage = d20;
            Console.WriteLine($"Um feixe elétrico sai da ponta dos seus dedos causando {d20} de dano.");
            magias--;
        }

        public static void BatalhaLobo()
        {
            while (Lobo.loboHP > 0 && hp > 0)
            {
                Console.Clear();
                StatusBar();

                Console.WriteLine("\nEscolha sua ação:");
                Console.WriteLine("\n1.Atacar com mísseis mágicos");
                Console.WriteLine("\n2.Atacar com choque elétrico");

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
                    MisseisMagicos();
                    Lobo.loboHP = Lobo.loboHP - damage;
                }
                else if (Gaming.selectOption == 2)
                {
                    if (magias > 0)
                    {
                        ChoqueEletrico();
                        Lobo.loboHP = Lobo.loboHP - damage;
                    }
                    else
                    {
                        Console.WriteLine("Você tenta disparar um choque elétrico em seu oponente, mas seu mana está totalmente drenado.");
                    }
                }

                if (Lobo.loboHP >= 1)
                {
                    Lobo.Mordida();
                }
                else
                {
                    Console.WriteLine("\nO pobre animal se debate no chão enquanto sua vida se esvai. Você usa sua magia para encerrar de vez seu sofrimento.");
                    Console.WriteLine("\nPressione ENTER para continuar.");
                    Console.ReadLine();
                    continue;
                }

                if (hp <= 0)
                {
                    Console.WriteLine("Você sente as mandíbulas do animal se fechando em seu pescoço enquanto o mundo escurece ao seu redor e você se entrega a uma morte patética. O predador faminto teria uma refeição aquela noite.");
                    Console.WriteLine("\nPressione ENTER para continuar.");
                    Console.ReadLine();
                    continue;
                }
            }
        }
    }
}
