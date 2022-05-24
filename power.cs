 class power
    {
	static void main(String[] args)
		{


			long power = 1;


        Console.WriteLine(" Please Enter any Number : ");
			int number = Convert.ToInt32(Console.ReadLine());

		Console.WriteLine(" Please Enter the Exponent Value : ");
			int expo = Convert.ToInt32(Console.ReadLine());

		for (int i = 1; i <= expo; i++)
			{
				power = power * number;
			}
        Console.WriteLine("The Final result of " + number + " power " + expo + " = " + power);

		}

	}

