using System;
using System.Collections.Generic;
using System.Media;
using System.Runtime.InteropServices;
using System.Threading;

namespace battleOfDroids
{
    class BattleOfDroids
    {   
        static BattleField field = new BattleField();
        static Droid player = new Droid(field.getSize()-3, field.getSize()-3, 'o',field);
        static Droid enemy = new Droid(4, 4, 'x',field);
        public static void Main(string[] args)
        {
            field.setPlayer(player);
            field.setEnemy(enemy);
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
                player.move('l');
            else if (input == ConsoleKey.RightArrow)
                player.move('r');
            else if (input == ConsoleKey.DownArrow)
                player.move('d');
            else if (input == ConsoleKey.UpArrow)
                player.move('u');
            else if (input == ConsoleKey.D1)
                player.shoot(enemy);
            else if (input == ConsoleKey.D2)
                player.shoot(enemy);
            field.refresh();
        }
        
        static void enemyMove()
        {
            var direction = new Random().Next(1, 5);
            if (direction == 1)
                enemy.move('l');
            else if (direction == 2)
                enemy.move('r');
            else if (direction == 3)
                enemy.move('d');
            else if (direction == 4)
                enemy.move('u');
            field.refresh();
        }
    }
}