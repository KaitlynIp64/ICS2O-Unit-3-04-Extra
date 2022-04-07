// Created by: Kaitlyn Ip
// Created on: Apr 2022
//
// This program accepts user input

using System;

class Program
{
    public static void Main(string[] args)
    {
        // This function accepts user input
        double fahrenheit;
        double celsius;
        //input
        Console.WriteLine("This program converts fahrenheit to celsius.");
        Console.WriteLine("");
        Console.WriteLine("Formula = °C = (A°F - 32) x 5/9");
        Console.WriteLine("");
        Console.Write("Enter Fahrenheit : ");
        fahrenheit = Convert.ToInt32(Console.ReadLine());

        //process
        celsius = ((fahrenheit - 32) * 5.0 / 9.0);

        //output
        Console.WriteLine("");
        Console.Write("The temperature in Celsius is: " + celsius.ToString("0.00") + " °C");
        Console.ReadKey();
        Console.WriteLine("\nDone.");
    }
}