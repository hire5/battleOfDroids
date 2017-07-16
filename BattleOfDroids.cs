using System;
using System.Collections.Generic;
using System.Media;
using System.Runtime.InteropServices;
using System.Threading;

namespace battleOfDroids
{
    internal class BattleOfDroids
    {   static BattleField field = new BattleField();
        public static void Main(string[] args)
        {
            field.show();
            while (true)
            {
                playerMove();
                enemyMove();
            }
        }

        static void playerMove()
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
        
        static void enemyMove()
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
}