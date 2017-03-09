
//Dice Rolling
		public void DiceRolling(List<string> readInList)
        {
            foreach (string s in readInList)
            {
                helperMethodDiceRolling(s);
            }
        }

        public void helperMethodDiceRolling(string valueFromList)
        {
            double tempVal = 0;
            double.TryParse(valueFromList, out tempVal);

            Random rnd = new Random();
            int random1To6 = rnd.Next(1, 7);

            double multiplyBy = 0;
            multiplyBy = tempVal * random1To6;

            double flooredValue = Math.Floor(multiplyBy);

            double finalAnswer = 0;
            finalAnswer = flooredValue + 1;

            Console.WriteLine(finalAnswer);
        }
