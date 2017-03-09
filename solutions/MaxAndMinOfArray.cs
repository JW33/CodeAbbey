
//Max And Min Of Array
		public void MaxAndMinOfArray(List<string> readInList)
        {
            List<int> myList = new List<int>();
            string[] temp = null;

            foreach (string x in readInList)
            {
                temp = x.Split(' ');
            }

            foreach (string s in temp)
            {
                myList.Add(Convert.ToInt32(s));
            }

            int maxValue = myList[0];
            int minValue = myList[0];
            for (int x = 0; x < myList.Count; x++)
            {
                if (myList[x] > maxValue)
                {
                    maxValue = myList[x];
                }
                if (myList[x] < minValue)
                {
                    minValue = myList[x];
                }
            }

            Console.Write(maxValue + " " + minValue);
		}
