using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Day_4
{
    public delegate void DelMethod(int x);
    class DelegateDemo
    {
        public static void Method(int x)
        {
            Console.WriteLine("Delegated Method ");
        }

    }
}
