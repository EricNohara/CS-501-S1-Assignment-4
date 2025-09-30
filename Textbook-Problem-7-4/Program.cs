using System.IO;
class Program
{
    //array of correct answers 
    private static string[] correctAnswers = [
        "B", "D", "A", "A", "C", "A", "B", "A", "C", "D",
            "B", "C", "D", "A", "D", "C", "C", "B", "D", "A"
        ];


    private static string GetFilePath() //needs a function to return the file string value 
    {
        Console.WriteLine("Enter the path to the student answers file: ");
        string filePath = Console.ReadLine()?.Trim();
        return string.IsNullOrEmpty(filePath) ? null : filePath.Trim('"');
    }

    private static string[] ReadAnswers(string filePath) // to double check if text file exceeded or is under 20 answers. 
    {
        string[] studentAnswers = new string[20];
        int answerCount = 0;

        using (StreamReader reader = new StreamReader(filePath))
        {
            string line;
            // Read until we have 20 answers or reach end of file
            while ((line = reader.ReadLine()) != null && answerCount < 20)
            {
                if (!string.IsNullOrWhiteSpace(line))
                {
                    studentAnswers[answerCount] = line.Trim().ToUpper();
                    answerCount++;
                }
            }
        }
        Console.WriteLine($"Successfully read {answerCount} answers.");
        return studentAnswers;
    }

    private static void gradeExam(string[] studentAnswers)  //compare answers from file to correct answers
    {
        int correctCount = 0;
        int wrongCount = 0;
        List<int> incorrectQuestions = new List<int>(); //add all wrong answer numbers here

        for (int i = 0; i < studentAnswers.Length; i++)
        {
            if (studentAnswers[i] == correctAnswers[i])
            {
                correctCount++;
            } else
            {
                wrongCount++;
                incorrectQuestions.Add(i + 1); //question number is index + 1

            }
        }

        //print out results based on grade
        bool passed = correctCount >= 15;
        Console.WriteLine($"Result: {(passed ? "PASSED" : "FAILED")}");
        Console.WriteLine($"Correct: {correctCount}/20");
        Console.WriteLine($"Incorrect: {wrongCount}/20");
        Console.WriteLine("Questions that were incorrect: ");
        Console.WriteLine(string.Join(", ", incorrectQuestions));
    }

    static void Main(string[] args)
    {
        string filePath = GetFilePath();

        //end program if no file is given
        if (string.IsNullOrEmpty(filePath))
        {
            Console.WriteLine("No file selected. Exiting...");
            return;
        }

        try
        {
            //get answers from file and grade them
            string[] studentAnswers = ReadAnswers(filePath);
            gradeExam(studentAnswers);
        }
        catch (Exception ex)
        {
            Console.WriteLine($"Error: {ex.Message}");
        }

        Console.WriteLine();
        Console.WriteLine("Press any key to exit...");
        Console.ReadKey();
    }
}