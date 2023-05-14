class homework2_1
{
    static void Main(string[] args)
    {
        bool loop = true;
        while (loop)
        {
            int startcheck = 1;

            int pas = int.Parse(Console.ReadLine());
            if (pas < 0)
            {
                Console.WriteLine("Invalid Pascal's triangle row number.");
            }
            else
            {

                for (int i = 0; i <= pas; i++)
                {
                    Console.WriteLine();
                    for (int j = 0; j <= i; j++)
                    {
                        if (j == 0 || i == j)
                        {
                            startcheck = 1;
                        }
                        else
                        {
                            startcheck = startcheck * (i - j + 1)/j;
                        }
                            Console.Write(startcheck + " ");
                        
                    }
                }
                 loop = false;
            }
           
        }

    }
}