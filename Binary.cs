using System;
using static System.Console;
class Binary
{
    static void Main(string[] args)
    {
        Console.WriteLine($"Factorial 8 is : {Factorial(8)}");
        var tt  =  1/2;
        var tt2 = 1 %2;
        WriteLine(tt);
        WriteLine(tt2);
        Write("Enter a number: ");
        bool correct = int.TryParse(ReadLine(), out int number);
        WriteLine(correct ? Binary_2(number) : "Enter a valid number!");
        ReadLine();
    }
    static string Binary_2 (int number)
    {
        string res = "";
        
        while (number  > 0)
        {
            int mod = number % 2;
            number /= 2;
            res = mod.ToString() + res;
        }  
        return res;
    }

    public static long Factorial(int n) =>  n  < 2 ? 1 : n * Factorial(n - 1);

}