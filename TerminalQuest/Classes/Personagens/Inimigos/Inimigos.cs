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
                int d4 = random.Next(0, 5);
                InimigoDamage = d4;

                if (d4 == 0)
                {
                    Console.WriteLine($"\nO lobo faminto avança e tenta te morder. Ele solta um grunhido seguido de um rosnado ao falhar.");
                } else if ((d4 >= 1) && (d4 <= 3))
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
                int d6 = random.Next(0, 7);
                InimigoDamage = d6;

                if (d6 == 0)
                {
                    Console.WriteLine("\nO morto-vivo tenta te abocanhar, mas você consegue evadir o ataque.");
                } else if ((d6 >= 1) && (d6 <= 3))
                {
                    Console.WriteLine($"\nO zumbi tenta sem muito sucesso cravar os dentes em você, ele causa {d6} de dano.");
                } else if ((d6 == 4) || (d6 == 5))
                {
                    Console.WriteLine($"\nVocê sente a dor da mordida do morto-vivo. Este ataque causou {d6} de dano.");
                } else
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
            int d6 = random.Next(0, 7);
            InimigoDamage = d6;

            if (d6 == 0)
            {
                Console.WriteLine($"\nO zumbi tenta te agarrar, mas não obtém sucesso.");
            } else if ((d6 >= 1) && (d6 <= 5))
            {
                Console.WriteLine($"\nO zumbi te arranha com suas unhas podres causando {d6} de dano.");
            } else
            {
                Console.WriteLine($"\nAs unhas quebradas do zumbi te arranham com força causando {d6} de dano.");
            }

            Console.WriteLine("\nPressione ENTER para continuar.");
            Console.ReadLine();
        }

        public void EspadaEnferrujada()
        {
            Random random = new Random();
            int d6 = random.Next(0, 7);
            InimigoDamage = d6;

            if (d6 == 0)
            {
                Console.WriteLine($"\nA espada enferrujada corta o ar e nada mais além disso.");
            } else if ((d6 >= 1) && (d6 <= 4))
            {
                Console.WriteLine($"\nDe forma desajeitada, o esqueleto brande a espada em sua direção. Seu corte causa {d6} de dano.");
            } else
            {
                Console.WriteLine($"\nO golpe foi mais forte do que você esperava e te causa {d6} de dano.");
            }

            Console.WriteLine("\nPressione ENTER para continuar.");
            Console.ReadLine();
        }

        public void Cabeçada()
        {
            Random random = new Random();
            int d4 = random.Next(0, 5);
            InimigoDamage = d4;
            if(d4 == 0)
            {
                Console.WriteLine("\nO esqueleto salta na sua direção com a cabeça abaixa tentando usar seu elmo como arma. Ele erra a cabeçada.");
            } else
            {
                Console.WriteLine($"\nVocê tonteia por um segundo após o esqueleto te dar uma cabeçada com seu elmo de metal. O impacto causou {d4} de dano.");
            }
            Console.WriteLine("\nPressione ENTER para continuar.");
            Console.ReadLine();
        }

        public void Tacape()
        {
            Random random = new Random();
            int d8 = random.Next(0, 9);
            InimigoDamage = d8;
            if (d8 == 0)
            {
                Console.WriteLine($"\nO goblin agita o tacape com violência, mas mesmo assim erra o ataque.");
            } else if (d8 <= 3)
            {
                Console.WriteLine($"\nO goblin tenta te acertar, mas o golpe sai desajeitado. Você recebe apenas {d8} de dano.");
            } else if ((d8 >= 4) && (d8 <= 7))
            {
                Console.WriteLine($"\nEle te acerta com uma golpe certeiro que te faz perder o equilíbrio por um instante. Este ataque causou {d8} de dano.");
            } else
            {
                Console.WriteLine($"\nUsando toda a sua força, o goblin te ataca com o tacape. Sua visão fica turva por alguns segundos após levar {d8} de dano.");
            }

            Console.WriteLine("\nPressione ENTER para continuar.");
            Console.ReadLine();
        }

        public void Faca()
        {
            Random random = new Random();
            int d6 = random.Next(0, 7);
            InimigoDamage = d6;
            if (d6 == 0)
            {
                Console.WriteLine($"\nO goblin te ataca com a faca, mas ele errou o ataque.");
            } else if ((d6 >= 1) && (d6 <= 5))
            {
                Console.WriteLine($"\nMostrando um bom manejo de sua faca, o goblin consegue te causar um corte que proporciona {d6} de dano.");
            } else
            {
                Console.WriteLine($"\nEnquanto solta uma risada maligna, o goblin finca a faca em você causando {d6} de dano.");
            }

            Console.WriteLine("\nPressione ENTER para continuar.");
            Console.ReadLine();
        }

        public void MachadoGrande()
        {
            Random random = new Random();
            int d12 = random.Next(0, 13);
            InimigoDamage = d12;
            if (d12 == 0)
            {
                Console.WriteLine($"\nO machado do orc passa cortando o ar acima da sua cabeça e emitindo um assovio sinistro. Você desviou por pouco do ataque.");
            } else if ((d12 >= 1) && (d12 <= 6))
            {
                Console.WriteLine($"\nO orc te ataca com seu machado. Você sente que o ataque foi fraco e causou apenas {d12} de dano.");
            } else if ((d12 >= 7) && (d12 <= 10))
            {
                Console.WriteLine($"\nO orc desfere um ataque forte contra você, te causando {d12} de dano.");
            } else
            {
                Console.WriteLine($"\nO machado desce em sua direção em um golpe poderoso enquanto o orc emite um grito furioso. Você sente a dor dos {d12} de dano causados.");
            }

            Console.WriteLine("\nPressione ENTER para continuar.");
            Console.ReadLine();
        }

        public void PunhosDeAço()
        {
            Random random = new Random();
            int d12 = random.Next(0, 13);
            InimigoDamage = d12;
            if (d12 == 0)
            {
                Console.WriteLine($"\nO golem desfere um golpe em sua direção. Você consegue desviar a tempo de evitar o impacto.");
            }
            else if ((d12 >= 1) && (d12 <= 6))
            {
                Console.WriteLine($"\nO golem causa {d12} de dano ao te acertar com um tapa.");
            }
            else if ((d12 >= 7) && (d12 <= 10))
            {
                Console.WriteLine($"\nVocê geme de dor ao sentir o impacto de um soco que te causou {d12} de dano.");
            }
            else
            {
                Console.WriteLine($"\nCom um golpe certeiro que te empurra para longe, o golem te acerta um soco que causa {d12} de dano.");
            }

            Console.WriteLine("\nPressione ENTER para continuar.");
            Console.ReadLine();
        }

        public void LancaChamas()
        {
            Random random = new Random();
            int d10 = random.Next(0, 11);
            InimigoDamage = d10;
            if ((d10 >= 1) && (d10 <= 4))
            {
                Console.WriteLine($"\nA chama não te acerta diretamente, mas o calor é tamanho que te causa {d10} de dano.");
            }
            else if ((d10 >= 5) && (d10 <= 8))
            {
                Console.WriteLine($"\nA labareda do lança-chamas te acerta. Por sorte você teve apenas queimaduras leves que te causam {d10} de dano.");
            }
            else
            {
                Console.WriteLine($"\nO golem se aproxima e dispara seu lança-chamas em sua direção. Você fica com queimaduras graves que te causam {d10} de dano.");
            }

            Console.WriteLine("\nPressione ENTER para continuar.");
            Console.ReadLine();
        }

        public void MagiaGelada()
        {
            Random random = new Random();
            int d8 = random.Next(1, 9);
            InimigoDamage = d8;
            if ((d8 >= 1) && (d8 <= 4))
            {
                Console.WriteLine($"\nVocê sente o ar frio ao seu redor quando o estilhaço de uma estaca de gelo te atinge causando {d8} de dano.");
            }
            else if ((d8 >= 5) && (d8 <= 7))
            {
                Console.WriteLine($"\nA estaca de gelo fica cravada em seu corpo por alguns instantes antes de derreter. Ela te causa {d8} de dano.");
            }
            else
            {
                Console.WriteLine($"\nO bruxo lança uma chuva de estacas de gelo em sua direção deixando o ar gelado. As que atingem o alvo causam {d8} de dano.");
            }

            Console.WriteLine("\nPressione ENTER para continuar.");
            Console.ReadLine();
        }

        public void EsferaAcida()
        {
            Random random = new Random();
            int d12 = random.Next(1, 13);
            InimigoDamage = d12;
            if ((d12 >= 1) && (d12 <= 4))
            {
                Console.WriteLine($"\nO bruxo lança uma esfera de ácido, você desvia mas ainda assim é atingido por respingos que causam {d12} de dano.");
            }
            else if ((d12 >= 5) && (d12 <= 10))
            {
                Console.WriteLine($"\nA esfera de ácido te atinge em cheio causando {d12} de dano.");
            }
            else
            {
                Console.WriteLine($"\nConcentrando bastante de seu poder o bruxo lança uma grande esfera de ácido. Você sente sua pele queimando e recebe {d12} de dano.");
            }

            Console.WriteLine("\nPressione ENTER para continuar.");
            Console.ReadLine();
        }

        public void GrandeEspada()
        {
            Random random = new Random();
            int d20 = random.Next(0, 21);
            InimigoDamage = d20;

            if(Gaming.idInimigo == 10)
            {
                if (d20 == 0 || d20 == 1)
                {
                    Console.WriteLine($"\nO cavaleiro agita a espada de forma ameaçadora enquanto te observa. O ataque foi apenas um blefe.");
                }
                else if ((d20 >= 2) && (d20 <= 6))
                {
                    Console.WriteLine($"\nO cavaleiro investe contra você e te acerta com o punho da espada, causando assim {d20} de dano.");
                }
                else if ((d20 >= 7) && (d20 <= 12))
                {
                    Console.WriteLine($"\nApesar do tamanho descomunal da espada, o cavaleiro te ataca com um corte rápido que te causa {d20} de dano.");
                }
                else if ((d20 >= 13) && (d20 <= 18))
                {
                    Console.WriteLine($"\nApós simular um ataque e ver para onde você iria desviar, o cavaleiro ataca de verdade e te acerta com sua espada causando {d20} de dano.");
                }
                else
                {
                    Console.WriteLine($"\nCom um golpe veloz e devastador, o cavaleiro te acerta com sua espada. Você sente a lâmina entrando em seu corpo e causando {d20} de dano.");
                }
            } else
            {
                if (d20 == 0 || d20 == 1)
                {
                    Console.WriteLine($"\nSeu inimigo agita a espada de forma ameaçadora enquanto te observa. O ataque foi apenas um blefe.");
                }
                else if ((d20 >= 2) && (d20 <= 6))
                {
                    Console.WriteLine($"\nO Senhor do Abismo investe contra você e te acerta com o punho da espada, causando assim {d20} de dano.");
                }
                else if ((d20 >= 7) && (d20 <= 12))
                {
                    Console.WriteLine($"\nEm um golpe ágil com a espada, seu oponente te ataca causando {d20} de dano com um corte.");
                }
                else if ((d20 >= 13) && (d20 <= 18))
                {
                    Console.WriteLine($"\nApós simular um ataque e ver para onde você iria desviar, o Senhor do Abismo ataca de verdade e te acerta com sua espada causando {d20} de dano.");
                }
                else
                {
                    Console.WriteLine($"\nCom um golpe veloz e devastador, seu inimigo te acerta com sua espada. Você sente que a lâmina vai fundo dentro do seu corpo e te causa {d20} de dano.");
                }
            }

            

            Console.WriteLine("\nPressione ENTER para continuar.");
            Console.ReadLine();
        }

        public void MagiaTrevas()
        {
            Random random = new Random();
            int d20 = random.Next(1, 21);
            InimigoDamage = d20;

            if(Gaming.idInimigo == 10)
            {
                if ((d20 >= 1) && (d20 <= 10))
                {
                    Console.WriteLine($"\nO cavaleiro lança uma esfera de energia das trevas em você que te causa {d20} de dano.");
                }
                else if ((d20 >= 11) && (d20 <= 18))
                {
                    Console.WriteLine($"\nA magia das trevas se divide em várias projéteis menores tornando difícil espacar. Você recebe {d20} de dano.");
                }
                else
                {
                    Console.WriteLine($"\nAs sombras recaem sobre a sala enquanto o cavaleiro concentra seu poder. Ao final ele dispara em velocidade surpreendente uma grande esfera de trevas que te causa {d20} de dano.");
                }
            }
            else
            {
                if ((d20 >= 1) && (d20 <= 10))
                {
                    Console.WriteLine($"\nSeu inimigo lança uma esfera de energia das trevas em você que te causa {d20} de dano.");
                }
                else if ((d20 >= 11) && (d20 <= 18))
                {
                    Console.WriteLine($"\nA magia das trevas se divide em várias projéteis menores tornando difícil espacar. Você recebe {d20} de dano.");
                }
                else
                {
                    Console.WriteLine($"\nAs sombras recaem sobre a sala enquanto o Senhor do Abismo concentra seu poder em um ataque massivo. Ele dispara uma grande esfera de trevas impossível de desviar e que te causa {d20} de dano.");
                }
            }

            Console.WriteLine("\nPressione ENTER para continuar.");
            Console.ReadLine();
        }

        public void FogoInfernal()
        {
            Random random = new Random();
            int d30 = random.Next(15, 31);
            InimigoDamage = d30;

            if ((d30 >= 15) && (d30 <= 20))
            {
                Console.WriteLine($"\nVocê sente o calor aumentando na sala e percebe o fogo azul nas mãos do Senhor do Abismo. Ele atira em sua direção e te causa {d30} de dano.");
            }
            else if ((d30 >= 21) && (d30 <= 25))
            {
                Console.WriteLine($"\nO Senhor do Abismo dispara uma rajada de chamas azuis em sua direção. Você desvia de algumas e outras te acertam e causam {d30} de dano.");
            }
            else if ((d30 >= 26) && (d30 <= 28))
            {
                Console.WriteLine($"\nO Senhor do Abismo concentra seu fogo infernal em uma esfera na palma mão e depois arremessa em você. Ao te atingir, a esfera explode e causa {d30} de dano.");
            }
            else
            {
                Console.WriteLine($"\nO calor toma conta de todo o ambiente enquanto labaredas de fogo azul surgem por todos os lado. Com um comando do Senhor do Abismo, todas vão em sua direção e te causam graves queimaduras. Você recebe {d30} de dano.");
            }

            Console.WriteLine("\nPressione ENTER para continuar.");
            Console.ReadLine();
        }

        public void MarteloDeGuerra()
        {
            Random random = new Random();
            int d20 = random.Next(1, 21);
            InimigoDamage = 999;

            if ((d20 > 0) && (d20 <= 10))
            {
                Console.WriteLine($"\nO Avatar da Justiça te observa atentamente enquanto você o ataca, mas permanece imóvel.");
            }
            else if ((d20 >= 11) && (d20 <= 15))
            {
                Console.WriteLine($"\nSeu inimigo zomba de você e diz que você não tem chances de derrotar \"aquele que está preso no abismo\".");
            }
            else if ((d20 >= 16) && (d20 <= 19))
            {
                Console.WriteLine($"\nO Avatar da Justiça solta uma grande gargalhada enquanto te incentiva a continuar te atacando.");
            }
            else
            {
                Console.WriteLine($"\nFinalmente o Avatar da Justiça se move. Ele pega seu martelo de guerra e, com desdém, diz que você é indigno de sua benção. Ele te ataca, causando {InimigoDamage} de dano.");
            }

            Console.WriteLine("\nPressione ENTER para continuar.");
            Console.ReadLine();
        }
    }

}

