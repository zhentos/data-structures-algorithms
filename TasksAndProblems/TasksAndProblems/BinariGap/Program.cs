using System;
using System.Linq;
using System.Text.RegularExpressions;

namespace BinariGap
{
    public class Solution
    {
        public int solution(int N)
        {
            var binary = Convert.ToString(N, 2);
            var regex = new Regex("(?<=1)(0+)(?=1)");

            int result = regex.Matches(binary).Cast<Match>().Select(x => x.Length).DefaultIfEmpty(0).Max();
            return result;
        }
    }
    class Program
    {
        static void Main(string[] args)
        {
            var p = new Solution();
            var result = p.solution(9);
            Console.WriteLine(result);
        }
    }
}
