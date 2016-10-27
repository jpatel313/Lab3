using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab3
{
    class SquaresCubes
    {
        static void Main(string[] args)
        {

            Console.WriteLine("Learn your squares and cubes!"); 
            bool agree = true;
            while (agree)
            {
                Console.WriteLine("Enter an integer: ");
                int numberMax = 0;
                numberMax = int.Parse(Console.ReadLine());
              
                //use string format so columns don't shift
                Console.WriteLine(String.Format("{0,-10} {1,-10} {2,-10}", "Number", "Squared", "Cubed"));
                Console.WriteLine(String.Format("{0,-10} {1,-10} {2,-10}","=======","========","======="));
                
                //for loop to calc up to the user input
                for (int i = 1; i <= numberMax; i++)
                {
                    int squared = (i * i);
                    int cubed = ((i * i) * i);
                    
                    Console.WriteLine(String.Format("{0, -10} {1,-10} {2,-10}", i, squared, cubed));
                    //format the padding so string stays in same place despite extra digits in column
                    //columns wont get pushed over
                    
                    // Console.Write(((Math.Pow(i, 3)).ToString()).PadRight(15));
                    ///alt calculation, study this more

                }

                Console.WriteLine("Do you want to continue?(y/n): ");
                string response = (Console.ReadLine());

                if (response == "y" || response == "Y")
                {
                    agree = true;
                }
                else
                {
                    agree = false;
                    break;
                }
            }
        }
    }
}
