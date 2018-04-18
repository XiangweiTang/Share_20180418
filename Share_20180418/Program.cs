using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Share_20180418
{
    class Program
    {
        static void Main(string[] args)
        {
            Solution sln = new Solution();
            var r = sln.KthInList(new int[] { 3, 4, 7, 8, 2, 10, 5, 6, 1, 9 }, 7);
        }

        static Random r = new Random();
        static IEnumerable<int> RandomList()
        {
            while (true)
            {
                yield return r.Next(5);
            }
        }
    }
}
