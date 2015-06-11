using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using Bol_Applicatie;

namespace ApplicatieTest
{
    // Voor deze testcases is er wel connectie met de database nodig! 

    [TestClass]
    public class DatabaseTest
    {

        DatabaseKoppeling dbKoppeling = new DatabaseKoppeling();
        Administratie administratie = new Administratie();

        // hier kun je testen of je uberhaubt wel verbinding hebt met de database
        [TestMethod]
        public void Connect()
        {
            dbKoppeling = new DatabaseKoppeling();
            bool isConnected;
            if(dbKoppeling.TestConnectie())
            {
                isConnected = true;
            }
            else
            {
                isConnected = false;
            }

            bool expected = true;
            bool actual = isConnected;

            Assert.AreEqual(expected, actual, "Er is geen verbinding");
        }

        [TestMethod]
        public void GeefGebruiker1()
        {
            Account account = dbKoppeling.GeefAccount("Joop");

            string expected = "Joop";
            string actual = account.GebruikersNaam;
            Assert.AreEqual(expected, actual, "De namen zijn niet gelijk");
        }

        [TestMethod]
        public void GeefGebruiker2()
        {
            Account account = dbKoppeling.GeefAccount("joop");

            Account expected = null;
            Account actual = dbKoppeling.GeefAccount("joop");
            Assert.AreEqual(expected, actual, "gebruikersnaam is niet null");
        }

        [TestMethod]
        public void LogIn1()
        {
            string gebruikersNaam = "Joop";
            string wachtwoord = "Joop";
            string error = "";

            dbKoppeling = new DatabaseKoppeling();
            bool expected = true;
            bool actual = dbKoppeling.LogIn(gebruikersNaam, wachtwoord, out error);

            Assert.AreEqual(expected, actual, "Kon niet inloggen");
        }

        [TestMethod]
        public void LogIn2()
        {
            string gebruikersNaam = "Joop";
            string wachtwoord = "joop";
            string error = "";

            dbKoppeling = new DatabaseKoppeling();
            bool expected = false;
            bool actual = dbKoppeling.LogIn(gebruikersNaam, wachtwoord, out error);

            Assert.AreEqual(expected, actual, "Kon toch inloggen");
        }

        [TestMethod]
        public void GeefProduct()
        {
            string error = "";
            string productnaam = "Qapital 2015";
            dbKoppeling = new DatabaseKoppeling();
            string expected = "Qapital 2015";
            string actual = dbKoppeling.GeefProduct(productnaam, out error).Naam;

            Assert.AreEqual(expected, actual, "Product niet gevonden");
        }

        [TestMethod]
        public void ZoekProducten()
        {
            string productnaam = "Qapital 2015";
            dbKoppeling = new DatabaseKoppeling();
            dbKoppeling.ZoekProducten(productnaam);
            Product actualProduct = null;
            foreach(Product p in dbKoppeling.ZoekProducten(productnaam))
            {
                actualProduct = p;
            }
            string expected = productnaam;
            string actual = actualProduct.Naam;

            Assert.AreEqual(expected, actual, "Product niet gevonden");
        }
    }
}
