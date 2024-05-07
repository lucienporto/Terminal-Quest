using static System.Net.Mime.MediaTypeNames;
using System;

namespace TerminalQuest.Classes.Personagens.Heros
{
    internal class Herois
    {
        public Herois() { }

        public double Hp;
        public int Magias;
        public int Potions;
        public int Damage;

        public void StatusBar()
        {
           Console.WriteLine($"\t\t\tHP: {Hp}, Magias restante: {Magias}, Poções: {Potions}");
        }

        public void AtacaEspada()
        {
            Random random = new Random();

            int d8 = random.Next(1, 9);
            Damage = d8;
            Console.WriteLine($"Com um corte preciso, você causa {d8} de dano com sua espada.");
        }

        public void ChoqueEletrico()
        {
            Random random = new Random();

            int d20 = random.Next(1, 21);
            Damage = d20;
            Console.WriteLine($"Um feixe elétrico sai da ponta dos seus dedos causando {d20} de dano.");
            Magias--;
        }
    }
}
