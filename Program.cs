using System;

namespace Deliverable_2___Conditional_Statement
{
    class Program
    {
        static void Main(string[] args)
        {
            // User is asked to input the numeric number of the grade they expect to receive in ISM 4300
            Console.WriteLine("Hello, please type in the numeric grade you expect to earn in ISM 4300");

            // Declare variables and convert grade from string input into int
            string input = Console.ReadLine();
            int grade;
            grade = int.Parse(input);
            // Console.ReadLine();

            //If Else statement used to display the student's letter grade based on the numeric value input for input expected grade starting from an A+ down to an F letter grade
            if ((grade >= 98) && (grade<= 100))
                {
                Console.WriteLine("Congratulations, your letter grade is an A+");
                }
            else if ((grade >= 92) && (grade<= 97))
                {
                Console.WriteLine("Congratulations, your letter grade is an A");
                }
            else if ((grade >= 90) && (grade<= 91))
                {
                Console.WriteLine("Congratulations, your letter grade would be a A-");
                }
            else if ((grade >= 88) && (grade<= 89))
                {
                Console.WriteLine("Congratulations, your letter grade would be a B+");
                }
            else if ((grade >= 82) && (grade <= 87))
                {
                Console.WriteLine("Congratulations, your letter grade would be a B");
                }
            else if ((grade >= 80) && (grade <= 81))
                {
                Console.WriteLine("Congratulations, your letter grade would be a B-");
                }
            else if ((grade >= 78) && (grade <= 99))
                {
                Console.WriteLine("Congratulations, your letter grade would be a C+");
                }
            else if ((grade >= 72) && (grade <= 77))
                {
                Console.WriteLine("Congratulations, your letter grade would be a C");
                }
            else if ((grade >= 70) && (grade <= 71))
                {
                Console.WriteLine("Congratulations, your letter grade would be a C-");
                }
            else if ((grade >= 68) && (grade <= 69))
                {
                Console.WriteLine("Congratulations, your letter grade would be a D+");
                }
            else if ((grade >= 62) && (grade <= 67))
                {
                Console.WriteLine("Congratulations, your letter grade would be a D");
                }
            else if ((grade >= 60) && (grade <= 61))
                {
                Console.WriteLine("Congratulations, your letter grade would be a D-");
                }
            else if ((grade >= 0) && (grade <= 59))
                {
                Console.WriteLine("Unfortunately, you have failed this course with an F letter grade");
                }
            //If user does not input a numeric value between 0-100, the user receives a message to input a value between 0-100
            else
                {
                Console.WriteLine("Please enter a value between 0-100.");
                }
            } //end of If/Else statement
    } //end of class
} //end of namespace