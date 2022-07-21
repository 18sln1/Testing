using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BMEG_summer_crash_course
{
    class Program
    {
         static void Main(string[] args)
        {

            int n = 5;
            int[] foo = new int[5] { 1, 2, 3, 4, 5 };

            int m = 100;
            int[] bar = new int[100];

            for (int i = 0; i < m; i++)
            {
                bar[i] = i;
            }

            Console.WriteLine($"The total number of even number in foo are: {countEvenNum1.countEvenNum(foo, n)}");
            Console.WriteLine($"The total number of even number in bar are: {countEvenNum1.countEvenNum(bar, m)}");
        }
    }
}

class countEvenNum1 {
    public static int countEvenNum(int[] args, int size)
    {
        int count = 0;
        for (int i = 0; i < size; i++)
        {
            if (args[i] % 2 == 0)
            {
                count++;
            }
        }
        return count;
    }

}
