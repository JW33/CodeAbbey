
//Sum Of Digits
		public void SumOfDigits(List<string> readInList)
        {
            StringBuilder sb = new StringBuilder();
            foreach (string s in readInList)
            {
                sb.Append(s + " ");
            }
            string something = sb.ToString();
            string[] temp = something.Split(' ');
            int value = 0;

            for (int x = 0; x < temp.Count() - 1; x += 3)
            {
                int value1 = Convert.ToInt32(temp[x]);
                int value2 = Convert.ToInt32(temp[x + 1]);
                int value3 = Convert.ToInt32(temp[x + 2]);
                value = (value1 * value2) + value3;

                helperMethod(value);
            }
            Console.WriteLine();
        }

        private static void helperMethodSumOfDigits(int value)
        {
            int final = 0;
            int iValue = 0;
            string strValue = value.ToString();
            for (int x = 0; x < strValue.Length; x++)
            {
                Int32.TryParse(strValue[x].ToString(), out iValue);
                final += iValue;
            }
            Console.Write(final + " ");
        }
