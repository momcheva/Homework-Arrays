using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace P01.LargestCommonEnd
{
    class LargestCommonEnd
    {
        static void Main(string[] args)
        {
            string[] words1 = Console.ReadLine().Split(' ').ToArray();
            string[] words2 = Console.ReadLine().Split(' ').ToArray();

            int smallerArrayLength = Math.Min(words1.Length,words2.Length);

            int leftCounter = CheckArrays(words1, words2, smallerArrayLength);

            Array.Reverse(words1);
            Array.Reverse(words2);

            int rightCounter = CheckArrays(words1, words2, smallerArrayLength);

            Console.WriteLine(Math.Max(leftCounter, rightCounter));

            //Variant2

            string[] firstArr = Console.ReadLine().Split();
            string[] secondArr = Console.ReadLine().Split();

            int smallerArrLength = Math.Min(firstArr.Length, secondArr.Length);

            int left = 0;
            int right = 0;

            for(int i = 0; i <smallerArrayLength;i++)
            {
                if(firstArr[i]==secondArr[i])
                {
                    left++;
                }
            }
            for (int i = 0; i < smallerArrayLength; i++)
            {
                if(firstArr[firstArr.Length-1-i]==secondArr[secondArr.Length-1-i])
                {
                    right++;
                }
            }

            Console.WriteLine(Math.Max(left, right));
           
        }

        private static int CheckArrays(string[] words1, string[] words2, int smallerArrayLength)
        {
            int counter = 0;
            for (int i = 0; i < smallerArrayLength; i++)
            {
                if (words1[i] == words2[i])
                {
                    counter++;
                }
                else
                {
                    break;
                }
            }

            return counter;
         }

        


    }
}
