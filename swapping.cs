 class swpping
    {
	 static void main(String[] args)
		{

        Console.WriteLine("Enter 1st number:");
		int num1 = Convert.ToInt32(Console.Read());
		Console.WriteLine("Enter 1st number:");
		int num2 = Convert.ToInt32(Console.Read());


        Console.WriteLine("Before swapping:");
        Console.WriteLine("firstnumber = " + num1 + ", second number = " + num2);

			int temp = num1;
			num1 = num2;
			num2 = temp;

        Console.WriteLine("After swapping:");
        Console.WriteLine("firstnumber = " + num1 + ", second number = " + num2);


		}

	}

