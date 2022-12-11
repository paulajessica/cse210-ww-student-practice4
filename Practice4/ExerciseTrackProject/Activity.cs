using System;

namespace Practice4.ExerciseTrackProject
{
    /// <summary>
    /// <para>
    /// The responsibility of Activity is to be base class to Cycling, Running and Swimming Classes.
    /// </para>
    /// </summary>
    public interface Activity
    {

        string GetDate();

        int GetLength();

        double GetDistance();

        void SetDate(string date);

        void SetLength(int length);

        void SetDistance(double distance);

        double Speed();

        double Pace();

        void GetSummary(Activity activity);

    }



}