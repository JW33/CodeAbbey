
//Prime Number Generator
		public void PrimeNumberGenerator(List<string> passInList)
        {
            foreach (string s in passInList)
            {
                string[] array = s.Split(' ');
                foreach (string t in array)
                {
                    int counter = 0;
                    int numberOfLoops = Convert.ToInt32(t);
                    int temp = Primes(numberOfLoops, counter);
                    Console.Write(temp + " ");
                }
            }
        }

        public int Primes(int numberOfLoops, int counter)
        {
            bool flag = true;
            int i = 0;
            while (flag)
            {
                if (IsPrime(i))
                {
                    counter++;
                    if (counter == numberOfLoops)
                    {
                        flag = false;
                        return i;
                    }
                }
                i++;
            }
            return -1;
        }

		//Credit to DotNetPerls
        public bool IsPrime(int number)
        {
            // Test whether the parameter is a prime number.
            if ((number & 1) == 0)
            {
                if (number == 2)
                {
                    return true;
                }
                else
                {
                    return false;
                }
            }
            // ... Test the square.
            // ... Also we exclude 1 at the end.
            for (int i = 3; (i * i) <= number; i += 2)
            {
                if ((number % i) == 0)
                {
                    return false;
                }
            }
            return number != 1;
        }
