 class SumofFact
    {
	 static void main(String[] args)
		{


        Console.WriteLine("Enter number : ");
			int n =Convert.ToInt32(Console.ReadLine());	

			int total = 0;
			int factorial = 1;



			for (int i = 1; i <= n; i++)
			{


				factorial = factorial * i;



				total = total + factorial;

			}

            Console.WriteLine("Sum : " + total);
		}

	}




