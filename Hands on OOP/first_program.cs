using System;

public Program
{
    static void Main(string[] args)
    {
        int num, sum = 0, r;
        Console.WriteLine("Enter a Number : ");
        num = int.Parse(Console.ReadLine());
        while (num != 0)
        {
            r = num % 10;
            num = num / 10;
            sum = sum + r;
        }
        Console.WriteLine("Sum of Digits of the Number : " + sum);
        Console.ReadLine();
    }
}

/* classic example of calculating the sum of all of the digita of a number.
 * It takes a number as input using the Console.ReadLine() function, parses it,
 * and stores it into a variable num, loops through while the number is 0, and
 * takes modulus by 10 to get the remainder of the division, which is then summed up
 * to produce the result. */

/* the using statement includes System. This ensures that both Console.ReadLine() and
 * Console.WriteLine() can be called. System is a namespace from the code, which enables 
 * the program to call the classes defined inside it without specifying the full namespace
 * path of the class. */
