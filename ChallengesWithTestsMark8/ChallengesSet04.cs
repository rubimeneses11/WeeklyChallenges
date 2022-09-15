using System;
using System.Collections.Generic;
using System.Linq;

namespace ChallengesWithTestsMark8
{
    public class ChallengesSet04
    {
        //return an int
        //passing in an int array
        //if number is even, get the sum
        //if number is odd, subtract
        //DONE!!
        public int AddEvenSubtractOdd(int[] numbers)
        {
            int answer = 0;
            for (int i = 0; i < numbers.Length; i++)
            {
                if (numbers[i] % 2 == 0)
                {
                    answer += numbers[i];
                }
                if (numbers[i] % 2 != 0)
                {
                    answer -= numbers[i];
                }
            }
            return answer;
        }

        //return an int
        //passing in 4 strings
        //create a new list and populate it with our 4 strings
        //we do this so we can use .length and have the size of each string that is passed thru
        //list.Min will return the smallest size in int form
        //DONE!!
        public int GetLengthOfShortestString(string str1, string str2, string str3, string str4)
        {
            var list = new List<string>() { str1, str2, str3, str4 };
            return list.Min(x => x.Length);

        }


        
        //DONE!!
        public int GetSmallestNumber(int number1, int number2, int number3, int number4) //return int & passing in 4 ints
        {
            if (number1 <= number2 && number1 <= number3 && number1 <= number4)
            {
                return number1;
            }
            if (number2 <= number1 && number2 <= number3 && number2 <= number4)
            {
                return number2;
            }
            if (number3 <= number1 && number3 <= number2 && number3 <= number4)
            {
                return number3;
            }
            if (number4 <= number1 && number4 <= number2 && number4 <= number3)
            {
                return number4;
            }
            return 0;
        }

        //DONE!!
        public void ChangeBusinessNameTo_TrueCoders(Business biz)
        {
            biz.Name = "TrueCoders"; //Business is a class-- to change a propery called Name use the instance biz
        }


        //DONE!!
        //according to test: side1 + side2 > side3 to be a triangle
        public bool CouldFormTriangle(int sideLength1, int sideLength2, int sideLength3) //returns a bool-- true or false & passes in 3 ints
        {
            if(sideLength1 + sideLength2 > sideLength3 && //since we have 3 lengths, we have to make sure whichever combination                                         
                sideLength1 + sideLength3 > sideLength2 &&//of the two are always greater than the lone side, check for every scenario
                sideLength2 + sideLength3 > sideLength1)
            {
                return true;
            }
            return false;
        }

        //return true or false
        //pass in a string
        //TryParse will return a bool depending on if it can pass thru input
        //DONE!!
        public bool IsStringANumber(string input)
        {
            bool isNumber = double.TryParse(input, out double number);
            return isNumber;
        }

        //return true or false
        //passing in an object array
        //how would you check for the majority of the elements???
        //TOTALLY LOST ON THIS ONE
        public bool MajorityOfElementsInArrayAreNull(object[] objs)
        {
            var majority = (objs.Length / 2) + 1; //gives majority

            var count = 0;

            foreach (var item in objs)
            {
                if(item == null)
                {
                    count++; //counts null items
                }
            }
            return (count >= majority); //the condition will be true or false so no 'if-statement' required
        }


        //DONE!!
        public double AverageEvens(int[] numbers) //return a double & pass in an array of type int
        {
            if (numbers == null || numbers.Length == 0) //if the collection is null or empty
            {
                return 0;
            }
            var n = numbers.Where(x => x % 2 == 0); //for every even number in the collection

            if(n.Count() == 0) //if there are no numbers in the sequence
            {
                return 0;
            }
            return n.Average(); //give the average of the even numbers
        }

        //a factorial is the product of an integer and all integers below it
        //WORKING BUT DONT UNDERSTAND IT
        public int Factorial(int number)
        {
            var fact = 1;

            if(number < 0)
            {
                throw new ArgumentOutOfRangeException();
            }

            for (int i = number; i > 0; i--) //starting at whatever number (ie 5, go down by one as long as it is greater than 0)
            {
                fact *= i; //multiply that number by 1
            }
            return fact;
        }
    }
}
