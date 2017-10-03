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

            string[] months = { "Jan", "Feb", "Mar", "Apr", "May", "Jun", "Jul", "Aug", "Sep", "Oct", "Nov", "Dec" };
            foreach(string month in months)
            {
                Console.WriteLine(month);
            }

            string[] musicians = { "Charles Mingus", "Boris", "Booker T. & The MGs", "Windhand", "Charlotte Dos Santos" };

            foreach(string musician in musicians)
            {
                Console.WriteLine(musician);
            }



        }

    }

}

