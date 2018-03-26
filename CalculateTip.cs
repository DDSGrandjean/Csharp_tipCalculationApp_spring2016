using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TipCalculationApp
{
    class CalculateTip
    {
        //Instantiate constant and variables
        private const double TAX = 0.08;

        private double taxAmount,
                       tipAmount,
                       bill,
                       totalBill,
                       tipPercentage;

        //Default constructor
        public CalculateTip(){}

        //Variable instantiator
        public CalculateTip(double atotalBill, double atipPercentage)
        {
            totalBill = atotalBill;
            tipPercentage = atipPercentage;
        }
        //Get  and return the tax amount
        public double calculateTaxAmount()
        {
            taxAmount = totalBill * TAX;

            return taxAmount;
        }

        //Calculate and return the tip amount
        public double calculateTipAmount()
        {
            bill = totalBill - taxAmount;
            tipAmount = bill * tipPercentage;
            return tipAmount;
        }
    }
}
