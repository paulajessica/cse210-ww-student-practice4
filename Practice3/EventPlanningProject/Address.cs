using System;

namespace Practice3.EventPlanningProject
{
    /// <summary>
    /// <para>
    /// The responsibility of Address is to get event's address.
    /// </para>
    /// </summary>
    public class Address
    {
        private string _street = "";
        private string _city = "";
        private string _state = "";
        private string _country = "";

        /// <summary>
        /// Constructs a new instance of Address.
        /// </summary>
        public Address()
        {

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
        public void SetStreet(string street)
        {
            this._street = street;
        }
        public void SetCity(string city)
        {
            this._city = city;
        }
        public void SetState(string state)
        {
            this._state = state;
        }
        public void SetCountry(string country)
        {
            this._country = country;
        }

        /// <summary>
        /// Displays the full address of a event.
        /// </summary>
        /// <param name="street">The street of a event.</param>
        /// <param name="state">The state of a event.</param>
        /// <param name="city">The city of a event.</param>
        /// <param name="country">The country of a event.</param>
        public void FullAddress(string street, string state, string city, string country)
        {

            Console.WriteLine($"{street}\n{state}\n{city}\n{country}");

        }



    }
}