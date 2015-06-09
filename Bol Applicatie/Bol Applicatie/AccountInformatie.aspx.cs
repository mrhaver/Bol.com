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
        DatabaseKoppeling dbKoppeling;
        protected void Page_Load(object sender, EventArgs e)
        {
            dbKoppeling = new DatabaseKoppeling();
            try
            {
                dbKoppeling.TestConnection();
            }
            catch
            {
                string message = "Hello! Mudassar.";
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
}