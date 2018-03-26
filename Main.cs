//DYLAN GRANDJEAN
//Tip Program using Class
//Program designed to calulate the tip amount of a bill after tax have been substracted
//March 2nd, 2016

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TipCalculationApp
{
    class Main
    {
        static void Main(string[] args)
        {
            //Instantiate variables
            double totalBill,
                   tipPercentage,
                   taxAmount,
                   tipAmount;

            //Display instruction to the user
            displayInstruction();

            //Get the total bill amount
            Console.Write("Enter total bill: ");
            totalBill = double.Parse(Console.ReadLine());
            //Get the tip percentage
            Console.Write("Enter tip percent: %");
            tipPercentage = (double.Parse(Console.ReadLine()) / 100);

            //Instantiate the CalculateTip class
            CalculateTip calcTip = new CalculateTip(totalBill, tipPercentage);
            taxAmount = calcTip.calculateTaxAmount();
            tipAmount = calcTip.calculateTipAmount();

            //Display the results
            Console.WriteLine("*********************************\n" +
                              "Total bill\t{0:c}\n" +
                              "Tax amount\t{1:c}\n" +
                              "Tip percent\t{2:p}\n" +
                              "Tip amount\t{3:c}\n" +
                              "*********************************",
                              totalBill, taxAmount, tipPercentage, tipAmount);
            Console.Read();
        }

        private static void displayInstruction()
        {
            Console.WriteLine("*********************************\n" +
                              "This program is designed to help\n" +
                              "you calculate the tip amount for\n" +
                              "your bill.\n\n" +
                              "Please enter both the total amount\n" +
                              "for your bill and the tip\n" +
                              "percentage below.\n" +
                              "*********************************");
        }
    }
}
