using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace Bol_Applicatie
{
    public class Account
    {
        private Administratie administratie;
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
        private List<Product> verlanglijst;

        public string GebruikersNaam
        {
            get { return gebruikersNaam; }
        }

        public int Budget
        {
            get { return budget; }
            set { budget = value; }
        }

        public List<Product> WinkelWagen
        {
            get { return winkelWagen; }
            set { winkelWagen = value; }
        }

        public List<Product> Verlanglijst
        {
            get { return verlanglijst; }
            set { verlanglijst = value; }
        }

        public Account(string gebruikersNaam, int budget)
        {
            administratie = new Administratie();
            this.gebruikersNaam = gebruikersNaam;
            this.budget = budget;
            winkelWagen = new List<Product>();
            verlanglijst = administratie.DBKoppeling.GeefVerlanglijst(this);
        }

        // winkelwagen is niet gekoppeld aan de database
        // als iemand uitlogt dan gaat alles uit de winkelwagen
        #region Winkelwagen
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
        #endregion 

        // account meegeven voor databasekoppeling
        public bool AanVerlanglijst(Account account, Product product, out string error)
        {
            // als het product al in de verlanglijst zit kan deze er niet aan toegevoegd worden
            foreach(Product p in verlanglijst)
            {
                if(p.Naam == product.Naam)
                {
                    error = "Het product staat al in de verlanglijst";
                    return false;
                }
            }
            if(administratie.DBKoppeling.AanVerlanglijst(account, product))
            {
                error = "";
                Verlanglijst.Add(product);
                return true;
            }
            else
            {
                error = "Product kon niet in de database worden toegevoegd";
                return false;
            }
        }

        // haal voor een bepaald product voor een bepaald account een product uit de verlanglijst
        // (uit de database)
        public bool UitVerlanglijst(Account account, Product product)
        {
            if(administratie.DBKoppeling.UitVerlanglijst(account, product))
            {
                verlanglijst.Remove(product);
                return true;
            }
            else
            {
                return false;
            }
        }

        // afrekenen van een winkelwagen
        public bool BetaalWinkelwagen(out string error)
        {
            error = "";
            if (this.WinkelWagen.Count != 0)
            {
                // als de persoon genoeg budget heeft dan haal de kosten van de winkelwagen van het budget af
                if (this.Budget >= this.GeefWinkelwagenPrijs())
                {
                    this.Budget -= this.GeefWinkelwagenPrijs();
                    administratie.DBKoppeling.UpdateBudget(this, this.Budget);
                    return true;
                }
                else
                {
                    error = "U heeft niet voldoende budget";
                    return false;

                }
            }
            else
            {
                error = "Nog geen producten in de winkelwagen";
                return false;
            }
        }
    }
}