using Calculator.Scripts.Interface;


namespace Calculator.Scripts.Operations
{
    public class Addition : IOperation
    {
        public string OperationName => "Add";

        public double Calculate(double num1, double num2) => num1 + num2;
        
    }
}
