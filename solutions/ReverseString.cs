
//Reverse String
		public void ReverseString(List<string> readInList)
        {
            StringBuilder sb = new StringBuilder();

            foreach (string s in readInList)
            {
                sb.Append(s);
            }

            string myString = sb.ToString();

            int length = myString.Length;
            int last = length - 1;

            char[] chars = myString.ToCharArray();
            Console.WriteLine(chars);
            for (int x = 0; x < length / 2; x++)
            {
                char c = chars[x];
                chars[x] = chars[last - x];
                chars[last - x] = c;
            }
            Console.WriteLine(chars);
        }
