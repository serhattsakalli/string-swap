namespace string_swap;

class Program
{  
    static void Main(string[] args)
    {
        Console.Write("Input: ");
        string input = Console.ReadLine();
        string output = SwapFirstAndLastCharacters(input);
        Console.WriteLine("Output: " + output);
        Console.ReadKey();
    }
    static string SwapFirstAndLastCharacters(string input)
    {
        string[] words = input.Split(' ');
        for (int i = 0; i < words.Length; i++)
        {
            if (words[i].Length > 1)
            {
                char firstChar = words[i][0];
                char lastChar = words[i][words[i].Length - 1];
                string middle = words[i].Substring(1, words[i].Length - 2);
                words[i] = lastChar + middle + firstChar;
            }
        }
        return string.Join(" ", words);
    }
}  
