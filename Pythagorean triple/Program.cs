using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Pythagorean_triple
{
    class Program
    {
        static void Main(string[] args)
        {
            PythagoreanTriplets PT = new PythagoreanTriplets();
            int sum = 1000;
            PT.FindPythagoreanTriplets(sum);
        }
    }
}
