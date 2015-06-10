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
        DatabaseKoppeling dbKoppeling = new DatabaseKoppeling();
        protected void Page_Load(object sender, EventArgs e)
        {
            if (!Page.IsPostBack)
            {
                Ververs();
            }     
        }

        public void GeefMessage(string message)
        {
            System.Text.StringBuilder sb = new System.Text.StringBuilder();
            sb.Append("<script type = 'text/javascript'>");
            sb.Append("window.onload=function(){");
            sb.Append("alert('");
            sb.Append(message);
            sb.Append("')};");
            sb.Append("</script>");
            ClientScript.RegisterClientScriptBlock(this.GetType(), "alert", sb.ToString());
        }

        protected void btnVerwijder_Click(object sender, EventArgs e)
        {
            string error = "";
            if(lbWinkelwagen.SelectedItem != null)
            {
                if(administratie.NuIngelogd.UitWinkelWagen(dbKoppeling.GeefProduct(lbWinkelwagen.SelectedItem.ToString(), out error)))
                {
                    GeefMessage("Item Verwijderd");
                    // ververs de listbox nadat er een item is verwijderd
                    // het het totale budget van de winkelwagen
                    Ververs();
                }
            }
        }

        protected void btnBetaal_Click(object sender, EventArgs e)
        {
            // kijk naar de totale prijs van de winkelwagen
            // kijk naar het budget.
            // als het budget genoeg is verwijder dan alle items uit de winkelwagen
            // haal de prijs van het budget af
            string error = "";
            if(!administratie.NuIngelogd.BetaalWinkelwagen(out error))
            {
                GeefMessage(error);
            }
            else
            {
                GeefMessage("Winkelwagen Afgerekend");
                administratie.NuIngelogd.WinkelWagen.Clear();
            }     
            Ververs();
            
        }

        private void Ververs()
        {
            lbWinkelwagen.Items.Clear();
            VulWinkelwagen();
            lblPrijs.Text = Convert.ToString(administratie.NuIngelogd.GeefWinkelwagenPrijs());
            lblBudget.Text = Convert.ToString(administratie.NuIngelogd.Budget);
        }

        private void VulWinkelwagen()
        {
            foreach (Product p in administratie.NuIngelogd.WinkelWagen)
            {
                lbWinkelwagen.Items.Add(p.Naam);
            }
        }

        protected void btnVerlanglijst_Click(object sender, EventArgs e)
        {
            Response.Redirect("AccountInformatie.aspx");
        }

        protected void btnInlog_Click(object sender, EventArgs e)
        {
            // er wordt nu ook als het ware uitgelogd omdat men weer terug naar het inlogscherm gaat
            administratie.NuIngelogd = null;
            Response.Redirect("InlogForm.aspx");
        }

        protected void btnCategorie_Click(object sender, EventArgs e)
        {
            // ga naar het zoekform
            Response.Redirect("HomeForm.aspx");
        }
    }
}