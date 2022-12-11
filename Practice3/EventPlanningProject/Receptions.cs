using System;

namespace Practice3.EventPlanningProject
{
    /// <summary>
    /// <para>
    /// The responsibility of Receptions is to get receptions event's the email rspv.
    /// </para>
    /// </summary>
    public class Receptions : Event
    {
        private string _emailrspv = "";

        /// <summary>
        /// Constructs a new instance of Comment.
        /// </summary>
        public Receptions()
        {

        }

        /// <summary>
        /// Displays Full Datails Message of a repection event.
        /// </summary>
        /// <param name="email">The email of a repection event.</param>
        /// <param name="event">The event.</param>       
        public void FullDetail(string email, Event eventone)
        {

            eventone.StandardDetails(eventone.GetTitle(), eventone.GetDescription(), eventone.GetDate(), eventone.GetTime(), eventone);
            this._emailrspv = email;
            Console.WriteLine($"E-mail for RSVP: {email}");

        }

        /// <summary>
        /// Displays Short Datails Message of a reception event.
        /// </summary>
        /// <param name="event">The event.</param> 
        public void ShortDescription(Event eventone)
        {
            Console.WriteLine($"Event Type: Receptions");
            Console.WriteLine($"{eventone.GetTitle()}");
            Console.WriteLine($"Date: {eventone.GetDate()}");
        }

    }
}