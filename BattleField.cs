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
        int line;
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
            Console.Write("\n\n     1 - shoot");
            player.show();
            enemy.show();
            playerBase.show();
            enemyBase.show();
            showInfo();
        }

        void showLine(string info)
        {
            Console.Write(info);
            Console.SetCursorPosition(size+5, Console.CursorTop+1);
        }

        void showInfo()
        {
            Console.SetCursorPosition(size + 5, 3);
            showLine(playerBase.getInfo());
            showLine(player.getInfo());
            showLine(enemyBase.getInfo());
            showLine(enemy.getInfo());
        }
        
        public void refresh()
        {
            for (int i = 3; i < size; i++)
            {
                Console.SetCursorPosition(size+5, i);
                Console.Write("                         ");
            }
            showInfo();
        }
    }
}