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
        Administratie administratie = new Administratie();

        protected void Page_Load(object sender, EventArgs e)
        {
            dbKoppeling = new DatabaseKoppeling();
            // laadt de list alleen als de page niet postback is
            if(Page.IsPostBack == false)
            {
                VulBovensteCategorieen();
            }
            this.Session["SelectedItem"] = lbCategorieen.SelectedItem;
            this.Session["SelectedItemP"] = lbProducten.SelectedItem;         
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
            // vul onder categorieën
            // als er niks is geselecteerd pak dan een standaard waarde
            string selectedItem = "";
            if(Session["SelectedItem"] != null)
            {          
                selectedItem = Session["SelectedItem"].ToString();
                VulOnderCategorieen(selectedItem);
            }
            else
            {
                lbCategorieen.SelectedIndex = 0;
                VulOnderCategorieen(lbCategorieen.SelectedItem.ToString());
            }
 
        }

        protected void btnVorige_Click(object sender, EventArgs e)
        {
            string selectedItem = "";
            if (Session["SelectedItem"] != null)
            {
                selectedItem = Session["SelectedItem"].ToString();
                VulBovenCategorieen(selectedItem); 
            }
            else
            {
                lbCategorieen.SelectedIndex = 0;
                VulBovenCategorieen(lbCategorieen.SelectedItem.ToString()); 
            }
                       
        }

        protected void btnKiesProduct_Click(object sender, EventArgs e)
        { 
            string selectedItem = "";
            string error = "";
            if(Session["SelectedItemP"] != null)
            {
                selectedItem = Session["SelectedItemP"].ToString();
                administratie.Product = dbKoppeling.GeefProduct(selectedItem, out error);
                Response.Redirect("ProductForm.aspx");
            }            
        }

        // Methods
        private void VulBovensteCategorieen()
        {
            lbCategorieen.Items.Clear();
            string error = "";
            List<Categorie> categorieen = dbKoppeling.GeefBovensteCategorieen(out error);
            if (categorieen.Count != 0)
            {
                foreach (Categorie c in categorieen)
                {
                    lbCategorieen.Items.Add(c.ToString());
                }
            }
        }

        private void VulBovenCategorieen(string selectedItem)
        {
            string error = "";
            Categorie categorie = dbKoppeling.GeefBovenCategorie(selectedItem, out error);
            if(categorie != null)
            {
                List<Categorie> categorieen = dbKoppeling.GeefBovenCategorieen(categorie.ToString(), out error);
                if (categorieen.Count == 0)
                {
                    VulBovensteCategorieen();
                }
                else
                {
                    lbCategorieen.Items.Clear();
                    foreach (Categorie c in categorieen)
                    {
                        lbCategorieen.Items.Add(c.ToString());
                    }
                }
            }
            else
            {
                GeefMessage("Er zijn geen categorieën hierboven");
            }        
        }

        private void VulOnderCategorieen(string selectedItem)
        {
            //Categorie categorie = lbCategorieen.SelectedItem as Categorie; FRANK: Waarom werkt dit niet?
            //lbCategorieen.Items.Clear();
            
            string error = "";
            List<Categorie> categorieen = dbKoppeling.GeefOnderCategorieen(selectedItem, out error);
            if (categorieen.Count == 0)
            {
                // als er geen categorieën kunnen worden teruggegeven geef dan de producten die bij die categorie horen
                VulProducten(selectedItem);
            }
            else
            {
                // geef alle categorieën
                lbCategorieen.Items.Clear();
                foreach (Categorie c in categorieen)
                {
                    lbCategorieen.Items.Add(c.ToString());
                }
            }
        }

        private void VulProducten(string selectedItem)
        {
            string error = "";
            List<Product> producten = dbKoppeling.GeefProducten(selectedItem, out error);
            if (producten.Count == 0)
            {
                // geef aan dat er geen producten zijn gevonden voor deze categorie
                lbProducten.Items.Clear();
                lbProducten.Items.Add("Geen producten gevonden voor deze categorie");
            }
            else
            {
                lbProducten.Items.Clear();
                foreach (Product p in producten)
                {
                    lbProducten.Items.Add(p.Naam);
                }
            }
        }


    }
}