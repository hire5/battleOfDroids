using System;

namespace battleOfDroids
{
    public abstract class Object2D
    {
        protected int x;
        protected int y;
        private char look;
        
        protected Object2D(int x, int y, char look)
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
        
        public void hide()
        {
            Console.SetCursorPosition(x, y);
            Console.Write(' ');
        }
        
        public void show()
        {
            Console.SetCursorPosition(x, y);
            Console.Write(look);
        }
    }
}