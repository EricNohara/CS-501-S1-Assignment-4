class Program
{
    public static char getMostFrequentChar(string? s)
    {
        if (string.IsNullOrEmpty(s))
            throw new ArgumentException("Input string cannot be empty");

        // create and full a charCounts dictionary containing the frequency for every char in the string
        Dictionary<char, int> charCounts = new Dictionary<char, int>();

        foreach (char c in s)
        {
            if (charCounts.ContainsKey(c))
            {
                charCounts[c]++;
            } else
            {
                charCounts.Add(c, 1);
            }
        }

        // use the dictionary to get the most frequent char
        char mostFrequentChar = charCounts.First(k => k.Value == charCounts.Values.Max()).Key;
        return mostFrequentChar;
    }
    static void Main(string[] args)
    {
        Console.WriteLine("Enter a string to test");
        string? input = Console.ReadLine();

        try
        {
            char mostFrequentChar = getMostFrequentChar(input);
            Console.WriteLine($"The most frequent character in your input string was: {mostFrequentChar}");
        }
        catch (Exception ex)
        {
            Console.WriteLine(ex.ToString());
        }

        Console.ReadLine();
    }
}