class Leapyear
    {
    static void main(string[] args)
    {
        Console.WriteLine("Enter a year you want:");
		int year=Convert.ToInt32(Console.ReadLine());

		if (year % 400 == 0)
		{
            Console.WriteLine(+year + " is a leap year");
		}
		else
		{
            Console.WriteLine(+year + " is not a leap year");
		}
	}
    }

