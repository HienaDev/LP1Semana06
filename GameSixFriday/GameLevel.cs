using System;

namespace GameSixFriday
{
    public class GameLevel
    {

        private int rooms;
        private Difficulty difficulty;
        private Foe[] foesInRoom;

        public GameLevel(int rooms, Difficulty difficulty)
        {
            this.rooms = rooms;
            this.difficulty = difficulty;
            foesInRoom = new Foe[rooms];
        }

        /// <summary>
        /// Returns the difficulty of the level
        /// </summary>
        /// <returns></returns>
        public Difficulty GetDifficulty() => difficulty;

        /// <summary>
        /// Returns the number of rooms
        /// </summary>
        /// <returns></returns>
        public int GetNumRooms() => rooms;

        /// <summary>
        /// Puts a foe in room index
        /// </summary>
        /// <param name="room"> index of the room </param>
        /// <param name="foe"> foe to be put in the room </param>
        public void SetFoeInRoom(int room, Foe foe)
        {
            foesInRoom[room] = foe;
        }

        /// <summary>
        /// Returns the number of foes
        /// </summary>
        /// <returns></returns>
        public int GetNumFoes()
        {
            int numberOfFOes = 0;

            foreach(Foe foe in foesInRoom)
            {
                if (foe != null)
                {
                    numberOfFOes += 1;
                }
            }

            return (numberOfFOes);
        }

        /// <summary>
        /// Prints the name of the foes and the room they are on
        /// </summary>
        public void PrintFoes()
        {
            for (int i = 0; i < rooms; i++)
            {
                if(foesInRoom[i] != null)
                {
                    string name = foesInRoom[i].GetName();
                    Console.WriteLine($"Room {i}: {name}");
                }
            }
        }
    }

}