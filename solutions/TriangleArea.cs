
//Triangle Area
		public void TriangleArea(List<string> passInList)
        {
            StringBuilder sb = new StringBuilder();
            foreach (string s in passInList)
            {
                string[] trianglesSides = s.Split(' ');

                int x1 = Convert.ToInt32(trianglesSides[0]);
                int y1 = Convert.ToInt32(trianglesSides[1]);

                int x2 = Convert.ToInt32(trianglesSides[2]);
                int y2 = Convert.ToInt32(trianglesSides[3]);

                int x3 = Convert.ToInt32(trianglesSides[4]);
                int y3 = Convert.ToInt32(trianglesSides[5]);

                const double ONE_HALF = .5;
                double solution = ONE_HALF * (Math.Abs((x1 - x3) * (y2 - y1) - (x1 - x2) * (y3 - y1)));

                Console.Write(solution + " ");

                sb.Append(solution + " ");
            }
            Console.WriteLine();
        }
