using System;

namespace battleOfDroids
{
    public class BattleField
    {
        int size = 25;
        Droid player;
        Droid enemy;
        Base playerBase;
        Base enemyBase;

        public BattleField()
        {
            playerBase = new Base(size-2, size-2, 'O');
            enemyBase = new Base(3, 3, 'X');
        }
        
        public int getSize()
        {
            return size;
        }
        
        public void setPlayer(Droid player)
        {
            this.player = player;
        }
        
        public void setEnemy(Droid enemy)
        {
            this.enemy = enemy;
        }
        
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
            player.show();
            enemy.show();
            playerBase.show();
            enemyBase.show();
            removeCursor();
        }

        public void removeCursor()
        {
            Console.SetCursorPosition(size+2, size+1);
        }
    }
}