
//Arithmetic Progression
		public void ArithmeticProgression(List<string> passInList)
        {
            foreach (string s in passInList)
            {
                //temporary array to split 3 numbers and then convert said numbers to integers
                //array will reset with every iteration
                string[] array = s.Split(' ');

                int firstValue = Convert.ToInt32(array[0]);
                int stepSize = Convert.ToInt32(array[1]);
                int numberOfSteps = Convert.ToInt32(array[2]);

                helperMethodArithmeticProgression(firstValue, stepSize, numberOfSteps);
            }
        }

        public static void helperMethodArithmeticProgression(int firstValue, int stepSize, int numberOfSteps)
        {
            int final = firstValue;
            //formula as follows: A + (A + B) + (A + 2B) + (A + 3B) + ...
            //already added the first 'A' in the beginning...
            for (int x = 1; x < numberOfSteps; x++)
            {
                final += firstValue + (x * stepSize);
            }
            Console.Write(final + " ");
        }
