namespace battleOfDroids
{
    public class HealthObject : Object2D
    {
        int health = 100;
        int maxHealth = 100;
        bool isDead;
        
        public HealthObject(int x, int y, char look) : base(x, y, look)
        {
        }

        public string getInfo()
        {
            string info = look + " - ";
            if (isDead)
                return info + "DEAD";
            return info + health + '/' + maxHealth + " hp";
        }

        public void getDamage(int damage)
        {
            health -= damage;
            if (health < 1)
                isDead = true;
        }
        
    }
}