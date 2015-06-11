using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace Bol_Applicatie
{
    public class Categorie
    {
        // fields
        int categorieNummer;
        int bovenCategorie;
        string categorieNaam;

        public int CategorieNummer
        {
            get { return categorieNummer; }
        }

        public int BovenCategorie
        {
            get { return bovenCategorie; }
        }

        public string CategorieNaam
        {
            get { return categorieNaam; }
        }

        // constructors
        public Categorie(int categorieNummer, int bovenCategorie, 
            string categorieNaam)
        {
            this.categorieNummer = categorieNummer;
            this.bovenCategorie = bovenCategorie;
            this.categorieNaam = categorieNaam;
        }

        public override string ToString()
        {
            return categorieNaam;
        }
    }
}