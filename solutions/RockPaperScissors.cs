
//Rock Paper Scissors
		public void RockPaperScissors(List<string> passInList)
        {
            foreach (string s in passInList)
            {
                string[] array = s.Split(' ');
                helperMethodRPS(array);
            }
        }

        public void helperMethodRPS(string[] array)
        {
            int playerOneMatchWins = 0;
            int playerTwoMatchWins = 0;
            foreach (string set in array)
            {
                switch (set)
                {
                    case "PR":
                    case "RS":
                    case "SP":
                        playerOneMatchWins++;
                        break;

                    case "RP":
                    case "SR":
                    case "PS":
                        playerTwoMatchWins++;
                        break;

                    case "RR":
                    case "SS":
                    case "PP":
                        break;

                    default:
                        Console.WriteLine("Invalid data inputed. Please, never try again");
                        break;
                }
            }
            if (playerOneMatchWins > playerTwoMatchWins)
            {
                // Player 1 wins
                Console.Write(1 + " ");
            }
            else
            {
                // Player 2 wins
                Console.Write(2 + " ");
            }
        }
