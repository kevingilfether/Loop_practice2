using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Loop_practice2
{
    class Program
    {
        static void Main(string[] args)
        {
            // Loops, one of the most efficient ways to
            // code repetivie action

            //for loops

            //for (int i = 1; x <= 10; x++)
            //    Console.WriteLine(x);


            //for (int counter = 50; counter <= 100; counter++)
            //{
            //    Console.WriteLine(counter);
            //}


            //// Prints out each character of my name after splitting it in an array
            //string aGreetings = "My name is Kevin.";
            //string[] someWords = aGreetings.Split();

            //for (int i = 0; i < someWords.Length - 1; i++)
            //    Console.WriteLine(aGreetings[i]);

            //setting up the loop
            //for (int i = 1; i <= 10; i++)
            ////do this
            //{
            //    Console.WriteLine(i);
            //}

            //for (int counter = 50; counter <= 100; counter++)
            //{
            //    Console.Write(counter+" ");
            //}

            //string greeting = "My name is Kevin";
            //string[] words = greeting.Split();
            //// same as
            //// string [] words = { "My", "name", ... "Kevin"}

            //for (int i = 0; i <= words.Length - 1; i++)
            //    Console.WriteLine(words[i]);


            //string[] days = { "Monday", "Tuesday", "Wednesday" };
            //for (int i = 0; i <= days.Length - 1; i++)
            //{
            //    Console.WriteLine(days[i]);
            //}

            //string storyStart = "Once upon a time";
            //string[] storyWords = storyStart.Split();
            //Array.Reverse(storyWords);

            //for (int i = 0; i < storyWords.Length; i++)
            //{
            //    Console.WriteLine(storyWords[i]);
            //}


            //Now doing foreach loop, which does some operation 
            //on every item of an array

            //string[] months = { "Jan", "Feb", "Mar", "Apr", "May", "Jun", "Jul", "Aug", "Sep", "Oct", "Nov", "Dec" };
            //foreach(string month in months)
            //{
            //    Console.WriteLine(month);
            //}

            //string[] musicians = { "Charles Mingus", "Boris", "Booker T. & The MGs", "Windhand", "Charlotte Dos Santos" };

            //foreach(string musician in musicians)
            //{
            //    Console.WriteLine(musician);
            //}

            // More practice with foreach loops


            //string[] favoriteFoods = { "Pizza", "Sushi", "Taco Bell", "Good Polish food" };
            //foreach(string food in favoriteFoods)
            //{
            //    Console.WriteLine(food);
            //}

            //int[] luckyNumbers = { 3, 8, 191, 2093, 28 };
            //foreach(int number in luckyNumbers)
            //{
            //    Console.WriteLine("Your lucky number is: " + number);
            //}

            //Counting down for loops
            //for (int i = 10; i > 0; i--)
            //{
            //    Console.WriteLine(i);
            //}


            //while loop -- while something is true

            //Console.WriteLine("Do you want to play a game? (YES/NO)");
            //string playAgain = Console.ReadLine().ToUpper();

            //while (playAgain == "YES")
            //{
            //    Console.WriteLine("It's a rematch");
            //    Console.WriteLine("Do you want to play a game?");
            //    playAgain = Console.ReadLine();
            //}


            //Hospital Example for jaded nurse
            //Console.WriteLine("Do you want to check the user in for their appointment? (Y/N)");
            //string answer = Console.ReadLine().ToLower().Trim;
            //while (answer != "y")
            //{
            //    Console.WriteLine("PATIENT CHECK-IN SYSTEM");
            //    Console.WriteLine("What's the patient's full name?");
            //    Console.ReadLine();
            //    Console.WriteLine("What's the patient's six digit ID?");
            //    int.Parse(Console.ReadLine());
            //    Console.WriteLine("What time is the patient appt.?");
            //    Console.ReadLine();

            //    Console.WriteLine("\nDo you want to check another user in for their appointment? (Y/N)");
            //    answer = Console.ReadLine().ToLower();

            //do-while loops
            //like an upside-down while loop, always runs at least once

            //string playAgain;
            //do
            //{
            //    Console.WriteLine("Great Game!");
            //    Console.WriteLine("Do you want to play again? (y/n)");
            //    playAgain = Console.ReadLine().ToLower().Trim();
            //}
            //while (playAgain == "y");

            // GPA Calculation 
            string answer;
            do
            {
                Console.WriteLine("What class do you want to enter your grade for?");
                Console.ReadLine();
                Console.WriteLine("Enter your grade (no \"+\" or \"-\")");
                Console.ReadLine();
                Console.WriteLine("Do you have another class to enter?");
                answer = Console.ReadLine().ToLower().Trim();
            }
            while (answer == "yes" || answer == "y");


        }

    }

}

