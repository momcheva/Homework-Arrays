using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace P04.SieveOfEratosthenes
{
    class SieveOfEratosthenes
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());
            int[] primes = new int[n+1];
            int count = 2;

            for(int i=2; i<=n; i++)
            {
                primes[i] = count;
                count++;
            }

            for(int i=2;(i*i)<=n;i++)
            {
                for(int j=(i*i); j<=n; j+=i)
                {
                    primes[j] = 0;
                }
            }
           
            for(int i =2;i<=n;i++)
            {               
                if(primes[i]!=0)
                {
                   
                   Console.Write(primes[i] + " ");
                    /*
                    if (i == 2)
                    {
                        Console.Write(primes[i]);
                    }
                    else
                    {
                        Console.Write(", " + primes[i]);
                    }
                   */
                    
                }
            }
            Console.WriteLine();
        }
    }
}
