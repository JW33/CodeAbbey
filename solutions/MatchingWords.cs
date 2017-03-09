
//Matching Words
		public void MatchingWords(List<string> passInList)
        {
            string[] array = null;
            foreach (string s in passInList)
            {
                array = s.Split(' ');
            }

            Dictionary<string, int> letterCount = new Dictionary<string, int>();

            for (int x = 0; x < array.Length; x++)
            {
                if (letterCount.ContainsKey(array[x]))
                {
                    letterCount[array[x]]++;
                }
                else
                {
                    letterCount.Add(array[x], 1);
                }
            }

            List<string> list = new List<string>();
            foreach (KeyValuePair<string, int> c in letterCount)
            {
                if (c.Value > 1)
                {
                    list.Add(c.Key);
                }
            }
            list.Sort();
            foreach (string item in list)
            {
                Console.Write(item + " ");
            }
        }
