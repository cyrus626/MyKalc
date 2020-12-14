using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Kalc
{
    class Program
    {
        static double[] dataCollector = new double[] { };
        static int? ISMyDataNull;

        public static void Main(string[] args)
        {
            // Welcome to Kalc
            Console.WriteLine("Hello, Welcome to Kalc");

            //Getting mode of operation 
            String SelectedOperation;
            bool SelectionChecker;
            int MySelection;
            do
            {
                Console.WriteLine("Please Select an operation:");
                Console.WriteLine(" 1. Addition \n 2. Subtraction \n 3. Multiplication \n 4. Division");
                SelectedOperation = Console.ReadLine();
                
                SelectionChecker = int.TryParse(SelectedOperation, out MySelection);
                if (!SelectionChecker) Console.WriteLine("Invalid input! Please put the correct input") ;
                if (MySelection > 4 || MySelection < 0) Console.WriteLine("Input is out of range");
                
            } while (SelectionChecker == false || MySelection > 4 || MySelection < 0);

            // Assigning MySelection to its various methods
            switch (MySelection)
            {
                case 1: //ToDO Addition
                    
                    Adding();
                    break;

                case 2: //ToDO Subtration
                    Subtracting();
                    break;

                case 3: //ToDO Multiplication
                    Mutiplying();
                    break;

                case 4: //ToDO Division
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
                //myData must be an integer not a string
            do
            {
                Console.WriteLine("\n Enter the next number" +
                        "to continue operation or\n press enter to exit");
                myData = Console.ReadLine();
                



                myDataChecker = double.TryParse(myData, out myDataStringToDouble);

                if (myData == "")
                {
                    ISMyDataNull = null;
                    myDataStringToDouble = 0;
                    break;
                }
                
                if (myDataChecker == false)
                {
                    Console.WriteLine("Please enter a valid number");
                }    
                else
                {
                   ISMyDataNull = (int)double.Parse(myData);
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
            //myData must be an integer not a string
            do
            {
                Console.WriteLine("\n Enter the next number" +
                        "to continue operation or\n press enter to exit");
                myData = Console.ReadLine();




                myDataChecker = double.TryParse(myData, out myDataStringToDouble);

                if (myData == "")
                {
                    ISMyDataNull = null;
                    myDataStringToDouble = 1;
                    break;
                }

                if (myDataChecker == false)
                {
                    Console.WriteLine("Please enter a valid number");
                }
                else
                {
                    ISMyDataNull = (int)(double.Parse(myData));
                    Console.WriteLine("Data entered!");

                    break;
                }
            } while (myDataChecker == false);
            return myDataStringToDouble;
        }
        //Checking data to make it useful
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
                ISMyDataNull = (int)(double.Parse(getData));
                Console.WriteLine("Data entered!");
                MyDataStringToDouble = myDataStringToDouble;
                return true;
            } 
        }

        //TODO adding here
        private static void Adding()
        {
            Console.Clear();
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
            int i = 0;
            
            //Collecting data as long as there is data
            do
            {
                Console.Write("  The current sum is {0}", SumResult);
                double data = GetData();
                SumResult += data;
               // dataCollector[i] = data;
                i++; 
            } while (ISMyDataNull != null);
            Console.WriteLine("The result is {0}", SumResult);
        }

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
            int i = 0;

            //Collecting data as long as there is data
            do
            {
                Console.Write("  The current result is {0}", SubResult);
                double data = GetData();
                SubResult -= data;
                // dataCollector[i] = data;
                i++;
            } while (ISMyDataNull != null);
            Console.WriteLine("The result is {0}", SubResult);
            #endregion
        }

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
            //int i = 0;

            //Collecting data as long as there is data
            do
            {
                Console.Write("  The current result is {0}", TimesResult);
                double data = GetData1();
                TimesResult *= data;
                // dataCollector[i] = data;
               // i++;
            } while (ISMyDataNull != null);
            Console.WriteLine("The result is {0}", TimesResult);
            #endregion
        }

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
            int i = 0;

            //Collecting data as long as there is data
            do
            {
                Console.Write("  The current result is {0}", Quotient);
                double data = GetData1();
                Quotient /= data;
                // dataCollector[i] = data;
                i++;
            } while (ISMyDataNull != null);
            Console.WriteLine("The result is {0}", Quotient);
            #endregion
        }
    }
}
