
//Rounding
		public void Rounding(List<string> readInList)
        {
            string[] temp = null;
            List<int> myList = new List<int>();

            foreach (string x in readInList)
            {
                temp = x.Split(' ');

                foreach (string y in temp)
                {
                    myList.Add(Convert.ToInt32(y));
                }
            }

            double divide = 0;
            List<double> finalAnswers = new List<double>();

            for (int x = 0; x < myList.Count; x += 2)
            {
                divide = (double)(myList[x]) / myList[x + 1];

                finalAnswers.Add(Math.Round(divide));
            }

            foreach (double x in finalAnswers)
            {
                Console.Write(x + " ");
            }
        }
