using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Kalc
{
    class Program
    {
        static readonly List<double> dataCollector = new List<double>() ;
        static double result;
        static int? getNullData;
        static double firstNumber;
        static readonly List<char> signCollector = new List<char>();
        static char sign;
        static string name;
        public static void Main()
        {
            // Welcome to Kalc.
            Console.WriteLine("Hello, Welcome to Kalc");

            //Getting mode of operation. 
            string selectedOperation;
            bool selectionChecker;
            int mySelection;
            
            
            string firstNumberString;
            do
            {
                Console.Write("\nEnter a number> ");
                firstNumberString = Console.ReadLine();

            }
            while (DataChecker(firstNumberString, out firstNumber) == false);

            result = firstNumber;
            
            do {
                Console.WriteLine("Please Select an operation you want to use:");
                Console.WriteLine("\n1. Addition \n2. Subtraction \n3. Multiplication \n4. Division");

                do
                {

                    Console.Write("\nEnter in a number to select an operation> ");
                    selectedOperation = Console.ReadLine();
                    // Getting the correct input 
                    selectionChecker = int.TryParse(selectedOperation, out mySelection);
                    if ((!selectionChecker) || (mySelection > 4) || (mySelection < 0))
                    {
                        Console.WriteLine("Invalid Output! Please try again");
                    }

                } while ((selectionChecker == false) || (mySelection) > 4 || (mySelection < 0));

                // Assigning MySelection to its various methods.
                switch (mySelection)
                {
                    case 1: //ToDO Addition...
                        name = "addition";
                        sign = '+';
                        DoOperation(name, sign);
                        break;

                    case 2: //ToDO Subtration...
                        name = "subtraction";
                        sign = '-';
                        DoOperation(name, sign);
                        break;

                    case 3: //ToDO Multiplication...
                        name = "multiplication";
                        sign = '*';
                        DoOperation(name, sign);
                        break;

                    case 4: //ToDO Division...
                        name = "division";
                        sign = '/';
                        DoOperation(name, sign);
                        break;
                }

            } while (getNullData != null);
            #region
            //The result.
            int i = 0;
            Console.Write("\nDone! --> {0} ", firstNumber, sign);
            foreach (double storedData in dataCollector)
            {
                while (i < signCollector.Count)
                {
                    Console.Write($" {signCollector[i]} {storedData}");
                    i++;
                    break;
                }
            }
            Console.Write(" = " + result);
            #endregion
            Console.ReadKey();
        }
        
        private static double GetData()
        {
            string myData;
            bool myDataChecker;
            double output;
            //The myData must be an integer not a string.
            do
            {
                Console.Write("\nPlease enter number to  execute" +
                        " the {1} operation or leave empty to exit (Ans: {0})> ", result, name);
                myData = Console.ReadLine();

                //Transfer null data here
                if (myData == "")
                {
                    getNullData = null;
                    output = 0;
                    break;
                }
                myDataChecker = DataChecker(myData, out output);
            } while (myDataChecker == false);
            return output;
        }  

        //Checking data to make it useful.
        static bool DataChecker(string getData, out double MyDataStringToDouble)
        {
            bool myDataChecker = double.TryParse(getData, out double myDataStringToDouble);

            if (myDataChecker == false)
            {
                
                Console.WriteLine("Please enter a valid number");
                MyDataStringToDouble = 0;
                return false;
            }
            else
            {
                getNullData = (int)(double.Parse(getData));
                MyDataStringToDouble = myDataStringToDouble;
                return true;
            } 
        }

        private static void DoOperation(string name, char sign)
        {
            #region
            
            switch (sign)
            {
                #region
                //To do addition continues here.
                case '+':
                    double data = GetData();
                    dataCollector.Add(data);
                    signCollector.Add(sign);
                    //Removing the last element.
                    if (getNullData == null)
                    {
                        dataCollector.RemoveAt(dataCollector.Count - 1);
                        break;
                    }
                    result += data;  
                    break;
                #endregion

                #region
                //TO DO subtraction.
                case '-':
                    data = GetData();
                    dataCollector.Add(data);
                    signCollector.Add(sign);
                    //Removing the last element.
                    if (getNullData == null)
                    {

                        dataCollector.RemoveAt(dataCollector.Count - 1);
                        break;
                    }
                    result -= data;
                    break;
                #endregion

                #region
                //To Do Multiplication.
                case '*':
                    data = GetData();
                    dataCollector.Add(data);
                    signCollector.Add(sign);
                    //Removing the last element.
                    if (getNullData == null)
                    {
                        dataCollector.RemoveAt(dataCollector.Count - 1);
                        break;
                    }
                    result *= data;
                    break;
                #endregion

                #region
                //To Do Division.
                case '/':
                    data = GetData();
                    dataCollector.Add(data);
                    signCollector.Add(sign);
                    //Removing the last element.
                    if (getNullData == null)
                    {
                        dataCollector.RemoveAt(dataCollector.Count - 1);
                        break;
                    }
                    result /= data;
                    break;
                    #endregion
            }
            #endregion
            // The result.
            
        }
    }
}
