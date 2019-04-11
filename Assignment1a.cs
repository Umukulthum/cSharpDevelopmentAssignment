using static System.Console;
class Assignment1a
{
    static void Main2(string[] args)
    {
        Write("Enter a word: ");
        string word = ReadLine();
        WriteLine($"The reverse of {word} is {ReverseString(word)}");
        ReadLine();
    }
    static string ReverseString(string word)
    {
        //int length = word.Length;
        string newWord = "";
        //Happy
        for (int i=0; i<word.Length; i++)
        {
            newWord = word[i] + newWord; 
        }

        return newWord;
    }
}
