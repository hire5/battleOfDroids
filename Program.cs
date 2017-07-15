using System;
using System.Collections.Generic;
using System.Runtime.InteropServices;
using System.Threading;
// ReSharper disable All

namespace battleOfDroids
{
    internal class Program
    {
        public static void Main(string[] args)
        {
            var field = new BattleField();
            field.show();
            while (true)
            {
                field.show();
                var input = Console.ReadKey().Key;

                if (input == ConsoleKey.LeftArrow)
                    field.movePlayer('l');
                else if (input == ConsoleKey.RightArrow)
                    field.movePlayer('r');
                else if (input == ConsoleKey.DownArrow)
                    field.movePlayer('d');
                else if (input == ConsoleKey.UpArrow)
                    field.movePlayer('u');
            }
        }
    }

    internal class BattleField
    {
        private Droid droid = new Droid(1, 1);
        
        public void show()
        {   
            Console.Clear();
            Console.WriteLine("000000000000");
            for(var i = 0;i<10;i++)
                Console.WriteLine("0          0");
            Console.WriteLine("000000000000");
            Console.SetCursorPosition(droid.getX(), droid.getY());
            Console.Write('X');
        }

        public void movePlayer(char direction)
        {
            if (direction == 'l')
                droid.moveLeft();
            else if (direction == 'r')
                droid.moveRight();
            else if (direction == 'd')
                droid.moveDown();
            else if (direction == 'u')
                droid.moveUp();
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

        public void moveLeft()
        {
            if (x > 1)
                x--;
        }
        
        public void moveRight()
        {
            if (x < 10)
                x++;
        }
        
        public void moveDown()
        {
            if (y < 10)
                y++; 
        }
        
        public void moveUp()
        {
            if (y > 1)
                y--;
        }
    }
}