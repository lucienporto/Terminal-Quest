using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TerminalQuest.Classes.Personagens;

namespace TerminalQuest.Classes
{
    public class Lobo
    {
        public static int loboHP = 10;

        public static void Mordida()
        {
            Random random = new Random();
            int d4 = random.Next(1, 5);

            Artifice.hp = Artifice.hp - d4;
            Mago.hp = Mago.hp - d4;

            Console.WriteLine($"O lobo te ataca com uma mordida, te causando {d4} de dano.");
            Console.WriteLine("\nPressione ENTER para continuar.");
            Console.ReadLine();
        }
    }
}
