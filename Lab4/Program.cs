using System;

namespace Lab4
{
    class MainClass
    {
        public static void Main(string[] args)
        {
            while (true) 
            {
                double Square, Cube; //declare variables

                //prompt
                Console.WriteLine("Learn your squares and cubes!");
                //input 
                Console.Write("Enter an integer: ");
                //convert string to double
                int userInput = int.Parse(Console.ReadLine());
                //print tab headers. added a space to center
                Console.WriteLine("\t Number\t Square\t Cube");
                //adds the line separation
                Console.WriteLine("\t=======\t=======\t=======");  
                //loop as many times as the userIput/counter value, then calculate for (square and cuded) and display values
                for (int i = 1; i <= userInput; i++) 
                {
                    Square = i * i;
                    Cube = i * i * i;
                    Console.WriteLine("\t{0}\t{1}\t{2}", i, Square, Cube);
                    //string header = string.Format("{0, -10}", "number");
                }

                //validation 
                Console.Write("Would you like to continue? (y/n): "); 

                string answer = Console.ReadLine().ToLower();//converts input to lowercase  
                if (answer != "y") 
                {
                    break;                
                }
            }
        }
    }

}


//https://www.dreamincode.net/forums/topic/16046-calculating-square-and-cubes/

/* Square = Number * Number;
Cube = Square * Number;
Console.WriteLine("\t{0}\t{1}\t{2}", Number, Square, Cube);*/


// end of calculate and display 