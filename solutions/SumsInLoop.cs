
//Sums In Loop
		public void SumInLoop(List<string> readInList)
        {
            List<string> myList = readInList;
            string temp = string.Join(" ", myList.ToArray());
            string[] splitArray = temp.Split(' ');

            List<int> numbers = new List<int>();

            foreach (string x in splitArray)
            {
                if (x != "")
                {
                    numbers.Add(Convert.ToInt32(x));
                }
            }

            int finalCount = 0;

            foreach (int x in numbers)
            {
                finalCount += x;
            }
            Console.WriteLine(finalCount);
        }
