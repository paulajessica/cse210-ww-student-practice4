using System;

namespace Practice2.OnlineOrderingProject
{
    /// <summary>
    /// <para>
    /// The responsibility of Custumer is to get a customer's the name and addres.
    /// </para>
    /// </summary>

    public class Customer
    {
        private string _name = "";


        /// <summary>
        /// Constructs a new instance of Customer with name and address.
        /// </summary>
        public Customer(string name, Address address)
        {
            this._name = name;

        }

        /// <summary>
        /// Returns true if the customer lives in USA.
        /// <param name="address">The address of a customer.</param>
        /// </summary>
        public bool LivedUSA(Address address)
        {
            return address.IsUSA();
        }
        public string GetName()
        {
            return _name;
        }

        public void SetName(string name)
        {
            this._name = name;
        }


    }
}
