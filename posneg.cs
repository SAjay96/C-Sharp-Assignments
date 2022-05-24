 class posneg
    {
    static void main(string[] args)
    
		{
			int num;
		
            Console.WriteLine("Enter a number:");
		num = Convert.ToInt32(Console.Read());

			if (num > 0)
			{
                Console.WriteLine("The entered number is positive");
			}
			else if (num < 0)
			{
                Console.WriteLine("The entered number is negative");
			}
			else
			{
                Console.WriteLine("zero");
			}


		}

	}




   
