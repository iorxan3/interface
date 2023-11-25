using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

public class Calculation : ICalculation
{
    public double Calculate(double num1, double num2)
    {
        double result = num1 + num2;
        return result;
    }
}
