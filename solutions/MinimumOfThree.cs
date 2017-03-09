		
//Minimum Of Three
		public void MinimumOfThree(List<string> readInList)
        {
            List<int> finalChoices = new List<int>();

            foreach (string x in readInList)
            {
                string[] temp = x.Split(' ');

                int value1 = 0;
                int value2 = 0;
                int value3 = 0;

                if (int.TryParse(temp[0], out value1) && int.TryParse(temp[1], out value2) && int.TryParse(temp[2], out value3))
                {
                    int minValue = value1;

                    if (minValue > value2)
                    {
                        minValue = value2;
                    }
                    else if (minValue > value3)
                    {
                        minValue = value3;
                    }
                    finalChoices.Add(minValue);
                }
            }

            foreach (int x in finalChoices)
            {
                Console.WriteLine(x);
                sBuilder4.Append(x + " ");
            }
        }
