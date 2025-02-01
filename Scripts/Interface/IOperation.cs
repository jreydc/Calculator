namespace Calculator.Scripts.Interface
{
    public interface IOperation
    {
        double Calculate(double num1, double num2);
        string OperationName { get; }
    }
}
