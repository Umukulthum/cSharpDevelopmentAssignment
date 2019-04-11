using static System.Console;
class Assignmenet1b
{
    static void Main4(string[] args)
    {
        Write("Enter a value: ");
        bool correct = int.TryParse(ReadLine(), out int value);
        WriteLine(correct ? EvenOdd(value): "Enter a valid value");
        ReadLine();
    }
    static string EvenOdd(int value)
    {
        return value % 2 == 0 ? ("The value you entered is an even number.") : ("The value you entered is an odd number.");
    }

    public static bool IsEven(int value)
    {
        return value % 2 == 0;
    }
    public static bool IsOdd(int value) => !IsEven(value);

} 