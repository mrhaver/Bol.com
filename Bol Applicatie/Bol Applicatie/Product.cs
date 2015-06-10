using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace Bol_Applicatie
{
    public class Product
    {
        // fields
        private string naam;
        private string beschrijving;
        private int prijs;

        public string Naam
        {
            get { return naam; }
        }

        public string Beschrijving
        {
            get { return beschrijving; }
        }

        public int Prijs
        {
            get { return prijs; }
        }

        public Product(string naam, string beschrijving, int prijs)
        {
            this.naam = naam;
            this.beschrijving = beschrijving;
            this.prijs = prijs;
        }

        public override string ToString()
        {
            return "Productnaam: " + naam;
        }
    }
}