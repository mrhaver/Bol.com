using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace Bol_Applicatie
{
    public partial class BeheerForm : System.Web.UI.Page
    {
        Administratie administratie = new Administratie();
        
        protected void Page_Load(object sender, EventArgs e)
        {
            if(!Page.IsPostBack)
            {
                VulOndersteCategorieen();
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

        protected void btnVoegProductToe_Click(object sender, EventArgs e)
        {
            string error = "";
            if(tbNaam.Text != "" && tbBeschrijving.Text != "" && tbPrijs.Text != "")
            {
                if(lbCategorieen.SelectedItem != null)
                {
                    if (administratie.DBKoppeling.NieuwProduct(lbCategorieen.SelectedItem.ToString(), tbNaam.Text, tbBeschrijving.Text, Convert.ToInt32(tbPrijs.Text), out error))
                    {
                        GeefMessage("Product Toegevoegd");
                    }
                    else
                    {
                        GeefMessage(error);
                    }
                }             
            }
            
        }

        private void VulOndersteCategorieen()
        {
            string error = "";
            List<Categorie> categorieen = new List<Categorie>();
            foreach (Categorie c in administratie.DBKoppeling.AlleCategorieen())
            {
                if (administratie.DBKoppeling.GeefOnderCategorieen(c.CategorieNaam, out error).Count == 0)
                {
                    categorieen.Add(c);
                }
            }

            foreach (Categorie c in categorieen)
            {
                lbCategorieen.Items.Add(c.CategorieNaam);
            }
        }

        protected void btnInlogform_Click(object sender, EventArgs e)
        {
            Response.Redirect("InlogForm.aspx");
        }
    }
}