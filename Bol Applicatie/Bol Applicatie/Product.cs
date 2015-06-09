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

        public string Naam
        {
            get { return naam; }
        }

        public string Beschrijving
        {
            get { return beschrijving; }
        }

        public Product(string naam, string beschrijving)
        {
            this.naam = naam;
            this.beschrijving = beschrijving;
        }

        public override string ToString()
        {
            return "Productnaam: " + naam;
        }
    }
}