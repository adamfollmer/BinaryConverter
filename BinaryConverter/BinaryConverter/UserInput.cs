using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BinaryConverter
{
    public class UserInput
    {
        public double userInput1;
        public double userInput2;
        public int gameSelection = 1;
        ArrayComparer regularProgram = new ArrayComparer();
        ArrayAnder anderProgram = new ArrayAnder();
        OringArrays oringProgram = new OringArrays();

        public UserInput()
        {
        }
        public double TakeUserInput()
        {
            double userInput;
            try
            {
                userInput = Convert.ToDouble(Console.ReadLine());
            }
            catch (FormatException)
            {
                Console.WriteLine("Not a valid number, enter a valid number.");
                return TakeUserInput();
            }
            if (userInput <= 0)
            {
                Console.WriteLine("Please provide a number greater than 0");
                return TakeUserInput();
            }
            return userInput;
        }
        public void AssignUserInput()
        {
            Console.WriteLine("Please enter in your first number");
            userInput1 = TakeUserInput();
            Console.WriteLine("Please enter in your second number");
            userInput2 = TakeUserInput();
            Console.WriteLine();
        }
        public void DecideStandardAndOr()
        {

        }
        public void RunUserInput()
        {
            AssignUserInput();
            SelectGame();
        }
        public void SelectGame()
        {
            Console.WriteLine("Which version would you like to perform?");
            Console.WriteLine("1. Regular adding");
            Console.WriteLine("2. AND adding");
            Console.WriteLine("3. OR adding");
            switch (gameSelection = TakeGameType())
            {
                case 1:
                    regularProgram.RunConverter(userInput1, userInput2);
                    break;
                case 2:
                    anderProgram.RunConverter(userInput1, userInput2);
                    break;
                case 3:
                    oringProgram.RunConverter(userInput1, userInput2);
                    break;
                default:
                    break;
            }
        }
        public int TakeGameType()
        {
            int userInput;
            try
            {
                userInput = Convert.ToInt32(Console.ReadLine());
            }
            catch (FormatException)
            {
                Console.WriteLine("Not a valid number, enter a valid number.");
                return TakeGameType();
            }
            if (userInput <= 0 || userInput >= 4)
            {
                Console.WriteLine("Please provide a number greater than 0 and less than 4");
                return TakeGameType();
            }
            return userInput;
        }
    }
}
