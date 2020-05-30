using System;
using System.Collections.Generic;
using System.Linq;

namespace MeetupSchedule
{
    class Program
    {
        public static int CountMeetings(List<int> firstDay, List<int> lastDay)
        {
            var count = 0;
            count = firstDay.Concat(lastDay).Distinct().Count();
            if (count > firstDay.Count)
            {
                count = firstDay.Count;
            }
            return count;
        }
        static void Main(string[] args)
        {
            Console.WriteLine("Hello World!");
        }
    }
}
