using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Zamka
{
    class Program
    {
        static void Main(string[] args)
        {
            int min = int.Parse(Console.ReadLine());
            int max = int.Parse(Console.ReadLine());
            int sum = int.Parse(Console.ReadLine());

            SortedSet<int> matches = new SortedSet<int>();

            for (int i = min; i <= max; i++)
            {
                string tempS = i.ToString();
                int tempI = 0;

                for (int ii = 0; ii < tempS.Length; ii++)
                {
                    tempI += int.Parse(tempS[ii].ToString());
                }

                if (tempI == sum)
                {
                    matches.Add(i);
                }
            }

            Console.WriteLine(matches.Min);
            Console.WriteLine(matches.Max);
        }
    }
}
