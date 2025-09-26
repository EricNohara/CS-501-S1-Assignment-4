class Program
{
    public static string sentenceCapitalizer(string? sentence)
    {
        if (string.IsNullOrWhiteSpace(sentence)) return "Inputted string is empty so there is nothing to capitalize!";

        // split the string up into chars and iterate over them to set the correct values as capitalized
        char[] chars = sentence.ToCharArray();
        bool capitalizeNext = true;

        for (int i = 0; i < chars.Length; i++)
        {
            // capitalize the letter and reset flag if the current char is a letter
            if (capitalizeNext && char.IsLetter(chars[i]))
            {
                chars[i] = char.ToUpper(chars[i]);
                capitalizeNext = false;
            }

            // set capitalizeNext flag if the current char is any punctuation 
            if (chars[i] == '.' || chars[i] == '?' || chars[i] == '!')
            {
                capitalizeNext = true;
            }
        }

        // return the string from the corrected char array
        return new string(chars);
    }

    static void Main(string[] args)
    {
        Console.WriteLine("Enter a sentence:");
        string? input = Console.ReadLine();

        string capitalizedSentence = sentenceCapitalizer(input);

        Console.WriteLine("\nCapitalized result:");
        Console.WriteLine(capitalizedSentence);

        Console.ReadLine();
    }
}