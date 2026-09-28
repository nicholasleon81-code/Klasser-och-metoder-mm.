using System;
using System.Collections.Generic;
using System.Text;

namespace DiceGame.Metoder
{
    public class TarningsHand
    {
        //En privat array du kan tilldela värden
        private Tarning[] tarningar { get; set; } = [];

        //En constructor som omvandlar ett heltal till mängden i vår array, hur många tärningar vi kan hantera
        public TarningsHand(int antalTarningar)
        {
            tarningar = new Tarning[antalTarningar];

            //Du kan förenkla med att skriva tarningar.for och då skapas din egna for-loop till dig
            for (int i = 0; i < tarningar.Length; i++)
            {
                tarningar[i] = new Tarning();
            }
        }
        //Metod som läser in varje tärning
        public void VisaTarningar()
        {
            int index = 0;
            foreach (var item in tarningar)
            {
                ++index;
                Console.WriteLine($"Tärning {index} har värdet: {item.Varde}");

            }
        }
        //Metod som "rullar" alla tärningar i din array
        public void RullaAlla()
        {
            foreach (var tarning in tarningar)
            {
                tarning.Rulla();
            }

            VisaTarningar();
        }

    }
}
