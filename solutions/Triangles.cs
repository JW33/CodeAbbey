
//Triangles
		public void Triangles(List<string> passInList)
        {
            const int NUMBER_OF_POINTS = 3; //always 3 points for triangle
            foreach (string s in passInList)
            {
                string[] array = s.Split(' ');
                if (array.Length == NUMBER_OF_POINTS)
                {
                    int firstSegment = Convert.ToInt32(array[0]);
                    int secondSegment = Convert.ToInt32(array[1]);
                    int thirdSegment = Convert.ToInt32(array[2]);

                    int sumFirstAndSecondSegments = firstSegment + secondSegment;
                    int sumFirstAndThirdSegments = firstSegment + thirdSegment;
                    int sumSecondAndThirdSegments = secondSegment + thirdSegment;

                    bool checkOne = sumFirstAndSecondSegments > thirdSegment;
                    bool checkTwo = sumFirstAndThirdSegments > secondSegment;
                    bool checkThree = sumSecondAndThirdSegments > firstSegment;

                    if (checkOne && checkTwo && checkThree)
                    {
                        Console.Write("1 ");
                    }
                    else
                    {
                        Console.Write("0 ");
                    }
                }
                else
                {
                    Console.WriteLine("Major Problem");
                }
            }
        }
