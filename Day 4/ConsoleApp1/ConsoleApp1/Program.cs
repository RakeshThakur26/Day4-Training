using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;



namespace ConsoleApp1
{
    public delegate void send(int j);

    public class Program
    {
        static void Main(string[] args)
        {
            //int up = 0, down = 10000;
            //del obj = new del();

            //obj.se += add;
            //obj.se += sub;
            //void add(int i)
            //{
            //    up = up + i;
            //    Console.WriteLine(up);
            //}
            //void sub(int i)
            //{
            //    down = down - i;
            //    Console.WriteLine(down);
            //}

            send sa = new send(del.add);
            sa(10);

            send sb = new send(del.sub);
            sb(30);
            Console.Read();
        }
    }
    public class del
    {
        
        public static void add(int k)
        {
            int up = k;
            up = up + 1;
            Console.WriteLine(up);
        }

        public static void sub(int k)
        {
            int down = k;
            down = down - 1;
             Console.WriteLine(down);
        }

    }
}
