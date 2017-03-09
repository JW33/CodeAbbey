
//Weight Sum Of Digits
		public void WeightSumOfDigits(List<string> readInList)
        {
            string[] tempArray = null;
            int final = 0;
            List<int> list = new List<int>();
            foreach (string x in readInList)
            {
                tempArray = x.Split(new[] { ' ' }, StringSplitOptions.RemoveEmptyEntries);
                foreach (string y in tempArray)
                {
                    int tempVal = 0;
                    for (int z = 0; z < y.Length; z++)
                    {
                        Int32.TryParse(y[z].ToString(), out tempVal);
                        z++;
                        final = final + (tempVal * z);
                        z--;
                    }
                    Console.Write(final + " ");
                    final = 0;
                }
            }
        }
