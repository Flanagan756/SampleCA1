using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SampleCA1
{
    class Player
    {
        public int PlayerID { get; }
        public string PlayerName { get; set; }
        public  int PlayerScore { get; private set; } //can only be access from within the class

        public Player(int id, string name, int score)
        {
            //sets properties within default constructor
            PlayerID = id;
            PlayerName = name;
            PlayerScore = score;
        }
        public void IncreaseScore(int valueToAdd)
        {
            if (PlayerScore < 100)
            {
                PlayerScore += valueToAdd;
            }
        }

        
    }
}
