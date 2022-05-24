class Evenum
{
	static void main(String[] args)
	{
		int number, i;


		Console.WriteLine(" Please Enter any Number : ");
		number = Convert.ToInt32(Console.ReadLine());

		for (i = 1; i <= number; i++)
		{
			if (i % 2 == 0)
			{
				Console.WriteLine(i);
			}

		}
	}
}
