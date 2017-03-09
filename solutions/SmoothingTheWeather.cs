
//Smoothing The Weather
		public void SmoothingTheWeather(List<string> passInList)
        {
            string[] array = null;
            List<decimal> list = new List<decimal>();

            string s = passInList[0];
            array = s.Split(' ');
            list.Add(Convert.ToDecimal(array[0]));

            int length = array.Length;
            int last = length - 1;
            for (int x = 0; x < array.Length - 2; x++)
            {
                decimal sum = Convert.ToDecimal(array[x]) + Convert.ToDecimal(array[x + 1]) + Convert.ToDecimal(array[x + 2]);
                decimal final = Math.Round(sum / 3, 10);

                list.Add(final);
                if ((x + 1) == length)
                {
                    break;
                }
            }
            list.Add(Convert.ToDecimal(array[last]));
            StringBuilder sb = new StringBuilder();
            foreach (decimal d in list)
            {
                sb.Append(d + " ");
            }
        }
