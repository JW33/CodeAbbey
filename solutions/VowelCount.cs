
//Vowel Count
		public void VowelCount(List<string> readInList)
        {
            int vowelCount = 0;

            char[] chars = null;
            foreach (string x in readInList)
            {
                vowelCount = 0;
                chars = x.ToCharArray();
                foreach (char c in chars)
                {
                    switch (c)
                    {
						//order based on frequencies in English
						case 'e':
                        case 'E':
                        case 'a':
                        case 'A':
						case 'o':
                        case 'O':
                        case 'i':
                        case 'I':
                        case 'u':
                        case 'U':
                        case 'y':
                        case 'Y':
                            vowelCount++;
                            break;
                    }
                }
                Console.Write(vowelCount + " ");
            }
        }
