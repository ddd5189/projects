using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProjectBandersnatchV._01
{
    class Program
    {
        static void Main(string[] args)
        {
            // global variable helpers
            string gResponse;
            bool gLoopHelper = true;

            // choice specfic variable helpers

            // introduction
            Console.WriteLine("Welcome to Project Bandersnatch!\n" +
                "This is an interactive story where you will have choices to make throughout the story.");

            // quick tutorial for the player
            Console.WriteLine("");
            // text before choice, so it doesn't repeat if the player submits an invalid option
            Console.WriteLine("The follow is going to ask a basic question to show you how it works");
            // tutorial loop
            // standard loop for choices
            while (gLoopHelper)
            {
                // text 
                Console.WriteLine("A or B?");
                // reading the players response
                gResponse = Console.ReadLine().Trim();
                // if one of the options set gLoopHelper to false to escape the loop
                if (gResponse == "a" || gResponse == "A")
                {
                    Console.WriteLine("You selected A");
                    gLoopHelper = false;
                }
                else if (gResponse == "b" || gResponse == "B")
                {
                    Console.WriteLine("You selected B");
                    gLoopHelper = false;
                }
                // if invalid, state so and re-ask the question
                else
                {
                    Console.WriteLine(gResponse + " is not a proper response, please enter an appropriate choice");
                }
            }
            // reset gLoopHelper to true so that it can enter next while loop
            gLoopHelper = true;

            // a series of storytelling and checks that move the story through properly based on what is chosen


        }
    }
}
