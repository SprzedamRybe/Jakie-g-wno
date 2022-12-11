using System;
using System.Collections.Generic;
using System.Text;

namespace GameRPG
{
    abstract class CharacterCreator : Stats
    {
        public void Creator()
        {
            Console.Write("Podaj imie postaci:");
            name = Console.ReadLine();
            Console.Clear();
            Console.WriteLine($"{name} wybierzz klasę postaci.");
            Console.WriteLine();
            Console.WriteLine("1.Wojowniek (Dużo życia i obrażeń, mała celność.)");
            Console.WriteLine("2.Wojowniek (Średnie życie i obrzażenia, wysoka celność.)");
            Console.WriteLine("3.Wojowniek (Mało życia, dużo obrażeń, średnia celność.)");
            int i;
            bool result = int.TryParse(Console.ReadLine(), out i);

            if(!result || i < 1 || i>3)
            {
                Creator();
            }else
            {
                if(i==1)
                {
                    Worrior();
                }else if(i==2)
                {
                    Archer();
                }else
                {
                    Mage();
                }
            }

        }

        public void Worrior()
        {
            profession = "Wojownik";
            health = 300;
            strenght = 30;
            accuracy = 10;
        }
        public void Archer()
        {
            profession = "Łucznik";
            health = 220;
            strenght = 10;
            accuracy = 20;
        }
        public void Mage()
        {
            profession = "Mag";
            health = 160;
            magicpower = 35;
            accuracy = 10;
        }
    }
}
