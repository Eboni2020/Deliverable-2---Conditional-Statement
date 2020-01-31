// Program details: the user will be prompted to enter a value between 0-100. The letter grade which 
// corresponds with this number will then be displayed to the user. If user inputs anything outside of 
// 0-100, they will receive an error message to input a value between 0-100

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


            //If user inputs anything between 98-100, they will receive a message indicating they will 
            //receive an "A+" letter grade
            if ((grade >= 98) && (grade<= 100))
                {
                Console.WriteLine("Congratulations, your letter grade is an A+");
                }

            //If user inputs anything between 92-97, they will receive a message indicating they will 
            //receive an "A" letter grade
            else if ((grade >= 92) && (grade<= 97))
                {
                Console.WriteLine("Congratulations, your letter grade is an A");
                }

            //If user inputs anything between 90-91, they will receive a message indicating they will 
            //receive an "A-" letter grade
            else if ((grade >= 90) && (grade<= 91))
                {
                Console.WriteLine("Congratulations, your letter grade would be a A-");
                }

            //If user inputs anything between 88-89, they will receive a message indicating they will 
            //receive a "B+" letter grade
            else if ((grade >= 88) && (grade<= 89))
                {
                Console.WriteLine("Congratulations, your letter grade would be a B+");
                }

            //If user inputs anything between 82-97, they will receive a message indicating they will 
            //receive a "B" letter grade
            else if ((grade >= 82) && (grade <= 87))
                {
                Console.WriteLine("Congratulations, your letter grade would be a B");
                }

            //If user inputs anything between 80-81, they will receive a message indicating they will 
            //receive a "B-" letter grade
            else if ((grade >= 80) && (grade <= 81))
                {
                Console.WriteLine("Congratulations, your letter grade would be a B-");
                }

            //If user inputs anything between 78-79, they will receive a message indicating they will 
            //receive a "C+" letter grade
            else if ((grade >= 78) && (grade <= 79))
                {
                Console.WriteLine("Congratulations, your letter grade would be a C+");
                }

            //If user inputs anything between 72-77, they will receive a message indicating they will 
            //receive a "C" letter grade
            else if ((grade >= 72) && (grade <= 77))
                {
                Console.WriteLine("Congratulations, your letter grade would be a C");
                }

            //If user inputs anything between 70-71, they will receive a message indicating they will 
            //receive a "C-" letter grade
            else if ((grade >= 70) && (grade <= 71))
                {
                Console.WriteLine("Congratulations, your letter grade would be a C-");
                }

            //If user inputs anything between 68-69, they will receive a message indicating they will 
            //receive a D+" letter grade
            else if ((grade >= 68) && (grade <= 69))
                {
                Console.WriteLine("Congratulations, your letter grade would be a D+");
                }

            //If user inputs anything between 62-67, they will receive a message indicating they will 
            //receive a D" letter grade
            else if ((grade >= 62) && (grade <= 67))
                {
                Console.WriteLine("Congratulations, your letter grade would be a D");
                }

            //If user inputs anything between 60-61, they will receive a message indicating they will 
            //receive a D-" letter grade
            else if ((grade >= 60) && (grade <= 61))
                {
                Console.WriteLine("Congratulations, your letter grade would be a D-");
                }

            //If user inputs anything between 0-65, they will receive a message indicating they will 
            //receive an "F" letter grade
            else if ((grade >= 0) && (grade <= 59))
                {
                Console.WriteLine("Unfortunately, you have failed this course with an F letter grade");
                }
            //If user does not input a numeric value between 0-100, the user receives a message to input
            //a value between 0-100
            else
                {
                Console.WriteLine("Please enter a value between 0-100.");
                }
            } //end of If/Else statement
    } //end of class
} //end of namespace