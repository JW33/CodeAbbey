
//Minimum Of Two
		public void MinimumOfTwo(List<string> readInList)
        {
            List<int> finalChoices = new List<int>();

            foreach (string x in readInList)
            {
                string[] temp = x.Split(' ');

                int value1 = 0;
                int value2 = 0;

                if (int.TryParse(temp[0], out value1))
                {
                    if (int.TryParse(temp[1], out value2))
                    {
                        if (value1 < value2)
                        {
                            finalChoices.Add(value1);
                        }
                        else
                        {
                            finalChoices.Add(value2);
                        }
                    }
                }
            }

            foreach (int x in finalChoices)
            {
                Console.WriteLine(x);
                sBuilder4.Append(x + " ");
            }
        }
