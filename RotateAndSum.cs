using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace P02.RotateAndSum
{
    class RotateAndSum
    {
        static void Main(string[] args)
        {
            int[] numbers = Console.ReadLine().Split(' ').Select(int.Parse).ToArray();
            int rotations = int.Parse(Console.ReadLine());

            int[] sum = new int[numbers.Length];

            for (int i = 0; i < rotations; i++)
			{
                int lastElement = numbers[numbers.Length-1];

                for(int j=numbers.Length-1; j>0;j--)
                {
                    numbers[j] = numbers[j-1];
                }
                numbers[0] = lastElement;

                for(int current = 0; current<numbers.Length; current++)
                {
                    sum[current] += numbers[current];
                }
			 
			}
            Console.WriteLine(string.Join(" ", sum));
        }
    }
}

            /*


            int[] input = Console.ReadLine().Split(' ').Select(int.Parse).ToArray();

            int rotations = int.Parse(Console.ReadLine());
            int[] sumOfRotations = new int[input.Length];

            for (int i = 0; i < rotations; i++)
            {
                int lastIndex = input[input.Length - 1];
                for (int j = input.Length - 1; j > 0; j--)
                {
                    input[j] = input[j - 1];
                }
                input[0] = lastIndex;


                for (int current = 0; current < input.Length; current++)
                {
                    sumOfRotations[current] += input[current];
                }
            }
            

            Console.WriteLine(string.Join(" ", sumOfRotations));
        }
    }
}
