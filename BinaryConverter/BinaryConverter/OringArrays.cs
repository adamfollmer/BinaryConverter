using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BinaryConverter
{
    public class OringArrays : ArrayComparer
    {
        public OringArrays()
        {
        }
        public void RunConverter(double FirstNumber, double SecondNumber)
        {
            SelectLargerNumber(FirstNumber, SecondNumber);
            AssignLists();
            AddOringArrays();
            addedArrays.Reverse();
            ConvertToInteger(addedArrays);
            Console.WriteLine();
            Console.WriteLine("Your result is: " + convertedInteger);
            Console.ReadLine();
        }
        public void AddOringArrays()
        {
            for (int rightBoolean = 0; rightBoolean < booleanListTwo.Count; rightBoolean++)
            {
                ReturnTrueTrueArray(rightBoolean);
            }
            booleanListOne.Reverse();
            for (int continuedRightBoolean = 0; continuedRightBoolean < (booleanListOne.Count - booleanListTwo.Count); continuedRightBoolean++)
            {
                AddSingleArray(continuedRightBoolean);
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
                ReturnTrueFalseArray(index);
            }
        }
        public void ReturnTrueFalseArray(int index)
        {
            if ((booleanListOne[index] == true && booleanListTwo[index] == false) || 
                (booleanListOne[index] == false && booleanListTwo[index] == true))
            {
                addedArrays.Add(true);
            }
            else
            {
                addedArrays.Add(false);
            }
        }
        public void AddSingleArray(int index)
        {
            if (booleanListOne[index] == true)
            {
                addedArrays.Add(true);
            } else
            {
                addedArrays.Add(false);
            }
        }
    }
}
