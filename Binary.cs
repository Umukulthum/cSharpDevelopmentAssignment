using System.Xml;
using System;

namespace Binary
{
  class Bin
  {
    public static void Mainh(string[] args)
    { 
      Console.Write("Number: ");
      string number = Console.ReadLine();
      Console.Write("From base: ");
      int bases = int.Parse(Console.ReadLine());
      Console.WriteLine($"The number you entered to base 10 is {ToDecimal(number, bases)}");
      Console.Write("To Base: ");
      int based = int.Parse(Console.ReadLine());
      Console.WriteLine($"The number you entered to base {based} is {ToBase(number,bases,based)}");
      Console.ReadLine();

/* 
      Console.WriteLine("First number: ");
      string num1 = Console.ReadLine();
      Console.WriteLine("Second Number: ");
      string num2 = Console.ReadLine();
      Console.WriteLine("Third number: ");
      string num3 = Console.ReadLine();
      Console.WriteLine($"The colour code for the entered number is {Colorcode(num1,num2,num3)}");
      Console.ReadLine();*/
      
    }

     static string[] numbs = {"10", "11", "12", "13", "14", "15"};
     static string[] letters = {"A", "B", "C", "D", "E", "F"};
     static string ToDecimal(string number, int bases)
     {
       long temp = 0;
       string res = "";
       char[] value = number.ToCharArray();
       int length = value.Length ;
       int newLength = length;
       for (int i = 0; i < length; i++)
       {
         string val = value[i].ToString();
         for (int j = 0; j < 6; j++)
           if (val.ToUpper() == letters[j]) // check for length   
             val = numbs[j];
         newLength--;
         temp += (long)(int.Parse(val)*Math.Pow(bases, newLength));
       }
       res = temp.ToString();
       return res;
     }
     static string ToBase(string number, int bases, int based)
     {
       string ans = "";
       long numb = long.Parse(ToDecimal(number, bases));
       while (numb > 0)
       {
         long mod = numb % based;
         string mods = mod.ToString();
         for (int j = 0; j < 6; j++)
           if (mods == numbs[j])
             mods = letters[j];
         numb /= based;
         ans = mods + ans;
       }
       if (long.Parse(ToDecimal(number,bases)) == 0)
        ans = "0";
      
       return ans;
     }
    /* static string Colorcode(string num1, string num2, string num3)
    {
        string r = ToBase(num1, 10, 16);
        Console.WriteLine(r);
        r= r.Length<2? "0"+r : r;
        string g = ToBase(num2, 10, 16);
        Console.WriteLine(g);
        g= g.Length<2? "0"+g : g;
        string b = ToBase(num3, 10, 16);
        Console.WriteLine(b);
        b= b.Length<2? "0"+b : b;
        return "#" + r + g + b;
    }*/
  }
}