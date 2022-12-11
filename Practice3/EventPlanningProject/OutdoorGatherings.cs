using System;

namespace Practice3.EventPlanningProject
{
    /// <summary>
    /// <para>
    /// The responsibility of OutdoorGatherings is to get outdoorgatherings event's the weather forecast.
    /// </para>
    /// </summary>
    public class OutdoorGatherings : Event
    {
        private string _weatherforecast = "";

        /// <summary>
        /// Constructs a new instance of Comment.
        /// </summary>
        public OutdoorGatherings()
        {

        }

        /// <summary>
        /// Displays Full Datails Message of a outdoorgatherings event.
        /// </summary>
        /// <param name="weatherforecast">The weather forecast of a outdoorgatherings event.</param>
        /// <param name="event">The event.</param>  
        public void FullDetail(string weatherforecast, Event eventone)
        {

            eventone.StandardDetails(eventone.GetTitle(), eventone.GetDescription(), eventone.GetDate(), eventone.GetTime(), eventone);
            this._weatherforecast = weatherforecast;
            Console.WriteLine($"The Weather Forecast: {weatherforecast}");

        }

        /// <summary>
        /// Displays Short Datails Message of a outdoorgatherings event.
        /// </summary>
        /// <param name="event">The event.</param> 
        public void ShortDescription(Event eventone)
        {
            Console.WriteLine($"Event Type: OutdoorGatherings");
            Console.WriteLine($"{eventone.GetTitle()}");
            Console.WriteLine($"Date: {eventone.GetDate()}");
        }

    }
}