
//Array Counter
		public void ArrayCounter(List<string> passInList)
        {
            //using SortedDictionary instead of Dictionary to sort Keys; does add overheard though
            SortedDictionary<int, int> myDictionary = new SortedDictionary<int, int>();
            foreach (string s in passInList)
            {
                string[] array = s.Split(' ');
                foreach (string t in array)
                {
                    int temp = Convert.ToInt32(t);
                    if (myDictionary.ContainsKey(temp))
                    {
                        myDictionary[temp]++;
                    }
                    else
                    {
                        myDictionary[temp] = 1;
                    }
                }
            }
            foreach (var pair in myDictionary)
            {
                Console.WriteLine("Value {0} occurred {1} times.", pair.Key, pair.Value);
            }
        }
