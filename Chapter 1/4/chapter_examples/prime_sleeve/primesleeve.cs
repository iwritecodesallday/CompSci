using System;

public class prime_sleeve
{
    // Print the number of primes <= n
    public static void Main(string[] args) {   
        // n          | argument
        Int32 n = Int32.Parse(args[0]);

        // isPrime[i] | is i prime?
        Boolean[] isPrime = new Boolean[n + 1];
        for (Int32 i = 2; i <= n; i++) {
            isPrime[i] = true;
        }

        for (Int32 i = 2; i <= (n / i); i++) {
            // Mark multiples of i as nonprime
            if (isPrime[i]) {
                for (Int32 j = i; j <= (n / i); j++)
                {
                    isPrime[i * j] = false;
                    
                }
            }
        }

        // primes     | prime counter
        // Count the primes
        Int32 primes = 0;
        for (Int32 i = 2; i <= n; i++)
        {
            if (isPrime[i]) primes++;
        }
        Console.WriteLine(primes);
        
    }
}