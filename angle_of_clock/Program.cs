// See https://aka.ms/new-console-template for more information


using System;

public class AngleOfClock
{
    public static void Main()
    {
        int hour, minute;
        double angle;

        // two input: hour hand and minute hand
        Console.Write("Enter hour hand: ");
        hour = Convert.ToInt32(Console.ReadLine());

        Console.Write("Enter minute hand: ");
        minute = Convert.ToInt32(Console.ReadLine());

        angle = Math.Abs(0.5 * (60 * hour - 11 * minute));

        if (angle > 180)
            angle = 360 - angle;

        // output: angle between hour hand and minute hand
        Console.WriteLine("Angle between hour hand and minute hand: {0}", angle);
    }
}