		
//Average Of An Array
		public void AverageOfAnArray(List<string> readInList)
        {
            string[] temp = null;
            double tempVal = 0;
            double sum = 0;
            double finalAnswer = 0;
            double dValue = 0;
            foreach (string s in readInList)
            {
                sum = 0;
                temp = s.Split(new[] { ' ' }, StringSplitOptions.RemoveEmptyEntries);
                for (int x = 0; x < temp.Length; x++)
                {
                    Double.TryParse(temp[x], out tempVal);
                    sum += tempVal;
                }
                dValue = sum / (temp.Length - 1);
                finalAnswer = Math.Round(dValue);
                Console.Write(finalAnswer + " ");
            }
        }
