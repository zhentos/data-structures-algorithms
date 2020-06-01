using System;
using System.Collections.Generic;
using System.Linq;

namespace MeetupSchedule
{
    class Program
    {
        //Passed 8 from 12 tests
        //For the input firstDay = [1,1,1] lastDay = [5,5,5]
        //this code returns 2 however correct answer is 3
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
