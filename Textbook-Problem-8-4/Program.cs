class Program
{
    // used for efficient lookups of vowels when searching
    public static HashSet<char> VOWELS = new HashSet<char> { 'a', 'e', 'i', 'o', 'u', 'A', 'E', 'I', 'O', 'U' }; 

    public static int countVowels(string? s)
    {
        if (string.IsNullOrEmpty(s)) return 0;

        // for every letter, add one if it is in the vowels hash set
        int count = 0;
        foreach (char c in s)
        {
            if (VOWELS.Contains(c))
            {
                count++;
            }
        }

        return count;
    }

    public static int countConsonants(string? s)
    {
        if (string.IsNullOrEmpty(s)) return 0;

        // for every letter, add one if it is a letter AND it is NOT a vowel
        int count = 0;
        foreach (char c in s)
        {
            if (char.IsLetter(c) && !VOWELS.Contains(c))
            {
                count++;
            }
        }

        return count;
    }

    static void Main(string[] args)
    {
        Console.WriteLine("Enter a string to count vowels and consonants!");
        string? input = Console.ReadLine();
        int numVowels = countVowels(input);
        int numConsonants = countConsonants(input);

        Console.WriteLine($"Your string contained {numVowels} vowels and {numConsonants} consonants!");
        Console.ReadLine();
    }
}