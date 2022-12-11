using System;

namespace Practice4.ExerciseTrackProject
{

    /// <summary>
    /// <para>
    /// The responsibility of Swimming is to get swimming activity's the lap number, the date and length.
    /// </para>
    /// </summary>
    public class Swimming : Activity
    {
        private double _lapnumber = 0;//kilometers
        private string _date = "";
        private int _length = 0;//minut



        /// <summary>
        /// Constructs a new instance of Swimming.
        /// </summary>
        public Swimming()
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
            return _lapnumber;
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
            this._lapnumber = distance;
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
            Console.WriteLine($"{GetDate()} Swimming ({GetLength()} min) - Distance: {GetDistance().ToString("F")} Km,  Speed: {Speed().ToString("F")} kph, Pace: {Pace().ToString("F")} min per km");
        }



    }
}