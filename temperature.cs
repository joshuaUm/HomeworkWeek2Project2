/// Homework No. 2		Project No. 1
/// File Name: temperature.cs
/// @author: Joshua Um
/// Date:  August 30, 2021
///
/// Problem Statement: Take a given temperature in Fahrenheit and convert it to Celsius, /// rounded to one decimal point.
/// 
/// 
/// Overall Plan:
/// 1. Prompt user for temperature in Fahrenheit.
/// 2. Convert given degrees in Fahrenheit to Celsisus  (5 * ( degreesF - 32)) / 9.0).
/// 3. Print degrees in Celsius rounded to one decimal point.

using System;

class Program {
  public static void Main (string[] args) {
    int degreesF;
    double degreesC;
    
    //Prompt user for degrees in Fahrenheit.
    Console.WriteLine("Enter a temperature in degrees Fahrenheit : ");
    degreesF = Int32.Parse(Console.ReadLine());

    //Convert Fahrenheit to Celsius.
    degreesC = (5 * ( degreesF - 32)) / 9.0;

    //Print results with degrees rounded to one decimal point.
    Console.WriteLine("Temperature in degrees Celsius : " + Math.Round(degreesC,1));



  }
}
