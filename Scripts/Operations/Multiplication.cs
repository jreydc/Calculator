using Calculator.Scripts.Interface;

namespace Calculator.Scripts.Operations
{
    public class Multiplication : IOperation
    {
        public double Calculate(double num1, double num2) => num1 * num2;
        public string OperationName => "Multiply";
    }
}
