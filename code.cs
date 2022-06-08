using System;
 
class GFG
{
 

    static void isDivisible(long n)
    {
        long temp = n;
     

        int sum = 0;
        while (n != 0)
        {
            int k = (int) n % 10;
            sum += k;
            n /= 10;
        }
     

        if (temp % sum == 0){
            Console.WriteLine("{0} is divisible by {1} (result: {2})", n , sum, temp/sum);
            return;
         }   
     
            Console.WriteLine("{0} isn't divisible by {1} (result: {2})", n , sum, temp/sum);
        return;
    }
     

    public static void Main()
    {
        long n = 122;
        isDivisible(n);
    }
}
 