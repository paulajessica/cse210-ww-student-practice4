using System;
using System.Collections.Generic;
using Practice2.OnlineOrderingProject;

namespace Practice2
{
    /// <summary>
    /// The program's entry point.
    /// Encapsulation is a technique to keep occult or not access information about methods of a class,
    /// hiding details so others can't see or change them. In Online Ordering Project, there are methods
    /// and variables in private, and this way, they can be accessed through gets and sets.    
    /// </summary>
    class Program
    {
        /// <summary>
        /// Starts the program using the given arguments.
        /// </summary>
        /// <param name="args">The given arguments.</param>
        static void Main(string[] args)
        {
            //Creates customers
            Address _customer1address = new Address("2900 Orchard Street", "Hopkins", "MN", "UNITED STATES");
            Customer _customer1 = new Customer("John Cox", _customer1address);
            Address _customer2address = new Address("123 Ilchester Road", "Mylor Bridge", "TR11", "CANADA");
            Customer _customer2 = new Customer("Mathew Smith", _customer2address);

            //Creates products list customer1
            List<Product> _customer1products = new List<Product>();

            Product _product1 = new Product("1", "scissors", 1, 2);
            Product _product2 = new Product("2", "marker", 4, 1);
            Product _product3 = new Product("3", "pencil", 2, 0);

            _customer1products.Add(_product1);
            _customer1products.Add(_product2);
            _customer1products.Add(_product3);

            //Creates customer1's order
            Order _order1 = new Order();
            _order1.PackingLabel(_customer1products);
            _order1.ShippingLabel(_customer1, _customer1address);
            int order1 = _order1.TotalOrder(_customer1products, _customer1);
            int shippingcost1 = _order1.ShippingCost(_customer1, _customer1address);
            int total1 = order1 + shippingcost1;
            Console.WriteLine($"Order: ${order1.ToString("F")}");
            Console.WriteLine($"Shipping Cost: ${shippingcost1.ToString("F")}");
            Console.WriteLine($"Total Order: ${total1.ToString("F")}");
            Console.WriteLine("");

            //Creates product list to customer2
            List<Product> _customer2products = new List<Product>();
            Product _product4 = new Product("4", "agenda", 3, 2);
            Product _product5 = new Product("5", "paperclip", 1, 10);

            _customer2products.Add(_product4);
            _customer2products.Add(_product5);

            //Creates customer2's order
            Order _order2 = new Order();
            _order2.PackingLabel(_customer2products);
            _order2.ShippingLabel(_customer2, _customer2address);
            int order2 = _order1.TotalOrder(_customer2products, _customer2);
            int shippingcost2 = _order1.ShippingCost(_customer2, _customer2address);
            int total2 = order2 + shippingcost2;
            Console.WriteLine($"Order: ${order2.ToString("F")}");
            Console.WriteLine($"Shipping Cost: ${shippingcost2.ToString("F")}");
            Console.WriteLine($"Total Order: ${total2.ToString("F")}");
            Console.WriteLine("");

        }
    }
}
