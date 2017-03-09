
//Savings Caculator
		public void SavingsCalculator(List<string> passInList)
        {
            foreach (string s in passInList)
            {
                string[] array = s.Split(' ');

                decimal startingAmount = Convert.ToDecimal(array[0]);
                decimal requiredSum = Convert.ToDecimal(array[1]);
                decimal interest = Convert.ToDecimal(array[2]) / 100;
                int years = 0;

                while (requiredSum > startingAmount)
                {
                    startingAmount += (startingAmount * interest);
                    years++;
                }
                Console.Write(years + " ");
            }
        }
