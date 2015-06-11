using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace Bol_Applicatie
{
    public partial class InlogForm : System.Web.UI.Page
    {
        DatabaseKoppeling dbKoppeling;
        Administratie administratie;

        protected void Page_Load(object sender, EventArgs e)
        {
            dbKoppeling = new DatabaseKoppeling();
            administratie = new Administratie();
        }

        protected void btnLogIn_Click(object sender, EventArgs e)
        {
            string error = "";
            if(tbGebruikersnaam.Text != "" && tbWachtwoord.Text != "")
            {
                if(rbtnBeheerder.Checked)
                {
                    if(dbKoppeling.LogIn(tbGebruikersnaam.Text, tbWachtwoord.Text, rbtnBeheerder.Checked, out error))
                    {
                        administratie.NuIngelogd = dbKoppeling.GeefAccount(tbGebruikersnaam.Text);
                        GeefMessage("Inloggen Gelukt");
                        Response.Redirect("BeheerForm.aspx"); 
                    }
                    else
                    {
                        GeefMessage(error);
                    }
                }
                else
                {
                    if (dbKoppeling.LogIn(tbGebruikersnaam.Text, tbWachtwoord.Text, out error))
                    {
                        administratie.NuIngelogd = dbKoppeling.GeefAccount(tbGebruikersnaam.Text);
                        GeefMessage("Inloggen Gelukt");
                        Response.Redirect("HomeForm.aspx");
                    }
                    else
                    {
                        GeefMessage(error);
                    }
                }              
            }
            else
            {
                GeefMessage("Voer Gebruikersnaam En Wachtwoord In");
            }
            
        }

        protected void btnMaakGebruiker_Click(object sender, EventArgs e)
        {
            Response.Redirect("MaakAccountForm.aspx");
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


    }
}