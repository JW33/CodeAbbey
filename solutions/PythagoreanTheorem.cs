
//Pythagorean Theorem
		public void PythagoreanTheorem(List<string> passInList)
        {
            foreach (string s in passInList)
            {
                string[] array = s.Split(' ');

                int angle1 = Convert.ToInt32(array[0]);
                int angle2 = Convert.ToInt32(array[1]);
                int hypotenuse = Convert.ToInt32(array[2]);

                int anglesTotal = (angle1 * angle1) + (angle2 * angle2);
                int hypotenuseTotal = hypotenuse * hypotenuse;

                if (anglesTotal == hypotenuseTotal)
                {
                    Console.Write("R ");
                }
                else if (anglesTotal > hypotenuseTotal)
                {
                    Console.Write("A ");
                }
                else if (anglesTotal < hypotenuseTotal)
                {
                    Console.Write("O ");
                }
            }
        }
