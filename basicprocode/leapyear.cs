using System;
namespace basicprocode
{
    public class leapyear
    {
        public void year()
        {
            Console.Write("Enter 4 digit year to check leap year or not : ");
            uint year = Convert.ToUInt32(Console.ReadLine());

            //Checking if the entered value is 4 digit or not



            if (year > 999 && year <= 9999)
            {
                //Leap Year condition

                if (year % 4 == 0 && year % 100 != 0 || year % 400 == 0)
                {
                    Console.WriteLine("Year is Leap Year");
                }
                else
                {
                    Console.WriteLine("Year is not Leap Year");
                }
            }
            else
            {
                Console.WriteLine("Entered year is not 4 digit");
            }

        }
    }
}
