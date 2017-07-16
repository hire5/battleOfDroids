namespace battleOfDroids
{
    public class Droid
    {
        int x;
        int y;
        char look;

        public Droid(int x, int y, char look)
        {
            this.x = x;
            this.y = x;
            this.look = look;
        }

        public int getX()
        {
            return x;
        }
        
        public int getY()
        {
            return y;
        }


        public char getLook()
        {
            return look;
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