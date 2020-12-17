using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Kalc
{
    class Program
    {
        static List<double> dataCollector = new List<double> () ;
        static int? iSMyDataNull;

        public static void Main(string[] args)
        {
            // Welcome to Kalc.
            Console.WriteLine("Hello, Welcome to Kalc");

            //Getting mode of operation. 
            string selectedOperation;
            bool selectionChecker;
            int mySelection;
            do
            {
                Console.WriteLine("Please Select an operation:");
                Console.WriteLine(" 1. Addition \n 2. Subtraction \n 3. Multiplication \n 4. Division");
                selectedOperation = Console.ReadLine();
                // Getting the correct input 
                selectionChecker = int.TryParse(selectedOperation, out mySelection);
                if (!selectionChecker) Console.WriteLine("Invalid input! Please put the correct input") ;
                if (mySelection > 4 || mySelection < 0) Console.WriteLine("Input is out of range");
                
            } while ((selectionChecker == false) || (mySelection) > 4 || (mySelection < 0));

            // Assigning MySelection to its various methods.
            switch (mySelection)
            {
                case 1: //ToDO Addition...
                    Adding();
                    break;

                case 2: //ToDO Subtration...
                    Subtracting();
                    break;

                case 3: //ToDO Multiplication...
                    Mutiplying();
                    break;

                case 4: //ToDO Division...
                    Dividing();
                    break;
            }


            Console.ReadKey();
        }

        private static double GetData()
        {
            string myData;
            bool myDataChecker;
            double myDataStringToDouble ;
                //The myData must be an integer not a string.
            do
            {
                Console.WriteLine("\n Enter the next number" +
                        "to continue operation or\n press enter to exit");
                myData = Console.ReadLine();
                



                myDataChecker = double.TryParse(myData, out myDataStringToDouble);

                if (myData == "")
                {
                    iSMyDataNull = null;
                    myDataStringToDouble = 0;
                    break;
                }
                
                if (myDataChecker == false)
                {
                    Console.WriteLine("Please enter a valid number");
                }    
                else
                {
                   iSMyDataNull = (int)double.Parse(myData);
                    Console.WriteLine("Data entered!");
                        
                    break;
                }
            } while (myDataChecker == false);
            return myDataStringToDouble;
        }

        private static double GetData1()
        {
            string myData;
            bool myDataChecker;
            double myDataStringToDouble;
            //myData must be an integer not a string.
            do
            {
                Console.WriteLine("\n Enter the next number" +
                        "to continue operation or\n press enter to exit");
                myData = Console.ReadLine();


                myDataChecker = double.TryParse(myData, out myDataStringToDouble);

                if (myData == "")
                {
                    iSMyDataNull = null;
                    myDataStringToDouble = 1;
                    break;
                }

                if (myDataChecker == false)
                {
                    Console.WriteLine("Please enter a valid number");
                }
                else
                {
                    iSMyDataNull = (int)(double.Parse(myData));
                    Console.WriteLine("Data entered!");

                    break;
                }
            } while (myDataChecker == false);
            return myDataStringToDouble;
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
                iSMyDataNull = (int)(double.Parse(getData));
                Console.WriteLine("Data entered!");
                MyDataStringToDouble = myDataStringToDouble;
                return true;
            } 
        }

        //TO DO adding here...
        private static void Adding()
        {
            Console.Clear();
            #region
            Console.WriteLine("Enter a number to start the addition operation");
            string FirstNumber = Console.ReadLine();
            double firstNumber;
            while(DataChecker(FirstNumber,out firstNumber) == false)
            {
                Console.WriteLine("Enter a number to start the addition operation");
                FirstNumber = Console.ReadLine();
                DataChecker(FirstNumber, out firstNumber);
            }
            
            Console.WriteLine("Enter another number");
            string SecondNumber = Console.ReadLine();
            double secondNumber;
            while (DataChecker(SecondNumber, out secondNumber) == false)
            {
                Console.WriteLine("Enter a number to start the addition operation");
                SecondNumber = Console.ReadLine();
                DataChecker(SecondNumber, out secondNumber);
            }
            double SumResult = firstNumber + secondNumber;
            
            
            //Collecting data as long as there is data.
            do
            {
                   
                Console.Write("  The current sum is {0}", SumResult);
                 
                double data = GetData();
                SumResult += data;
                dataCollector.Add(data);
                //Removing the last element.
                if (iSMyDataNull == null)
                {
                    dataCollector.RemoveAt(dataCollector.Count - 1);
                }
            } while (iSMyDataNull != null);

            // The result.
            Console.Write(firstNumber + " + " + secondNumber);
            foreach(double storedData in dataCollector)
            {
                Console.Write($" + {storedData}");
            }
            Console.WriteLine("\nThe result is {0}", SumResult);
            #endregion
        }

        //TO DO subtraction...
        private static void Subtracting()
        {
            Console.Clear();
            #region
            Console.Clear();
            Console.WriteLine("Enter a number to start the subtraction operation");
            string FirstNumber = Console.ReadLine();
            double firstNumber;
            while (DataChecker(FirstNumber, out firstNumber) == false)
            {
                Console.WriteLine("Enter a number to start the subtraction operation");
                FirstNumber = Console.ReadLine();
                DataChecker(FirstNumber, out firstNumber);
            }

            Console.WriteLine("Enter another number");
            string SecondNumber = Console.ReadLine();
            double secondNumber;
            while (DataChecker(SecondNumber, out secondNumber) == false)
            {
                Console.WriteLine("Enter another number");
                SecondNumber = Console.ReadLine();
                DataChecker(SecondNumber, out secondNumber);
            }
            double SubResult = firstNumber - secondNumber;
            //Collecting data as long as there is data.
            do
            {
                Console.Write("  The current result is {0}", SubResult);
                double data = GetData();
                SubResult -= data;
                dataCollector.Add(data);
                //Removing the last element.
                if (iSMyDataNull == null)
                {
                    dataCollector.RemoveAt(dataCollector.Count - 1);
                }
            } while (iSMyDataNull != null);
            // The result.
            Console.Write(firstNumber + " - " + secondNumber);
            foreach (double storedData in dataCollector)
            {
                Console.Write($" - {storedData}");
            }
            Console.WriteLine("\nThe result is {0}", SubResult);
            #endregion
        }

        //To Do Multiplication...
        private static void Mutiplying()
        {
            Console.Clear();
            
            #region
            Console.Clear();
            Console.WriteLine("Enter a number to start the multiplication operation");
            string FirstNumber = Console.ReadLine();
            double firstNumber;
            while (DataChecker(FirstNumber, out firstNumber) == false)
            {
                Console.WriteLine("Enter a number to start the multiplication operation");
                FirstNumber = Console.ReadLine();
                DataChecker(FirstNumber, out firstNumber);
            }

            Console.WriteLine("Enter another number");
            string SecondNumber = Console.ReadLine();
            double secondNumber;
            while (DataChecker(SecondNumber, out secondNumber) == false)
            {
                Console.WriteLine("Enter another number");
                SecondNumber = Console.ReadLine();
                DataChecker(SecondNumber, out secondNumber);
            }
            double TimesResult = firstNumber * secondNumber;
            //Collecting data as long as there is data.
            do
            {
                Console.Write("  The current result is {0}", TimesResult);
                double data = GetData1();
                TimesResult *= data;
                dataCollector.Add(data);
                //Removing the last element.
                if (iSMyDataNull == null)
                {
                    dataCollector.RemoveAt(dataCollector.Count - 1);
                }
            } while (iSMyDataNull != null);
            // The result.
            Console.Write(firstNumber + " * " + secondNumber);
            foreach (double storedData in dataCollector)
            {
                Console.Write($" * {storedData}");
            }
            Console.WriteLine("\nThe result is {0}", TimesResult);
            #endregion
        }

        //To Do Division...
        private static void Dividing()
        {
            Console.Clear();
            #region
            Console.Clear();
            Console.WriteLine("Enter a number to start the dividing operation");
            string FirstNumber = Console.ReadLine();
            double firstNumber;
            while (DataChecker(FirstNumber, out firstNumber) == false)
            {
                Console.WriteLine("Enter a number to start the addition operation");
                FirstNumber = Console.ReadLine();
                DataChecker(FirstNumber, out firstNumber);
            }

            Console.WriteLine("Enter another number");
            string SecondNumber = Console.ReadLine();
            double secondNumber;
            while (DataChecker(SecondNumber, out secondNumber) == false)
            {
                Console.WriteLine("Enter a number to start the dividion operation");
                SecondNumber = Console.ReadLine();
                DataChecker(SecondNumber, out secondNumber);
            }
            double Quotient = firstNumber / secondNumber;
            //Collecting data as long as there is data
            do
            {
                Console.Write("  The current result is {0}", Quotient);
                double data = GetData1();
                Quotient /= data;
                dataCollector.Add(data);
                //Removing the last element.
                if (iSMyDataNull == null)
                {
                    dataCollector.RemoveAt(index:dataCollector.Count - 1);
                }
            } while (iSMyDataNull != null);
            // The result.
            Console.Write(firstNumber + " / " + secondNumber);
            foreach (double storedData in dataCollector)
            {
                Console.Write($" / {storedData}");
            }
            Console.WriteLine("\nThe result is {0}", Quotient);
            #endregion
        }
    }
}
