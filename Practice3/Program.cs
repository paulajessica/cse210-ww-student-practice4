using System;
using Practice3.EventPlanningProject;

namespace Practice3
{
    /// <summary>
    /// The program's entry point.
    /// Inheritance in programming allows us to share attributes, methods, and other class members.
    /// In the Event Planning Project, I could apply this concept in Event, Lectures, Outdoor Gatherings,
    ///and Receptions Classes. This way, I've used methods from another class without the need to repeat them.
    /// </summary>
    class Program
    {
        /// <summary>
        /// Starts the program using the given arguments.
        /// </summary>
        /// <param name="args">The given arguments.</param>
        static void Main(string[] args)
        {
            // Creates a Lectures Event
            Lectures _lectures = new Lectures();
            _lectures.SetTitle("Topics in International Technology Managemen");
            _lectures.SetDescription("Each year, this series explores different themes such as 'Green Technologies in Transportation'\nto 'The Rise of Commercial Space Businesses in Asia'. Distinguished speakers from industry\nand government are invited to discuss and share their insights.");
            _lectures.SetDate("2022-12-12");
            _lectures.SetTime("6pm");
            _lectures.SetStreet("450 Serra Mall");
            _lectures.SetCity("Stanford");
            _lectures.SetState("CA 94305");
            _lectures.SetCountry("United States");
            _lectures.FullDetail("John Smith", 5000, _lectures);
            _lectures.StandardDetails(_lectures.GetTitle(), _lectures.GetDescription(), _lectures.GetDate(), _lectures.GetTime(), _lectures);
            _lectures.ShortDescription(_lectures);

            // Creates a Receptions Event
            Receptions _receptions = new Receptions();
            _receptions.SetTitle("Evening Reception");
            _receptions.SetDescription("Together with their families,\nElizabeth and James\ninvite you to celebrate their marriage.\nPlease RSPV by 1st April");
            _receptions.SetDate("On Satuday 31st July 2021");
            _receptions.SetTime("7pm");
            _receptions.SetStreet("2011 John Lennon");
            _receptions.SetCity("California");
            _receptions.SetState("CA 9633");
            _receptions.SetCountry("United States");
            _receptions.FullDetail("lizjames@yahoo.com", _receptions);
            _receptions.StandardDetails(_receptions.GetTitle(), _receptions.GetDescription(), _receptions.GetDate(), _receptions.GetTime(), _receptions);
            _receptions.ShortDescription(_receptions);

            // Creates a Outdoor Gatherins Event
            OutdoorGatherings _outdoorgatherings = new OutdoorGatherings();
            _outdoorgatherings.SetTitle("2022 Candlelight Ski Events");
            _outdoorgatherings.SetDescription("The Zippel Bay State Park Friends Group\nwould like to invite you to come enjoy\nan event outdoors at our Candlelight Ski\nand Snowshoe Events.");
            _outdoorgatherings.SetDate("January 15 - February 19");
            _outdoorgatherings.SetTime("4pm - 8pm");
            _outdoorgatherings.SetStreet("344 Joseph Taylor");
            _outdoorgatherings.SetCity("Utah");
            _outdoorgatherings.SetState("UH 955");
            _outdoorgatherings.SetCountry("Unated States");
            _outdoorgatherings.FullDetail("Snowy weather", _outdoorgatherings);
            _outdoorgatherings.StandardDetails(_outdoorgatherings.GetTitle(), _outdoorgatherings.GetDescription(), _outdoorgatherings.GetDate(), _outdoorgatherings.GetTime(), _outdoorgatherings);
            _outdoorgatherings.ShortDescription(_outdoorgatherings);
        }


    }
}
