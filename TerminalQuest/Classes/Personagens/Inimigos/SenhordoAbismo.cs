using System;
using TerminalQuest.Classes.Personagens;

namespace TerminalQuest.Classes
{
    public class SenhorDoAbismo
    {
        public static int loboHP = 5;

        public static void Mordida()
        {
            Random random = new Random();
            int d4 = random.Next(1, 5);

            Artifice.hp[0] = Artifice.hp[0] - d4;
            Mago.hp = Mago.hp - d4;
            Paladino.hp = Paladino.hp - d4;
            Monge.hp = Monge.hp - d4;

            if (d4 <= 2)
            {
                Console.WriteLine($"\nA fera te ataca com uma mordida fraca, causando {d4} de dano.");
            }
            else if (d4 == 3)
            {
                Console.WriteLine($"\nO lobo avança e morde com força, te causando {d4} de dano.");
            } else
            {
                Console.WriteLine($"\nO lobo salta na sua direção e te ataca, sua mordida causa {d4} de dano.");
            }

            Console.WriteLine("\nPressione ENTER para continuar.");
            Console.ReadLine();
        }
    }
}
