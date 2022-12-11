using System;

namespace Practice2.OnlineOrderingProject
{
    /// <summary>
    /// <para>
    /// The responsibility of Address is to the address of a customer.
    /// </para>
    /// </summary>
    public class Address
    {
        private string _street = "";
        private string _city = "";
        private string _state = "";
        private string _country = "";

        /// <summary>
        /// Constructs a new instance of Addres with street, city, state, country.
        /// </summary>
        public Address(string street, string city, string state, string country)
        {
            this._street = street;
            this._city = city;
            this._state = state;
            this._country = country;

        }

        /// <summary>
        /// Returns true if the customer lives in USA.
        /// </summary>
        public bool IsUSA()
        {
            return _country == "UNITED STATES";

        }
        public string GetStreet()
        {
            return _street;
        }
        public string GetCity()
        {
            return _city;
        }
        public string GetState()
        {
            return _state;
        }
        public string GetCountry()
        {
            return _country;
        }

    }
}