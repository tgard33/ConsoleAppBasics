namespace CodeTestandLearning
{
    class Program
    {
        static void Main(string[] args)
        {
       

            //for loop printing out all elements inside of an array
            int[] luckyNumbers = { 2, 4, 6, 8, 33 };
            for(int i = 0; i < luckyNumbers.Length; i++)
            {
                Console.WriteLine(luckyNumbers[i]);
            }
            
            
            //Guessing Game

            string secretWord = "Money";
            string guess = "";
            int guessCount = 0;
            int guessLimit = 6;
            bool outOfGuesses = false;

            while (guess != secretWord && !outOfGuesses)
            {
                if (guessCount < guessLimit)
                {
                    Console.Write("Enter a word for your Guess: ");
                    guess = Console.ReadLine();
                    guessCount++;
                }
                else
                {
                    outOfGuesses = true;

                }


            }
                if (outOfGuesses)
                {
                    Console.WriteLine("Sorry, you lose!");
                }
                else
            {
                Console.WriteLine("You Win! Congrats!");
            }

            
            



            //Call the method "TheDay" to get what day it is.
            Console.WriteLine(TheDay());

            Console.WriteLine(GetMax(68, 69, 70));

            string name = "Tyler Gardner";
            string company = "The Grind Never Stops";
            int playersNumber = 33;

            Console.WriteLine("                "   +name + playersNumber);
            Console.WriteLine("          ___________________________");
            Console.WriteLine("         |_____________  ____________|");
            Console.WriteLine("            __________|  |_________");
            Console.WriteLine("           |   _______|  |_________|");
            Console.WriteLine("           |  |       |  |");
            Console.WriteLine("           |  |       |  |   ______");
            Console.WriteLine("           |  |       |  |  |____  |");
            Console.WriteLine("           |  |       |  |       | |");
            Console.WriteLine("           |  |_______|  |_______| |");
            Console.WriteLine("           |__________|  |_________|");
            Console.WriteLine("                      |  |");
            Console.WriteLine("                      |__|");
            Console.WriteLine("");
            Console.WriteLine("              "+company);
            Console.WriteLine("");
            Console.WriteLine("");

            SayHi();

            //Question and answer

            Console.Write("Please Enter Your First and Last Name: ");
            string userName = Console.ReadLine();
            Console.WriteLine("Hello " +userName);
            Console.Write("Please Enter Your Favorite Number: ");
            string favoriteNumber = Console.ReadLine();
            Console.WriteLine(favoriteNumber+" is a cool number");

           //Simple Calculator example

            Console.Write("Enter a whole number: ");
            int num1 = Convert.ToInt32(Console.ReadLine());

            Console.Write("Enter another whole number: ");
            int num2 = Convert.ToInt32(Console.ReadLine());

            Console.Write("The sum of those two numbers is: ");
            Console.WriteLine(num1 + num2);
            

            //Game of fill in the blanks (Mad Lib Example)

            string color, pluralnoun, celebrity;

            Console.Write("Enter a color: ");
            color = Console.ReadLine();

            Console.Write("Enter a plural noun: ");
            pluralnoun = Console.ReadLine();

            Console.Write("Enter a celebrity: ");
            celebrity = Console.ReadLine(); 


            Console.WriteLine("Roses are " + color);
            Console.WriteLine(pluralnoun + " are blue");
            Console.WriteLine("I love "  + celebrity);

            //Array's example (container that holds a bunch of pieces of information)
            int[] luckynumbers = { 5, 10, 12, 15, 33, 23, 99 };
            string[] sports = new string[10];
            sports[0] = "Baseball";
            sports[1] = "Golf";
            sports[2] = "Basketball";

            Console.WriteLine(luckynumbers[0]);
            Console.WriteLine(sports[1]);


            //If statements
            bool isMale = false;
            bool isTall = true;

            if (isMale && isTall)
            {
                Console.WriteLine("You have a sausage and taters! You are also Tall!");

            }
            else if (isMale && !isTall)
            {
                Console.WriteLine("You are a male but you are not tall!");
            }
            else if (!isMale && isTall)
            {
                Console.WriteLine("You are a tall female!");
            }
            else
            {
                Console.WriteLine("You have a hoo haaa and tetas!");
            }
         
                   
           

            Console.ReadLine();

        }

        //Method example (block of code to perform specific task) Created this, and called it in Main string method above
        //Method and function are essentially the same thing. The official term is method however

        static void SayHi() 
        {
            Console.WriteLine("Hello User");
        }

        //Method with a return statement

        static string TheDay()
        {
           
            Console.Write("What Day is Today? ");
            string day = Console.ReadLine();
            return day;

        }

        static int GetMax(int num1, int num2, int num3)
        {
            int result;
            if (num1 >= num2 && num1 >= num3)
            {
                result = num1;
            }
            else if (num2 >= num1 && num2 >= num3)
            {
                result = num2;
            }
            else 
            { 
                result = num3; 
            }


            return result;
        }
       //test
    }

 }

