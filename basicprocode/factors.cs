using System;
namespace basicprocode
{
    public class factors
    {
        public void primeFactors()
        {
            Console.Write("Enter a number to find Prime Factors : ");

            int num = Convert.ToInt32(Console.ReadLine());
            Console.Write("Prime Factors of {0} are : ", num);

            //While the number is divisible by 2 we are dividing it
            while (num % 2 == 0)
            {
                Console.Write(2 + " ");
                num = num / 2;
            }

            //This part is for all the odd numbers greater than 2
            for (int i = 3; i <= Math.Sqrt(num); i += 2)
            {
                while (num % i == 0)
                {
                    Console.Write(i + " ");
                    num = num / i;
                }
            }
            if (num > 2)
            {
                Console.Write(num);
            }

        }
    }
}
