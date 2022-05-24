class dayswi
    {
	static void main(String[] args)
		{

        Console.WriteLine("Enter day number");
			int day =Convert.ToInt32(Console.ReadLine());
			switch (day)
			{
				case 1:
                Console.WriteLine("Sunday");
					break;
				case 2:
                Console.WriteLine("Monnday");
					break;
				case 3:
                Console.WriteLine("Tuesday");
					break;
				case 4:
                Console.WriteLine("Wedday");
					break;
				case 5:
                Console.WriteLine("Thursday");
					break;
				case 6:
                Console.WriteLine("friday");
					break;
				case 7:
                Console.WriteLine("Saturday");
					break;
				Default:
                Console.WriteLine("Invalid day number");
			}


		}

	}

