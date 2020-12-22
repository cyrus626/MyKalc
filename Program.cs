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
        public static void Main(string[] args)
        {
            // Welcome to Kalc.
            Console.WriteLine("Hello, Welcome to Kalc");

            //Getting mode of operation. 
            string selectedOperation;
            bool selectionChecker;
            int mySelection;
            string name;
            //the default operation is +
            char sign = '+';
            Console.WriteLine("Please Select an option:");
            Console.WriteLine("1. Addition \n2. Subtraction \n3. Multiplication \n4. Division");

            do
            {
                
                Console.Write("\nEnter in a number to select an option> ");
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
                Console.Write("\nPlease enter another number" +
                        "to continue operation or leave empty to exit (Ans: {0})> ", result);
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
            double myDataStringToDouble;
            bool myDataChecker = double.TryParse(getData, out myDataStringToDouble);

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
            string firstNumberString;
            double firstNumber;
            do
            {
                Console.Write("\nEnter a number to start the {0}> ", name);
                firstNumberString = Console.ReadLine();
                
            }
            while (DataChecker(firstNumberString, out firstNumber) == false);
            string secondNumberString;
            double secondNumber;
            do
            {
                Console.Write("Please enter another number> ");
                secondNumberString = Console.ReadLine();
            }
            while (DataChecker(secondNumberString, out secondNumber) == false);
            switch (sign)
            {
                #region
                //To do addition continues here.
                case '+':
                    result = firstNumber + secondNumber;
                    //Collecting data as long as there is data.
                    do
                    {
                        double data = GetData();
                        dataCollector.Add(data);
                        //Removing the last element.
                        if (getNullData == null)
                        {
                            dataCollector.RemoveAt(dataCollector.Count - 1);
                        }
                        result += data; 
                    }
                    while (getNullData != null);
                    // The result.
                    Console.Write("\nDone! --> " + firstNumber + " + " + secondNumber);
                    foreach (double storedData in dataCollector)
                    {
                        Console.Write($" + {storedData}");
                    }
                    Console.Write(" = " + result);
                    break;
                #endregion

                #region
                //TO DO subtraction.
                case '-':
                    result = firstNumber - secondNumber;
                    //Collecting data as long as there is data.
                    do
                    {
                        double data = GetData();
                        dataCollector.Add(data);
                        //Removing the last element.
                        if (getNullData == null)
                        {
                            dataCollector.RemoveAt(dataCollector.Count - 1);
                            break;
                        }
                        result -= data;
                    }
                    while (getNullData != null);
                    // The result.
                    Console.Write("\nDone! --> " + firstNumber + " - " + secondNumber);
                    foreach (double storedData in dataCollector)
                    {
                        Console.Write($" - {storedData}");
                    }
                    Console.Write(" = " + result);
                    break;
                #endregion

                #region
                //To Do Multiplication.
                case '*':
                    result = firstNumber * secondNumber;
                    //Collecting data as long as there is data.
                    do
                    {
                        double data = GetData();
                        dataCollector.Add(data);
                        //Removing the last element.
                        if (getNullData == null)
                        {
                            dataCollector.RemoveAt(dataCollector.Count - 1);
                            break;
                        }
                        result *= data;
                    }
                    while (getNullData != null);
                    // The result.
                    Console.Write("\nDone! --> " + firstNumber + " * " + secondNumber);
                    foreach (double storedData in dataCollector)
                    {
                        Console.Write($" * {storedData}");
                    }
                    Console.Write(" = " + result);
                    break;
                #endregion

                #region
                //To Do Division.
                case '/':
                    result = firstNumber / secondNumber;
                    //Collecting data as long as there is data.
                    do
                    {
                        double data = GetData();
                        dataCollector.Add(data);
                        //Removing the last element.
                        if (getNullData == null)
                        {
                            dataCollector.RemoveAt(dataCollector.Count - 1);
                            break;
                        }
                        result /= data;
                    }
                    while (getNullData != null);
                    // The result.
                    Console.Write("\nDone! --> " + firstNumber + " / " + secondNumber);
                    foreach (double storedData in dataCollector)
                    {
                        Console.Write($" / {storedData}");
                    }
                    Console.Write(" = " + result);
                    break;
                    #endregion
            }
            #endregion
        }
    }
}
