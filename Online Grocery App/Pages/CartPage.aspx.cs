using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.HtmlControls;
using System.Web.UI.WebControls;

namespace Online_Grocery_App.Pages
{
    public partial class CartPage : System.Web.UI.Page
    {

        protected void Page_Load(object sender, EventArgs e)
        {
            List<int> items = (List<int>)Session["CartItems"];
            databaseConnection connection = new databaseConnection();
            List<Product> list = new List<Product>();
            for (int i = 0; i < items.Count; i++)
            {
                list.Add(connection.getProduct(items[i]));
            }

            for(int i = 0; i < list.Count; i++)
            {
                HtmlGenericControl productContainer = new HtmlGenericControl("div");
                productContainer.Attributes["class"] = "product-container";

                HtmlGenericControl productImage = new HtmlGenericControl("div");
                productImage.Attributes["class"] = "product-img";
                Image image = new Image();
                image.ImageUrl = ".." + list[i].getProductImage();
                productImage.Controls.Add(image);

                HtmlGenericControl productDetailsContainer = new HtmlGenericControl("div");
                productDetailsContainer.Attributes["class"] = "product-details-container";
                HtmlGenericControl productName = new HtmlGenericControl("h1");
                HtmlGenericControl productPrice = new HtmlGenericControl("h1");
                productName.InnerText = list[i].getProductName();
                productPrice.InnerText = list[i].getProductPrice().ToString();
                productDetailsContainer.Controls.Add(productName);
                productDetailsContainer.Controls.Add(productPrice);

                HtmlGenericControl productQuantityContainer = new HtmlGenericControl("div");
                productQuantityContainer.Attributes["class"] = "product-quantity-container";
                HtmlGenericControl btnCross = new HtmlGenericControl("button");
                btnCross.Attributes["class"] = "remove-item";
                HtmlGenericControl cross = new HtmlGenericControl("i");
                cross.Attributes["class"] = "fas fa-times fa-lg";
                btnCross.Controls.Add(cross);
                productQuantityContainer.Controls.Add(btnCross);
                HtmlGenericControl quantityButton = new HtmlGenericControl("div");
                quantityButton.Attributes["class"] = "quantity-buttons";
                HtmlGenericControl btnMinus = new HtmlGenericControl("button");
                btnMinus.Attributes["class"] = "buttons";
                HtmlGenericControl minus = new HtmlGenericControl("i");
                minus.Attributes["class"] = "fa fa-solid fa-minus fa-lg";
                btnMinus.Controls.Add(minus);
                HtmlGenericControl btnPlus = new HtmlGenericControl("button");
                btnPlus.Attributes["class"] = "buttons";
                HtmlGenericControl plus = new HtmlGenericControl("i");
                plus.Attributes["class"] = "fa fa-solid fa-plus fa-lg";
                btnPlus.Controls.Add(plus);
                quantityButton.Controls.Add(btnMinus);
                quantityButton.Controls.Add(btnPlus);
                productQuantityContainer.Controls.Add(quantityButton);

                productContainer.Controls.Add(productImage);
                productContainer.Controls.Add(productDetailsContainer);
                productContainer.Controls.Add(productQuantityContainer);

                Panel1.Controls.Add(productContainer);
            }
             
        }
    }
}


