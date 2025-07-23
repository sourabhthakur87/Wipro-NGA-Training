
class Stringss
{
    public static void Main()
    {
        Console.WriteLine("Enter Your String");
        string s = Console.ReadLine() ?? string.Empty;
        Console.WriteLine("The Length Of String is :- " + s.Length);

        string space = s.Replace(" ", "");
        // Console.WriteLine(space.Length);

        int CharCount = 0;
        int VowelCount = 0;
        int letter = 0;
        int number = 0;
        foreach (char ch in space)
        {
            if (!char.IsLetterOrDigit(ch) && !char.IsDigit(ch))
            {
                CharCount++;
            }
            if ("aeiouAEIOU".Contains(ch))
            {
                VowelCount++;
            }
            if (char.IsLetter(ch))
            {
                letter++;
            }
            if (char.IsNumber(ch))
            {
                number++;
            }
        }
        int TotalAlphabet = space.Count(char.IsLetter);

        Console.WriteLine("The Special Character is: " + CharCount);
        Console.WriteLine("The Vowel is: " + VowelCount);
        Console.WriteLine("The Consonent is: " + (TotalAlphabet - VowelCount));
        Console.WriteLine("Total Letters is:- " + letter);
        Console.WriteLine("Total number is:- " + number);

    }
}

// Thi1s is @3esf S354Urabh

// The Length Of String is = 24
// The Count Of Alphabest is = 15
// The count of Vowel is = 5
// The Special Character is  = 1
// The Consonent count is  = 10
// The Number count is  = 5

//a e i o u