using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace Bol_Applicatie
{
    public partial class MaakAccountForm : System.Web.UI.Page
    {
        DatabaseKoppeling dbKoppeling;
        protected void Page_Load(object sender, EventArgs e)
        {
            dbKoppeling = new DatabaseKoppeling();
            if(!Page.IsPostBack)
            {
                VulBudget();
            }
        }

        private void VulBudget()
        {
            ddlBudget.Items.Clear();
            int budget = 5;
            for(int i = 0; i<10; i++)
            {
                ddlBudget.Items.Add(Convert.ToString(budget));
                budget += 5;
            }
        }

        protected void btnMaak_Click(object sender, EventArgs e)
        {
            string foutmelding = "";
            string geslacht;
            if(tbVoornaam.Text != "")
            {
                if(tbAchternaam.Text != "")
                {
                    if(rbtnMan.Checked || rbtnVrouw.Checked)
                    {
                        if(rbtnMan.Checked)
                        {
                            geslacht = "Man";
                        }
                        else
                        {
                            geslacht = "Vrouw";
                        }
                        if(tbEmail.Text != "")
                        {
                            if(tbGebruikersnaam.Text != "")
                            {
                                if(tbWachtwoord.Text != "")
                                {
                                    // dan pas mag het aangemaakt worden
                                    if(dbKoppeling.MaakGebruiker(tbVoornaam.Text, tbAchternaam.Text, geslacht, tbEmail.Text, tbGebruikersnaam.Text, tbWachtwoord.Text, Convert.ToInt32(ddlBudget.SelectedItem.ToString()), out foutmelding))
                                    {
                                        GeefMessage(tbVoornaam.Text + " " + tbAchternaam.Text + " " + " Aanmaken Gelukt");
                                        Response.Redirect("InlogForm.aspx");
                                    }
                                    else
                                    {
                                        GeefMessage(foutmelding);
                                    }
                                }
                                else
                                {
                                    GeefMessage("Vul je wachtwoord in");
                                }
                            }
                            else
                            {
                                GeefMessage("Vul een gebruikersnaam in");
                            }
                        }
                        else
                        {
                            GeefMessage("Vul uw email in");
                        }
                    }
                    else
                    {
                        GeefMessage("Selecteer uw geslacht");
                    }
                }
                else
                {
                    GeefMessage("Achternaam niet ingevuld");
                }
            }
            else
            {
                GeefMessage("Voornaam niet ingevuld");
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

        protected void btnAnnuleer_Click(object sender, EventArgs e)
        {
            tbVoornaam.Text = "";
            tbAchternaam.Text = "";
            tbEmail.Text = "";
            tbGebruikersnaam.Text = "";
            tbWachtwoord.Text = "";
            rbtnMan.Checked = false;
            rbtnVrouw.Checked = false;
        }
    }
}