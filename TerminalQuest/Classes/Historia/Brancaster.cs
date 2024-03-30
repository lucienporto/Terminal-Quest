using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace TerminalQuest.Classes
{
    public class Brancaster
    {
        private static int selectOption = 0;
        public static void Parte1()
        {
            Console.Clear();
            Console.WriteLine("\tA lua cheia brilhava alto no céu enquanto você caminhava com o filho do senhor Torvan, um fazendeiro da região, pela estrada de terra. O garoto de apenas 7 anos, não tinha ferimentos graves, apenas alguns cortes e arranhões mas ainda estava assustado após passar os últimos 3 dias perdido na floresta.");
            Thread.Sleep(2000);
            Console.WriteLine("\n\tEle olha em volta constantemente enquanto treme de medo, frio e fome. Você tenta reconfortá-lo apontando para a pequena casa da fazenda, que já se via à distância, onde seus pais, preocupados, o aguardavam e onde ele estaria seguro para descansar, comer algo quente e esquecer o que ele passou.");
            Thread.Sleep(2000);
            Console.WriteLine("\n\tVocês continuam a caminhar em direção a casa vendo as janelas ilumidas fracamente por velas e então o garoto, adquirindo um súbito animo, exclama bem alto:");
            Thread.Sleep(1000);
            Console.WriteLine("\n\t—Mamãe!");
            Thread.Sleep(2000);
            Console.WriteLine("\n\tE se põe a correr em disparada em direção a casa. Seus pés conheciam aquela estrada de terra, mas ele não sabia do perigo que estava à espreita. Você corre atrás dele e o alcança a tempo de impedir que um lobo o atacasse. O garoto te olha assustado e você o manda correr para casa enquanto lida com a fera, os gritos chamando pela animado mãe, agora só transmitiam medo.");
            Thread.Sleep(2000);
            Console.WriteLine("\n\tVocê olha para o lobo enquanto ele rosna e ameaça te atacar. É notável que aquele animal está em péssimas condições. Está magro, ferido e sem dúvidas já caça sozinho e sem sucesso há algum tempo, mas, apesar do aspecto deplorável do animal, você não pode deixá-lo fugir para atacar outras crianças.");
            Thread.Sleep(1000);
            Console.WriteLine("\nPressione ENTER para continuar");
            Console.ReadLine();
        }

        public static void Parte2()
        {
            Console.Clear();
            
            Console.WriteLine("\tApós derrotar o lobo, você segue para a casa da fazenda. Ao chegar lá, Torvan, com lágrimas de felicidade nos olhos, te agradece diversas vezes pelo resgate de seu filho. Você o alerta sobre o cadáver do lobo na beira da estrada, pega o seu pagamento e se prepara para partir quando o garoto corre em sua direção e te abraça, agradecendo e pede para que você fique para o jantar.");
            Thread.Sleep(2000);
            Console.WriteLine("\nAceitar convite?");
            Console.WriteLine("\n1.Sim");
            Console.WriteLine("\n2.Não");

            try
            {
                selectOption = int.Parse(Console.ReadLine());
            }
            catch(FormatException erro)
            {
                Console.WriteLine("\nDetectamos um erro, tente novamente.");
                Parte2();
            }

            switch (selectOption)
            {
                case 1:
                    Console.WriteLine("\n\tVocê agradece a generosidade do convite e entra acompanhado do garoto enquanto ele diz que quando crescer, quer ser tão corajoso quanto você.");
                    break;

                case 2:
                    Console.WriteLine("\n\tApesar de estar com fome, você diz que não pode ficar, mas antes que possa se virar para ir, o garoto te puxa pela mão para dentro da casa. Parece que você não tem outra escolha a não ser ficar mais um pouco.");
                    break;

                default:
                    Console.WriteLine("\nOpção inválida, tente novamente.");
                    Parte2();
                    break;
            }

            Thread.Sleep(2000);
            Console.WriteLine("\n\tDurante o jantar, enquanto Marya, esposa de Torvan, te conta sobre as brincadeiras do filho, você vê pela janela o céu no horizonte assumir tons alaranjados e consegue distinguir uma fumaça densa subindo para o céu.");
            Thread.Sleep(2000);
            Console.WriteLine("\n\tA resposta era óbvia: FOGO. E naquela direção só poderia significar uma coisa, Brancaster estava em chamas, sua cidade corria perigo.");
            Console.WriteLine("\nPressione ENTER para continuar");
            Console.ReadLine();

            Console.Clear();
            Console.WriteLine("\tVocê se levanta às pressas e corre para pegar seu equipamento. Ao sair, Torvan diz para você pegar o seu cavalo emprestado. Você agradece e sai em disparada, algo em seu coração dizia que algo perverso estava para acontecer e que era preciso chegar lá rápido.\r\n");
            Thread.Sleep(2000);
            Console.WriteLine("\n\tApós uma viagem que pareceu levar muito mais tempo do que deveria, quando você finalmente chega em Brancaster, a população já havia começado o combate ao incêndio. Aqueles que se feriram estavam recebendo os cuidados da curandeira na praça central, enquanto homens e mulheres corriam por todos os lados abastecendo baldes no rio que atravessava a cidade para tentar controlar as chamas.\r\n");
            Thread.Sleep(2000);
            Console.WriteLine("\n\tAo entrar na cidade, você decide perguntar o que aconteceu:");
            Console.WriteLine("\nPressione ENTER para continuar");
            Console.ReadLine();
        }

        public static void PerguntasSobreFogo()
        {
            bool perguntar = false;

            while (perguntar != true)
            {
                Console.Clear();
                Console.WriteLine("Perguntar para quem?");
                Console.WriteLine("\n1.Para uma mulher sentada na praça chorando.");
                Console.WriteLine("\n2.Para um homem que passa por você.");
                Console.WriteLine("\n3.Para a curandeira da cidade.");

                try
                {
                    selectOption = int.Parse(Console.ReadLine());
                }
                catch (FormatException erro)
                {
                    Console.WriteLine("\nDetectamos um erro, tente novamente.");
                    PerguntasSobreFogo();
                }

                switch (selectOption)
                {
                    case 1:
                        Console.WriteLine("\n\tVocê mal consegue distinguir o que ela diz, mas entende que seu marido está ferido. Após um lamento ela aponta um homem deitado ali perto.");
                        Console.WriteLine("\nPerguntar para outra pessoa?");
                        Console.WriteLine("\n1.Sim");
                        Console.WriteLine("\n2.Não");
                        try
                        {
                            selectOption = int.Parse(Console.ReadLine());
                        }
                        catch (FormatException erro)
                        {
                            Console.WriteLine("\nDetectamos um erro, tente novamente.");
                            PerguntasSobreFogo();
                        }

                        if (selectOption == 2)
                        {
                            perguntar = true;
                        }
                        break;

                    case 2:
                        Console.WriteLine("\n\tO homem apenas acena com a cabeça apontando na direção de um ferido e continua em seu passo apressado. Então você percebe o balde em sua mão.");
                        Console.WriteLine("\nPerguntar para outra pessoa?");
                        Console.WriteLine("\n1.Sim");
                        Console.WriteLine("\n2.Não");
                        try
                        {
                            selectOption = int.Parse(Console.ReadLine());
                        }
                        catch (FormatException erro)
                        {
                            Console.WriteLine("\nDetectamos um erro, tente novamente.");
                            PerguntasSobreFogo();
                        }

                        if (selectOption == 2)
                        {
                            perguntar = true;
                        }
                        break;

                    case 3:
                        Console.WriteLine("\n\tSem desviar o olhar de seu paciente atual, ela aponta para um homem deitado ali perto e diz que ele pode te responder, já que tudo começou na loja dele.");
                        Console.WriteLine("\nPerguntar para outra pessoa?");
                        Console.WriteLine("\n1.Sim");
                        Console.WriteLine("\n2.Não");
                        try
                        {
                            selectOption = int.Parse(Console.ReadLine());
                        }
                        catch (FormatException erro)
                        {
                            Console.WriteLine("\nDetectamos um erro, tente novamente.");
                            PerguntasSobreFogo();
                        }

                        if (selectOption == 2)
                        {
                            perguntar = true;
                            Parte3();
                        }
                        break;

                    default:
                        Console.WriteLine("\nOpção inválida, tente novamente.");
                        Parte2();
                        break;
                }
            } 
        }

        public static void Parte3()
        {
            Console.Clear();

            Console.WriteLine("\tVocê vai falar com o homem e logo o reconhece, era o dono da velha loja de tapeçarias, ao perguntar para ele o que aconteceu, ele tosse algumas vezes e diz:");
            Thread.Sleep(2000);
            Console.WriteLine("\n\t—Um velho vestindo manto e capuz entrou na loja, eu não pude ver o rosto dele mas disse que já estava fechado. Ele insistiu dizendo que não iria demorar e que tinha uma proposta para mim, e antes que eu pudesse mandá-lo embora ele me interrompeu e disse que estava interessado no colar que eu usava e estava disposto a me conceder quanto ouro eu achasse justo, não importando a quantidade.");
            Thread.Sleep(2000);
            Console.WriteLine("\n\t—Eu achei aquilo tudo muito estranho e disse que aquele colar já estava na minha família há incontáveis gerações, portanto não iria vendê-lo a um qualquer que começasse a falar absurdos. De repente ele saltou na minha direção e agarrou meu colar, nós lutamos por algum tempo mas ele era mais forte do que aparentava e conseguiu me derrubar, a corrente do meu colar se arrebentou e ele correu para a porta. Antes de sair, ele olhou para mim com desdém e com alguma feitiçaria, colocou fogo na minha loja.");
            Thread.Sleep(2000);
            Console.WriteLine("\n\t—A loja que foi do meu avô, do meu pai, minha e que seria do meu filho. Gerações de trabalho duro que viraram cinzas por causa de um colar...— O homem começou a chorar.");
            Thread.Sleep(2000);
            Console.WriteLine("\n\tVocê se levanta e decide que irá reunir um grupo para encontrar esse velho e fazer ele enfrentar a punição por tal ato vil. Quando você começa a caminhar pensando por onde iria começar e com quem poderia contar, você ouve uma voz te chamando, era Samma, sua vizinha.");
            Thread.Sleep(2000);
            Console.WriteLine("\nPressione ENTER para continuar");
            Console.ReadLine();

            Console.Clear();
            Console.WriteLine($"\t{Gaming.nome}! {Gaming.nome}! Que bom que eu te encontrei, algo terrível aconteceu. Minha filha, Raya foi raptada.");
            Thread.Sleep(2000);
            Console.WriteLine("\n\tAo questionar quem foi, ela diz a mesma exata descrição do homem que roubou e incendiou a loja do tapeceiro.");
            Thread.Sleep(2000);
            Console.WriteLine("\n\tIsso não podia ser coinciência, você sente a mesma sensação que sentiu mais cedo. Você pergunta para Samma em que direção eles foram e ela diz que ele correu em direção ao velho portão que leva para a trilha onde se encontra a Capela Abandonada. Sem perder tempo você monta novamente no cavalo e inicia a perseguição.");
            Thread.Sleep(2000);
            Console.WriteLine("\n\tHá essa altura ele já devia estar chegando na Capela, mas você sabe que pode chegar antes que algo ruim aconteça com a jovem Raya, você tem que conseguir.");
            Thread.Sleep(2000);
            Thread.Sleep(2000);
            Console.WriteLine("\nPressione ENTER para continuar");
            Console.ReadLine();
        }

    }
}
