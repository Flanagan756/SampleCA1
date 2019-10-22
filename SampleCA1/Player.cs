using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SampleCA1
{
    public class Player : IComparable
    {
        public int PlayerID { get; }
        public string PlayerName { get; set; }
        public  int PlayerScore { get; private set; } //can only be access from within the class

        public static int HighScore { get; private set; } //Belongs to all player objects and cannot be set from ourside the class
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

            //check for highscore
            if (PlayerScore > HighScore)
            {
	         HighScore = PlayerScore;
            }	

        }
        public int CompareTo(object obj)
        {
            //get a reference to the next object in the list/array/collection
            Player objectThatIAmComparingTo = (Player)obj; //now we have something to compare our current obkect to
            //indicate what field I want to compare
            int returnValue = this.PlayerScore.CompareTo(objectThatIAmComparingTo.PlayerScore);
            //return
            return returnValue;
        }
        public override string ToString()
        {
            return ($"{PlayerID,-10}{PlayerName,-10}{PlayerScore,-10}");
        }
    }
}

