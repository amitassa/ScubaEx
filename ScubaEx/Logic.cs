using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Reflection;
using System.Text;
using System.Threading.Tasks;

namespace Logic
{
    public class Logic
    {
        public int Logic1(int[] numbers)
        {
            int result = numbers[0];
            for (int i = 1; i < numbers.Length; i++)
            {
                result += i;
            }
            return result;
        }

        public void Logic2(string inputFileName, string outputFileName)
        {
            StreamReader sr = new StreamReader(inputFileName);
            string input = sr.ReadToEnd();
            sr.Close();

            StreamWriter sw = new StreamWriter(outputFileName);
            sw.Write(inputFileName);
            sw.Close();
        }

        public int Logic3(string data)
        {
            return Int32.Parse(data);
        }

        public void Logic4(string data1, int data2, long data3)
        {
            throw new NotImplementedException("This method is not implemeted");
        }

        public void Logic5(string dllName)
        {
            Assembly.LoadFrom(dllName);
        }

    }
}

