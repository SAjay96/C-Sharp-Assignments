class table
{
	static void main(String[] args)
	{

        Console.WriteLine("Enter number: ");  
		int num= Convert.ToInt32(Console.ReadLine());

		for (int i=1; i <= 10; i++)  
		{

            Console.WriteLine(num+" * "+i+" = "+num*i);  
		}  
	

	}
}

