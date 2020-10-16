using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Diagnostics.CodeAnalysis;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

public class NumericFunction
{
    public int Add(params int[] arguments)
    {
        int sum = 0;
        for(int i = 0; i < arguments.Length; i++)
        {
            sum += arguments[i];
        }
        return sum;
    }

    public int Subtract(params int[] arguments)
    {
        int sum = 0;
        for(int i = 0; i < arguments.Length; i++)
        {
            sum -= arguments[i];
        }
        return sum;
    }

    public int Divide(params int[] arguments)
    {
        int quotient = arguments[0] / arguments[1];
        for (int i = 2; i < arguments.Length; i++)
        {
            quotient = quotient / arguments[i];
        }
        return quotient;
        
    }
    public int Multiply(params int[] arguments)
    {
        int product = 1;
        for(int i = 0; i < arguments.Length; i++)
        {
            product = product * arguments[i];
        }
        return product;
        
        
    }
    public int Max(params int[] arguments)
    {
        int max;
        max = arguments.Max();
        return max;
    }

    public int Min(params int[] arguments)
    {
        int min;
        min = arguments.Min();
        return min;
    }

    public int IsEven(int argument)
    {
        int flag = 0;
        if (argument % 2 == 0)
        {
            flag = 1;
        }
        return flag;
    }
    public int IsOdd(int argument)
    {
        int flag = 1;
        if (argument % 2 == 0)
        {
            flag = 0;
        }
        return flag;
        
    }

    public int IsPrime(int argument)
    {
        int flag = 1;
        for(int i = 2; i < argument / 2; i++)
        {
            if (argument % i == 0)
            {
                flag = 0;
                
            }
        }
        return flag;
    }
    public string PrintEven(int range)
    {
        string evenNumbers="\n";
        for(int i = 2; i < range - 1; i += 2)
        {
            evenNumbers = evenNumbers + " "+Convert.ToString(i);
        }
        return evenNumbers;
    }

    public string PrintOdd(int range)
    {
        string oddNumbers = "\n";
        for (int i = 1; i < range - 1; i += 2)
        {
            oddNumbers = oddNumbers + " " + Convert.ToString(i);
        }
        return oddNumbers;
    }
    public void PrintPrime(int range)
    {
        for (int i = 2; i < range - 1; i++)
        {
            for(int j = 2; j < i / 2; j++)
            {
                if ( i% j == 0)
                {
                    continue;

                    
                }
                else
                {
                    Console.WriteLine(i);
                }
            }
        }
    }

    public string PrintTable(int argument)
    {
        string table = "\n";
        for(int i = 1; i <= 10; i++)
        {
            table = table+"\n" + Convert.ToString(argument) + " " + "x" + " " + Convert.ToString(i) + " " + "=" + " " + Convert.ToString(i * argument);
        }
        return table;
    }





}

