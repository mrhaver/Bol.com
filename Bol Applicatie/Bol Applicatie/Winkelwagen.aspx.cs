using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace Bol_Applicatie
{
    public partial class Winkelwagen : System.Web.UI.Page
    {
        Administratie administratie = new Administratie();
        protected void Page_Load(object sender, EventArgs e)
        {
            if (Page.IsPostBack == false)
            {
                lblPrijs.Text = Convert.ToString(administratie.NuIngelogd.GeefWinkelwagenPrijs());
                lblBudget.Text = Convert.ToString(administratie.NuIngelogd.Budget);
                VulWinkelwagen();
            }     
        }

        private void VulWinkelwagen()
        {
            foreach(Product p in administratie.NuIngelogd.WinkelWagen)
            {
                lbWinkelwagen.Items.Add(p.ToString());
            }
        }
    }
}