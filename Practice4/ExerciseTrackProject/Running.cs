using System;

namespace Practice4.ExerciseTrackProject
{
    /// <summary>
    /// <para>
    /// The responsibility of Running is to get running activity's the date, the length and distance.
    /// </para>
    /// </summary>
    public class Running : Activity
    {
        private string _date = "";
        private int _length = 0;//minut
        private double _distance = 0;//kilometers

        /// <summary>
        /// Constructs a new instance of Running.
        /// </summary>
        public Running()
        {

        }
        public string GetDate()
        {
            return _date;
        }
        public int GetLength()
        {
            return _length;
        }
        public double GetDistance()
        {
            return _distance;
        }
        public void SetDate(string date)
        {
            this._date = date;
        }
        public void SetLength(int length)
        {
            this._length = length;
        }

        public void SetDistance(double distance)
        {
            this._distance = distance;
        }

        /// <summary>
        /// Calculates the speed of a activity.
        /// </summary>
        public double Speed()
        {
            return (GetDistance() / GetLength()) * 60;

        }

        /// <summary>
        /// Calculates the pace of a activity.
        /// </summary>
        public double Pace()
        {
            return GetLength() / GetDistance();

        }

        /// <summary>
        /// Displays the summary of a activity.
        /// </summary>
        /// <param name="activity">The activity.</param>
        public void GetSummary(Activity activity)
        {
            Console.WriteLine($"{GetDate()} Running ({GetLength()} min) - Distance: {GetDistance().ToString("F")} Km,  Speed: {Speed().ToString("F")} kph, Pace: {Pace().ToString("F")} min per km");
        }
    }
}