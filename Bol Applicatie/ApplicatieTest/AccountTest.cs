using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using Bol_Applicatie;

namespace ApplicatieTest
{
    [TestClass]
    public class AccountTest
    {
        DatabaseKoppeling dbKoppeling = new DatabaseKoppeling();
        Administratie administratie = new Administratie();

        [TestMethod]
        public void AccountAanWinkelwagen()
        {
            Account account = new Account("Frank", 10);
            Product product = new Product("Fiets", "Dit is een heel mooi ding", 20);
            account.AanWinkelWagen(product);
            int expected = 1;
            int actual = account.WinkelWagen.Count;

            Assert.AreEqual(expected, actual, "Product niet aan winkelwagen toegevoegd");
        }

        [TestMethod]
        public void UitWinkelwagen()
        {
            Account account = new Account("Frank", 10);
            Product product = new Product("Fiets", "Dit is een heel mooi ding", 20);
            account.AanWinkelWagen(product);
            account.UitWinkelWagen(product);
            int expected = 0;
            int actual = account.WinkelWagen.Count;

            Assert.AreEqual(expected, actual, "Product niet uit winkelwagen gehaald");
        }

        [TestMethod]
        public void WinkelwagenPrijs()
        {
            Account account = new Account("Frank", 10);
            account.WinkelWagen.Add(new Product("Fiets", "mooi ding", 50));
            account.WinkelWagen.Add(new Product("Auto", "2.0 liter TDI VW Golf", 800));
            int expected = 850;
            int actual = account.GeefWinkelwagenPrijs();

            Assert.AreEqual(expected, actual, "Prijs winkelwagen klopt niet");
        }

        // voor deze test moet wel de database koppeling outcommented worden
        [TestMethod]
        public void BetaalWinkelwagen1()
        {
            Account account = new Account("Frank", 1000);
            account.WinkelWagen.Add(new Product("Fiets", "mooi ding", 50));
            account.WinkelWagen.Add(new Product("Auto", "2.0 liter TDI VW Golf", 800));

            string error = "";
            bool actual = account.BetaalWinkelwagen(out error);
            bool expected = true;

            Assert.AreEqual(expected, actual, "Kan winkelwagen wel betalen");
        }

        [TestMethod]
        public void BetaalWinkelwagen2()
        {
            Account account = new Account("Frank", 100);
            account.WinkelWagen.Add(new Product("Fiets", "mooi ding", 50));
            account.WinkelWagen.Add(new Product("Auto", "2.0 liter TDI VW Golf", 800));

            string error = "";
            bool actual = account.BetaalWinkelwagen(out error);
            bool expected = false;

            Assert.AreEqual(expected, actual, "Kan winkelwagen wel betalen");
        }


    }
}
