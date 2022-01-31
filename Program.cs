using System;

namespace Kalkulačka
{
    class Program
    {
        public static string num01;
        public static string num02;
        public static string operation;
        public static float result;

        public static float inum01;
        public static float inum02;

        static void Main(string[] args)
        {   

            Console.Title = "Calculator";
           //Runs function for getting numbers
            SelcetNumbersAndOperation();

            //Check if numbers and operation are valid
            if(CheckNumber(num01)) inum01 = ConverToInt(num01);
            else{
                Console.ForegroundColor = ConsoleColor.Red;
                Console.WriteLine("Not a valid number!");
                Console.ForegroundColor = ConsoleColor.Gray;

                Console.WriteLine("Press any key to exit");
                Console.ReadKey();
                return;
            }
            //Check if numbers and operation are valid
            if(CheckNumber(num02)) inum02 = ConverToInt(num02);
            else if(CheckNumber(num02)==false) {
                Console.ForegroundColor = ConsoleColor.Red;
                Console.WriteLine("Not a valid number!");
                Console.ForegroundColor = ConsoleColor.Gray;

                Console.WriteLine("Press any key to exit");
                Console.ReadKey();
                return;
            }
            //Check if numbers and operation are valid
            if (CheckOperation(operation)) operation = operation;
            else if(!CheckOperation(operation))
            {
                Console.ForegroundColor = ConsoleColor.Red;
                Console.WriteLine("Not a valid operation");
                Console.ForegroundColor = ConsoleColor.Gray;

                Console.WriteLine("Press any key to exit");
                Console.ReadKey();
                return;
            }

            //Calculate
            //Calculate and store the result
            Calcualte();
            //Print the result
            PrintResult();

            //Loop
            Loop();

            //Stops before exit
            Console.Clear();
            Console.ForegroundColor = ConsoleColor.Gray;
            Console.WriteLine("Press any key to exit");
            Console.ReadKey();
        }

        //Loop
        static void Loop()
        {
            Console.Title = "Calculator";
            Console.Clear();
            //sets vars
            bool loop = true;
            string continu;

            //Ask if user wants to continue
            Console.ForegroundColor = ConsoleColor.Red;
            Console.WriteLine("Do you want to continue(y/n): ");
            continu = Convert.ToString(Console.ReadLine());
            if (continu=="y") loop=true;
            else if (continu=="n") return;
            else {Loop(); return;}
        
            for (int i = 0;loop == true;)
            {
                Console.Title = "Calculator";
                Console.Clear();

                //Runs function for getting numbers
                SelcetNumbersAndOperation();

                //Check if numbers and operation are valid
                if(CheckNumber(num01)) inum01 = ConverToInt(num01);
                else{
                    Console.ForegroundColor = ConsoleColor.Red;
                    Console.WriteLine("Not a valid number!");
                    Console.ForegroundColor = ConsoleColor.Gray;

                    Console.WriteLine("Press any key to return");
                    Console.ReadKey();
                    return;
                }
                if(CheckNumber(num02)) inum02 = ConverToInt(num02);
                else if(CheckNumber(num02)==false) {
                    Console.ForegroundColor = ConsoleColor.Red;
                    Console.WriteLine("Not a valid number!");
                    Console.ForegroundColor = ConsoleColor.Gray;

                    Console.WriteLine("Press any key to return");
                    Console.ReadKey();
                    return;
                }
                if (CheckOperation(operation)) operation = operation;
                else if(!CheckOperation(operation))
                {
                    Console.ForegroundColor = ConsoleColor.Red;
                    Console.WriteLine("Not a valid operation");
                    Console.ForegroundColor = ConsoleColor.Gray;

                    Console.WriteLine("Press any key to return");
                    Console.ReadKey();
                    return;
                }

                    //Calculate
                    //Calculate and store the result
                    Calcualte();
                    //Print the result
                    PrintResult();

                    Console.Clear();
                    //Ask if user wants to continue
                    Console.ForegroundColor = ConsoleColor.Red;
                    Console.WriteLine("Do you want to continue(y/n): ");
                    continu = Convert.ToString(Console.ReadLine());
                    if (continu=="y") loop=true;
                    else if (continu=="n") return;
                    else {Loop(); return;}
                }
            }

        //Calculate
        static void Calcualte(){
            //+
            if (operation=="+")
            {
                result = inum01 + inum02;
            }
            //-
            if (operation=="-")
            {
                result = inum01 - inum02;
            }
            //×
            if (operation=="*")
            {
                result = inum01 * inum02;
            }
            //÷
            if (operation=="/")
            {
                result = inum01 / inum02;
            }
        }

        //Print the result
        static void PrintResult(){
            //Make the user wait
            Console.ForegroundColor = ConsoleColor.Gray;
            Console.WriteLine("Calculating.");
            Console.Title = "Calculating.";
            System.Threading.Thread.Sleep(1000);
            Console.Clear();
            Console.WriteLine("Calculating..");
            Console.Title = "Calculating..";
            System.Threading.Thread.Sleep(1000);
            Console.Clear();
            Console.WriteLine("Calculating...");
            Console.Title = "Calculating...";
            System.Threading.Thread.Sleep(1000);
            Console.Clear();
            Console.WriteLine("Calculating.");
            Console.Title = "Calculating.";
            System.Threading.Thread.Sleep(1000);
            Console.Clear();
            Console.WriteLine("Calculating..");
            Console.Title = "Calculating..";
            System.Threading.Thread.Sleep(1000);
            Console.Clear();
            Console.WriteLine("Calculating...");
            Console.Title = "Calculating...";
            System.Threading.Thread.Sleep(1000);

            Console.Title = "Result";
            //Print the result out
            Console.Clear();
            Console.ForegroundColor = ConsoleColor.DarkRed;
            Console.WriteLine("The result is: " + result);
            Console.ReadKey();
        }

        //Get numbers and operations
        static void SelcetNumbersAndOperation(){
            //Sets color to red
            Console.ForegroundColor = ConsoleColor.Red;

            //Set console title
            Console.Title = "Please select number";

            //Get user's number 
            Console.Write("Please select first number:");
            num01 = Convert.ToString(Console.ReadLine());
            Console.Write("Please select second number:");
            num02 = Convert.ToString(Console.ReadLine());

            //Set console title
            Console.Title = "Please select operation";

            //Gets users operation
            Console.ForegroundColor = ConsoleColor.Green;
            Console.Write("Please select operation(+, -, *, /): ");
            operation = Convert.ToString(Console.ReadLine());
            Console.Clear();
            Console.Title = "Calculator";
            }

            
        static bool CheckOperation(string operation){
            if (operation=="")
            {
                return false;
            }
            //Checks if operations are valid else return false
            if (operation=="+") return true;
            if (operation=="-") return true;
            if (operation=="*") return true;
            if (operation=="/") return true;
            else return false;
        }    
        static bool CheckNumber(string num){
            //If number equals null automatic return false
            if (num=="")
            {
                return false;
            }
            //Gets all vars
            int numlenght = num.Length;
            string lastNum;
            bool isNumber = true;
            for (int i = 0; i < numlenght; i++)
            {
                //Get last char from num
                lastNum = num.Substring(num.Length - 1);

                //Checks if that char is number
                if (lastNum == "0")isNumber=true;
                else if (lastNum == "1")isNumber=true;
                else if (lastNum == "2")isNumber=true;
                else if (lastNum == "3")isNumber=true;
                else if (lastNum == "4")isNumber=true;
                else if (lastNum == "5")isNumber=true;
                else if (lastNum == "6")isNumber=true;
                else if (lastNum == "7")isNumber=true;
                else if (lastNum == "8")isNumber=true;
                else if (lastNum == "9")isNumber=true;
                else if (lastNum == ",")isNumber=true;
                else isNumber = false;

                //remove last char from num
                num = num.Remove(num.Length -1);

                //When it detects that its not number it break the loop
                if (isNumber==false)
                {
                    break;
                }
            }
            //If its number return true
            if (isNumber==true)
            {
                return true;
            }
            else
            {
                return false;
            }
        }
        static float ConverToInt(string convert){
            //Converts the number to float
            return float.Parse(convert, System.Globalization.NumberStyles.AllowDecimalPoint);
        }
    }
}
