using System;
class Assignment1c
{
    static void Main4(string[] args)
    {
        Console.Write("Enter your name: ");
		string Name = Console.ReadLine();
		Console.Write("Enter your score: ");
		bool success = int.TryParse(Console.ReadLine(), out int Score);
		Console.WriteLine(success ? ($"{Name}, your grade is {ResultGradingApplication(Score)}") : "Enter a valid number");
		Console.ReadLine();
    }
	static string ResultGradingApplication(int Score)
	{	
		return (Score <= 100 && Score >= 80) ? "A" : Score >= 65 ? "AB" : Score >= 55 ? "B" : Score >= 45 ? "C" : Score >= 35 ? "CD" : Score >= 25 ? "D" : Score >= 15 ? "E" : Score >= 0 ? "F" : "Please Enter your score!";
    }
}

