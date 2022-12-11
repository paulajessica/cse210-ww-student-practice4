using System;
using Practice4.ExerciseTrackProject;

namespace Practice4.ExerciseTrackProject
{

    /// <summary>
    /// The program's entry point.
    ///  Polymorphism as the name says, is related to the shape of something, in other words,
    /// changing a method of a class in another child's class. In the Exercise Track Project,
    /// I could apply that technique using activity class as a base class (interface) to all the
    /// methods and, customize according to the trait of each of them.
    /// </summary>
    class Program
    {

        /// <summary>
        /// Starts the program using the given arguments.
        /// </summary>
        /// <param name="args">The given arguments.</param>
        static void Main(string[] args)
        {
            //Creates Activities List
            List<Activity> _activities = new List<Activity>();

            //Creates Running Activity
            Running _running = new Running();
            _running.SetDistance(4.8);
            _running.SetDate("03 Nov 2022");
            _running.SetLength(30);
            _activities.Add(_running);

            // //Creates Cycling Activity
            Cycling _cycling = new Cycling();
            _cycling.SetDistance(10);
            _cycling.SetDate("15 Nov 2022");
            _cycling.SetLength(30);
            _activities.Add(_cycling);

            //Creates Swimming Activity
            Swimming _swimming = new Swimming();
            _swimming.SetDistance(12);
            _swimming.SetDate("20 Nov 2022");
            _swimming.SetLength(60);
            _activities.Add(_swimming);


            // Scrolls through a list and displays the summary message
            foreach (Activity activity in _activities)
            {
                activity.GetSummary(activity);
            }

        }
    }
}
