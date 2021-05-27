using System;
using System.Collections.Generic;

namespace FindPrimes
{
    class Program
    {
        public static List<int> FindPrimes(int input)
        {
            List<int> primeList = new List<int>();
            for (int i = 1; i <= input; i++)
            {
                bool isPrime = true;
                for (int j = 1; j < i; j++)
                {                    
                    if (i % j == 0 && j != 1)
                    {
                        isPrime = false;
                        break;
                    }
                    
                }
                if (isPrime == true)
                {
                    primeList.Add(i);
                }

            }
            return primeList;
        }
        static void Main(string[] args)
        {
            Console.WriteLine("Enter an integer to find all the prime numbers less than or equal to it.");
            int testNum = Convert.ToInt32(Console.ReadLine());
            List<int> primes = FindPrimes(testNum);
            for (int prime = 0; prime < primes.Count; prime++)
            {
                Console.WriteLine(primes[prime]);
            }

        }
    }
}
