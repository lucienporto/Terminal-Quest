using Figgle;
using System;
using System.Net;
using System.Security.Cryptography.X509Certificates;
using System.Threading;
using TerminalQuest.Classes.Personagens;
using TerminalQuest.Classes.Personagens.Heros;
using TerminalQuest.Classes.Personagens.Inimigos;
using static System.Net.Mime.MediaTypeNames;

namespace TerminalQuest.Classes
{
    public class Gaming
    {   
        public static int selectOption = 0;
        private static int idHeroi;
        public static int fugaBatalhas = 0;
        public static int idInimigo = 1;
        public static string nome;

        
        public static void SetupPlayer()
        {
            Console.Clear();
            Console.WriteLine(FiggleFonts.Standard.Render("Terminal Quest"));
            Console.WriteLine("Insira o nome do seu personagem: ");
            nome = Console.ReadLine();
            if (nome == "")
                nome = "Leopoldo";

            Console.WriteLine("\nEscolha a classe do seu personagem:");
            Console.WriteLine("\n1. Artifice - HP: 15; Martelo: dano de concussão 1d10; Bombas: dano de fogo 1d12");
            Console.WriteLine("\n2. Mago - HP: 10; Mísseis Mágicos: dano mágico 1d6; Choque Elétrico: dano mágico elemental 1d20");
            Console.WriteLine("\n3. Monge - HP: 20; Punhos: dano físico 1d4 + nº de ataques; Lança: dano perfurante 1d10");
            Console.WriteLine("\n4. Paladino - HP: 25; Espada Longa: dano de corte 1d8; Banimento Divino: dano mágico sagrado 1d12");
            Console.WriteLine("\n5. ProxyHero - HP: 20; Espada Longa: dano de corte 1d8; Choque Elétrico: dano mágico sagrado 1d20");

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
                    idHeroi = 1;
                    Brancaster.Parte1();
                    Batalha();

                    if (Artifice.hp[0] > 0)
                    {
                        Brancaster.Parte2();
                        Brancaster.Parte3();
                    }

                    Console.Clear();
                    Console.WriteLine("Updates em breve.");
                    Thread.Sleep(5000);
                    MenuPrincipal.GameOver();
                    break;

                case 2:
                    Brancaster.Parte1();
                    Batalha();

                    if (Mago.hp > 0)
                    {
                        Brancaster.Parte2();
                        Brancaster.Parte3();
                    }

                    Console.Clear();
                    Console.WriteLine("Updates em breve.");
                    Thread.Sleep(5000);
                    MenuPrincipal.GameOver();
                    break;

                case 3:
                    Brancaster.Parte1();
                    Batalha();

                    if (Monge.hp > 0)
                    {
                        Brancaster.Parte2();
                        Brancaster.Parte3();
                    }

                    Console.Clear();
                    Console.WriteLine("Updates em breve.");
                    Thread.Sleep(5000);
                    MenuPrincipal.GameOver();
                    break;

                case 4:
                    Brancaster.Parte1();
                    Batalha();

                    if (Paladino.hp > 0)
                    {
                        Brancaster.Parte2();
                        Brancaster.Parte3();
                    }

                    Console.Clear();
                    Console.WriteLine("Updates em breve.");
                    Thread.Sleep(5000);
                    MenuPrincipal.GameOver();
                    break;

                case 5:
                    idHeroi = 5;
                    Brancaster.Parte1();
                    Batalha();
                    Console.WriteLine("Enchendo linguiça");
                    Thread.Sleep(3000);
                    Batalha();
                    break;
            }
        }

        public static void Batalha()
        {
           switch (idHeroi)
            {
                case 1:
                    switch (idInimigo)
                    {
                        case 1:
                            Artifice.BatalhaLobo();
                            idInimigo++;
                            break;

                        case 2:
                            Artifice.BatalhaZumbi();
                            idInimigo++;
                            break;
                    }
                    break;

                case 5:
                    Herois fakeHero = new Herois();
                    fakeHero.Hp = 20;
                    fakeHero.Magias = 5;
                    switch (idInimigo)
                    {
                        case 1:
                            Inimigos lobo = new Inimigos(5);
                            while (lobo.Hp > 0 && fakeHero.Hp > 0)
                            {
                                Console.Clear();
                                fakeHero.StatusBar();

                                Console.WriteLine("\nEscolha sua ação:");
                                Console.WriteLine("\n1.Atacar com a espada");
                                Console.WriteLine("\n2.Usar o choque elétrico");

                                try
                                {
                                    Gaming.selectOption = int.Parse(Console.ReadLine());
                                }
                                catch (FormatException erro)
                                {
                                    Console.WriteLine("Detectamos um erro, tente novamente.");
                                    Batalha();
                                }

                                if (Gaming.selectOption == 1)
                                {
                                    fakeHero.AtacaEspada();
                                    lobo.Hp = lobo.Hp - fakeHero.Damage;
                                }
                                else if (Gaming.selectOption == 2)
                                {
                                    if (fakeHero.Magias > 0)
                                    {
                                        fakeHero.ChoqueEletrico();
                                        lobo.Hp = lobo.Hp - fakeHero.Damage;
                                    }
                                    else
                                    {
                                        Console.WriteLine("A magia brochou!");
                                    }
                                }

                                if (lobo.Hp >= 1)
                                {
                                    lobo.Mordida();
                                    fakeHero.Hp = fakeHero.Hp - lobo.InimigoDamage;
                                }
                                else
                                {
                                    Console.WriteLine("\nO pobre animal se debate no chão enquanto sua vida se esvai. Você faz uma oração rápida e encerra de vez seu sofrimento.");
                                    Console.WriteLine("\nPressione ENTER para continuar.");
                                    Console.ReadLine();
                                    continue;
                                }

                                if (fakeHero.Hp <= 0)
                                {
                                    Console.WriteLine("Você sente as mandíbulas do animal se fechando em seu pescoço enquanto o mundo escurece ao seu redor. O predador faminto teria uma refeição aquela noite.");
                                    Console.WriteLine("\nPressione ENTER para continuar.");
                                    Console.ReadLine();
                                    continue;
                                }
                            }
                            idInimigo++;
                            break;

                        case 2:
                            Inimigos zumbi = new Inimigos(8);
                            while (zumbi.Hp > 0 && fakeHero.Hp > 0)
                            {
                                Console.Clear();
                                fakeHero.StatusBar();

                                Console.WriteLine("\nEscolha sua ação:");
                                Console.WriteLine("\n1.Atacar com a espada");
                                Console.WriteLine("\n2.Usar o choque elétrico");

                                try
                                {
                                    Gaming.selectOption = int.Parse(Console.ReadLine());
                                }
                                catch (FormatException erro)
                                {
                                    Console.WriteLine("Detectamos um erro, tente novamente.");
                                    Batalha();
                                }

                                if (Gaming.selectOption == 1)
                                {
                                    fakeHero.AtacaEspada();
                                    zumbi.Hp = zumbi.Hp - fakeHero.Damage;
                                }
                                else if (Gaming.selectOption == 2)
                                {
                                    if (fakeHero.Magias > 0)
                                    {
                                        fakeHero.ChoqueEletrico();
                                        zumbi.Hp = zumbi.Hp - fakeHero.Damage;
                                    }
                                    else
                                    {
                                        Console.WriteLine("A magia brochou!");
                                    }
                                }

                                if (zumbi.Hp >= 1)
                                {
                                    Random random = new Random();
                                    int ataque = random.Next(1,3);
                                    if (ataque == 1)
                                    {
                                        zumbi.Mordida();
                                        fakeHero.Hp = fakeHero.Hp - zumbi.InimigoDamage;
                                    } else
                                    {
                                        zumbi.Arranha();
                                        fakeHero.Hp = fakeHero.Hp - zumbi.InimigoDamage;
                                    }
                                    
                                }
                                else
                                {
                                    Console.WriteLine("\nO morto-vivo cai no chão emitindo um baque seco. A carcaça reanimada por necromancia já não apresenta perigo.");
                                    Console.WriteLine("\nPressione ENTER para continuar.");
                                    Console.ReadLine();
                                    continue;
                                }

                                if (fakeHero.Hp <= 0)
                                {
                                    Console.WriteLine("Com arranhões e mordidas, o zumbi arranca pedaços e destrói seu corpo. Em seus últimos momentos você se sente patético por ter sido derrotado.");
                                    Console.WriteLine("\nPressione ENTER para continuar.");
                                    Console.ReadLine();
                                    continue;
                                }
                            }
                            idInimigo++;
                            break;
                    }
                    break;
            } 
        }

    }
}
