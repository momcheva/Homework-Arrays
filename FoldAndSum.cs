using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace P03.FoldAndSum
{
    class FoldAndSum
    {
        static void Main(string[] args)
        {
            int[] nums = Console.ReadLine().Split().Select(int.Parse).ToArray();

            int k=nums.Length/4;
            int[] result = new int[nums.Length/2];

            for(int i = 0;i<result.Length; i++)
            {
                if(i<k)
                {
                    result[i] = nums[k-i-1]+ nums[i+k];
                }
                else
                {
                    result[i] = nums[nums.Length-1+k-i]+nums[i+k];
                }
            }
            Console.WriteLine(string.Join(" ", result));

        }
    }
}
            /*
            int[] numbers = Console.ReadLine().Split().Select(int.Parse).ToArray();
            
            int k = numbers.Length/4;
            int[] middleElements = new int[2*k];
            int[] firstKElements = new int[k];

            for(int i=0; i<middleElements.Length;i++)
            {
                 middleElements[i] = numbers[k+i];
            }


            for (int j = 0; j < firstKElements.Length; j++)
            {
                firstKElements[j] = numbers[j];
            }

            int[] lastKElements = new int[k];

            for (int j = 0; j < lastKElements.Length; j++)
            {
                lastKElements[j] = numbers[j+3*k];
            }

            Array.Reverse(lastKElements);
            Array.Reverse(firstKElements);

            int[] output = new int[2 * k];

            for (int i = 0; i < output.Length;i++ )
            {
                if (i < k)
                {
                    output[i] = firstKElements[i];
                }
                else
                {
                    output[i] = lastKElements[i - k];
                }
            }

            for (int i = 0; i < middleElements.Length; i++) 
            {
                middleElements[i] += output[i];
            }
                Console.WriteLine(string.Join(" ", middleElements));
        }
    }
}
