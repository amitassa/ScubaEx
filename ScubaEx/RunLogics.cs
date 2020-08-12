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
                Console.WriteLine("Enter 'string' type for input file name");
                inputFileName = StringParser();
                Console.WriteLine("Enter 'string' type for output file name");
                outputFileName = StringParser();
                Logics.Logic2(inputFileName, outputFileName);
            }
            catch (ScubaException ex)
            {
                Console.WriteLine($"Sorry, student {ex.studentNumber}, You got a ScubaException: {ex.Message}");
            }
            catch (IOException e)
            {
                Console.WriteLine(e.Message.ToString());
            }

        }

        public void RunLogic3()
        {
            string dataToParse = "";
            while (String.IsNullOrWhiteSpace(dataToParse)) // cannot get ArgumentNullException if string is not empty
            {
                try
                {
                    Console.WriteLine("Enter 'string' type data");
                    dataToParse = StringParser();
                }
                catch (ScubaException ex)
                {
                    Console.WriteLine($"Sorry, student {ex.studentNumber}, You got a ScubaException: {ex.Message}");
                }
            }
            try
            {
                Logics.Logic3(dataToParse);
            }
            catch (ArgumentException ex)
            {
                Console.WriteLine(ex.Message.ToString());
            }
            catch (FormatException ex)
            {
                Console.WriteLine(ex.Message.ToString());
            }
            catch (OverflowException ex)
            {
                Console.WriteLine(ex.Message.ToString());
            }

        }

        public void RunLogic4()
        {
            int logic4Number;
            string logic4String;
            long logic4Long;

            try
            {
                Console.WriteLine("Enter 'long' type number");
                logic4Long = LongParser();
                Console.WriteLine("Enter 'int' type number");
                logic4Number = IntParser();
                Console.WriteLine("Enter 'string' type message");
                logic4String = StringParser();
                Logics.Logic4(logic4String, logic4Number, logic4Long);
            }
            catch (ScubaException ex)
            {
                Console.WriteLine($"Sorry, student {ex.studentNumber}, You got a ScubaException: {ex.Message}");
            }
            catch (NotImplementedException ex)
            {
                Console.WriteLine(ex.Message.ToString()); 
            }
        }

        public void RunLogic5()
        {
            string dllfile;
            try
            {
                Console.WriteLine("Enter 'string' type dll file name");
                dllfile = StringParser();
                Logics.Logic5(dllfile);
            }
            catch (FileNotFoundException e)
            {
                Console.WriteLine("Assembly file not found" + e.Message.ToString());
                throw;
            }
            catch (FileLoadException e)
            {
                Console.WriteLine("Couldnt Load the file" + e.Message.ToString());
                throw;
            }
        }

        public int IntParser()
        {
            int number;
            if (!int.TryParse(Console.ReadLine(), out number))
            {
                throw new ScubaException(String.Format($"The number needs to be an integer. Instead got the value: {number}"), studentNumber);
            }
            return number;
        }

        public string StringParser()
        
        {
            string str;
            if (!string.IsNullOrWhiteSpace(str = Console.ReadLine()))
            {
                throw new ScubaException(String.Format($"The name needs to be a string. Instead got the value: {str}"), studentNumber);
            }
            return str;
        }
        

        public long LongParser()
        
        {
            long longNumber;
            if (!long.TryParse(Console.ReadLine(), out longNumber))
            {
                throw new ScubaException(String.Format($"The number needs to be a long type. Instead got the value: {longNumber}"), studentNumber);
            }
            return longNumber;
        }

    }
}
