using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.HtmlControls;
using System.Web.UI.WebControls;

namespace Online_Grocery_App.Pages
{
    public partial class ProductsPage : System.Web.UI.Page
    {
        private List<Product> list;
        protected void Page_Load(object sender, EventArgs e)
        {
            //if(!IsPostBack)
            //{
            
            if(Request.QueryString.HasKeys())
            {
                string ProductId;
                
                ProductId = Request.QueryString["id"].ToString();
                databaseConnection connection = new databaseConnection();
                string query = @"select products.id, product_name,product_price, product_description, product_brand, category_name, nameOfType, product_picture from products
                            inner join category
                            on products.category = category.id
                            left join product_type
                            on products.p_type = product_type.id
                            where products.id = " + ProductId;
                list = connection.getData(query);
                imageDiv.InnerHtml = "<img src = '.." + list[0].getProductImage() + "'/>";
                productName.InnerText = list[0].getProductName();
                productPrice.InnerText = "Rs. " + list[0].getProductPrice().ToString();
                productBrand.InnerText = list[0].getProductBrand();
                btnAddToCart.CommandArgument = list[0].getProductID().ToString();
                productDescription.InnerText = list[0].getProductDescription();
                showData(list[0].getProductCategory());
            }
            else
            {
                Response.Redirect("../index.aspx");
            }

            ListItem item1 = new ListItem("Select Quantity", "-1");
            ListItem item2 = new ListItem("0.25kg", "0.25");
            ListItem item3 = new ListItem("0.5kg", "0.5");
            ListItem item4 = new ListItem("1kg", "1");

            DropDownList1.Items.Add(item1);
            DropDownList1.Items.Add(item2);
            DropDownList1.Items.Add(item3);
            DropDownList1.Items.Add(item4);
            

        }


        //}
        public void showData(string type)
        {
            databaseConnection connection = new databaseConnection();
            string query = @"select products.id, product_name,product_price, product_description, product_brand, category_name, nameOfType, product_picture from products
                                inner join category
                                on products.category = category.id
                                left join product_type
                                on products.p_type = product_type.id
                                where category.category_name = '" + type + "'";
            List<Product> list = connection.getData(query);
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

        protected void btnViewAll(object sender, EventArgs e)
        {
            Response.Redirect("./CategoryPage.aspx?category=" + list[0].getProductCategory());
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