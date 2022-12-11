using System;
using System.Collections.Generic;
using System.Text;

namespace GameRPG
{
    class Character : CharacterCreator
    {
        public void Stats()
        {
            Console.WriteLine($"Imie: {name}");
            Console.WriteLine($"Życie: {health}");
            Console.WriteLine($"Klasa: {profession}");
            Console.WriteLine();
            Console.WriteLine("Statystyki:");
            Console.WriteLine($"siła: {strenght}");
            Console.WriteLine($"celność: {accuracy}");
            Console.WriteLine($"moc: {magicpower}");
            Console.WriteLine($"Armor- Fizyczny:{armor} Magiczny:{magicarmor}");
            Console.WriteLine($"Przbicie pancerza- Fizyczny:{armorpenetration} Magiczny:{magicpenetration}");
        }
    }
}
