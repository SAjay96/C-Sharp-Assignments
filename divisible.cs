class Divisible
{
	static void main(string[] args)
	{

		int number;
        Console.WriteLine("Enter a number:");
		number = Convert.ToInt32(Console.ReadLine());

    if((number % 5 == 0) && (number % 11 == 0))
			{
            Console.WriteLine("Given number " + number + " is Divisible by 5 and 11");
			}
			else
				{
            Console.WriteLine(" Given number " + number + " is Not Divisible by 5 and 11");
			}	
		  }
	}
