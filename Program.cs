using System;
using System.Collections.Generic;
using System.Media;
using System.Runtime.InteropServices;
using System.Threading;

namespace battleOfDroids
{
    internal class Program
    {   private static BattleField field = new BattleField();
        public static void Main(string[] args)
        {
            field.show();
            while (true)
            {
                playerMove();
                enemyMove();
            }
        }

        private static void playerMove()
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
        
        private static void enemyMove()
        {
            var direction = new Random().Next(1, 5);
            if (direction == 1)
                field.moveEnemy('l');
            else if (direction == 2)
                field.moveEnemy('r');
            else if (direction == 3)
                field.moveEnemy('d');
            else if (direction == 4)
                field.moveEnemy('u');
        }
    }

    internal class BattleField
    {
        private Droid player = new Droid(size-2, size-2);
        private Droid enemy = new Droid(3, 3);
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
            show(player);
            show(enemy);
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
            hide(player);
            if (direction == 'l' && player.getX() > 1)
                player.moveLeft();
            else if (direction == 'r' && player.getX() < size)
                player.moveRight();
            else if (direction == 'd' && player.getY() < size)
                player.moveDown();
            else if (direction == 'u' && player.getY() > 1)
                player.moveUp();
            show(player);
        }
        
        public void moveEnemy(char direction)
        {
            hide(enemy);
            if (direction == 'l' && enemy.getX() > 1)
                enemy.moveLeft();
            else if (direction == 'r' && enemy.getX() < size)
                enemy.moveRight();
            else if (direction == 'd' && enemy.getY() < size)
                enemy.moveDown();
            else if (direction == 'u' && enemy.getY() > 1)
                enemy.moveUp();
            show(enemy);
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