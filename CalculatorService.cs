using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

public class CalculatorService
{
    private readonly ICalculation _calculation;

    public CalculatorService(ICalculation calculation)
    {
        _calculation = calculation;
    }

    public double PerformCalculation(double num1, double num2)
    {
        return _calculation.Calculate(num1, num2);
    }
}
