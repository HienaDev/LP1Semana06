using System;

namespace GameSix
{
    public class Foe
    {

        private static int powerUpsUsed;
        private string name;
        private float health;
        private float shield;

        /// <summary>
        /// Constructor
        /// </summary>
        /// <param name="name"> Name of the Foe </param>
        public Foe(string name)
        {
            SetName(name);
            health = 40;
            shield = 55;
        }

        static Foe()
        {
            powerUpsUsed = 0;
        }

        public string GetName() => name;

        public float GetHealth() => health;

        public float GetShield() => shield;

        public void SetName(string name)
        {
            name = name.Trim(' ');
            this.name = name;
        }

        public static int GetPowerUpsUsed() => powerUpsUsed;

        public void TakeDamage(float damage)
        {
            shield -= damage;

            if (shield < 0)
            {

                float damageStillToInflict = -shield;
                shield = 0;
                health -= damageStillToInflict;

                if (health < 0 ) health = 0;
            }
        }

        public void PickupPowerUp(PowerUp power, float number)
        {
            if (power == PowerUp.Health)
            {
                health *= number;
                if (health > 100) health = 100;
            }
            else if (power == PowerUp.Shield)
            {
                shield *= number;
                if (shield > 100) shield = 100;
            }

            powerUpsUsed += 1;
        }
        
    }
}