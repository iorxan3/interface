class Program
{
    static void Main()
    {
        ICalculation calculation = new Calculation(); 
        CalculatorService calculatorService = new CalculatorService(calculation); 
        double result1 = calculatorService.PerformCalculation(7, 3); 
        double result2 = calculatorService.PerformCalculation(8, 2); 
        
        Console.WriteLine("Result 1: " + result1);
        Console.WriteLine("Result 2: " + result2);
    }
}
