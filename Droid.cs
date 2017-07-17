using System;

namespace battleOfDroids
{
    public class Droid : HealthObject
    {
        BattleField field;
        int damage = 10;
        
        public Droid(int x, int y, char look) : base(x, y, look)
        {
        }

        public Droid(int x, int y, char look, BattleField field) : base(x, y, look)
        {
            this.field = field;
        }
        
        public void setField(BattleField field)
        {
            this.field = field;
        }
        
        public void move(char direction)
        {
            hide();
            if (direction == 'l' && x > 1)
                x--;
            else if (direction == 'r' && x < field.getSize())
                x++;
            else if (direction == 'd' && y < field.getSize())
                y++;
            else if (direction == 'u' && y > 1)
                y--;
            show();
        }

        public void shoot(HealthObject target)
        {
            target.getDamage(damage);
        }
    }
}