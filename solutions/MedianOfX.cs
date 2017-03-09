
//Median Of X
		public void MedianOfX(List<string> readInList)
        {
            foreach (string s in readInList)
            {
                helperMethodMedianOfX(s);
            }
        }

        private static void helperMethodMedianOfX(string valueFromList)
        {
            string[] sArray = valueFromList.Split(new[] { ' ' }, StringSplitOptions.RemoveEmptyEntries);
            List<int> myList = new List<int>();
            int tempVal = 0;

            for (int x = 0; x < sArray.Length; x++)
            {
                Int32.TryParse(sArray[x], out tempVal);
                myList.Add(tempVal);
            }

            myList.Sort();
            int count = myList.Count;
            if (count == 0)
            {
                throw new InvalidOperationException("Empty collection");
            }
            else if (count % 2 == 0)
            {
                //count is even, average two middle elements
                int a = myList[count / 2 - 1];
                int b = myList[count / 2];
                count = (a + b) / 2;
                Console.WriteLine("Amount in list cars is even, no median");
            }
            else
            {
                // count is odd, return the middle element
                count = myList[count / 2];
            }
            Console.Write(count + " ");
        }
