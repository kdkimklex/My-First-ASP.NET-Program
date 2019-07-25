using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

//namespace
namespace MyFirstTry
{   //Main Class
	class Program
	{   //Entry Point Method
		static void Main(string[] args)
		{

            GetAppInfo();//Get App Info

            GreetUser();//Greet user
            

            while (true)
            {

                //Initialize Correct number
                //int correctNumber = 8;

                //Create a New Random object
                Random random = new Random();

                //Initialize Correct number
                int correctNumber = random.Next(1, 10);

                //Initialize Guess Variable
                int guess = 0;

                //Ask a number for user
                Console.WriteLine("Guess a number between 1 to 10");

                //While guess is not correctNum
                while (guess != correctNumber)
                {
                    //Get User's input
                    string input = Console.ReadLine();

                    //Make sure its a number
                    if (!int.TryParse(input, out guess))
                    {
                        //Print Error Message
                        PrintColourMsg(ConsoleColor.Red, "Please, Enter a actual number!");

                        //Keep Going
                        continue;


                    }

                    //Cast int to and put in guess
                    guess = Int32.Parse(input);

                    //Match guess to correctNumber
                    if (guess != correctNumber)
                    {
                       
                        //Print Error Message
                        PrintColourMsg(ConsoleColor.Red, "Wrong Number, Please Try again !");

                    }


                }

                //Output Success Message

                PrintColourMsg(ConsoleColor.Yellow, "You are CORRECT!!!");

                //Ask Play again
                Console.WriteLine("Do you want to play again ? [Y or N]");

                //Get the answer
                string ans = Console.ReadLine().ToUpper();

                if(ans == "Y")
                {
                    continue;
                }
                else if (ans == "N")
                {
                    return;
                }
                else
                {
                    return;
                }




            }

        }

        //Dispaly app info
        static void GetAppInfo()
        {
            //Set app variables
            string appName = "Number Gusser";
            string appVersion = "1.0.0";
            string appAuother = "Kanchi Wasalamudali";

            //Change text colour
            Console.ForegroundColor = ConsoleColor.DarkBlue;

            //Write app info
            Console.WriteLine("{0} : Version {1} by {2}", appName, appVersion, appAuother);

            //Reset text colour
            Console.ResetColor();
        }
        //Greet user
        static void GreetUser()
        {
            //Ask User Name
            Console.WriteLine("What is your Name ?");

            //Get User Name
            string inputName = Console.ReadLine();

            Console.WriteLine("Hello {0}, let's play a game ...", inputName);
        }
        //Print colour message
        static void PrintColourMsg(ConsoleColor colour,string msg)
        {
            //Change text colour
            Console.ForegroundColor = colour;

            //Tell User its not a number
            Console.WriteLine(msg);

            //Reset text colour
            Console.ResetColor();
        }
        
            
        
	}
}
