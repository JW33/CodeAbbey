
//Modular Calculator
		public void ModularCalculator2(List<string> readInList)
        {
            BigInteger tempVal = new BigInteger();
            BigInteger final = new BigInteger();
            bool flag = true;

            foreach (string s in readInList)
            {
                string[] temp = s.Split(' ');

                if (BigInteger.TryParse(tmp[0], out tempVal) && flag)
                {
                    final += tempVal;
                }
                else
                {
                    if (temp[0] == "*")
                    {
                        BigInteger.TryParse(temp[1], out tempVal);
                        final *= tempVal;
                    }
                    else if (temp[0] == "+")
                    {
                        BigInteger.TryParse(temp[1], out tempVal);
                        final += tempVal;
                    }
                    else if (temp[0] == "%")
                    {
                        BigInteger.TryParse(temp[1], out tempVal);
                        final %= tempVal;
                    }
                }
                flag = false;
            }
            Console.WriteLine(final);
        }

