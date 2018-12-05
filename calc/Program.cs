using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace calc
{
    class Program
    {
        static void Main(string[] args)
        {
            MyMaht maht = new MyMaht();
            Console.WriteLine(maht.add(4, 5));
            Console.WriteLine(maht.Sub(4, 5));
            Console.ReadLine();
        }
    }
}
