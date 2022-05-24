 class ElectricityBill
	{

		static void main(String[] args) { 
	

			int Units;
			double Amount, Charge, TotalAmount;


        Console.WriteLine(" Please Enter the Units that you Consumed  : ");
		Units = Convert.ToInt32(Console.ReadLine());


		if (Units < 50)
			{
				Amount = Units * 3.60;
				Charge = 25;
			}
			else if (Units <= 100)
			{

				Amount = 130 + ((Units - 50) * 4.25);
				Charge = 35;
			}
			else if (Units <= 200)
			{

				Amount = 130 + 162.50 + ((Units - 100) * 6.26);
				Charge = 45;
			}
			else
			{

				Amount = 130 + 162.50 + 526 + ((Units - 200) * 7.75);
				Charge = 55;
			}

			TotalAmount = Amount + Charge;
            Console.WriteLine("Electricity Bill  =  " + TotalAmount);

		}

	}


    
