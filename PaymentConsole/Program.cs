using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;

namespace PaymentConsole
{
    internal class Program
    {
        // Default folder    
        static readonly string rootFolder = @"C:\Temp\";
        //Default file. 
        static readonly string textFile = @"C:\Temp\ServerStatus.txt";

        static void Main(string[] args)
        {
            if (File.Exists(textFile))
            {
                // Read entire text file content in one string    
                string text = File.ReadAllText(textFile);

                if(text.ToLower() == "down")
                {
                    Console.WriteLine("Your selected Payment Gateway is down and low success rate.");
                }
            }

            Console.WriteLine("Enter the total amount to be paid: ");
            double amount = Convert.ToDouble(Console.ReadLine());
            Console.WriteLine("Enter the card number: ");
            string cardNumber = Console.ReadLine();
            Console.WriteLine("Enter the expiry date (MM/YYYY): ");
            string expiryDate = Console.ReadLine();
            Console.WriteLine("Enter the CVV: ");
            string cvv = Console.ReadLine();

            Console.WriteLine("Processing payment...");

            // Placeholder logic for payment processing
            // Need to check the PAYMENT SERVER STATUS here (UP/DOWN). Based on that foloowing status can be implemented

            bool paymentSuccessful = true;

            if (paymentSuccessful)
            {
                Console.WriteLine("Payment of " + amount + " successful.");
            }
            else
            {
                Console.WriteLine("Payment failed. Please try again.");
            }

            Console.ReadLine();
        }
    }
}
