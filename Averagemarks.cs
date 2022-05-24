class Averagemarks
    {
		static void main(String[] args)
		{
			double English, Hindi, Maths, Science, SocialStudy, TotalMarks, Average, Percentage;
			English = 65;
			Hindi = 50;
			Maths = 50;
			Science = 50;
			SocialStudy = 60;

			TotalMarks = English + Hindi + Maths + Science + SocialStudy;


        
            Console.WriteLine("Total Marks in five subject=" + TotalMarks);

			Average = (TotalMarks / 5);
            Console.WriteLine("Average Marks in five subject=" + Average);

			Percentage = ((TotalMarks / 500) * 100);
            Console.WriteLine("Percentage is:  " + Percentage);


			if (Percentage > 65)
			{
                Console.WriteLine("First class with distinction");
			}
			else if (Percentage > 60)
			{
                Console.WriteLine("First class");
			}
			else if (Percentage > 50)
			{
                Console.WriteLine("second class");
			}
			else if (Percentage > 40)
			{
                Console.WriteLine("Pass class");
			}
			else
			{
                Console.WriteLine("Fail");
			}

		}

	}

    
