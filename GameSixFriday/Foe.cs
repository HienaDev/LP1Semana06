using System;

namespace GameSixFriday
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

        /// <summary>
        /// Initalizes static variables
        /// </summary>
        static Foe()
        {
            powerUpsUsed = 0;
        }
        
        /// <summary>
        /// Returns name of instance Foe
        /// </summary>
        /// <returns></returns>
        public string GetName() => name;

        /// <summary>
        /// Returns health of instance Foe
        /// </summary>
        /// <returns></returns>
        public float GetHealth() => health;

        /// <summary>
        /// Returns shield of instance Foe
        /// </summary>
        /// <returns></returns>
        public float GetShield() => shield;

        /// <summary>
        /// Changes name of instance Foe
        /// </summary>
        /// <param name="name"> New name for foe </param>
        public void SetName(string name)
        {
            name = name.Trim(' ');
            this.name = name;
        }
        
        /// <summary>
        /// Returns how many times power ups were used
        /// </summary>
        /// <returns></returns>
        public static int GetPowerUpsUsed() => powerUpsUsed;

        /// <summary>
        /// Deals damage to foe
        /// </summary>
        /// <param name="damage"> damage to be dealt to foe </param>
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

        /// <summary>
        /// Increases parameter "power" by the float number but it
        /// never goes above 100
        /// </summary>
        /// <param name="power"> Health or Shield</param>
        /// <param name="number"> numer to be multiplied by </param>
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