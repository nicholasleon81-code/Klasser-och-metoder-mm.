using System;
using System.Collections.Generic;
using System.Text;

namespace DiceGame.Metoder
{
    public class Tarning
    {
        //Object som har ett privat internal värde som inte kan ändras på andra ställen
        //Du kan välja att set ska vara antingen Privat eller public så du kan ändra värde på den lite överallt eller ej
        public int Varde { get; private set; }

        //(ctor) för att VS ska skapa enkla "constructors" självt. Dem är bara guider för vad dina klasser kan göra
        public Tarning()
        {
            
        }

        public Tarning(int Varde)
        {
            //Varde kan nu få ett exakt värde för vad vi vill ge den
            this.Varde = Varde;

        }
        

        //Enkel Random number generator Metod
        public void Rulla()
        {
            int nyttSlumpMassigtVärde = Random.Shared.Next(1,7);
            Varde = nyttSlumpMassigtVärde;
        }

    }
}
