using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Pythagorean_triple
{
    class PythagoreanTriplets
    {
        public void FindPythagoreanTriplets(int sum)
        {
            for (int a = 1; a <= sum / 3; a++)
            {
                for (int b = a + 1; b <= sum / 2; b++)
                {
                    int c = sum - a - b;
                    if (a * a + b * b == c * c)
                        Console.WriteLine($"a={a}, b={b}, c={c}");
                }
            }
        }
    }
}
