using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SampleCA1
{
    class Program
    {
        static void Main(string[] args)
        {
            Player player1 = new Player(1, "Millie", 0);
            Player player2 = new Player(2, "Katie", 0);
            Player player3 = new Player(3, "Kevin", 0);
            Player player4 = new Player(4, "Conor", 0);
            Player player5 = new Player(5, "Pauline", 0);

            //List of players in player class
            List<Player> allPlayers = new List<Player>();
            //adds each player to the list
            allPlayers.Add(player1);
            allPlayers.Add(player2);
            allPlayers.Add(player3);
            allPlayers.Add(player4);
            allPlayers.Add(player5);


            //display all players with scores based on Display method in Program.cs
            Display(allPlayers);
            Console.WriteLine();

            Console.Write("Enter the player ID number you wish to update the score of or 0 to finish -->");
            int enteredID = int.Parse(Console.ReadLine());
    
          while (enteredID != -0)
	      {
             Player selectedPlayer = allPlayers.ElementAt(enteredID-1); /*Gets allPlayers based on what order the add is in*/
	         selectedPlayer.IncreaseScore(1); 
             Console.WriteLine();

             Console.Write("Enter the player ID number you wish to update the score of or 0 to finish -->");
             enteredID = int.Parse(Console.ReadLine());
                 
         }
            Display(allPlayers);
            Console.WriteLine();
            

            
            //sort the list
            Console.WriteLine();
            allPlayers.Sort();
            Console.WriteLine();
            allPlayers.Reverse();
          DisplayPlayerDetails(allPlayers);
        
     
             Console.WriteLine("The highest score is {0}", Player.HighScore);
          
        }
        private static void Display(List<Player> players)
        {
            Console.WriteLine("{0, -10}{1, -10}{2, -10}{3, -10}{4, -10}","Player1", "Player2", "Player3", "Player4", "Player5");

            //loop through all players in list and display score for each
            foreach (Player player in players)
            {
                Console.Write("{0,-10}",player.PlayerScore);
                
                
            }
        }

         

        private static void DisplayPlayerDetails(List<Player> players)
        {
            Console.WriteLine($"{"PlayerID"}\t{"PlayerName"}\t{"PlayerScore"}");
            foreach (Player player in players)
                {
                Console.WriteLine(player);
                }
{

	}
        }






    }
}

