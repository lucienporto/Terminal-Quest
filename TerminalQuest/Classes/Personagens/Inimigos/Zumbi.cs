using System;
using TerminalQuest.Classes.Personagens;

namespace TerminalQuest.Classes
{
    public class Zumbi
    {
        public static int zumbiHP = 8;

        public static void Mordida()
        {
            Random random = new Random();
            int d6 = random.Next(1, 7);

            Artifice.hp[0] = Artifice.hp[0] - d6;
            Mago.hp = Mago.hp - d6;
            Paladino.hp = Paladino.hp - d6;
            Monge.hp = Monge.hp - d6;

            if (d6 <= 3)
            {
                Console.WriteLine($"\nO zumbi tenta sem muito sucesso cravar os dentes em você, ele causa {d6} de dano.");
            }
            else if ((d6 >= 3) && (d6 <= 5))
            {
                Console.WriteLine($"\nVocê sente a dor da mordida do morto-vivo. Este ataque causou {d6} de dano.");
            } else
            {
                Console.WriteLine($"\nO zumbi crava os dentes em sua pele em uma mordida fria causando {d6} de dano.");
            }

            Console.WriteLine("\nPressione ENTER para continuar.");
            Console.ReadLine();
        }

        public static void Arranhar()
        {
            Random random = new Random();
            int d6 = random.Next(1, 7);

            Artifice.hp[0] = Artifice.hp[0] - d6;
            Mago.hp = Mago.hp - d6;
            Paladino.hp = Paladino.hp - d6;
            Monge.hp = Monge.hp - d6;

            if (d6 <= 3)
            {
                Console.WriteLine($"\nO zumbi te arranha com suas unhas podres causando {d6} de dano.");
            }
            else
            {
                Console.WriteLine($"\nAs unhas quebradas do zumbi te arranham com força causando {d6} de dano.");
            }

            Console.WriteLine("\nPressione ENTER para continuar.");
            Console.ReadLine();
        }
    }
}
