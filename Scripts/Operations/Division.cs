using Calculator.Scripts.Interface;

namespace Calculator.Scripts.Operations
{
    public class Division : IOperation
    {
        public double Calculate(double num1, double num2)
        {
            if (num2 == 0) throw new DivideByZeroException("Cannot divide by zero.");
            return num1 / num2;
        }
        public string OperationName => "Divide";
    }
}
