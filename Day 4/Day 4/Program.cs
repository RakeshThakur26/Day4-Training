using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Day_4
{
    class Program
    {
        static void Main(string[] args)
        {
            DelegateDemo dd = new DelegateDemo();
            DelMethod dm = new DelMethod(DelegateDemo.Method);
            dm(5);

            Console.Read();
        }
    }
}
