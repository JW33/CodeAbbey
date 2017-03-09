
//Fahrenheit To Celsius
		public void FtoC(List<string> readInList)
        {
            List<string> myList = readInList;
            string temp = string.Join(" ", myList.ToArray());
            string[] splitArray = temp.Split(' ');

            double convert = 0.0;

            List<double> finalAnswers = new List<double>();
            const int VALUE_TO_SUBTRACT = 32;
            const double VALUE_TO_MULTIPY = 5.0 / 9.0;

            foreach (string y in splitArray)
            {
                convert = ((Convert.ToDouble(y) - VALUE_TO_SUBTRACT) * (VALUE_TO_MULTIPY));

                finalAnswers.Add(Math.Round(convert));
            }

            StringBuilder sb = new StringBuilder();
            foreach (double x in finalAnswers)
            {
                Console.Write(x + " ");
                sb.Append(x + " ");
            }
            Console.WriteLine("Disegard first number!");
        }
