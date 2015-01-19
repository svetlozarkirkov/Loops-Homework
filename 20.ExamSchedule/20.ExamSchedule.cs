using System;
using System.Globalization;

namespace ExamSchedule
{
    class ExamSchedule
    {
        static void Main()
        {
            string hour = Console.ReadLine();
            string minutes = Console.ReadLine();
            string partofday = Console.ReadLine();
            int durationHours = int.Parse(Console.ReadLine());
            int durationMinutes = int.Parse(Console.ReadLine());

            string joinedTime = hour + ":" + minutes + ":" + partofday;

            DateTime beginTime = DateTime.ParseExact(joinedTime, "h:m:tt", CultureInfo.CreateSpecificCulture("en-US"));
            DateTime finalTime = beginTime;

            finalTime = beginTime.AddHours(durationHours);
            finalTime = finalTime.AddMinutes(durationMinutes);

            Console.WriteLine(finalTime.ToString("hh:mm:tt", CultureInfo.InvariantCulture));
        }
    }
}