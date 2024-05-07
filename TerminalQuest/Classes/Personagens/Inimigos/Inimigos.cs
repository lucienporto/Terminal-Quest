using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static System.Net.Mime.MediaTypeNames;

namespace TerminalQuest.Classes.Personagens.Inimigos
{
    internal class Inimigos
    {
        public Inimigos(int Hp)
        {
            this.Hp = Hp;
        }

        public int Hp;
        public int InimigoDamage;

        public void Mordida()
        {
            if (Gaming.idInimigo == 1)
            {
                Random random = new Random();
                int d4 = random.Next(1, 5);
                InimigoDamage = d4;

                if (d4 <= 3)
                {
                    Console.WriteLine($"\nO lobo avança e morde, causando {d4} de dano.");
                }
                else
                {
                    Console.WriteLine($"\nO lobo salta na sua direção e te ataca, sua mordida causa {d4} de dano.");
                }

                Console.WriteLine("\nPressione ENTER para continuar.");
                Console.ReadLine();
            } else
            {
                Random random = new Random();
                int d6 = random.Next(1, 7);
                InimigoDamage = d6;

                if (d6 <= 3)
                {
                    Console.WriteLine($"\nO zumbi tenta sem muito sucesso cravar os dentes em você, ele causa {d6} de dano.");
                }
                else if ((d6 >= 3) && (d6 <= 5))
                {
                    Console.WriteLine($"\nVocê sente a dor da mordida do morto-vivo. Este ataque causou {d6} de dano.");
                }
                else
                {
                    Console.WriteLine($"\nO zumbi crava os dentes em sua pele em uma mordida fria causando {d6} de dano.");
                }

                Console.WriteLine("\nPressione ENTER para continuar.");
                Console.ReadLine();
            }
        }

        public void Arranha()
        {
            Random random = new Random();
            int d6 = random.Next(1, 7);
            InimigoDamage = d6;

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

        public void EspadaEnferrujada()
        {
            Random random = new Random();
            int d6 = random.Next(1, 7);
            InimigoDamage = d6;

            if (d6 <= 4)
            {
                Console.WriteLine($"\nDe forma desajeitada, o esqueleto brande a espada em sua direção. Seu corte causa {d6} de dano.");
            }
            else
            {
                Console.WriteLine($"\nO golpe foi mais forte do que você esperava e te causa {d6} de dano.");
            }

            Console.WriteLine("\nPressione ENTER para continuar.");
            Console.ReadLine();
        }

        public void Cabeçada()
        {
            Random random = new Random();
            int d4 = random.Next(1, 5);
            InimigoDamage = d4;
            Console.WriteLine($"\nVocê tonteia por um segundo após o esqueleto te dar uma cabeçada com seu elmo podre. O impacto causou {d4} de dano.");

            Console.WriteLine("\nPressione ENTER para continuar.");
            Console.ReadLine();
        }
    }

}

