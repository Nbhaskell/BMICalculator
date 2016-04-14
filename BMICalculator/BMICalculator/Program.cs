using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BMICalculator
{
    class Program
    {
        static void Main(string[] args)
        {
            decimal feet;
            decimal inches;
            decimal weight;
            decimal bmi;
            decimal result;
            string gender;

            // get user input
            Console.WriteLine("Enter your gender (male or female): ");
            gender = Console.ReadLine();
            Console.WriteLine("Enter height in feet: ");
            feet = Decimal.Parse(Console.ReadLine());
            Console.WriteLine("How many inches: ");
            inches = Decimal.Parse(Console.ReadLine());
            Console.WriteLine("Enter weight in pounds: ");
            weight = Decimal.Parse(Console.ReadLine());

            // calculations
            inches += feet * 12;
            decimal height = inches * (decimal)0.0254;
            decimal weightdecimal = weight * (decimal)0.453592;
            bmi = weightdecimal / (height * height);

            // display
            Console.WriteLine("Your Body Mass Index is: {0}", bmi.ToString());

            if (bmi < 19 & gender == "female")
            { Console.WriteLine("-> Underweight"); }
            if (bmi >= 19 & bmi <= 24 & gender == "female")
            { Console.WriteLine("-> Normal"); }
            if (bmi > 24 & gender == "female")
            { Console.WriteLine("-> Overweight"); }

            if (bmi < 20 & gender == "male")
            { Console.WriteLine("-> Underweight"); }
            if (bmi >= 20 & bmi <= 25 & gender == "male")
            { Console.WriteLine("-> Normal"); }
            if (bmi > 25 & gender == "male")
            { Console.WriteLine("-> Overweight"); }

            Console.ReadLine(); 
        }
    }
}
