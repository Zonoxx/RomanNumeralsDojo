using System.Collections.Generic;
using System;

namespace RomanNumeralsDojo;

public class NumeralsConverter : INumeralsConverter
{
    public string UserInput;
    public bool isInputValid;
    public readonly Dictionary Numerals = new Dictionary<char, int>()
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
        return UserInput;
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

    public int convertRomanNumeralToInt(string input)
    {
        UserInput = input;
        int result = 0;
        int previousKeyValue = 0;

        foreach(char numeral in UserInput)
        {
            keyValue = Numerals[numeral];
            if(previousKeyValue != 0 && keyValue > previousKeyValue)
            {
                result -= previousKeyValue*2;
            }
            
            result += keyValue;
            previousKeyValue = keyValue;
        }
        return result;
        
    }
    //return true if input only contains I, V, X, L, C, D, M && XLIV  LXXXIX


}