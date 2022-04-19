using System;

namespace Reverse_number
{
    
        class Program
        {
            static void Main(string[] args)
            {
              
                int Num, Rem;
            int Reverse=0;
                Console.WriteLine("Enter a Number :");
                Num =int.Parse(Console.ReadLine());
                while (Num != 0)
                {
                    Rem = Num%10;
                Reverse = Reverse * 10 + Rem;
                Num /= 10;

                }
                Console.WriteLine("Reverese Number is :{0}", Reverse);
                Console.ReadLine();


            }
        }
    


}
