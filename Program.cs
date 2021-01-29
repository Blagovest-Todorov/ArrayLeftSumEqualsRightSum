using System;
using System.Linq;

namespace equalSumsInArrayLeftSumRightSum
{
    class Program
    {
        static void Main(string[] args)             //1 2 3 3 
        {
            int[] numbersArr = Console.ReadLine()
                                     .Split()
                                     .Select(int.Parse)
                                     .ToArray();

            bool isNumber = false;
            for (int currIndex = 0; currIndex < numbersArr.Length; currIndex++)
            {               
                int leftSum = 0;
                int rightSum = 0;
               
                
                // Left for loop for the left sum 
                for (int i = currIndex - 1; i >= 0; i--)
                {
                    leftSum += numbersArr[i];
                }
                //rightSum Right LOOP
                for (int i = currIndex + 1; i < numbersArr.Length; i++)
                {
                    rightSum += numbersArr[i];
                }
                
                if (leftSum == rightSum)
                {
                    Console.WriteLine(currIndex);
                    isNumber = true;
                    break;
                } 
            }

            if (isNumber==false)
            {
                Console.WriteLine("no");
            }
           

        }
    }
}
