using System;

// Counting Primes:
// Compare PrimeSieve with the method below. This is an example 
// of a space-time tradeoff: 
// PrimeSieve is fast, but requires a Boolean array
// Below only uses two integer variables, but is much slower

// Estimate the magnitude of this difference by finding the value of n
// for which this second approach can complete the computation in about the same time as
// .\prime_compare.exe 1000000


public class prime_compare
{
    public static void Main(String[] args)
    {
        int n = int.Parse(args[0]);
        int factor;
        

        for(factor = 2; factor <= (n/factor); factor++) {
            if(n % factor == 0) {
                break;
            }
        }

        if (factor > (n/factor)) {
            Console.WriteLine(n + " is Prime");
        }
    }
}