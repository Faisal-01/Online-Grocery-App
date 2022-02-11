using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.HtmlControls;
using System.Web.UI.WebControls;

namespace Online_Grocery_App.Pages
{
    public partial class ProductTypePage : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            if (Request.QueryString.HasKeys())
            {
                string ProductType;
                ProductType = Request.QueryString["type"].ToString();
                producttypeName.InnerText = ProductType.ToUpper();
                showData(ProductType);
            }
            else
            {
                Response.Redirect("../index.aspx");
            }
        }

        public void showData(string type)
        {
            databaseConnection connection = new databaseConnection();
            string query = @"select products.id, product_name,product_price, product_description, product_brand, category_name, nameOfType, product_picture from products
                                inner join category
                                on products.category = category.id
                                left join product_type
                                on products.p_type = product_type.id
                                where product_type.nameOfType = '" + type + "'";
            List<Product> list = connection.getData(query);
            string data = "";
            for (int i = 0; i < list.Count; i++)
            {
                HtmlGenericControl link = new HtmlGenericControl("a");
                link.Attributes["href"] = "../Pages/ProductsPage.aspx?id=" + list[i].getProductID().ToString();
                HtmlGenericControl div = new HtmlGenericControl("div");
                div.Attributes["class"] = "div";
                Image img = new Image();
                img.ImageUrl = "~" + list[i].getProductImage();
                HtmlGenericControl name = new HtmlGenericControl("p");
                HtmlGenericControl price = new HtmlGenericControl("p");
                HtmlGenericControl brand = new HtmlGenericControl("p");
                HtmlGenericControl addCartDiv = new HtmlGenericControl("div");
                Button btn = new Button();
                addCartDiv.Attributes["class"] = "AddCartDiv";
                addCartDiv.Controls.Add(btn);

                btn.Text = "Add to Cart";
                btn.CssClass = "cartBtn";
                btn.CommandArgument = list[i].getProductID().ToString();
                btn.Click += BtnAddToCart;
                name.InnerText = list[i].getProductName();
                price.InnerText = list[i].getProductPrice().ToString();
                brand.InnerText = list[i].getProductBrand();

                link.Controls.Add(img);
                link.Controls.Add(name);
                link.Controls.Add(price);
                link.Controls.Add(brand);
                link.Controls.Add(addCartDiv);
                div.Controls.Add(link);

                Panel1.Controls.Add(div);
            }


        }

        protected void BtnAddToCart(object sender, EventArgs e)
        {
            Button btn = (Button)sender;
            HtmlGenericControl cart = (HtmlGenericControl)this.Master.FindControl("cartLabel");
            Session["cartNumber"] = (Int32.Parse(Session["cartNumber"].ToString()) + 1).ToString();
            cart.InnerText = Session["cartNumber"].ToString();

            List<int> items = (List<int>)Session["CartItems"];
            items.Add(Int32.Parse(btn.CommandArgument));
            Session["CartItems"] = items;
            Response.Redirect(Request.Url.AbsoluteUri);
        }
    }
    
}