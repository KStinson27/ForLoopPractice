using System;
using System.Linq;
using System.Text;
using System.Threading;

namespace ForLoopsPractice
{
    class Program
    {
        static void Main(string[] args)
        {
            //Exercise 1

             int numberOne;

             Console.WriteLine("Enter a number");
             numberOne = Int16.Parse(Console.ReadLine());

             for (int i = numberOne; i != 0; i--)
             {
                 Console.WriteLine(i + "..");

                 Thread.Sleep(2000);
             }

             //Exercise 2

             for (int j = 0; j != 102; j+=2 )
             {
                 Console.WriteLine(j);
             }

            //Exercise 3

            StringBuilder builder = new StringBuilder();

            for (int k = 1, b = 6; b != -1; k++, b--)
            {
                builder.Append(k);

                string addition = new string('*', b);

                Console.WriteLine(builder + addition);
            }

            //Exercise 4

            int firstFibo = 0;
            int secondFibo = 1;

            
            Console.WriteLine(firstFibo);
            Console.WriteLine(secondFibo);


            for (int m = 2; m < 10 ; m++)
            {
                int thirdFibo = firstFibo + secondFibo;

                Console.WriteLine(thirdFibo);

                firstFibo = secondFibo;

                secondFibo = thirdFibo;

            }

            //Exercise 5

            char[] chess = { 'X', 'O', 'X', 'O', 'X', 'O', 'X', 'O' };

            int x = 0;
            StringBuilder chess1 = new StringBuilder();
            StringBuilder chessReverse = new StringBuilder();

            
            for (int n = 0; n != 3; n++)
            {
                while(x != 1)
                {
                    foreach (char b in chess)
                    {
                        chess1.Append(b);

                    }

                    Console.WriteLine(chess1);
                    
                    Array.Reverse(chess);

                    foreach (char c in chess)
                    {
                        chessReverse.Append(c);

                    }

                    x = 1;
                    Console.WriteLine(chessReverse);
                } 

                Console.WriteLine(chess1);
                Console.WriteLine(chessReverse);
            }
        }
    }
}
