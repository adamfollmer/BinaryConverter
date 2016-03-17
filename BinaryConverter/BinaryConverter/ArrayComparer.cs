using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BinaryConverter
{
    public class ArrayComparer
    {
        public List<bool> booleanListOne = new List<bool>();
        public List<bool> booleanListTwo = new List<bool>();
        public List<bool> addedArrays = new List<bool>();
        public double largerNumber;
        public double smallerNumber;
        public bool holdExtra;
        public int convertedInteger;

        public ArrayComparer()
        {
        }
        public void RunConverter(double FirstNumber, double SecondNumber)
        {
            SelectLargerNumber(FirstNumber, SecondNumber);
            AssignLists();
            AddArrays();
            addedArrays.Reverse();
            ConvertToInteger(addedArrays);
            Console.WriteLine();
            Console.WriteLine("Your result is: " + convertedInteger);
            Console.ReadLine();
        }
        public void SelectLargerNumber(double FirstNumber, double SecondNumber)
        {
            if (FirstNumber >= SecondNumber)
            {
                largerNumber = FirstNumber;
                smallerNumber = SecondNumber;
            } else
            {
                largerNumber = SecondNumber;
                smallerNumber = FirstNumber;
            }
        }
        public void ConvertToInteger(List<bool> Binary)
        {
            foreach (bool binaryDigit in Binary)
            {
                if (binaryDigit == true)
                {
                    convertedInteger = (convertedInteger + 1) * 2;
                }
                else
                {
                    convertedInteger = convertedInteger * 2;
                }
            }
            convertedInteger = convertedInteger / 2;
        }
        public void ConvertToBinary(double IntegerToConvert, List<bool> OutputList)
        {
            while (IntegerToConvert >= 1)
            {
                if (IntegerToConvert % 2 == 1)
                {
                    OutputList.Add(true);
                    IntegerToConvert = (IntegerToConvert / 2) - .5;
                }
                else
                {
                    OutputList.Add(false);
                    IntegerToConvert = IntegerToConvert / 2;
                }
            }
        }
        public void AssignLists()
        {
            ConvertToBinary(largerNumber, booleanListOne);
            ConvertToBinary(smallerNumber, booleanListTwo);
            //booleanListOne.Reverse();
            //booleanListTwo.Reverse();
        }
        public void AddArrays()
        {
            for (int rightBoolean = 0; rightBoolean < booleanListTwo.Count; rightBoolean++)
            {
                ReturnHoldTrueArrayTrue(rightBoolean);
            }
            booleanListOne.Reverse();
            for (int continuedRightBoolean = 0; continuedRightBoolean < (booleanListOne.Count - booleanListTwo.Count); continuedRightBoolean++)
            {
                PerformSingleArrayLogic(continuedRightBoolean);
            }
            if (holdExtra == true)
            {
                addedArrays.Add(true);
            }
        }
        public void PerformSingleArrayLogic(int index)
        {
            if (holdExtra == true && booleanListOne[index] == true)
            {
                addedArrays.Add(false);
                holdExtra = true;
            }
            else if (holdExtra == true && booleanListOne[index] == false)
            {
                addedArrays.Add(true);
                holdExtra = false;
            }
            else if (holdExtra == false && booleanListOne[index] == true)
            {
                addedArrays.Add(true);
                holdExtra = false;
            }
            else if (holdExtra == false && booleanListOne[index] == false)
            {
                addedArrays.Add(false);
                holdExtra = false;
            }
        }
        public void ReturnHoldTrueArrayTrue(int index)
        {
            if (booleanListOne[index] == true && booleanListTwo[index] == true && holdExtra == true)
            {
                addedArrays.Add(true);
                holdExtra = true;
            }
            else
            {
                ReturnHoldTrueArrayFalse(index);
            }
        }
        public void ReturnHoldTrueArrayFalse(int index)
        {
            if ((booleanListOne[index] == false && booleanListTwo[index] == true && holdExtra == true)
                || (booleanListOne[index] == true && booleanListTwo[index] == false && holdExtra == true)
                    || (booleanListOne[index] == true && booleanListTwo[index] == true && holdExtra == false))
            {
                addedArrays.Add(false);
                holdExtra = true;
            }
            else
            {
                ReturnHoldFalseArrayTrue(index);
            }
        }
        public void ReturnHoldFalseArrayTrue(int index)
        {
            if ((booleanListOne[index] == false && booleanListTwo[index] == false && holdExtra == true)
                || (booleanListOne[index] == true && booleanListTwo[index] == false && holdExtra == false)
                    || (booleanListOne[index] == false && booleanListTwo[index] == true && holdExtra == false))
            {
                addedArrays.Add(true);
                holdExtra = false;
            }
            else
            {
                ReturnHoldFalseArrayFalse(index);
            }
        }
        public void ReturnHoldFalseArrayFalse(int index)
        {
            if (booleanListOne[index] == false && booleanListTwo[index] == false && holdExtra == false)
            {
                addedArrays.Add(false);
                holdExtra = false;
            }
        }
        
    }
}
