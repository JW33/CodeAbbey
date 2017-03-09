
//Collatz Sequence
		public void CollatzSequence(List<string> passInString)
        {
            string[] array = null;
            foreach (string s in passInString)
            {
                array = s.Split(' ');
            }

            for (int x = 0; x < array.Length; x++)
            {
                helperMethodCS(array[x]);
            }
        }

        public void helperMethodCS(string s)
        {
            int temp = Convert.ToInt32(s);
            int counter = 0;
            while (temp != 1)
            {
                if (temp % 2 == 0)
                {
                    temp = temp / 2;
                }
                else
                {
                    temp = (temp * 3) + 1;
                }
                counter++;
            }
            Console.Write(counter + " ");
        }
