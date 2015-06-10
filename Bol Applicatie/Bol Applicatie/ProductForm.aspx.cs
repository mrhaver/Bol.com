using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace Bol_Applicatie
{
    public partial class ProductForm : System.Web.UI.Page
    {
        Administratie administratie = new Administratie();
        DatabaseKoppeling dbKoppeling = new DatabaseKoppeling();

        protected void Page_Load(object sender, EventArgs e)
        {
            lblProduct.Text = administratie.GekozenProduct.Naam;
            lblProductBeschrijving.Text = administratie.GekozenProduct.Beschrijving;
            lblPrijs.Text = Convert.ToString(administratie.GekozenProduct.Prijs);
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

        protected void btnNaarVerlanglijst_Click(object sender, EventArgs e)
        {
            string error = "";
            if(administratie.NuIngelogd.AanVerlanglijst(administratie.NuIngelogd, administratie.GekozenProduct, out error))
            {
                GeefMessage("Product Toegevoegd aan Verlanglijst");
            }
            else
            {
                GeefMessage(error);
            }
        }

        protected void btnNaarWinkelwagen_Click(object sender, EventArgs e)
        {
            if(administratie.NuIngelogd.AanWinkelWagen(administratie.GekozenProduct))
            {
                GeefMessage("Product Toegevoegd Aan Winkelwagen");
            }
            else
            {
                GeefMessage("Product Bestaat Al In Winkelwagen");
            }

        }

        protected void btnInlog_Click(object sender, EventArgs e)
        {
            administratie.NuIngelogd = null;
            Response.Redirect("InlogForm.aspx");
        }

        protected void btnCategorie_Click(object sender, EventArgs e)
        {
            Response.Redirect("HomeForm.aspx");
        }

        protected void btnVerlanglijst_Click1(object sender, EventArgs e)
        {
            Response.Redirect("AccountInformatie.aspx");
        }

        protected void btnWinkelwagen_Click1(object sender, EventArgs e)
        {
            Response.Redirect("Winkelwagen.aspx");
        }


    }
}