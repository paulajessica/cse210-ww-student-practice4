using System;

namespace Practice3.EventPlanningProject
{
    /// <summary>
    /// <para>
    /// The responsibility of Lectures is to get lectures event's the speaker and the capacity.
    /// </para>
    /// </summary>
    public class Lectures : Event
    {
        string _speaker = "";
        int _capacity = 0;

        /// <summary>
        /// Constructs a new instance of Comment.
        /// </summary>
        public Lectures()
        {


        }
        /// <summary>
        /// Displays Full Datails Message of a lecture event.
        /// </summary>
        /// <param name="speaker">The speaker of a lecture event.</param>
        /// <param name="capacity">The capacity of a lecture event.</param>
        /// <param name="event">The event.</param>       
        public void FullDetail(string speaker, int capacity, Event eventone)
        {
            eventone.StandardDetails(eventone.GetTitle(), eventone.GetDescription(), eventone.GetDate(), eventone.GetTime(), eventone);
            this._speaker = speaker;
            this._capacity = capacity;
            Console.WriteLine($"Speaker: {speaker}");
            Console.WriteLine($"Capacity: {capacity}");

        }

        /// <summary>
        /// Displays Short Datails Message of a lecture event.
        /// </summary>
        /// <param name="event">The event.</param> 
        public void ShortDescription(Event eventone)
        {
            Console.WriteLine($"Event Type: Lectures");
            Console.WriteLine($"{eventone.GetTitle()}");
            Console.WriteLine($"Date: {eventone.GetDate()}");
        }
    }
}