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
        protected void Page_Load(object sender, EventArgs e)
        {
            dbKoppeling = new DatabaseKoppeling();
        }

        protected void btnLogIn_Click(object sender, EventArgs e)
        {
            string error = "";
            if(dbKoppeling.LogIn(tbGebruikersnaam.Text, tbWachtwoord.Text, out error))
            {
                GeefMessage("Inloggen Gelukt");
                Response.Redirect("HomeForm.aspx");
            }
            else
            {
                GeefMessage(error);
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