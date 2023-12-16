using System;

namespace datetime_properties
{
    class Program
    {
        static void Main(string[] args)
        {
            DateTime d = new DateTime(2001, 8, 15, 13, 45, 58, 275);

            //Console.WriteLine(d);
            //Console.WriteLine("1) Date: " + d.Date);
            //Console.WriteLine("2) Day: " + d.Day);
            //Console.WriteLine("3) DayOfWeek: " + d.DayOfWeek);
            //Console.WriteLine("4) DayofYear: " + d.DayOfYear);
            //Console.WriteLine("5) Hour: " + d.Hour);
            //Console.WriteLine("6) Kind: " + d.Kind);
            //Console.WriteLine("7) Millisecond: " + d.Millisecond);
            //Console.WriteLine("8) Month: " + d.Month);
            //Console.WriteLine("9) Minute: " + d.Minute);
            //Console.WriteLine("10) Second: " + d.Second);
            //Console.WriteLine("11) Ticks: " + d.Ticks);
            //Console.WriteLine("12) TimeOfDay: " + d.TimeOfDay);
            //Console.WriteLine("13) Year: " + d.Year);

            //string s1 = d.ToLongDateString();
            //string s2 = d.ToLongTimeString();
            //string s3 = d.ToShortDateString();
            //string s4 = d.ToShortTimeString();

            //string s5 = d.ToString();

            //string s6 = d.ToString("yyyy-MM-dd HH:mm:ss");
            //string s7 = d.ToString("yyyy-MM-dd HH:mm:ss.fff");

            //Console.WriteLine(s1);
            //Console.WriteLine(s2);
            //Console.WriteLine(s3);
            //Console.WriteLine(s4);
            //Console.WriteLine(s5);
            //Console.WriteLine(s6);
            //Console.WriteLine(s7);

            //DateTime a = d.Add(TimeSpan);
            //DateTime b = d.AddDays(double);
            //DateTime c = d.AddHours(double);
            //DateTime e = d.AddMilliseconds(double);
            //DateTime f = d.AddMinutes(double);
            //DateTime g = d.AddMonths(double);
            //DateTime h = d.AddSeconds(double);
            //DateTime i = d.AddTicks(long);
            //DateTime j = d.AddYears(int);

            //DateTime k = d.Subtract(TimeSpan);
            //DateTime l = d.Subtract(DateTime);

            DateTime d2 = d.AddHours(2);

            Console.WriteLine(d);
            Console.WriteLine(d2);

        }
    }
}