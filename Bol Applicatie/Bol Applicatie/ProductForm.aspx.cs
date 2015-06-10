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

        protected void btnVerlanglijst_Click(object sender, EventArgs e)
        {

        }

        protected void btnWinkelWagen_Click(object sender, EventArgs e)
        {
            Response.Redirect("Winkelwagen.aspx");
        }
    }
}