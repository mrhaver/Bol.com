using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace Bol_Applicatie
{
    public partial class HomeForm : System.Web.UI.Page
    {
        DatabaseKoppeling dbKoppeling;
        int counter = 0;

        protected void Page_Load(object sender, EventArgs e)
        {
            dbKoppeling = new DatabaseKoppeling();
            // laadt de list alleen als de page niet postback is
            if(Page.IsPostBack == false)
            {
                VulCategorieen();
            }
            this.Session["SelectedItem"] = lbCategorieen.SelectedItem;
            
        }

        private void VulCategorieen()
        {
            lbCategorieen.Items.Clear();
            string error = "";
            List<Categorie> categorieen = dbKoppeling.GeefBovenCategorieen(out error);
            if(categorieen.Count != 0)
            {
                foreach (Categorie c in categorieen)
                {
                    lbCategorieen.Items.Add(c.ToString());
                }
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

        protected void btnKies_Click(object sender, EventArgs e)
        {
            //Categorie categorie = lbCategorieen.SelectedItem as Categorie; FRANK: Waarom werkt dit niet?
            //lbCategorieen.Items.Clear();
            GeefMessage(Session["SelectedItem"].ToString());
            
        }
    }
}