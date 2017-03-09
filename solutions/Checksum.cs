
//Checksum
		public void ArrayChecksum(List<string> passInList)
        {
            BigInteger result = new BigInteger();
            BigInteger secondResult = new BigInteger();
            foreach (string s in passInList)
            {
                string[] array = s.Split(' ');
                foreach (string t in array)
                {
                    BigInteger temp = new BigInteger();
                    temp = BigInteger.Parse(t);
                    result = (result + temp) * 113;
                    if (result >= 10000007)
                    {
                        secondResult = result % 10000007;
                    }
                }
            }
            Console.WriteLine(secondResult);
        }
