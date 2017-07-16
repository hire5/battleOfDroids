using System;

namespace battleOfDroids
{
    public class BattleField
    {
        Droid player = new Droid(size-2, size-2, 'o');
        Droid enemy = new Droid(3, 3, 'x');
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

        void hide(Droid droid)
        {
            Console.SetCursorPosition(droid.getX(), droid.getY());
            Console.Write(' ');
        }

        void show(Droid droid)
        {
            Console.SetCursorPosition(droid.getX(), droid.getY());
            Console.Write(droid.getLook());
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
}