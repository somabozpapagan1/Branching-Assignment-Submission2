// Package Express Shipping Rate Calculator
// Created by: Sarah Johnson
// Last modified: March 2024
using System;

namespace PackageExpress
{
    class ShippingCalculator
    {
        static void Main(string[] args)
        {
            // Initialize the program with a welcome message
            Console.WriteLine("Welcome to Package Express. Please follow the instructions below.");

            // Request and validate package weight
            Console.WriteLine("Please enter the package weight:");
            decimal itemWeight = decimal.Parse(Console.ReadLine());

            // Weight validation check
            if (itemWeight > 50)
            {
                Console.WriteLine("Package too heavy to be shipped via Package Express. Have a good day.");
                return;
            }

            // Collect package measurements
            Console.WriteLine("Please enter the package width:");
            decimal boxWidth = decimal.Parse(Console.ReadLine());

            Console.WriteLine("Please enter the package height:");
            decimal boxHeight = decimal.Parse(Console.ReadLine());

            Console.WriteLine("Please enter the package length:");
            decimal boxLength = decimal.Parse(Console.ReadLine());

            // Sum up all dimensions
            decimal dimensionSum = boxWidth + boxHeight + boxLength;

            // Size validation check
            if (dimensionSum > 50)
            {
                Console.WriteLine("Package too big to be shipped via Package Express.");
                return;
            }

            // Compute shipping cost using the formula
            // Cost = (width * height * length * weight) / 100
            decimal deliveryCost = (boxWidth * boxHeight * boxLength * itemWeight) / 100;

            // Show the calculated shipping cost
            Console.WriteLine($"Your estimated total for shipping this package is: ${deliveryCost:F2}");
            Console.WriteLine("Thank you!");
        }
    }
} 