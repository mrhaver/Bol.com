using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace Bol_Applicatie
{
    public partial class AccountInformatie : System.Web.UI.Page
    {
        private Administratie administratie = new Administratie();
        protected void Page_Load(object sender, EventArgs e)
        {
            if(!Page.IsPostBack)
            {
                VulVerlanglijst();
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

        private void VulVerlanglijst()
        {
            lbVerlanglijst.Items.Clear();
            foreach (Product p in administratie.DBKoppeling.GeefVerlanglijst(administratie.NuIngelogd))
            {
                lbVerlanglijst.Items.Add(p.Naam);
            }            
        }

        protected void btnVerwijder_Click(object sender, EventArgs e)
        {
            string error = "";
            if(lbVerlanglijst.SelectedItem != null)
            {
                if(administratie.NuIngelogd.UitVerlanglijst(administratie.NuIngelogd, administratie.DBKoppeling.GeefProduct(lbVerlanglijst.SelectedItem.ToString(), out error)))
                {
                    GeefMessage("Product Verwijderd");
                    VulVerlanglijst();
                }
                else
                {
                    GeefMessage(error);
                }
            }
            else
            {
                GeefMessage("Selecteer een item");
            }
        }

        protected void btnExWinkelwagen_Click(object sender, EventArgs e)
        {
            // in principe wordt de winkelwagen van het ingelogde account aangepast
            // die winkelwagen wordt eerst geleegd en daarna gevuld met het verlanglijstje, 
            // daarna wordt het formulier van de winkelwagen geopend
            administratie.NuIngelogd.WinkelWagen.Clear();
            foreach(Product p in administratie.DBKoppeling.GeefVerlanglijst(administratie.NuIngelogd))
            {
                administratie.NuIngelogd.WinkelWagen.Add(p);
            }
            // could have: geef een vraag aan de gebruiker of deze direct naar het winkelwagen form wil
            // zo ja, ga. zo nee, blijf op deze pagina.
            Response.Redirect("Winkelwagen.aspx");
        }

        protected void btnInlog_Click(object sender, EventArgs e)
        {
            Response.Redirect("InlogForm.aspx");
        }

        protected void btnCategorie_Click(object sender, EventArgs e)
        {
            Response.Redirect("HomeForm.aspx");
        }

        protected void btnVerlanglijst_Click(object sender, EventArgs e)
        {
            Response.Redirect("Winkelwagen.aspx");
        }
    }
}