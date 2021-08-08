using System;

namespace GuessingGame
{
    class Program
    {
        static void Main(string[] args)
        {
            //Generates random number from 1 to 10
            int randomNumber = new System.Random().Next(1,11);

            //Default Player Info.
            var one = new Player("",0,"",0);
            

            Console.WriteLine("Hello, Welcome to the Guessing Game! You must pick a random number between one and ten. You begin with three lives. If you guess wrong, you lose a life, lose all three and you lose the game. In order to win you must correctly guess the number. Good Luck!"  ); 
            

            //Asks for Player to input their data
            Console.WriteLine("Input Name: ");
            string xname = Console.ReadLine();
            one.Name = xname;
            
            while(one.Age <= 0 || one.Age >= 100)
            {
                
                Console.WriteLine("Input Age: ");
                int xage = Convert.ToInt32(Console.ReadLine()); //"convert" allows inputs of ints
                one.Age = xage;

                if(one.Age <= 0 || one.Age >= 100)
                {
                    Console.WriteLine("Error!"); //test
                }

            }

            DateTime current = DateTime.Now; //todays year
            one.BirthYear = current.Year - one.Age;
            
            
            Console.WriteLine("Input Gender or Gender Identity: ");
            string xgender = Console.ReadLine();
            one.Gender = xgender;

            Console.WriteLine(one.toString());//Displays Player's Info.

            Console.WriteLine("Press Any Key to Begin...");
            Console.ReadKey();

            
            int lives = 3;
            while(lives > 0)
           {
               Console.WriteLine("Input Guess: ");
               int guess = Convert.ToInt32(Console.ReadLine());

               if(guess == randomNumber)
               {
                   break;
               }
               else
               {
                   lives--;
                   Console.WriteLine($"Lives Left: {lives}");
               }
           }

           if(lives == 0)
           {
               Console.WriteLine("You Lost!");
           }
           else
           {
                Console.WriteLine($"Congrats {one.Name}, You Have Won!");
           }

           

        } 
    }  
}
