
//Body Mass Index
		public void BodyMassIndex(List<string> readInList)
        {
            foreach (string s in readInList)
            {
                helperMethodBMI(s);
            }
        }

        public void helperMethodBMI(string valueFromList)
        {
            string[] splitArray = valueFromList.Split(new[] { ' ' }, StringSplitOptions.RemoveEmptyEntries);
            double weight = 0;
            double height = 0;
            double BMI = 0;

            if (!Double.TryParse(splitArray[0], out weight))
            {
                throw new Exception();
            }

            if (!Double.TryParse(splitArray[1], out height))
            {
                throw new Exception();
            }

            BMI = weight / Math.Pow(height, 2);

            if (BMI < 18.5)
            {
                Console.Write("under ");
            }
            else if (BMI < 25.0)
            {
                Console.Write("normal ");
            }
            else if (BMI < 30)
            {
                Console.Write("over ");
            }
            else
            {
                Console.Write("obese ");
            }
        }
