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
        public const int size = 25;
        
        public void show()
        {   
            Console.Clear();
            for(int i = -1;i<=size;i++)
                Console.Write('0');
            Console.WriteLine();
            for (int i = 0; i < size; i++)
            {
                Console.Write('0');
                for (int j = 0; j < size; j++)
                    Console.Write(' ');
                Console.WriteLine('0');
            }
            for(int i = -1;i<=size;i++)
                Console.Write('0');
            show(droid);
        }

        private void hide(Droid droid)
        {
            Console.SetCursorPosition(droid.getX(), droid.getY());
            Console.Write(' ');
        }

        private void show(Droid droid)
        {
            Console.SetCursorPosition(droid.getX(), droid.getY());
            Console.Write('X');
            Console.SetCursorPosition(size+2, size+1);
        }
        public void movePlayer(char direction)
        {
            hide(droid);
            if (direction == 'l' && droid.getX() > 1)
                droid.moveLeft();
            else if (direction == 'r' && droid.getX() < size)
                droid.moveRight();
            else if (direction == 'd' && droid.getY() < size)
                droid.moveDown();
            else if (direction == 'u' && droid.getY() > 1)
                droid.moveUp();
            show(droid);
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
                x--;
        }
        
        public void moveRight()
        {
                x++;
        }
        
        public void moveDown()
        {
                y++; 
        }
        
        public void moveUp()
        {
                y--;
        }
    }
}