using System;

namespace Practice2.OnlineOrderingProject
{
    /// <summary>
    /// <para>
    /// The responsibility of Products is to get product's the name, id, price unit and quantity.
    /// </para>
    /// </summary>
    public class Product
    {
        private string _productname = "";
        private string _id = "";
        private int _priceunit = 0;
        private int _quantity = 0;


        /// <summary>
        /// Constructs a new instance of Product with productname, priceunit and quantity.
        /// </summary>
        public Product(string id, string productname, int priceunit, int quantity)
        {
            this._id = id;
            this._productname = productname;
            this._priceunit = priceunit;
            this._quantity = quantity;

        }

        /// <summary>
        /// Calculates the price of a product.
        /// <param name="priceunit">The price unit of a product.</param>
        /// <param name="quantity">The quantity of a product.</param>
        /// </summary>
        public int Price(int priceunit, int quantity)
        {
            this._priceunit = priceunit;
            this._quantity = quantity;
            return (priceunit * quantity);
        }
        public string GetNameProduct()
        {
            return _productname;
        }
        public string GetId()
        {
            return _id;
        }
        public int GetPriceUnit()
        {
            return _priceunit;
        }
        public int GetQuantity()
        {
            return _quantity;
        }
        public void SetNameProduct(string name)
        {
            this._productname = name;
        }
        public void SetId(string id)
        {
            this._id = id;
        }
        public void SetPriceUnit(int priceunit)
        {
            this._priceunit = priceunit;
        }
        public void SetQuantity(int quantity)
        {
            this._quantity = quantity;
        }


    }
}