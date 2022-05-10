using System;
namespace basicprocode
{
    public class swap
    {

        public void swaptwonumber()
        {
            Console.Write("Enter first number : ");
            int num1 = Convert.ToInt32(Console.ReadLine());
            Console.Write("Enter second number : ");
            int num2 = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Number1 = " + num1 + "\tNumber2 = " + num2);

            //Swap logic
            int temp = num1;
            num1 = num2;
            num2 = temp;

            Console.WriteLine("After swapping\nNumber1 = " + num1 + "\tNumber2 = " + num2);
        }

    }
}
