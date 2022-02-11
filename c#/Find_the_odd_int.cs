using System;
using System.Collections.Generic;
using System.Linq;

namespace ConsoleApp1
{
    public class Program
    {
        static void Main(string[] args)
        {

        }
        public static int Solution(int[] value)
        {
            return value
                .ToList()
                .GroupBy(x => x)
                .Where(x => x.Count() % 2 != 0)
                .First().Key;
        }
    }
}
