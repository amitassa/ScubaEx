using System;
using System.Collections.Generic;
using System.IO;
using System.Text;

namespace ScubaEx
{
    public  class RunLogics
    {

        private int studentNumber;
        private Logic.Logic Logics = new Logic.Logic();

        public RunLogics()
        {
            Console.WriteLine("Please enter your student number");
            studentNumber = IntParser();
        }
     
        public void RunLogic1()
        {
            int arrayLength = 0; //default value for array length
            Console.WriteLine("Please enter array`s size");
            try
            {
                arrayLength = IntParser();
            }
            catch (ScubaException ex)
            {
                Console.WriteLine($"Sorry, student {ex.studentNumber}, You got a ScubaException: {ex.Message}");
            }

            int[] numbersArray = new int[arrayLength];
            Console.WriteLine("Please enter the numbers");
            for (int i = 0; i < arrayLength; i++)
            {
                try
                {
                    numbersArray[i] = IntParser();
                }
                catch (ScubaException ex)
                {
                    Console.WriteLine($"Sorry, student {ex.studentNumber}, You got a ScubaException: {ex.Message}");
                }
            }

            Console.WriteLine("Logic1 function result: " + Logics.Logic1(numbersArray));
        }

        public void RunLogic2()
        {
            string inputFileName = "";
            string outputFileName = "";
            try
            {
                inputFileName = StringParser();
                outputFileName = StringParser();
            }
        }

        public int IntParser()
        {
            int number;
            while (!int.TryParse(Console.ReadLine(), out number))
            {
                throw new ScubaException(String.Format($"The number needs to be an integer. Instead got the value: {number}"), studentNumber);
            }
            return number;
        }

        public string StringParser()
        {
            {
               string str;
               while (string.IsNullOrWhiteSpace(str = Console.ReadLine()))
                {
                    throw new ScubaException(String.Format($"The name needs to be a string. Instead got the value: {str}"), studentNumber);
                }
                return str;
            }
        }
     
    }
}
