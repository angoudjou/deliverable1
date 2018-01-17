    using System;
    namespace Delivreable1
    {

    class Program
    {
        public static bool check_digit(string number1, string number2)
        {


            int sum1=0, sum2=0;

            //we first check that the two number have the same lenght, otherwise we exit the function
            if (number1.Length != number2.Length)
            {
                Console.WriteLine("The values should have the same lenght(number of digits)");
                return false;
            }
            //if the values are less than  10, we only compare the two values
            if (number1.Length == 1)
            {
                //check if it is not a character
              

                sum1 = sum2 =int.Parse( number1.Substring(0,1));
              //  Console.WriteLine("the sum of each digit is: " + sum2.ToString());

                return number1 == number2;
            }
            //else if it is greather than 10 then we check if the sum of digits at the position i equals sum of digit at the position i-1
            // if at any moment we realise that it is  not true we return false


            for (int i = 1; i < number2.Length; i++)
            {
                sum1 = int.Parse(number1.Substring(i, 1)) + int.Parse(number2.Substring(i, 1));
                sum2 = int.Parse(number1.Substring(i - 1, 1)) + int.Parse(number2.Substring(i - 1, 1));
                if (sum2 != sum1)
                    return false;

            }

            Console.WriteLine( "the sum of each digit is: " + sum2.ToString());
            return true;
        }
       
        static void Main(string[] args)
        {
            const string title = "Welcome to my first deliverable of bootcamp \nEnter 2 numbers and the program checks \n if each corresponding place in the 2 numbers sums to the same total ";
            const string thanks = "Thank you for using my program \nALBERT SEVERIN NGOUDJOU";

            Console.Clear();
            string n1, n2;
            int nb1, nb2;
            bool continue_run = true;
            Console.WriteLine(title);

            while (continue_run)
            {
                Console.WriteLine();
                Console.Write("Number 1 : ");
                n1 = Console.ReadLine();
                Console.WriteLine();
                Console.Write("Number 2 : ");
                n2 = Console.ReadLine();

                //we check that the value are number
                if (Int32.TryParse(n1, out nb1) && Int32.TryParse(n2, out nb2))
                    Console.WriteLine(check_digit(n1, n2));
                else
                {
                    if (!Int32.TryParse(n1, out nb1))
                        Console.WriteLine("The first value is not a whole number");

                   if (!
                        Int32.TryParse(n2, out nb2))
                        Console.WriteLine("The second value is not a whole number");

                    Console.WriteLine("Unable to check the digits");

                }
                Console.WriteLine();
                Console.Write("Do you want to continue running the program ? Y(Yes),other key(Quit):");
                continue_run = ( Console.ReadKey().Key ==  ConsoleKey.Y );

            }


            Console.WriteLine();
            Console.WriteLine(thanks);
            Console.ReadKey();
        }
       




    }
    }
