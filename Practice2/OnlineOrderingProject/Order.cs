using System;
using System.Collections.Generic;

namespace Practice2.OnlineOrderingProject
{
    /// <summary>
    /// <para>
    /// The responsibility of Order is to get Total Order, shipping cost, packing label and shipping label.
    /// </para>
    /// </summary>
    public class Order
    {

        /// <summary>
        /// Constructs a new instance of Order.
        /// </summary>
        public Order()
        {

        }

        /// <summary>
        /// Calculates the total of a Order.
        /// </summary>
        /// <param name="products">The list of products.</param>
        /// <param name="customer">The customer.</param>
        public int TotalOrder(List<Product> products, Customer customer)
        {
            List<int> _sumprice = new List<int>();
            int total = 0;
            foreach (Product order in products)
            {
                int _price = order.Price(order.GetPriceUnit(), order.GetQuantity());
                _sumprice.Add(_price);
            }

            foreach (int number in _sumprice)
            {
                total += number;

            }
            return total;

        }
        /// <summary>
        /// Calculates the cost of the shipping according to where a customer lives.
        /// </summary>
        /// <param name="customer">The customer.</param>
        /// <param name="addres">The address of the customer.</param>
        public int ShippingCost(Customer customer, Address address)
        {
            int _shippingcost = 0;
            if (customer.LivedUSA(address))
            {
                _shippingcost = 5;
            }
            else
            {
                _shippingcost = 35;
            }
            return _shippingcost;
        }

        /// <summary>
        /// Displays the packing label of a order.
        /// </summary>
        /// <param name="products">The list of products.</param>       
        public void PackingLabel(List<Product> products)
        {
            Console.WriteLine($"Packing Label:");
            foreach (Product product in products)
            {
                Console.WriteLine($"{product.GetId()}: {product.GetNameProduct()}");
            }
        }

        /// <summary>
        /// Displays the shopping label of a order.
        /// </summary>
        /// <param name="customer">The customer.</param>
        /// <param name="addres">The address of the customer.</param>
        public void ShippingLabel(Customer customer, Address address)
        {
            Console.WriteLine($"Shopping Label:");
            Console.WriteLine($"{customer.GetName()}");
            Console.WriteLine($"{address.GetStreet()}\n{address.GetCity()}\n{address.GetState()}\n{address.GetCity()}\n{address.GetCountry()}");


        }

    }
}





