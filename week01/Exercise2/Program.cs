using System;

class Program
{
    static void Main(string[] args)
    {
        Console.WriteLine("Hello World! This is the Exercise2 Project.");

        Console.Write("What is your grade percentage? ");
        string grade = Console.ReadLine();
        int percentage = int.Parse(grade);

        string LetterGrade = "";

        if (percentage >= 97)
        {
            LetterGrade = "A+";
        }
        else if (percentage <= 96 && percentage >= 94)
        {
            LetterGrade = "A";
        }
        else if (percentage <= 93 && percentage >= 90)
        {
            LetterGrade = "A-";
        }
        else if (percentage <= 89 && percentage >= 87)
        {
            LetterGrade = "B+";
        }
        else if (percentage <= 86 && percentage >= 84)
        {
            LetterGrade = "B";
        }
        else if (percentage <= 83 && percentage >= 80)
        {
            LetterGrade = "B-";
        }
        else if (percentage <= 79 && percentage >= 77)
        {
            LetterGrade = "C+";
        }
        else if (percentage <= 76 && percentage >= 74)
        {
            LetterGrade = "C";
        }
        else if (percentage <= 73 && percentage >= 70)
        {
            LetterGrade = "C-";
        }
        else if (percentage <= 69 && percentage >= 67)
        {
            LetterGrade = "D+";
        }
        else if (percentage <= 66 && percentage >= 64)
        {
            LetterGrade = "D";
        }
        else if (percentage <= 63 && percentage >= 60)
        {
            LetterGrade = "D-";
        }
        else
        {
            LetterGrade = "F";
        }

        Console.WriteLine($"Your letter grade is: {LetterGrade}");

        if (percentage >= 70)
        {
            Console.WriteLine($"Congratulations! You passed!");
        }
        else
        {
            Console.WriteLine($"You did not pass. Come back later to try again!");
        }
    }
}