using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace Bol_Applicatie
{
    public class Administratie
    {
        private static Product product;

        public Product Product
        {
            get { return product; }
            set { product = value; }
        }

        public Administratie()
        {

        }

    }
}