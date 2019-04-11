using static System.Console;
class Assignment1d
{
    static void Main(string[] args)
    {
        Write("Enter a number: ");
        bool correct = int.TryParse(ReadLine(), out int number);
        WriteLine(correct? ConvertInteger(number): "Enter a valid number");
        ReadLine();
    }
    static string[] tensDigits = {"Zero", "One", "Two", "Three", "Four", "Five", "Six", "Seven", "Eight", "Nine", "Ten", "Eleven", "Twelve", "Thirteen", "Fourteen", "Fifteen", "Sixteen", "Seventeen", "Eighteen", "Nineteen"};
    static string[] tensMultiple = {"Twenty", "Thirty", "Forty", "Fifty", "Sixty", "Seventy", "Eighty", "Ninety"};
    static string[] tensHundred = {"Hundred","Thousand","Million"};
    static string ConvertInteger(int number)
    {
        string result = "";
        if (number < 100)
        {
            result = Conv(number);
        }
        if (number >= 100 && number < 1000)
        {
            result = Convert(number);
        }
        if (number >= 1000 && number < 1000000)
        {
            result = ConvertHundred(number);
        }
        return result;
    }
    static string Conv(int number)
    {
        string val = "";
        if (number < 20)
        { 
            val = tensDigits[number];
        }
        if (number >= 20)
        {
            val = tensMultiple[(number/10) - 2];
            if (number % 10 != 0)
            {
                val += " " + tensDigits[number%10];
            }
        }
        
        return val;
    }
    static string Convert(int number)
    {
        string word = "";
        int quotient = number / 100;
        int remainder = number % 100;
        if (quotient > 0)
        {
            word = tensDigits[quotient] + " " + tensHundred[0];
            if (remainder > 0)
            {
                word += " and " + Conv(remainder);
            }
        }
        return word;
    }
    static string ConvertHundred (int number)
    {
        string ans = "";
        int quotient1 = number / 1000;
        int remainder1 = number % 1000;
        //if (quotient1 > 
        ans = tensDigits[quotient1] + " " + tensHundred[1];
        if (remainder1 )

    }
}

