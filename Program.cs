using System;
using System.Collections.Generic;
using System.Runtime.InteropServices;
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
        private Droid droid = new Droid(1, 1);
        
        public void show()
        {
            Console.WriteLine("000000000000");
            for(var i = 0;i<10;i++)
                Console.WriteLine("0          0");
            Console.WriteLine("000000000000");
            Console.SetCursorPosition(droid.getX(), droid.getY());
            Console.Write('X');
        }
    }

    internal class Droid
    {
        private int x;
        private int y;

        public Droid(int x, int y)
        {
            this.x = x;
            this.y = x;
        }

        public int getX()
        {
            return x;
        }
        
        public int getY()
        {
            return y;
        }
    }
}