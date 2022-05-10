using System;
namespace basicprocode
{
    public class harmonicnumber
    {
        public void Harmonic()
        {
            Console.Write("Enter the value of N to calculate Nth Harmonic Value : ");

            int N = Convert.ToInt32(Console.ReadLine());

            double harmonicNumber = 0;
            if (N > 0)
            {
                //Harmonic Number logic
                for (double i = 1; i <= N; i++)
                {
                    harmonicNumber += 1 / i;
                }
                Console.WriteLine(N + "th Harmonic Number is : " + harmonicNumber);
            }
            else
            {
                Console.WriteLine("Entered number is negative");
            }

        }
    }
}
