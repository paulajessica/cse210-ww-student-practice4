using System;

namespace Practice3.EventPlanningProject
{
    /// <summary>
    /// <para>
    /// The responsibility of Event is to get event's the title, description, date, time and address.
    /// </para>
    /// </summary>
    public class Event : Address
    {
        private string _title = "";
        private string _description = " ";
        private string _date = " ";
        private string _time = " ";

        /// <summary>
        /// Constructs a new instance of Event.
        /// </summary>
        public Event()
        {


        }

        /// <summary>
        /// Displays Standart Details Message of a event.
        /// </summary>
        /// <param name="title">The title of a event.</param>
        /// <param name="description">The description of a event.</param>
        /// <param name="date">The date of a event.</param>
        /// <param name="time">The time of a event.</param>
        /// <param name="event">The event.</param>
        public void StandardDetails(string title, string description, string date, string time, Event eventone)
        {
            this._title = title;
            this._description = description;
            this._date = date;
            this._time = time;
            Console.WriteLine($"{title} Event");
            Console.WriteLine($"Description: {description}\nDate: {date}\nTime: {time}");
            eventone.FullAddress(eventone.GetStreet(), eventone.GetCity(), eventone.GetState(), eventone.GetCountry());
        }

        public string GetTitle()
        {
            return _title;
        }
        public string GetDescription()
        {
            return _description;
        }
        public string GetDate()
        {
            return _date;
        }
        public string GetTime()
        {
            return _time;
        }
        public void SetTitle(string title)
        {
            this._title = title;
        }
        public void SetDescription(string description)
        {
            this._description = description;
        }
        public void SetDate(string date)
        {
            this._date = date;
        }
        public void SetTime(string time)
        {
            this._time = time;
        }




    }
}