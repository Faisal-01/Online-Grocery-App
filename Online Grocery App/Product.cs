using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace Online_Grocery_App
{
    public class Product
    {
        private int productID;
        private string productName;
        private double productPrice;
        private string productDescription;
        private string productBrand;
        private string productCategory;
        private string productType;
        private string productImage;

        public Product(int productID, string productName, double productPrice, string productDescription, string productBrand, string productCategory, string productType, string productImage)
        {
            this.productID = productID;
            this.productName = productName;
            this.productPrice = productPrice;
            this.productDescription = productDescription;
            this.productBrand = productBrand;
            this.productCategory = productCategory;
            this.productType = productType;
            this.productImage = productImage;
        }

        public int getProductID()
        {
            return productID;
        }

        public string getProductName()
        {
            return productName;
        }

        public double getProductPrice()
        {
            return productPrice;
        }

        public string getProductDescription()
        {
            return productDescription;
        }

        public string getProductBrand()
        {
            return productBrand;
        }

        public string getProductCategory()
        {
            return productCategory;
        }

        public string getProductType()
        {
            return productType;
        }

        public string getProductImage()
        {
            return productImage;
        }
    }
}