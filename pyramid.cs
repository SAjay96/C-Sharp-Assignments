class Pyramid
{

    public static void main(String[] args)
    {


        for (int i = 0; i < 5; i++)
        {
            for (int j = 5; j > 1; j--)
            {
                Console.WriteLine(" ");
            }

            for (int j = 0; j <= i; j++)
            {

                Console.WriteLine("* ");
            }

            Console.WriteLine();

        }
    }
}
