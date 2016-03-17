using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BinaryConverter
{
    public class ArrayAnder : ArrayComparer
    {
        public ArrayAnder()
        {
        }
        public void RunConverter(double FirstNumber, double SecondNumber)
        {
            SelectLargerNumber(FirstNumber, SecondNumber);
            AssignLists();
            AndArrays();
            addedArrays.Reverse();
            ConvertToInteger(addedArrays);
            Console.WriteLine();
            Console.WriteLine("Your result is: " + convertedInteger);
            Console.ReadLine();
        }
        public void AndArrays()
        {
            for (int rightBoolean = 0; rightBoolean < booleanListTwo.Count; rightBoolean++)
            {
                ReturnTrueTrueArray(rightBoolean);
            }
            booleanListOne.Reverse();
            for (int continuedRightBoolean = 0; continuedRightBoolean < (booleanListOne.Count - booleanListTwo.Count); continuedRightBoolean++)
            {
                addedArrays.Add(false);
            }

        }
        public void ReturnTrueTrueArray(int index)
        {
            if ((booleanListOne[index] == true && booleanListTwo[index] == true))
            {
                addedArrays.Add(true);
            }
            else
            {
                addedArrays.Add(false);
            }
        }
    }
}
