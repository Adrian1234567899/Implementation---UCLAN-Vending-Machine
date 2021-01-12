using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Adrian_s_Vending_Machines
{
    class Program
    {
        static void DrawRightAlignedText(string text)
        {
            // There are 80 characters on a line. Subtracting the number of
            // characters in the text. The remainder must be spaces at the left
            int leftSpaces = 80 - text.Length;
            for (int i = 0; i < leftSpaces; i++)
            {
                Console.Write(" ");
            }
            Console.Write(text);
        }
        static void DrawCentreAlignedText(string text)
        {
            // There are 80 characters on a line. Subtracting the number of
            // characters in the text. The remainder must be spaces at the left
            int leftSpaces = 40 - text.Length;
            for (int i = 0; i < leftSpaces; i++)
            {
                Console.Write(" ");
            }
            Console.Write(text);
        }
        static void DrawText(string text)
        {
            // There are 80 characters on a line. Subtracting the number of
            // characters in the text. The remainder must be spaces at the left
            int leftSpaces = 80 - text.Length;
            for (int i = 0; i < leftSpaces; i++)
            {
                Console.Write(" ");
            }
            Console.Write(text);
        }
        static void DrawHorizontalLine(int lineWidth) // int is a parameter
        {

            for (int i = 0; i < lineWidth; i++)
            {
                Console.Write("*");
            }
            Console.WriteLine();
        }
        // Wait for user to press enter
        static void WaitForEnter()
        {
            Console.WriteLine();
            Console.Write("Press Enter to continue...");
            Console.ReadLine();
            Console.WriteLine();
        }

        static void Main(string[] args)
        {
            {
                DrawHorizontalLine(80);
                Console.WriteLine("*                                                                              *");
                DrawText("     *                    Uclan Vending Machines By Adrian Mazur                    *");
                Console.WriteLine();
                Console.WriteLine("*                                                                              *");
                DrawHorizontalLine(80);
                Console.WriteLine();
            }
            Console.WriteLine();
            WaitForEnter();    // call the method instead of writing it all out again

            {
                DrawHorizontalLine(80);     // draw the horizontal line
                Console.WriteLine("*                                                                              *");
                DrawText("     *                                Main Menu                                     *");
                Console.WriteLine();
                Console.WriteLine();
                DrawText("     *          1] Add credits                                                      *");
                Console.WriteLine();
                DrawText("     *          2] Display product/s                                                *");
                Console.WriteLine();
                DrawText("     *          3] Checkout                                                         *");
                Console.WriteLine();
                DrawText("     *          0] Exit                                                             *");
                Console.WriteLine();
                Console.WriteLine("*                                                                              *");
                DrawHorizontalLine(80);
                Console.WriteLine();
            }

            Console.Write("What option do you want to select? Select either 0, 1, 2 or 3");
            string mainMenuInput = Console.ReadLine();

            if (mainMenuInput == "1")
            {
                // Ask the end user to input credits
                Console.WriteLine("How many credits to add?");
                string inputString = Console.ReadLine();
                bool validCredits = false;
                double credits;

                // validate if credits entered are numbers
                do
                {
                    validCredits = double.TryParse(inputString, out credits);
                    WaitForEnter();
                } while (validCredits == false);

                // an attempt to display current credits to the end user

                if (validCredits == true)
                {
                    Console.WriteLine("You have {0:0.00} credits", credits);
                    Console.WriteLine("Your current balance is: {0:0.00} credits", inputString);
                    WaitForEnter();
                    Console.Clear();
                }

                {
                    DrawHorizontalLine(80);
                    Console.WriteLine("*                                                                              *");
                    DrawText("     *                                   Sub Menu                                   *");
                    Console.WriteLine();
                    Console.WriteLine();
                    DrawText("     *      1. Chocolate Bar      [0.80 credits]                                    *");
                    Console.WriteLine();
                    DrawText("     *      2. Soda Can           [0.60 credits]                                    *");
                    Console.WriteLine();
                    DrawText("     *      3. Soda Bottle        [1.25 credits]                                    *");
                    Console.WriteLine();
                    DrawText("     *      4. Crisps             [0.50 credits]                                    *");
                    Console.WriteLine();
                    DrawText("     *      5. Cookies            [1.15 credits]                                    *");
                    Console.WriteLine();
                    DrawText("     *      6. Checkout                                                             *");
                    Console.WriteLine();
                    DrawText("     *      0. Main Menu                                                            *");
                    Console.WriteLine();
                    Console.WriteLine("*                                                                              *");
                    DrawHorizontalLine(80);
                    {
                        WaitForEnter();
                    }
                }
                // static variable and update value to an order. use method to display reset credits to 0 //
                // Method upDATE CREDITS, SUBTRACT THEM AND DISPLAY //
            }
            else if (mainMenuInput == "2")
            {
                {
                    DrawHorizontalLine(80);
                    Console.WriteLine("*                                                                              *");
                    DrawText("     *                                   Sub Menu                                   *");
                    Console.WriteLine();
                    Console.WriteLine();
                    DrawText("     *      1. Chocolate Bar      [0.80 credits]                                    *");
                    Console.WriteLine();
                    DrawText("     *      2. Soda Can           [0.60 credits]                                    *");
                    Console.WriteLine();
                    DrawText("     *      3. Soda Bottle        [1.25 credits]                                    *");
                    Console.WriteLine();
                    DrawText("     *      4. Crisps             [0.50 credits]                                    *");
                    Console.WriteLine();
                    DrawText("     *      5. Cookies            [1.15 credits]                                    *");
                    Console.WriteLine();
                    DrawText("     *      0. Main Menu                                                            *");
                    Console.WriteLine();
                    Console.WriteLine("*                                                                              *");
                    DrawHorizontalLine(80);
                }
                {
                    WaitForEnter();
                }
            }
            else if (mainMenuInput == "3")
            {
                {
                    DrawHorizontalLine(80);
                    Console.WriteLine("*                                                                              *");
                    DrawText("     *                            Welcome to the checkout                           *");
                    Console.WriteLine();
                    Console.WriteLine("*                                                                              *");
                    DrawHorizontalLine(80);
                }
                WaitForEnter();
                return;
            }
            else if (mainMenuInput == "0")
            {
                {
                    DrawHorizontalLine(80);
                    Console.WriteLine("*                                                                              *");
                    Console.WriteLine("     *                   Thank you for using our service                   *");
                    Console.WriteLine();
                    Console.WriteLine("*                                                                              *");
                    DrawHorizontalLine(80);
                }
                WaitForEnter();
                return;
            }
            else  // if a number outside the range is entered, display this message
            {
                Console.WriteLine("Please try again");
            }
            WaitForEnter();

            int vendingChoice;
            double subTotal;
            string yesNo;
            double totalCost = 0;
            do
            {
                // below is the code to store prices for each of the available items
                // and to write them as decimals
                double item1Price = 0.80;
                double item2Price = 0.60;
                double item3Price = 1.25;
                double item4Price = 0.50;
                double item5Price = 1.15;

                // below is the code to store and show each item the user can choose

                string item1 = "Chocolate Bar";
                string item2 = "Soda Can";
                string item3 = "Soda Bottle";
                string item4 = "Crisps";
                string item5 = "Cookies";

                // Ask for the product choice and validate answer
                Console.Write("Please enter a number from 0 to 5 to choose your order: ");
                bool isNumber = int.TryParse(Console.ReadLine(), out vendingChoice);
                WaitForEnter();
                while (!isNumber)
                {
                    Console.Write("enter valid number");
                    isNumber = int.TryParse(Console.ReadLine(), out vendingChoice);
                    WaitForEnter();
                }
                if (vendingChoice == 1)
                {
                    subTotal = vendingChoice + item1Price;  // calculates the sub total cost
                    Console.Write("You have chosen {0}, it costs {1} credits. Your subtotal is {2} credits", item1, item1Price, item1Price);
                    WaitForEnter();
                }
                else if (vendingChoice == 2)
                {
                    subTotal = vendingChoice + item2Price;
                    Console.Write("You have chosen {0}, it costs {1} credits. Your subtotal is {2} credits", item2, item2Price, item2Price);
                    WaitForEnter();
                    // Console.WriteLine("How many would you like?");
                    //string choice = Console.ReadLine();
                    //double choice1 = 2;

                    //Console.WriteLine("you chose {0} times. Subtotal is {1} credits");
                }
                else if (vendingChoice == 3)
                {
                    subTotal = vendingChoice + item3Price;
                    Console.Write("You have chosen {0}, it costs {1} credits. Your subtotal is {2} credits", item3, item3Price, item3Price);
                    WaitForEnter();
                }
                else if (vendingChoice == 4)
                {
                    subTotal = vendingChoice + item4Price;
                    Console.Write("You have chosen {0}, it costs {1} credits. Your subtotal is {2} credits", item4, item4Price, item4Price);
                    WaitForEnter();
                }
                else if (vendingChoice == 5)
                {
                    subTotal = vendingChoice + item5Price;
                    Console.Write("You have chosen {0}, it costs {1} credits. Your subtotal is {2} credits", item5, item5Price, item5Price);
                    WaitForEnter();

                }
                else if (vendingChoice == 0)
                {
                    {
                        DrawHorizontalLine(80);
                        Console.WriteLine("*                                                                              *");
                        DrawText("     *                                Main Menu                                     *");
                        Console.WriteLine();
                        Console.WriteLine();
                        DrawText("     *          1] Add credits                                                      *");
                        Console.WriteLine();
                        DrawText("     *          2] Display product/s                                                *");
                        Console.WriteLine();
                        DrawText("     *          3] Checkout                                                         *");
                        Console.WriteLine();
                        DrawText("     *          0] Exit                                                             *");
                        Console.WriteLine();
                        Console.WriteLine("*                                                                              *");
                        DrawHorizontalLine(80);
                        Console.WriteLine();
                    }
                    WaitForEnter();
                    //Console.Clear();  // this line of code clears the displayed text
                    //break;            // break out of the loop if the condition is met

                    Console.Write("What option do you want to select? Select either 0, 1, 2 or 3");
                    Console.ReadLine();

                    if (mainMenuInput == "1")
                    {
                        // Ask the end user to input credits and validate if its entered correctly
                        Console.WriteLine("How many credits to add?");
                        string inputString = Console.ReadLine();
                        bool validCredits = false;
                        double credits;

                        do
                        {
                            validCredits = double.TryParse(inputString, out credits);
                            WaitForEnter();
                        } while (validCredits == false);

                        // an attempt to display current credits to the end user

                        if (validCredits == true)
                        {
                            Console.WriteLine("You have {0:0.00} credits", credits);
                            Console.WriteLine("Your current balance is: {0:0.00} credits", inputString);
                            WaitForEnter();
                            Console.Clear();
                        }
                    }
                    else if (mainMenuInput == "2")
                    {
                        {
                            DrawHorizontalLine(80);
                            Console.WriteLine("*                                                                              *");
                            DrawText("     *                                   Sub Menu                                   *");
                            Console.WriteLine();
                            Console.WriteLine();
                            DrawText("     *      1. Chocolate Bar      [0.80 credits]                                    *");
                            Console.WriteLine();
                            DrawText("     *      2. Soda Can           [0.60 credits]                                    *");
                            Console.WriteLine();
                            DrawText("     *      3. Soda Bottle        [1.25 credits]                                    *");
                            Console.WriteLine();
                            DrawText("     *      4. Crisps             [0.50 credits]                                    *");
                            Console.WriteLine();
                            DrawText("     *      5. Cookies            [1.15 credits]                                    *");
                            Console.WriteLine();
                            DrawText("     *      0. Main Menu                                                            *");
                            Console.WriteLine();
                            Console.WriteLine("*                                                                              *");
                            DrawHorizontalLine(80);
                        }
                        {
                            WaitForEnter();
                        }
                    }
                    else if (mainMenuInput == "3")
                    {
                        {
                            DrawHorizontalLine(80);
                            Console.WriteLine("*                                                                              *");
                            DrawText("     *                            Welcome to the checkout                           *");
                            Console.WriteLine();
                            Console.WriteLine("*                                                                              *");
                            //double finalCredit = 0;
                            //totalCost = item1Price + item2Price;
                            Console.WriteLine("Your subtotal is {0} + {1} = {2} credits", item1Price, item2Price, totalCost);
                            Console.ReadLine();
                            //Console.WriteLine("You have {0:0.00} credits", finalCredit);
                            //Console.WriteLine("Your final balance is: {0:0.00} credits", finalCredit);
                            WaitForEnter();
                            Console.Clear();
                            WaitForEnter();
                            DrawHorizontalLine(80);
                        }
                        Console.ReadLine();
                        Console.WriteLine();
                        break;

                    }
                    else if (mainMenuInput == "0")
                    {
                        {
                            DrawHorizontalLine(80);
                            Console.WriteLine("*                                                                              *");
                            Console.WriteLine("     *                   Thank you for using our service                   *");
                            Console.WriteLine();
                            Console.WriteLine("*                                                                              *");
                            DrawHorizontalLine(80);
                        }

                    }

                }
                else if (vendingChoice > 6)
                {
                    Console.WriteLine("Unrecognized number pressed. Please select either number from 0 to 6");
                    WaitForEnter();
                }
                Console.WriteLine();

                // Check for a response and check if its outside the range of possible responses or not
                Console.Write("Do you want to add to your order? (y for yes and n for no)");
                yesNo = Console.ReadLine().ToLower();
                WaitForEnter();

                // if the end users response is not equal to y or n
                // Display an error message

                while (yesNo != "y" && yesNo != "n")  
                {
                    Console.WriteLine("Sorry, you must press 'y' for yes or 'n' for no.");
                    Console.Write("Do you want to choose another item? (y/n) ");
                    yesNo = Console.ReadLine().ToLower();
                    WaitForEnter();
                }
                Console.WriteLine();
            } while (yesNo == "y");
            Console.Clear();

            // Ask the end user if they want to proceed to the checkout

            
            string finalCheckout;
            do
            {
                
                double finalCredit = 0;

                double item01Price = 0.80;
                double item02Price = 0.60;
            
                Console.Write("Do you want to proceed to checkout?");
                finalCheckout = Console.ReadLine().ToLower();       // convert end users input to lower case
                WaitForEnter();

                Console.Write("Please press any number to proceed ");
                bool isNumber = int.TryParse(Console.ReadLine(), out vendingChoice);
                WaitForEnter();
                while (!isNumber)
                {
                    Console.Write("enter valid number");
                    isNumber = int.TryParse(Console.ReadLine(), out vendingChoice);
                    WaitForEnter();
                }

                if (finalCheckout == "y")
                {

                    double totalCost2 = 0;
                    totalCost2 = item01Price + item02Price;
                    Console.WriteLine("Your subtotal is {0} + {1} = {2} credits", item01Price, item02Price, totalCost2);
                    Console.WriteLine("You have {0:0.00} credits", finalCredit);
                    Console.WriteLine("Your final balance is: {0:0.00} credits", finalCredit);
                    Console.WriteLine("Thank you for using our service, future updates to the system are coming soon");
                    DrawHorizontalLine(80);
                    WaitForEnter();
                }
                while (finalCheckout != "y" && finalCheckout != "n")
                {
                    Console.WriteLine("Sorry, you must press 'y' for yes or 'n' for no.");
                    Console.Write("Do you want to choose another item? (y/n) ");
                    finalCheckout = Console.ReadLine().ToLower();
                    WaitForEnter();
                }
            } while (finalCheckout == "y");
        }
    }
}