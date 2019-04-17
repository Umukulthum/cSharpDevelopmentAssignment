using System;
using System.Net.Sockets;

namespace quiz
{
    class Quiz
    {
        static void Main(string[] args)
        {
            Console.WriteLine("This quiz comprises of 10 questions each with 4 options.");
            Console.WriteLine("Before you proceed with the quiz, please fill in your correct details.");
            Console.Write("FULL NAME: ");
            string name = Console.ReadLine();
            Console.Write("HOME ADDRESS: ");
            Console.ReadLine();
            Console.Write("AGE: ");
            Console.ReadLine();
            beginning:
            Console.WriteLine(
                "__________________________________________________________________________");
            Console.WriteLine(
                "INSTRUCTIONS: You are required to read the questions carefully and choose the letter corresponding to the correct option.");
            Console.WriteLine("Press the Enter key to begin the test!");
            Console.ReadLine();
            Console.WriteLine(name.ToUpper() +", your score is " + QuizApplication()+ "%");
            Console.WriteLine(
                "__________________________________________________________________________");
            Console.WriteLine("\nPlease choose one of the following. \n1.\tTake the quiz again \n2.\tView the solution \n3.\tExit");
            string next = Console.ReadLine();
            if (next == "1")
                goto beginning;
            else if (next == "2")
            {
                Console.WriteLine(Solution());
                Console.ReadLine();
            }
            else
            Console.ReadKey();
        }
        
        static string[] answers = {"a", "c", "b", "a", "b", "a", "a", "b", "c", "c"};
        static string[] questions =
        {
            "\n1.\tWhich is the odd one out?\na) Nassarawa  b) Yobe c) Gombe d) Bauchi",
            "\n2.\tObama is the what President of America?\na) 46th  b) 45th  c) 44th  d) 43rd",
            "\n3.\tWhat is the Capital of Tanzania?\na) Dar es salam  b) Dodoma  c) Maputo  d) Kampala",
            "\n4.\tThe first military coup was in...?\na) Jan 1966  b) Jan 1960  c) Jan 1965  d) Jan 1962",
            "\n5.\tWhich of these cities is not in Africa?\na) Accra  b) Dhaka  c) Dakar  d) Banjul",
            "\n6.\tAba women riot happened in what year?\na) 1929  b) 1928  c) 1926  d) 1920",
            "\n7.\tWhat does the the two horses on the coat of arm of Nigeria stand for?\na) Dignity  b) Strength  c) Peace  d) Love",
            "\n8.\tNigeria is divided into how many geopolitical zones?\na) 5  b) 6  c) 7  d) 8",
            "\n9.\tHow many local government areas are in Nigeria?\na) 784  b) 754  c) 774  d) 764",
            "\n10.\twhat is the capital of Australia?\na) Brisbane  b) Sydney  c) Canberra  d) Melbourne"
        };
        static int QuizApplication()
        {   int score = 0;
            for (int i = 0; i < 10; i++)
            {
                Console.WriteLine(questions[i]);
                string sol = Console.ReadLine();
                if (sol.ToLower() == answers[i])
                    score += 1;
            }
            return score * 10;
        }
        static string Solution()
        {
            for (int j = 0; j < 10; j++)
            {
                Console.WriteLine(questions[j] + "\nAnswer: " + answers[j].ToUpper());
                Console.ReadLine();
            }

            return "";
        }

    }
}