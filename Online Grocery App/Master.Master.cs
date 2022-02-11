using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace Online_Grocery_App
{
    public partial class Master : System.Web.UI.MasterPage
    {
        
        protected void Page_Load(object sender, EventArgs e)
        {
            cartLabel.InnerText = Session["cartNumber"].ToString();
            
            
        }

        public void BtnSearch(object sender, EventArgs e)
        {
            string value = textboxInput.Value;
            
            Response.Redirect("~/Pages/SearchPage.aspx?query=" + value);
        }
    }
}