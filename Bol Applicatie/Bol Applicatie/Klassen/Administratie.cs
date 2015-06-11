﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace Bol_Applicatie
{
    public class Administratie
    {
        private static Product gekozenProduct;
        private static Account nuIngelogd;
        private DatabaseKoppeling dbKoppeling;

        public Product GekozenProduct
        {
            get { return gekozenProduct; }
            set { gekozenProduct = value; }
        }

        public Account NuIngelogd
        {
            get { return nuIngelogd; }
            set { nuIngelogd = value; }
        }

        public DatabaseKoppeling DBKoppeling
        {
            get { return dbKoppeling; }
        }

        public Administratie()
        {
            dbKoppeling = new DatabaseKoppeling();
        }

    }
}