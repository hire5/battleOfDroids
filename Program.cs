using System;
using System.Collections.Generic;
using System.Threading;

namespace battleOfDroids
{
    internal class Program
    {
        public static void Main(string[] args)
        {
            var field = new BattleField();
            field.show();
            var v = Console.ReadLine();
        }
    }

    internal class BattleField
    {
        public void show()
        {
            Console.WriteLine("000000000000");
            for(var i = 0;i<10;i++)
                Console.WriteLine("0          0");
            Console.WriteLine("000000000000");
        }
    }
}