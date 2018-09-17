using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lucky1
{
    class Program
    {
        static void Main()
        {
            int[] luckyNum = new int[6];//declaring lucky number array 
            int[] guessNum = new int[6];//declaring guess number array
            int[] rangeNum = new int[2];//declaring range number array
            int temp = 0;//declaring int variable to be used for range and guess number
            int genNum =0;

            Console.WriteLine("Enter a Starting number");

            rangeNum[0] = int.Parse(Console.ReadLine());//Using parse to change input to an int

            while (rangeNum[1] == 0)
            {
                Console.WriteLine("Enter a Ending number greater than the starting number");
                temp = int.Parse(Console.ReadLine());

                if (temp > rangeNum[0] + 4)//greater number plus 6 for 6 lucky numbers
                {
                    rangeNum[1] = temp;
                }
            }
            Console.WriteLine(rangeNum[0] + "-" + rangeNum[1]);

            Random randLuck = new Random();

            for (int i = 0; i < 6; i++)
            {
                genNum = randLuck.Next(rangeNum[0], rangeNum[1]);//+1,-1 to rangeNum to not include range numbers


                if (luckyNum.Contains(genNum))
                {
                    i--;
                }
                else
                {
                    luckyNum[i] = genNum;
                }
            }

            for (int i = 0; i < 6; i++)
            {
                Console.WriteLine("Please enter a number between" + rangeNum[0] + "and" + rangeNum[1]);
                temp =int.Parse(Console.ReadLine());
                if (temp>=rangeNum[0]&&temp<=rangeNum[1])//take off equal to choose numbers between 
                {
                    if (guessNum.Contains(temp))
                    {
                        i--;
                    }
                    else
                    {
                        guessNum[i] = temp;
                    }

                }
            }

            for (int i = 0; i < luckyNum.Length; i++)
            {
                Console.WriteLine(i+1+" Lucky Number: "+luckyNum[i]);
            }
            int correctGuessNum = 0;//using it as a counter 
            foreach (var item in guessNum)
            {
                if (luckyNum.Contains(item))
                {
                    correctGuessNum++;
                }

            }
            Console.WriteLine("You guessed "+correctGuessNum+" numbers correct");
            double jackpot = 1000000;
            double winnings = jackpot / 6 * correctGuessNum;
            Console.WriteLine("The Jackpot was $" + jackpot);
            Console.WriteLine("You won $" + Math.Round((Double)winnings, 2)+"!");
            Console.WriteLine("Would you like to play again yes or no?");
            if (Console.ReadLine() == "yes")
            {
                Main();
            }
            else
            {
                Console.WriteLine("Thanks for playing");
            }
            Console.Read();

            //original attempt to enter range error
            //while (rangeNum.Length != 2)
            //    {
            //        Console.WriteLine("Enter a number");

            //        int Input = int.Parse(Console.ReadLine());

            //        if (rangeNum.Contains(Input))
            //        {

            //            Console.WriteLine("Please enter another number");
            //        }
            //        else
            //        {
            //            rangeNum[rangeNum.Length] = Input;

            //        }
            //    }
            //    Console.WriteLine(rangeNum[0] + "-" + rangeNum[1]);

            //foreach (var itemG in guessNum)//contains nested for loop 
            //{
            //    foreach (var itemL in luckyNum)
            //    {
            //        if (itemG ==itemL)
            //        {
            ////            correctGuessNum++;
            //        }
            //    }

            //}
        }
    }
}
