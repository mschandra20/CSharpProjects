using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using BSorter;

namespace BubbleSorter
{
    class Program
    {
        static void Main(string[] args)
        {
            Sorter s = new Sorter();
            s.Input();
            s.Display();
        }
    }
}
