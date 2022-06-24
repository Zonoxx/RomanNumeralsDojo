using System.Collections.Generic;
using System;

namespace RomanNumeralsDojo;

public class numeralsConverter
{
    public string UserInput;
    public bool isInputValid;
    public readonly Dictionary numerals = new Dictionary<char, int>()
    {
        {'I', 1},
        {'V', 5},
        {'X', 10},
        {'L', 50},
        {'C', 100},
        {'D', 500},
        {'M', 1000}
    };

    public numeralsConverter()
    {
        
    }

    public string getUserInput()
    {
        Console.WriteLine("Welcome to the Roman Numerals Converter.\nThis converter converts your Roman Numerals into number values.");
        UserInput = Console.ReadLine("Please enter your numeral: ").ToUpper;
    }
    
    private bool checkForValidInput()
    {
        foreach(char letter in UserInput)
        {
            if (!numerals.ContainsKey(letter))
            {
                return false;
            }
            continue;
        }

    }
    //return true if input only contains I, V, X, L, C, D, M && XLIV  LXXXIX


}