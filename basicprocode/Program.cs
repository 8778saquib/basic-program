using System;

namespace basicprocode
{
    class Program
    {
        static void Main(string[] args)
        {
         
            Console.WriteLine("Enter the choice");
            Console.WriteLine(" 1. Flip Coin and print percentage of Heads and Tails");
            Console.WriteLine(" 2. Leap Year");
            Console.WriteLine(" 3. Power of 2");
            Console.WriteLine(" 4. Harmonic Number");
            Console.WriteLine(" 5. Factors");
            Console.WriteLine(" 6. Quotient and Remainder");
            Console.WriteLine(" 7. Swap Two Numbers");
            Console.WriteLine(" 8. Even or Odd");
            Console.WriteLine(" 9. Alphabet is Vowel or Consonant");
            Console.WriteLine("10. Largest Among Three Numbers");

            int choice = Convert.ToInt32(Console.ReadLine());

            switch (choice)
            {
                case 1:
                    Flipcoin basicCore = new Flipcoin();
                    basicCore.coin();

                    break;
                case 2:
                    leapyear b = new leapyear();
                    b.year();

                    break;
                case 3:
                    powerof2 c = new powerof2();
                    c.Power();
                    break;
                case 4:
                    harmonicnumber d = new harmonicnumber();
                    d.Harmonic();

                    break;
                case 5:
                    factors e = new factors();
                    e.primeFactors();

                    break;
                case 6:
                    QuotientAndRemainder f = new QuotientAndRemainder();
                    f.quotientRemainder();
                    break;
                case 7:
                    swap g = new swap();
                    g.swaptwonumber();

                    break;
                case 8:
                    evenorodd h = new evenorodd();
                    h.EvenOdd();

                    break;
                case 9:
                    VowelOrConstant i = new VowelOrConstant();
                    i.VowelConsonant();

                    break;
                case 10:
                    LargestAmong3num j = new LargestAmong3num();
                    j.Largest();


                    break;
                default:
                    Console.WriteLine("Please enter the correct choice");
                    break;
            }


        }
    }
}
