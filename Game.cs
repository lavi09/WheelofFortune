using System;
using System.Collections.Generic;
using System.Text;

namespace Wheel_of_Fortune
{
    class Game
    {
        private Puzzle puzzle;
        private List<Player> playerList; 

        public Game()
            {
                Puzzle puzzle= new Puzzle();
            playerList = new List<Player>();
        }

        public void StartGame()
        {
            
            int players = AskPlayerNumber();
            int rounds = AskRoundNumber();

            Console.WriteLine("Welcome to Wheel of Fortune game!");
            for (int i = 0; i < players; i++)
            {
                Console.WriteLine($"Please enter player {i + 1}'s name:");
                var playerName = Console.ReadLine();
                playerList.Add(new Player(playerName));
            }
            //Console.WriteLine);

            for (int i = 0; i < rounds; i++)
            {
                puzzle.DisplayWordWithDashes();

                while (!puzzle.IsComplete())
                {
                    puzzle.Guess();
                }
                EndGame();
            }
        }

        public void EndGame()
        {
             Console.WriteLine("Wow, you won the game!");
        }

        public void ManageRounds()
        {
            
        }

        public int AskPlayerNumber() 
        {
            // TODO: SHOULD ASK AND VALIDATE INPUT
            return 1;
        }

        public int AskRoundNumber()
        {
            // TODO: SHOULD ASK AND VALIDATE INPUT
            return 1;
        }
    }
}
