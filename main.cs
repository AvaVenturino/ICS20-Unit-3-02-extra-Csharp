// Created by: Ava Venturino
// Created on: March 22 2022
//
// This program accepts user input

using System;

class Program
{
    public static void Main(string[] args)
    {
        // This function accepts user input
        int length;
        int width;
        int height;

        Console.WriteLine("This program finds the volume of a pyramid.");
        Console.WriteLine("");
        Console.WriteLine("Formula = (length x width x height) / 3.");
        Console.WriteLine("");
        Console.Write("Enter the length of the pyramid (mm): ");
        length = Convert.ToInt32(Console.ReadLine());
        Console.Write("Enter the width of the pyramid (mm): ");
        width = Convert.ToInt32(Console.ReadLine());
        Console.Write("Enter the height of the pyramid (mm): ");
        height = Convert.ToInt32(Console.ReadLine());

        Double volume = (length * width * height) / 3;

        Console.WriteLine("");
        Console.Write("Volume of the pyramid = " + volume + " mm³");
        Console.ReadKey();
        Console.WriteLine("\nDone.");
    }
}