

namespace GameSix
{
    public class Foe
    {

        private string name;
        private float health;
        private float shield;

        /// <summary>
        /// Constructor
        /// </summary>
        /// <param name="name"> Name of the Foe </param>
        public Foe(string name)
        {
            this.name = name;
            health = 100;
            shield = 100;
        }
    }
}