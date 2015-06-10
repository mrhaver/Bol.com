using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace Bol_Applicatie
{
    public class Account
    {
        private string voornaam;
        private string achternaam;
        private string geslacht;
        private string mailadres;
        private string gebruikersNaam;
        private string wachtwoord;
        private int budget;
        private bool gebannt;
        private bool isBeheerder;
        private List<Product> winkelWagen;

        public string GebruikersNaam
        {
            get { return gebruikersNaam; }
        }

        public int Budget
        {
            get { return budget; }
        }

        public List<Product> WinkelWagen
        {
            get { return winkelWagen; }
            set { winkelWagen = value; }
        }

        public Account(string gebruikersNaam, int budget)
        {
            this.gebruikersNaam = gebruikersNaam;
            this.budget = budget;
            winkelWagen = new List<Product>();
        }

        public bool AanWinkelWagen(Product product)
        {
            foreach(Product p in winkelWagen)
            {
                // als het product nog niet bestaat voeg het dan toe
                if(p.Naam == product.Naam)
                {
                    return false;
                }
            }
            winkelWagen.Add(product);
            return true;
        }

        public bool UitWinkelWagen(Product product)
        {
            foreach(Product p in winkelWagen)
            {
                // als het product gevonden is dan wordt het product uit de winkelwagen gehaald
                if(p.Naam == product.Naam)
                {
                    winkelWagen.Remove(p);
                    return true;
                }
            }
            return false;
        }

        public int GeefWinkelwagenPrijs()
        {
            int totaalPrijs = 0;
            foreach(Product p in winkelWagen)
            {
                totaalPrijs += p.Prijs;
            }
            return totaalPrijs;
        }
    }
}